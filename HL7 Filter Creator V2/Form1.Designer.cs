namespace HL7_Filter_Creator_V2
{
    partial class inputForm
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
            this.blockLabel = new System.Windows.Forms.Label();
            this.PV1CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.resultTypeCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.locationCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.createButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // blockLabel
            // 
            this.blockLabel.AutoSize = true;
            this.blockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blockLabel.Location = new System.Drawing.Point(12, 144);
            this.blockLabel.Name = "blockLabel";
            this.blockLabel.Size = new System.Drawing.Size(71, 25);
            this.blockLabel.TabIndex = 0;
            this.blockLabel.Text = "Block:";
            // 
            // PV1CheckedListBox
            // 
            this.PV1CheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PV1CheckedListBox.FormattingEnabled = true;
            this.PV1CheckedListBox.Items.AddRange(new object[] {
            "Inpatient",
            "Outpatient",
            "Preadmit",
            "Recurring",
            "Obstetrics",
            "Not Applicable",
            "Unknown",
            "Emergency"});
            this.PV1CheckedListBox.Location = new System.Drawing.Point(102, 144);
            this.PV1CheckedListBox.Name = "PV1CheckedListBox";
            this.PV1CheckedListBox.Size = new System.Drawing.Size(166, 186);
            this.PV1CheckedListBox.TabIndex = 1;
            // 
            // resultTypeCheckedListBox
            // 
            this.resultTypeCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTypeCheckedListBox.FormattingEnabled = true;
            this.resultTypeCheckedListBox.Items.AddRange(new object[] {
            "ADTs",
            "LABs",
            "RADs"});
            this.resultTypeCheckedListBox.Location = new System.Drawing.Point(274, 144);
            this.resultTypeCheckedListBox.Name = "resultTypeCheckedListBox";
            this.resultTypeCheckedListBox.Size = new System.Drawing.Size(166, 186);
            this.resultTypeCheckedListBox.TabIndex = 2;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromLabel.Location = new System.Drawing.Point(446, 144);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(67, 25);
            this.fromLabel.TabIndex = 3;
            this.fromLabel.Text = "From:";
            // 
            // locationCheckedListBox
            // 
            this.locationCheckedListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationCheckedListBox.FormattingEnabled = true;
            this.locationCheckedListBox.Items.AddRange(new object[] {
            "Quest Diagnostics Labaratory",
            "Mercy",
            "Trihealth",
            "Labcorps",
            "Children\'s Hospital"});
            this.locationCheckedListBox.Location = new System.Drawing.Point(519, 144);
            this.locationCheckedListBox.Name = "locationCheckedListBox";
            this.locationCheckedListBox.Size = new System.Drawing.Size(188, 186);
            this.locationCheckedListBox.TabIndex = 4;
            // 
            // createButton
            // 
            this.createButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.Location = new System.Drawing.Point(297, 376);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(124, 66);
            this.createButton.TabIndex = 5;
            this.createButton.Text = "Create Filter";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // inputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 475);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.locationCheckedListBox);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.resultTypeCheckedListBox);
            this.Controls.Add(this.PV1CheckedListBox);
            this.Controls.Add(this.blockLabel);
            this.Name = "inputForm";
            this.Text = "Configure Filter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label blockLabel;
        private System.Windows.Forms.CheckedListBox PV1CheckedListBox;
        private System.Windows.Forms.CheckedListBox resultTypeCheckedListBox;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.CheckedListBox locationCheckedListBox;
        private System.Windows.Forms.Button createButton;
    }
}

