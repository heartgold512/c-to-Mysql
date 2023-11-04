using System;
using System.Net.Security;
using System.Drawing;
using System.Windows.Forms;

namespace restarunttest2
{
    public class Loginform : Form1 //class to reference as using .:. declare public
    {

        private TextBox usernametextbox;
        private TextBox passwordtextbox;
        private Button loginbutton;
        //global stuff for global reasons

        public Loginform()
        {
            InitializeComponents();
            eventh();
        }

        private void InitializeComponents() //method defines properties of textboxes and stuff
        {


            this.Text = "Login";
            this.Size = new System.Drawing.Size(300, 150);

            usernametextbox = new TextBox
            {
                //can rid of after
                Location = new System.Drawing.Point(50, 20),
                Width = 200,
            };

            passwordtextbox = new TextBox
            {
                Location = new System.Drawing.Point(50, 50),
                Width = 200,
                PasswordChar = '*',
            };

            loginbutton = new Button
            {
                Text = "Login",
                Location = new System.Drawing.Point(100, 80),
            };


            this.Controls.Add(usernametextbox);
            this.Controls.Add(passwordtextbox);
            this.Controls.Add(loginbutton);
        }
        //method ends here?
        private int failedLoginAttempts = 0;

        private void eventh()
        {
            loginbutton.Click += loginbuttonvclick; //we can now define a method for logginbuttonvclick
        }
        private void loginbuttonvclick(object sender, EventArgs e) //eeeeeeeeeeeeeeeeeeee
        {
            string username = usernametextbox.Text; //this just autogened  i think itll work fine anyways
            string password = passwordtextbox.Text;
            //option to create f and else statments here
            // if condition is true do login
            //else print login fail or something
            if (isautheticated(username, password))
            {
                MessageBox.Show("successful logging in...");
            }
            else
            {
                failedLoginAttempts++;
                MessageBox.Show("try again");

                //enter a future way to only allow a total input of three times failure and then sleep the form input
                if (failedLoginAttempts >= 3)
                {
                    LockForm();
                }
            }
        
        

                //iffai
        }
        public void lockoutuser() { 
        }
        public bool  isautheticated(string username, string password) //auth method
        {
            //enter actual auth later
            return username ==  "user"    && password =="mypassword";
        }
        
      
    }
}
         
