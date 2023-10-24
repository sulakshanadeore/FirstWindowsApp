using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;
namespace FirstWindowsApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            EMS emp =new EMS();
            Emp userdata = new Emp();
            userdata.Userid=txt_user_name.Text;
            userdata.Password=txt_pwd.Text;

            bool ans=emp.ValidateUser(userdata.Userid, userdata.Password);  
            if (ans)
            {
                MessageBox.Show("Welcome " + userdata.Userid);
            }
            else
            {
                MessageBox.Show("The userid and password is not not correct...");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("R u sure to stop the application");
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_MouseMove(object sender, MouseEventArgs e)
        {
            //moving the mouse will change the color
            btnLogin.BackColor = Color.DeepSkyBlue;
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            //clicked it will become red
            btnLogin.BackColor = Color.Red;
        }

        private void btnLogin_Leave(object sender, EventArgs e)
        {
            //when some control is active, then this is yellow
            btnLogin.BackColor = Color.Yellow;
        }

       
    }
}
