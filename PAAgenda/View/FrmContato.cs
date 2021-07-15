using System;
using System.Windows.Forms;

namespace PAAgenda.View
{
    using PAAgenda.Domain.Model;
    using PAAgenda.ViewModel;
    using System.Threading.Tasks;

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
            await SaveOrEdit();
        }

        private async void BtnEditar_Click(object sender, EventArgs e)
        {
            await SaveOrEdit();
        }

        private async void BtnExcluir_Click(object sender, EventArgs e)
        {
            if (!(String.IsNullOrWhiteSpace(TxtCodigo.Text)))
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
                    DisplayMessageBoxOK("Erroa ao executar operação", ex.Message);
                }
            }
            else 
            {
                string caption = "Erro no preenchimento dos dados:";
                string message = "Você deve selecionar um registro para exclusão";
                DisplayMessageBoxOK(caption, message);
            }
           
            
        }
        #region Métodos auxiliares de evento
        private void ClearForm() 
        {
            TxtCodigo.Clear();
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
        private async Task SaveOrEdit()
        {
            try
            {
                ReadForm();
                if (!(String.IsNullOrWhiteSpace(TxtNome.Text)) && !(string.IsNullOrWhiteSpace(TxtTelefone.Text)))
                {
                    await _viewModel.Salvar();
                    ClearForm();
                    _viewModel.Agenda = new Agenda { Id = 0 };
                }
                else
                {
                    string caption = "Erro no preenchimento dos dados:";
                    string message = "Você deve preencher os campos de Nome e Telefone";
                    DisplayMessageBoxOK(caption, message);
                }

            }
            catch (Exception ex)
            {
                DisplayMessageBoxOK("Erroa ao executar operação",ex.Message);
            }
        }

        private void DisplayMessageBoxOK(string caption, string message)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(message, caption, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion
    }
}
