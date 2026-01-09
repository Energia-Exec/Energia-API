using System;
using System.Windows.Forms;

namespace EnergiaTestUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Energia.InstancesChanged += (list) =>
            {
                // list[idx].Id -- Roblox PID
                // list[idx].Name -- Roblox client name

                label1.Text = "Attached: " + Energia.IsAttached().ToString();
            };

            Energia.Refresh(); // will update list of attached Roblox instances and fire attached event
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Energia.Attach(); // attaches to all instances
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Energia.Execute(textBox1.Text); // executes to all instances
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Energia.Kill(); // kills all instances
        }
    }
}
