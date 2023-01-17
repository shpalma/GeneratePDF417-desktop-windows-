using System;
using System.Windows.Forms;
using ZXing;

namespace GeneratePDF417
{
   public partial class frm01 : Form
   {

      public bool isSubmitedbyUser = false;

      public frm01()
      {
         InitializeComponent();
      }

      private void frm01_Load(object sender, EventArgs e)
      {
         // set up custom format for date timepicker controller
         dtpSTR.Format = DateTimePickerFormat.Custom;
         dtpSTR.CustomFormat = "dd/MM/yyyy hh:mm:ss";
         dtpSTR.Value = DateTime.Now.Date;
      }

      private void dtpSTR_ValueChanged(object sender, EventArgs e)
      {
         DateTime dTime;
         dTime = dtpSTR.Value;
         //MessageBox.Show("Current date is " + dTime.ToString("dd/MM/yyyy hh:mm:ss"));

      }

      private void btnGenePDF417_Click(object sender, EventArgs e)
      {
         Byte[] byteArray;
         var width = 250;
         var height = 250;
         var margin = 0;
         
      }
   }
}
