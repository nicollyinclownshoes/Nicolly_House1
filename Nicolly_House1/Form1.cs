using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nicolly_House1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 3;

            if (panel2.Width >= 1184)
            {
                timer1.Stop();
                Form2 Temporadas_e_episodios = new Form2();
                Temporadas_e_episodios.Show();
                this.Hide();
            }
        }
    }
}
