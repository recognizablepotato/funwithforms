using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//This program allows user to input houly wage, hours worked , and weeks worked in given textboxes.
//when hit the method 1 button it calculates the total pay and outputs it in the list box.
namespace ExtraCreditBlauria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Method 1 Begins

        private void btnMethod1CalculatePay_Click(object sender, EventArgs e)
        {//beginning bracket for event handler calculate pay
            //takes input from textbox enter hourly wage and makes it a double so it can be used in multiplication
            double dblHourlyWage = double.Parse(txtEnterHourlyWage.Text);
            //takes input from textbox enter Hours worked and makes it a double so it can be used in multiplication
            double dblHoursWorked = double.Parse(txtEnterHoursWorked.Text);
            //takes input from textbox enter weeks worked and makes it a double so it can be used in multiplication
            double dblEnterWeeksWorked = double.Parse(txtEnterWeeksWorked.Text);

            //calls method
            getcalculation(dblHourlyWage, dblHoursWorked, dblEnterWeeksWorked);
            
        }//closing eventhandler 

        private void getcalculation(double dblHourlyWage, double dblHoursWorked, double dblEnterWeeksWorked)
        { //Multiplys the textbox variables to get total pay then ouputs in listbox
            double dblResult = dblHourlyWage * dblHoursWorked * dblEnterWeeksWorked;
            lstOutput.Items.Add(string.Format("{0,13}{1,1}", "Total pay is ", dblResult.ToString("C")));
        }//end method that calculates and prints the result of total pay

        //Method 1 ends




        //Method 2 begins
        //Compares two words entered in the textbox's by the user


        private void btnMethod2ReturnMatch_Click(object sender, EventArgs e)
        {//Eventhandler for Method2 Comparing Words Entered
            //Get string from given textboxes
            string strEnterAWord = txtEnterAWord.Text;
            string strEnterAWord1 = txtEnterAWord1.Text;

            //Call method for Result True or False
            bool blnResult = getblnResult(strEnterAWord, strEnterAWord1);


            //If true state words are the same
           if(blnResult == true) 
             lstOutput.Items.Add(strEnterAWord + " and " + strEnterAWord1 + " are the same word"); 
           //if false state words are not the same
            if(blnResult == false)
            lstOutput.Items.Add(strEnterAWord + " and " + strEnterAWord1 + " are not the same word ");
        } //end of event handler for method 2 button that compares words
        
         private bool getblnResult(string strEnterAWord, string strEnterAWord1)
        {//Method begins that get values from event then returns true or false when comparing the words in the textbox
            bool blnResult;
                    //if statement that returns true
                    if (strEnterAWord == strEnterAWord1)
                     { blnResult = true; }//end if statement
                            //else returns false
                             else{ blnResult = false; }//end else statement
                                     return blnResult;}//method for Returning True or False Value ends

        //Method 3 Begins
        //Method 3 Changes input word and replaces it with "Your word was replaced with a literal" passing variable ref to method and then back to event
        // Method 3 changes input number with the number times Pi passing variable ref to method and then back to event


        //Event handler for button on method 3 that pass a string and double by ref and changes them
        private void btnMethod3PassbyRef_Click(object sender, EventArgs e)
        {//opening of button event
            //getting data from textbox
            string strEnterAWordMethod3 = txtEnterAWord3.Text;
            double dblEnterNumber = double.Parse(txtEnterNumber.Text);

            //Calling method
            getValues(ref strEnterAWordMethod3, ref dblEnterNumber);

            //Displaying output in listbox
            lstOutput.Items.Add(string.Format(strEnterAWordMethod3));
            lstOutput.Items.Add(string.Format("{0,13}{1,1}", "Your number times pi is ", dblEnterNumber.ToString("N2")));
        }//end of button event

        //method for Called to compute reference variables
        private void getValues(ref string strEnterAWordMethod3, ref double dblEnterNumber)
             {//begin method
            //Replace string computation
            strEnterAWordMethod3 = strEnterAWordMethod3.Replace(strEnterAWordMethod3, "Your word was replaced with a literal");
            //Times Number by PI computation
            dblEnterNumber = dblEnterNumber * 3.14;
           
        }//end method

        private void btnClearListbox_Click(object sender, EventArgs e)
        {
            {//opening eventhandler for clearing listbox output
                this.btnClearListbox3.Click += new System.EventHandler(this.btnClearListbox_Click);
                this.btnClearListbox2.Click += new System.EventHandler(this.btnClearListbox_Click);
                lstOutput.Items.Clear();
           
            }//end clear eventhandler button
        }
    }//end class
}//end namespace
 