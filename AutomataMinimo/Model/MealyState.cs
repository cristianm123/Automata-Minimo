using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataMinimo.Model
{
    //Estado de Mealy. Hereda de estado.
    class MealyState : State
    {
        //Diccionario de estímulo-Pareja(El estado y la salida de la transición).
        private IDictionary<char, KeyValuePair<MealyState, char>> adj_states;
        public MealyState(char id):base(id)
        {
            adj_states = new Dictionary<char, KeyValuePair<MealyState, char>>();
        }

        public IDictionary<char, KeyValuePair<MealyState, char>> getAdj()
        {
            return adj_states;
        }

        //Visita a todos los estados adyacentes y se marca a sí mismo como visitado.
        public void visitStates()
        {
            setReach();
            foreach (MealyState st in adj_states.Values.Select(x=> x.Key))
            {
                if (!st.getReach())
                {
                    st.visitStates();
                }
            }
        }

        //Devuelve una lista con las salidas que tienen todas sus transiciones.
        public string adjOuts()
        {
            string ret = "";
            var t = adj_states.Values.Select(x => x.Value);
            foreach(var f in t)
            {
                ret = string.Concat(ret, f);
            }
            return ret;
        }
    }
}
