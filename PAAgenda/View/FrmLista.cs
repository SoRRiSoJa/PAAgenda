using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAAgenda.View
{
    using PAAgenda.ViewModel;
    public partial class FrmLista : Form
    {
        private  ListaViewModel _viewModel;
        public Menu MenuRef { get; set; }

        public  FrmLista()
        {
            InitializeComponent();
            _viewModel = new ListaViewModel();
             
        }
        public FrmLista(ListaViewModel _viewModel)
        {
            InitializeComponent();
            this._viewModel = _viewModel;
        }

        private async void BtnConsultar_Click(object sender, EventArgs e)
        {
            await SearchAndList();
        }

        private async Task SearchAndList()
        {
            try
            {
                if (!string.IsNullOrEmpty(TxtConsulta.Text) && TxtConsulta.Text.Length > 3)
                {

                    if (RdbTelefone.Checked)
                    {
                        await LoadDtgByNumber(TxtConsulta.Text);
                    }
                    else if (RdbNome.Checked)
                    {
                        await LoadDtgByName(TxtConsulta.Text);
                    }
                    else if (RdbTodos.Checked)
                    {
                        await LoadDtg();
                    }
                }
                else
                {
                    await LoadDtg();
                }
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

        private async void TxtConsulta_TextChanged(object sender, EventArgs e)
        {
            await SearchAndList();
            
        }
        private async Task LoadDtg() 
        {
            try
            {
                if (!(RdbNome.Checked && RdbTelefone.Checked && RdbTodos.Checked) || RdbTodos.Checked)
                {
                    DtgAgenda.Rows.Clear();
                    await _viewModel.UpdateList();
                    foreach (var item in _viewModel.Lista)
                    {
                        DtgAgenda.Rows.Add(new string[] { item.Id.ToString(), item.Nome, item.Numero });
                    }
                }
            }
            catch (Exception ex)
            {
                DisplayMsgBox(ex);
            }
            
            
        }
        private async Task LoadDtgByNumber(string number)
        {
            try
            {
                DtgAgenda.Rows.Clear();
                await _viewModel.UpdateListByNumber(number);
                foreach (var item in _viewModel.Lista)
                {
                    DtgAgenda.Rows.Add(new string[] { item.Id.ToString(), item.Nome, item.Numero });
                }
            }
            catch (Exception ex)
            {
                DisplayMsgBox(ex);
            }
            
        }
        private async Task LoadDtgByName(string name)
        {
            try
            {
                DtgAgenda.Rows.Clear();
                await _viewModel.UpdateListByName(name);
                foreach (var item in _viewModel.Lista)
                {
                    DtgAgenda.Rows.Add(new string[] { item.Id.ToString(), item.Nome, item.Numero });
                }
            }
            catch (Exception ex)
            {

                DisplayMsgBox(ex);
            }
            
        }

        private void DtgAgenda_SelectionChanged(object sender, EventArgs e)
        {
            if (DtgAgenda.SelectedRows.Count>0)
            {
                _viewModel.Agenda.Id = int.Parse(DtgAgenda.Rows[DtgAgenda.CurrentRow.Index].Cells[0].Value.ToString());
                _viewModel.Agenda.Nome = DtgAgenda.Rows[DtgAgenda.CurrentRow.Index].Cells[1].Value.ToString();
                _viewModel.Agenda.Numero = DtgAgenda.Rows[DtgAgenda.CurrentRow.Index].Cells[2].Value.ToString();
                MenuRef.OpenChildForm(new FrmContato(_viewModel));
            }
        }
    }
}
