namespace Conversor
{
    partial class HesperiaConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HesperiaConverter));
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            panelDrop = new Panel();
            listBox1 = new ListBox();
            lblDrop = new Label();
            panelDrop.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 288);
            label1.Name = "label1";
            label1.Size = new Size(158, 38);
            label1.TabIndex = 0;
            label1.Text = "Convertir a:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "PNG", "JPG", "GIF", "ICO", "WEBP", "BMP", "TIFF", "TGA" });
            comboBox1.Location = new Point(278, 298);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(451, 267);
            button1.Name = "button1";
            button1.Size = new Size(265, 90);
            button1.TabIndex = 2;
            button1.Text = "CONVERTIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panelDrop
            // 
            panelDrop.AllowDrop = true;
            panelDrop.BackColor = Color.WhiteSmoke;
            panelDrop.BorderStyle = BorderStyle.FixedSingle;
            panelDrop.Controls.Add(listBox1);
            panelDrop.Controls.Add(lblDrop);
            panelDrop.Location = new Point(114, 34);
            panelDrop.Name = "panelDrop";
            panelDrop.Size = new Size(611, 212);
            panelDrop.TabIndex = 3;
            panelDrop.DragDrop += panelDrop_DragDrop;
            panelDrop.DragEnter += panelDrop_DragEnter;
            panelDrop.Paint += panelDrop_Paint;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(-1, 109);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(611, 104);
            listBox1.TabIndex = 1;
            // 
            // lblDrop
            // 
            lblDrop.AutoSize = true;
            lblDrop.Location = new Point(35, 54);
            lblDrop.Name = "lblDrop";
            lblDrop.Size = new Size(175, 20);
            lblDrop.TabIndex = 0;
            lblDrop.Text = "Arrastra los archivos aquí";
            lblDrop.Click += label2_Click;
            // 
            // HesperiaConverter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(panelDrop);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "HesperiaConverter";
            Text = "Form1";
            Load += Form1_Load;
            panelDrop.ResumeLayout(false);
            panelDrop.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Button button1;
        private Panel panelDrop;
        private Label lblDrop;
        private ListBox listBox1;
    }
}
