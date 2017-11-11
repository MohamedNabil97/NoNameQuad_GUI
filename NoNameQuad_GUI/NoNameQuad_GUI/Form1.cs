using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoNameQuad_GUI
{
    public partial class Form1 : Form
    {
        static Transmitter myTransmitter = new Transmitter("COM5", 9600);
        Controller myController = new Controller(myTransmitter);
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Serv180_Click(object sender, EventArgs e)
        {

        }

        private void button_applyChanges_t1_Click(object sender, EventArgs e)
        {
            int legnumber_t1 = 0;
            string servonumber="";
            byte alpha = 0, beta = 0, gamma = 0;
            try
            {
                legnumber_t1 = int.Parse(comboBox_legNumber_t1.Text);
            }
            catch
            {
                MessageBox.Show("No leg number chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBox_servo_t1.SelectedIndex > -1)
            {
                servonumber = comboBox_servo_t1.Text;
            }
            else
            {
                MessageBox.Show("No servo number chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textbox_alpha_t1.Text != "")
            {
                try
                {
                    alpha = byte.Parse(textbox_alpha_t1.Text);
                }
                catch
                {
                    MessageBox.Show("No alpha angle chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (textbox_beta_t1.Text != "")
                {
                    try
                    {
                        beta =byte.Parse(textbox_beta_t1.Text);
                    }
                    catch
                    {
                        MessageBox.Show("No beta angle chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                if (textbox_gamma_t1.Text != "")
                {
                    try
                    {
                        gamma = byte.Parse(textbox_gamma_t1.Text);
                        myController.MoveServo(alpha, beta, gamma);
                    }
                    catch
                    {
                        MessageBox.Show("No gamma angle chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            myController.ResetEverything();
        }

        private void button_apply_t2_Click(object sender, EventArgs e)
        {
            int legnumber_t2 = 0;
            byte x = 0, y = 0, z = 0;
            try
            {
                legnumber_t2 = int.Parse(comboBox_legChoice_t2.Text);
            }
            catch
            {
                MessageBox.Show("No leg number chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textbox_xHold_t2.Text != "")
            {
                try
                {
                    x = byte.Parse(textbox_xHold_t2.Text);
                }
                catch
                {
                    MessageBox.Show("No x number chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            if (textbox_yHold_t2.Text != "")
            {
                try
                {
                    y = byte.Parse(textbox_yHold_t2.Text);
                }
                catch
                {
                    MessageBox.Show("No y number chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            if (textbox_zHold_t2.Text != "")
            {
                try
                {
                    z = byte.Parse(textbox_zHold_t2.Text);
                }
                catch
                {
                    MessageBox.Show("No z number chosen", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }
    }
}