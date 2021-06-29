using System;
using System.Windows.Forms;
using WindowsFormsApp1.Controls;

namespace WindowsFormsApp1.ChildForms
{
    public partial class FormMaster : Form
    {
        OpenChildForms open = new OpenChildForms();

        public FormMaster()
        {
            InitializeComponent();
            open.OpenChildForm(new ChildForms.frmMaster.frmAddFlight(),pnlMasterChildForm);
        }
        private void CreateComponents() { 
            

        
        
        
        
        
        
        }
        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            
            open.OpenChildForm(new ChildForms.frmMaster.frmAddFlight(), pnlMasterChildForm);
        }

        private void pnlMasterChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddMaster_Click(object sender, EventArgs e)
        {
           
            open.OpenChildForm(new ChildForms.FrmMaster.frmAddMaster(), pnlMasterChildForm);

        }

        private void btnListOfFlight_Click(object sender, EventArgs e)
        {
            open.OpenChildForm(new ChildForms.FormsMaster.MasterListOfFlights(), pnlMasterChildForm);
        }
    }
}
