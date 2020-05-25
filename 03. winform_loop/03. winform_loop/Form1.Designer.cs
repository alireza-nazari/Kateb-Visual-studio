namespace winform_loop
{
    partial class mainForm
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
            this.start_value = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.Label();
            this.years = new System.Windows.Forms.Label();
            this.money = new System.Windows.Forms.Label();
            this.int1 = new System.Windows.Forms.TextBox();
            this.int2 = new System.Windows.Forms.TextBox();
            this.int3 = new System.Windows.Forms.TextBox();
            this.int4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_value
            // 
            this.start_value.AutoSize = true;
            this.start_value.Location = new System.Drawing.Point(23, 33);
            this.start_value.Name = "start_value";
            this.start_value.Size = new System.Drawing.Size(59, 13);
            this.start_value.TabIndex = 0;
            this.start_value.Text = "Start Value";
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.Location = new System.Drawing.Point(23, 73);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(30, 13);
            this.rate.TabIndex = 1;
            this.rate.Text = "Rate";
            // 
            // years
            // 
            this.years.AutoSize = true;
            this.years.Location = new System.Drawing.Point(23, 116);
            this.years.Name = "years";
            this.years.Size = new System.Drawing.Size(34, 13);
            this.years.TabIndex = 2;
            this.years.Text = "Years";
            // 
            // money
            // 
            this.money.AutoSize = true;
            this.money.Location = new System.Drawing.Point(23, 224);
            this.money.Name = "money";
            this.money.Size = new System.Drawing.Size(39, 13);
            this.money.TabIndex = 3;
            this.money.Text = "Money";
            // 
            // int1
            // 
            this.int1.Location = new System.Drawing.Point(88, 33);
            this.int1.Name = "int1";
            this.int1.Size = new System.Drawing.Size(176, 20);
            this.int1.TabIndex = 4;
            // 
            // int2
            // 
            this.int2.Location = new System.Drawing.Point(88, 70);
            this.int2.Name = "int2";
            this.int2.Size = new System.Drawing.Size(176, 20);
            this.int2.TabIndex = 5;
            // 
            // int3
            // 
            this.int3.Location = new System.Drawing.Point(88, 113);
            this.int3.Name = "int3";
            this.int3.Size = new System.Drawing.Size(176, 20);
            this.int3.TabIndex = 6;
            // 
            // int4
            // 
            this.int4.Location = new System.Drawing.Point(88, 221);
            this.int4.Name = "int4";
            this.int4.Size = new System.Drawing.Size(176, 20);
            this.int4.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Get Output";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 265);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.int4);
            this.Controls.Add(this.int3);
            this.Controls.Add(this.int2);
            this.Controls.Add(this.int1);
            this.Controls.Add(this.money);
            this.Controls.Add(this.years);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.start_value);
            this.Name = "mainForm";
            this.Text = "Alireza Nazari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label start_value;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.Label years;
        private System.Windows.Forms.Label money;
        private System.Windows.Forms.TextBox int1;
        private System.Windows.Forms.TextBox int2;
        private System.Windows.Forms.TextBox int3;
        private System.Windows.Forms.TextBox int4;
        private System.Windows.Forms.Button button1;
    }
}

