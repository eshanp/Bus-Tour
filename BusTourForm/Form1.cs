using System;
using System.Windows.Forms;
using System.Globalization;

namespace BusTourForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Declaration of Global Variables.
        decimal FullFare = 5.50m, StudentFare = 4.50m, DiscountFare = 3.75m, TotalReceipts;
        int TotalDrivers, TotalPassengers;

        //Clears and sets the form for next user input. 
        private void ClearButton_Click(object sender, EventArgs e)
        {   //Visible and enabled status are changed to default.
            DetailsGroupBox.Enabled = true;
            DetailsGroupBox.Visible = true;
            CalculateGroupBox.Visible = false;
            SummaryGroupBox.Visible = false;

            //String boxes for input is emptied.
            FullFareRiderTextBox.Text = string.Empty;
            StudentRiderTextBox.Text = string.Empty;
            DiscountRiderTextBox.Text = string.Empty;
            DriverNameTextBox.Text = string.Empty;
            DriverNameTextBox.Focus();
            CalculateButton.Enabled = true;
            SummaryButton.Enabled = false;
        }

        //Displays Summary of all company drivers.
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            
            SummaryNoOfDriverDisplayLabel.Text = TotalDrivers.ToString();
            //Changes the visibility and enable status.
            DetailsGroupBox.Visible = false;
            DetailsGroupBox.Enabled = true;
            SummaryGroupBox.Visible = true;
            CalculateGroupBox.Visible = false;
            //Displays the calculates values.
            SummaryTotalPassengerDisplayLabel.Text = TotalPassengers.ToString();
            SummaryTotalReceiptsDisplayLabel.Text = TotalReceipts.ToString();
            SummaryAvgReceiptsDisplayLabel.Text=(TotalReceipts / TotalPassengers).ToString("c", new CultureInfo("en-FR"));
        }

        
        //Closes the application.
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //Declaring local variables.
            int NoOfFullFareRider = 0, NoOfStudentRider = 0, NoOfDiscountRider = 0, NoOfTotalPassenger = 0;
            decimal Receipt =0m;
            
            //Checks if Driver name is given.
            if (DriverNameTextBox.Text != "")
            {
                //Parsing is done in all try blocks.
                try
                {
                    NoOfFullFareRider = int.Parse(FullFareRiderTextBox.Text);

                    try
                    {
                        NoOfStudentRider = int.Parse(StudentRiderTextBox.Text);

                        try
                        {
                            NoOfDiscountRider = int.Parse(DiscountRiderTextBox.Text);
                            
                            //Passengers are calculated for the particular driver.
                            NoOfTotalPassenger = NoOfFullFareRider + NoOfStudentRider + NoOfDiscountRider;

                            //Global variables for count is incremented.
                            TotalDrivers += 1;
                            TotalPassengers = TotalPassengers + NoOfTotalPassenger;

                            //Calculation and visibile change are done.
                            Receipt = (NoOfFullFareRider * FullFare) + (NoOfStudentRider * StudentFare) + (NoOfDiscountRider * DiscountFare);
                            TotalReceipts = TotalReceipts + Receipt;
                            CalculateButton.Enabled = false;
                            SummaryButton.Enabled = true;
                            DetailsGroupBox.Enabled = false;
                            CalculateGroupBox.Visible = true;

                            //Calculated summary for particular driver is displayed.
                            CalculateDriverNameDisplayLabel.Text = DriverNameTextBox.Text;
                            CalculateTotalPassengerDisplayLabel.Text = NoOfTotalPassenger.ToString();
                            CalculateTotalReceiptsDisplayLabel.Text = Receipt.ToString("c", new CultureInfo("en-FR"));
                            CalculateAvgReceiptsDisplayLabel.Text = (Receipt / NoOfTotalPassenger).ToString("c", new CultureInfo("en-FR"));
 }
                        //Try exceptions thrown are handled by catch blocks.
                        catch
                        {

                            MessageBox.Show("Please enter numerical discount rider", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            DiscountRiderTextBox.Focus();
                            DiscountRiderTextBox.SelectAll();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Please enter numerical Student rider", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        StudentRiderTextBox.Focus();
                        StudentRiderTextBox.SelectAll();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter numerical Full Fare rider", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FullFareRiderTextBox.Focus();
                    FullFareRiderTextBox.SelectAll();
                }
            }
            else
            {
                //Exception if driver name text box is left empty.
                MessageBox.Show("Please enter driver name", "Enter data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DriverNameTextBox.Focus();
            }
        }
        }
    }
