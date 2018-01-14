using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Rasp_UI_2
{
    public partial class Home : MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroUserControl1_Load_1(object sender, EventArgs e)
        {
            Interface_Rasp_Values Form_rpi = new Interface_Rasp_Values();
            Form_rpi.BringToFront();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Interface_Rasp_Values.ActiveForm.BringToFront();
            
        }
    }
}
