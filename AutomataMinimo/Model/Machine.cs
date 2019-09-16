using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataMinimo.Model
{
    //Tiene las propiedad comunes de los autómatas
    public abstract class Machine
    {
        //Diccionario de identificador-estado.
        public Dictionary<char, State> states;
        //Alfabeto de entrada y de salida.
        public List<char> alphaIn, alphaOut;
        //Identificador del estado inicial.
        public char state1;

        public Machine(char[,] diagram, List<char> i, List<char> o, List<char> s, char q1)
        {
            states = new Dictionary<char, State>();
            alphaIn = i;
            alphaOut = o;
            state1 = q1;
        }

        public Dictionary<char, State> getStates()
        {
            return states;
        }
        public List<char> getAlphaIn()
        {
            return alphaIn;
        }
        public List<char> getAlphaOut()
        {
            return alphaOut;
        }

        public int getState1()
        {
            return state1;
        }
       
    }
}
