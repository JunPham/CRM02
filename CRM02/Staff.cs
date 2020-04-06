using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM02
{
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateDataUser f = new CreateDataUser();
            f.ShowDialog();
        }
    }
}
