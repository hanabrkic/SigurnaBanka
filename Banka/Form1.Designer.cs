namespace Banka
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
            this.btnPretvorbaEura = new System.Windows.Forms.Button();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.btnKrediti = new System.Windows.Forms.Button();
            this.btnStednja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPretvorbaEura
            // 
            this.btnPretvorbaEura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPretvorbaEura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.btnPretvorbaEura.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnPretvorbaEura.ForeColor = System.Drawing.Color.Transparent;
            this.btnPretvorbaEura.Location = new System.Drawing.Point(429, 420);
            this.btnPretvorbaEura.Margin = new System.Windows.Forms.Padding(2);
            this.btnPretvorbaEura.Name = "btnPretvorbaEura";
            this.btnPretvorbaEura.Size = new System.Drawing.Size(222, 41);
            this.btnPretvorbaEura.TabIndex = 3;
            this.btnPretvorbaEura.Text = "PRETVORBA EURA";
            this.btnPretvorbaEura.UseVisualStyleBackColor = false;
            this.btnPretvorbaEura.Click += new System.EventHandler(this.btnPretvorbaEura_Click);
            // 
            // btnPrijava
            // 
            this.btnPrijava.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.btnPrijava.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrijava.Location = new System.Drawing.Point(100, 322);
            this.btnPrijava.Margin = new System.Windows.Forms.Padding(0);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(213, 41);
            this.btnPrijava.TabIndex = 4;
            this.btnPrijava.Text = "Prijava | Kalkulator";
            this.btnPrijava.UseVisualStyleBackColor = false;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // btnKrediti
            // 
            this.btnKrediti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.btnKrediti.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnKrediti.ForeColor = System.Drawing.Color.Transparent;
            this.btnKrediti.Location = new System.Drawing.Point(429, 322);
            this.btnKrediti.Margin = new System.Windows.Forms.Padding(2);
            this.btnKrediti.Name = "btnKrediti";
            this.btnKrediti.Size = new System.Drawing.Size(222, 41);
            this.btnKrediti.TabIndex = 5;
            this.btnKrediti.Text = "Krediti";
            this.btnKrediti.UseVisualStyleBackColor = false;
            this.btnKrediti.Click += new System.EventHandler(this.btnKrediti_Click);
            // 
            // btnStednja
            // 
            this.btnStednja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(186)))), ((int)(((byte)(0)))));
            this.btnStednja.Font = new System.Drawing.Font("Perpetua Titling MT", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnStednja.ForeColor = System.Drawing.Color.Transparent;
            this.btnStednja.Location = new System.Drawing.Point(100, 420);
            this.btnStednja.Margin = new System.Windows.Forms.Padding(2);
            this.btnStednja.Name = "btnStednja";
            this.btnStednja.Size = new System.Drawing.Size(213, 41);
            this.btnStednja.TabIndex = 6;
            this.btnStednja.Text = "Štednja i investicije";
            this.btnStednja.UseVisualStyleBackColor = false;
            this.btnStednja.Click += new System.EventHandler(this.btnStednja_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Banka.Properties.Resources.Banka_slika;
            this.ClientSize = new System.Drawing.Size(1362, 750);
            this.Controls.Add(this.btnStednja);
            this.Controls.Add(this.btnKrediti);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.btnPretvorbaEura);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Sigurna Banka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPretvorbaEura;
        private System.Windows.Forms.Button btnPrijava;
        private System.Windows.Forms.Button btnKrediti;
        private System.Windows.Forms.Button btnStednja;
    }
}

