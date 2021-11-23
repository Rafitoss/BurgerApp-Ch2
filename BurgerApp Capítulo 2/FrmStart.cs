using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerApp_Capítulo_2
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            panel2.Width += 6;

            if (panel2.Width >= 545)
            {
                timer1.Stop();
                BurgerApp frmMain = new BurgerApp();
                frmMain.Show();
                this.Hide();
            }
        }

       
    }
}
