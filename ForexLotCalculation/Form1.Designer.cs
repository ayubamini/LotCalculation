namespace ForexLotCalculation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtRiskManagementInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProfitPerPip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStoplossPerPip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtInvestments = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMinProfit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaxLoss = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.txtQuantity_CFD = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtMinProfit_CFD = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtMaxLoss_CFD = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRiskManagementInfo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnCalculator);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtProfitPerPip);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtStoplossPerPip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtInfo);
            this.groupBox1.Controls.Add(this.txtInvestments);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox1.Size = new System.Drawing.Size(1448, 394);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // txtRiskManagementInfo
            // 
            this.txtRiskManagementInfo.BackColor = System.Drawing.SystemColors.Window;
            this.txtRiskManagementInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRiskManagementInfo.ForeColor = System.Drawing.Color.Salmon;
            this.txtRiskManagementInfo.Location = new System.Drawing.Point(42, 226);
            this.txtRiskManagementInfo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtRiskManagementInfo.Multiline = true;
            this.txtRiskManagementInfo.Name = "txtRiskManagementInfo";
            this.txtRiskManagementInfo.ReadOnly = true;
            this.txtRiskManagementInfo.Size = new System.Drawing.Size(895, 123);
            this.txtRiskManagementInfo.TabIndex = 27;
            this.txtRiskManagementInfo.Text = "This is a sample message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 32);
            this.label5.TabIndex = 25;
            this.label5.Text = "Profit:";
            // 
            // btnCancel
            // 
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(1019, 291);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(379, 57);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculator.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCalculator.Location = new System.Drawing.Point(1019, 226);
            this.btnCalculator.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(379, 57);
            this.btnCalculator.TabIndex = 17;
            this.btnCalculator.Text = "Calculated";
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(924, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "Pips";
            // 
            // txtProfitPerPip
            // 
            this.txtProfitPerPip.Location = new System.Drawing.Point(742, 150);
            this.txtProfitPerPip.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtProfitPerPip.Name = "txtProfitPerPip";
            this.txtProfitPerPip.Size = new System.Drawing.Size(166, 38);
            this.txtProfitPerPip.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Stop loss:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(477, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "Pips";
            // 
            // txtStoplossPerPip
            // 
            this.txtStoplossPerPip.Location = new System.Drawing.Point(302, 150);
            this.txtStoplossPerPip.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtStoplossPerPip.Name = "txtStoplossPerPip";
            this.txtStoplossPerPip.Size = new System.Drawing.Size(166, 38);
            this.txtStoplossPerPip.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Investment Value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 85);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "$";
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.SystemColors.Info;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtInfo.ForeColor = System.Drawing.Color.Gray;
            this.txtInfo.Location = new System.Drawing.Point(624, 84);
            this.txtInfo.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(773, 38);
            this.txtInfo.TabIndex = 17;
            this.txtInfo.Text = "This is a sample message";
            this.txtInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtInvestments
            // 
            this.txtInvestments.Location = new System.Drawing.Point(302, 82);
            this.txtInvestments.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtInvestments.Name = "txtInvestments";
            this.txtInvestments.Size = new System.Drawing.Size(166, 38);
            this.txtInvestments.TabIndex = 16;
            this.txtInvestments.Text = "1000";
            this.txtInvestments.TextChanged += new System.EventHandler(this.txtInvestments_TextChanged);
            this.txtInvestments.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInvestments_KeyPress);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(5, 399);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox2.Size = new System.Drawing.Size(741, 326);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Spread Betting";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtMinProfit);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtMaxLoss);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel1.Location = new System.Drawing.Point(30, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 231);
            this.panel1.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(523, 155);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 32);
            this.label12.TabIndex = 23;
            this.label12.Text = "$ / PIP";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(242, 152);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(270, 38);
            this.txtQuantity.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(523, 91);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 32);
            this.label11.TabIndex = 21;
            this.label11.Text = "$";
            // 
            // txtMinProfit
            // 
            this.txtMinProfit.Location = new System.Drawing.Point(242, 88);
            this.txtMinProfit.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtMinProfit.Name = "txtMinProfit";
            this.txtMinProfit.Size = new System.Drawing.Size(270, 38);
            this.txtMinProfit.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(523, 26);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "$";
            // 
            // txtMaxLoss
            // 
            this.txtMaxLoss.Location = new System.Drawing.Point(245, 23);
            this.txtMaxLoss.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtMaxLoss.Name = "txtMaxLoss";
            this.txtMaxLoss.Size = new System.Drawing.Size(270, 38);
            this.txtMaxLoss.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 32);
            this.label9.TabIndex = 2;
            this.label9.Text = "Maximum loss:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 91);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "Minimum profit:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 155);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(206, 32);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quantity (size):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(746, 399);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.groupBox3.Size = new System.Drawing.Size(707, 326);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CFD";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.txtQuantity_CFD);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txtMinProfit_CFD);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtMaxLoss_CFD);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panel2.Location = new System.Drawing.Point(38, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(635, 231);
            this.panel2.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(523, 155);
            this.label17.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 32);
            this.label17.TabIndex = 23;
            this.label17.Text = "Lots";
            // 
            // txtQuantity_CFD
            // 
            this.txtQuantity_CFD.Location = new System.Drawing.Point(242, 152);
            this.txtQuantity_CFD.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtQuantity_CFD.Name = "txtQuantity_CFD";
            this.txtQuantity_CFD.Size = new System.Drawing.Size(270, 38);
            this.txtQuantity_CFD.TabIndex = 22;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(523, 91);
            this.label18.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 32);
            this.label18.TabIndex = 21;
            this.label18.Text = "$";
            // 
            // txtMinProfit_CFD
            // 
            this.txtMinProfit_CFD.Location = new System.Drawing.Point(242, 88);
            this.txtMinProfit_CFD.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtMinProfit_CFD.Name = "txtMinProfit_CFD";
            this.txtMinProfit_CFD.Size = new System.Drawing.Size(270, 38);
            this.txtMinProfit_CFD.TabIndex = 20;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(523, 26);
            this.label19.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 32);
            this.label19.TabIndex = 19;
            this.label19.Text = "$";
            // 
            // txtMaxLoss_CFD
            // 
            this.txtMaxLoss_CFD.Location = new System.Drawing.Point(245, 23);
            this.txtMaxLoss_CFD.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.txtMaxLoss_CFD.Name = "txtMaxLoss_CFD";
            this.txtMaxLoss_CFD.Size = new System.Drawing.Size(270, 38);
            this.txtMaxLoss_CFD.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 26);
            this.label20.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(203, 32);
            this.label20.TabIndex = 2;
            this.label20.Text = "Maximum loss:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 91);
            this.label21.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(209, 32);
            this.label21.TabIndex = 1;
            this.label21.Text = "Minimum profit:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(21, 155);
            this.label22.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(206, 32);
            this.label22.TabIndex = 0;
            this.label22.Text = "Quantity (size):";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculator;
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1458, 730);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forex Lots Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtInvestments;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStoplossPerPip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProfitPerPip;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRiskManagementInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMinProfit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaxLoss;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtQuantity_CFD;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtMinProfit_CFD;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtMaxLoss_CFD;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}

