using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataMinimo.Model
{
    //Contiene todas las propiedades comunes de los estados de Mealy y de Moore.
    public abstract class State
    {
        //Identificador del estado.
        private char id;
        //Bool que indica si el estado fue visitado.
        private bool reach;
        public State(char id)
        {
            this.id = id;
            reach = false;
        }

        public bool getReach()
        {
            return reach;
        }

        public void setReach()
        {
            reach = true;
        }

        public char getId()
        {
            return id;
        }

        public override string ToString()
        {
            return id+"";
        }
    }
}
