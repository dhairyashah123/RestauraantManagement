using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Xml;
using System.Windows.Forms;

namespace Restaurant_Management
{
    public partial class Settings : Sample
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void servertxt_TextChanged(object sender, EventArgs e)
        {
            if (servertxt.Text == "")
            {
                serverErrorLabel.Visible = true;
            }
            else
            {
                serverErrorLabel.Visible = false;
            }
        }
    

    private void databasetxt_TextChanged(object sender, EventArgs e)
        {
            if (databasetxt.Text == "")
            {
                databaseErrorLabel.Visible = true;
            }
            else
            {
                databaseErrorLabel.Visible = false;
            }
        }

        private void useridtxt_TextChanged(object sender, EventArgs e)
        {
            if (!isCB.Checked)
            {
                if (useridtxt.Text == "")
                {
                    useridErrorLabel.Visible = true;
                }
                else
                {
                    useridErrorLabel.Visible = false;
                }
            }
        }

        private void passwordtxt_TextChanged(object sender, EventArgs e)
        {
            if (!isCB.Checked)
            {
                if (passwordtxt.Text == "")
                {
                    passwordErrorLabel.Visible = true;
                }
                else
                {
                    passwordErrorLabel.Visible = false;
                }
            }
        }

        private void isCB_CheckedChanged(object sender, EventArgs e)
        {
            if(isCB.Checked)
            {
                useridErrorLabel.Visible = false;
                passwordErrorLabel.Visible = false;
                useridtxt.Enabled = false;
                passwordtxt.Enabled = false;
                useridtxt.Text = "";
                passwordtxt.Text = "";


            }
            else
            {
                useridtxt.Enabled = true;
                passwordtxt.Enabled = true;

            }
        }
        public void updateConfigFile(String con)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            foreach(XmlElement xElement in xmlDoc.DocumentElement)
            {
                if (xElement.Name == "connectionStrings") 
                xElement.FirstChild.Attributes[2].Value = con;

            }
            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            ConfigurationManager.RefreshSection("connectionStrings");

        }
        string connection;

        private void savebtn_Click(object sender, EventArgs e)
        {
            if(isCB.Checked)
            {
                if (servertxt.Text == "")
                {
                    serverErrorLabel.Visible = true;
                }
                else
                {
                    serverErrorLabel.Visible = false;
                }
                if (databasetxt.Text == "")
                {
                    databaseErrorLabel.Visible = true;
                }
                else
                {
                    databaseErrorLabel.Visible = false;
                }
                if(serverErrorLabel.Visible || databaseErrorLabel.Visible)
                {
                    MainClass.showMessage("Fields with * are Mandatory","Error");
                }
                else
                {
                    connection = "Data Source=" + servertxt.Text +
                        ";Intial Catelog=" + databasetxt.Text + 
                        ";Integrated Security=true;MultipleActiveResultSets=true;";
                    updateConfigFile(connection);
                    DialogResult dr = MessageBox.Show("Settings saved Successfully");
                    if(dr == DialogResult.OK)
                    {
                        LoginScreen ls = new LoginScreen();
                        MainClass.showWindow(ls, this, MDI.ActiveForm);

                    }


                }

            }
            else
            {
                if (servertxt.Text == "")
                {
                    serverErrorLabel.Visible = true;
                }
                else
                {
                    serverErrorLabel.Visible = false;
                }
                if (databasetxt.Text == "")
                {
                    databaseErrorLabel.Visible = true;
                }
                else
                {
                    databaseErrorLabel.Visible = false;
                }
                if (useridtxt.Text == "")
                {
                    useridErrorLabel.Visible = true;
                }
                else
                {
                    useridErrorLabel.Visible = false;
                }
                if (passwordtxt.Text == "")
                {
                    passwordErrorLabel.Visible = true;
                }
                else
                {
                    passwordErrorLabel.Visible = false;
                }
                if (serverErrorLabel.Visible || databaseErrorLabel.Visible || useridErrorLabel.Visible || passwordErrorLabel.Visible)
                {
                    MainClass.showMessage("Fields with * are Mandatory", "Error");
                }
                else
                {
                    connection = "Data Source=" + servertxt.Text +
                        ";Intial Catelog=" + databasetxt.Text +
                        ";Integrated Security=true;MultipleActiveResultSets=true;";
                    updateConfigFile(connection);
                    DialogResult dr = MessageBox.Show("Settings saved Successfully");
                    if (dr == DialogResult.OK)
                    {
                        LoginScreen ls = new LoginScreen();
                        MainClass.showWindow(ls, this, MDI.ActiveForm);

                    }

                }
            }
        }
    }
}
