
namespace WinFormsAppGra
{
    partial class Form1
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
            this.buttonNowaGra = new System.Windows.Forms.Button();
            this.textBoxMinZakres = new System.Windows.Forms.TextBox();
            this.textBoxMaxZakres = new System.Windows.Forms.TextBox();
            this.buttonWylosuj = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNowaGra
            // 
            this.buttonNowaGra.Location = new System.Drawing.Point(34, 33);
            this.buttonNowaGra.Name = "buttonNowaGra";
            this.buttonNowaGra.Size = new System.Drawing.Size(94, 29);
            this.buttonNowaGra.TabIndex = 0;
            this.buttonNowaGra.Text = "Nowa gra";
            this.buttonNowaGra.UseVisualStyleBackColor = true;
            this.buttonNowaGra.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxMinZakres
            // 
            this.textBoxMinZakres.Location = new System.Drawing.Point(15, 26);
            this.textBoxMinZakres.Name = "textBoxMinZakres";
            this.textBoxMinZakres.Size = new System.Drawing.Size(125, 27);
            this.textBoxMinZakres.TabIndex = 1;
            this.textBoxMinZakres.Text = "1";
            this.textBoxMinZakres.TextChanged += new System.EventHandler(this.textBoxMinZakres_TextChanged);
            // 
            // textBoxMaxZakres
            // 
            this.textBoxMaxZakres.Location = new System.Drawing.Point(15, 64);
            this.textBoxMaxZakres.Name = "textBoxMaxZakres";
            this.textBoxMaxZakres.Size = new System.Drawing.Size(125, 27);
            this.textBoxMaxZakres.TabIndex = 2;
            this.textBoxMaxZakres.Text = "100";
            this.textBoxMaxZakres.TextChanged += new System.EventHandler(this.textBoxMaxZakres_TextChanged);
            // 
            // buttonWylosuj
            // 
            this.buttonWylosuj.Location = new System.Drawing.Point(150, 49);
            this.buttonWylosuj.Name = "buttonWylosuj";
            this.buttonWylosuj.Size = new System.Drawing.Size(94, 29);
            this.buttonWylosuj.TabIndex = 3;
            this.buttonWylosuj.Text = "Wylosuj";
            this.buttonWylosuj.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonWylosuj);
            this.groupBox1.Controls.Add(this.textBoxMaxZakres);
            this.groupBox1.Controls.Add(this.textBoxMinZakres);
            this.groupBox1.Location = new System.Drawing.Point(34, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonNowaGra);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNowaGra;
        private System.Windows.Forms.TextBox textBoxMinZakres;
        private System.Windows.Forms.TextBox textBoxMaxZakres;
        private System.Windows.Forms.Button buttonWylosuj;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

