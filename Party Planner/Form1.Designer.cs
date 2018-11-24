namespace Party_Planner
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudPeople = new System.Windows.Forms.NumericUpDown();
            this.chbFancyDecorations = new System.Windows.Forms.CheckBox();
            this.chbHealthyOption = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.TestBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPeople)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // nudPeople
            // 
            this.nudPeople.Location = new System.Drawing.Point(12, 25);
            this.nudPeople.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudPeople.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPeople.Name = "nudPeople";
            this.nudPeople.Size = new System.Drawing.Size(92, 20);
            this.nudPeople.TabIndex = 1;
            this.nudPeople.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPeople.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudPeople.ValueChanged += new System.EventHandler(this.nudPeople_ValueChanged);
            // 
            // chbFancyDecorations
            // 
            this.chbFancyDecorations.AutoSize = true;
            this.chbFancyDecorations.Checked = true;
            this.chbFancyDecorations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFancyDecorations.Location = new System.Drawing.Point(12, 51);
            this.chbFancyDecorations.Name = "chbFancyDecorations";
            this.chbFancyDecorations.Size = new System.Drawing.Size(115, 17);
            this.chbFancyDecorations.TabIndex = 2;
            this.chbFancyDecorations.Text = "Fancy Decorations";
            this.chbFancyDecorations.UseVisualStyleBackColor = true;
            this.chbFancyDecorations.CheckedChanged += new System.EventHandler(this.chbFancyDecorations_CheckedChanged);
            // 
            // chbHealthyOption
            // 
            this.chbHealthyOption.AutoSize = true;
            this.chbHealthyOption.Location = new System.Drawing.Point(12, 74);
            this.chbHealthyOption.Name = "chbHealthyOption";
            this.chbHealthyOption.Size = new System.Drawing.Size(96, 17);
            this.chbHealthyOption.TabIndex = 4;
            this.chbHealthyOption.Text = "Healthy Option";
            this.chbHealthyOption.UseVisualStyleBackColor = true;
            this.chbHealthyOption.CheckedChanged += new System.EventHandler(this.chbHealthyOption_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cost";
            // 
            // lblCost
            // 
            this.lblCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(58, 106);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(80, 19);
            this.lblCost.TabIndex = 6;
            // 
            // TestBox
            // 
            this.TestBox.FormattingEnabled = true;
            this.TestBox.Location = new System.Drawing.Point(49, 214);
            this.TestBox.Name = "TestBox";
            this.TestBox.Size = new System.Drawing.Size(120, 95);
            this.TestBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 355);
            this.Controls.Add(this.TestBox);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbHealthyOption);
            this.Controls.Add(this.chbFancyDecorations);
            this.Controls.Add(this.nudPeople);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.nudPeople)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudPeople;
        private System.Windows.Forms.CheckBox chbFancyDecorations;
        private System.Windows.Forms.CheckBox chbHealthyOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.ListBox TestBox;
    }
}

