using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Таймер, выполненный на уроке с дополнительным функционалом: 

- при счете таймера добавить визуальное представление обратного отсчета; 

- при остановке таймера раньше заданного времени выдать сообщение про либо сколько времени прошло, либо сколько времени осталось 
*/
namespace Homework2
{
    public partial class TimerForm : Form
    {
        private int start = DateTime.Now.Second;
        private int end = DateTime.Now.Second;
        public TimerForm()
        {
            InitializeComponent(); 
        }
        private void ShowTimer(object vObject, EventArgs e)    
        { 
            Stopwatch.Stop();      
            button2.Enabled = false;
            button1.Enabled = true;
            MessageBox.Show("Таймер отработал!","Таймер");    
        }
        private void button1_Click(object sender, EventArgs e)    
        {
            if (numSeconds.Value <= 0) { 
                MessageBox.Show("Количество секунд должно быть больше 0!"); 
                return; 
            }
            button2.Enabled = true;
            button1.Enabled = false;
            Stopwatch.Interval = decimal.ToInt32(numSeconds.Value) * 1000;
            start = DateTime.Now.Second;
            Stopwatch.Start();
            end = Stopwatch.Interval/1000 + start;
            textBox1.Text = (end-DateTime.Now.Second).ToString();
            textBox1.Focus();
            SendKeys.Send(" ");

        }
        private void button2_Click(object sender, EventArgs e)    
        {
            Stopwatch.Stop();
            MessageBox.Show("Таймер не успел отработать!", "Таймер");      
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1.Text = (end - DateTime.Now.Second).ToString();
            if (textBox1.Text != "0")
            {
                textBox1.Focus();
                SendKeys.Send(" ");
            }
        }
    }
}

