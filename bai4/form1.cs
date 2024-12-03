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
    public partial class form1 : Form
    {
       
        public form1()
        {
            InitializeComponent();
        }
 
        List<employee> employeeinfo= new List<employee>();
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
           form2 f2 = new form2();
          f2.ShowDialog();
           if (f2.Name == "form2" && f2.Pay == 0) { return; }
            employeeinfo.Add(new employee() {employeeId=f2.Id,employeeName=f2.Name,employeePay=f2.Pay });
            dgvNhanvien.DataSource = null;
            dgvNhanvien.DataSource = employeeinfo;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {   
            form2 f2 = new form2();
            f2.ShowDialog();
            int index=dgvNhanvien.CurrentCell.RowIndex;
            employeeinfo[index] = new employee() { employeeId = f2.Id, employeeName = f2.Name, employeePay = f2.Pay };
            dgvNhanvien.DataSource = null;
            dgvNhanvien.DataSource = employeeinfo;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int index = dgvNhanvien.CurrentCell.RowIndex;
            employeeinfo.RemoveAt(index);
            dgvNhanvien.DataSource = null;
            dgvNhanvien.DataSource = employeeinfo;
        }
    }
}
