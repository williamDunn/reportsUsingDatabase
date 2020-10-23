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
using CrystalDecisions.CrystalReports.Engine;

namespace A10_DUNNW
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

            if (crystalReport == "movieReport")
            {
                crystalReportViewer1.ReportSource = MovieReport1;
                crystalReportViewer1.Refresh();
            }
            else if(crystalReport == "companyReport")
            {
                crystalReportViewer1.ReportSource = ProductionCompanyReport1;
                crystalReportViewer1.Refresh();
            }
            else if(crystalReport == "starReport")
            {
                crystalReportViewer1.ReportSource = StarReport1;
                crystalReportViewer1.Refresh();
            }
        }

        public string crystalReport;

    }
}
