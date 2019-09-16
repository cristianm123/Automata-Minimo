using AutomataMinimo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomataMinimo.Interface
{
    public partial class MealyInterface : Form
    {
        Inter inter;
        public MealyInterface(Inter f)
        {
            InitializeComponent();
            inter = f;
        }

        public DataGridView getMatrix()
        {
            return Matrix;
        }

        public ListView getAlphaIn()
        {
            return AlphaInList;
        }

        public ListView getAlphaOut()
        {
            return AlphaOutList;
        }

        public ListView getStates()
        {
            return StatesList;
        }
        private void AddState_Click(object sender, EventArgs e)
        {
            StatesList.Items.Add(TextBox.Text);
            TextBox.Clear();
            comboBox1.DataSource = StatesList.Items.Cast<ListViewItem>().Select(x => x.Text).ToList();
            TextBox.Focus();
        }

        private void AddAlphaIn_Click(object sender, EventArgs e)
        {
            AlphaInList.Items.Add(TextBox.Text);
            TextBox.Clear();
            TextBox.Focus();
        }

        private void AddAlphaOut_Click(object sender, EventArgs e)
        {
            AlphaOutList.Items.Add(TextBox.Text);
            TextBox.Clear();
            TextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matrix.ColumnCount = 2*AlphaInList.Items.Count;
            Matrix.RowCount = StatesList.Items.Count;
            int i = 0;
            foreach (DataGridViewRow row in Matrix.Rows)
            {
                row.HeaderCell.Value = StatesList.Items[i].Text;
                i++;
            }
            Matrix.AutoResizeRowHeadersWidth(
        DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            for (int j = 0; j < Matrix.ColumnCount; j+=2)
            {
                DataGridViewColumn col = Matrix.Columns[j];
                col.HeaderCell.Value = AlphaInList.Items[j/2].Text;
                Matrix.Columns[j+1].HeaderCell.Value = "Out";
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            inter.getController().minimiseMealyMachine();
            int i = 0;
            foreach (DataGridViewRow row in newMatrix.Rows)
            {
                row.HeaderCell.Value = StatesList.Items[i].Text;
                i++;
            }
            newMatrix.AutoResizeRowHeadersWidth(
        DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            for (int j = 0; j < newMatrix.ColumnCount; j += 2)
            {
                DataGridViewColumn col = newMatrix.Columns[j];
                col.HeaderCell.Value = AlphaInList.Items[j/2].Text;
                newMatrix.Columns[j + 1].HeaderCell.Value = "Out";
            }
        }

        public char getState1()
        {
            return Convert.ToChar(comboBox1.Items[comboBox1.SelectedIndex]);
        }

        public DataGridView getNewMatrix()
        {
            return newMatrix;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Visible = false;
            inter.Visible = true;
            inter.restartMealy();
        }


    }
}
