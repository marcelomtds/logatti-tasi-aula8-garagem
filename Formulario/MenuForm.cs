using System;
using System.Windows.Forms;

namespace Formulario
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void itemMenuCliente_Click(object sender, EventArgs e)
        {
            if (IsClosedForm("ClienteForm"))
            {
                ClienteForm cliente = new ClienteForm();
                cliente.Show();
            }
        }

        private Boolean IsClosedForm(string formName)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form form in fc)
            {
                if (form.Name == formName)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
