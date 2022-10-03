
namespace Vizsga
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
            this.tbBeolvasas = new System.Windows.Forms.Label();
            this.lboxAdatok = new System.Windows.Forms.ListBox();
            this.btnSikeres = new System.Windows.Forms.Button();
            this.lbFo = new System.Windows.Forms.Label();
            this.btnAllomanybaIras = new System.Windows.Forms.Button();
            this.lbKeresett = new System.Windows.Forms.Label();
            this.tbKeresett = new System.Windows.Forms.TextBox();
            this.btnKereses = new System.Windows.Forms.Button();
            this.lbAdatok = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbBeolvasas
            // 
            this.tbBeolvasas.AutoSize = true;
            this.tbBeolvasas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbBeolvasas.Location = new System.Drawing.Point(13, 19);
            this.tbBeolvasas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbBeolvasas.Name = "tbBeolvasas";
            this.tbBeolvasas.Size = new System.Drawing.Size(216, 20);
            this.tbBeolvasas.TabIndex = 0;
            this.tbBeolvasas.Text = "0 vizsgázó adatait beolvastuk";
            // 
            // lboxAdatok
            // 
            this.lboxAdatok.FormattingEnabled = true;
            this.lboxAdatok.ItemHeight = 20;
            this.lboxAdatok.Location = new System.Drawing.Point(12, 58);
            this.lboxAdatok.Name = "lboxAdatok";
            this.lboxAdatok.Size = new System.Drawing.Size(248, 524);
            this.lboxAdatok.TabIndex = 1;
            // 
            // btnSikeres
            // 
            this.btnSikeres.Location = new System.Drawing.Point(310, 58);
            this.btnSikeres.Name = "btnSikeres";
            this.btnSikeres.Size = new System.Drawing.Size(243, 46);
            this.btnSikeres.TabIndex = 2;
            this.btnSikeres.Text = "Sikeres vizsgát tett";
            this.btnSikeres.UseVisualStyleBackColor = true;
            // 
            // lbFo
            // 
            this.lbFo.AutoSize = true;
            this.lbFo.Location = new System.Drawing.Point(628, 71);
            this.lbFo.Name = "lbFo";
            this.lbFo.Size = new System.Drawing.Size(36, 20);
            this.lbFo.TabIndex = 3;
            this.lbFo.Text = "0 fő";
            // 
            // btnAllomanybaIras
            // 
            this.btnAllomanybaIras.Location = new System.Drawing.Point(310, 163);
            this.btnAllomanybaIras.Name = "btnAllomanybaIras";
            this.btnAllomanybaIras.Size = new System.Drawing.Size(243, 46);
            this.btnAllomanybaIras.TabIndex = 2;
            this.btnAllomanybaIras.Text = "Eredmények állományba írása";
            this.btnAllomanybaIras.UseVisualStyleBackColor = true;
            // 
            // lbKeresett
            // 
            this.lbKeresett.AutoSize = true;
            this.lbKeresett.Location = new System.Drawing.Point(306, 258);
            this.lbKeresett.Name = "lbKeresett";
            this.lbKeresett.Size = new System.Drawing.Size(117, 20);
            this.lbKeresett.TabIndex = 3;
            this.lbKeresett.Text = "Keresett tanuló";
            // 
            // tbKeresett
            // 
            this.tbKeresett.Location = new System.Drawing.Point(310, 310);
            this.tbKeresett.Name = "tbKeresett";
            this.tbKeresett.Size = new System.Drawing.Size(196, 26);
            this.tbKeresett.TabIndex = 4;
            // 
            // btnKereses
            // 
            this.btnKereses.Location = new System.Drawing.Point(570, 300);
            this.btnKereses.Name = "btnKereses";
            this.btnKereses.Size = new System.Drawing.Size(94, 46);
            this.btnKereses.TabIndex = 2;
            this.btnKereses.Text = "Keresés";
            this.btnKereses.UseVisualStyleBackColor = true;
            // 
            // lbAdatok
            // 
            this.lbAdatok.AutoSize = true;
            this.lbAdatok.Location = new System.Drawing.Point(310, 402);
            this.lbAdatok.Name = "lbAdatok";
            this.lbAdatok.Size = new System.Drawing.Size(105, 20);
            this.lbAdatok.TabIndex = 5;
            this.lbAdatok.Text = "Tanuló adatai";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 600);
            this.Controls.Add(this.lbAdatok);
            this.Controls.Add(this.tbKeresett);
            this.Controls.Add(this.lbKeresett);
            this.Controls.Add(this.lbFo);
            this.Controls.Add(this.btnKereses);
            this.Controls.Add(this.btnAllomanybaIras);
            this.Controls.Add(this.btnSikeres);
            this.Controls.Add(this.lboxAdatok);
            this.Controls.Add(this.tbBeolvasas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendszerüzemeltető vizsga";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tbBeolvasas;
        private System.Windows.Forms.ListBox lboxAdatok;
        private System.Windows.Forms.Button btnSikeres;
        private System.Windows.Forms.Label lbFo;
        private System.Windows.Forms.Button btnAllomanybaIras;
        private System.Windows.Forms.Label lbKeresett;
        private System.Windows.Forms.TextBox tbKeresett;
        private System.Windows.Forms.Button btnKereses;
        private System.Windows.Forms.Label lbAdatok;
    }
}

