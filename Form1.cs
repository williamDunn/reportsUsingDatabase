//William Dunn - 285 - A10 - 4/12/18

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A10_DUNNW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void openForm()
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            openForm();
            using (Form2 form2 = new Form2())
            {
                form2.crystalReport = "movieReport";
            }
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            openForm();
            using (Form2 form2 = new Form2())
            {
                form2.crystalReport = "companyReport";
            }
        }

        private void btnStar_Click(object sender, EventArgs e)
        {
            openForm();
            using (Form2 form2 = new Form2())
            {
                form2.crystalReport = "starReport";
            }
        }
    }
}
