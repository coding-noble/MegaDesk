namespace MegaDesk
{
    partial class AddQuote
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.drawerCountLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.rushDaysLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.addQuoteTitle = new System.Windows.Forms.Label();
            this.materialSelection = new System.Windows.Forms.ComboBox();
            this.depthSelection = new System.Windows.Forms.TextBox();
            this.widthSelection = new System.Windows.Forms.TextBox();
            this.numDrawersSelection = new System.Windows.Forms.TextBox();
            this.rushDaySelection = new System.Windows.Forms.TextBox();
            this.widthInvalidType = new System.Windows.Forms.Label();
            this.widthToSmallLabel = new System.Windows.Forms.Label();
            this.widthToBigLabel = new System.Windows.Forms.Label();
            this.rushInvalidType = new System.Windows.Forms.Label();
            this.materialTypeInvalid = new System.Windows.Forms.Label();
            this.tooManyDrawersLabel = new System.Windows.Forms.Label();
            this.notEnoughDrawersLabel = new System.Windows.Forms.Label();
            this.depthToBigLabel = new System.Windows.Forms.Label();
            this.depthToSmallLabel = new System.Windows.Forms.Label();
            this.depthTypeInvalid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(17, 294);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(171, 51);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "&Cancel Quote";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(46, 53);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(142, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Customer Name:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(95, 93);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(93, 20);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "Width (In):";
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(92, 133);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(96, 20);
            this.depthLabel.TabIndex = 3;
            this.depthLabel.Text = "Depth (In):";
            // 
            // drawerCountLabel
            // 
            this.drawerCountLabel.AutoSize = true;
            this.drawerCountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerCountLabel.Location = new System.Drawing.Point(20, 173);
            this.drawerCountLabel.Name = "drawerCountLabel";
            this.drawerCountLabel.Size = new System.Drawing.Size(168, 20);
            this.drawerCountLabel.TabIndex = 4;
            this.drawerCountLabel.Text = "Number of Drawers:";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(42, 213);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(146, 20);
            this.materialLabel.TabIndex = 5;
            this.materialLabel.Text = "Surface Material:";
            // 
            // rushDaysLabel
            // 
            this.rushDaysLabel.AutoSize = true;
            this.rushDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushDaysLabel.Location = new System.Drawing.Point(59, 253);
            this.rushDaysLabel.Name = "rushDaysLabel";
            this.rushDaysLabel.Size = new System.Drawing.Size(129, 20);
            this.rushDaysLabel.TabIndex = 6;
            this.rushDaysLabel.Text = "Shipping Days:";
            // 
            // submitButton
            // 
            this.submitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(194, 294);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(171, 51);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "&Submit Quote";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameInput.Location = new System.Drawing.Point(195, 50);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(150, 26);
            this.nameInput.TabIndex = 8;
            // 
            // addQuoteTitle
            // 
            this.addQuoteTitle.AutoSize = true;
            this.addQuoteTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteTitle.Location = new System.Drawing.Point(101, 10);
            this.addQuoteTitle.Name = "addQuoteTitle";
            this.addQuoteTitle.Size = new System.Drawing.Size(197, 29);
            this.addQuoteTitle.TabIndex = 9;
            this.addQuoteTitle.Text = "Add New Quote";
            // 
            // materialSelection
            // 
            this.materialSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialSelection.FormattingEnabled = true;
            this.materialSelection.Items.AddRange(new object[] {
            "Laminate",
            "Oak",
            "Pine",
            "Rosewood",
            "Veneer"});
            this.materialSelection.Location = new System.Drawing.Point(195, 210);
            this.materialSelection.Name = "materialSelection";
            this.materialSelection.Size = new System.Drawing.Size(150, 28);
            this.materialSelection.TabIndex = 13;
            // 
            // depthSelection
            // 
            this.depthSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthSelection.Location = new System.Drawing.Point(195, 130);
            this.depthSelection.Name = "depthSelection";
            this.depthSelection.Size = new System.Drawing.Size(150, 26);
            this.depthSelection.TabIndex = 15;
            this.depthSelection.KeyUp += new System.Windows.Forms.KeyEventHandler(this.depthSelection_KeyUp);
            // 
            // widthSelection
            // 
            this.widthSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthSelection.Location = new System.Drawing.Point(195, 90);
            this.widthSelection.Name = "widthSelection";
            this.widthSelection.Size = new System.Drawing.Size(150, 26);
            this.widthSelection.TabIndex = 16;
            this.widthSelection.Validating += new System.ComponentModel.CancelEventHandler(this.widthSelection_Validating);
            // 
            // numDrawersSelection
            // 
            this.numDrawersSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrawersSelection.Location = new System.Drawing.Point(195, 170);
            this.numDrawersSelection.Name = "numDrawersSelection";
            this.numDrawersSelection.Size = new System.Drawing.Size(150, 26);
            this.numDrawersSelection.TabIndex = 17;
            this.numDrawersSelection.Validating += new System.ComponentModel.CancelEventHandler(this.numDrawersSelection_Validating);
            // 
            // rushDaySelection
            // 
            this.rushDaySelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushDaySelection.Location = new System.Drawing.Point(195, 250);
            this.rushDaySelection.Name = "rushDaySelection";
            this.rushDaySelection.Size = new System.Drawing.Size(150, 26);
            this.rushDaySelection.TabIndex = 18;
            this.rushDaySelection.Validating += new System.ComponentModel.CancelEventHandler(this.rushDaySelection_Validating);
            // 
            // widthInvalidType
            // 
            this.widthInvalidType.AutoSize = true;
            this.widthInvalidType.ForeColor = System.Drawing.Color.Red;
            this.widthInvalidType.Location = new System.Drawing.Point(77, 78);
            this.widthInvalidType.Name = "widthInvalidType";
            this.widthInvalidType.Size = new System.Drawing.Size(111, 13);
            this.widthInvalidType.TabIndex = 0;
            this.widthInvalidType.Text = "Plese Enter A Number";
            this.widthInvalidType.Visible = false;
            // 
            // widthToSmallLabel
            // 
            this.widthToSmallLabel.AutoSize = true;
            this.widthToSmallLabel.ForeColor = System.Drawing.Color.Red;
            this.widthToSmallLabel.Location = new System.Drawing.Point(35, 78);
            this.widthToSmallLabel.Name = "widthToSmallLabel";
            this.widthToSmallLabel.Size = new System.Drawing.Size(153, 13);
            this.widthToSmallLabel.TabIndex = 19;
            this.widthToSmallLabel.Text = "Width Must Be Larger Than 24";
            this.widthToSmallLabel.Visible = false;
            // 
            // widthToBigLabel
            // 
            this.widthToBigLabel.AutoSize = true;
            this.widthToBigLabel.ForeColor = System.Drawing.Color.Red;
            this.widthToBigLabel.Location = new System.Drawing.Point(31, 78);
            this.widthToBigLabel.Name = "widthToBigLabel";
            this.widthToBigLabel.Size = new System.Drawing.Size(157, 13);
            this.widthToBigLabel.TabIndex = 20;
            this.widthToBigLabel.Text = "Width Must Be Smaller Than 96";
            this.widthToBigLabel.Visible = false;
            // 
            // rushInvalidType
            // 
            this.rushInvalidType.AutoSize = true;
            this.rushInvalidType.ForeColor = System.Drawing.Color.Red;
            this.rushInvalidType.Location = new System.Drawing.Point(71, 240);
            this.rushInvalidType.Name = "rushInvalidType";
            this.rushInvalidType.Size = new System.Drawing.Size(117, 13);
            this.rushInvalidType.TabIndex = 21;
            this.rushInvalidType.Text = "Please Enter A Number";
            this.rushInvalidType.Visible = false;
            // 
            // materialTypeInvalid
            // 
            this.materialTypeInvalid.AutoSize = true;
            this.materialTypeInvalid.ForeColor = System.Drawing.Color.Red;
            this.materialTypeInvalid.Location = new System.Drawing.Point(71, 160);
            this.materialTypeInvalid.Name = "materialTypeInvalid";
            this.materialTypeInvalid.Size = new System.Drawing.Size(117, 13);
            this.materialTypeInvalid.TabIndex = 22;
            this.materialTypeInvalid.Text = "Please Enter A Number";
            this.materialTypeInvalid.Visible = false;
            // 
            // tooManyDrawersLabel
            // 
            this.tooManyDrawersLabel.AutoSize = true;
            this.tooManyDrawersLabel.ForeColor = System.Drawing.Color.Red;
            this.tooManyDrawersLabel.Location = new System.Drawing.Point(23, 160);
            this.tooManyDrawersLabel.Name = "tooManyDrawersLabel";
            this.tooManyDrawersLabel.Size = new System.Drawing.Size(165, 13);
            this.tooManyDrawersLabel.TabIndex = 23;
            this.tooManyDrawersLabel.Text = "The Max Number Of Drawers Is 7";
            this.tooManyDrawersLabel.Visible = false;
            // 
            // notEnoughDrawersLabel
            // 
            this.notEnoughDrawersLabel.AutoSize = true;
            this.notEnoughDrawersLabel.ForeColor = System.Drawing.Color.Red;
            this.notEnoughDrawersLabel.Location = new System.Drawing.Point(23, 160);
            this.notEnoughDrawersLabel.Name = "notEnoughDrawersLabel";
            this.notEnoughDrawersLabel.Size = new System.Drawing.Size(162, 13);
            this.notEnoughDrawersLabel.TabIndex = 24;
            this.notEnoughDrawersLabel.Text = "The Min Number Of Drawers Is 0";
            this.notEnoughDrawersLabel.Visible = false;
            // 
            // depthToBigLabel
            // 
            this.depthToBigLabel.AutoSize = true;
            this.depthToBigLabel.ForeColor = System.Drawing.Color.Red;
            this.depthToBigLabel.Location = new System.Drawing.Point(31, 120);
            this.depthToBigLabel.Name = "depthToBigLabel";
            this.depthToBigLabel.Size = new System.Drawing.Size(158, 13);
            this.depthToBigLabel.TabIndex = 25;
            this.depthToBigLabel.Text = "Depth Must Be Smaller Than 48";
            this.depthToBigLabel.Visible = false;
            // 
            // depthToSmallLabel
            // 
            this.depthToSmallLabel.AutoSize = true;
            this.depthToSmallLabel.ForeColor = System.Drawing.Color.Red;
            this.depthToSmallLabel.Location = new System.Drawing.Point(31, 120);
            this.depthToSmallLabel.Name = "depthToSmallLabel";
            this.depthToSmallLabel.Size = new System.Drawing.Size(154, 13);
            this.depthToSmallLabel.TabIndex = 26;
            this.depthToSmallLabel.Text = "Depth Must Be Larger Than 12";
            this.depthToSmallLabel.Visible = false;
            // 
            // depthTypeInvalid
            // 
            this.depthTypeInvalid.AutoSize = true;
            this.depthTypeInvalid.ForeColor = System.Drawing.Color.Red;
            this.depthTypeInvalid.Location = new System.Drawing.Point(68, 120);
            this.depthTypeInvalid.Name = "depthTypeInvalid";
            this.depthTypeInvalid.Size = new System.Drawing.Size(117, 13);
            this.depthTypeInvalid.TabIndex = 27;
            this.depthTypeInvalid.Text = "Please Enter A Number";
            this.depthTypeInvalid.Visible = false;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.depthTypeInvalid);
            this.Controls.Add(this.depthToSmallLabel);
            this.Controls.Add(this.depthToBigLabel);
            this.Controls.Add(this.notEnoughDrawersLabel);
            this.Controls.Add(this.tooManyDrawersLabel);
            this.Controls.Add(this.materialTypeInvalid);
            this.Controls.Add(this.rushInvalidType);
            this.Controls.Add(this.widthToBigLabel);
            this.Controls.Add(this.widthToSmallLabel);
            this.Controls.Add(this.widthInvalidType);
            this.Controls.Add(this.rushDaySelection);
            this.Controls.Add(this.numDrawersSelection);
            this.Controls.Add(this.widthSelection);
            this.Controls.Add(this.depthSelection);
            this.Controls.Add(this.materialSelection);
            this.Controls.Add(this.addQuoteTitle);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.rushDaysLabel);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.drawerCountLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cancelButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label drawerCountLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Label rushDaysLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label addQuoteTitle;
        private System.Windows.Forms.ComboBox materialSelection;
        private System.Windows.Forms.TextBox depthSelection;
        private System.Windows.Forms.TextBox widthSelection;
        private System.Windows.Forms.TextBox numDrawersSelection;
        private System.Windows.Forms.TextBox rushDaySelection;
        private System.Windows.Forms.Label widthInvalidType;
        private System.Windows.Forms.Label widthToSmallLabel;
        private System.Windows.Forms.Label widthToBigLabel;
        private System.Windows.Forms.Label rushInvalidType;
        private System.Windows.Forms.Label materialTypeInvalid;
        private System.Windows.Forms.Label tooManyDrawersLabel;
        private System.Windows.Forms.Label notEnoughDrawersLabel;
        private System.Windows.Forms.Label depthToBigLabel;
        private System.Windows.Forms.Label depthToSmallLabel;
        private System.Windows.Forms.Label depthTypeInvalid;
    }
}