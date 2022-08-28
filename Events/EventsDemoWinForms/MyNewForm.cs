using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsDemoWinForms
{
    public partial class MyNewForm : Form
    {
        public event EventHandler<object> myEvent;
        public int Counter { get; set; } = 0;
        public MyNewForm()
        {
            InitializeComponent();
            myEvent += abonatOfMyMethod;

        }

       

        private void OnClickDoSomething(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Red;
            Counter++;
            if(Counter == 5)
            {
                myEvent.Invoke(this, null);
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            this.button1.BackColor = Color.Black;
        }

        private void abonatOfMyMethod(object sender, object e)
        {
            this.textBox1.BackColor = Color.Blue;
        }

    }
}
