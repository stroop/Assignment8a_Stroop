using System;
using System.Windows.Forms;

/*
Jacob Stroop
CIS353 - Assignment 8a
2/7/16
*/

namespace Assignment8a_Stroop
{
    class Assignment8 : Form
    {
        // declare controls
        private Button btnClickMe;
        private Button btnExit;

        // constructor calls method to initialize form
        public Assignment8()
        {
            InitializeComponent();
        }

        // initialization instructions
        private void InitializeComponent()
        {
            // btnClickMe config
            this.btnClickMe = new System.Windows.Forms.Button(); // instantiate button
            this.btnClickMe.Location = new System.Drawing.Point(15, 20); // button location
            this.btnClickMe.Text = "Press Me"; // button text
            this.btnClickMe.Click += new EventHandler(this.btnClickMe_Click); // button event handler

            // btnExit config
            this.btnExit = new System.Windows.Forms.Button(); // instantiate button
            this.btnExit.Location = new System.Drawing.Point(15, 60); // button location
            this.btnExit.Text = "Exit"; // button text
            this.btnExit.Click += new EventHandler(this.btnExit_Click); // button event handler

            // form config
            this.ClientSize = new System.Drawing.Size(300, 150); // form size
            this.Controls.Add(this.btnClickMe); // add button
            this.Controls.Add(this.btnExit); // add button
            this.Name = "Assignment8"; // form name
            this.Text = "Assignment8"; // form title bar text
        }

        // button onclick method exits application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        // button onclick method displays message box
        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Button Has Been Clicked.", "Click Me");
        }
    }

    static class Assignment8a_Stroop
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Assignment8());
        }
    }
}
