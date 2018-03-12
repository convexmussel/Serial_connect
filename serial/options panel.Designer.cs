namespace serial
{
    partial class options_panel
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.bCommand = new System.Windows.Forms.TextBox();
            this.command = new System.Windows.Forms.Label();
            this.bName = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.closeButton);
            this.groupBox1.Controls.Add(this.confirmButton);
            this.groupBox1.Controls.Add(this.bCommand);
            this.groupBox1.Controls.Add(this.command);
            this.groupBox1.Controls.Add(this.bName);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Location = new System.Drawing.Point(15, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(357, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "user control";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(182, 88);
            this.closeButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(84, 29);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(273, 88);
            this.confirmButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(84, 29);
            this.confirmButton.TabIndex = 5;
            this.confirmButton.Text = "confirm";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // bCommand
            // 
            this.bCommand.Location = new System.Drawing.Point(115, 54);
            this.bCommand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bCommand.Name = "bCommand";
            this.bCommand.Size = new System.Drawing.Size(242, 26);
            this.bCommand.TabIndex = 4;
            // 
            // command
            // 
            this.command.AutoSize = true;
            this.command.Location = new System.Drawing.Point(26, 57);
            this.command.Name = "command";
            this.command.Size = new System.Drawing.Size(83, 20);
            this.command.TabIndex = 3;
            this.command.Text = "command:";
            // 
            // bName
            // 
            this.bName.Location = new System.Drawing.Point(115, 19);
            this.bName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bName.Name = "bName";
            this.bName.Size = new System.Drawing.Size(242, 26);
            this.bName.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(6, 23);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(103, 20);
            this.name.TabIndex = 1;
            this.name.Text = "button name:";
            // 
            // options_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "options_panel";
            this.Text = "options_form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.TextBox bCommand;
        private System.Windows.Forms.Label command;
        private System.Windows.Forms.TextBox bName;
        private System.Windows.Forms.Label name;
    }
}