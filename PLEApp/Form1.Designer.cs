namespace PLEApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.multiCommand = new System.Windows.Forms.RichTextBox();
            this.errorBox = new System.Windows.Forms.RichTextBox();
            this.singleCommand = new System.Windows.Forms.RichTextBox();
            this.runBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.syntaxbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outputDisplay = new System.Windows.Forms.PictureBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // multiCommand
            // 
            this.multiCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.multiCommand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiCommand.ForeColor = System.Drawing.SystemColors.ControlText;
            this.multiCommand.Location = new System.Drawing.Point(36, 87);
            this.multiCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.multiCommand.Name = "multiCommand";
            this.multiCommand.Size = new System.Drawing.Size(424, 385);
            this.multiCommand.TabIndex = 1;
            this.multiCommand.Text = "";
            // 
            // errorBox
            // 
            this.errorBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.errorBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.errorBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.errorBox.Location = new System.Drawing.Point(499, 474);
            this.errorBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.errorBox.Name = "errorBox";
            this.errorBox.ReadOnly = true;
            this.errorBox.Size = new System.Drawing.Size(702, 135);
            this.errorBox.TabIndex = 1;
            this.errorBox.Text = "";
            // 
            // singleCommand
            // 
            this.singleCommand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.singleCommand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singleCommand.ForeColor = System.Drawing.SystemColors.Desktop;
            this.singleCommand.Location = new System.Drawing.Point(36, 525);
            this.singleCommand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.singleCommand.Multiline = false;
            this.singleCommand.Name = "singleCommand";
            this.singleCommand.Size = new System.Drawing.Size(424, 40);
            this.singleCommand.TabIndex = 1;
            this.singleCommand.Text = "";
            this.singleCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.singleCommand_KeyDown);
            // 
            // runBtn
            // 
            this.runBtn.BackColor = System.Drawing.Color.Lime;
            this.runBtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.runBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.runBtn.Location = new System.Drawing.Point(67, 569);
            this.runBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(113, 40);
            this.runBtn.TabIndex = 2;
            this.runBtn.Text = "Run";
            this.runBtn.UseVisualStyleBackColor = false;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1236, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // syntaxbtn
            // 
            this.syntaxbtn.BackColor = System.Drawing.Color.Red;
            this.syntaxbtn.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.syntaxbtn.ForeColor = System.Drawing.Color.Black;
            this.syntaxbtn.Location = new System.Drawing.Point(205, 569);
            this.syntaxbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.syntaxbtn.Name = "syntaxbtn";
            this.syntaxbtn.Size = new System.Drawing.Size(226, 40);
            this.syntaxbtn.TabIndex = 4;
            this.syntaxbtn.Text = "Syntax Check";
            this.syntaxbtn.UseVisualStyleBackColor = false;
            this.syntaxbtn.Click += new System.EventHandler(this.syntaxbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Program Window";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(786, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Canvas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 491);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Command Line";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(753, 439);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Validity Checker";
            // 
            // outputDisplay
            // 
            this.outputDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.outputDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputDisplay.Location = new System.Drawing.Point(499, 87);
            this.outputDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputDisplay.Name = "outputDisplay";
            this.outputDisplay.Size = new System.Drawing.Size(702, 326);
            this.outputDisplay.TabIndex = 0;
            this.outputDisplay.TabStop = false;
            this.outputDisplay.Paint += new System.Windows.Forms.PaintEventHandler(this.outputDisplay_Paint);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Image = global::PLEApp.Properties.Resources.file;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::PLEApp.Properties.Resources.open;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Image = global::PLEApp.Properties.Resources.load;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::PLEApp.Properties.Resources.exit;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editToolStripMenuItem.Image = global::PLEApp.Properties.Resources.edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Image = global::PLEApp.Properties.Resources.help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(82, 27);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::PLEApp.Properties.Resources.about;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 28);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1236, 620);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.syntaxbtn);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.singleCommand);
            this.Controls.Add(this.errorBox);
            this.Controls.Add(this.multiCommand);
            this.Controls.Add(this.outputDisplay);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrawingTest";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox outputDisplay;
        private System.Windows.Forms.RichTextBox multiCommand;
        private System.Windows.Forms.RichTextBox errorBox;
        private System.Windows.Forms.RichTextBox singleCommand;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button syntaxbtn;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

