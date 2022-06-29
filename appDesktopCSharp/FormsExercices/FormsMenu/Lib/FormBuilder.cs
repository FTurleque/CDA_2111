using FormsMenu.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsMenu.Lib
{
    internal class FormBuilder<T> : IFormBuilder where T : Form, new()
    {
        public int index;

        public FormBuilder()
        {
            index = 0;
        }

        public Form CreateInstance(Form parent)
        {
            T form = new();
            form.Text += " N°" + ++index;
            form.MdiParent = parent;
            /*form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.WindowState = FormWindowState.Maximized;*/
            return form;
        }

    }
}
