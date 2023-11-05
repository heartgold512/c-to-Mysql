using System;
using System.Net.Security;
using System.Drawing;
using System.Windows.Forms;

namespace restarunttest2
{
    public class Loginform : Form1 //class to reference as using .:. declare public and inherit
    {

        private TextBox usernametextbox; 
        private TextBox passwordtextbox;
        private Button loginbutton;
        //global stuff for global reasons

        public Loginform() //eventh is the evnt handler function go down to see
        {
            InitializeComponents();
            eventh();
        }

        private void InitializeComponents() //method defines properties of message boxes and stuff
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
                PasswordChar = '*', //just two bog standard login textboxes
            };

            loginbutton = new Button
            {
                Text = "Login",
                Location = new System.Drawing.Point(100, 80), //to confirm login
            };


            this.Controls.Add(usernametextbox);
            this.Controls.Add(passwordtextbox);
            this.Controls.Add(loginbutton);
        }
        //method ends here?
        private int failedLoginAttempts = 0; //this will be incremented later (add one to zero)

        private void eventh()
        {
            loginbutton.Click += loginbuttonvclick; //we can now define a method for logginbuttonvclick as += not =
        }
        private void loginbuttonvclick(object sender, EventArgs e) //eeeeeeeeeeeeeeeeeeee
        {
            string username = usernametextbox.Text; // itll work fine anyways
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
                    LockForm(); //lent method from Form1
                }
            }

            
        }
        public void lockoutuser() { 
        }
        public bool  isautheticated(string username, string password) //auth method
        {
            //enter actual auth later like your actual username and password in: ""
            return username ==  "user"    && password =="mypassword";
        }
        
      
    }
}
         
