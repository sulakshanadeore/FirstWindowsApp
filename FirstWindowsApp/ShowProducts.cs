using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HRLibrary;
namespace FirstWindowsApp
{
    public partial class ShowProducts : Form
    {
        public ShowProducts()
        {
            InitializeComponent();
            
        }

        private void ShowProducts_Load(object sender, EventArgs e)
        {
            EmpManagement mgt=new EmpManagement();
            List<Employee> emplist = new List<Employee>();
            emplist=mgt.ShowEmployeeList();
            foreach (Employee emp in emplist)
            {
                listBox1.Items.Add(emp.Empid + "  " + emp.Ename  + " " +emp.Deptno + " "+ emp.Deptno);

            }
           
        }
    }
}
