using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String tp, tc, tco, tfp, tfm, tfq, tfpp, tff, tfa, tf, tsa, tsr, tsc, tst, ts, tm, tmk, tmmo, tmma, tmv, tmp, tmpi, name;
        Double pp, pc, pfp, pfm, pfq, pfpp, pff, pfa, pf, psa, psr, psc, pst, pa, pco, pm, pmk, pmmo, pmma, pmv, pmp, pmpi, somatotal;

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                tp = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                tp = radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                tp = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                tp = radioButton4.Text;
            }
            else if (radioButton5.Checked)
            {
                tp = radioButton5.Text;
            }
            else
            {
                tp = "Nenhum pão escolhido";
            }

            if (radioButton11.Checked)
            {
                tc = radioButton11.Text;
            }
            else if (radioButton12.Checked) 
            {
                tc = radioButton12.Text;
            }
            else if (radioButton13.Checked)
            {
                tc = radioButton13.Text;
            }
            else if (radioButton14.Checked)
            {
                tc = radioButton14.Text;
            }
            else if (radioButton15.Checked)
            {
                tc = radioButton15.Text;
            }

            if (checkBox1.Checked)
            {
                tfp = checkBox1.Text + ", ";
                pfp = 2.20;
            }
            else
            {
                tfp = "";
                pfp = 0;
            }

            if (checkBox2.Checked)
            {
                tfm = checkBox2.Text + ", ";
                pfm = 2.25;
            }
            else
            {
                tfm = "";
                pfm = 0;
            }

            if (checkBox3.Checked)
            {
                tfq = checkBox3.Text + ", ";
                pfq = 2.40;
            }
            else
            {
                tfq = "";
                pfq = 0;
            }

            if (checkBox4.Checked)
            {
                tfpp = checkBox4.Text + ", ";
                pfpp = 2.40;
            }
            else
            {
                tfpp = "";
                pfpp = 0;
            }

            if (checkBox5.Checked)
            {
                tff = checkBox5.Text + ", ";
                pff = 2.50;
            }
            else
            {
                tff = "";
                pff = 0;
            }

            if (checkBox6.Checked)
            {
                tfa = checkBox6.Text + ", ";
                pfa = 3.00;
            }
            else
            {
                tfa = "";
                pfa = 0;
            }
            

            if (checkBox7.Checked)
            {
                tsa = checkBox7.Text + ", ";
                psa = 3.00;
            }
            else
            {
                tsa = "";
                psa = 0;
            }
            if (checkBox8.Checked)
            {
                tsr = checkBox8.Text + ", ";
                psr = 2.15;
            }
            else
            {
                tsr = "";
                psr = 0;
            }
            if (checkBox9.Checked)
            {
                tsc = checkBox9.Text + ", ";
                psc = 3.00;
            }
            else
            {
                tsc = "";
                psc = 0;
            }
            if (checkBox10.Checked)
            {
                tst = checkBox10.Text + ", ";
                pst = 2.50;
            }
            else
            {
                tst = "";
                pst = 0;
            }
           

            if (radioButton1.Checked)
            {
                pp = 1.50;
            }
            else if (radioButton2.Checked)
            {
                pp = 2.00;
            }
            else if (radioButton3.Checked)
            {
                pp = 2.30;
            }
            else if (radioButton4.Checked)
            {
                pp = 2.50;
            }
            else if (radioButton5.Checked)
            {
                pp = 2.15;
            }
            else
            {
                pp = 0.00;
            }

            if (radioButton11.Checked)
            {
                pc = 3.20;
            }
            else if (radioButton12.Checked)
            {
                pc = 3.50;
            }
            else if (radioButton13.Checked)
            {
                pc = 4.00;
            }
            else if (radioButton14.Checked)
            {
                pc = 4.30;
            }
            else if (radioButton15.Checked)
            {
                pc = 4.50;
            }

            if (radioButton6.Checked)
            {
                pco = 3.50;
                tco = radioButton6.Text;
            }
            else if (radioButton7.Checked)
            {
                pco = 3.45;
                tco = radioButton7.Text;
            }
            else if (radioButton8.Checked)
            {
                pco = 3.15;
                tco = radioButton8.Text;
            }
            else if (radioButton9.Checked)
            {
                pco = 2.15;
                tco = radioButton9.Text;
            }
            else if (radioButton10.Checked)
            {
                pco = 2.00;
                tco = radioButton10.Text;
            }
            else if (radioButton16.Checked)
            {
                pco = 2.50;
                tco = radioButton16.Text;
            }
            else if (radioButton17.Checked)
            {
                pco = 2.00;
                tco = radioButton17.Text;
            }
            else if (radioButton18.Checked)
            {
                pco = 2.15;
                tco = radioButton18.Text;
            }
            else
            {
                pco = 0.00;
            }

            if (checkBox12.Checked)
            {
                tmk = checkBox12.Text + ", ";
                pmk = 1.50;
            }
            else
            {
                tmk = "";
                pmk = 0;
            }

            if (checkBox13.Checked)
            {
                tmmo = checkBox13.Text + ", ";
                pmmo = 1.80;
            }
            else
            {
                tmmo = "";
                pmmo = 0;
            }

            if (checkBox14.Checked)
            {
                tmma = checkBox14.Text + ", ";
                pmma = 2.00;
            }
            else
            {
                tmma = "";
                pmma = 0;
            }

            if (checkBox11.Checked)
            {
                tmv = checkBox11.Text + ", ";
                pmv = 2.50;
            }
            else
            {
                tmv = "";
                pmv = 0;
            }

            if (checkBox15.Checked)
            {
                tmp = checkBox15.Text + ", ";
                pmp = 3.50;
            }
            else
            {
                tmp = "";
                pmp = 0;
            }

            if (checkBox16.Checked)
            {
                tmpi = checkBox16.Text + ", ";
                pmpi = 2.50;
            }
            else
            {
                tmpi = "";
                pmpi = 0;
            }
            

            pf = pfp + pfm + pfq + pfpp + pff + pfa;
            tf = tfp + tfm + tfq + tfpp + tff + tfa;
            pa = psa + psr + psc + pst;
            ts = tsa + tsr + tsc + tst;
            tm = tmk + tmmo + tmma + tmv + tmp + tmpi;
            pm = pmk + pmmo + pmma + pmv + pmp + pmpi;


            somatotal = pp + pc + pf + pa + pco + pm;
            label3.Text = name + "SEU LANCHE CONTEM: \n" + tp + ", " + tc + ", " + tf + ts + tco + ", " + tm;
            label5.Text = Convert.ToString("R$ "+somatotal);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
