namespace Challenge4
{
    partial class ChallengeMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.inputValue = new System.Windows.Forms.TextBox();
            this.outputValue = new System.Windows.Forms.TextBox();
            this.HenkanButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputValue
            // 
            this.inputValue.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.inputValue.Location = new System.Drawing.Point(89, 59);
            this.inputValue.Name = "inputValue";
            this.inputValue.Size = new System.Drawing.Size(100, 19);
            this.inputValue.TabIndex = 0;
            // 
            // outputValue
            // 
            this.outputValue.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.outputValue.Location = new System.Drawing.Point(89, 127);
            this.outputValue.Name = "outputValue";
            this.outputValue.ReadOnly = true;
            this.outputValue.Size = new System.Drawing.Size(100, 19);
            this.outputValue.TabIndex = 1;
            // 
            // HenkanButton
            // 
            this.HenkanButton.Location = new System.Drawing.Point(102, 196);
            this.HenkanButton.Name = "HenkanButton";
            this.HenkanButton.Size = new System.Drawing.Size(75, 23);
            this.HenkanButton.TabIndex = 2;
            this.HenkanButton.Text = "変換";
            this.HenkanButton.UseVisualStyleBackColor = true;
            this.HenkanButton.Click += new System.EventHandler(this.HenkanButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "変換前";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "変換後";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HenkanButton);
            this.Controls.Add(this.outputValue);
            this.Controls.Add(this.inputValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputValue;
        private System.Windows.Forms.TextBox outputValue;
        private System.Windows.Forms.Button HenkanButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

