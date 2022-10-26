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
namespace Homework2
{
    public partial class Coordinates : Form
    {
        private String CoordinatesToString(MouseEventArgs e) { return "Координаты мыши: х=" + e.X.ToString() + "; y=" + e.Y.ToString(); }    
        private void Coordinates_MouseMove(object sender, MouseEventArgs e)    
        {      
            Text = CoordinatesToString(e);   
        }
        private void Rectangle_MouseMove(object sender, MouseEventArgs e)
        {
            Text = "Координаты мыши: х=" + (e.X + Rectangle.Location.X).ToString() + "; y=" + (e.Y + Rectangle.Location.Y).ToString();
        }
        private void Coordinates_MouseClick(object sender, MouseEventArgs e)   
        {
            if(e.Button == MouseButtons.Left && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                this.Close();
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Точка находится снаружи прямоугольника.", "Клик ЛКМ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Button == MouseButtons.Right)     
            {
                Text = $"Ширина = {this.Width}, Высота = {this.Height}";
                Thread.Sleep(1000);
            }
        }
        private void Rectangle_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left && (ModifierKeys & Keys.Control) == Keys.Control)
            {
                this.Close();
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                if(e.X==0||e.X==Rectangle.Width||e.Y==0||e.Y==Rectangle.Height) MessageBox.Show("Точка находится на границе прямоугольника.", "Клик ЛКМ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Точка находится внутри прямоугольника.", "Клик ЛКМ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Button == MouseButtons.Right)
            {
                Text = $"Ширина = {this.Width}, Высота = {this.Height}";
                Thread.Sleep(1000);
            }
        }
        public Coordinates()
        {
            InitializeComponent();
        }
    }
}
