using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLSinhVien
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            QLSV qLSV  =new QLSV(0);
            qLSV.Show();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            QLSV qLSV = new QLSV(1);
            qLSV.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            QLSV qLSV = new QLSV(2);
            qLSV.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
            QLSV qLSV = new QLSV(3);
            qLSV.Show();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
