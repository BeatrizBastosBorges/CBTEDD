using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContatoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }
        private Contatos agenda = new Contatos();
        private bool isFromAlter = false;

        private Button btnExit;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnAlter;
        private Button btnRemove;
        private Button btnList;
        private Button btnSave;
        private Button btnConfirmSearch;
        private Button btnSaveAlteration;
        private Button btnDelet;
        private Button btnBack;

        private TextBox txtNome, txtEmail, txtDia, txtMes, txtAno, txtTelefone, txtTipo;
        private CheckBox chkPrincipal;
        private ListBox lstContatos;

        private void InitializeUI()
        {
            this.Text = "Projeto Contato";
            this.Size = new Size(900, 500);
            this.StartPosition = FormStartPosition.CenterScreen;

            btnExit = new Button();
            btnExit.Text = "Sair";
            btnExit.Size = new Size(100, 30);
            btnExit.Location = new Point(10, 10);
            btnExit.Click += BtnExit_Click;
            this.Controls.Add(btnExit);

            btnAdd = new Button();
            btnAdd.Text = "Adicionar contato";
            btnAdd.Size = new Size(150, 30);
            btnAdd.Location = new Point(120, 10);
            btnAdd.Click += BtnAdd_Click;
            this.Controls.Add(btnAdd);

            btnSearch = new Button();
            btnSearch.Text = "Pesquisar contato";
            btnSearch.Size = new Size(150, 30);
            btnSearch.Location = new Point(280, 10);
            btnSearch.Click += BtnSearch_Click;
            this.Controls.Add(btnSearch);

            btnAlter = new Button();
            btnAlter.Text = "Alterar contato";
            btnAlter.Size = new Size(130, 30);
            btnAlter.Location = new Point(440, 10);
            btnAlter.Click += BtnAlter_Click;
            this.Controls.Add(btnAlter);

            btnRemove = new Button();
            btnRemove.Text = "Remover contato";
            btnRemove.Size = new Size(140, 30);
            btnRemove.Location = new Point(580, 10);
            btnRemove.Click += BtnRemove_Click;
            this.Controls.Add(btnRemove);

            btnList = new Button();
            btnList.Text = "Listar contato";
            btnList.Size = new Size(130, 30);
            btnList.Location = new Point(730, 10);
            btnList.Click += BtnList_Click;
            this.Controls.Add(btnList);

            lstContatos = new ListBox();
            lstContatos.Size = new Size(800, 200);
            lstContatos.Location = new Point(40, 100);
            this.Controls.Add(lstContatos);
        }

        private void InitializeContatoForm()
        {
            Label lblNome = new Label();
            lblNome.Text = "Nome:";
            lblNome.Location = new Point(10, 10);
            this.Controls.Add(lblNome);

            txtNome = new TextBox();
            txtNome.Size = new Size(200, 30);
            txtNome.Location = new Point(120, 10);
            this.Controls.Add(txtNome);

            Label lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.Location = new Point(10, 50);
            this.Controls.Add(lblEmail);

            txtEmail = new TextBox();
            txtEmail.Size = new Size(200, 30);
            txtEmail.Location = new Point(120, 50);
            this.Controls.Add(txtEmail);

            Label lblDataNasc = new Label();
            lblDataNasc.Text = "Data de Nascimento:";
            lblDataNasc.Location = new Point(10, 90);
            this.Controls.Add(lblDataNasc);

            txtDia = new TextBox();
            txtDia.Size = new Size(30, 30);
            txtDia.Location = new Point(120, 90);
            this.Controls.Add(txtDia);

            txtMes = new TextBox();
            txtMes.Size = new Size(30, 30);
            txtMes.Location = new Point(160, 90);
            this.Controls.Add(txtMes);

            txtAno = new TextBox();
            txtAno.Size = new Size(50, 30);
            txtAno.Location = new Point(200, 90);
            this.Controls.Add(txtAno);

            Label lblTelefone = new Label();
            lblTelefone.Text = "Telefone:";
            lblTelefone.Location = new Point(10, 130);
            this.Controls.Add(lblTelefone);

            txtTelefone = new TextBox();
            txtTelefone.Size = new Size(150, 30);
            txtTelefone.Location = new Point(120, 130);
            this.Controls.Add(txtTelefone);

            Label lblTipo = new Label();
            lblTipo.Text = "Tipo:";
            lblTipo.Location = new Point(10, 170);
            this.Controls.Add(lblTipo);

            txtTipo = new TextBox();
            txtTipo.Size = new Size(100, 30);
            txtTipo.Location = new Point(120, 170);
            this.Controls.Add(txtTipo);

            chkPrincipal = new CheckBox();
            chkPrincipal.Text = "Principal";
            chkPrincipal.Location = new Point(230, 170);
            this.Controls.Add(chkPrincipal);
        }

        private void InitializeContatoEmailForm()
        {
            Label lblEmail = new Label();
            lblEmail.Text = "Email:";
            lblEmail.Location = new Point(10, 10);
            this.Controls.Add(lblEmail);

            txtEmail = new TextBox();
            txtEmail.Size = new Size(200, 30);
            txtEmail.Location = new Point(120, 10);
            this.Controls.Add(txtEmail);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AtualizarListaContatos()
        {
            lstContatos.Items.Clear();
            foreach (var contato in agenda.ListarContatos())
            {
                lstContatos.Items.Add(contato.ToString());
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeContatoForm();

            btnSave= new Button();
            btnSave.Text = "Salvar";
            btnSave.Size = new Size(100, 30);
            btnSave.Location = new Point(10, 250);
            btnSave.Click += BtnSave_Click;
            this.Controls.Add(btnSave);

            btnBack = new Button();
            btnBack.Text = "Voltar";
            btnBack.Size = new Size(100, 30);
            btnBack.Location = new Point(220, 250);
            btnBack.Click += BtnBack_Click;
            this.Controls.Add(btnBack);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeContatoEmailForm();

            btnConfirmSearch = new Button();
            btnConfirmSearch.Text = "Confirmar";
            btnConfirmSearch.Size = new Size(100, 30);
            btnConfirmSearch.Location = new Point(10, 50);
            btnConfirmSearch.Click += BtnConfirmSearch_Click;
            this.Controls.Add(btnConfirmSearch);

            btnBack = new Button();
            btnBack.Text = "Voltar";
            btnBack.Size = new Size(100, 30);
            btnBack.Location = new Point(220, 50);
            btnBack.Click += BtnBack_Click;
            this.Controls.Add(btnBack);
        }

        private void BtnAlter_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeContatoForm();

            isFromAlter = true;

            btnSave = new Button();
            btnSave.Text = "Editar";
            btnSave.Size = new Size(100, 30);
            btnSave.Location = new Point(10, 250);
            btnSave.Click += BtnSaveAlteration_Click;
            this.Controls.Add(btnSave);

            btnSearch = new Button();
            btnSearch.Text = "Procurar";
            btnSearch.Size = new Size(100, 30);
            btnSearch.Location = new Point(330, 50);
            btnSearch.Click += BtnConfirmSearch_Click;
            this.Controls.Add(btnSearch);

            btnBack = new Button();
            btnBack.Text = "Voltar";
            btnBack.Size = new Size(100, 30);
            btnBack.Location = new Point(220, 250);
            btnBack.Click += BtnBack_Click;
            this.Controls.Add(btnBack);
        }

        private void BtnSearch_Click1(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeContatoEmailForm();

            btnDelet = new Button();
            btnDelet.Text = "Confirmar";
            btnDelet.Size = new Size(100, 30);
            btnDelet.Location = new Point(10, 50);
            btnDelet.Click += BtnDelet_Click;
            this.Controls.Add(btnDelet);

            btnBack = new Button();
            btnBack.Text = "Voltar";
            btnBack.Size = new Size(100, 30);
            btnBack.Location = new Point(220, 50);
            btnBack.Click += BtnBack_Click;
            this.Controls.Add(btnBack);
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            AtualizarListaContatos();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeUI();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int ano = int.Parse(txtAno.Text);
            string telefone = txtTelefone.Text;
            string tipo = txtTipo.Text;
            bool principal = chkPrincipal.Checked;

            Data dataNascimento = new Data();
            dataNascimento.setData(dia, mes, ano);

            Contato novoContato = new Contato(nome, email, dataNascimento);

            Telefone novoTelefone = new Telefone(tipo, telefone, principal);
            novoContato.AdicionarTelefone(novoTelefone);

            if (agenda.Adicionar(novoContato))
            {
                MessageBox.Show("Contato adicionado com sucesso!");
            }
            else
            {
                MessageBox.Show("Não é possível adicionar esse contato!");
            }

            AtualizarListaContatos();
        }

        private void BtnSaveAlteration_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            Contato contatoParaAlterar = new Contato("", email, null);
            Contato contatoExistente = agenda.Pesquisar(contatoParaAlterar);

            if (contatoExistente != null)
            {
                contatoExistente.setNome(txtNome.Text);
                Data d = new Data();
                d.setDia(int.Parse(txtDia.Text));
                d.setMes(int.Parse(txtMes.Text));
                d.setAno(int.Parse(txtAno.Text));
                contatoExistente.setData(d);

                Telefone telefonePrincipal = contatoExistente.getTelefones().FirstOrDefault(t => t.getPrincipal());
                if (telefonePrincipal != null)
                {
                    telefonePrincipal.setNumero(txtTelefone.Text);
                    telefonePrincipal.setTipo(txtTipo.Text);
                    telefonePrincipal.setPrincipal(chkPrincipal.Checked);
                }
                else
                {
                    Telefone novoTelefone = new Telefone(txtTipo.Text, txtTelefone.Text, chkPrincipal.Checked);
                    contatoExistente.AdicionarTelefone(novoTelefone);
                }

                if (agenda.Alterar(contatoExistente))
                {
                    MessageBox.Show("Contato alterado com sucesso!");
                    AtualizarListaContatos();
                }
                else
                {
                    MessageBox.Show("Erro ao alterar contato.");
                }
            }
            else
            {
                MessageBox.Show("Contato não encontrado.");
            }
        }

        private void BtnConfirmSearch_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            Contato contato = new Contato("", email, null);
            Contato encontrado = agenda.Pesquisar(contato);

            if (encontrado != null)
            {
                MessageBox.Show(encontrado.ToString());

                if (isFromAlter)
                {
                    this.Controls.Clear();
                    InitializeContatoForm();

                    txtNome.Text = encontrado.getNome();
                    txtEmail.Text = encontrado.getEmail();
                    txtDia.Text = encontrado.getData().getDia().ToString();
                    txtMes.Text = encontrado.getData().getMes().ToString();
                    txtAno.Text = encontrado.getData().getAno().ToString();

                    ListBox listaDeNumeros = new ListBox();
                    listaDeNumeros.Size = new Size(200, 150);
                    listaDeNumeros.Location = new Point(400, 10); 
                    this.Controls.Add(listaDeNumeros);

                    List<Telefone> numeros = encontrado.getTelefones();
                    foreach (var telefone in numeros)
                    {
                        listaDeNumeros.Items.Add($"{telefone.getTipo()} - {telefone.getNumero()} (Principal: {telefone.getPrincipal()})");
                    }

                    listaDeNumeros.SelectedIndexChanged += (s, ev) =>
                    {
                        int selectedIndex = listaDeNumeros.SelectedIndex;
                        if (selectedIndex >= 0 && selectedIndex < numeros.Count)
                        {
                            Telefone telefoneSelecionado = numeros[selectedIndex];

                            txtTipo.Text = telefoneSelecionado.getTipo();
                            txtTelefone.Text = telefoneSelecionado.getNumero();
                            chkPrincipal.Checked = telefoneSelecionado.getPrincipal();
                        }
                    };

                    // Adicionar botões de salvar alteração e voltar
                    btnSaveAlteration = new Button();
                    btnSaveAlteration.Text = "Salvar Alterações";
                    btnSaveAlteration.Size = new Size(150, 30);
                    btnSaveAlteration.Location = new Point(10, 250);
                    btnSaveAlteration.Click += BtnSaveAlteration_Click;
                    this.Controls.Add(btnSaveAlteration);

                    btnBack = new Button();
                    btnBack.Text = "Voltar";
                    btnBack.Size = new Size(100, 30);
                    btnBack.Location = new Point(220, 250);
                    btnBack.Click += BtnBack_Click;
                    this.Controls.Add(btnBack);

                    isFromAlter = false;
                }
            }
            else
            {
                MessageBox.Show("Contato não encontrado.");
            }
        }



        private void BtnDelet_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            Contato contatoParaRemover = new Contato("", email, null);

            Contato contatoExistente = agenda.Pesquisar(contatoParaRemover);

            if (contatoExistente != null)
            {
                if (agenda.Remover(contatoExistente))
                {
                    MessageBox.Show("Contato removido com sucesso!");
                    AtualizarListaContatos();
                }
                else
                {
                    MessageBox.Show("Erro ao remover o contato.");
                }
            }
            else
            {
                MessageBox.Show("Contato não encontrado.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
