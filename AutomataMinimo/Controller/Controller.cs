using AutomataMinimo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomataMinimo.Controller
{
    //Intermediario entre la interfaz y el modelo.
    public class Controller
    {
        //Conexión con la interfaz.
        private Inter inter;
        //Conexión con el modelo.
        private Machine machine;

        public Controller(Inter i)
        {
            inter = i;
        }

        public void setMachine(Machine m)
        {
            machine = m;
        }
        //Recibe la tabla de estados de un autómata de Moore de la interfaz y se la pasa al modelo. Recibe el autómata mínimo equivalente
        //y se lo pasa a la interfaz.
        public void minimiseMooreMachine()
        {
            DataGridView Matrix = inter.getMoore().getMatrix();
            ListView AlphaInList = inter.getMoore().getAlphaIn();
            ListView AlphaOutList = inter.getMoore().getAlphaOut();
            ListView StatesList = inter.getMoore().getStates();
            char q1 = inter.getMoore().getState1();
            char[,] mat = new char[Matrix.RowCount, Matrix.ColumnCount];
            for (int i = 0; i < Matrix.RowCount; i++)
            {
                for (int j = 0; j < Matrix.ColumnCount; j++)
                {
                    var a = Matrix[j, i].Value;
                    mat[i, j] = Convert.ToChar(Matrix[j, i].Value.ToString());
                }
            }
            char[] alphain = new char[AlphaInList.Items.Count];
            int l = 0;
            foreach (ListViewItem a in AlphaInList.Items)
            {
                alphain[l] = Convert.ToChar(a.Text);
                l++;
            }
            l = 0;
            char[] alphaout = new char[AlphaOutList.Items.Count];
            foreach (ListViewItem a in AlphaOutList.Items)
            {
                alphaout[l] = Convert.ToChar(a.Text);
                l++;
            }
            l = 0;
            char[] states = new char[StatesList.Items.Count];
            foreach (ListViewItem a in StatesList.Items)
            {
                states[l] = Convert.ToChar(a.Text);
                l++;
            }
            
            machine = new Moore(mat, alphain.ToList(), alphaout.ToList(), states.ToList(), q1);
            ((Moore)machine).reachableStates();
            ((Moore)machine).reduceMachine();
            char[,] matr = ((Moore)machine).getMat();
            Matrix = inter.getMoore().getNewMatrix();
            Matrix.ColumnCount = matr.GetLength(1);
            Matrix.RowCount = matr.GetLength(0);
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Matrix[j, i].Value = matr[i, j];
                }
            }
            Matrix.Update();
        }
        //Recibe la tabla de estados de un autómata de Mealy de la interfaz y se la pasa al modelo. Recibe el autómata mínimo equivalente
        //y se lo pasa a la interfaz.
        public void minimiseMealyMachine()
        {
            DataGridView Matrix = inter.getMealy().getMatrix();
            ListView AlphaInList = inter.getMealy().getAlphaIn();
            ListView AlphaOutList = inter.getMealy().getAlphaOut();
            ListView StatesList = inter.getMealy().getStates();
            char q1 = inter.getMealy().getState1();
            char[,] mat = new char[Matrix.RowCount, Matrix.ColumnCount];
            for (int i = 0; i < Matrix.RowCount; i++)
            {
                for (int j = 0; j < Matrix.ColumnCount; j++)
                {
                    var a = Matrix[j, i].Value;
                    mat[i, j] = Convert.ToChar(Matrix[j, i].Value.ToString());
                }
            }
            char[] alphain = new char[AlphaInList.Items.Count];
            int l = 0;
            foreach (ListViewItem a in AlphaInList.Items)
            {
                alphain[l] = Convert.ToChar(a.Text);
                l++;
            }
            l = 0;
            char[] alphaout = new char[AlphaOutList.Items.Count];
            foreach (ListViewItem a in AlphaOutList.Items)
            {
                alphaout[l] = Convert.ToChar(a.Text);
                l++;
            }
            l = 0;
            char[] states = new char[StatesList.Items.Count];
            foreach (ListViewItem a in StatesList.Items)
            {
                states[l] = Convert.ToChar(a.Text);
                l++;
            }
            
            machine = new Mealy(mat, alphain.ToList(), alphaout.ToList(), states.ToList(), q1);
            ((Mealy)machine).reachableStates();
            ((Mealy)machine).reduceMachine();
            char[,] matr = ((Mealy)machine).getMat();
            Matrix = inter.getMealy().getNewMatrix();
            Matrix.ColumnCount = matr.GetLength(1);
            Matrix.RowCount = matr.GetLength(0);
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    Matrix[j, i].Value = matr[i, j];
                }
            }
            Matrix.Update();
        }
        
    }
}
