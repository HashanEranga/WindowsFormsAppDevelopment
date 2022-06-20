using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempAgencyApplication
{
    public partial class PayrollApp : Form
    {
        public PayrollApp()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            //create UI changes
            lblHours.Show();
            lblDependents.Show();

            txtHours.Show();
            txtDependents.Show();

            lblGross.Hide();
            lblFed.Hide();
            lblSoc.Hide();
            lblAgency.Hide();
            lblNet.Hide();

            txtGross.Hide();
            txtFed.Hide();
            txtSocial.Hide();
            txtAgency.Hide();
            txtNet.Hide();

            txtName.Text = "";
            txtHours.Text = "";
            txtDependents.Text = "";
            txtName.Focus();

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //create list of properties
            string fullName;
            string fname;
            string lname;

            int hours;
            int dependents;
            


            //first name and last name split
            fullName = txtName.Text;
            try
            {
                fname = fullName.Split(' ')[0];
                lname = fullName.Split(' ')[fullName.Split(' ').Count() - 1];
                hours = Convert.ToInt16(txtHours.Text);
                dependents = Convert.ToInt16(txtDependents.Text);

                //create UI changes
                lblHours.Hide();
                lblDependents.Hide();

                txtHours.Hide();
                txtDependents.Hide();

                lblGross.Show();
                lblFed.Show();
                lblSoc.Show();
                lblAgency.Show();
                lblNet.Show();

                txtGross.Show();
                txtFed.Show();
                txtSocial.Show();
                txtAgency.Show();
                txtNet.Show();

                Employee emp = new Employee(fname, lname, dependents, hours);
                txtGross.Text = String.Format("{0:C}", emp.DetermineGross()).ToString();
                txtFed.Text = String.Format("{0:C}", emp.DetermineFederalTax()).ToString();
                txtSocial.Text = String.Format("{0:C}", emp.DetermineSocialSecurity()).ToString();
                txtAgency.Text = String.Format("{0:C}", emp.DetermineAgencyFee()).ToString();
                txtNet.Text = String.Format("{0:C}", emp.DetermineNet()).ToString();
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Error : Enter first name and last name");
                txtName.Text = "";
                txtHours.Text = "";
                txtDependents.Text = "";
                txtName.Focus();
            }
            catch (FormatException)
            {
                MessageBox.Show("Error : All fields of the application must be filled with accurate data");
                txtName.Text = "";
                txtHours.Text = "";
                txtDependents.Text = "";
                txtName.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Error : Unhandled Exception occured");
                txtName.Text = "";
                txtHours.Text = "";
                txtDependents.Text = "";
                txtName.Focus();
            }





        }

    }
}
