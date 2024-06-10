using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c__hinhtron
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btndt_Click(object sender, EventArgs e)
        {
            Double r, ketqua;
            r = Convert.ToDouble(txt1.Text);
            ketqua = (r * r * 3.14);
            txt1kq.Text = ketqua.ToString();
        }

        private void btncv_Click(object sender, EventArgs e)
        {
            Double r, ketqua;
            r = Convert.ToDouble(txt1.Text);
            ketqua = (r * 2 * 3.14);
            txt1kq.Text = ketqua.ToString();
        }
    }
}
