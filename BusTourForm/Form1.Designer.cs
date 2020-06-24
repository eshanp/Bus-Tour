namespace BusTourForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.DetailsGroupBox = new System.Windows.Forms.GroupBox();
            this.DiscountRiderTextBox = new System.Windows.Forms.TextBox();
            this.StudentRiderTextBox = new System.Windows.Forms.TextBox();
            this.FullFareRiderTextBox = new System.Windows.Forms.TextBox();
            this.DriverNameTextBox = new System.Windows.Forms.TextBox();
            this.DiscountRiderLabel = new System.Windows.Forms.Label();
            this.StudentRiderLabel = new System.Windows.Forms.Label();
            this.FullFareRiderLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DriverNameLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CalculateGroupBox = new System.Windows.Forms.GroupBox();
            this.CalculateAvgReceiptsDisplayLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CalculateTotalReceiptsDisplayLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CalculateTotalPassengerDisplayLabel = new System.Windows.Forms.Label();
            this.CalculateTotalPassengerLabel = new System.Windows.Forms.Label();
            this.CalculateDriverNameDisplayLabel = new System.Windows.Forms.Label();
            this.CalculateDriverNameLabel = new System.Windows.Forms.Label();
            this.SummaryGroupBox = new System.Windows.Forms.GroupBox();
            this.SummaryAvgReceiptsDisplayLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SummaryTotalReceiptsDisplayLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SummaryTotalPassengerDisplayLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SummaryNoOfDriverDisplayLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DetailsGroupBox.SuspendLayout();
            this.CalculateGroupBox.SuspendLayout();
            this.SummaryGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.Location = new System.Drawing.Point(152, 13);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(241, 26);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Daily Tours Summary";
            // 
            // DetailsGroupBox
            // 
            this.DetailsGroupBox.Controls.Add(this.DiscountRiderTextBox);
            this.DetailsGroupBox.Controls.Add(this.StudentRiderTextBox);
            this.DetailsGroupBox.Controls.Add(this.FullFareRiderTextBox);
            this.DetailsGroupBox.Controls.Add(this.DriverNameTextBox);
            this.DetailsGroupBox.Controls.Add(this.DiscountRiderLabel);
            this.DetailsGroupBox.Controls.Add(this.StudentRiderLabel);
            this.DetailsGroupBox.Controls.Add(this.FullFareRiderLabel);
            this.DetailsGroupBox.Controls.Add(this.label2);
            this.DetailsGroupBox.Controls.Add(this.DriverNameLabel);
            this.DetailsGroupBox.Location = new System.Drawing.Point(115, 48);
            this.DetailsGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.DetailsGroupBox.Name = "DetailsGroupBox";
            this.DetailsGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.DetailsGroupBox.Size = new System.Drawing.Size(305, 156);
            this.DetailsGroupBox.TabIndex = 0;
            this.DetailsGroupBox.TabStop = false;
            // 
            // DiscountRiderTextBox
            // 
            this.DiscountRiderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountRiderTextBox.Location = new System.Drawing.Point(199, 114);
            this.DiscountRiderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DiscountRiderTextBox.Name = "DiscountRiderTextBox";
            this.DiscountRiderTextBox.Size = new System.Drawing.Size(44, 20);
            this.DiscountRiderTextBox.TabIndex = 3;
            this.DiscountRiderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StudentRiderTextBox
            // 
            this.StudentRiderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRiderTextBox.Location = new System.Drawing.Point(199, 89);
            this.StudentRiderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.StudentRiderTextBox.Name = "StudentRiderTextBox";
            this.StudentRiderTextBox.Size = new System.Drawing.Size(44, 20);
            this.StudentRiderTextBox.TabIndex = 2;
            this.StudentRiderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FullFareRiderTextBox
            // 
            this.FullFareRiderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullFareRiderTextBox.Location = new System.Drawing.Point(199, 62);
            this.FullFareRiderTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FullFareRiderTextBox.Name = "FullFareRiderTextBox";
            this.FullFareRiderTextBox.Size = new System.Drawing.Size(44, 20);
            this.FullFareRiderTextBox.TabIndex = 1;
            this.FullFareRiderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DriverNameTextBox
            // 
            this.DriverNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverNameTextBox.Location = new System.Drawing.Point(136, 24);
            this.DriverNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.DriverNameTextBox.Name = "DriverNameTextBox";
            this.DriverNameTextBox.Size = new System.Drawing.Size(131, 20);
            this.DriverNameTextBox.TabIndex = 0;
            this.DriverNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DiscountRiderLabel
            // 
            this.DiscountRiderLabel.AutoSize = true;
            this.DiscountRiderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountRiderLabel.Location = new System.Drawing.Point(61, 116);
            this.DiscountRiderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiscountRiderLabel.Name = "DiscountRiderLabel";
            this.DiscountRiderLabel.Size = new System.Drawing.Size(109, 15);
            this.DiscountRiderLabel.TabIndex = 2;
            this.DiscountRiderLabel.Text = "Discount Riders";
            // 
            // StudentRiderLabel
            // 
            this.StudentRiderLabel.AutoSize = true;
            this.StudentRiderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentRiderLabel.Location = new System.Drawing.Point(61, 91);
            this.StudentRiderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudentRiderLabel.Name = "StudentRiderLabel";
            this.StudentRiderLabel.Size = new System.Drawing.Size(102, 15);
            this.StudentRiderLabel.TabIndex = 3;
            this.StudentRiderLabel.Text = "Student Riders";
            // 
            // FullFareRiderLabel
            // 
            this.FullFareRiderLabel.AutoSize = true;
            this.FullFareRiderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullFareRiderLabel.Location = new System.Drawing.Point(61, 66);
            this.FullFareRiderLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FullFareRiderLabel.Name = "FullFareRiderLabel";
            this.FullFareRiderLabel.Size = new System.Drawing.Size(110, 15);
            this.FullFareRiderLabel.TabIndex = 4;
            this.FullFareRiderLabel.Text = "Full Fare Riders";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(20, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 2);
            this.label2.TabIndex = 5;
            // 
            // DriverNameLabel
            // 
            this.DriverNameLabel.AutoSize = true;
            this.DriverNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DriverNameLabel.Location = new System.Drawing.Point(23, 26);
            this.DriverNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DriverNameLabel.Name = "DriverNameLabel";
            this.DriverNameLabel.Size = new System.Drawing.Size(94, 15);
            this.DriverNameLabel.TabIndex = 1;
            this.DriverNameLabel.Text = "Drivers Name";
            // 
            // CalculateButton
            // 
            this.CalculateButton.BackColor = System.Drawing.SystemColors.Info;
            this.CalculateButton.Location = new System.Drawing.Point(115, 238);
            this.CalculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(65, 23);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "C&alculate";
            this.CalculateButton.UseVisualStyleBackColor = false;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.Info;
            this.ClearButton.Location = new System.Drawing.Point(193, 238);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(65, 23);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "&Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SummaryButton
            // 
            this.SummaryButton.BackColor = System.Drawing.SystemColors.Info;
            this.SummaryButton.Enabled = false;
            this.SummaryButton.Location = new System.Drawing.Point(276, 238);
            this.SummaryButton.Margin = new System.Windows.Forms.Padding(2);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(65, 23);
            this.SummaryButton.TabIndex = 3;
            this.SummaryButton.Text = "&Summary";
            this.toolTip1.SetToolTip(this.SummaryButton, "Press for company summary data");
            this.SummaryButton.UseVisualStyleBackColor = false;
            this.SummaryButton.Click += new System.EventHandler(this.SummaryButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.Info;
            this.ExitButton.Location = new System.Drawing.Point(355, 238);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(65, 23);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CalculateGroupBox
            // 
            this.CalculateGroupBox.Controls.Add(this.CalculateAvgReceiptsDisplayLabel);
            this.CalculateGroupBox.Controls.Add(this.label8);
            this.CalculateGroupBox.Controls.Add(this.CalculateTotalReceiptsDisplayLabel);
            this.CalculateGroupBox.Controls.Add(this.label6);
            this.CalculateGroupBox.Controls.Add(this.CalculateTotalPassengerDisplayLabel);
            this.CalculateGroupBox.Controls.Add(this.CalculateTotalPassengerLabel);
            this.CalculateGroupBox.Controls.Add(this.CalculateDriverNameDisplayLabel);
            this.CalculateGroupBox.Controls.Add(this.CalculateDriverNameLabel);
            this.CalculateGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateGroupBox.Location = new System.Drawing.Point(115, 296);
            this.CalculateGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.CalculateGroupBox.Name = "CalculateGroupBox";
            this.CalculateGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.CalculateGroupBox.Size = new System.Drawing.Size(295, 180);
            this.CalculateGroupBox.TabIndex = 6;
            this.CalculateGroupBox.TabStop = false;
            this.CalculateGroupBox.Text = "Driver Summary Data";
            this.CalculateGroupBox.Visible = false;
            // 
            // CalculateAvgReceiptsDisplayLabel
            // 
            this.CalculateAvgReceiptsDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalculateAvgReceiptsDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalculateAvgReceiptsDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateAvgReceiptsDisplayLabel.Location = new System.Drawing.Point(190, 130);
            this.CalculateAvgReceiptsDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CalculateAvgReceiptsDisplayLabel.Name = "CalculateAvgReceiptsDisplayLabel";
            this.CalculateAvgReceiptsDisplayLabel.Size = new System.Drawing.Size(100, 22);
            this.CalculateAvgReceiptsDisplayLabel.TabIndex = 7;
            this.CalculateAvgReceiptsDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 15);
            this.label8.TabIndex = 6;
            this.label8.Text = "Avg Passenger Receipts";
            // 
            // CalculateTotalReceiptsDisplayLabel
            // 
            this.CalculateTotalReceiptsDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalculateTotalReceiptsDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalculateTotalReceiptsDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateTotalReceiptsDisplayLabel.Location = new System.Drawing.Point(190, 99);
            this.CalculateTotalReceiptsDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CalculateTotalReceiptsDisplayLabel.Name = "CalculateTotalReceiptsDisplayLabel";
            this.CalculateTotalReceiptsDisplayLabel.Size = new System.Drawing.Size(100, 21);
            this.CalculateTotalReceiptsDisplayLabel.TabIndex = 5;
            this.CalculateTotalReceiptsDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(25, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Total Receipts";
            // 
            // CalculateTotalPassengerDisplayLabel
            // 
            this.CalculateTotalPassengerDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalculateTotalPassengerDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalculateTotalPassengerDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateTotalPassengerDisplayLabel.Location = new System.Drawing.Point(190, 66);
            this.CalculateTotalPassengerDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CalculateTotalPassengerDisplayLabel.Name = "CalculateTotalPassengerDisplayLabel";
            this.CalculateTotalPassengerDisplayLabel.Size = new System.Drawing.Size(100, 22);
            this.CalculateTotalPassengerDisplayLabel.TabIndex = 3;
            this.CalculateTotalPassengerDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateTotalPassengerLabel
            // 
            this.CalculateTotalPassengerLabel.AutoSize = true;
            this.CalculateTotalPassengerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateTotalPassengerLabel.Location = new System.Drawing.Point(25, 66);
            this.CalculateTotalPassengerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CalculateTotalPassengerLabel.Name = "CalculateTotalPassengerLabel";
            this.CalculateTotalPassengerLabel.Size = new System.Drawing.Size(118, 15);
            this.CalculateTotalPassengerLabel.TabIndex = 2;
            this.CalculateTotalPassengerLabel.Text = "Total Passengers";
            // 
            // CalculateDriverNameDisplayLabel
            // 
            this.CalculateDriverNameDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CalculateDriverNameDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CalculateDriverNameDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateDriverNameDisplayLabel.Location = new System.Drawing.Point(190, 31);
            this.CalculateDriverNameDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CalculateDriverNameDisplayLabel.Name = "CalculateDriverNameDisplayLabel";
            this.CalculateDriverNameDisplayLabel.Size = new System.Drawing.Size(100, 22);
            this.CalculateDriverNameDisplayLabel.TabIndex = 1;
            this.CalculateDriverNameDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateDriverNameLabel
            // 
            this.CalculateDriverNameLabel.AutoSize = true;
            this.CalculateDriverNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateDriverNameLabel.Location = new System.Drawing.Point(25, 31);
            this.CalculateDriverNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CalculateDriverNameLabel.Name = "CalculateDriverNameLabel";
            this.CalculateDriverNameLabel.Size = new System.Drawing.Size(87, 15);
            this.CalculateDriverNameLabel.TabIndex = 0;
            this.CalculateDriverNameLabel.Text = "Driver Name";
            // 
            // SummaryGroupBox
            // 
            this.SummaryGroupBox.Controls.Add(this.SummaryAvgReceiptsDisplayLabel);
            this.SummaryGroupBox.Controls.Add(this.label3);
            this.SummaryGroupBox.Controls.Add(this.SummaryTotalReceiptsDisplayLabel);
            this.SummaryGroupBox.Controls.Add(this.label5);
            this.SummaryGroupBox.Controls.Add(this.SummaryTotalPassengerDisplayLabel);
            this.SummaryGroupBox.Controls.Add(this.label9);
            this.SummaryGroupBox.Controls.Add(this.SummaryNoOfDriverDisplayLabel);
            this.SummaryGroupBox.Controls.Add(this.label11);
            this.SummaryGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryGroupBox.Location = new System.Drawing.Point(115, 296);
            this.SummaryGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.SummaryGroupBox.Name = "SummaryGroupBox";
            this.SummaryGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.SummaryGroupBox.Size = new System.Drawing.Size(305, 187);
            this.SummaryGroupBox.TabIndex = 7;
            this.SummaryGroupBox.TabStop = false;
            this.SummaryGroupBox.Text = "Company Summary Data";
            this.SummaryGroupBox.Visible = false;
            // 
            // SummaryAvgReceiptsDisplayLabel
            // 
            this.SummaryAvgReceiptsDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SummaryAvgReceiptsDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryAvgReceiptsDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryAvgReceiptsDisplayLabel.Location = new System.Drawing.Point(189, 127);
            this.SummaryAvgReceiptsDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SummaryAvgReceiptsDisplayLabel.Name = "SummaryAvgReceiptsDisplayLabel";
            this.SummaryAvgReceiptsDisplayLabel.Size = new System.Drawing.Size(102, 21);
            this.SummaryAvgReceiptsDisplayLabel.TabIndex = 7;
            this.SummaryAvgReceiptsDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Avg Passenger Receipts";
            // 
            // SummaryTotalReceiptsDisplayLabel
            // 
            this.SummaryTotalReceiptsDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SummaryTotalReceiptsDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryTotalReceiptsDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTotalReceiptsDisplayLabel.Location = new System.Drawing.Point(189, 93);
            this.SummaryTotalReceiptsDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SummaryTotalReceiptsDisplayLabel.Name = "SummaryTotalReceiptsDisplayLabel";
            this.SummaryTotalReceiptsDisplayLabel.Size = new System.Drawing.Size(102, 21);
            this.SummaryTotalReceiptsDisplayLabel.TabIndex = 6;
            this.SummaryTotalReceiptsDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total Receipts";
            // 
            // SummaryTotalPassengerDisplayLabel
            // 
            this.SummaryTotalPassengerDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SummaryTotalPassengerDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryTotalPassengerDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryTotalPassengerDisplayLabel.Location = new System.Drawing.Point(190, 59);
            this.SummaryTotalPassengerDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SummaryTotalPassengerDisplayLabel.Name = "SummaryTotalPassengerDisplayLabel";
            this.SummaryTotalPassengerDisplayLabel.Size = new System.Drawing.Size(101, 21);
            this.SummaryTotalPassengerDisplayLabel.TabIndex = 5;
            this.SummaryTotalPassengerDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 66);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Passengers";
            // 
            // SummaryNoOfDriverDisplayLabel
            // 
            this.SummaryNoOfDriverDisplayLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SummaryNoOfDriverDisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SummaryNoOfDriverDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SummaryNoOfDriverDisplayLabel.Location = new System.Drawing.Point(190, 24);
            this.SummaryNoOfDriverDisplayLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SummaryNoOfDriverDisplayLabel.Name = "SummaryNoOfDriverDisplayLabel";
            this.SummaryNoOfDriverDisplayLabel.Size = new System.Drawing.Size(101, 22);
            this.SummaryNoOfDriverDisplayLabel.TabIndex = 4;
            this.SummaryNoOfDriverDisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 15);
            this.label11.TabIndex = 3;
            this.label11.Text = "Total Drivers";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 550);
            this.Controls.Add(this.SummaryGroupBox);
            this.Controls.Add(this.CalculateGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.SummaryButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.DetailsGroupBox);
            this.Controls.Add(this.HeaderLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Mild Atlantic Bus Tours";
            this.DetailsGroupBox.ResumeLayout(false);
            this.DetailsGroupBox.PerformLayout();
            this.CalculateGroupBox.ResumeLayout(false);
            this.CalculateGroupBox.PerformLayout();
            this.SummaryGroupBox.ResumeLayout(false);
            this.SummaryGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.GroupBox DetailsGroupBox;
        private System.Windows.Forms.TextBox DiscountRiderTextBox;
        private System.Windows.Forms.TextBox StudentRiderTextBox;
        private System.Windows.Forms.TextBox FullFareRiderTextBox;
        private System.Windows.Forms.TextBox DriverNameTextBox;
        private System.Windows.Forms.Label DiscountRiderLabel;
        private System.Windows.Forms.Label StudentRiderLabel;
        private System.Windows.Forms.Label FullFareRiderLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label DriverNameLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox CalculateGroupBox;
        private System.Windows.Forms.Label CalculateAvgReceiptsDisplayLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CalculateTotalReceiptsDisplayLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CalculateTotalPassengerDisplayLabel;
        private System.Windows.Forms.Label CalculateTotalPassengerLabel;
        private System.Windows.Forms.Label CalculateDriverNameDisplayLabel;
        private System.Windows.Forms.Label CalculateDriverNameLabel;
        private System.Windows.Forms.GroupBox SummaryGroupBox;
        private System.Windows.Forms.Label SummaryAvgReceiptsDisplayLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SummaryTotalReceiptsDisplayLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label SummaryTotalPassengerDisplayLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label SummaryNoOfDriverDisplayLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

