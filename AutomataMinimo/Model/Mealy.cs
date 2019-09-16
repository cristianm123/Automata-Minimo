using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataMinimo.Model
{
    //Autómata de Mealy, hereda de Machine.
    class Mealy : Machine
    {
        public Mealy(char[,] diagram, List<char> l, List<char> o, List<char> t, char q1) : base(diagram, l, o, t, q1)
        {
            //Lee la matriz que representa la tabla de estados digitada por el usuario y la traduce al autómata.
            for (int i = 0; i < t.Count; i++)
            {
                states.Add(t[i], new MealyState(t[i]));
            }
            for (int i = 0; i < diagram.GetLength(0); i++)
            {
                MealyState s = (MealyState)states.ElementAt(i).Value;
                for (int j = 0; j < diagram.GetLength(1); j+=2)
                {
                    s.getAdj().Add(alphaIn[j/2], new KeyValuePair<MealyState, char>((MealyState)states[diagram[i, j]], diagram[i, j+1]));
                }
            }
        }
        //Marca los estados que se pueden alcanzar desde el estado inicial. Obtener el autómata conexo equivalente.
        public void reachableStates()
        {
            ((MealyState)states[state1]).visitStates();
            List<char> l = new List<char>();
            foreach (MealyState m in states.Values)
            {
                if (!m.getReach())
                {
                    l.Add(m.getId());
                }
            }
            foreach (char m in l)
            {
                states.Remove(m);
            }
        }
        //Implementación del algoritmo de minimización de autómatas de estado finito.
        public void reduceMachine()
        {
            //Partición inicial p1, se agrupan los estados por salida.
            List<List<State>> partitionk = states.Values.ToList()
            .GroupBy(x => ((MealyState)x).adjOuts()).Select(x=> x.ToList()).ToList();
            List<List<State>> partitionk1 = new List<List<State>>();
            bool notEqual = true;
            //Mientras pk sea distinto de pk+1
            while (notEqual)
            {
                //Algoritmo de particionamiento.
                foreach (var parti in partitionk)
                {
                    MealyState st1 = (MealyState)parti.First();
                    List<State> newparti = new List<State>();
                    foreach (MealyState st2 in parti.Skip(1))
                    {
                        bool yes = true;
                        foreach (char ch in alphaIn)
                        {
                            if (!partitionk.Any(x => x.Contains(st1.getAdj()[ch].Key) && x.Contains(st2.getAdj()[ch].Key)))
                            {
                                yes = false;
                                break;
                            }
                        }
                        if (!yes)
                        {
                            newparti.Add(st2);
                        }
                    }
                    if (newparti.Count != 0)
                    {
                        partitionk1.Add(parti.Except(newparti).ToList());
                        partitionk1.Add(newparti);
                    }
                    else
                    {
                        partitionk1.Add(parti);
                    }
                }
                notEqual = !partitionk.SequenceEqual(partitionk1);
                partitionk = partitionk1;
                partitionk1 = new List<List<State>>();
            }
            //Cada partición representa un estado nuevo.
            int i = 0;
            Dictionary<char, State> statesnew = new Dictionary<char, State>();
            foreach (var newst in partitionk)
            {
                char id = states.Keys.ElementAt(i);
                statesnew.Add(id, new MealyState(id));
                i++;
            }
            
            foreach (char c in alphaIn)
            {
                for (int h = 0; h < partitionk.Count; h++)
                {
                    var p = partitionk[h];
                    //Se encuentra en qué partición está el estado inicial y se marca como nuevo estado inicial.
                    if (p.Contains(states[state1]))
                    {
                        state1 = statesnew.ElementAt(h).Value.getId();
                    }
                    //Se encuentran los sucesores de cada estado.
                    MealyState s = ((MealyState)p.First()).getAdj()[c].Key;
                    char value = ((MealyState)p.First()).getAdj()[c].Value;
                    for (int l = 0; l < partitionk.Count; l++)
                    {
                        if (partitionk[l].Contains(s))
                        {
                            ((MealyState)statesnew.ElementAt(h).Value).getAdj()
                                .Add(c, new KeyValuePair<MealyState, char>((MealyState)statesnew.ElementAt(l).Value, value));
                            break;
                        }
                    }
                }
            }
            //Se actualiza el autómata.
            states = statesnew;

        }

        //Se traduce el autómata a la tabla de estados equivalente.
        public char[,] getMat()
        {
            char[,] mat = new char[states.Count, 2 * alphaIn.Count];
            int i = 0;
            foreach (MealyState m in states.Values)
            {
                int j = 0;
                foreach (KeyValuePair<MealyState, char> ad in m.getAdj().Values)
                {
                    mat[i, j] = ad.Key.getId();
                    mat[i, j+1] = ad.Value;
                    j+=2;
                }
                i++;
            }
            return mat;
        }
    }

    
}
