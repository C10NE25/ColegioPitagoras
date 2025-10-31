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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            customizeDesing();
        }

        //Metodo para ocultar los submenus
        private void customizeDesing()
        {
            panelAcademicoSubMenu.Visible = false;
            panelAdministrativoSubMenu.Visible = false;
            panelTesoreriaSubMenu.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelAcademicoSubMenu.Visible == true)
                panelAcademicoSubMenu.Visible = false;
            if (panelAdministrativoSubMenu.Visible == true)
                panelAdministrativoSubMenu.Visible = false;
            if (panelTesoreriaSubMenu.Visible == true)
                panelTesoreriaSubMenu.Visible = false;
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

        private void btnAcademico_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAcademicoSubMenu);
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

        private void btnEstudiante_Click(object sender, EventArgs e)
        {
            openChildForms(new frmEstudiante());

            hideSubMenu();
        }

        private void btnDocente_Click(object sender, EventArgs e)
        {
            openChildForms(new frmDocente());

            hideSubMenu();
        }

        private void btnAdministrativo_Click(object sender, EventArgs e)
        {
            showSubMenu(panelAdministrativoSubMenu);
        }

        private void btnTesoreria_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTesoreriaSubMenu);
        }

        private void btnNivelAcademico_Click(object sender, EventArgs e)
        {
            openChildForms(new frmNivelAcademico());

            hideSubMenu();
        }

        private void btnGradoAcademico_Click(object sender, EventArgs e)
        {
            openChildForms(new frmGradoAcademico());

            hideSubMenu();
        }

        private void btnCurso_Click(object sender, EventArgs e)
        {
            openChildForms(new frmCurso());

            hideSubMenu();
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            openChildForms(new frmAsistencias());

            hideSubMenu();
        }

        private void btnNotas_Click(object sender, EventArgs e)
        {
            openChildForms(new frmNotas());

            hideSubMenu();
        }

        private void btnTipoDocumento_Click(object sender, EventArgs e)
        {
            openChildForms(new frmTipoDocumento());

            hideSubMenu();
        }

        private void btnDocumento_Click(object sender, EventArgs e)
        {
            openChildForms(new frmDocumento());

            hideSubMenu();
        }

        private void btnCarpetaInscripcion_Click(object sender, EventArgs e)
        {
            openChildForms(new frmCarpetaInscripcion());

            hideSubMenu();
        }

        private void btnBoletaInscripcion_Click(object sender, EventArgs e)
        {
            openChildForms(new frmBoletaInscripcion());

            hideSubMenu();
        }

        private void btnBoletaMatricula_Click(object sender, EventArgs e)
        {
            openChildForms(new frmBoletaMatricula());

            hideSubMenu();
        }

        private void btnInscripcion_Click(object sender, EventArgs e)
        {
            openChildForms(new frmInscripcion());

            hideSubMenu();
        }

        private void btnMatricula_Click(object sender, EventArgs e)
        {
            openChildForms(new frmMatricula());

            hideSubMenu();
        }

        private void btnTipoPlanPago_Click(object sender, EventArgs e)
        {
            openChildForms(new frmTipoPlanPago());

            hideSubMenu();
        }

        private void btnPlanPago_Click(object sender, EventArgs e)
        {
            openChildForms(new frmPlanPago());

            hideSubMenu();
        }

        private void btnBoletaPago_Click(object sender, EventArgs e)
        {
            openChildForms(new frmBoletaPago());

            hideSubMenu();
        }
    }
}
