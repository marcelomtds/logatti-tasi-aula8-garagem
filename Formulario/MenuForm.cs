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
                ClienteForm form = new ClienteForm();
                form.Show();
            }
        }

        private void itemMenuFuncionario_Click(object sender, EventArgs e)
        {
            if (IsClosedForm("FuncionarioForm"))
            {
                FuncionarioForm form = new FuncionarioForm();
                form.Show();
            }
        }

        private void itemMenuMotor_Click(object sender, EventArgs e)
        {
            if (IsClosedForm("MotorForm"))
            {
                MotorForm form = new MotorForm();
                form.Show();
            }
        }

        private void itemMenuCarro_Click(object sender, EventArgs e)
        {
            if (IsClosedForm("CarroForm"))
            {
                CarroForm form = new CarroForm();
                form.Show();
            }
        }

        private void itemMenuGaragem_Click(object sender, EventArgs e)
        {
            if (IsClosedForm("GaragemForm"))
            {
                GaragemForm form = new GaragemForm();
                form.Show();
            }
        }

        private void itemMenuAtendimento_Click(object sender, EventArgs e)
        {
            if (IsClosedForm("AtendimentoForm"))
            {
                AtendimentoForm form = new AtendimentoForm();
                form.Show();
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