using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DynamicLua;



namespace Lua_LP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            try
            {
                dynamic lua = new DynamicLua.DynamicLua();
                lua("texto='Mensaje mostrado usando Lua, asignado a la variable texto en lua, y despues asignada al textbox de c#'");
                lua(textBox1.Text += lua.texto);
            }
            catch (Exception err)
            {

                Console.WriteLine(err.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            string s = @"luanet.load_assembly ""System.Windows.Forms""
                        Form = luanet.import_type ""System.Windows.Forms.Form""

                        form = Form()
                        form.Text = ""Lua's Form""
                        form:ShowDialog()";
            textBox1.Text = s;

            try
            {
                dynamic lua = new DynamicLua.DynamicLua();
                lua(textBox1.Text);
            }
            catch (Exception)
            {

                //throw;
            }

        }

        /*
luanet.load_assembly "System.Windows.Forms"
Form = luanet.import_type "System.Windows.Forms.Form"
Button = luanet.import_type "System.Windows.Forms.Button"
Label = luanet.import_type "System.Windows.Forms.Label"
TextBox = luanet.import_type "System.Windows.Forms.TextBox"
MessageBox = luanet.import_type "System.Windows.Forms.MessageBox"

form = Form()
form.Text = "Form Maker"



button = Button()

button.Text = "Make Form"
button.Left = 150
button.Top = 100
button.Click:Add(function()
MessageBox.Show(textbox.Text,"Special box tittle")end)

form.Controls:Add(button)

textbox = TextBox()
textbox.Left = 50
textbox.Top = 100
form.Controls:Add(textbox)

label = Label()
label.Text="Ingrese el Texto"
label.Left = 80
label.Top = 50
form.Controls:Add(label)
form:ShowDialog()
        */
        private void button3_Click(object sender, EventArgs e)
        {

            string s =
                s = "@\"";
            s = textBox1.Text;
            s += "\"";


            try
            {
                dynamic lua = new DynamicLua.DynamicLua();
                lua(textBox1.Text);
            }
            catch (Exception)
            {

                //throw;
            }

        }
    }
}
