
namespace Lab2Zadanie2
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
            this.lblText = new System.Windows.Forms.Label();
            this.txtText = new System.Windows.Forms.TextBox();
            this.grpWielkosc = new System.Windows.Forms.GroupBox();
            this.rdBduza = new System.Windows.Forms.RadioButton();
            this.rdDuza = new System.Windows.Forms.RadioButton();
            this.rdMala = new System.Windows.Forms.RadioButton();
            this.grpCzcionka = new System.Windows.Forms.GroupBox();
            this.checkPodrkeslenie = new System.Windows.Forms.CheckBox();
            this.checkPochylenie = new System.Windows.Forms.CheckBox();
            this.checkPogrubienie = new System.Windows.Forms.CheckBox();
            this.grpKolor = new System.Windows.Forms.GroupBox();
            this.rdOrange = new System.Windows.Forms.RadioButton();
            this.rdNiebieski = new System.Windows.Forms.RadioButton();
            this.rdCzerwony = new System.Windows.Forms.RadioButton();
            this.btn = new System.Windows.Forms.Button();
            this.grpWielkosc.SuspendLayout();
            this.grpCzcionka.SuspendLayout();
            this.grpKolor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblText.Location = new System.Drawing.Point(50, 50);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(140, 32);
            this.lblText.TabIndex = 0;
            this.lblText.Text = "Podaj tekst";
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtText.Location = new System.Drawing.Point(207, 47);
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(506, 39);
            this.txtText.TabIndex = 1;
            // 
            // grpWielkosc
            // 
            this.grpWielkosc.Controls.Add(this.rdBduza);
            this.grpWielkosc.Controls.Add(this.rdDuza);
            this.grpWielkosc.Controls.Add(this.rdMala);
            this.grpWielkosc.Location = new System.Drawing.Point(50, 122);
            this.grpWielkosc.Name = "grpWielkosc";
            this.grpWielkosc.Size = new System.Drawing.Size(200, 100);
            this.grpWielkosc.TabIndex = 2;
            this.grpWielkosc.TabStop = false;
            this.grpWielkosc.Text = "Wielkość";
            // 
            // rdBduza
            // 
            this.rdBduza.AutoSize = true;
            this.rdBduza.Location = new System.Drawing.Point(10, 72);
            this.rdBduza.Name = "rdBduza";
            this.rdBduza.Size = new System.Drawing.Size(89, 19);
            this.rdBduza.TabIndex = 2;
            this.rdBduza.TabStop = true;
            this.rdBduza.Text = "Bardzo duża";
            this.rdBduza.UseVisualStyleBackColor = true;
            // 
            // rdDuza
            // 
            this.rdDuza.AutoSize = true;
            this.rdDuza.Location = new System.Drawing.Point(10, 47);
            this.rdDuza.Name = "rdDuza";
            this.rdDuza.Size = new System.Drawing.Size(51, 19);
            this.rdDuza.TabIndex = 1;
            this.rdDuza.TabStop = true;
            this.rdDuza.Text = "Duża";
            this.rdDuza.UseVisualStyleBackColor = true;
            // 
            // rdMala
            // 
            this.rdMala.AutoSize = true;
            this.rdMala.Location = new System.Drawing.Point(10, 22);
            this.rdMala.Name = "rdMala";
            this.rdMala.Size = new System.Drawing.Size(51, 19);
            this.rdMala.TabIndex = 0;
            this.rdMala.TabStop = true;
            this.rdMala.Text = "Mała";
            this.rdMala.UseVisualStyleBackColor = true;
            // 
            // grpCzcionka
            // 
            this.grpCzcionka.Controls.Add(this.checkPodrkeslenie);
            this.grpCzcionka.Controls.Add(this.checkPochylenie);
            this.grpCzcionka.Controls.Add(this.checkPogrubienie);
            this.grpCzcionka.Location = new System.Drawing.Point(276, 122);
            this.grpCzcionka.Name = "grpCzcionka";
            this.grpCzcionka.Size = new System.Drawing.Size(200, 100);
            this.grpCzcionka.TabIndex = 3;
            this.grpCzcionka.TabStop = false;
            this.grpCzcionka.Text = "Styl czcionki";
            // 
            // checkPodrkeslenie
            // 
            this.checkPodrkeslenie.AutoSize = true;
            this.checkPodrkeslenie.Location = new System.Drawing.Point(6, 72);
            this.checkPodrkeslenie.Name = "checkPodrkeslenie";
            this.checkPodrkeslenie.Size = new System.Drawing.Size(93, 19);
            this.checkPodrkeslenie.TabIndex = 2;
            this.checkPodrkeslenie.Text = "Podkreślenie";
            this.checkPodrkeslenie.UseVisualStyleBackColor = true;
            // 
            // checkPochylenie
            // 
            this.checkPochylenie.AutoSize = true;
            this.checkPochylenie.Location = new System.Drawing.Point(6, 48);
            this.checkPochylenie.Name = "checkPochylenie";
            this.checkPochylenie.Size = new System.Drawing.Size(84, 19);
            this.checkPochylenie.TabIndex = 1;
            this.checkPochylenie.Text = "Pochylenie";
            this.checkPochylenie.UseVisualStyleBackColor = true;
            // 
            // checkPogrubienie
            // 
            this.checkPogrubienie.AutoSize = true;
            this.checkPogrubienie.Location = new System.Drawing.Point(6, 23);
            this.checkPogrubienie.Name = "checkPogrubienie";
            this.checkPogrubienie.Size = new System.Drawing.Size(90, 19);
            this.checkPogrubienie.TabIndex = 0;
            this.checkPogrubienie.Text = "Pogrubienie";
            this.checkPogrubienie.UseVisualStyleBackColor = true;
            // 
            // grpKolor
            // 
            this.grpKolor.Controls.Add(this.rdOrange);
            this.grpKolor.Controls.Add(this.rdNiebieski);
            this.grpKolor.Controls.Add(this.rdCzerwony);
            this.grpKolor.Location = new System.Drawing.Point(513, 122);
            this.grpKolor.Name = "grpKolor";
            this.grpKolor.Size = new System.Drawing.Size(200, 100);
            this.grpKolor.TabIndex = 4;
            this.grpKolor.TabStop = false;
            this.grpKolor.Text = "Kolor czcionki";
            // 
            // rdOrange
            // 
            this.rdOrange.AutoSize = true;
            this.rdOrange.Location = new System.Drawing.Point(6, 72);
            this.rdOrange.Name = "rdOrange";
            this.rdOrange.Size = new System.Drawing.Size(106, 19);
            this.rdOrange.TabIndex = 3;
            this.rdOrange.TabStop = true;
            this.rdOrange.Text = "pomarańczowy";
            this.rdOrange.UseVisualStyleBackColor = true;
            // 
            // rdNiebieski
            // 
            this.rdNiebieski.AutoSize = true;
            this.rdNiebieski.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.rdNiebieski.Location = new System.Drawing.Point(6, 47);
            this.rdNiebieski.Name = "rdNiebieski";
            this.rdNiebieski.Size = new System.Drawing.Size(71, 19);
            this.rdNiebieski.TabIndex = 2;
            this.rdNiebieski.TabStop = true;
            this.rdNiebieski.Text = "niebieski";
            this.rdNiebieski.UseVisualStyleBackColor = true;
            // 
            // rdCzerwony
            // 
            this.rdCzerwony.AutoSize = true;
            this.rdCzerwony.Location = new System.Drawing.Point(6, 22);
            this.rdCzerwony.Name = "rdCzerwony";
            this.rdCzerwony.Size = new System.Drawing.Size(75, 19);
            this.rdCzerwony.TabIndex = 1;
            this.rdCzerwony.TabStop = true;
            this.rdCzerwony.Text = "czerwony";
            this.rdCzerwony.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn.Location = new System.Drawing.Point(276, 267);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(207, 50);
            this.btn.TabIndex = 5;
            this.btn.Text = "Aktualizuj";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 348);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.grpKolor);
            this.Controls.Add(this.grpCzcionka);
            this.Controls.Add(this.grpWielkosc);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpWielkosc.ResumeLayout(false);
            this.grpWielkosc.PerformLayout();
            this.grpCzcionka.ResumeLayout(false);
            this.grpCzcionka.PerformLayout();
            this.grpKolor.ResumeLayout(false);
            this.grpKolor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.GroupBox grpWielkosc;
        private System.Windows.Forms.RadioButton rdBduza;
        private System.Windows.Forms.RadioButton rdDuza;
        private System.Windows.Forms.RadioButton rdMala;
        private System.Windows.Forms.GroupBox grpCzcionka;
        private System.Windows.Forms.CheckBox checkPodrkeslenie;
        private System.Windows.Forms.CheckBox checkPochylenie;
        private System.Windows.Forms.CheckBox checkPogrubienie;
        private System.Windows.Forms.GroupBox grpKolor;
        private System.Windows.Forms.RadioButton rdOrange;
        private System.Windows.Forms.RadioButton rdNiebieski;
        private System.Windows.Forms.RadioButton rdCzerwony;
        private System.Windows.Forms.Button btn;
    }
}

