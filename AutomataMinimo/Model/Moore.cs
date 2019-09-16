using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataMinimo.Model
{
    //Autómata de Moore, hereda de Machine.
    class Moore : Machine
    {

        public Moore(char[,] diagram, List<char> l, List<char> o, List<char> t, char q1):base(diagram, l, o, t, q1)
        {
            states = new Dictionary<char, State>();
            alphaIn = l;
            alphaOut = o;
            //Lee la matriz que representa la tabla de estados digitada por el usuario y la traduce al autómata.
            for (int i = 0; i < diagram.GetLength(0); i++)
            {
                states.Add(t[i] , new MooreState(t[i], diagram[i, diagram.GetLength(1) - 1]));
               
             }
            for (int i = 0; i < diagram.GetLength(0); i++)
            {
                MooreState s = (MooreState)states.ElementAt(i).Value;
                for (int j = 0; j < diagram.GetLength(1) - 1; j++)
                { 
                    s.getAdj().Add(alphaIn[j], (MooreState)states[diagram[i, j]]);
                }
            }
        }
        //Marca los estados que se pueden alcanzar desde el estado inicial. Obtener el autómata conexo equivalente.
        public void reachableStates()
        {
            ((MooreState)states[state1]).visitStates();
            List<char> l = new List<char>();
            foreach(MooreState m in states.Values)
            {
                if(!m.getReach())
                {
                    l.Add(m.getId());
                }
            }
            foreach(char m in l)
            {
                states.Remove(m);
            }
        }
        //Implementación del algoritmo de minimización de autómatas de estado finito.
        public void reduceMachine()
        {
            //Partición inicial p1, se agrupan los estados por salida.
            List<List<State>> partitionk = new List<List<State>>();
            foreach(char c in alphaOut)
            {
                partitionk.Add(states.Values.Where(x => ((MooreState)x).getOut() == c).ToList());
            }
            List<List<State>> partitionk1 = new List<List<State>>();
            bool areEqual = true;
            //Mientras pk sea distinto de pk+1
            while (areEqual)
            {
                //Algoritmo de particionamiento.
                foreach (var parti in partitionk)
                {
                    MooreState st1 = (MooreState)parti.First();
                    List<State> newparti = new List<State>();
                    foreach (MooreState st2 in parti.Skip(1))
                    {
                        bool yes = true;
                        foreach (char ch in alphaIn)
                        {
                            if (!partitionk.Any(x => x.Contains(st1.getAdj()[ch]) && x.Contains(st2.getAdj()[ch])))
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
                areEqual = !partitionk.SequenceEqual(partitionk1);
                partitionk = partitionk1;
                partitionk1 = new List<List<State>>();
            }
            int i = 0;
            //Cada partición representa un estado nuevo.
            Dictionary<char, State> statesnew = new Dictionary<char, State>();
            foreach (var newst in partitionk)
            {
                char id = states.Keys.ElementAt(i);
                statesnew.Add(id, new MooreState(id, ((MooreState)newst[0]).getOut()));
                i++;
            }
            foreach(char c in alphaIn)
            {
                for(int h = 0; h < partitionk.Count; h++)
                {
                    //Se encuentra en qué partición está el estado inicial y se marca como nuevo estado inicial.
                    var p = partitionk[h];
                    if (p.Contains(states[state1]))
                    {
                        state1 = statesnew.ElementAt(h).Value.getId();
                    }
                    //Se encuentran los sucesores de cada estado.
                    MooreState s = ((MooreState)p.First()).getAdj()[c];
                    for(int l = 0; l < partitionk.Count; l++)
                    {
                        if(partitionk[l].Contains(s))
                        {
                            ((MooreState)statesnew.ElementAt(h).Value).getAdj().Add(c, (MooreState)statesnew.ElementAt(l).Value);
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
            char[,] mat = new char[states.Count, alphaIn.Count+1];
            int i = 0;
            foreach(MooreState m in states.Values)
            {
                int j = 0;
                foreach(MooreState ad in m.getAdj().Values)
                {
                    mat[i, j] = ad.getId();
                    j++;
                }
                mat[i, j] = m.getOut();
                i++;
            }
            return mat;
        }
    }
}
