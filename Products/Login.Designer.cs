namespace Products
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelLOGIN = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Btncerrar = new System.Windows.Forms.PictureBox();
            this.BtMinimizar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Btncerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtMinimizar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(216)))), ((int)(((byte)(223)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 330);
            this.panel1.TabIndex = 0;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(326, 105);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(376, 25);
            this.textBoxUsuario.TabIndex = 1;
            this.textBoxUsuario.Text = "USUARIO";
            this.textBoxUsuario.TextChanged += new System.EventHandler(this.textBoxUsuario_TextChanged);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxContraseña.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(326, 198);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '*';
            this.textBoxContraseña.Size = new System.Drawing.Size(376, 25);
            this.textBoxContraseña.TabIndex = 2;
            this.textBoxContraseña.Text = "CONTRASEÑA";
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // labelLOGIN
            // 
            this.labelLOGIN.AutoSize = true;
            this.labelLOGIN.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLOGIN.Location = new System.Drawing.Point(443, 9);
            this.labelLOGIN.Name = "labelLOGIN";
            this.labelLOGIN.Size = new System.Drawing.Size(122, 40);
            this.labelLOGIN.TabIndex = 3;
            this.labelLOGIN.Text = "LOGIN";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(326, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 40);
            this.button1.TabIndex = 4;
            this.button1.Text = "ACCEDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btncerrar
            // 
            this.Btncerrar.Image = ((System.Drawing.Image)(resources.GetObject("Btncerrar.Image")));
            this.Btncerrar.Location = new System.Drawing.Point(736, 0);
            this.Btncerrar.Name = "Btncerrar";
            this.Btncerrar.Size = new System.Drawing.Size(32, 32);
            this.Btncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Btncerrar.TabIndex = 6;
            this.Btncerrar.TabStop = false;
            this.Btncerrar.Click += new System.EventHandler(this.Btncerrar_Click);
            // 
            // BtMinimizar
            // 
            this.BtMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtMinimizar.Image")));
            this.BtMinimizar.Location = new System.Drawing.Point(694, 0);
            this.BtMinimizar.Name = "BtMinimizar";
            this.BtMinimizar.Size = new System.Drawing.Size(32, 32);
            this.BtMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.BtMinimizar.TabIndex = 5;
            this.BtMinimizar.TabStop = false;
            this.BtMinimizar.Click += new System.EventHandler(this.BtMinimizar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.Btncerrar);
            this.Controls.Add(this.BtMinimizar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelLOGIN);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Btncerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtMinimizar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelLOGIN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox BtMinimizar;
        private System.Windows.Forms.PictureBox Btncerrar;
    }
}