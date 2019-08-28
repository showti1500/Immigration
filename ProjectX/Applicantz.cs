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
    public partial class Applicantz : Form
    {
        private InOutHH inoutHH = null;
        public Applicantz()
        {
            InitializeComponent();
        }

        private void Applicantz_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
        }
        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = false;
            textBox7.Visible = false;
            label10.Visible = false;
            comboBox1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                NRCForm NrcForm = new NRCForm();
                NrcForm.Show();
            }
            else if (radioButton2.Checked && comboBox1.SelectedItem.Equals("New"))
            {
                HouseholdForm HhForm = new HouseholdForm();
                HhForm.Show();
            }
            else if (radioButton2.Checked && comboBox1.SelectedItem.Equals("Income"))
            {
                inoutHH = new InOutHH();
                inoutHH.Text = "InCome";
                inoutHH.Show();
                inoutHH.GroupBoxText = "IncomeForm";
              
            }
            else if (radioButton2.Checked && comboBox1.SelectedItem.Equals("Outcome"))
            {
                inoutHH = new InOutHH();
                inoutHH.Text = "OutCome";
                inoutHH.Show();
                this.inoutHH.GroupBoxText = "OutComeForm";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label8.Visible = true;
            textBox7.Visible = true;
            label10.Visible = true;
            comboBox1.Visible = true;
        }
    }
}
