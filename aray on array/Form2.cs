using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        int drsy = 1985;
        private void button1_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync(argument:drsy);
        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            sayy(int.Parse(e.Argument.ToString()));
        }
        public void sayy(int sayidgr)
        {
            for (int i = 0; i < sayidgr + 1; i++)
            {
                listBox1.Items.Add(i);
            }
            MessageBox.Show("İşlem Tamamlandı.");
        }
    }
}
