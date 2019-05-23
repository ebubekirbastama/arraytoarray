using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aray_on_array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList ary = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
          
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                ary.Add(listBox1.Items[i].ToString().Split(' '));
            }
            for (int i = 0; i < ary.Count; i++)
            {
                var dgr = ((string[])(ary[i]));
                listBox2.Items.Add(dgr[0].ToString());
                listBox3.Items.Add(dgr[1].ToString());
            }
        }
    }
}
