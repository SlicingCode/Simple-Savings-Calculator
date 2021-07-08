
namespace Simple_Savings_Calculator
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
            this.LblDeposit = new System.Windows.Forms.Label();
            this.LblWeeks = new System.Windows.Forms.Label();
            this.LblSavings = new System.Windows.Forms.Label();
            this.TxtDeposit = new System.Windows.Forms.TextBox();
            this.TxtWeeks = new System.Windows.Forms.TextBox();
            this.TxtSavings = new System.Windows.Forms.TextBox();
            this.BtnEnter = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblDeposit
            // 
            this.LblDeposit.AutoSize = true;
            this.LblDeposit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeposit.Location = new System.Drawing.Point(12, 22);
            this.LblDeposit.Name = "LblDeposit";
            this.LblDeposit.Size = new System.Drawing.Size(130, 18);
            this.LblDeposit.TabIndex = 0;
            this.LblDeposit.Text = "Weekly Deposit";
            // 
            // LblWeeks
            // 
            this.LblWeeks.AutoSize = true;
            this.LblWeeks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWeeks.Location = new System.Drawing.Point(12, 57);
            this.LblWeeks.Name = "LblWeeks";
            this.LblWeeks.Size = new System.Drawing.Size(147, 18);
            this.LblWeeks.TabIndex = 1;
            this.LblWeeks.Text = "Number of Weeks";
            // 
            // LblSavings
            // 
            this.LblSavings.AutoSize = true;
            this.LblSavings.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSavings.Location = new System.Drawing.Point(12, 95);
            this.LblSavings.Name = "LblSavings";
            this.LblSavings.Size = new System.Drawing.Size(115, 18);
            this.LblSavings.TabIndex = 2;
            this.LblSavings.Text = "Total Savings";
            // 
            // TxtDeposit
            // 
            this.TxtDeposit.Location = new System.Drawing.Point(216, 20);
            this.TxtDeposit.Name = "TxtDeposit";
            this.TxtDeposit.Size = new System.Drawing.Size(198, 20);
            this.TxtDeposit.TabIndex = 3;
            // 
            // TxtWeeks
            // 
            this.TxtWeeks.Location = new System.Drawing.Point(216, 55);
            this.TxtWeeks.Name = "TxtWeeks";
            this.TxtWeeks.Size = new System.Drawing.Size(198, 20);
            this.TxtWeeks.TabIndex = 4;
            // 
            // TxtSavings
            // 
            this.TxtSavings.Location = new System.Drawing.Point(216, 93);
            this.TxtSavings.Name = "TxtSavings";
            this.TxtSavings.Size = new System.Drawing.Size(198, 20);
            this.TxtSavings.TabIndex = 5;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnter.Location = new System.Drawing.Point(12, 167);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(134, 32);
            this.BtnEnter.TabIndex = 6;
            this.BtnEnter.Text = "Enter";
            this.BtnEnter.UseVisualStyleBackColor = true;
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(280, 167);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(134, 32);
            this.BtnExit.TabIndex = 7;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 269);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.TxtSavings);
            this.Controls.Add(this.TxtWeeks);
            this.Controls.Add(this.TxtDeposit);
            this.Controls.Add(this.LblSavings);
            this.Controls.Add(this.LblWeeks);
            this.Controls.Add(this.LblDeposit);
            this.Name = "Form1";
            this.Text = "Savings Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDeposit;
        private System.Windows.Forms.Label LblWeeks;
        private System.Windows.Forms.Label LblSavings;
        private System.Windows.Forms.TextBox TxtDeposit;
        private System.Windows.Forms.TextBox TxtWeeks;
        private System.Windows.Forms.TextBox TxtSavings;
        private System.Windows.Forms.Button BtnEnter;
        private System.Windows.Forms.Button BtnExit;
    }
}

