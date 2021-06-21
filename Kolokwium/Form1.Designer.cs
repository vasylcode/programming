
namespace Kolokwium
{
    partial class Form
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.result1 = new System.Windows.Forms.Label();
            this.result2 = new System.Windows.Forms.Label();
            this.result3 = new System.Windows.Forms.Label();
            this.txtbox = new System.Windows.Forms.TextBox();
            this.btn = new System.Windows.Forms.Button();
            this.combobox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl1.Location = new System.Drawing.Point(12, 51);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(155, 21);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Wprowadź wartość";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl2.Location = new System.Drawing.Point(12, 219);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(125, 21);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Skala Celsjusza";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl3.Location = new System.Drawing.Point(258, 219);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(146, 21);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Skala Fahrenheita";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl4.Location = new System.Drawing.Point(543, 219);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(112, 21);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Skala Kelvina";
            // 
            // result1
            // 
            this.result1.AutoSize = true;
            this.result1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.result1.Location = new System.Drawing.Point(44, 270);
            this.result1.Name = "result1";
            this.result1.Size = new System.Drawing.Size(47, 21);
            this.result1.TabIndex = 4;
            this.result1.Text = "Error";
            // 
            // result2
            // 
            this.result2.AutoSize = true;
            this.result2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.result2.Location = new System.Drawing.Point(306, 270);
            this.result2.Name = "result2";
            this.result2.Size = new System.Drawing.Size(47, 21);
            this.result2.TabIndex = 5;
            this.result2.Text = "Error";
            // 
            // result3
            // 
            this.result3.AutoSize = true;
            this.result3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.result3.Location = new System.Drawing.Point(577, 270);
            this.result3.Name = "result3";
            this.result3.Size = new System.Drawing.Size(47, 21);
            this.result3.TabIndex = 6;
            this.result3.Text = "Error";
            // 
            // txtbox
            // 
            this.txtbox.Location = new System.Drawing.Point(279, 53);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(100, 23);
            this.txtbox.TabIndex = 7;
            // 
            // btn
            // 
            this.btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn.Location = new System.Drawing.Point(291, 101);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 8;
            this.btn.Text = "Oblicz";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // combobox
            // 
            this.combobox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.combobox.FormattingEnabled = true;
            this.combobox.Items.AddRange(new object[] {
            "skala Celsjusza",
            "skala Fahrenheita",
            "skala Kelvina"});
            this.combobox.Location = new System.Drawing.Point(543, 53);
            this.combobox.Name = "combobox";
            this.combobox.Size = new System.Drawing.Size(121, 25);
            this.combobox.TabIndex = 9;
            this.combobox.Text = " Wybierz skale";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 313);
            this.Controls.Add(this.combobox);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.result3);
            this.Controls.Add(this.result2);
            this.Controls.Add(this.result1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Form";
            this.Text = "Temperature-Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label result1;
        private System.Windows.Forms.Label result2;
        private System.Windows.Forms.Label result3;
        private System.Windows.Forms.TextBox txtbox;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.ComboBox combobox;
    }
}

