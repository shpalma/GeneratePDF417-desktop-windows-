
namespace GeneratePDF417
{
   partial class frm01
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
         this.gbHeader = new System.Windows.Forms.GroupBox();
         this.lblSTR = new System.Windows.Forms.Label();
         this.cmbSTR = new System.Windows.Forms.ComboBox();
         this.btnManSTR = new System.Windows.Forms.Button();
         this.label2 = new System.Windows.Forms.Label();
         this.txtbFolio = new System.Windows.Forms.TextBox();
         this.lblAmount = new System.Windows.Forms.Label();
         this.textBox1 = new System.Windows.Forms.TextBox();
         this.lblDate = new System.Windows.Forms.Label();
         this.dtpSTR = new System.Windows.Forms.DateTimePicker();
         this.chkbAutoIncrease = new System.Windows.Forms.CheckBox();
         this.btnManAutInc = new System.Windows.Forms.Button();
         this.btnGenePDF417 = new System.Windows.Forms.Button();
         this.gbPdf417 = new System.Windows.Forms.GroupBox();
         this.lnklblAutoRef = new System.Windows.Forms.LinkLabel();
         this.gbHeader.SuspendLayout();
         this.SuspendLayout();
         // 
         // gbHeader
         // 
         this.gbHeader.Controls.Add(this.lnklblAutoRef);
         this.gbHeader.Controls.Add(this.btnGenePDF417);
         this.gbHeader.Controls.Add(this.btnManAutInc);
         this.gbHeader.Controls.Add(this.chkbAutoIncrease);
         this.gbHeader.Controls.Add(this.dtpSTR);
         this.gbHeader.Controls.Add(this.lblDate);
         this.gbHeader.Controls.Add(this.textBox1);
         this.gbHeader.Controls.Add(this.lblAmount);
         this.gbHeader.Controls.Add(this.txtbFolio);
         this.gbHeader.Controls.Add(this.label2);
         this.gbHeader.Controls.Add(this.btnManSTR);
         this.gbHeader.Controls.Add(this.cmbSTR);
         this.gbHeader.Controls.Add(this.lblSTR);
         this.gbHeader.Location = new System.Drawing.Point(13, 13);
         this.gbHeader.Name = "gbHeader";
         this.gbHeader.Size = new System.Drawing.Size(487, 145);
         this.gbHeader.TabIndex = 0;
         this.gbHeader.TabStop = false;
         this.gbHeader.Text = "Data header";
         // 
         // lblSTR
         // 
         this.lblSTR.AutoSize = true;
         this.lblSTR.Location = new System.Drawing.Point(6, 17);
         this.lblSTR.Name = "lblSTR";
         this.lblSTR.Size = new System.Drawing.Size(145, 13);
         this.lblSTR.TabIndex = 0;
         this.lblSTR.Text = "Single tax roll (RUT / <RE>): ";
         // 
         // cmbSTR
         // 
         this.cmbSTR.FormattingEnabled = true;
         this.cmbSTR.Location = new System.Drawing.Point(158, 17);
         this.cmbSTR.Name = "cmbSTR";
         this.cmbSTR.Size = new System.Drawing.Size(241, 21);
         this.cmbSTR.TabIndex = 1;
         // 
         // btnManSTR
         // 
         this.btnManSTR.Enabled = false;
         this.btnManSTR.Location = new System.Drawing.Point(405, 17);
         this.btnManSTR.Name = "btnManSTR";
         this.btnManSTR.Size = new System.Drawing.Size(75, 23);
         this.btnManSTR.TabIndex = 2;
         this.btnManSTR.Text = "Manage";
         this.btnManSTR.UseVisualStyleBackColor = true;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(7, 43);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(56, 13);
         this.label2.TabIndex = 3;
         this.label2.Text = "Folio (<F>)";
         // 
         // txtbFolio
         // 
         this.txtbFolio.Location = new System.Drawing.Point(158, 43);
         this.txtbFolio.Name = "txtbFolio";
         this.txtbFolio.Size = new System.Drawing.Size(125, 20);
         this.txtbFolio.TabIndex = 4;
         // 
         // lblAmount
         // 
         this.lblAmount.AutoSize = true;
         this.lblAmount.Location = new System.Drawing.Point(7, 69);
         this.lblAmount.Name = "lblAmount";
         this.lblAmount.Size = new System.Drawing.Size(129, 13);
         this.lblAmount.TabIndex = 5;
         this.lblAmount.Text = "Amount (Monto / <MNT>)";
         // 
         // textBox1
         // 
         this.textBox1.Location = new System.Drawing.Point(158, 69);
         this.textBox1.Name = "textBox1";
         this.textBox1.Size = new System.Drawing.Size(125, 20);
         this.textBox1.TabIndex = 6;
         // 
         // lblDate
         // 
         this.lblDate.AutoSize = true;
         this.lblDate.Location = new System.Drawing.Point(7, 91);
         this.lblDate.Name = "lblDate";
         this.lblDate.Size = new System.Drawing.Size(30, 13);
         this.lblDate.TabIndex = 7;
         this.lblDate.Text = "Date";
         // 
         // dtpSTR
         // 
         this.dtpSTR.Location = new System.Drawing.Point(158, 96);
         this.dtpSTR.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
         this.dtpSTR.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
         this.dtpSTR.Name = "dtpSTR";
         this.dtpSTR.Size = new System.Drawing.Size(200, 20);
         this.dtpSTR.TabIndex = 8;
         this.dtpSTR.ValueChanged += new System.EventHandler(this.dtpSTR_ValueChanged);
         // 
         // chkbAutoIncrease
         // 
         this.chkbAutoIncrease.AutoSize = true;
         this.chkbAutoIncrease.Location = new System.Drawing.Point(289, 46);
         this.chkbAutoIncrease.Name = "chkbAutoIncrease";
         this.chkbAutoIncrease.Size = new System.Drawing.Size(91, 17);
         this.chkbAutoIncrease.TabIndex = 9;
         this.chkbAutoIncrease.Text = "Auto increase";
         this.chkbAutoIncrease.UseVisualStyleBackColor = true;
         // 
         // btnManAutInc
         // 
         this.btnManAutInc.Enabled = false;
         this.btnManAutInc.Location = new System.Drawing.Point(405, 43);
         this.btnManAutInc.Name = "btnManAutInc";
         this.btnManAutInc.Size = new System.Drawing.Size(75, 23);
         this.btnManAutInc.TabIndex = 10;
         this.btnManAutInc.Text = "Manage";
         this.btnManAutInc.UseVisualStyleBackColor = true;
         // 
         // btnGenePDF417
         // 
         this.btnGenePDF417.Location = new System.Drawing.Point(364, 97);
         this.btnGenePDF417.Name = "btnGenePDF417";
         this.btnGenePDF417.Size = new System.Drawing.Size(116, 23);
         this.btnGenePDF417.TabIndex = 11;
         this.btnGenePDF417.Text = "Generate PDF417";
         this.btnGenePDF417.UseVisualStyleBackColor = true;
         this.btnGenePDF417.Click += new System.EventHandler(this.btnGenePDF417_Click);
         // 
         // gbPdf417
         // 
         this.gbPdf417.Location = new System.Drawing.Point(13, 164);
         this.gbPdf417.Name = "gbPdf417";
         this.gbPdf417.Size = new System.Drawing.Size(487, 238);
         this.gbPdf417.TabIndex = 1;
         this.gbPdf417.TabStop = false;
         this.gbPdf417.Text = "PDF417";
         // 
         // lnklblAutoRef
         // 
         this.lnklblAutoRef.AutoSize = true;
         this.lnklblAutoRef.Location = new System.Drawing.Point(394, 123);
         this.lnklblAutoRef.Name = "lnklblAutoRef";
         this.lnklblAutoRef.Size = new System.Drawing.Size(86, 13);
         this.lnklblAutoRef.TabIndex = 12;
         this.lnklblAutoRef.TabStop = true;
         this.lnklblAutoRef.Text = "Refresh PDF417";
         // 
         // frm01
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(512, 413);
         this.Controls.Add(this.gbPdf417);
         this.Controls.Add(this.gbHeader);
         this.MaximizeBox = false;
         this.Name = "frm01";
         this.ShowIcon = false;
         this.Text = "Generate PDF417 (Windows desktop)";
         this.Load += new System.EventHandler(this.frm01_Load);
         this.gbHeader.ResumeLayout(false);
         this.gbHeader.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox gbHeader;
      private System.Windows.Forms.Button btnGenePDF417;
      private System.Windows.Forms.Button btnManAutInc;
      private System.Windows.Forms.CheckBox chkbAutoIncrease;
      private System.Windows.Forms.DateTimePicker dtpSTR;
      private System.Windows.Forms.Label lblDate;
      private System.Windows.Forms.TextBox textBox1;
      private System.Windows.Forms.Label lblAmount;
      private System.Windows.Forms.TextBox txtbFolio;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button btnManSTR;
      private System.Windows.Forms.ComboBox cmbSTR;
      private System.Windows.Forms.Label lblSTR;
      private System.Windows.Forms.LinkLabel lnklblAutoRef;
      private System.Windows.Forms.GroupBox gbPdf417;
   }
}

