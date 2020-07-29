namespace SimplePainter
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewPNG = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBColor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMouse = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPen = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiElli = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiText = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiErase = new System.Windows.Forms.ToolStripMenuItem();
            this.picImg = new System.Windows.Forms.PictureBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.tsmiPicker = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiFColor,
            this.tsmiBColor,
            this.tsmiPicker,
            this.tsmiMouse,
            this.tsmiPen,
            this.tsmiLine,
            this.tsmiRect,
            this.tsmiElli,
            this.tsmiText,
            this.tsmiErase});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.mnsMenu.Size = new System.Drawing.Size(1176, 25);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "mstipMenu";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOpen,
            this.tsmiNew,
            this.tsmiNewPNG,
            this.tsmiSave,
            this.tsmiClose});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 19);
            this.tsmiFile.Text = "File";
            // 
            // tsmiOpen
            // 
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Size = new System.Drawing.Size(125, 22);
            this.tsmiOpen.Text = "Open";
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);
            // 
            // tsmiNew
            // 
            this.tsmiNew.Name = "tsmiNew";
            this.tsmiNew.Size = new System.Drawing.Size(125, 22);
            this.tsmiNew.Text = "New";
            this.tsmiNew.Click += new System.EventHandler(this.tsmiNew_Click);
            // 
            // tsmiNewPNG
            // 
            this.tsmiNewPNG.Name = "tsmiNewPNG";
            this.tsmiNewPNG.Size = new System.Drawing.Size(125, 22);
            this.tsmiNewPNG.Text = "New PNG";
            this.tsmiNewPNG.Click += new System.EventHandler(this.TsmiNewPNG_Click);
            // 
            // tsmiSave
            // 
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(125, 22);
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Click += new System.EventHandler(this.tsmiSave_Click);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(125, 22);
            this.tsmiClose.Text = "Close";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // tsmiFColor
            // 
            this.tsmiFColor.BackColor = System.Drawing.SystemColors.ControlText;
            this.tsmiFColor.ForeColor = System.Drawing.SystemColors.Control;
            this.tsmiFColor.Name = "tsmiFColor";
            this.tsmiFColor.Size = new System.Drawing.Size(71, 19);
            this.tsmiFColor.Text = "ForeColor";
            this.tsmiFColor.Click += new System.EventHandler(this.tsmiFColor_Click);
            // 
            // tsmiBColor
            // 
            this.tsmiBColor.BackColor = System.Drawing.Color.White;
            this.tsmiBColor.Name = "tsmiBColor";
            this.tsmiBColor.Size = new System.Drawing.Size(73, 19);
            this.tsmiBColor.Text = "BackColor";
            this.tsmiBColor.Click += new System.EventHandler(this.tsmiBColor_Click);
            // 
            // tsmiMouse
            // 
            this.tsmiMouse.BackColor = System.Drawing.SystemColors.Highlight;
            this.tsmiMouse.Name = "tsmiMouse";
            this.tsmiMouse.Size = new System.Drawing.Size(55, 19);
            this.tsmiMouse.Text = "Mouse";
            this.tsmiMouse.Click += new System.EventHandler(this.tsmiMouse_Click);
            // 
            // tsmiPen
            // 
            this.tsmiPen.Checked = true;
            this.tsmiPen.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.tsmiPen.Name = "tsmiPen";
            this.tsmiPen.Size = new System.Drawing.Size(39, 19);
            this.tsmiPen.Text = "Pen";
            this.tsmiPen.Click += new System.EventHandler(this.tsmiPen_Click);
            // 
            // tsmiLine
            // 
            this.tsmiLine.Name = "tsmiLine";
            this.tsmiLine.Size = new System.Drawing.Size(41, 19);
            this.tsmiLine.Text = "Line";
            this.tsmiLine.Click += new System.EventHandler(this.tsmiLine_Click);
            // 
            // tsmiRect
            // 
            this.tsmiRect.Name = "tsmiRect";
            this.tsmiRect.Size = new System.Drawing.Size(71, 19);
            this.tsmiRect.Text = "Rectangle";
            this.tsmiRect.Click += new System.EventHandler(this.tsmiRect_Click);
            // 
            // tsmiElli
            // 
            this.tsmiElli.BackColor = System.Drawing.SystemColors.Control;
            this.tsmiElli.Name = "tsmiElli";
            this.tsmiElli.Size = new System.Drawing.Size(52, 19);
            this.tsmiElli.Text = "Ellipse";
            this.tsmiElli.Click += new System.EventHandler(this.tsmiElli_Click);
            // 
            // tsmiText
            // 
            this.tsmiText.Name = "tsmiText";
            this.tsmiText.Size = new System.Drawing.Size(40, 19);
            this.tsmiText.Text = "Text";
            this.tsmiText.Click += new System.EventHandler(this.tsmiText_Click);
            // 
            // tsmiErase
            // 
            this.tsmiErase.Name = "tsmiErase";
            this.tsmiErase.Size = new System.Drawing.Size(50, 19);
            this.tsmiErase.Text = "Eraser";
            this.tsmiErase.Click += new System.EventHandler(this.tsmiEraser_Click);
            // 
            // picImg
            // 
            this.picImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picImg.Location = new System.Drawing.Point(0, 25);
            this.picImg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picImg.Name = "picImg";
            this.picImg.Size = new System.Drawing.Size(1176, 838);
            this.picImg.TabIndex = 2;
            this.picImg.TabStop = false;
            this.picImg.Paint += new System.Windows.Forms.PaintEventHandler(this.picImg_Paint);
            this.picImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picImg_MouseDown);
            this.picImg.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picImg_MouseUp);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Location = new System.Drawing.Point(38, 58);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(150, 19);
            this.txtInput.TabIndex = 3;
            this.txtInput.Visible = false;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // tsmiPicker
            // 
            this.tsmiPicker.Name = "tsmiPicker";
            this.tsmiPicker.Size = new System.Drawing.Size(51, 19);
            this.tsmiPicker.Text = "Picker";
            this.tsmiPicker.Click += new System.EventHandler(this.TsmiPicker_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.picImg);
            this.Controls.Add(this.mnsMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnsMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Simple Painter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripMenuItem tsmiNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.ToolStripMenuItem tsmiFColor;
        private System.Windows.Forms.PictureBox picImg;
        private System.Windows.Forms.ToolStripMenuItem tsmiPen;
        private System.Windows.Forms.ToolStripMenuItem tsmiLine;
        private System.Windows.Forms.ToolStripMenuItem tsmiRect;
        private System.Windows.Forms.ToolStripMenuItem tsmiElli;
        private System.Windows.Forms.ToolStripMenuItem tsmiText;
        private System.Windows.Forms.ToolStripMenuItem tsmiErase;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ToolStripMenuItem tsmiBColor;
        private System.Windows.Forms.ToolStripMenuItem tsmiMouse;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewPNG;
        private System.Windows.Forms.ToolStripMenuItem tsmiPicker;
    }
}

