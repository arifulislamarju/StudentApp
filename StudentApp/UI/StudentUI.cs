using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StudentApp.DAL.Gateway;

namespace StudentApp.UI
{
    public partial class StudentUI : Form
    {
        public StudentUI()
        {
            InitializeComponent();
        }

        public StudentGateway aGateway = new StudentGateway();
 
        private void btnPreview_Click(object sender, EventArgs e)
        {
            try
            {
                if (aGateway.ShowStudentInfo())
                {
                    ReportUI Rpt = new ReportUI();
                    Rpt.RD.Load(Application.StartupPath + "\\Report\\rptStudentInfo.rpt");
                    Rpt.LoadReport();
                    //Rpt.RD.SetParameterValue("@InvoiceId", txtInvoice.Text);
                    Rpt.crView.ReportSource = Rpt.RD;
                    Rpt.Text = "Invoice";
                    Rpt.Show();
                }
                else
                {
                    MessageBox.Show("No Information to Show in Report");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Information couldn't loaded from your system", ex);
            }
         
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
