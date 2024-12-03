using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai4
{
    public partial class form2 : Form
    {
        public String Id { get; set; }
        public String Name { get; set; }
        public int Pay { get; set; }
        public form2()
        {
            InitializeComponent();
        }

        private void btnAgree_Click(object sender, EventArgs e)
        {
          form1 f1 = new form1();
            Id=txtId.Text;
            Name=txtName.Text;  
            Pay=Convert.ToInt32(txtPay.Text);
          this.Close();
        }
        
        private void btnDeny_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
