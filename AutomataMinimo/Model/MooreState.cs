using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataMinimo.Model
{
    //Estado de Moore. Hereda de estado.
    class MooreState : State
    {
        //Diccionario de estímulo-estado.
        private IDictionary<char, MooreState> adj_states;
        //Salida del estado.
        private char outt;

        public MooreState(char id, char outt):base(id)
        {
            adj_states = new Dictionary<char, MooreState>();
            this.outt = outt;
        }

        public IDictionary<char, MooreState> getAdj()
        {
            return adj_states;
        }

        public char getOut()
        {
            return outt;
        }
        //Visita a todos los estados adyacentes y se marca a sí mismo como visitado.
        public void visitStates()
        {
            setReach();
            foreach(MooreState st in adj_states.Values)
            {
                if(!st.getReach())
                {
                    st.visitStates();
                }
            }
        }
    }
}
