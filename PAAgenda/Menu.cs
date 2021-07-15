using PAAgenda.View;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using PAAgenda.ViewModel;

namespace PAAgenda
{
    public partial class Menu : Form
    {
        public Form CurrentChildForm;
        public ListaViewModel ViewModel { get; set; }
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
        }

        private void BtnNovo_Click(object sender, EventArgs e)
        {
            if (ViewModel != null) 
            {
                OpenChildForm(new FrmContato(ViewModel));
            }
            else 
            {
                OpenChildForm(new FrmContato());
            }
            
        }

        private void BtnLista_Click(object sender, EventArgs e)
        {
            var frm = new FrmLista
            {
                MenuRef = this
            };
            OpenChildForm(frm);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void OpenChildForm(Form cForm)
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }
            CurrentChildForm = cForm;
            CurrentChildForm.TopLevel = false;
            CurrentChildForm.FormBorderStyle = FormBorderStyle.None;
            CurrentChildForm.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(CurrentChildForm);
            PanelContent.Tag = CurrentChildForm;
            CurrentChildForm.BringToFront();
            CurrentChildForm.Show();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCpture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCpture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
