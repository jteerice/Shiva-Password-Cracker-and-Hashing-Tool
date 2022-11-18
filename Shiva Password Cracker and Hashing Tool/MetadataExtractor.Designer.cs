namespace Shiva_Password_Cracker_and_Hashing_Tool
{
    partial class Metadata_Extractor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Metadata_Extractor));
            this.pathText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.Label();
            this.btnExtract = new System.Windows.Forms.Button();
            this.resultsText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // pathText
            // 
            this.pathText.Location = new System.Drawing.Point(11, 27);
            this.pathText.Name = "pathText";
            this.pathText.Size = new System.Drawing.Size(177, 20);
            this.pathText.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(194, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select an image:";
            // 
            // results
            // 
            this.results.AutoSize = true;
            this.results.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(109, 100);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(57, 18);
            this.results.TabIndex = 3;
            this.results.Text = "Results:";
            // 
            // btnExtract
            // 
            this.btnExtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtract.Location = new System.Drawing.Point(11, 54);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(253, 31);
            this.btnExtract.TabIndex = 4;
            this.btnExtract.Text = "Extract!";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // resultsText
            // 
            this.resultsText.Location = new System.Drawing.Point(11, 126);
            this.resultsText.Name = "resultsText";
            this.resultsText.Size = new System.Drawing.Size(253, 352);
            this.resultsText.TabIndex = 5;
            this.resultsText.Text = "";
            // 
            // Metadata_Extractor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 500);
            this.Controls.Add(this.resultsText);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.results);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pathText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Metadata_Extractor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metadata Extractor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Metadata_Extractor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label results;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.RichTextBox resultsText;
    }
}