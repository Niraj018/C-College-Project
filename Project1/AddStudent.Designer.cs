namespace Project1
{
    partial class AddStudent
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
            this.Name = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(223, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(316, 72);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(224, 23);
            this.Name.TabIndex = 1;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(316, 119);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(224, 23);
            this.Address.TabIndex = 2;
            this.Address.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(210, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address:";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(316, 167);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(224, 23);
            this.Email.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(223, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(316, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(316, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 45);
            this.button2.TabIndex = 7;
            this.button2.Text = "Display";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.label1);
            this.Name = "AddStudent";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox Name;
        private TextBox Address;
        private Label label2;
        private TextBox Email;
        private Label label3;
        private Button button1;
        private Button button2;
    }
}