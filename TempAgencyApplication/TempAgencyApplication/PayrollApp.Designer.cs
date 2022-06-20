namespace TempAgencyApplication
{
    partial class PayrollApp
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
            System.Windows.Forms.Label label1;
            this.label2 = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblDependents = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtDependents = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblFed = new System.Windows.Forms.Label();
            this.lblSoc = new System.Windows.Forms.Label();
            this.lblAgency = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtFed = new System.Windows.Forms.TextBox();
            this.txtSocial = new System.Windows.Forms.TextBox();
            this.txtAgency = new System.Windows.Forms.TextBox();
            this.txtNet = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(125, 19);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "XYZ JobSource";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name : ";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(37, 109);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(165, 20);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "No of Hours Worked : ";
            // 
            // lblDependents
            // 
            this.lblDependents.AutoSize = true;
            this.lblDependents.Location = new System.Drawing.Point(37, 151);
            this.lblDependents.Name = "lblDependents";
            this.lblDependents.Size = new System.Drawing.Size(151, 20);
            this.lblDependents.TabIndex = 3;
            this.lblDependents.Text = "No of Dependants : ";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(106, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(241, 26);
            this.txtName.TabIndex = 4;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(208, 106);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(139, 26);
            this.txtHours.TabIndex = 5;
            // 
            // txtDependents
            // 
            this.txtDependents.Location = new System.Drawing.Point(208, 148);
            this.txtDependents.Name = "txtDependents";
            this.txtDependents.Size = new System.Drawing.Size(139, 26);
            this.txtDependents.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(41, 199);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(208, 32);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calculate Take Home Pay";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(255, 199);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 32);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblGross
            // 
            this.lblGross.AutoSize = true;
            this.lblGross.Location = new System.Drawing.Point(37, 283);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(90, 20);
            this.lblGross.TabIndex = 9;
            this.lblGross.Text = "Gross Pay :";
            this.lblGross.Visible = false;
            // 
            // lblFed
            // 
            this.lblFed.AutoSize = true;
            this.lblFed.Location = new System.Drawing.Point(37, 328);
            this.lblFed.Name = "lblFed";
            this.lblFed.Size = new System.Drawing.Size(105, 20);
            this.lblFed.TabIndex = 10;
            this.lblFed.Text = "Fedaral Ded :";
            this.lblFed.Visible = false;
            // 
            // lblSoc
            // 
            this.lblSoc.AutoSize = true;
            this.lblSoc.Location = new System.Drawing.Point(37, 373);
            this.lblSoc.Name = "lblSoc";
            this.lblSoc.Size = new System.Drawing.Size(111, 20);
            this.lblSoc.TabIndex = 11;
            this.lblSoc.Text = "Soc Sec Ded :";
            this.lblSoc.Visible = false;
            // 
            // lblAgency
            // 
            this.lblAgency.AutoSize = true;
            this.lblAgency.Location = new System.Drawing.Point(37, 418);
            this.lblAgency.Name = "lblAgency";
            this.lblAgency.Size = new System.Drawing.Size(102, 20);
            this.lblAgency.TabIndex = 12;
            this.lblAgency.Text = "Agency Fee :";
            this.lblAgency.Visible = false;
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Location = new System.Drawing.Point(37, 463);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(72, 20);
            this.lblNet.TabIndex = 13;
            this.lblNet.Text = "Net Pay :";
            this.lblNet.Visible = false;
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(208, 280);
            this.txtGross.Name = "txtGross";
            this.txtGross.ReadOnly = true;
            this.txtGross.Size = new System.Drawing.Size(139, 26);
            this.txtGross.TabIndex = 14;
            this.txtGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGross.Visible = false;
            // 
            // txtFed
            // 
            this.txtFed.Location = new System.Drawing.Point(208, 325);
            this.txtFed.Name = "txtFed";
            this.txtFed.ReadOnly = true;
            this.txtFed.Size = new System.Drawing.Size(139, 26);
            this.txtFed.TabIndex = 15;
            this.txtFed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFed.Visible = false;
            // 
            // txtSocial
            // 
            this.txtSocial.Location = new System.Drawing.Point(208, 370);
            this.txtSocial.Name = "txtSocial";
            this.txtSocial.ReadOnly = true;
            this.txtSocial.Size = new System.Drawing.Size(139, 26);
            this.txtSocial.TabIndex = 16;
            this.txtSocial.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSocial.Visible = false;
            // 
            // txtAgency
            // 
            this.txtAgency.Location = new System.Drawing.Point(208, 415);
            this.txtAgency.Name = "txtAgency";
            this.txtAgency.ReadOnly = true;
            this.txtAgency.Size = new System.Drawing.Size(139, 26);
            this.txtAgency.TabIndex = 17;
            this.txtAgency.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAgency.Visible = false;
            // 
            // txtNet
            // 
            this.txtNet.Location = new System.Drawing.Point(208, 460);
            this.txtNet.Name = "txtNet";
            this.txtNet.ReadOnly = true;
            this.txtNet.Size = new System.Drawing.Size(139, 26);
            this.txtNet.TabIndex = 18;
            this.txtNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtNet.Visible = false;
            // 
            // PayrollApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.txtNet);
            this.Controls.Add(this.txtAgency);
            this.Controls.Add(this.txtSocial);
            this.Controls.Add(this.txtFed);
            this.Controls.Add(this.txtGross);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblAgency);
            this.Controls.Add(this.lblSoc);
            this.Controls.Add(this.lblFed);
            this.Controls.Add(this.lblGross);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtDependents);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblDependents);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.label2);
            this.Controls.Add(label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PayrollApp";
            this.Text = "PayrollApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDependents;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtDependents;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblFed;
        private System.Windows.Forms.Label lblSoc;
        private System.Windows.Forms.Label lblAgency;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.TextBox txtFed;
        private System.Windows.Forms.TextBox txtSocial;
        private System.Windows.Forms.TextBox txtAgency;
        private System.Windows.Forms.TextBox txtNet;
    }
}

