using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GUIAddressBook
{
    public partial class Form1 : Form
    {
        private StreamWriter fil;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                fil = new StreamWriter("addressBook.txt");
            }
            catch (DirectoryNotFoundException exc)
            {
                messageLbl.Text = "Invalid directory" + exc.Message;
            }
            catch (System.IO.IOException exc)
            {
                messageLbl.Text = exc.Message;
            }
        }

        private void nameTxtBx_TextChanged(object sender, EventArgs e)
        {
           
        }

        public void ClearForm()
        {
            nameTxtBx.Text = string.Empty;
            nameMesLbl.Text = string.Empty;
            emailTxtBx.Text = string.Empty;
            emailMesLbl.Text = string.Empty;
            phoneTxtBx.Text = string.Empty;
            phoneMesLbl.Text = string.Empty;
            
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {

            double phone;

            if (nameTxtBx.Text.Length < 2)
            {
                nameMesLbl.Text = "Please enter a name";
            }

            if (!emailTxtBx.Text.Contains('@'))
            {
                emailMesLbl.Text = "Please enter a valid email address";
            }

            if ((double.TryParse(phoneTxtBx.Text, out phone) == false) || phoneTxtBx.Text.Contains('-'))
            {
                phoneMesLbl.Text = "Phone number must be only numbers";
            } 


            else
            {
                try
                {
                    fil.Write(nameTxtBx.Text + "\t");
                    

                    fil.Write(emailTxtBx.Text + "\t");
                    

                    fil.Write(phoneTxtBx.Text + "\t");
                    

                    fil.WriteLine("\n");

                    ClearForm();


                }
                catch (System.IO.IOException exc)
                {
                    messageLbl.Text = exc.Message;
                }
                catch (Exception exc)
                {
                    messageLbl.Text = exc.Message;
                }

            }
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                fil.Close();
            }
            catch
            {
                messageLbl.Text = "File did not close properly: ";
            }
        }

        
    }
}
