using System;
using System.Linq;
using System.IO; //Importing systems input and output to allow the program to read and write files to a .csv document on a computer
using System.Windows.Forms;//imported manually to use the DataGridView class
using System.Data; //imported manually to use the DataGridView class

namespace projInsurancePolicy
{
    class ReadAndWriteCSV
    {
        DataTable csvDataTable = new DataTable();

        public static DataTable readCSV(DataTable dataTable)
        {
            if (!File.Exists(Policy.csvPath))//checks if the csv file exist before adding the data to the data grid view
            {
                // Create a file to write to.
                using (StreamWriter writeText = File.CreateText(Policy.csvPath))
                {
                    writeText.Write("Policy ID,Start Date of Policy,Driver Name,Occupation,Date of Birth,Premium");//if the file doesn't exist then the 1st row is written with the titles for each column
                }
            }

            string[] rawText = System.IO.File.ReadAllLines(Policy.csvPath);
            string[] dataCol = null;
            int x = 0;
            foreach (string textLine in rawText)
            {
                dataCol = textLine.Split(',');

                if (x == 0)
                {
                    for (int i = 0; i <= dataCol.Count() - 1; i++)
                    {
                        dataTable.Columns.Add(dataCol[i]);
                    }
                    x++;
                }
                else
                {
                    dataTable.Rows.Add(dataCol);
                }
            }
            return dataTable;
        }

        public static void writeDGVDetails(DataGridView gridIn, string outputFile)
        {
            //test to see if the DataGridView has any rows
            if (gridIn.RowCount > 0)
            {
                string value = "";
                DataGridViewRow dr = new DataGridViewRow();
                StreamWriter swOut = new StreamWriter(outputFile);

                //write header rows to csv
                for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                {
                    if (i > 0)
                    {
                        swOut.Write(",");
                    }
                    swOut.Write(gridIn.Columns[i].HeaderText);
                }

                swOut.WriteLine();

                //write DataGridView rows to csv
                for (int j = 0; j <= gridIn.Rows.Count - 1; j++)
                {
                    if (j > 0)
                    {
                        swOut.WriteLine();
                    }

                    dr = gridIn.Rows[j];

                    for (int i = 0; i <= gridIn.Columns.Count - 1; i++)
                    {
                        if (i > 0)
                        {
                            swOut.Write(",");
                        }

                        value = dr.Cells[i].Value.ToString();
                        //replace comma's with spaces
                        value = value.Replace(',', ' ');
                        //replace embedded newlines with spaces
                        value = value.Replace(Environment.NewLine, " ");

                        swOut.Write(value);
                    }
                }
                swOut.Close();
            }//end of if statement
        }

        public static void writeDetails(string startOfPolicy, string driverName, string driverOccupation, string driverDOB, double driversPremium)//declaration of the write details method
        {
            if (!File.Exists(Policy.csvPath))//check if a file exist
            {
                // Create a file to write to.
                using (StreamWriter writeText = File.CreateText(Policy.csvPath))
                {
                    writeText.Write("Policy ID,Start Date of Policy,Driver Name,Occupation,Date of Birth,Premium");//if file doesn’t exist than a new one is created and the 1st row is written
                    //with the titles for the columns
                }
            }

            StreamWriter sw = new StreamWriter(Policy.csvPath, append: true);//stream writer creates an object called sw which points to the csv file to write with a property to append the file
            //which means it will write additional information without deleting the existing data in the file
            sw.Write("\n{0},{1},{2},{3},{4},{5}", Policy.policyID, startOfPolicy, driverName, driverOccupation, driverDOB, Math.Round(driversPremium, 2));
            //the sw object writes the information with the variables that are passed to the method
            sw.Close();//sw object is closed

            StreamWriter writePolicyID = new StreamWriter(Policy.policyPath);//stream writer points to the policy id file to write the int variable 
            writePolicyID.Write(Policy.policyID);//the object writes the int variable policyID to the txt file
            writePolicyID.Close();//writePolicyID object is closed
        }
    }
}
