
namespace PAAgenda.View
{
    partial class FrmLista
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtConsulta = new System.Windows.Forms.TextBox();
            this.BtnConsultar = new System.Windows.Forms.Button();
            this.RdbTodos = new System.Windows.Forms.RadioButton();
            this.RdbNome = new System.Windows.Forms.RadioButton();
            this.RdbTelefone = new System.Windows.Forms.RadioButton();
            this.DtgAgenda = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtConsulta
            // 
            this.TxtConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TxtConsulta.Location = new System.Drawing.Point(75, 45);
            this.TxtConsulta.Name = "TxtConsulta";
            this.TxtConsulta.Size = new System.Drawing.Size(859, 29);
            this.TxtConsulta.TabIndex = 0;
            this.TxtConsulta.TextChanged += new System.EventHandler(this.TxtConsulta_TextChanged);
            // 
            // BtnConsultar
            // 
            this.BtnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.BtnConsultar.FlatAppearance.BorderSize = 0;
            this.BtnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.BtnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsultar.Image = global::PAAgenda.Properties.Resources.search_24px;
            this.BtnConsultar.Location = new System.Drawing.Point(944, 45);
            this.BtnConsultar.Name = "BtnConsultar";
            this.BtnConsultar.Size = new System.Drawing.Size(34, 29);
            this.BtnConsultar.TabIndex = 1;
            this.BtnConsultar.UseVisualStyleBackColor = false;
            this.BtnConsultar.Click += new System.EventHandler(this.BtnConsultar_Click);
            // 
            // RdbTodos
            // 
            this.RdbTodos.AutoSize = true;
            this.RdbTodos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RdbTodos.ForeColor = System.Drawing.Color.White;
            this.RdbTodos.Location = new System.Drawing.Point(75, 92);
            this.RdbTodos.Name = "RdbTodos";
            this.RdbTodos.Size = new System.Drawing.Size(63, 21);
            this.RdbTodos.TabIndex = 2;
            this.RdbTodos.TabStop = true;
            this.RdbTodos.Text = "Todos";
            this.RdbTodos.UseVisualStyleBackColor = true;
            // 
            // RdbNome
            // 
            this.RdbNome.AutoSize = true;
            this.RdbNome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RdbNome.ForeColor = System.Drawing.Color.White;
            this.RdbNome.Location = new System.Drawing.Point(158, 92);
            this.RdbNome.Name = "RdbNome";
            this.RdbNome.Size = new System.Drawing.Size(63, 21);
            this.RdbNome.TabIndex = 3;
            this.RdbNome.TabStop = true;
            this.RdbNome.Text = "Nome";
            this.RdbNome.UseVisualStyleBackColor = true;
            // 
            // RdbTelefone
            // 
            this.RdbTelefone.AutoSize = true;
            this.RdbTelefone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RdbTelefone.ForeColor = System.Drawing.Color.White;
            this.RdbTelefone.Location = new System.Drawing.Point(233, 92);
            this.RdbTelefone.Name = "RdbTelefone";
            this.RdbTelefone.Size = new System.Drawing.Size(79, 21);
            this.RdbTelefone.TabIndex = 4;
            this.RdbTelefone.TabStop = true;
            this.RdbTelefone.Text = "Telefone";
            this.RdbTelefone.UseVisualStyleBackColor = true;
            // 
            // DtgAgenda
            // 
            this.DtgAgenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.DtgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.Telefone});
            this.DtgAgenda.Location = new System.Drawing.Point(75, 147);
            this.DtgAgenda.Name = "DtgAgenda";
            this.DtgAgenda.ReadOnly = true;
            this.DtgAgenda.RowTemplate.Height = 25;
            this.DtgAgenda.Size = new System.Drawing.Size(859, 418);
            this.DtgAgenda.TabIndex = 5;
            this.DtgAgenda.SelectionChanged += new System.EventHandler(this.DtgAgenda_SelectionChanged);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 560;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 216;
            // 
            // FrmLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.ClientSize = new System.Drawing.Size(1114, 652);
            this.Controls.Add(this.DtgAgenda);
            this.Controls.Add(this.RdbTelefone);
            this.Controls.Add(this.RdbNome);
            this.Controls.Add(this.RdbTodos);
            this.Controls.Add(this.BtnConsultar);
            this.Controls.Add(this.TxtConsulta);
            this.Name = "FrmLista";
            this.Text = "FrmLista";
            ((System.ComponentModel.ISupportInitialize)(this.DtgAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtConsulta;
        private System.Windows.Forms.Button BtnConsultar;
        private System.Windows.Forms.RadioButton RdbTodos;
        private System.Windows.Forms.RadioButton RdbNome;
        private System.Windows.Forms.RadioButton RdbTelefone;
        private System.Windows.Forms.DataGridView DtgAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
    }
}