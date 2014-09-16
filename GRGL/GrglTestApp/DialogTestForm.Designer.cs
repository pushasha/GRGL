namespace GrglTestApp
{
    partial class DialogTestForm
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
            this.DialogPanel = new System.Windows.Forms.Panel();
            this.ButtonContextual = new System.Windows.Forms.Button();
            this.ComboBoxChoice = new System.Windows.Forms.ComboBox();
            this.LabelNpcDialog = new System.Windows.Forms.Label();
            this.DialogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DialogPanel
            // 
            this.DialogPanel.AutoScroll = true;
            this.DialogPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DialogPanel.Controls.Add(this.ButtonContextual);
            this.DialogPanel.Controls.Add(this.ComboBoxChoice);
            this.DialogPanel.Controls.Add(this.LabelNpcDialog);
            this.DialogPanel.Location = new System.Drawing.Point(16, 15);
            this.DialogPanel.Name = "DialogPanel";
            this.DialogPanel.Size = new System.Drawing.Size(656, 412);
            this.DialogPanel.TabIndex = 0;
            // 
            // ButtonContextual
            // 
            this.ButtonContextual.Location = new System.Drawing.Point(64, 296);
            this.ButtonContextual.Name = "ButtonContextual";
            this.ButtonContextual.Size = new System.Drawing.Size(94, 32);
            this.ButtonContextual.TabIndex = 2;
            this.ButtonContextual.Text = "<Button Text>";
            this.ButtonContextual.UseVisualStyleBackColor = true;
            this.ButtonContextual.Click += new System.EventHandler(this.ButtonContextual_Click);
            // 
            // ComboBoxChoice
            // 
            this.ComboBoxChoice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxChoice.FormattingEnabled = true;
            this.ComboBoxChoice.Location = new System.Drawing.Point(64, 221);
            this.ComboBoxChoice.Name = "ComboBoxChoice";
            this.ComboBoxChoice.Size = new System.Drawing.Size(377, 21);
            this.ComboBoxChoice.TabIndex = 1;
            // 
            // LabelNpcDialog
            // 
            this.LabelNpcDialog.AutoSize = true;
            this.LabelNpcDialog.Location = new System.Drawing.Point(61, 37);
            this.LabelNpcDialog.Name = "LabelNpcDialog";
            this.LabelNpcDialog.Size = new System.Drawing.Size(74, 13);
            this.LabelNpcDialog.TabIndex = 0;
            this.LabelNpcDialog.Text = "<NPC Dialog>";
            // 
            // DialogTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 452);
            this.Controls.Add(this.DialogPanel);
            this.Name = "DialogTestForm";
            this.Text = "Dialog";
            this.Load += new System.EventHandler(this.DialogTestForm_Load);
            this.DialogPanel.ResumeLayout(false);
            this.DialogPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DialogPanel;
        private System.Windows.Forms.Label LabelNpcDialog;
        private System.Windows.Forms.ComboBox ComboBoxChoice;
        private System.Windows.Forms.Button ButtonContextual;

    }
}

