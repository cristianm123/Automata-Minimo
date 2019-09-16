using AutomataMinimo.Interface;
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

namespace AutomataMinimo
{
    public partial class Inter : Form
    {
        private MooreInterface mooreInterface;
        private MealyInterface mealyInterface;
        private Controller.Controller controller;
        public Inter()
        {
            InitializeComponent();
            mooreInterface = new MooreInterface(this);
            mealyInterface = new MealyInterface(this);
            controller = new Controller.Controller(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mealyInterface.Visible = true;
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mooreInterface.Visible = true;
            Visible = false;
        }

        public Controller.Controller getController()
        {
            return controller;
        }

        public MooreInterface getMoore()
        {
            return mooreInterface;
        }

        public MealyInterface getMealy()
        {
            return mealyInterface;
        }

        public void restartMoore()
        {
            mooreInterface = new MooreInterface(this);
        }
        public void restartMealy()
        {
            mealyInterface = new MealyInterface(this);
        }

        private void Inter_Load(object sender, EventArgs e)
        {

        }
    }
}
