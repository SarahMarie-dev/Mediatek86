
namespace Mediatek86
{
    partial class Mediatek86Frm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginTxtBox = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loginLbl = new System.Windows.Forms.Label();
            this.mdpLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.validationBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginTxtBox
            // 
            this.loginTxtBox.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTxtBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.loginTxtBox.Location = new System.Drawing.Point(106, 180);
            this.loginTxtBox.Name = "loginTxtBox";
            this.loginTxtBox.Size = new System.Drawing.Size(193, 22);
            this.loginTxtBox.TabIndex = 0;
            this.loginTxtBox.Text = "Entrer votre identifiant";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.Location = new System.Drawing.Point(106, 268);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(193, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Entrer votre mot de passe";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // loginLbl
            // 
            this.loginLbl.AutoSize = true;
            this.loginLbl.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLbl.Location = new System.Drawing.Point(161, 146);
            this.loginLbl.Name = "loginLbl";
            this.loginLbl.Size = new System.Drawing.Size(75, 19);
            this.loginLbl.TabIndex = 2;
            this.loginLbl.Text = "Identifiant";
            // 
            // mdpLbl
            // 
            this.mdpLbl.AutoSize = true;
            this.mdpLbl.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdpLbl.Location = new System.Drawing.Point(150, 232);
            this.mdpLbl.Name = "mdpLbl";
            this.mdpLbl.Size = new System.Drawing.Size(96, 19);
            this.mdpLbl.TabIndex = 3;
            this.mdpLbl.Text = "Mot de passe";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mediatek86 - Gestion des absences";
            // 
            // validationBtn
            // 
            this.validationBtn.AllowDrop = true;
            this.validationBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.validationBtn.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.validationBtn.FlatAppearance.BorderSize = 0;
            this.validationBtn.Location = new System.Drawing.Point(177, 324);
            this.validationBtn.Name = "validationBtn";
            this.validationBtn.Size = new System.Drawing.Size(46, 37);
            this.validationBtn.TabIndex = 5;
            this.validationBtn.Text = "OK";
            this.validationBtn.UseVisualStyleBackColor = false;
            // 
            // Mediatek86Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(413, 450);
            this.Controls.Add(this.validationBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mdpLbl);
            this.Controls.Add(this.loginLbl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.loginTxtBox);
            this.Name = "Mediatek86Frm";
            this.Text = "Mediatek86 - Gestion des absences";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTxtBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label loginLbl;
        private System.Windows.Forms.Label mdpLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button validationBtn;
    }
}

