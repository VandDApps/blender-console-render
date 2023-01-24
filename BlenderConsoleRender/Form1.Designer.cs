namespace BlenderConsoleRender
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
            this.darkTheme = new MaterialSkin.Controls.MaterialCheckBox();
            this.browseString = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.browseButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.browseString1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.browseButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.closeAfterStart = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.saveButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.saveString = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.startButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.startFrame = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lastFrame = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.frameJump = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.treatsCPU = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.frameName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.saveParmButt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialContextMenuStrip1 = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.startCommand = new System.Windows.Forms.TextBox();
            this.AboutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.WikiButt = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // darkTheme
            // 
            this.darkTheme.BackColor = System.Drawing.SystemColors.Highlight;
            this.darkTheme.Depth = 0;
            this.darkTheme.Font = new System.Drawing.Font("Roboto", 10F);
            this.darkTheme.ForeColor = System.Drawing.Color.Coral;
            this.darkTheme.Location = new System.Drawing.Point(596, 103);
            this.darkTheme.Margin = new System.Windows.Forms.Padding(0);
            this.darkTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.darkTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.darkTheme.Name = "darkTheme";
            this.darkTheme.Ripple = true;
            this.darkTheme.Size = new System.Drawing.Size(186, 23);
            this.darkTheme.TabIndex = 1;
            this.darkTheme.Text = "Dark mode";
            this.darkTheme.UseVisualStyleBackColor = false;
            this.darkTheme.CheckedChanged += new System.EventHandler(this.darkTheme_CheckedChanged);
            // 
            // browseString
            // 
            this.browseString.Depth = 0;
            this.browseString.Hint = "";
            this.browseString.Location = new System.Drawing.Point(12, 74);
            this.browseString.MaxLength = 32767;
            this.browseString.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseString.Name = "browseString";
            this.browseString.PasswordChar = '\0';
            this.browseString.SelectedText = "";
            this.browseString.SelectionLength = 0;
            this.browseString.SelectionStart = 0;
            this.browseString.Size = new System.Drawing.Size(553, 23);
            this.browseString.TabIndex = 2;
            this.browseString.TabStop = false;
            this.browseString.Text = "Path to blender";
            this.browseString.UseSystemPasswordChar = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // browseButton
            // 
            this.browseButton.AutoSize = true;
            this.browseButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseButton.Depth = 0;
            this.browseButton.Icon = null;
            this.browseButton.Location = new System.Drawing.Point(489, 103);
            this.browseButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseButton.Name = "browseButton";
            this.browseButton.Primary = true;
            this.browseButton.Size = new System.Drawing.Size(76, 36);
            this.browseButton.TabIndex = 5;
            this.browseButton.Text = "Browse";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // browseString1
            // 
            this.browseString1.Depth = 0;
            this.browseString1.Hint = "";
            this.browseString1.Location = new System.Drawing.Point(12, 145);
            this.browseString1.MaxLength = 32767;
            this.browseString1.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseString1.Name = "browseString1";
            this.browseString1.PasswordChar = '\0';
            this.browseString1.SelectedText = "";
            this.browseString1.SelectionLength = 0;
            this.browseString1.SelectionStart = 0;
            this.browseString1.Size = new System.Drawing.Size(553, 23);
            this.browseString1.TabIndex = 7;
            this.browseString1.TabStop = false;
            this.browseString1.Text = "Path to .blend";
            this.browseString1.UseSystemPasswordChar = false;
            // 
            // browseButton1
            // 
            this.browseButton1.AutoSize = true;
            this.browseButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.browseButton1.Depth = 0;
            this.browseButton1.Icon = null;
            this.browseButton1.Location = new System.Drawing.Point(489, 174);
            this.browseButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.browseButton1.Name = "browseButton1";
            this.browseButton1.Primary = true;
            this.browseButton1.Size = new System.Drawing.Size(76, 36);
            this.browseButton1.TabIndex = 8;
            this.browseButton1.Text = "Browse";
            this.browseButton1.UseVisualStyleBackColor = true;
            this.browseButton1.Click += new System.EventHandler(this.browseButton1_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(597, 182);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(135, 23);
            this.materialLabel3.TabIndex = 10;
            this.materialLabel3.Text = "Start Frame:";
            // 
            // materialLabel4
            // 
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(597, 216);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(135, 23);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Last Frame:";
            this.materialLabel4.Click += new System.EventHandler(this.materialLabel4_Click);
            // 
            // closeAfterStart
            // 
            this.closeAfterStart.Depth = 0;
            this.closeAfterStart.Font = new System.Drawing.Font("Roboto", 10F);
            this.closeAfterStart.Location = new System.Drawing.Point(596, 74);
            this.closeAfterStart.Margin = new System.Windows.Forms.Padding(0);
            this.closeAfterStart.MouseLocation = new System.Drawing.Point(-1, -1);
            this.closeAfterStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeAfterStart.Name = "closeAfterStart";
            this.closeAfterStart.Ripple = true;
            this.closeAfterStart.Size = new System.Drawing.Size(186, 23);
            this.closeAfterStart.TabIndex = 14;
            this.closeAfterStart.Text = "Close after start";
            this.closeAfterStart.UseVisualStyleBackColor = true;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(597, 145);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(135, 23);
            this.materialLabel6.TabIndex = 18;
            this.materialLabel6.Text = "CPU threads:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(597, 261);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(135, 23);
            this.materialLabel7.TabIndex = 19;
            this.materialLabel7.Text = "Frame skip:";
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = true;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Depth = 0;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(489, 248);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Primary = true;
            this.saveButton.Size = new System.Drawing.Size(76, 36);
            this.saveButton.TabIndex = 23;
            this.saveButton.Text = "Browse";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveString
            // 
            this.saveString.Depth = 0;
            this.saveString.Hint = "";
            this.saveString.Location = new System.Drawing.Point(12, 216);
            this.saveString.MaxLength = 32767;
            this.saveString.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveString.Name = "saveString";
            this.saveString.PasswordChar = '\0';
            this.saveString.SelectedText = "";
            this.saveString.SelectionLength = 0;
            this.saveString.SelectionStart = 0;
            this.saveString.Size = new System.Drawing.Size(553, 23);
            this.saveString.TabIndex = 22;
            this.saveString.TabStop = false;
            this.saveString.Text = "Path to save folder";
            this.saveString.UseSystemPasswordChar = false;
            // 
            // startButton1
            // 
            this.startButton1.AutoSize = true;
            this.startButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.startButton1.Depth = 0;
            this.startButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton1.Icon = null;
            this.startButton1.Location = new System.Drawing.Point(718, 290);
            this.startButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.startButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.startButton1.Name = "startButton1";
            this.startButton1.Primary = false;
            this.startButton1.Size = new System.Drawing.Size(64, 36);
            this.startButton1.TabIndex = 25;
            this.startButton1.Text = "START";
            this.startButton1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.startButton1.UseVisualStyleBackColor = true;
            this.startButton1.Click += new System.EventHandler(this.startButton1_Click);
            // 
            // startFrame
            // 
            this.startFrame.Depth = 0;
            this.startFrame.Hint = "";
            this.startFrame.Location = new System.Drawing.Point(738, 182);
            this.startFrame.MaxLength = 32767;
            this.startFrame.MouseState = MaterialSkin.MouseState.HOVER;
            this.startFrame.Name = "startFrame";
            this.startFrame.PasswordChar = '\0';
            this.startFrame.SelectedText = "";
            this.startFrame.SelectionLength = 0;
            this.startFrame.SelectionStart = 0;
            this.startFrame.Size = new System.Drawing.Size(44, 23);
            this.startFrame.TabIndex = 26;
            this.startFrame.TabStop = false;
            this.startFrame.UseSystemPasswordChar = false;
            // 
            // lastFrame
            // 
            this.lastFrame.Depth = 0;
            this.lastFrame.Hint = "";
            this.lastFrame.Location = new System.Drawing.Point(738, 216);
            this.lastFrame.MaxLength = 32767;
            this.lastFrame.MouseState = MaterialSkin.MouseState.HOVER;
            this.lastFrame.Name = "lastFrame";
            this.lastFrame.PasswordChar = '\0';
            this.lastFrame.SelectedText = "";
            this.lastFrame.SelectionLength = 0;
            this.lastFrame.SelectionStart = 0;
            this.lastFrame.Size = new System.Drawing.Size(44, 23);
            this.lastFrame.TabIndex = 27;
            this.lastFrame.TabStop = false;
            this.lastFrame.UseSystemPasswordChar = false;
            // 
            // frameJump
            // 
            this.frameJump.Depth = 0;
            this.frameJump.Hint = "";
            this.frameJump.Location = new System.Drawing.Point(738, 261);
            this.frameJump.MaxLength = 32767;
            this.frameJump.MouseState = MaterialSkin.MouseState.HOVER;
            this.frameJump.Name = "frameJump";
            this.frameJump.PasswordChar = '\0';
            this.frameJump.SelectedText = "";
            this.frameJump.SelectionLength = 0;
            this.frameJump.SelectionStart = 0;
            this.frameJump.Size = new System.Drawing.Size(44, 23);
            this.frameJump.TabIndex = 28;
            this.frameJump.TabStop = false;
            this.frameJump.Text = "0";
            this.frameJump.UseSystemPasswordChar = false;
            // 
            // treatsCPU
            // 
            this.treatsCPU.Depth = 0;
            this.treatsCPU.Hint = "";
            this.treatsCPU.Location = new System.Drawing.Point(738, 145);
            this.treatsCPU.MaxLength = 32767;
            this.treatsCPU.MouseState = MaterialSkin.MouseState.HOVER;
            this.treatsCPU.Name = "treatsCPU";
            this.treatsCPU.PasswordChar = '\0';
            this.treatsCPU.SelectedText = "";
            this.treatsCPU.SelectionLength = 0;
            this.treatsCPU.SelectionStart = 0;
            this.treatsCPU.Size = new System.Drawing.Size(44, 23);
            this.treatsCPU.TabIndex = 29;
            this.treatsCPU.TabStop = false;
            this.treatsCPU.UseSystemPasswordChar = false;
            // 
            // frameName
            // 
            this.frameName.Depth = 0;
            this.frameName.Hint = "";
            this.frameName.Location = new System.Drawing.Point(12, 261);
            this.frameName.MaxLength = 32767;
            this.frameName.MouseState = MaterialSkin.MouseState.HOVER;
            this.frameName.Name = "frameName";
            this.frameName.PasswordChar = '\0';
            this.frameName.SelectedText = "";
            this.frameName.SelectionLength = 0;
            this.frameName.SelectionStart = 0;
            this.frameName.Size = new System.Drawing.Size(142, 23);
            this.frameName.TabIndex = 30;
            this.frameName.TabStop = false;
            this.frameName.Text = "Frame_#";
            this.frameName.UseSystemPasswordChar = false;
            // 
            // saveParmButt
            // 
            this.saveParmButt.AutoSize = true;
            this.saveParmButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveParmButt.Depth = 0;
            this.saveParmButt.Icon = null;
            this.saveParmButt.Location = new System.Drawing.Point(660, 26);
            this.saveParmButt.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveParmButt.Name = "saveParmButt";
            this.saveParmButt.Primary = true;
            this.saveParmButt.Size = new System.Drawing.Size(122, 36);
            this.saveParmButt.TabIndex = 33;
            this.saveParmButt.Text = "Save Settings";
            this.saveParmButt.UseVisualStyleBackColor = true;
            this.saveParmButt.Click += new System.EventHandler(this.saveParmButt_Click);
            // 
            // materialContextMenuStrip1
            // 
            this.materialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialContextMenuStrip1.Depth = 0;
            this.materialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            this.materialContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // startCommand
            // 
            this.startCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startCommand.Location = new System.Drawing.Point(12, 290);
            this.startCommand.Multiline = true;
            this.startCommand.Name = "startCommand";
            this.startCommand.Size = new System.Drawing.Size(699, 36);
            this.startCommand.TabIndex = 35;
            // 
            // AboutButton
            // 
            this.AboutButton.AutoSize = true;
            this.AboutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AboutButton.Depth = 0;
            this.AboutButton.Icon = null;
            this.AboutButton.Location = new System.Drawing.Point(588, 26);
            this.AboutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Primary = true;
            this.AboutButton.Size = new System.Drawing.Size(66, 36);
            this.AboutButton.TabIndex = 36;
            this.AboutButton.Text = "About";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // WikiButt
            // 
            this.WikiButt.AutoSize = true;
            this.WikiButt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WikiButt.Depth = 0;
            this.WikiButt.Icon = null;
            this.WikiButt.Location = new System.Drawing.Point(554, 26);
            this.WikiButt.MouseState = MaterialSkin.MouseState.HOVER;
            this.WikiButt.Name = "WikiButt";
            this.WikiButt.Primary = true;
            this.WikiButt.Size = new System.Drawing.Size(28, 36);
            this.WikiButt.TabIndex = 37;
            this.WikiButt.Text = "?";
            this.WikiButt.UseVisualStyleBackColor = true;
            this.WikiButt.Click += new System.EventHandler(this.WikiButt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 339);
            this.ContextMenuStrip = this.materialContextMenuStrip1;
            this.Controls.Add(this.WikiButt);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.startCommand);
            this.Controls.Add(this.saveParmButt);
            this.Controls.Add(this.frameName);
            this.Controls.Add(this.treatsCPU);
            this.Controls.Add(this.frameJump);
            this.Controls.Add(this.lastFrame);
            this.Controls.Add(this.startFrame);
            this.Controls.Add(this.startButton1);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.saveString);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.closeAfterStart);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.browseButton1);
            this.Controls.Add(this.browseString1);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.browseString);
            this.Controls.Add(this.darkTheme);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "BCR by V&DApps";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckBox darkTheme;
        private MaterialSkin.Controls.MaterialSingleLineTextField browseString;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MaterialSkin.Controls.MaterialRaisedButton browseButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField browseString1;
        private MaterialSkin.Controls.MaterialRaisedButton browseButton1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCheckBox closeAfterStart;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialRaisedButton saveButton;
        private MaterialSkin.Controls.MaterialSingleLineTextField saveString;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MaterialSkin.Controls.MaterialFlatButton startButton1;
        private MaterialSkin.Controls.MaterialSingleLineTextField startFrame;
        private MaterialSkin.Controls.MaterialSingleLineTextField lastFrame;
        private MaterialSkin.Controls.MaterialSingleLineTextField frameJump;
        private MaterialSkin.Controls.MaterialSingleLineTextField treatsCPU;
        private MaterialSkin.Controls.MaterialSingleLineTextField frameName;
        private MaterialSkin.Controls.MaterialRaisedButton saveParmButt;
        private MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;
        private System.Windows.Forms.TextBox startCommand;
        private MaterialSkin.Controls.MaterialRaisedButton AboutButton;
        private MaterialSkin.Controls.MaterialRaisedButton WikiButt;
    }
}