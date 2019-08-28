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
    public partial class InOutHH : Form
    {
        public InOutHH()
        {
            InitializeComponent();
        }
        public string GroupBoxText
        {
            get
            {
                return groupBox1.Text;
                
            }
            set
            {
                groupBox1.Text = value;
            }
        }
        private void IncomeHH_Load(object sender, EventArgs e)
        {

        }
    }
}
