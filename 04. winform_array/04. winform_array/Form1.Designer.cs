namespace _04.winform_array
{
    partial class mainFrom
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
            this.label2 = new System.Windows.Forms.Label();
            this.nameOf = new System.Windows.Forms.TextBox();
            this.lists = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "The number of free space in romm: 3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // nameOf
            // 
            this.nameOf.Location = new System.Drawing.Point(73, 70);
            this.nameOf.Name = "nameOf";
            this.nameOf.Size = new System.Drawing.Size(320, 20);
            this.nameOf.TabIndex = 2;
            // 
            // lists
            // 
            this.lists.FormattingEnabled = true;
            this.lists.Location = new System.Drawing.Point(73, 133);
            this.lists.Name = "lists";
            this.lists.Size = new System.Drawing.Size(320, 303);
            this.lists.TabIndex = 3;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(318, 96);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 5;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(73, 97);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 6;
            this.show.Text = "show";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // mainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 458);
            this.Controls.Add(this.show);
            this.Controls.Add(this.add);
            this.Controls.Add(this.lists);
            this.Controls.Add(this.nameOf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "mainFrom";
            this.Text = "Alireza Nazari";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameOf;
        private System.Windows.Forms.ListBox lists;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button show;
    }
}

