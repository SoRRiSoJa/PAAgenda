using System;
using System.Windows.Forms;

namespace PAAgenda.View
{
    using PAAgenda.Domain.Model;
    using PAAgenda.ViewModel;

    public partial class FrmContato : Form
    {

        private ListaViewModel _viewModel;

        public FrmContato()
        {
            InitializeComponent();
            _viewModel = new ListaViewModel();
        }
        public FrmContato(ListaViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            LoadForm();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            _viewModel.Agenda=new Agenda{ Id = 0};
            ClearForm();
        }

        private async void BtnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ReadForm();
                await _viewModel.Salvar();
                ClearForm();
                _viewModel.Agenda = new Agenda { Id = 0 };
            }
            catch (Exception ex)
            {
                DisplayMsgBox(ex);
            }

        }

        private void DisplayMsgBox(Exception ex)
        {
            string caption = "Erro ao executar operação:";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            
            result = MessageBox.Show(ex.Message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                ReadForm();
                await _viewModel.Salvar();
                ClearForm();
                _viewModel.Agenda = new Agenda { Id = 0 };
            }
            catch (Exception ex)
            {
                DisplayMsgBox(ex);
            }
            
        }

        private async void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                ReadForm();
                await _viewModel.Delete();
                ClearForm();
                _viewModel.Agenda = new Agenda { Id = 0 };
            }
            catch (Exception ex)
            {
                DisplayMsgBox(ex);
            }
            
        }
        #region Métodos auxiliares de evento
        private void ClearForm() 
        {
            TxtNome.Clear();
            TxtTelefone.Clear();
           
        }
        private void LoadForm() 
        {
            TxtCodigo.Text = _viewModel.Agenda.Id.ToString();
            TxtNome.Text = _viewModel.Agenda.Nome;
            TxtTelefone.Text = _viewModel.Agenda.Numero;
        }
        private void ReadForm() 
        {
            int id = 0;
            int.TryParse(TxtCodigo.Text, out id);
            _viewModel.Agenda.Id = id;
            _viewModel.Agenda.Nome = TxtNome.Text;
            _viewModel.Agenda.Numero = TxtTelefone.Text;
        }
        #endregion
    }
}
