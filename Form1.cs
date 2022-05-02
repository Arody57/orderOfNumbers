using OrderNumber.dataGrid;
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

namespace OrderNumber
{
    public partial class Form1 : Form
    {
        ArrayList arrAddres;
        ArrayList arrData;
        public Form1()
        {
            InitializeComponent();
           arrAddres = new ArrayList();     
            arrData = new ArrayList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            arrAddres.Add(int.Parse(this.txtAddress.Text));
            arrData.Add(int.Parse(this.txtData.Text));


            listBox1.Items.Add(this.txtAddress.Text);
            listBox2.Items.Add(this.txtData.Text);

            txtAddress.Text = "";
            txtData.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            listBox4.Items.Clear();
            for (int i = 0; i < arrAddres.Count; i++)
            {
                arrAddres.Sort();
                listBox3.Items.Add(arrAddres[i]);
            };

            for (int i = 0; i < arrData.Count; i++)
            {
                arrData.Sort();
                listBox4.Items.Add(arrData[i]);
            };

        }

    }
}
