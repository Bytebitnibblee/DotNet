using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Event_Demo
{
    public delegate void DelEventHandler();
    class Program:Form
    {
        public event DelEventHandler add;
        Program()
        {
            Button btn = new Button();
            btn.Parent = this;
            btn.Text = "Hit me";
            btn.Location = new System.Drawing.Point(150,150);

            btn.Click += new EventHandler(onClick);
            add += new DelEventHandler(Initiate);
            add();
        }

        public void Initiate()
        {
            Console.WriteLine("Event Initiates");

        }
        public void onClick(Object sender, EventArgs e)
        {
            MessageBox.Show("you clicked me");
        }
        static void Main(string[] args)
        {
            Application.Run(new Program());
            Console.ReadLine();
        }
    }
}
