
namespace Lab2Zadanie1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWzrost = new System.Windows.Forms.Label();
            this.lblPlec = new System.Windows.Forms.Label();
            this.grpBoxWaga = new System.Windows.Forms.GroupBox();
            this.checkBoxIdealna = new System.Windows.Forms.CheckBox();
            this.checkBoxStandardowa = new System.Windows.Forms.CheckBox();
            this.rdBtnKobieta = new System.Windows.Forms.RadioButton();
            this.rdBtnMez = new System.Windows.Forms.RadioButton();
            this.txtBoxWzrost = new System.Windows.Forms.TextBox();
            this.btnOblicz = new System.Windows.Forms.Button();
            this.lblWynik = new System.Windows.Forms.Label();
            this.lblResult1 = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.grpBoxWaga.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWzrost
            // 
            this.lblWzrost.AutoSize = true;
            this.lblWzrost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWzrost.Location = new System.Drawing.Point(38, 31);
            this.lblWzrost.Name = "lblWzrost";
            this.lblWzrost.Size = new System.Drawing.Size(119, 17);
            this.lblWzrost.TabIndex = 0;
            this.lblWzrost.Text = "Podaj wzrost [cm]";
            // 
            // lblPlec
            // 
            this.lblPlec.AutoSize = true;
            this.lblPlec.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPlec.Location = new System.Drawing.Point(38, 75);
            this.lblPlec.Name = "lblPlec";
            this.lblPlec.Size = new System.Drawing.Size(72, 17);
            this.lblPlec.TabIndex = 1;
            this.lblPlec.Text = "Podaj płeć";
            // 
            // grpBoxWaga
            // 
            this.grpBoxWaga.Controls.Add(this.checkBoxIdealna);
            this.grpBoxWaga.Controls.Add(this.checkBoxStandardowa);
            this.grpBoxWaga.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grpBoxWaga.Location = new System.Drawing.Point(441, 22);
            this.grpBoxWaga.Name = "grpBoxWaga";
            this.grpBoxWaga.Size = new System.Drawing.Size(200, 84);
            this.grpBoxWaga.TabIndex = 2;
            this.grpBoxWaga.TabStop = false;
            this.grpBoxWaga.Text = "Waga";
            // 
            // checkBoxIdealna
            // 
            this.checkBoxIdealna.AutoSize = true;
            this.checkBoxIdealna.Location = new System.Drawing.Point(6, 51);
            this.checkBoxIdealna.Name = "checkBoxIdealna";
            this.checkBoxIdealna.Size = new System.Drawing.Size(69, 21);
            this.checkBoxIdealna.TabIndex = 1;
            this.checkBoxIdealna.Text = "Idealna";
            this.checkBoxIdealna.UseVisualStyleBackColor = true;
            // 
            // checkBoxStandardowa
            // 
            this.checkBoxStandardowa.AutoSize = true;
            this.checkBoxStandardowa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxStandardowa.Location = new System.Drawing.Point(6, 26);
            this.checkBoxStandardowa.Name = "checkBoxStandardowa";
            this.checkBoxStandardowa.Size = new System.Drawing.Size(104, 21);
            this.checkBoxStandardowa.TabIndex = 0;
            this.checkBoxStandardowa.Text = "Standardowa";
            this.checkBoxStandardowa.UseVisualStyleBackColor = true;
            // 
            // rdBtnKobieta
            // 
            this.rdBtnKobieta.AutoSize = true;
            this.rdBtnKobieta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdBtnKobieta.Location = new System.Drawing.Point(170, 71);
            this.rdBtnKobieta.Name = "rdBtnKobieta";
            this.rdBtnKobieta.Size = new System.Drawing.Size(71, 21);
            this.rdBtnKobieta.TabIndex = 3;
            this.rdBtnKobieta.TabStop = true;
            this.rdBtnKobieta.Text = "Kobieta";
            this.rdBtnKobieta.UseVisualStyleBackColor = true;
            // 
            // rdBtnMez
            // 
            this.rdBtnMez.AutoSize = true;
            this.rdBtnMez.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdBtnMez.Location = new System.Drawing.Point(259, 71);
            this.rdBtnMez.Name = "rdBtnMez";
            this.rdBtnMez.Size = new System.Drawing.Size(89, 21);
            this.rdBtnMez.TabIndex = 4;
            this.rdBtnMez.TabStop = true;
            this.rdBtnMez.Text = "Mężczyzna";
            this.rdBtnMez.UseVisualStyleBackColor = true;
            // 
            // txtBoxWzrost
            // 
            this.txtBoxWzrost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxWzrost.Location = new System.Drawing.Point(170, 30);
            this.txtBoxWzrost.Name = "txtBoxWzrost";
            this.txtBoxWzrost.Size = new System.Drawing.Size(131, 25);
            this.txtBoxWzrost.TabIndex = 5;
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(236, 130);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(185, 41);
            this.btnOblicz.TabIndex = 6;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWynik.Location = new System.Drawing.Point(38, 193);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(47, 19);
            this.lblWynik.TabIndex = 7;
            this.lblWynik.Text = "Wynik";
            // 
            // lblResult1
            // 
            this.lblResult1.AutoSize = true;
            this.lblResult1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult1.Location = new System.Drawing.Point(108, 210);
            this.lblResult1.Name = "lblResult1";
            this.lblResult1.Size = new System.Drawing.Size(0, 21);
            this.lblResult1.TabIndex = 8;
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult2.Location = new System.Drawing.Point(108, 235);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(0, 21);
            this.lblResult2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 295);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult1);
            this.Controls.Add(this.lblWynik);
            this.Controls.Add(this.btnOblicz);
            this.Controls.Add(this.txtBoxWzrost);
            this.Controls.Add(this.rdBtnMez);
            this.Controls.Add(this.rdBtnKobieta);
            this.Controls.Add(this.grpBoxWaga);
            this.Controls.Add(this.lblPlec);
            this.Controls.Add(this.lblWzrost);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Kobieta";
            this.grpBoxWaga.ResumeLayout(false);
            this.grpBoxWaga.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWzrost;
        private System.Windows.Forms.Label lblPlec;
        private System.Windows.Forms.GroupBox grpBoxWaga;
        private System.Windows.Forms.CheckBox checkBoxIdealna;
        private System.Windows.Forms.CheckBox checkBoxStandardowa;
        private System.Windows.Forms.RadioButton rdBtnKobieta;
        private System.Windows.Forms.RadioButton rdBtnMez;
        private System.Windows.Forms.TextBox txtBoxWzrost;
        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.Label lblResult1;
        private System.Windows.Forms.Label lblResult2;
    }
}

