using System;
using System.IO; //Importing systems input and output to allow the program to read and write files to a .csv document on a computer

namespace projInsurancePolicy
{
    class Policy
    {
        public static int policyID = 0;//policy id is incremented every time a new policy is created. The value of the variable is stored in a txt file in the same directory as the executable file
        public static string csvPath = "policydetails.csv";//the policy details are saved to a csv file in the same directory as the executable file
        public static string policyPath = "policyID.txt";//the path for the text file where the policy id is saved after the program is closed and opened again the id would be read and initialised again

        public Policy(string startDate, string[] name, string[] occupation, DateTime[] dateOfBirth, double premiumCost)//the constructor which creates an object when the user tries to create a policy
        {
            if (!File.Exists(policyPath))//checks if the policy.txt file exist
            {
                StreamWriter writePolicyID = new StreamWriter(policyPath);
                writePolicyID.Write(policyID);//writes the int variable policy ID into a text file
                writePolicyID.Close();
            }
            else
            {
                using (StreamReader readPolicyID = new StreamReader(policyPath))
                {
                    policyID = Convert.ToInt32(readPolicyID.ReadLine());//if policy id text file exists then the id is read from the file and initialised to policyID int variable
                }
            }

            policyID++;//the policy id is incremented before a new policy is written to a csv file

            int arrayIndex = 0;//array index is set to 0 to be used to write details from the arrays that are passed from form1.cs
            for (int count = 0; count < name.Length; count++)//for loop runs as long as count is less than the length of the name string array which is 5
            {
                if (name[arrayIndex] != null)//if statement checks if the name string array at arrayIndex is not null or has a string value inside like a name of driver
                {
                    ReadAndWriteCSV.writeDetails(startDate, name[arrayIndex], occupation[arrayIndex], dateOfBirth[arrayIndex].ToString("dd/MM/yyyy"), premiumCost);//write details method is called
                    //method takes the start date of policy, drivers name, drivers occupation, drivers date of birth, and the cost of premium for the policy
                    //All of this information is printed into a csv file
                }
                arrayIndex++;//arrayIndex is incremented by 1 so when the for loop runs a second time it will look at the 2nd element in an array to check if it’s not null
            }
        }
    }
}

