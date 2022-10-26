using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Homework2
{
    public partial class Menu : Form
    {
        private Func<string> OutputFunc;
        public Menu()
        {
            InitializeComponent();
            
        }
        public Menu(Func<string> func)
        {
            InitializeComponent();
            OutputFunc = func;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutputFunc();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Coordinates cs = new Coordinates();
            cs.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimerForm tf = new TimerForm();
            tf.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
