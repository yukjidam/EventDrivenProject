using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDP_Project
{
    public partial class Logs_Frm : Form
    {
        public Logs_Frm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Admin_Frm_Main af = new Admin_Frm_Main();
            this.Hide();
            af.Show();

        }
    }
}
