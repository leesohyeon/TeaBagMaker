using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class Form1 : Form
    {
        string[] List = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        string orgStr = "";
        int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (count < 1)
            {
                this.Timer.Enabled = false;
                MessageBox.Show("티백을 건지세요!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ( == true)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < List.Length; i++)
            {
                this.comboBox1.Items.Add(List[i]);
            }
            this.orgStr = comboBox1.Text;

        }


    }
}
