
namespace Lab1Zadanie1
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
            this.lblx = new System.Windows.Forms.Label();
            this.lbly = new System.Windows.Forms.Label();
            this.lblz = new System.Windows.Forms.Label();
            this.lblwynik = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbZ = new System.Windows.Forms.TextBox();
            this.tbWynik = new System.Windows.Forms.TextBox();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnIloczyn = new System.Windows.Forms.Button();
            this.btnWyjscie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblx.Location = new System.Drawing.Point(37, 40);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(17, 21);
            this.lblx.TabIndex = 0;
            this.lblx.Text = "x";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbly.Location = new System.Drawing.Point(37, 80);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(18, 21);
            this.lbly.TabIndex = 1;
            this.lbly.Text = "y";
            // 
            // lblz
            // 
            this.lblz.AutoSize = true;
            this.lblz.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblz.Location = new System.Drawing.Point(37, 120);
            this.lblz.Name = "lblz";
            this.lblz.Size = new System.Drawing.Size(17, 21);
            this.lblz.TabIndex = 2;
            this.lblz.Text = "z";
            // 
            // lblwynik
            // 
            this.lblwynik.AutoSize = true;
            this.lblwynik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblwynik.Location = new System.Drawing.Point(4, 165);
            this.lblwynik.Name = "lblwynik";
            this.lblwynik.Size = new System.Drawing.Size(51, 21);
            this.lblwynik.TabIndex = 3;
            this.lblwynik.Text = "wynik";
            // 
            // tbX
            // 
            this.tbX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbX.Location = new System.Drawing.Point(60, 40);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(169, 29);
            this.tbX.TabIndex = 4;
            // 
            // tbY
            // 
            this.tbY.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbY.Location = new System.Drawing.Point(61, 80);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(169, 29);
            this.tbY.TabIndex = 5;
            // 
            // tbZ
            // 
            this.tbZ.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbZ.Location = new System.Drawing.Point(60, 120);
            this.tbZ.Name = "tbZ";
            this.tbZ.Size = new System.Drawing.Size(169, 29);
            this.tbZ.TabIndex = 6;
            // 
            // tbWynik
            // 
            this.tbWynik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbWynik.Location = new System.Drawing.Point(60, 162);
            this.tbWynik.Name = "tbWynik";
            this.tbWynik.Size = new System.Drawing.Size(169, 29);
            this.tbWynik.TabIndex = 7;
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(287, 41);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(128, 29);
            this.btnSuma.TabIndex = 8;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnIloczyn
            // 
            this.btnIloczyn.Location = new System.Drawing.Point(287, 99);
            this.btnIloczyn.Name = "btnIloczyn";
            this.btnIloczyn.Size = new System.Drawing.Size(128, 29);
            this.btnIloczyn.TabIndex = 9;
            this.btnIloczyn.Text = "Iloczyn";
            this.btnIloczyn.UseVisualStyleBackColor = true;
            this.btnIloczyn.Click += new System.EventHandler(this.btnIloczyn_Click);
            // 
            // btnWyjscie
            // 
            this.btnWyjscie.Location = new System.Drawing.Point(287, 157);
            this.btnWyjscie.Name = "btnWyjscie";
            this.btnWyjscie.Size = new System.Drawing.Size(128, 29);
            this.btnWyjscie.TabIndex = 10;
            this.btnWyjscie.Text = "Wyjscie";
            this.btnWyjscie.UseVisualStyleBackColor = true;
            this.btnWyjscie.Click += new System.EventHandler(this.btnWyjscie_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 231);
            this.Controls.Add(this.btnWyjscie);
            this.Controls.Add(this.btnIloczyn);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.tbWynik);
            this.Controls.Add(this.tbZ);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblwynik);
            this.Controls.Add(this.lblz);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblx);
            this.Name = "Form1";
            this.Text = "Matematyka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Label lblz;
        private System.Windows.Forms.Label lblwynik;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbZ;
        private System.Windows.Forms.TextBox tbWynik;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Button btnIloczyn;
        private System.Windows.Forms.Button btnWyjscie;
    }
}

