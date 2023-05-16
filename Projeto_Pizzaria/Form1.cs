namespace Projeto_Pizzaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //preenche o ComboBox com os sabores das Pizzas
            cboSabor.Items.Add("Mussarela");
            cboSabor.Items.Add("Palmito");
            cboSabor.Items.Add("Atum");
            cboSabor.Items.Add("Calabresa");

            //seleciona o item da lista que tem �ndice = 0, o primeiro da lista
            cboSabor.SelectedIndex = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //seleciona o item da lista que tem �ndice = 0, o primeiro da lista
            cboSabor.SelectedIndex = 0;
            //coloca o cursor no comboBox
            cboSabor.Focus();

            //Deixa os CheckBox sem sele��o
            chkAzeitona.Checked = false;
            chkCebola.Checked = false;

            //deixa o RadioButton rdbSemBorda selecionado
            rdbSemBorda.Checked = true;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //declara��o das vari�veis
            string strSabor;

            //vari�vel para concatenar os textos
            string strPedido = null;

            //vari�vel recebe o Texto do ComboBox
            strSabor = cboSabor.Text;

            //verififca se tem algum item do CombBox selecionado por meio da propriedade Text
            //Se o texto for Nulo ou Vazio emite mensagem ao usu�rio e coloca o foco do cursor no cboSabor

            if (string.IsNullOrEmpty(cboSabor.Text))
            {
                MessageBox.Show("Selecione um sabor de pizza!", "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboSabor.Focus();
                return;
            }

            //estrutura switch para os sabores das pizzas.
            // a vari�velo strPedido recebe o texto de strSabor 
            switch (strSabor)
            {
                case "Mussarela":
                    strPedido = "Mussarela";
                    break;
                case "Palmito":
                    strPedido = "Palmito";
                    break;
                case "Atum":
                    strPedido = "Atum";
                    break;
                case "Calabresa":
                    strPedido = "Calabresa";
                    break;
            }

            //neste caso podemos ter os dois selecionados, um ou nenhum.
            //concatena o texto de strPedido com a String definida 
            //verifica se CheckBox est� selecionado
            if (chkAzeitona.Checked)
            {
                //concatena o texto de strPedido com a String definida 
                strPedido = strPedido + " com Azeitonas";
            }
            if (chkCebola.Checked)
            {
                strPedido = strPedido + " com Cebola";
            }

            //verifica se RadioButton selecionado
            if (rdbComBorda.Checked)
            {
                //concatena o texto de strPedido com a String definida
                strPedido = strPedido + " com borda recheada";
            }
            else
            {
                strPedido = strPedido + " sem borda";
            }

            // emite mensagem da forma��o do pedido
            MessageBox.Show(strPedido, "Pizzaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}