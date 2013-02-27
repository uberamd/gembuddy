/* Copyright 2013 uberamd
 * This file is part of GemBuddy.
 * 
 * GemBuddy is free software: you can redistribute it and/or 
 * modify it under the terms of the GNU General Public License 
 * as published by the Free Software Foundation, either version 3 
 * of the License, or (at your option) any later version.
 * 
 * GemBuddy is distributed in the hope that it will be useful, 
 * but WITHOUT ANY WARRANTY; without even the implied warranty 
 * of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See 
 * the GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License 
 * along with GemBuddy. If not, see http://www.gnu.org/licenses/.
*/
namespace GemBuddy
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
            this.components = new System.ComponentModel.Container();
            this.gemTimer = new System.Windows.Forms.Timer(this.components);
            this.txtGemCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.lblCraftBtn = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl3Set = new System.Windows.Forms.Label();
            this.lbl2Set = new System.Windows.Forms.Label();
            this.lbl1Set = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gemTimer
            // 
            this.gemTimer.Interval = 3000;
            this.gemTimer.Tick += new System.EventHandler(this.gemTimer_Tick);
            // 
            // txtGemCount
            // 
            this.txtGemCount.Location = new System.Drawing.Point(174, 6);
            this.txtGemCount.Name = "txtGemCount";
            this.txtGemCount.Size = new System.Drawing.Size(71, 20);
            this.txtGemCount.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Number of Tier 1 Gems to Craft";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(251, 4);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(61, 23);
            this.btnSet.TabIndex = 9;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnSet_KeyPress);
            // 
            // lblCraftBtn
            // 
            this.lblCraftBtn.AutoSize = true;
            this.lblCraftBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCraftBtn.Location = new System.Drawing.Point(252, 126);
            this.lblCraftBtn.Name = "lblCraftBtn";
            this.lblCraftBtn.Size = new System.Drawing.Size(61, 13);
            this.lblCraftBtn.TabIndex = 20;
            this.lblCraftBtn.Text = "NOT SET";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Move mouse craft button and press 4";
            // 
            // lbl3Set
            // 
            this.lbl3Set.AutoSize = true;
            this.lbl3Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3Set.Location = new System.Drawing.Point(251, 100);
            this.lbl3Set.Name = "lbl3Set";
            this.lbl3Set.Size = new System.Drawing.Size(61, 13);
            this.lbl3Set.TabIndex = 18;
            this.lbl3Set.Text = "NOT SET";
            // 
            // lbl2Set
            // 
            this.lbl2Set.AutoSize = true;
            this.lbl2Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2Set.Location = new System.Drawing.Point(251, 72);
            this.lbl2Set.Name = "lbl2Set";
            this.lbl2Set.Size = new System.Drawing.Size(61, 13);
            this.lbl2Set.TabIndex = 17;
            this.lbl2Set.Text = "NOT SET";
            // 
            // lbl1Set
            // 
            this.lbl1Set.AutoSize = true;
            this.lbl1Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1Set.Location = new System.Drawing.Point(252, 43);
            this.lbl1Set.Name = "lbl1Set";
            this.lbl1Set.Size = new System.Drawing.Size(61, 13);
            this.lbl1Set.TabIndex = 16;
            this.lbl1Set.Text = "NOT SET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(235, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Select window and press 9 to start/stop program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Move mouse over starting gem type and press 3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Move mouse over starting gem type and press 2";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(12, 44);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(233, 13);
            this.lblTemp.TabIndex = 12;
            this.lblTemp.Text = "Move mouse over starting gem type and press 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 178);
            this.Controls.Add(this.lblCraftBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl3Set);
            this.Controls.Add(this.lbl2Set);
            this.Controls.Add(this.lbl1Set);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGemCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GemBuddy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gemTimer;
        private System.Windows.Forms.TextBox txtGemCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lblCraftBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl3Set;
        private System.Windows.Forms.Label lbl2Set;
        private System.Windows.Forms.Label lbl1Set;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTemp;
    }
}

