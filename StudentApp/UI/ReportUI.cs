using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;

namespace StudentApp.UI
{
    public partial class ReportUI : Form
    {
        public ReportUI()
        {
            InitializeComponent();
        }

        public ReportDocument RD = new ReportDocument();

        public void LoadReport()
        {
            RD.SetDatabaseLogon("sa", "123456");
        }
    }
}
