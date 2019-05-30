namespace Restaurant_Management
{
    partial class Settings
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.servertxt = new System.Windows.Forms.TextBox();
            this.databasetxt = new System.Windows.Forms.TextBox();
            this.useridtxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.serverErrorLabel = new System.Windows.Forms.Label();
            this.databaseErrorLabel = new System.Windows.Forms.Label();
            this.useridErrorLabel = new System.Windows.Forms.Label();
            this.passwordErrorLabel = new System.Windows.Forms.Label();
            this.leftpanel.SuspendLayout();
            this.rightpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftpanel
            // 
            this.leftpanel.Controls.Add(this.passwordErrorLabel);
            this.leftpanel.Controls.Add(this.useridErrorLabel);
            this.leftpanel.Controls.Add(this.databaseErrorLabel);
            this.leftpanel.Controls.Add(this.serverErrorLabel);
            this.leftpanel.Controls.Add(this.savebtn);
            this.leftpanel.Controls.Add(this.isCB);
            this.leftpanel.Controls.Add(this.passwordtxt);
            this.leftpanel.Controls.Add(this.useridtxt);
            this.leftpanel.Controls.Add(this.databasetxt);
            this.leftpanel.Controls.Add(this.servertxt);
            this.leftpanel.Controls.Add(this.label6);
            this.leftpanel.Controls.Add(this.label5);
            this.leftpanel.Controls.Add(this.label4);
            this.leftpanel.Controls.Add(this.label3);
            this.leftpanel.Size = new System.Drawing.Size(174, 450);
            this.leftpanel.Controls.SetChildIndex(this.label3, 0);
            this.leftpanel.Controls.SetChildIndex(this.label4, 0);
            this.leftpanel.Controls.SetChildIndex(this.label5, 0);
            this.leftpanel.Controls.SetChildIndex(this.label6, 0);
            this.leftpanel.Controls.SetChildIndex(this.servertxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.databasetxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.useridtxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.passwordtxt, 0);
            this.leftpanel.Controls.SetChildIndex(this.isCB, 0);
            this.leftpanel.Controls.SetChildIndex(this.savebtn, 0);
            this.leftpanel.Controls.SetChildIndex(this.serverErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.databaseErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.useridErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.passwordErrorLabel, 0);
            this.leftpanel.Controls.SetChildIndex(this.panel1, 0);
            // 
            // rightpanel
            // 
            this.rightpanel.Location = new System.Drawing.Point(174, 0);
            this.rightpanel.Size = new System.Drawing.Size(626, 450);
            // 
            // panel1
            // 
            this.panel1.Size = new System.Drawing.Size(174, 85);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(626, 85);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Database";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "UserID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Password";
            // 
            // servertxt
            // 
            this.servertxt.Location = new System.Drawing.Point(12, 135);
            this.servertxt.Name = "servertxt";
            this.servertxt.Size = new System.Drawing.Size(151, 22);
            this.servertxt.TabIndex = 5;
            this.servertxt.Visible = false;
            this.servertxt.TextChanged += new System.EventHandler(this.servertxt_TextChanged);
            // 
            // databasetxt
            // 
            this.databasetxt.Location = new System.Drawing.Point(15, 179);
            this.databasetxt.Name = "databasetxt";
            this.databasetxt.Size = new System.Drawing.Size(151, 22);
            this.databasetxt.TabIndex = 6;
            this.databasetxt.Visible = false;
            this.databasetxt.TextChanged += new System.EventHandler(this.databasetxt_TextChanged);
            // 
            // useridtxt
            // 
            this.useridtxt.Location = new System.Drawing.Point(15, 223);
            this.useridtxt.Name = "useridtxt";
            this.useridtxt.Size = new System.Drawing.Size(151, 22);
            this.useridtxt.TabIndex = 7;
            this.useridtxt.Visible = false;
            this.useridtxt.TextChanged += new System.EventHandler(this.useridtxt_TextChanged);
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(12, 267);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.Size = new System.Drawing.Size(151, 22);
            this.passwordtxt.TabIndex = 8;
            this.passwordtxt.Visible = false;
            this.passwordtxt.TextChanged += new System.EventHandler(this.passwordtxt_TextChanged);
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Location = new System.Drawing.Point(12, 309);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(138, 20);
            this.isCB.TabIndex = 9;
            this.isCB.Text = "Integrated Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(36, 335);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 10;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // serverErrorLabel
            // 
            this.serverErrorLabel.AutoSize = true;
            this.serverErrorLabel.Location = new System.Drawing.Point(153, 116);
            this.serverErrorLabel.Name = "serverErrorLabel";
            this.serverErrorLabel.Size = new System.Drawing.Size(13, 16);
            this.serverErrorLabel.TabIndex = 11;
            this.serverErrorLabel.Text = "*";
            // 
            // databaseErrorLabel
            // 
            this.databaseErrorLabel.AutoSize = true;
            this.databaseErrorLabel.Location = new System.Drawing.Point(153, 160);
            this.databaseErrorLabel.Name = "databaseErrorLabel";
            this.databaseErrorLabel.Size = new System.Drawing.Size(13, 16);
            this.databaseErrorLabel.TabIndex = 12;
            this.databaseErrorLabel.Text = "*";
            // 
            // useridErrorLabel
            // 
            this.useridErrorLabel.AutoSize = true;
            this.useridErrorLabel.Location = new System.Drawing.Point(150, 204);
            this.useridErrorLabel.Name = "useridErrorLabel";
            this.useridErrorLabel.Size = new System.Drawing.Size(13, 16);
            this.useridErrorLabel.TabIndex = 13;
            this.useridErrorLabel.Text = "*";
            // 
            // passwordErrorLabel
            // 
            this.passwordErrorLabel.AutoSize = true;
            this.passwordErrorLabel.Location = new System.Drawing.Point(150, 248);
            this.passwordErrorLabel.Name = "passwordErrorLabel";
            this.passwordErrorLabel.Size = new System.Drawing.Size(13, 16);
            this.passwordErrorLabel.TabIndex = 14;
            this.passwordErrorLabel.Text = "*";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Settings";
            this.Text = "Settings";
            this.leftpanel.ResumeLayout(false);
            this.leftpanel.PerformLayout();
            this.rightpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.TextBox useridtxt;
        private System.Windows.Forms.TextBox databasetxt;
        private System.Windows.Forms.TextBox servertxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox isCB;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Label passwordErrorLabel;
        private System.Windows.Forms.Label useridErrorLabel;
        private System.Windows.Forms.Label databaseErrorLabel;
        private System.Windows.Forms.Label serverErrorLabel;
    }
}