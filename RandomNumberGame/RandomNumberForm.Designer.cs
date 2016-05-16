namespace RandomNumberGame
{
    partial class RandomNumberForm
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
            this.lblGuessNumber = new System.Windows.Forms.Label();
            this.txtUserInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNewNumber = new System.Windows.Forms.Button();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblNumGuesses = new System.Windows.Forms.Label();
            this.lblNumGuessesResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGuessNumber
            // 
            this.lblGuessNumber.AutoSize = true;
            this.lblGuessNumber.Location = new System.Drawing.Point(43, 18);
            this.lblGuessNumber.Name = "lblGuessNumber";
            this.lblGuessNumber.Size = new System.Drawing.Size(182, 13);
            this.lblGuessNumber.TabIndex = 0;
            this.lblGuessNumber.Text = "Guess a number between 1 and 100.";
            // 
            // txtUserInput
            // 
            this.txtUserInput.Location = new System.Drawing.Point(46, 35);
            this.txtUserInput.Name = "txtUserInput";
            this.txtUserInput.Size = new System.Drawing.Size(179, 20);
            this.txtUserInput.TabIndex = 1;
            this.txtUserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserInput_KeyPress);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(95, 72);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNewNumber
            // 
            this.btnNewNumber.Location = new System.Drawing.Point(75, 101);
            this.btnNewNumber.Name = "btnNewNumber";
            this.btnNewNumber.Size = new System.Drawing.Size(121, 23);
            this.btnNewNumber.TabIndex = 3;
            this.btnNewNumber.Text = "New Number";
            this.btnNewNumber.UseVisualStyleBackColor = true;
            this.btnNewNumber.Click += new System.EventHandler(this.btnNewNumber_Click);
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Location = new System.Drawing.Point(95, 130);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(75, 23);
            this.btnGiveUp.TabIndex = 4;
            this.btnGiveUp.Text = "Give Up!";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblResult.Location = new System.Drawing.Point(0, 189);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(264, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumGuesses
            // 
            this.lblNumGuesses.AutoSize = true;
            this.lblNumGuesses.Location = new System.Drawing.Point(82, 156);
            this.lblNumGuesses.Name = "lblNumGuesses";
            this.lblNumGuesses.Size = new System.Drawing.Size(0, 13);
            this.lblNumGuesses.TabIndex = 6;
            // 
            // lblNumGuessesResult
            // 
            this.lblNumGuessesResult.AutoSize = true;
            this.lblNumGuessesResult.Location = new System.Drawing.Point(126, 169);
            this.lblNumGuessesResult.Name = "lblNumGuessesResult";
            this.lblNumGuessesResult.Size = new System.Drawing.Size(0, 13);
            this.lblNumGuessesResult.TabIndex = 7;
            // 
            // RandomNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 202);
            this.Controls.Add(this.lblNumGuessesResult);
            this.Controls.Add(this.lblNumGuesses);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGiveUp);
            this.Controls.Add(this.btnNewNumber);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtUserInput);
            this.Controls.Add(this.lblGuessNumber);
            this.Name = "RandomNumberForm";
            this.Text = "Random Number Game v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGuessNumber;
        private System.Windows.Forms.TextBox txtUserInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNewNumber;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblNumGuesses;
        private System.Windows.Forms.Label lblNumGuessesResult;
    }
}

