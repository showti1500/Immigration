using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectX
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void applicantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Applicantz appli = new Applicantz();
            appli.FormBorderStyle = FormBorderStyle.None;
            appli.TopLevel = false;
            appli.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(appli);
            panel1.Visible = true;        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void nRCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NRC nrc = new NRC();
            nrc.FormBorderStyle = FormBorderStyle.None;
            nrc.TopLevel = false;
            nrc.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(nrc);
            panel1.Visible = true;
        }

        private void householdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Household hhold = new Household();
            hhold.FormBorderStyle = FormBorderStyle.None;
            hhold.TopLevel = false;
            hhold.Show();
            panel1.Controls.Clear();
            panel1.Controls.Add(hhold);
            panel1.Visible = true;


        }
    }
}
