
namespace OrtalamaBul
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
            this.txtone = new System.Windows.Forms.TextBox();
            this.lbl_birinci = new System.Windows.Forms.Label();
            this.lbl_ikinci = new System.Windows.Forms.Label();
            this.btn_one = new System.Windows.Forms.Button();
            this.textwo = new System.Windows.Forms.TextBox();
            this.lbl_three = new System.Windows.Forms.Label();
            this.texthree = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtone
            // 
            this.txtone.Location = new System.Drawing.Point(179, 41);
            this.txtone.Name = "txtone";
            this.txtone.Size = new System.Drawing.Size(100, 20);
            this.txtone.TabIndex = 0;          
            // 
            // lbl_birinci
            // 
            this.lbl_birinci.AutoSize = true;
            this.lbl_birinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_birinci.Location = new System.Drawing.Point(67, 42);
            this.lbl_birinci.Name = "lbl_birinci";
            this.lbl_birinci.Size = new System.Drawing.Size(91, 15);
            this.lbl_birinci.TabIndex = 1;
            this.lbl_birinci.Text = "1. sayıyı giriniz :";
            // 
            // lbl_ikinci
            // 
            this.lbl_ikinci.AutoSize = true;
            this.lbl_ikinci.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ikinci.Location = new System.Drawing.Point(67, 74);
            this.lbl_ikinci.Name = "lbl_ikinci";
            this.lbl_ikinci.Size = new System.Drawing.Size(91, 15);
            this.lbl_ikinci.TabIndex = 1;
            this.lbl_ikinci.Text = "2. sayıyı giriniz :";
            // 
            // btn_one
            // 
            this.btn_one.Location = new System.Drawing.Point(70, 117);
            this.btn_one.Name = "btn_one";
            this.btn_one.Size = new System.Drawing.Size(209, 23);
            this.btn_one.TabIndex = 2;
            this.btn_one.Text = "ortamala hesapla";
            this.btn_one.UseVisualStyleBackColor = true;
            this.btn_one.Click += new System.EventHandler(this.btn_one_Click);
            // 
            // textwo
            // 
            this.textwo.Location = new System.Drawing.Point(179, 74);
            this.textwo.Name = "textwo";
            this.textwo.Size = new System.Drawing.Size(100, 20);
            this.textwo.TabIndex = 0;
            // 
            // lbl_three
            // 
            this.lbl_three.AutoSize = true;
            this.lbl_three.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_three.Location = new System.Drawing.Point(67, 156);
            this.lbl_three.Name = "lbl_three";
            this.lbl_three.Size = new System.Drawing.Size(75, 15);
            this.lbl_three.TabIndex = 1;
            this.lbl_three.Text = "ortalamanız:";
            // 
            // texthree
            // 
            this.texthree.Location = new System.Drawing.Point(148, 156);
            this.texthree.Name = "texthree";
            this.texthree.Size = new System.Drawing.Size(100, 20);
            this.texthree.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 212);
            this.Controls.Add(this.btn_one);
            this.Controls.Add(this.lbl_three);
            this.Controls.Add(this.lbl_ikinci);
            this.Controls.Add(this.lbl_birinci);
            this.Controls.Add(this.texthree);
            this.Controls.Add(this.textwo);
            this.Controls.Add(this.txtone);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtone;
        private System.Windows.Forms.Label lbl_birinci;
        private System.Windows.Forms.Label lbl_ikinci;
        private System.Windows.Forms.Button btn_one;
        private System.Windows.Forms.TextBox textwo;
        private System.Windows.Forms.Label lbl_three;
        private System.Windows.Forms.TextBox texthree;
    }
}

