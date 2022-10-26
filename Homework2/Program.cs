using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework2
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        private static string OutputMessages()
        {
            string[] m = { "Текст сообщения", "Заголовок сообщения" };
            MessageBox.Show(m[0], m[1], MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show(m[0], m[1], MessageBoxButtons.YesNo);
            MessageBox.Show(m[0], string.Empty, MessageBoxButtons.OK);
            string[] m2 = { "Сообщение от программиста!", "Это заглавие", "Выбор", "Вы выбрали Cancel!" };
            MessageBox.Show(m2[0], string.Empty, MessageBoxButtons.OK);
            MessageBox.Show(m2[0], m2[1], MessageBoxButtons.OK);
            var res = MessageBox.Show(m2[0], m2[2], MessageBoxButtons.YesNoCancel);
            if (res == DialogResult.Cancel)
                MessageBox.Show(m2[3], String.Empty, MessageBoxButtons.OK);
            return null;
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu(OutputMessages));

        }
    }
}
