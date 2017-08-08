namespace _3000_cvs_SanityCheck
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
            this.btnChooseInput = new System.Windows.Forms.Button();
            this.textInputFile = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.checkRestart = new System.Windows.Forms.CheckBox();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textCharacterNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnChooseInput
            // 
            this.btnChooseInput.Location = new System.Drawing.Point(12, 12);
            this.btnChooseInput.Name = "btnChooseInput";
            this.btnChooseInput.Size = new System.Drawing.Size(100, 30);
            this.btnChooseInput.TabIndex = 0;
            this.btnChooseInput.Text = "Choose Input";
            this.btnChooseInput.UseVisualStyleBackColor = true;
            this.btnChooseInput.Click += new System.EventHandler(this.btnChooseInput_Click);
            // 
            // textInputFile
            // 
            this.textInputFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInputFile.Location = new System.Drawing.Point(118, 14);
            this.textInputFile.Name = "textInputFile";
            this.textInputFile.Size = new System.Drawing.Size(450, 24);
            this.textInputFile.TabIndex = 1;
            this.textInputFile.Text = "C:\\Users\\darkd\\Downloads\\Chinese Pod\\ACER0\\_3000_.csv";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 152);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 30);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(12, 48);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(100, 30);
            this.buttonProcess.TabIndex = 3;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // checkRestart
            // 
            this.checkRestart.AutoSize = true;
            this.checkRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRestart.Location = new System.Drawing.Point(152, 52);
            this.checkRestart.Name = "checkRestart";
            this.checkRestart.Size = new System.Drawing.Size(75, 22);
            this.checkRestart.TabIndex = 4;
            this.checkRestart.Text = "Restart";
            this.checkRestart.UseVisualStyleBackColor = true;
            // 
            // textStatus
            // 
            this.textStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatus.Location = new System.Drawing.Point(102, 99);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(466, 24);
            this.textStatus.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status Msg:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(251, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Restart at Character #:";
            // 
            // textCharacterNo
            // 
            this.textCharacterNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCharacterNo.Location = new System.Drawing.Point(414, 50);
            this.textCharacterNo.Name = "textCharacterNo";
            this.textCharacterNo.Size = new System.Drawing.Size(154, 24);
            this.textCharacterNo.TabIndex = 8;
            this.textCharacterNo.Text = "0001";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 199);
            this.Controls.Add(this.textCharacterNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.checkRestart);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.textInputFile);
            this.Controls.Add(this.btnChooseInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseInput;
        private System.Windows.Forms.TextBox textInputFile;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.CheckBox checkRestart;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textCharacterNo;
    }
}

