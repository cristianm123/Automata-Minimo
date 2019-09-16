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
    public partial class MooreInterface : Form
    {
        Inter inter;

        public MooreInterface(Inter f)
        {
            inter = f;
            InitializeComponent();
            
        }

        private void AddStates_Click(object sender, EventArgs e)
        {
            StatesList.Items.Add(TextBox.Text);
            TextBox.Clear();
            comboBox1.DataSource = StatesList.Items.Cast<ListViewItem>().Select(x=> x.Text).ToList();
            TextBox.Focus();

        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

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

        private void StatesList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matrix.ColumnCount = AlphaInList.Items.Count+1;
            Matrix.RowCount = StatesList.Items.Count;
            int i = 0;
            foreach(DataGridViewRow row in Matrix.Rows)
            {
                row.HeaderCell.Value = StatesList.Items[i].Text;
                i++;
            }
            Matrix.AutoResizeRowHeadersWidth(
        DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            for (int j = 0; j < Matrix.ColumnCount-1; j++)
            {
                DataGridViewColumn col = Matrix.Columns[j];
                col.HeaderCell.Value = AlphaInList.Items[j].Text;
            }
            DataGridViewColumn c = Matrix.Columns[Matrix.ColumnCount-1];
            c.HeaderCell.Value = "Out";
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            inter.getController().minimiseMooreMachine();
            int i = 0;
            foreach (DataGridViewRow row in newMatrix.Rows)
            {
                row.HeaderCell.Value = StatesList.Items[i].Text;
                i++;
            }
            newMatrix.AutoResizeRowHeadersWidth(
        DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            for (int j = 0; j < newMatrix.ColumnCount - 1; j++)
            {
                DataGridViewColumn col = newMatrix.Columns[j];
                col.HeaderCell.Value = AlphaInList.Items[j].Text;
            }
            DataGridViewColumn c = newMatrix.Columns[newMatrix.ColumnCount - 1];
            c.HeaderCell.Value = "Out";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Matrix_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
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
            inter.restartMoore();
        }
    }
}
