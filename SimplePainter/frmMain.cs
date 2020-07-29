using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;

namespace SimplePainter
{
    public partial class FrmMain : Form
    {
        Bitmap img, cache; // paint image, cache image

        Point p; // start point
        Color bColor = Color.White;
        Color fColor = SystemColors.ControlText;
        Pen dPen = Pens.Black;

        enum PenMode { None, Picker, Pen, Line, Elli, Rect, Text, Erase };
        PenMode penMode;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            img = new Bitmap(picImg.Width, picImg.Height);
            using (var g = Graphics.FromImage(img))
            {
                g.Clear(Color.White);
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;
            }
            cache = new Bitmap(img);
        }

        private void picImg_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(img, 0, 0);
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog() { Filter = "Image Files (*.bmp; *.jpg; *.png)| *.bmp; *.jpg; *.png" };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Text = dlg.FileName;
                RenewPainter();
                var temp = Image.FromFile(dlg.FileName);
                using (var g = Graphics.FromImage(img))
                {
                    g.DrawImage(temp, 0, 0, temp.Width, temp.Height);
                }
                picImg.Refresh();
            }
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            Text = "New Paint";
            RenewPainter();
            picImg.Refresh();
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog() { Filter = "Portable Network Graphics (*.png)|*.png|Bitmap file (*.bmp)|*.bmp|JPEG File(*.jpg)| *.jpg", FileName = Text };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string ext = Path.GetExtension(dlg.FileName).ToLower();
                switch (ext.ToLower())
                {
                    case ".png":
                        img.Save(dlg.FileName, ImageFormat.Png);
                        break;
                    case ".bmp":
                        img.Save(dlg.FileName, ImageFormat.Bmp);
                        break;
                    case ".jpg":
                        img.Save(dlg.FileName, ImageFormat.Jpeg);
                        break;
                }
                Text = dlg.FileName;
            }
        }

        private void tsmiClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tsmiFColor_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                fColor = dlg.Color;
                dPen = new Pen(fColor, 1);
                tsmiFColor.BackColor = fColor;
            }
        }

        private void tsmiBColor_Click(object sender, EventArgs e)
        {
            var dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                bColor = dlg.Color;
                tsmiBColor.BackColor = bColor;
            }
        }

        private void TsmiPicker_Click(object sender, EventArgs e)
        {
            penMode = PenMode.Picker;
            Cursor = Cursors.Cross;
            CleanTsmi();
            tsmiPicker.BackColor = SystemColors.Highlight;
        }

        private void tsmiMouse_Click(object sender, EventArgs e)
        {
            penMode = PenMode.None;
            Cursor = Cursors.Default;
            CleanTsmi();
            tsmiMouse.BackColor = SystemColors.Highlight;
        }

        private void tsmiPen_Click(object sender, EventArgs e)
        {
            penMode = PenMode.Pen;
            Cursor = Cursors.Cross;
            CleanTsmi();
            tsmiPen.BackColor = SystemColors.Highlight;
        }

        private void tsmiLine_Click(object sender, EventArgs e)
        {
            penMode = PenMode.Line;
            Cursor = Cursors.Cross;
            CleanTsmi();
            tsmiLine.BackColor = SystemColors.Highlight;
        }

        private void tsmiRect_Click(object sender, EventArgs e)
        {
            penMode = PenMode.Rect;
            Cursor = Cursors.Cross;
            CleanTsmi();
            tsmiRect.BackColor = SystemColors.Highlight;
        }

        private void tsmiElli_Click(object sender, EventArgs e)
        {
            penMode = PenMode.Elli;
            Cursor = Cursors.Cross;
            CleanTsmi();
            tsmiElli.BackColor = SystemColors.Highlight;
        }

        private void tsmiText_Click(object sender, EventArgs e)
        {
            penMode = PenMode.Text;
            Cursor = Cursors.IBeam;
            CleanTsmi();
            tsmiText.BackColor = SystemColors.Highlight;
        }

        private void tsmiEraser_Click(object sender, EventArgs e)
        {
            penMode = PenMode.Erase;
            Cursor = Cursors.WaitCursor;
            CleanTsmi();
            tsmiErase.BackColor = SystemColors.Highlight;
        }

        private void picImg_MouseDown(object sender, MouseEventArgs e)
        {
            using (var g = Graphics.FromImage(img))
            {                
                g.DrawString(txtInput.Text, txtInput.Font, new SolidBrush(fColor), p.X + 1, p.Y - 2);
            }
            p = e.Location;
            switch (penMode)
            {
                case PenMode.None:
                case PenMode.Picker:
                    break;
                case PenMode.Text:
                    txtInput.Text = "";
                    txtInput.Location = new Point(e.X + 4, e.Y + 22);
                    txtInput.BackColor = tsmiBColor.BackColor;
                    txtInput.Visible = true;
                    txtInput.Focus();
                    break;
                default:
                    picImg.MouseMove += new MouseEventHandler(picImg_MouseMove);
                    break;
            }
        }

        private void picImg_MouseMove(object sender, MouseEventArgs e)
        {
            switch (penMode)
            {
                case PenMode.Pen:
                    using (var g = Graphics.FromImage(img))
                    {
                        g.DrawLine(dPen, p, e.Location);
                    }
                    p = e.Location;
                    break;
                case PenMode.Line:
                    img = new Bitmap(cache);
                    using (var g = Graphics.FromImage(img))
                    {
                        g.DrawLine(dPen, p, e.Location);
                    }
                    break;
                case PenMode.Rect:
                    img = new Bitmap(cache);
                    using (var g = Graphics.FromImage(img))
                    {
                        g.DrawRectangle(dPen, Math.Min(p.X, e.X), Math.Min(p.Y, e.Y), Math.Abs(e.X - p.X), Math.Abs(e.Y - p.Y));
                    }
                    break;
                case PenMode.Elli:
                    img = new Bitmap(cache);
                    using (var g = Graphics.FromImage(img))
                    {
                        g.DrawEllipse(dPen, p.X, p.Y, e.X - p.X, e.Y - p.Y);
                    }
                    break;
                case PenMode.Erase:
                    using (var g = Graphics.FromImage(img))
                    {
                        g.FillEllipse(new SolidBrush(bColor), p.X - 15, p.Y - 15, 30, 30);
                        g.DrawLine(new Pen(bColor, 30), p, e.Location);
                    }
                    p = e.Location;
                    break;
            }
            picImg.Refresh();
        }

        private void picImg_MouseUp(object sender, MouseEventArgs e)
        {
            switch (penMode)
            {
                case PenMode.Picker:
                    fColor = img.GetPixel(e.X,e.Y);
                    dPen = new Pen(fColor, 1);
                    tsmiFColor.BackColor = fColor;
                    break;
                case PenMode.Line:
                    img = new Bitmap(cache);
                    using (var g = Graphics.FromImage(img))
                    {
                        g.DrawLine(dPen, p, e.Location);
                    }
                    break;
                case PenMode.Rect:
                    img = new Bitmap(cache);
                    using (var g = Graphics.FromImage(img))
                    {
                        g.DrawRectangle(dPen, Math.Min(p.X, e.X), Math.Min(p.Y, e.Y), Math.Abs(e.X - p.X), Math.Abs(e.Y - p.Y));
                    }
                    break;
                case PenMode.Elli:
                    img = new Bitmap(cache);
                    using (var g = Graphics.FromImage(img))
                    {
                        g.DrawEllipse(dPen, p.X, p.Y, e.X - p.X, e.Y - p.Y);
                    }
                    break;
            }
            cache = new Bitmap(img);
            picImg.MouseMove -= new MouseEventHandler(picImg_MouseMove);
            picImg.Refresh();
        }

        private void TsmiNewPNG_Click(object sender, EventArgs e)
        {
            Text = "New PNG file";
            RenewPainter();
            using (var g = Graphics.FromImage(img))
            {
                g.Clear(Color.Transparent);
            }
            picImg.Refresh();
        }

        private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)13 && e.KeyChar != (char)27)
                return;
            if (e.KeyChar == (char)13)
            {
                using (var g = Graphics.FromImage(img))
                {
                    g.DrawString(txtInput.Text, txtInput.Font, new SolidBrush(fColor), p.X + 1, p.Y - 2);                
                }
            }
            txtInput.Text = "";
            txtInput.Visible = false;
        }

        private void RenewPainter()
        {
            using (var g = Graphics.FromImage(img))
            {
                g.Clear(Color.White);
            }
            cache = new Bitmap(img);
            bColor = Color.White;
            fColor = SystemColors.ControlText;
            tsmiBColor.BackColor = bColor;
            tsmiFColor.BackColor = fColor;
            Cursor = Cursors.Default;
            penMode = PenMode.None;
            CleanTsmi();
            tsmiMouse.BackColor = SystemColors.Highlight;
        }

        private void CleanTsmi()
        {
            tsmiPicker.BackColor = SystemColors.Control;
            tsmiMouse.BackColor = SystemColors.Control;
            tsmiPen.BackColor = SystemColors.Control;
            tsmiLine.BackColor = SystemColors.Control;
            tsmiRect.BackColor = SystemColors.Control;
            tsmiElli.BackColor = SystemColors.Control;
            tsmiText.BackColor = SystemColors.Control;
            tsmiErase.BackColor = SystemColors.Control;
            txtInput.Visible = false;
        }
    }
}