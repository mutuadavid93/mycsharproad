using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ReflectionSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TypeName = textBox1.Text;
            Type T = Type.GetType(TypeName);

            //Clear containers on start
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            //Get Methods
            MethodInfo[] methods = T.GetMethods();
            foreach (MethodInfo method in methods)
            {
                listBox1.Items.Add(method.ReturnType.Name+" "+method.Name);
            }

            //Get Properties
            PropertyInfo[] properties = T.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                listBox2.Items.Add(property.PropertyType.Name + " " + property.Name);
            }

            //Get Constructors
            ConstructorInfo[] constructors = T.GetConstructors();
            foreach (ConstructorInfo constrcutor in constructors)
            {
                listBox3.Items.Add(constrcutor.ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
