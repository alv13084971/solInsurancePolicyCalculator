using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace projInsurancePolicy
{
    public partial class frmPolicyCalculator : Form
    {
        public frmPolicyCalculator()
        {
            InitializeComponent();
        }

        DataTable csvDataTable = new DataTable();
        private static int driversPerPolicy = 1;//int is used to store the number of driver added to a single policy, program can only allow up to 5
        private string[] dName = new string[5];//string array used to store driver names
        private string[] dOccupation = new string[5];//string array is used to store drivers occupation if they have any
        private DateTime[] dDOB = new DateTime[5];//date time array used to store drivers birth date
        private List<DateTime> dateOfClaim = new List<DateTime>();//date time list is used to store the date of claim that a driver has received from another insurance policy
        private double premium = 500;//double variable is set to 500
        private static int index = 0;//int variable stores the index number when adding data from form to string and datetime arrays
        private static int claims = 0;//int variable stores the number of claims the drivers have made per one policy

        private void btnAddDriver_Click(object sender, EventArgs e)
        {

            if (dtpStartDateOfPolicy.Value.Date < DateTime.Now.AddDays(-1))//check if the date selected in the date time picker is not before today
            {
                MessageBox.Show("Start Date of Policy cannot be before today");//message box appears if the user has selected a date before today for the start date of policy
            }
            else if (driversPerPolicy > 5)//if statement checks if the number of drivers that have been added to the policy doesn't exceed 5
            {
                MessageBox.Show("Number of drivers cannot exceed 5 per policy");
            }
            else if (txtName.Text == "")//if statement check if the text box is not empty for drivers name
            {
                MessageBox.Show("Please enter a name");//shows a message box asking the user to enter a name
            }
            else
            {
                Occupation[] occupationObj = new Occupation[2];//object array is declared

                occupationObj[0] = new Accountant();//1st index is initialised to the accountant class
                occupationObj[1] = new Chauffeur();//2nd index is initialised to the chauffeur class

                if (!string.IsNullOrEmpty(cboOccupation.Text))//if statement checks if an occupation has been selected in the combo box
                    premium = occupationObj[cboOccupation.SelectedIndex].getPremium();//The index of the selected combo box is used to select which class the object is going to use
                //if the user selected accountant or chauffeur as drivers occupation the premium can be decreased or increased by 10%

                //if the validation checks all pass the information from the form is added to the string and date time arrays
                dName[index] = txtName.Text;
                dOccupation[index] = cboOccupation.Text;
                dDOB[index] = dtpDateOfBirth.Value.Date;
                //the textbox, combo box and date time picker is reset or set to be empty so the user can input the 2nd driver
                txtName.Text = "";
                dtpDateOfBirth.Value = DateTime.Now;
                cboOccupation.Text = "";

                index++;//the index number for the string and date time arrays is incremented by 1 as a driver has already been added
                //the label is updated to display how many drivers has been created per policy
                lblDriversCreated.Text = "Drivers created " + index + "/5";
                panelAddClaims.Visible = true;//the panel to add claim appear after the 1st driver has been added

                driversPerPolicy++;// the number for the amount of driver that have been added per policy is incremented by 1

            }//end of if statement
        }

        private void btnBackToForm_Click(object sender, EventArgs e)
        {
            //pressing the button back to form erases the data grid view, hides the data grid and the panel with the 2 buttons for going back to the form and saving the changes made to the data grid
            //it also makes the panel with the controls to input policy date and drivers appears on the form.
            panel1.Visible = true;
            panel2.Visible = false;
            csvDataGrid.Visible = false;

            csvDataGrid.DataSource = null;
            csvDataGrid.Rows.Clear();
            csvDataGrid.Columns.Clear();
            csvDataTable.Rows.Clear();
            csvDataGrid.Refresh();

            csvDataTable.Columns.Remove("Policy ID");
            csvDataTable.Columns.Remove("Start Date of Policy");
            csvDataTable.Columns.Remove("Driver Name");
            csvDataTable.Columns.Remove("Occupation");
            csvDataTable.Columns.Remove("Date of Birth");
            csvDataTable.Columns.Remove("Premium");

            this.Controls.Remove(csvDataGrid);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//clicking the exit button closes the form
        }

        private void btnAdminSection_Click(object sender, EventArgs e)
        {
            //clicking the admin section makes the data grid view appear and the form for inputting policies and drivers disappear
            panel1.Visible = false;
            panel2.Visible = true;
            csvDataGrid.Visible = true;

            csvDataGrid.DataSource = ReadAndWriteCSV.readCSV(csvDataTable);
            this.Controls.Add(csvDataGrid);
        }

        private void frmPolicyCalculator_Load(object sender, EventArgs e)
        {
            //when the form is loaded the add claims panel, data grid view, and the panel with 2 buttons that are used in the admin section are all hidden from view
            panel2.Visible = false;
            panelAddClaims.Visible = false;
            csvDataGrid.Visible = false;
        }

        private void txtSaveChanges_Click(object sender, EventArgs e)
        {
            //when the button is clicked the writeDGVDetails to CSV method is called from the ReadAndWriteCSV class to write the data that is displayed in the data grid view to the csv file
            ReadAndWriteCSV.writeDGVDetails(csvDataGrid, Policy.csvPath);

            MessageBox.Show("Changes have been saved");//when it finished the message box appears telling the user that the changes have been saved
        }

        private void btnCreatePolicy_Click(object sender, EventArgs e)
        {
            //2 string variables would be used to store the name of the oldest driver and the youngest driver in a policy
            string youngestName = "";
            string oldestName = "";

            double driverAge;
            double youngestAge = 99;//this int will be used to store the age of the youngest driver
            double oldestAge = 0;//this int will be used to store the age of the oldest driver

            for (int count = 0; count < index; count++)//for loop runs through all the drivers to check if they are the youngest or the oldest
            {
                TimeSpan timespanAge = DateTime.Now - dDOB[count];
                driverAge = timespanAge.Days / 365.25;

                if (driverAge < youngestAge)//if statement compares ages to find the youngest driver
                {
                    youngestName = dName[count];
                    youngestAge = driverAge;
                }
                if (driverAge > oldestAge)//if statement compares ages to find oldest driver
                {
                    oldestName = dName[count];
                    oldestAge = driverAge;
                }
            }//end of for loop

            if (dName[0] == null)
                MessageBox.Show("Add a driver to the policy");
            else if (dtpStartDateOfPolicy.Value.Date < DateTime.Now.AddDays(-1))//check if the date selected in the date time picker is not before today
                MessageBox.Show("Start Date of Policy cannot be before today. Premium is declined");//message box appears if the user has selected a date before today for the start date of policy
            else if (youngestAge < 21)//check if the youngest driver is under 21, if it is then the premium is declined
            {
                youngestAge = Math.Truncate(100 * youngestAge) / 100;
                MessageBox.Show("Age of Youngest driver " + youngestAge.ToString("N2") + " Name: " + youngestName + " premium is declined");
            }
            else if (oldestAge > 75)//check if the oldest driver is over 75, if it is then the premium is declined
            {
                oldestAge = Math.Truncate(100 * oldestAge) / 100;
                MessageBox.Show("Age of Oldest driver " + oldestAge.ToString("N2") + " Name: " + oldestName + " premium is declined");
            }
            else if (claims == 3)//if claims is 3 then the premium is declined with a message box 
                MessageBox.Show("Driver has more than 2 claims. Premium is declined");
            else if (claims > 3)//if claims is more than 3 then the premium is declined with a message box 
                MessageBox.Show("Driver has more than 3 claims. Premium is declined");
            else
            {
                if (claims == 1)//if the number of claims made is 1 then the if statement runs
                    checkClaimsAge(dateOfClaim[0]);
                else if (claims == 2)//if the number of claims made is 2 then the if statement runs
                {
                    checkClaimsAge(dateOfClaim[0]);
                    checkClaimsAge(dateOfClaim[1]);
                }//end of if elseif statement

                if (youngestAge >= 21 && youngestAge <= 25)//checks if youngest driver is between 21 and 25, if it is then the premium is increased by 20%
                    premium += premium * 0.20;
                else if (youngestAge >= 26 && youngestAge <= 75)//checks if youngest driver is between 25 and 75, if it is then the premium is decreased by 10%
                    premium -= premium * 0.10;

                // if the validation checks pass an object called newPolicy is created and data is passed through the parameters
                Policy newPolicy = new Policy(dtpStartDateOfPolicy.Value.ToString("dd/MM/yyyy"), dName, dOccupation, dDOB, premium);
                MessageBox.Show("Policy has been created");
                dtpStartDateOfPolicy.Value = DateTime.Now;//start date of policy date time picker is reset to the current date

            }//end of else if statement that checks if at least 1 driver has been added

            resetValues();//the reset values method sets the premium, index, driversPerPolicy, claims and dName array to their default values
        }

        private void btnClearDrivers_Click(object sender, EventArgs e)
        {
            //when clicking the button the value in the array of drivers name is set to null.
            //other arrays don't have to be re initialised since the Policy class uses the driver name array to check is the element is null or not
            //to enter a driver the name field cannot be null and the existing arrays with values for the driver occupation would be overwritten
            resetValues();//the reset values method sets the premium, index, driversPerPolicy, claims and dName array to their default values
        }

        private void btnAddClaim_Click(object sender, EventArgs e)
        {
            if (dtpPastClaim.Value.Date > DateTime.Now)// check if the date for claim is in the future
                MessageBox.Show("Date of claim cannot be after today");
            else
            {
                dateOfClaim.Add(dtpPastClaim.Value.Date);//date of claim is added to a date of claim List
                claims++;//the int claims is incremented by 1 
                lblClaims.Text = "Claims Added: " + claims;//the label that says how many claims have been added is updated
                dtpPastClaim.Value = DateTime.Now;//reset the date time picker to the current date
            }
        }

        public void resetValues()
        {
            for (int arrayIndex = 0; arrayIndex < dName.Length; arrayIndex++)//reinitialised the array for drivers names to null in all elements
            {
                dName[arrayIndex] = null;
            }


            index = 0;//index for the drivers added is set to 0 since a policy has been created
            lblDriversCreated.Text = "Drivers created " + index + "/5";//the number of drivers that have been added to the policy is updated to 0
            driversPerPolicy = 1;//number of driver that exist per policy is set to 1
            premium = 500;// premium is set to the starting value of 500
            dateOfClaim.Clear();
            claims = 0;//the number of claims the drivers have made is set to 0
            lblClaims.Text = "Claims Added: " + claims;//the number of claims label is set to Claims Added: 0
            panelAddClaims.Visible = false;// the panel to add claims is hidden
        }

        //this method checks how old the claims are and increases the premium based on the age of claim unless it’s over 5 years old where the premium remains unchanged
        public void checkClaimsAge(DateTime ageOfDriversClaim)
        {
            TimeSpan claimsAge;//TimeSpan is used to record the age of the claims that the driver has made

            claimsAge = DateTime.Now - ageOfDriversClaim;
            double age = claimsAge.Days / 365.25;

            if (age < 1)//if the age of claim is less than 1 then the premium is increased by 20%
            {
                premium += premium * 0.20;
            }
            else if (age >= 1 && age <= 5)//if the age of claim is between 1 and 5 years then the premium is increased by 10%
            {
                premium += premium * 0.10;
            }
        }
    }
}





