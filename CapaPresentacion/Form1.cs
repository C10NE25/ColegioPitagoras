using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesing();
        }

        //Metodo para ocultar los submenus
        private void customizeDesing()
        {
            panelAdministrativoSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelAdministrativoSubMenu.Visible == true)
                panelAdministrativoSubMenu.Visible = false;
        }
        //Metodo para mostrar los submenus
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnAdministrativo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAdministrativoSubMenu);
        }

        private void btnTutor_Click(object sender, EventArgs e)
        {
            openChildForms(new frmTutor());

            //Oculta el submenu luego de hacer click en una opcion
            hideSubMenu();
        }
        //Variable para almacenar formulario hijo
        private Form activeForm=null; 
        //Panel para abrir formularios hijos
        private void openChildForms(Form childForm)
        {
            //Si esta activo, lo cierra
            if (activeForm != null)
                activeForm.Close();
            //Almacena el formulario en la variable
            activeForm=childForm;
            childForm.TopLevel=false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag= childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
