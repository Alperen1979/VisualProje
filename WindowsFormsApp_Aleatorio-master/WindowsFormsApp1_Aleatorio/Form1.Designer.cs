namespace WindowsFormsApp1_Aleatorio
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonONOFF = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFrutas1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxFrutas2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxFrutas3 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelMoney = new System.Windows.Forms.Label();
            this.buttonGuaranteeWin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrutas1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrutas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrutas3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonONOFF
            // 
            this.buttonONOFF.BackColor = System.Drawing.Color.Transparent;
            this.buttonONOFF.BackgroundImage = global::WindowsFormsApp1_Aleatorio.Properties.Resources.ONOFF;
            this.buttonONOFF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonONOFF.Location = new System.Drawing.Point(16, 470);
            this.buttonONOFF.Margin = new System.Windows.Forms.Padding(4);
            this.buttonONOFF.Name = "buttonONOFF";
            this.buttonONOFF.Size = new System.Drawing.Size(60, 52);
            this.buttonONOFF.TabIndex = 0;
            this.buttonONOFF.UseVisualStyleBackColor = false;
            this.buttonONOFF.Click += new System.EventHandler(this.buttonONOFF_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp1_Aleatorio.Properties.Resources.palanca1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(841, 91);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(59, 180);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // pictureBoxFrutas1
            // 
            this.pictureBoxFrutas1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxFrutas1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFrutas1.Location = new System.Drawing.Point(188, 267);
            this.pictureBoxFrutas1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFrutas1.Name = "pictureBoxFrutas1";
            this.pictureBoxFrutas1.Size = new System.Drawing.Size(153, 148);
            this.pictureBoxFrutas1.TabIndex = 2;
            this.pictureBoxFrutas1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp1_Aleatorio.Properties.Resources.palanca2;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(841, 178);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 92);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pictureBoxFrutas2
            // 
            this.pictureBoxFrutas2.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxFrutas2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFrutas2.Location = new System.Drawing.Point(399, 252);
            this.pictureBoxFrutas2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFrutas2.Name = "pictureBoxFrutas2";
            this.pictureBoxFrutas2.Size = new System.Drawing.Size(153, 148);
            this.pictureBoxFrutas2.TabIndex = 5;
            this.pictureBoxFrutas2.TabStop = false;
            // 
            // pictureBoxFrutas3
            // 
            this.pictureBoxFrutas3.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBoxFrutas3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxFrutas3.Location = new System.Drawing.Point(607, 252);
            this.pictureBoxFrutas3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFrutas3.Name = "pictureBoxFrutas3";
            this.pictureBoxFrutas3.Size = new System.Drawing.Size(153, 148);
            this.pictureBoxFrutas3.TabIndex = 6;
            this.pictureBoxFrutas3.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::WindowsFormsApp1_Aleatorio.Properties.Resources.TituloF;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(264, 1);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(416, 149);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // labelMoney
            // 
            this.labelMoney.AutoSize = true;
            this.labelMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMoney.Location = new System.Drawing.Point(725, 59);
            this.labelMoney.Name = "labelMoney";
            this.labelMoney.Size = new System.Drawing.Size(0, 29);
            this.labelMoney.TabIndex = 8;
            // 
            // buttonGuaranteeWin
            // 
            this.buttonGuaranteeWin.BackColor = System.Drawing.Color.Transparent;
            this.buttonGuaranteeWin.Location = new System.Drawing.Point(149, 76);
            this.buttonGuaranteeWin.Name = "buttonGuaranteeWin";
            this.buttonGuaranteeWin.Size = new System.Drawing.Size(108, 23);
            this.buttonGuaranteeWin.TabIndex = 9;
            this.buttonGuaranteeWin.Text = "GuaranteeWin";
            this.buttonGuaranteeWin.UseVisualStyleBackColor = false;
            this.buttonGuaranteeWin.Click += new System.EventHandler(this.buttonGuaranteeWin_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::WindowsFormsApp1_Aleatorio.Properties.Resources.FondoU;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(999, 537);
            this.ControlBox = false;
            this.Controls.Add(this.buttonGuaranteeWin);
            this.Controls.Add(this.labelMoney);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBoxFrutas3);
            this.Controls.Add(this.pictureBoxFrutas2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxFrutas1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonONOFF);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrutas1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrutas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFrutas3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonONOFF;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBoxFrutas1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBoxFrutas2;
        private System.Windows.Forms.PictureBox pictureBoxFrutas3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelMoney;
        private System.Windows.Forms.Button buttonGuaranteeWin;
    }
}

