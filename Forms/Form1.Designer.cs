namespace ConverIt
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
            this.Txtinput = new HartUI.Controls.cuiTextBox();
            this.btnExecute = new HartUI.Controls.cuiButton();
            this.cuiChartLine1 = new HartUI.Controls.Charts.cuiChartLine();
            this.Output = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Txtinput
            // 
            this.Txtinput.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.Txtinput.Content = "contet";
            this.Txtinput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txtinput.FocusBackgroundColor = System.Drawing.Color.DarkOliveGreen;
            this.Txtinput.FocusImageTint = System.Drawing.Color.DarkSeaGreen;
            this.Txtinput.FocusOutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(24)))), ((int)(((byte)(226)))));
            this.Txtinput.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtinput.ForeColor = System.Drawing.Color.Ivory;
            this.Txtinput.Image = null;
            this.Txtinput.ImageExpand = new System.Drawing.Point(0, 0);
            this.Txtinput.ImageOffset = new System.Drawing.Point(0, 0);
            this.Txtinput.ImageTextSpacing = 8;
            this.Txtinput.Location = new System.Drawing.Point(38, 45);
            this.Txtinput.Margin = new System.Windows.Forms.Padding(4);
            this.Txtinput.Multiline = false;
            this.Txtinput.Name = "Txtinput";
            this.Txtinput.NormalImageTint = System.Drawing.Color.White;
            this.Txtinput.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Txtinput.Padding = new System.Windows.Forms.Padding(20, 14, 20, 0);
            this.Txtinput.PasswordChar = false;
            this.Txtinput.PlaceholderColor = System.Drawing.Color.LightGray;
            this.Txtinput.PlaceholderText = "Placeholder text..";
            this.Txtinput.Rounding = new System.Windows.Forms.Padding(8);
            this.Txtinput.Size = new System.Drawing.Size(881, 49);
            this.Txtinput.TabIndex = 0;
            this.Txtinput.TextOffset = new System.Drawing.Size(0, 0);
            this.Txtinput.UnderlinedStyle = true;
            this.Txtinput.ContentChanged += new System.EventHandler(this.cuiTextBox1_ContentChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.CheckButton = false;
            this.btnExecute.Checked = false;
            this.btnExecute.CheckedBackground = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(24)))), ((int)(((byte)(226)))));
            this.btnExecute.CheckedForeColor = System.Drawing.Color.White;
            this.btnExecute.CheckedImageTint = System.Drawing.Color.White;
            this.btnExecute.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(24)))), ((int)(((byte)(226)))));
            this.btnExecute.Content = "Execute";
            this.btnExecute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExecute.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExecute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnExecute.ForeColor = System.Drawing.Color.Ivory;
            this.btnExecute.HoverBackground = System.Drawing.Color.White;
            this.btnExecute.HoverForeColor = System.Drawing.Color.DimGray;
            this.btnExecute.HoverImageTint = System.Drawing.Color.DimGray;
            this.btnExecute.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExecute.Image = null;
            this.btnExecute.ImageExpand = new System.Drawing.Point(0, 0);
            this.btnExecute.Location = new System.Drawing.Point(941, 45);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.NormalBackground = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.btnExecute.NormalForeColor = System.Drawing.Color.Ivory;
            this.btnExecute.NormalImageTint = System.Drawing.Color.Black;
            this.btnExecute.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExecute.OutlineThickness = 1F;
            this.btnExecute.Padding = new System.Windows.Forms.Padding(12);
            this.btnExecute.PressedBackground = System.Drawing.Color.WhiteSmoke;
            this.btnExecute.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnExecute.PressedImageTint = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnExecute.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnExecute.Rounding = new System.Windows.Forms.Padding(8);
            this.btnExecute.Size = new System.Drawing.Size(162, 49);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnExecute.TextPadding = 12;
            this.btnExecute.TextSpacing = 2;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // cuiChartLine1
            // 
            this.cuiChartLine1.AutoMaxValue = false;
            this.cuiChartLine1.AxisColor = System.Drawing.Color.Gray;
            this.cuiChartLine1.ChartLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(24)))), ((int)(((byte)(226)))));
            this.cuiChartLine1.ChartPadding = 40;
            this.cuiChartLine1.CustomXAxis = new string[0];
            this.cuiChartLine1.DataPoints = new float[] {
        100F,
        90F,
        80F,
        75F,
        70F,
        65F,
        60F};
            this.cuiChartLine1.DayColor = System.Drawing.Color.DarkGray;
            this.cuiChartLine1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F);
            this.cuiChartLine1.GradientBackground = true;
            this.cuiChartLine1.Location = new System.Drawing.Point(333, 525);
            this.cuiChartLine1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cuiChartLine1.MaxValue = 100F;
            this.cuiChartLine1.Name = "cuiChartLine1";
            this.cuiChartLine1.PointColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(24)))), ((int)(((byte)(226)))));
            this.cuiChartLine1.ShortDates = true;
            this.cuiChartLine1.ShowLines = true;
            this.cuiChartLine1.Size = new System.Drawing.Size(9, 8);
            this.cuiChartLine1.TabIndex = 2;
            this.cuiChartLine1.UseBezier = false;
            this.cuiChartLine1.UsePercent = true;
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(177)))), ((int)(((byte)(138)))));
            this.Output.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Output.Location = new System.Drawing.Point(38, 116);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(881, 477);
            this.Output.TabIndex = 3;
            this.Output.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(78)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1130, 639);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.cuiChartLine1);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.Txtinput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HartUI.Controls.cuiTextBox Txtinput;
        private HartUI.Controls.cuiButton btnExecute;
        private HartUI.Controls.Charts.cuiChartLine cuiChartLine1;
        private System.Windows.Forms.RichTextBox Output;
    }
}

