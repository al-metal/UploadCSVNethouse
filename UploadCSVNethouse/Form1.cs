using Bike18;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UploadCSVNethouse
{
    public partial class Form1 : Form
    {
        nethouse nethouse = new nethouse();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnUploadCSV_Click(object sender, EventArgs e)
        {
            string file = "naSite.csv";
        }
    }
}
