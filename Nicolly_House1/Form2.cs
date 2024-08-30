using System;
using System.Drawing;
using System.Windows.Forms;

namespace Nicolly_House1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /* a groupbox(5) dos episódios da versão 'temporadas e personagens' é linkada com a groupbox dos pacientes (6), ou seja, quando você
         * escolhe um episódio o paciente daquele episódio aparece automaticamente na grpbx(6). Já na versão 'escritores e diretores', eles não são linkados, então
         * a grpbx(6) ja aparece junto com a (5). Por isso, haverá uma list box separada para a escolha dos diretores.
         * 
         * 'temporadas e personagens'
         *     - nome da grpbx(6) fica no radiobutton.Checked.changed da listbox da grpbx(5)
         *     - o listBox1_SelectedIndexChanged controla o que é enviado pra grpbx(7) e o que é armazenada na listbox, na richtextbox e na imagem da grpbx(6) 
         *     - posição também fica no r_bttn, e é a mesma do design
         * 'produção e elenco'
         *     - nome da grpbx(6) fica no radiobutton
         *     - posição da grpbx(6) fica no r_bttn
         *     - o listBox1_SelectedIndexChanged não controla o que é enviado pra grpbx(7), ja que nessa versão elas não estão relacionadas
         */

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Visible = false;
            button2.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            listBox2.Visible = false;

            groupBox2.Text = "Temporadas";
            groupBox3.Text = "Poster da temporada";
            groupBox4.Text = "Personagens";
            groupBox5.Text = "Episódios";

            comboBox1.Items.Clear();
            comboBox1.Items.Add("Temporada 1");
            comboBox1.Items.Add("Temporada 2");
            comboBox1.Items.Add("Temporada 3");
            comboBox1.Items.Add("Temporada 4");
            comboBox1.Items.Add("Temporada 5");
            comboBox1.Items.Add("Temporada 6");
            comboBox1.Items.Add("Temporada 7");
            comboBox1.Items.Add("Temporada 8");

            groupBox5.Location = new Point(60, 668);
            groupBox5.Size = new Size(1082, 306);
            groupBox6.Location = new Point(1178, 668);
            groupBox6.Size = new Size(475, 306);

            listBox1.Size = new Size(330, 196);

            groupBox7.Location = new Point(400, 42);
            groupBox7.Size = new Size(289, 167);
            richTextBox1.Location = new Point(1, 19);
            richTextBox1.Size = new Size(286, 144);

            pictureBox8.Location = new Point(710, 53);
            pictureBox8.Size = new Size(327, 172);

            label1.Location = new Point(706, 250);
            label1.Size = new Size(156, 24);

            //paciente

            richTextBox2.Location = new Point(35, 53);
            richTextBox2.Size = new Size(188, 127);
            groupBox8.Location = new Point(34, 36);
            groupBox8.Size = new Size(191, 149);

            pictureBox9.Location = new Point(295, 40);
            pictureBox9.Size = new Size(138, 196);

            label2.Location = new Point(230, 250);
            label2.Size = new Size(205, 24);

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //produção e elenco
            {
                groupBox2.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox7.Visible = true;
                listBox2.Visible = true;

                groupBox5.Location = new Point(60, 668);
                groupBox5.Size = new Size(772, 306);
                groupBox6.Location = new Point(881, 668);
                groupBox6.Size = new Size(772, 306);

                listBox1.Size = new Size(271, 196);

                groupBox7.Location = new Point(338, 40);
                groupBox7.Size = new Size(231, 156);
                richTextBox1.Location = new Point(1, 17);
                richTextBox1.Size = new Size(226, 133);

                pictureBox8.Location = new Point(590, 45);
                pictureBox8.Size = new Size(138, 196);

                label1.Location = new Point(572, 256);
                label1.Size = new Size(156, 24);

                //escritores

                listBox2.Location = new Point(37, 42);
                listBox2.Size = new Size(247, 148);

                richTextBox2.Location = new Point(335, 48);
                richTextBox2.Size = new Size(188, 127);
                groupBox8.Location = new Point(334, 31);
                groupBox8.Size = new Size(231, 165);

                pictureBox9.Location = new Point(599, 42);
                pictureBox9.Size = new Size(138, 196);

                label2.Location = new Point(534, 252);
                label2.Size = new Size(205, 24);

                groupBox2.Text = "Ano";
                groupBox3.Text = "Foto da equipe";
                groupBox4.Text = "Atores";
                groupBox5.Text = "Melhores escritores";
                groupBox6.Text = "Melhores diretores";

                comboBox1.Items.Clear();
                comboBox1.Items.Add("2004");
                comboBox1.Items.Add("2005");
                comboBox1.Items.Add("2006");
                comboBox1.Items.Add("2007");
                comboBox1.Items.Add("2008");
                comboBox1.Items.Add("2009");
                comboBox1.Items.Add("2010");
                comboBox1.Items.Add("2011");
                comboBox1.Items.Add("2012");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //escolha de temporadas
        {
            if (radioButton1.Checked == true) //temporadas e personagens
            {
                string temp;
                temp = comboBox1.Text;

                switch (temp)
                {
                    case "Temporada 1":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp1;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "Robert Chase";
                        checkBox3.Text = "Eric Foreman";
                        checkBox4.Text = "Alisson Cameron";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("Ep 1 - Todo Mundo Mente");
                        listBox1.Items.Add("Ep 2 - Paternidade");
                        listBox1.Items.Add("Ep 3 - O Princípio De Occam");
                        listBox1.Items.Add("Ep 4 - Maternidade");
                        listBox1.Items.Add("Ep 5 - Criticado de uma Forma ou de Outra");
                        listBox1.Items.Add("Ep 6 - O Método de Sócrates");
                        listBox1.Items.Add("Ep 7 - Fidelidade");
                        listBox1.Items.Add("Ep 8 - Veneno");
                        listBox1.Items.Add("Ep 9 - Me Deixe Morrer");
                        listBox1.Items.Add("Ep 10 - Históricos de Pacientes");
                        listBox1.Items.Add("Ep 11 - Desintoxicação");
                        listBox1.Items.Add("Ep 12 - Medicina Esportiva");
                        listBox1.Items.Add("Ep 13 - Amaldiçoado");
                        listBox1.Items.Add("Ep 14 - Controle");
                        listBox1.Items.Add("Ep 15 - Regras de Gangsters");
                        listBox1.Items.Add("Ep 16 - Gorda");
                        listBox1.Items.Add("Ep 17 - O Exemplo");
                        listBox1.Items.Add("Ep 18 - Bebês e Água Para Banho");
                        listBox1.Items.Add("Ep 19 - Crianças");
                        listBox1.Items.Add("Ep 20 - O Amor dói");
                        listBox1.Items.Add("Ep 21 - Três Histórias");
                        listBox1.Items.Add("Ep 22 - Lua de Mel");

                        break;

                    case "Temporada 2":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp2;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "Robert Chase";
                        checkBox3.Text = "Eric Foreman";
                        checkBox4.Text = "Alisson Cameron";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("Ep 1 - Aceitação");
                        listBox1.Items.Add("Ep 2 - Autópsia");
                        listBox1.Items.Add("Ep 3 - A Queda do Telhado");
                        listBox1.Items.Add("Ep 4 - Tuberculose");
                        listBox1.Items.Add("Ep 5 - O Garoto do Papai");
                        listBox1.Items.Add("Ep 6 - A Corrida");
                        listBox1.Items.Add("Ep 7 - A Caça");
                        listBox1.Items.Add("Ep 8 - O Erro");
                        listBox1.Items.Add("Ep 9 - A Decepção");
                        listBox1.Items.Add("Ep 10 - Falha de comunicação");
                        listBox1.Items.Add("Ep 11 - Preciso Saber");
                        listBox1.Items.Add("Ep 12 - Distrações");
                        listBox1.Items.Add("Ep 13 - Superficial");
                        listBox1.Items.Add("Ep 14 - O Sexo Mata");
                        listBox1.Items.Add("Ep 15 - Sem Pista");
                        listBox1.Items.Add("Ep 16 - Por Segurança");
                        listBox1.Items.Add("Ep 17 - Aposta Tudo");
                        listBox1.Items.Add("Ep 18 - Cachorro que Dorme Não Mente");
                        listBox1.Items.Add("Ep 19 - House VS Deus");
                        listBox1.Items.Add("Ep 20 - Euforia, Parte 1");
                        listBox1.Items.Add("Ep 21 - Euforia, Parte 2");
                        listBox1.Items.Add("Ep 22 - Para sempre");
                        listBox1.Items.Add("Ep 23 - Quem é o seu pai?");
                        listBox1.Items.Add("Ep 24 - Sem Motivo");

                        break;

                    case "Temporada 3":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp3;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "Robert Chase";
                        checkBox3.Text = "Eric Foreman";
                        checkBox4.Text = "Alisson Cameron";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("Ep 1 - O Significado das Coisas");
                        listBox1.Items.Add("Ep 2 - Com ou Sem Bengala");
                        listBox1.Items.Add("Ep 3 - Autorizações");
                        listBox1.Items.Add("Ep 4 - Rabiscos na Areia");
                        listBox1.Items.Add("Ep 5 - O Amor é Cego");
                        listBox1.Items.Add("Ep 6 - O Que Será, Será");
                        listBox1.Items.Add("Ep 7 - Filho do Sujeito em Coma");
                        listBox1.Items.Add("Ep 8 - O Irmão Mais Velho");
                        listBox1.Items.Add("Ep 9 - À Procura do Judas");
                        listBox1.Items.Add("Ep 10 - Feliz Natal");
                        listBox1.Items.Add("Ep 11 - Palavras e Ações");
                        listBox1.Items.Add("Ep 12 - Um Dia, Uma Sala");
                        listBox1.Items.Add("Ep 13 - Agulha Num Palheiro");
                        listBox1.Items.Add("Ep 14 - Insensível a Dor");
                        listBox1.Items.Add("Ep 15 - Meia Capacidade");
                        listBox1.Items.Add("Ep 16 - Confidencial");
                        listBox1.Items.Add("Ep 17 - Posição Fetal");
                        listBox1.Items.Add("Ep 18 - Transportados Pelo Ar");
                        listBox1.Items.Add("Ep 19 - Viver a Idade");
                        listBox1.Items.Add("Ep 20 - Treinamento");
                        listBox1.Items.Add("Ep 21 - Família ");
                        listBox1.Items.Add("Ep 22 - Resignação");
                        listBox1.Items.Add("Ep 23 - O Idiota");
                        listBox1.Items.Add("Ep 24 - Erro Humano");

                        break;

                    case "Temporada 4":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp4;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "Robert Chase";
                        checkBox3.Text = "Eric Foreman";
                        checkBox4.Text = "Alisson Cameron";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("Ep 1 - Sozinho");
                        listBox1.Items.Add("Ep 2 - A Coisa Certa");
                        listBox1.Items.Add("Ep 3 - 97 Segundos");
                        listBox1.Items.Add("Ep 4 - Anjos da Guarda");
                        listBox1.Items.Add("Ep 5 - Espelho, Espelho Meu");
                        listBox1.Items.Add("Ep 6 - O Que For Preciso");
                        listBox1.Items.Add("Ep 7 - Feio");
                        listBox1.Items.Add("Ep 8 - Você Não Quer Saber");
                        listBox1.Items.Add("Ep 9 - Jogos");
                        listBox1.Items.Add("Ep 10 - A Mentira Não Se Compra");
                        listBox1.Items.Add("Ep 11 - Congelada");
                        listBox1.Items.Add("Ep 12 - Não Mude Nunca");
                        listBox1.Items.Add("Ep 13 - Adeus Sr Bonzinho");
                        listBox1.Items.Add("Ep 14 - Vivendo o Sonho");
                        listBox1.Items.Add("Ep 15 - A Cabeça do House");
                        listBox1.Items.Add("Ep 16 - O Coração de Wilson");

                        break;

                    case "Temporada 5":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp5;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "Robert Chase";
                        checkBox3.Text = "Eric Foreman";
                        checkBox4.Text = "Alisson Cameron";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("Ep 1 - Morrer Muda Tudo");
                        listBox1.Items.Add("Ep 2 - Não é Câncer");
                        listBox1.Items.Add("Ep 3 - Eventos Adversos");
                        listBox1.Items.Add("Ep 4 - Marcas de nascença");
                        listBox1.Items.Add("Ep 5 - Sorte da Treze");
                        listBox1.Items.Add("Ep 6 - Alegria");
                        listBox1.Items.Add("Ep 7 - A Coceira");
                        listBox1.Items.Add("Ep 8 - Emancipação");
                        listBox1.Items.Add("Ep 9 - O Último Recurso");
                        listBox1.Items.Add("Ep 10 - Deixa Comer Bolo");
                        listBox1.Items.Add("Ep 11 - Alegria para o Mundo");
                        listBox1.Items.Add("Ep 12 - Sem Dor");
                        listBox1.Items.Add("Ep 13 - Bebê Enorme");
                        listBox1.Items.Add("Ep 14 - O Bem Maior");
                        listBox1.Items.Add("Ep 15 - Infiel");
                        listBox1.Items.Add("Ep 16 - O Lado Mais Suave");
                        listBox1.Items.Add("Ep 17 - O Contrato Social");
                        listBox1.Items.Add("Ep 18 - Vem Cá Bichano");
                        listBox1.Items.Add("Ep 19 - Encarcerado");
                        listBox1.Items.Add("Ep 20 - Explicação Simples");
                        listBox1.Items.Add("Ep 21 - Os Salvadores");
                        listBox1.Items.Add("Ep 22 - O House Dividido");
                        listBox1.Items.Add("Ep 23 - Embaixo da Minha Pele");
                        listBox1.Items.Add("Ep 23 - Agora os Dois Lados");

                        break;

                    case "Temporada 6":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp6;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "Robert Chase";
                        checkBox3.Text = "Eric Foreman";
                        checkBox4.Text = "Alisson Cameron";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("Ep 1.1 e 1.2 - Derrotado ");
                        listBox1.Items.Add("Ep 3 - O Grande Fiasco");
                        listBox1.Items.Add("Ep 4 - O Tirano");
                        listBox1.Items.Add("Ep 5 - Carma Urgente");
                        listBox1.Items.Add("Ep 6 - Coração Valente");
                        listBox1.Items.Add("Ep 7 - Verdades Não Ditas");
                        listBox1.Items.Add("Ep 8 - Trabalho em Equipe");
                        listBox1.Items.Add("Ep 9 - Santa Ignorância");
                        listBox1.Items.Add("Ep 10 - Wilson");
                        listBox1.Items.Add("Ep 11 - Segredos");
                        listBox1.Items.Add("Ep 12 - Remorso");
                        listBox1.Items.Add("Ep 13 - Família é Família");
                        listBox1.Items.Add("Ep 14 - Um Dia Daqueles");
                        listBox1.Items.Add("Ep 15 - Vidas Particulares");
                        listBox1.Items.Add("Ep 16 - Buraco Negro");
                        listBox1.Items.Add("Ep 17 - Trancado");
                        listBox1.Items.Add("Ep 18 - A Queda do Cavaleiro");
                        listBox1.Items.Add("Ep 19 - Aberto ou Fechado?");
                        listBox1.Items.Add("Ep 20 - Questão de Escolha");
                        listBox1.Items.Add("Ep 21 - Bagagem");
                        listBox1.Items.Add("Ep 22 - Me Ajude");

                        break;

                    case "Temporada 7":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp7;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "Robert Chase";
                        checkBox3.Text = "Eric Foreman";
                        checkBox4.Text = "Alisson Cameron";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("Ep 1 - E Agora?");
                        listBox1.Items.Add("Ep 2 - Egoísta");
                        listBox1.Items.Add("Ep 3 - Entrelinhas");
                        listBox1.Items.Add("Ep 4 - Massoterapia");
                        listBox1.Items.Add("Ep 5 - Paternidade Indesejada");
                        listBox1.Items.Add("Ep 6 - Politicagem");
                        listBox1.Items.Add("Ep 7 - Um Estranho Entre Nós");
                        listBox1.Items.Add("Ep 8 - Pequenos Sacrifícios");
                        listBox1.Items.Add("Ep 9 - Maior Que A Vida");
                        listBox1.Items.Add("Ep 10 - Atos e Consequências");
                        listBox1.Items.Add("Ep 11 - Médico de Família");
                        listBox1.Items.Add("Ep 12 - Você se Lembra?");
                        listBox1.Items.Add("Ep 13 - Duas Histórias");
                        listBox1.Items.Add("Ep 14 - À Prova de Recessão");
                        listBox1.Items.Add("Ep 15 - Bombas");
                        listBox1.Items.Add("Ep 16 - Fora do Curso");
                        listBox1.Items.Add("Ep 17 - A Queda do Homem");
                        listBox1.Items.Add("Ep 18 - Do Fundo do Baú");
                        listBox1.Items.Add("Ep 19 - A Última Tentação");
                        listBox1.Items.Add("Ep 20 - Mudanças");
                        listBox1.Items.Add("Ep 21 - Toma Lá, Dá Cá");
                        listBox1.Items.Add("Ep 22 - Pós-Expediente");
                        listBox1.Items.Add("Ep 23 - Seguindo em Frente");

                        break;

                    case "Temporada 8":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp8;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "Robert Chase";
                        checkBox3.Text = "Eric Foreman";
                        checkBox4.Text = "Alisson Cameron";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("Ep 1 - Vinte Vicodins");
                        listBox1.Items.Add("Ep 2 - Transplante");
                        listBox1.Items.Add("Ep 3 - Caso de Caridade");
                        listBox1.Items.Add("Ep 4 - Negócio Arriscado");
                        listBox1.Items.Add("Ep 5 - A Confissão");
                        listBox1.Items.Add("Ep 6 - Pais");
                        listBox1.Items.Add("Ep 7 - Morto e Enterrado");
                        listBox1.Items.Add("Ep 8 - Perigos da Paranóia");
                        listBox1.Items.Add("Ep 9 - Cara-Metade");
                        listBox1.Items.Add("Ep 10 - Fugitivos");
                        listBox1.Items.Add("Ep 11 - Culpa de Ninguém");
                        listBox1.Items.Add("Ep 12 - Chase");
                        listBox1.Items.Add("Ep 13 - O Homem da Casa");
                        listBox1.Items.Add("Ep 14 - O Amor é Cego");
                        listBox1.Items.Add("Ep 15 - Assoprando o Apito");
                        listBox1.Items.Add("Ep 16 - Verificação de Intestino");
                        listBox1.Items.Add("Ep 17 - Nós Precisamos dos Ovos");
                        listBox1.Items.Add("Ep 18 - Corpo e Alma");
                        listBox1.Items.Add("Ep 19 - A Palavra C");
                        listBox1.Items.Add("Ep 20 - Pós Morte");
                        listBox1.Items.Add("Ep 21 - Aguentando");
                        listBox1.Items.Add("Ep 22 - Todo Mundo Morre");

                        break;
                }

            }
            else //escolha de ano
            {
                string ano;
                ano = comboBox1.Text;

                switch (ano)
                {
                    case "2004":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = true;

                        checkBox1.Text = "Hugh Laurie";
                        checkBox2.Text = "Jesse Spencer";
                        checkBox3.Text = "Omar Epps";
                        checkBox4.Text = "Jessica Morisson";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("shurp");
                        listBox1.Items.Add("delurp");
                        listBox1.Items.Add("shurp delurp");
                        listBox1.Items.Add("Ep 7 - Fidelidade");
                        listBox1.Items.Add("Ep 10 - Históricos de Pacientes");
                        listBox1.Items.Add("Ep 11 - Desintoxicação");
                        listBox1.Items.Add("Ep 15 - Regras de Gangsters");
                        listBox1.Items.Add("Ep 16 - Gorda");
                        listBox1.Items.Add("Ep 18 -  Bebês e Água Para Banho");
                        listBox1.Items.Add("Ep 21 - Três Histórias");
                        listBox1.Items.Add("Ep 22 - Lua de Mel");

                        break;

                    case "2005":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = true;

                        checkBox1.Text = "Hugh Laurie";
                        checkBox2.Text = "Jesse Spencer";
                        checkBox3.Text = "Omar Epps";
                        checkBox4.Text = "Jessica Morisson";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("shurp");
                        listBox1.Items.Add("delurp");
                        listBox1.Items.Add("shurp delurp");
                        listBox1.Items.Add("Ep 7 - Fidelidade");
                        listBox1.Items.Add("Ep 10 - Históricos de Pacientes");
                        listBox1.Items.Add("Ep 11 - Desintoxicação");
                        listBox1.Items.Add("Ep 15 - Regras de Gangsters");
                        listBox1.Items.Add("Ep 16 - Gorda");
                        listBox1.Items.Add("Ep 18 -  Bebês e Água Para Banho");
                        listBox1.Items.Add("Ep 21 - Três Histórias");
                        listBox1.Items.Add("Ep 22 - Lua de Mel");

                        break;

                    case "2006":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = true;

                        checkBox1.Text = "Hugh Laurie";
                        checkBox2.Text = "Jesse Spencer";
                        checkBox3.Text = "Omar Epps";
                        checkBox4.Text = "Jessica Morisson";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("shurp");
                        listBox1.Items.Add("delurp");
                        listBox1.Items.Add("shurp delurp");
                        listBox1.Items.Add("Ep 7 - Fidelidade");
                        listBox1.Items.Add("Ep 10 - Históricos de Pacientes");
                        listBox1.Items.Add("Ep 11 - Desintoxicação");
                        listBox1.Items.Add("Ep 15 - Regras de Gangsters");
                        listBox1.Items.Add("Ep 16 - Gorda");
                        listBox1.Items.Add("Ep 18 -  Bebês e Água Para Banho");
                        listBox1.Items.Add("Ep 21 - Três Histórias");
                        listBox1.Items.Add("Ep 22 - Lua de Mel");

                        break;

                    case "2007":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = true;

                        checkBox1.Text = "Hugh Laurie";
                        checkBox2.Text = "Jesse Spencer";
                        checkBox3.Text = "Omar Epps";
                        checkBox4.Text = "Jessica Morisson";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("shurp");
                        listBox1.Items.Add("delurp");
                        listBox1.Items.Add("shurp delurp");
                        listBox1.Items.Add("Ep 7 - Fidelidade");
                        listBox1.Items.Add("Ep 10 - Históricos de Pacientes");
                        listBox1.Items.Add("Ep 11 - Desintoxicação");
                        listBox1.Items.Add("Ep 15 - Regras de Gangsters");
                        listBox1.Items.Add("Ep 16 - Gorda");
                        listBox1.Items.Add("Ep 18 -  Bebês e Água Para Banho");
                        listBox1.Items.Add("Ep 21 - Três Histórias");
                        listBox1.Items.Add("Ep 22 - Lua de Mel");

                        break;

                    case "2008":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = true;

                        checkBox1.Text = "Hugh Laurie";
                        checkBox2.Text = "Jesse Spencer";
                        checkBox3.Text = "Omar Epps";
                        checkBox4.Text = "Jessica Morisson";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("shurp");
                        listBox1.Items.Add("delurp");
                        listBox1.Items.Add("shurp delurp");
                        listBox1.Items.Add("Ep 7 - Fidelidade");
                        listBox1.Items.Add("Ep 10 - Históricos de Pacientes");
                        listBox1.Items.Add("Ep 11 - Desintoxicação");
                        listBox1.Items.Add("Ep 15 - Regras de Gangsters");
                        listBox1.Items.Add("Ep 16 - Gorda");
                        listBox1.Items.Add("Ep 18 -  Bebês e Água Para Banho");
                        listBox1.Items.Add("Ep 21 - Três Histórias");
                        listBox1.Items.Add("Ep 22 - Lua de Mel");

                        break;

                    case "2009":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = true;

                        checkBox1.Text = "Hugh Laurie";
                        checkBox2.Text = "Jesse Spencer";
                        checkBox3.Text = "Omar Epps";
                        checkBox4.Text = "Jessica Morisson";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("shurp");
                        listBox1.Items.Add("delurp");
                        listBox1.Items.Add("shurp delurp");
                        listBox1.Items.Add("Ep 7 - Fidelidade");
                        listBox1.Items.Add("Ep 10 - Históricos de Pacientes");
                        listBox1.Items.Add("Ep 11 - Desintoxicação");
                        listBox1.Items.Add("Ep 15 - Regras de Gangsters");
                        listBox1.Items.Add("Ep 16 - Gorda");
                        listBox1.Items.Add("Ep 18 -  Bebês e Água Para Banho");
                        listBox1.Items.Add("Ep 21 - Três Histórias");
                        listBox1.Items.Add("Ep 22 - Lua de Mel");

                        break;

                    case "2010":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = true;

                        checkBox1.Text = "Hugh Laurie";
                        checkBox2.Text = "Jesse Spencer";
                        checkBox3.Text = "Omar Epps";
                        checkBox4.Text = "Jessica Morisson";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("shurp");
                        listBox1.Items.Add("delurp");
                        listBox1.Items.Add("shurp delurp");
                        listBox1.Items.Add("Ep 7 - Fidelidade");
                        listBox1.Items.Add("Ep 10 - Históricos de Pacientes");
                        listBox1.Items.Add("Ep 11 - Desintoxicação");
                        listBox1.Items.Add("Ep 15 - Regras de Gangsters");
                        listBox1.Items.Add("Ep 16 - Gorda");
                        listBox1.Items.Add("Ep 18 -  Bebês e Água Para Banho");
                        listBox1.Items.Add("Ep 21 - Três Histórias");
                        listBox1.Items.Add("Ep 22 - Lua de Mel");

                        break;
                    case "2011":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = true;

                        checkBox1.Text = "Hugh Laurie";
                        checkBox2.Text = "Jesse Spencer";
                        checkBox3.Text = "Omar Epps";
                        checkBox4.Text = "Jessica Morisson";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("shurp");
                        listBox1.Items.Add("delurp");
                        listBox1.Items.Add("shurp delurp");
                        listBox1.Items.Add("Ep 7 - Fidelidade");
                        listBox1.Items.Add("Ep 10 - Históricos de Pacientes");
                        listBox1.Items.Add("Ep 11 - Desintoxicação");
                        listBox1.Items.Add("Ep 15 - Regras de Gangsters");
                        listBox1.Items.Add("Ep 16 - Gorda");
                        listBox1.Items.Add("Ep 18 -  Bebês e Água Para Banho");
                        listBox1.Items.Add("Ep 21 - Três Histórias");
                        listBox1.Items.Add("Ep 22 - Lua de Mel");

                        break;

                    case "2012":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = true;

                        checkBox1.Text = "Hugh Laurie";
                        checkBox2.Text = "Jesse Spencer";
                        checkBox3.Text = "Omar Epps";
                        checkBox4.Text = "Jessica Morisson";
                        checkBox5.Text = "Lisa Cuddy";
                        checkBox6.Text = "James Wilson";

                        listBox1.Items.Clear();
                        listBox1.Items.Add("shurp");
                        listBox1.Items.Add("delurp");
                        listBox1.Items.Add("shurp delurp");
                        listBox1.Items.Add("Ep 7 - Fidelidade");
                        listBox1.Items.Add("Ep 10 - Históricos de Pacientes");
                        listBox1.Items.Add("Ep 11 - Desintoxicação");
                        listBox1.Items.Add("Ep 15 - Regras de Gangsters");
                        listBox1.Items.Add("Ep 16 - Gorda");
                        listBox1.Items.Add("Ep 18 -  Bebês e Água Para Banho");
                        listBox1.Items.Add("Ep 21 - Três Histórias");
                        listBox1.Items.Add("Ep 22 - Lua de Mel");

                        break;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) //listbox de escolha dos episodios ou escritores e groupbox.Visible do pacientes
        {
            if (radioButton1.Checked == true) //episodios
            {
                groupBox6.Text = "Paciente";
                string eps;
                eps = listBox1.Text;

                switch (eps)
                {
                    case "Ep 1 - Todo Mundo Mente":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma professora de 29 anos não conseguiu pronunciar palavras direito e desmaia na sala de aula. É levada para o hospital Princeton-Plainsboro, onde o Dr. House e a sua equipe vão resolver a situação do doente";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 1 - Todo Mundo Mente";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Rebecca Adler foi a paciente do episódio Piloto. Ela foi interpretada pela atriz Robin Tunney. Adler é a primeira paciente que House e sua equipe trataram e curaram com sucesso na série.";

                        label2.Text = "Rebecca Adler";

                        break;

                    case "Ep 2 - Paternidade":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um jovem jogador de Lacrosse de 16 anos sofre de visão dupla e alucinações. Durante o tratamento, House sabe de partida que ele é adotado mas a situação complica-se quando é necessário saber o histórico médico da mãe biológica.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 2 - Paternidade";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Dan era o jogador de lacrosse do ensino médio no episódio Paternidade. Dan tinha um histórico recente de visão dupla de início súbito e terrores noturnos. Depois de não serem diagnosticados, seus pais contataram o Dr. House e marcaram uma consulta.";

                        label2.Text = "Dan";

                        break;


                    case "Ep 3 - O Princípio De Occam":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Dr. House e a sua equipe tentam encontrar a solução para o desmaio de um universitário após fazer sexo \"agressivo\" com sua namorada.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 3 - O Princípio De Occam";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Brandon Merrell foi o paciente do episódio O Princípio De Occam. Brandon foi levado ao pronto-socorro depois de desmaiar após fazer sexo. Sua namorada notou que antes de desmaiar ele estava reclamando de tosse e náusea e tinha uma erupção cutânea no abdômen.";

                        label2.Text = "Brandon Merrell";

                        break;


                    case "Ep 4 - Maternidade":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Na maternidade, alguns bebês são infectados por uma bactéria e começam a ter febre e convulsões. Para descobrir qual a doença e sua cura, House se vê obrigado a sacrificar um desses bebês e descobrir como eles foram infectados.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 4 - Maternidade";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Bebê Chen-Lupino nasceu com 9 meses, filho de duas lésbicas. O Dr. House estava vasculhando as maternidades em busca de sinais de epidemia e descobriu que o paciente acabara de desenvolver febre. Ele convenceu a Dra. Cuddy de que isso mostrava que uma infecção estava se espalhando pela maternidade.";

                        label2.Text = "Chen-Lupino";

                        break;


                    case "Ep 5 - Criticado de uma Forma ou de Outra":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Dr. House trata uma alergia de uma freira que estava com as mãos inchadas e pensava que isso que era um estigma, mas vê-se enganado quando ela quase morre.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 5 - Criticado de uma Forma ou de Outra";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Irmã Mary Augustine foi a paciente no episódio Criticado de uma Forma ou de Outra. A paciente chegou tarde à clínica e foi encaminhada ao Dr. House. A pele de suas mãos estava extremamente áspera e ela estava sangrando.";

                        label2.Text = "Irmã Mary Augustine";

                        break;


                    case "Ep 6 - O Método de Sócrates":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma mãe esquizofrénica aparece no hospital depois de ter uma trombose. Quando uma estranha chamada telefônica é feita a partir do quarto da paciente, House faz um outro diagnóstico sobre ela.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 6 - O Método de Sócrates";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Lucy Palmeiro é a paciente esquizofrênica do episódio O Método de Sócrates. Ela é interpretada pela atriz Stacy Edwards. A paciente foi diagnosticada com esquizofrenia há um ano e havia perdido o emprego como resultado da deterioração de sua condição. Ela morava com o filho jovem e recebia assistência social. Ela sofria de paranóia e alucinações auditivas.";

                        label2.Text = "Lucy Palmeiro";

                        break;


                    case "Ep 7 - Fidelidade":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um homem ao chegar em casa, encontra sua mulher dormindo e quando tenta acordá-la ela tem um ataque de raiva repentino. House e sua equipe acham que ela tem Doença do sono, mas não parecem haver evidências de ela ter contraído a doença.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 7 - Fidelidade";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Elise Snow é a paciente com hipersonia no episódio Fidelidade. Ela é interpretada pela atriz Myndy Crist. A paciente foi levada ao Hospital Universitário de Princeton-Plainsboro depois de ficar doente por três dias e não ter saído da cama. Quando o marido tentou acordá-la, ela o atacou com raiva e depois pediu desculpas e disse que devia ter algo errado com ela.";

                        label2.Text = "Elise Snow";

                        break;


                    case "Ep 8 - Veneno":
                        groupBox6.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe investigam um misterioso envenenamento no estudante do Ensino Médio Matt Davis, enquanto outro adolescente é trazido para o hospital com os mesmos sintomas, mas com quase nada em comum com Matt.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 8 - Veneno";

                        pictureBox9.Image = Properties.Resources.som_off;

                        label2.Text = "";

                        richTextBox2.Text = "Matt Davis foi um dos dois pacientes com uma doença inexplicável no episódio Veneno. Ele foi interpretado pelo ator John Patrick Amedori. Matt foi internado após desmaiar durante o exame de cálculo de colocação avançada. Ele descreveu estar enjoado e desorientado. Ele sofria de bradicardia grave – sua frequência cardíaca estava em 48 e caindo rapidamente. O Dr. Foreman levou o caso ao Dr. House. Chi Ling foi o segundo paciente a apresentar sintomas de intoxicação por organofosfatos no episódio Veneno. Ele foi interpretado pelo ator Ulysses Lee. Chi foi trazido com sintomas idênticos aos de Matt Davis, incluindo bradicardia grave. Sua frequência cardíaca era de 49 e suas estatísticas de O2 caíram para 84%.";

                        break;


                    case "Ep 9 - Me Deixe Morrer":
                        groupBox6.Visible = true;
                        button1.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando um lendário músico de jazz desmaia a meio de uma atuação, House e a sua equipe deparam-se com dificuldades técnicas em tratá-lo. Descobrem que este tem Esclerose lateral amiotrófica mas quando ele ordena que não lhe procedam os procedimentos de ressurreição, House desobedece e acaba em tribunal.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 9 - Me Deixe Morrer";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "John Henry Giles é o famoso trompetista de jazz que foi o paciente do episódio DNR. Ele foi interpretado pelo ator Harry J. Lennix. Giles foi diagnosticado com esclerose lateral amiotrófica e atualmente está confinado a uma cadeira de rodas porque está paralisado abaixo da cintura. Ele ficou deprimido ao perceber que o efeito progressivo da doença estava paralisando lentamente seu diafragma. Embora ele tenha dificuldade para respirar, sua condição o impediu de exercer o tipo de controle respiratório necessário para tocar trompete.";

                        label2.Text = "John Henry Giles";

                        break;


                    case "Ep 10 - Históricos de Pacientes":
                        groupBox6.Visible = true;
                        button1.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma sem-teto tem convulsões e é levada ao Hospital, os empregados do Hospital Princeton-Plainsboro e Foreman acham que ela está fingindo os ataques para conseguir uma refeição de graça e um lugar para dormir, porém Wilson insiste para que House se interesse pelo caso.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 10 - Históricos de Pacientes";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Victoria Madsen foi a paciente sem-teto do episódio Históricos de Pacientes. Ela é interpretada pela atriz Leslie Hope. A paciente foi internada como uma desconhecida após desmaiar durante uma briga com um policial. Ela não tinha identificação e parecia não lembrar seu nome. Suspeitou-se de overdose de drogas, mas seu exame toxicológico deu negativo.";

                        label2.Text = "Victoria Madsen";

                        break;


                    case "Ep 11 - Desintoxicação":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Cuddy aposta com House um mês de trabalho na clínica se este conseguir ficar sem Vicodin por uma semana enquanto tenta descobrir a razão de uma vítima de um acidente de automóvel não parar de sangrar.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 11 - Desintoxicação";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Pam era a namorada de Keith Foster no episódio Detox da 1ª temporada. Ela foi interpretada pela atriz Amanda Seyfried. Pam convenceu Keith a dar um passeio no carro que a falecida mãe de Keith comprou para seu pai. Ela sofreu um acidente depois de ver que Keith estava sangrando pelo nariz.";

                        label2.Text = "Pam";

                        break;


                    case "Ep 12 - Medicina Esportiva":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando a estrela do basebol Hank Wiggen de repente parte o braço, descobre que tem um caso bizarro de perda óssea. House sabe que o paciente tem histórico de uso de drogas e esteróides, porém o paciente pode estar escondendo algo a mais.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 12 - Medicina Esportiva";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Hank Wiggen é um famoso arremessador de beisebol que está saindo de uma suspensão por uso de drogas. Ele é o paciente do episódio Medicina Esportiva e é interpretado pelo ator Scott Foley. O paciente foi internado quando seu osso ulnar direito quebrou logo abaixo do ombro enquanto lançava uma bola de beisebol durante uma filmagem comercial.";

                        label2.Text = "Hank Wiggen";

                        break;


                    case "Ep 13 - Amaldiçoado":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Após consultar um tabuleiro de Ouija acerca da sua vida, um garoto pensa que vai morrer. O pai de Chase vai ao hospital encontrar-se com Wilson e ajudar House a diagnosticar o paciente.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 13 - Amaldiçoado";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Gabe Reilich é o jovem paciente do episódio Amaldiçoado. Ele é interpretado pelo ator Daryl Sabara. Gabe foi internado no hospital depois de sofrer de tosse, fadiga e febre por quase uma semana. Ele também estava com o peito congestionado e tossindo com catarro verde.";

                        label2.Text = "Gabe Reilich";

                        break;


                    case "Ep 14 - Controle":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma mulher de negócios é admitida no hospital após ter tido uma paralisia inexplicável e fortes dores em sua perna durante uma conferência. Descobre-se que ela tem tudo: vida perfeita, emprego perfeito e corpo perfeito. Enquanto isso, o bilionário Edward Vogler começa a financiar o hospital.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 14 - Controle";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Carly Forlano era a paciente CEO do episódio Controle. Ela foi interpretada pela atriz Sarah Clarke. Sem o conhecimento da equipe médica, Carly sofria de bulimia e tomava ipecacuanha, medicamento que provoca vômito, três vezes por semana. Porém, também fica claro que a paciente quase não tem tempo de lazer e trabalha quase sem parar enquanto está acordada. Sua mãe morreu de câncer de cólon. Ela corre muito para se exercitar.";

                        label2.Text = "";

                        break;


                    case "Ep 15 - Regras de Gangsters":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House trata um homem que é testemunha num caso relacionado com a máfia, cujo irmão mafioso avisa House para não lhe dê alta - nem o diagnóstico. Vogler e Cuddy continuam a discutir a importância de House no hospital.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 15 - Regras de Gangsters";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Joey Arnello foi o paciente no episódio Mob Rules da 1ª temporada. Ele é irmão de Bill Arnello. Ele foi interpretado pelo ator Joseph Lyle Taylor. Joey mascava chiclete de nicotina para se livrar do vício de fumar. Joey desmaiou depois de comer uma refeição e se levantou para ir ao banheiro. Ele não pôde ser reanimado pelos agentes federais que estavam com ele e foi internado em coma no Hospital Universitário Princeton-Plainsboro.";

                        label2.Text = "Joey Arnello";

                        break;


                    case "Ep 16 - Gorda":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House se esforça para descobrir porque uma garota obesa de dez anos teve um ataque cardíaco enquanto pulava corda. Vogler ordena que House demita um de sua equipe no prazo de uma semana.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 16 - Gorda";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Jessica Simms foi a paciente do episódio Heavy. Ela foi interpretada pela atriz Jennifer Stone. Jessica é gravemente obesa - bem no percentil 99º de peso para meninas de sua idade ou altura e pelo menos um desvio padrão acima do peso médio para sua faixa etária. Ela foi submetida a um regime rigoroso de dieta e exercícios, mas não perdeu peso, o que fez com que seu médico de cuidados primários chegasse à conclusão de que ela estava comendo demais. Jessica foi internada no Hospital Universitário de Princeton-Plainsboro após desmaiar durante um exercício orientado por seu professor de educação física.";

                        label2.Text = "Jessica Simms";

                        break;


                    case "Ep 17 - O Exemplo":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando um candidato presidencial adoece em campanha, House é forçado por Vogler a tomar conta do caso, além de ter que fazer um discurso sobre um novo remédio criado pela companhia de Vogler. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 17 - O Exemplo";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "Gary H. Wright foi o senador que concorreu à presidência no episódio O Exemplo. O personagem é vagamente baseado no então senador júnior dos EUA por Illinois, o ex-presidente Barack Obama. Gary teve convulsões devido à epilepsia infantil. Durante uma convulsão, ele mordeu a língua. No entanto, as convulsões cessaram quando ele tinha 6 anos e ele não tomava remédios desde os 10 anos. Ele não revelou sua epilepsia à equipe médica e explicou a cicatriz na língua como uma lesão infantil. Gary estava fazendo um discurso para uma grande multidão quando começou a sentir náusea e mal-estar.";

                        break;


                    case "Ep 18 - Bebês e Água Para Banho":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Vogler tenta demitir House, enquanto que House trata uma paciente grávida com disfunções do cérebro e dos rins, a paciente deve fazer a escolha mais importante de sua vida, onde ela tem que escolher entre a sua vida e a do bebê. Vogler vota com outros membros do conselho do hospital para ver se House continua ou não no hospital e Wilson é ameaçado a ser demitido por ser o único a votar contra House sair do hospital. Vogler acaba sendo supreso com a decisão final dos membros do conselho médico no final do episódio que teve uma reviravolta graças a intervenção da administradora chefe do hospital Lisa Cuddy em favor do Dr.House.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 18 - Bebês e Água Para Banho";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Naomi era a paciente grávida de Bebês e Água Para Banho. Quando ela tinha 18 anos, ela teve uma menina chamada Grace, que morreu da doença infantil de Alexander. Ela também abortou 3 vezes antes. No entanto, ela estava atualmente na 28ª semana de uma gravidez sem intercorrências. Naomi, que estava grávida de 28 semanas, estava levando o marido bêbado para casa. Enquanto conversavam sobre como seriam as coisas quando o bebê nascesse, Naomi desmaiou momentaneamente e eles evitaram por pouco um acidente de carro.";

                        label2.Text = "Naomi Randolph";

                        break;


                    case "Ep 19 - Crianças":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Durante o caos de uma epidemia de Meningite, House descobre uma paciente cujos sintomas não se relacionam com os da epidemia.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 19 - Crianças";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Mary Carroll foi a mergulhadora do episódio Kids. Ela foi interpretada pela atriz Skye McCole Bartusiak. Mary é uma mergulhadora competitiva. Ela tinha uma erupção na pele, que ela atribuiu ao seu novo maiô. Ela também tinha torcicolo. Mary chegou ao hospital junto com várias centenas de outras pessoas devido a um surto de meningite em uma competição de mergulho com a participação de 2.500 pessoas.";

                        label2.Text = "Mary Carroll";

                        break;


                    case "Ep 20 - O Amor dói":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Após os modos rudes de House terem assustado um homem, House tenta pedir desculpas e o homem acaba tendo um derrame. House marca um encontro com Cameron para que esta volta ao hospital.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 20 - O Amor dói";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Harvey Park é o paciente do episódio O Amor dói. Ele é interpretado pelo ator John Cho. O paciente sofreu uma fratura na mandíbula, necessitando de uma grande cirurgia reconstrutiva e, como resultado, tem uma placa de aço que mantém sua mandíbula unida. Ele frequentemente usa praticantes de medicina alternativa.";

                        label2.Text = "Harvey Park";

                        break;


                    case "Ep 21 - Três Histórias":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Cuddy força House a dar uma palestra para estudantes em que o tema é \"como diagnosticar\" um caso em que três pacientes têm fortes dores nas pernas.O episódio acaba revelando algumas coisas sobre o passado de House.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 21 - Três Histórias";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;


                    case "Ep 22 - Lua de Mel":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Depois de uma longa argumentação (e de drogar a sua bebida), Stacy consegue que o seu marido seja admitido no hospital para realizar uma bateria de testes que resultam negativos apesar de seus sintomas crescentes indicarem que está a morrer.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 22 - Lua de Mel";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Mark Warner foi um personagem recorrente em House, MD durante a primeira e a segunda temporada. Ele é marido da Conselheira Geral de Princeton-Plainsboro, Stacy Warner. Mark apareceu pela primeira vez no episódio Lua de Mel, quando Stacy pediu a House que investigasse sua dor abdominal e alterações de humor.";

                        label2.Text = "Mark Warner";

                        break;

                    case "Ep 1 - Aceitação":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um homem condenado à morte tem um ataque cardíaco após ter visões com as pessoas que matou, é aceito no hospital e House voluntaria-se para investigar, apesar das objeções da sua equipe.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 1 - Aceitação";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Clarence foi o presidiário do corredor da morte no episódio Aceitação. Ele foi interpretado pelo ator/rapper LL Cool J. Clarence cometeu quatro homicídios - ele assassinou sua namorada, um guarda penitenciário e dois de seus companheiros de prisão. Clarence era um preso no corredor da morte que começou a ter alucinações sobre as pessoas que matou durante seu período de exercício. Ele gritou para ser liberado do pátio de exercícios e depois caiu no chão.";

                        label2.Text = "Clarence";

                        break;

                    case "Ep 2 - Autópsia":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Wilson convence House a tratar uma menina com câncer terminal que teve alucinações. A menina se mostra bem mais madura e corajosa do que sua idade e ela decide enfrentar uma operação arriscada para conseguir mais algum tempo de vida. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 2 - Autópsia";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Andie era a paciente terminal com câncer no episódio Autopsy. Ela foi interpretada pela atriz Sasha Pieterse. Andie foi diagnosticada com rabdomiossarcoma alveolar, um câncer terminal. Ela passou por cinco grandes cirurgias, um transplante de medula óssea, quatorze rodadas de quimioterapia e radioterapia.";

                        label2.Text = "Andie";

                        break;

                    case "Ep 3 - A Queda do Telhado":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um telhador com asma cai inesperadamente do teto da casa da Dr.ª Cuddy.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 3 - A Queda do Telhado";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Alfredo é o faz-tudo latino-americano que caiu do telhado de Lisa Cuddy. Ele foi interpretado pelo ator Ignacio Serricchio. Alfredo sofria de asma que afetava sua respiração. Ele também tinha cicatrizes de obras. Alfredo estava consertando o telhado da Cuddy quando caiu. Ele já havia reclamado que sua asma estava piorando, mas a Dra. Cuddy pediu que ele concluísse o trabalho no telhado dela.";

                        label2.Text = "Alfredo";

                        break;

                    case "Ep 4 - Tuberculose":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um famoso médico adoece trabalhando na África e é então examinado por House. Todos acreditam que ele tenha tuberculose, menos House. A estranha relação desse médico doente com Cameron causa uma certa curiosidade em House.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 4 - Tuberculose";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Sebastian Charles é o famoso médico tuberculoso que se torna paciente no episódio 'Tuberculose'. Ele foi interpretado pelo ator Ron Livingston. O personagem está envolvido na obtenção de medicamentos para quem sofre de tuberculose na África e seu nome já foi citado diversas vezes como indicado ao Prêmio Nobel da Paz.";

                        label2.Text = "Sebastian Charles";

                        break;

                    case "Ep 5 - O Garoto do Papai":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um estudante recém formado em Princeton tem sérios espasmos e sente choques em sua coluna durante a festa de formatura. Enquanto isso, os pais de House resolvem aparecer.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 5 - O Garoto do Papai";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Carnell Hall é um recém-formado pela Universidade de Princeton que sofre de sensações inexplicáveis, semelhantes a choques elétricos no episódio Daddy's Boy. Ele é interpretado pelo ator Vicellous Shannon. Ao comemorar na noite anterior à cerimônia de formatura, Carnell sentiu sensações contínuas na parte inferior das costas, como um choque elétrico intenso e doloroso.";

                        label2.Text = "Carnell Hall";

                        break;

                    case "Ep 6 - A Corrida":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um conhecido ciclista é levado a House depois de desmaiar numa corrida. É surpreendentemente honesto acerca de vários medicamentos ilegais e técnicas que aplicou a si próprio, mas a sua doença não é causada por nenhum deles. Enquanto isso Cameron fica indignada pela falta de ética do ciclista.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 6 - A Corrida";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Jeff está em primeiro lugar em uma corrida beneficente de ciclismo quando de repente começa a ofegar, fica desorientado e cai da bicicleta.";

                        label2.Text = "Jeff Forrester";

                        break;

                    case "Ep 7 - A Caça":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House finalmente aceita tratar um vizinho gay com AIDS, que entra choque anafilático após trombar no carro de Wilson, acabando por descobrir que a sua doença pode ser mais do que aparenta. Então, Cameron fica perturbada pois pensa que foi infectada depois que o paciente tosse sangue na boca da médica.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 7 - A Caça";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Kalvin Ryan era o paciente com AIDS que apareceu no episódio Hunting. Kalvin contraiu HIV através de sexo anal desprotegido ou através do compartilhamento de agulhas. No entanto, ele está tomando antirretrovirais e sua contagem de células T está dentro dos limites. No entanto, ele continua a ter relações sexuais desprotegidas com outros homens seropositivos e usa regularmente drogas recreativas, como ecstasy e metanfetaminas.";

                        label2.Text = "Kalvin Ryan";

                        break;

                    case "Ep 8 - O Erro":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Após uma mulher com fortes dores gástricas morrer ao encargo de Chase, este e House têm de enfrentar um grupo de médicos para ouvir acerca dos seus destinos.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 8 - O Erro";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Kayla McGinley é a paciente de O Erro que morre devido à negligência de Chase. Ela é interpretada pela atriz Allison Smith.";

                        label2.Text = "Kayla McGinley";

                        break;

                    case "Ep 9 - A Decepção":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma mulher é admitida no hospital após um ataque epiléptico, enquanto todos pedem para que esta seja retirada do hospital quando se descobre que esta tem Síndrome de Munchausen; no entanto, House acha que ela tem uma doença escondida.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 9 - A Decepção";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Anica Jovanovich era a paciente com síndrome de Münchausen no episódio A Decepção. Ela foi interpretada pela atriz Cynthia Nixon.";

                        label2.Text = "Anica Jovanovich";

                        break;

                    case "Ep 10 - Falha de comunicação":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um famoso jornalista desmaia no escritório da empresa da sua revista. Apesar de agir normalmente depois de se levantar torna-se claro pela forma como baralha as palavras que sofre de afasia. Enquanto isso, House e Stacy exploram sua relação.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 10 - Falha de comunicação";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Fletcher foi diagnosticado como bipolar, mas não contou a ninguém. Seu transtorno bipolar o fez buscar excitação. Ele tomou topamax para tentar controlar, mas para tentar pará-lo completamente fez uma cingulotomia bilateral. Ele também tinha histórico de uso de pílulas para dormir e anfetaminas.";

                        label2.Text = "Fletcher Stone";

                        break;

                    case "Ep 11 - Preciso Saber":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e Stacy tentam reparar a sua relação, enquanto o resto da equipe tenta diagnosticar uma mulher com espasmos musculares e ataques de raiva constantes. Enquanto isso sai o resultado do exame de HIV de Cameron, mas esta tem medo de abri-lo.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 11 - Preciso Saber";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Margo Dalton é a ocupada mulher e mãe de carreira que desenvolve espasmos musculares incontroláveis ​​​​no episódio Need to Know. Ela é interpretada pela atriz Julie Warner. A paciente está tentando engravidar e toma medicamentos para fertilidade há treze meses.";

                        label2.Text = "Margo Dalton";

                        break;

                    case "Ep 12 - Distrações":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Surgem problemas logísticos quando House e a sua equipe não conseguem fazer todos os testes normais numa vítima de queimaduras.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 12 - Distrações";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Adam é o jovem paciente queimado no episódio Distrações. Ele foi interpretado pelo ator James Immekus. Adam sofreu queimaduras graves em mais de 40% de seu corpo em um acidente de quadriciclo. Ele foi levado às pressas de helicóptero para o Hospital Universitário Princeton-Plainsboro. Ele foi imediatamente colocado em ringer com lactato. Ele foi anestesiado para lidar com a dor das queimaduras durante o processo de recuperação e colocado em uma sala limpa para prevenir infecções.";

                        label2.Text = "Adam Kelvey";

                        break;

                    case "Ep 13 - Superficial":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Dr. House trata uma supermodelo com vício de heroína que tem um inesperado ataque de raiva e um desmaio num desfile e, no processo descobre segredos importantes sobre ela.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 13 - Superficial";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Alexandria Robinson era a paciente supermodelo em Skin Deep. Embora a paciente tivesse características sexuais secundárias bem desenvolvidas, ela ainda não havia começado a menstruar. Alex também era viciado em heroína.";

                        label2.Text = "Alexandria Robinson";

                        break;

                    case "Ep 14 - O Sexo Mata":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House tenta tratar um homem que tem uma convulsão de ausência, mas não percebe que este necessita de um coração novo. Quando o comitê de transplantes vota \"não\" a um coração novo, House tenta conseguir um de uma mulher morta cujos orgãos também foram rejeitados pelo comitê.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 14 - O Sexo Mata";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Henry Arrington, um aposentado de 65 anos com histórico de refluxo ácido, compareceu ao pronto-socorro acompanhado de sua filha de 20 anos após sofrer uma crise de ausência. Ele foi examinado por Eric Foreman, que o internou. O Dr. House foi designado como seu médico assistente quando a causa da convulsão não foi imediatamente aparente.";

                        label2.Text = "Henry Arrington";

                        break;

                    case "Ep 15 - Sem Pista":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando um homem começa a ter dificuldades em respirar, House acaba por ter de questionar as razões para o seu casamento. Enquanto isso, Wilson se muda para a casa de House devido as brigas em seu casamento e se torna vítima de várias brincadeirinhas.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 15 - Sem Pista";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Bob Palko é o paciente de Clueless que House suspeita ter sido envenenado por sua esposa aparentemente amorosa. Ele é interpretado pelo ator Eddie Mills.";

                        label2.Text = "Bob Palko";

                        break;

                    case "Ep 16 - Por Segurança":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House trata de uma adolescente que passou por um tratamento com forte medicação após um transplante de coração. Ela tem uma séria reação alérgica e entra em choque logo após a visita de seu namorado. Enquanto isso, House e Wilson enfrentam os problemas surgidos da convivência no mesmo apartamento.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 16 - Por Segurança";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Melinda Bardach foi a paciente do episódio Safe. Ela foi interpretada pela atriz Michelle Trachtenberg. Melinda tinha histórico de alergia grave a amendoim, picadas de abelha e penicilina. Enquanto seus pais estavam fora, ela sofreu uma reação alérgica grave e não tomou EpiPen. Ela decidiu tentar ir de carro até o hospital, mas no caminho ficou tonta e sofreu um acidente automobilístico. Ela sofreu um trauma grave no peito que resultou em parada cardíaca. Ela recebeu um transplante de coração e recebeu imunossupressores.  Seus pais montaram uma sala limpa em sua casa, recusaram-se a deixá-la sair e estabeleceram limites rígidos para visitantes.";

                        label2.Text = "Melinda Badarch";

                        break;
                    case "Ep 17 - Aposta Tudo":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um menino apresenta os mesmos sintomas de um paciente de House que morreu há anos. Assim, o médico acredita que pode prever o curso da doença do garoto. Enquanto isso, é organizada uma noite de poker em benefício do Departamento de Oncologia.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 17 - Aposta Tudo";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Ian Alston era o jovem paciente que sofria de diarreia com sangue que House estava convencido de que estava morrendo da mesma doença que matou outro paciente seu doze anos antes, no episódio All In. Ele foi interpretado pelo ator Carter Page.";

                        label2.Text = "Ian Alston";

                        break;

                    case "Ep 18 - Cachorro que Dorme Não Mente":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House corre contra o tempo para atender uma paciente que sofre de um caso fatal de insônia. Enquanto isso, Cameron se enfurece com Foreman, que roubou um artigo escrito pela médica.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 18 - Cachorro que Dorme Não Mente";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Hannah era a mulher que não dormia há dez dias no episódio Cachorro que Dorme Não Mente. Ela foi interpretada pela atriz Jayma Mays. Hannah havia recentemente tomado esteróides para hera venenosa e ibuprofeno para um joelho que machucou enquanto esquiava. Ela relatou que não dormia há dez dias. Hannah tomou um frasco inteiro de pílulas para dormir para tentar ajudá-la a dormir. Seu parceiro Max a encontrou no chão do banheiro, ainda consciente, e chamou uma ambulância. Eles foram levados ao pronto-socorro de Princeton-Plainsboro.";

                        label2.Text = "Hannah";

                        break;

                    case "Ep 19 - House VS Deus":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um curandeiro religioso adolescente aparece no hospital com um problema originalmente de fácil diagnóstico e durante a sua estada parece fazer encolher o tumor de um paciente com cancro. Wilson se sente rejeitado quando descobre que o médico participa de um jogo semanal de poker e House sente falta do amigo em sua casa.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 19 - House VS Deus";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Boyd foi o paciente curandeiro no episódio \"House vs. Deus\". Boyd tomou aspirina para dores de cabeça. Ele também bebeu muita água para se manter hidratado. Boyd estava dando um sermão quando seu abdômen ficou tenso, ele caiu de joelhos e disse ao pai que precisava de um médico. Como viaja muito, come muito fast food. Seu pai disse aos médicos que ele ouvia a palavra do Senhor desde os 10 anos.";

                        label2.Text = "Boyd";

                        break;

                    case "Ep 20 - Euforia, Parte 1":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um policial ferido à bala é atendido pela equipe e sofre de estranhos ataques de riso. House e seus companheiros ficam perplexos com o caso. Foreman começa a apresentar os mesmos sintomas, levando a equipe a acelerar a investigação sobre a causa da doença.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 20 - Euforia, Parte 1";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Joe Luria era o policial eufórico de Euphoria. Joe estava perseguindo um criminoso chamado \"Babyshoes\" quando não conseguiu controlar o riso. Babyshoes aproveitou a oportunidade para tentar atirar nele, mas a bala estilhaçou-se no colete à prova de balas de Joe, embora fragmentos da bala tenham atingido sua cabeça, jogando Joe no chão. Porém, depois disso, Joe continuou a rir.";

                        label2.Text = "Joe Luria";

                        break;

                    case "Ep 21 - Euforia, Parte 2":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Foreman continua a apresentar sintomas semelhantes aos de um policial internado no hospital, acometido por crises de riso. House acredita que a solução para a doença esteja no apartamento do agente de polícia. Tudo se complica mais quando Foreman infecta Cameron também, obrigando a médica a achar a solução do caso para salvar ambas as vidas. A médica não pega a doença.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 21 - Euforia, Parte 2";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "O Dr. Foreman esteve envolvido no tratamento de um paciente que primeiro exibiu euforia, depois cegueira que o paciente não conseguia perceber e depois uma dor tremenda. O Dr. Foreman foi o único médico que esteve no apartamento do paciente. House começou a ficar preocupado com seu comportamento quando o Dr. Cameron relatou comportamento pouco profissional em torno do paciente e o Dr. Foreman sorriu quando o Dr. House realizou um experimento atirando em um cadáver. Logo depois, o Dr. Foreman começou a rir quando o paciente ficou taquicárdico e começou a sangrar.";

                        label2.Text = "Dr. Eric Foreman";

                        break;
                    case "Ep 22 - Para sempre":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma jovem mãe sofre uma convulsão enquanto dá banho em seu filho recém-nascido e quase o afoga. House e sua equipe trabalham nos dois casos ao mesmo tempo: tentam salvar o bebê e descobrir a causa das convulsões da mãe.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 22 - Para Sempre";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Kara Mason foi a paciente do Forever. Ela foi interpretada pela atriz Hillary Tuck. O nome dela é provavelmente uma homenagem à personagem Cara Mason da saga de Terry Goodkind: A Espada da Verdade. A paciente havia dado à luz recentemente e estava cuidando de seu filho recém-nascido, Mikey. O marido de Kara encontrou Kara inconsciente em uma banheira cheia de água, e seu filho Mickey debaixo d'água e aparentemente sem respirar. Ele estava com eles apenas alguns momentos antes e ambos agiam normalmente.";

                        label2.Text = "Kara Mason";

                        break;

                    case "Ep 23 - Quem é o seu pai?":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um ex-companheiro da banda de House pede ao médico que atenda sua recém-descoberta filha de 16 anos. Vítima do furacão Katrina, a garota sofre de alucinações desde o desastre. Embora House tema que o amigo esteja sendo enganado, aceita trabalhar no caso.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 23 - Quem é o seu pai?";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Leona é a aparente filha biológica do velho amigo de House, Dylan Crandall, no episódio Quem é o seu pai?. Ela é neta do famoso pianista de jazz Jesse Baker. Ela é interpretada pela atriz Aasha Davis. Leona estava viajando de avião com Dylan quando de repente começou a ter alucinações de que o avião estava enchendo de água. Ela sofreu uma taquicardia extrema e desmaiou.";

                        label2.Text = "Leona";

                        break;

                    case "Ep 24 - Sem Motivo":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando um homem com a língua inchada é admitido no hospital, um homem misterioso atira em House, mas quando o caso é totalmente sem sentido, House tenta descobrir porque sua perna não dói.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 24 - Sem Motivo";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "---";

                        label2.Text = "Sem Paciente";

                        break;

                    case "Ep 1 - O Significado das Coisas":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House volta com a sua perna recuperada e completamente sem dor, e resolve tratar de dois pacientes simultaneamente: Richard, paralisado depois de uma operação de câncer no cérebro há oito anos, tenta se suicidar, e Caren, uma jovem mulher paralisada do pescoço para baixo depois de uma sessão de Yoga. Quando House começa a diagnosticar e tratar os seus pacientes, o time nota uma forma de tratamento diferente desde sua recuperação. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 1 - O Significado das Coisas";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Richard McNeil era o irlandês-americano paralisado que se tornou o paciente em O Significado das Coisas. Oito anos atrás (antes do episódio), Richard foi diagnosticado com câncer no cérebro. Foi realizada uma cirurgia para remover completamente o câncer, mas o deixou em estado vegetativo, incapaz de andar ou falar. Ele tem uma cadeira de rodas eletrônica, pois ainda tem algum controle sobre os dedos. Nos últimos oito anos ele teve 214 sintomas, muitos deles repetidos. Richard estava em uma reunião de família quando aparentemente dirigiu sua cadeira de rodas elétrica para dentro da piscina. Ele foi levado para o Hospital Universitário Princeton-Plainsboro.";

                        label2.Text = "Richard McNeil";

                        break;

                    case "Ep 2 - Com ou Sem Bengala":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House tem um dificil caso medico em que: um garoto de 7 anos, produto de uma fertilização in vitro, que alega ter um rastreador alienígena em seu pescoço, além de ser cobaia de experiências desses aliens. Quando descobre-se que ele realmente possuía um pino metálico no pescoço os pais dele começam a dar mais crédito ao que o filho fala. Enquanto isso, Cameron se choca quando descobre que Cuddy e Wilson estão mentindo para House sobre o diagnóstico do último caso do médico mal-humorado. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 2 - Com ou Sem Bengala";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Clancy Green é o jovem paciente que teve alucinações sobre abduções alienígenas no episódio Cane and Able. Ele é interpretado pelo ator Skyler Gisondo. Clancy foi o resultado de fertilização in vitro. Ele tomou todas as vacinas. Ele quebrou o osso ulnar direito quando tinha três anos, resultando no uso de um pino cirúrgico de titânio para manter os ossos do braço direito unidos. Ele teve catapora quando tinha cinco anos. Ele também tinha um histórico de fantasias de abdução alienígena. Clancy foi levado ao Hospital Universitário de Princeton-Plainsboro depois de ser encontrado inconsciente em seu gramado pela manhã, sangrando pelo reto.";

                        label2.Text = "Clancy Green";

                        break;

                    case "Ep 3 - Autorizações":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "O paciente de House, Ezra Powell (Participação especial de Joel Grey), um conhecido médico pesquisador que desmaia em seu laboratório. House não consegue diagnosticar o problema e o paciente pede para que o deixem morrer. Uma paciente começa a desenvolver uma paixonite por House. Além disso, o médico mal-humorado volta a sentir dores na perna e passa a usar a bengala novamente.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 3 - Autorizações";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Ezra Powell foi um personagem do episódio Autorizações. Ele era um cientista pesquisador de 71 anos que perdeu a consciência enquanto trabalhava em seu laboratório. Powell é retratado como um cientista famoso e prolífico que ajudou a desenvolver o protocolo para o teste de estresse e a linguagem diagnóstica padrão para dores no peito. Ele é interpretado pelo ator vencedor do Oscar Joel Gray.";

                        label2.Text = "Ezra Powell";

                        break;

                    case "Ep 4 - Rabiscos na Areia":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House assume o caso de um garoto autista, que grita aparentemente sem motivo. Contudo, após uma efusão pleural, House não sabe o que pensar. Cuddy ignora o pedido de House de deixar o antigo tapete no escritório dele, então ele começa a diagnosticar em outras salas, até na de Wilson. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 4 - Rabiscos na Areia";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Adam Kelvey é o jovem paciente autista do episódio Rabiscos na Areia. Ele é interpretado pelo ator Braeden Lemasters. O paciente foi diagnosticado com autismo e desde então seus pais deixaram o emprego para cuidar dele. Ele tem grandes necessidades de apoio, é incapaz de falar ou se comunicar e geralmente não responde a estímulos externos. ";

                        label2.Text = "Adam Kelvey";

                        break;

                    case "Ep 5 - O Amor é Cego":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma mulher é assaltada com o marido e começa a sofrer problemas respiratórios e dor no estômago. Durante o diagnóstico do problema, o marido também começa a desenvolver os mesmos sintomas que ela. Enquanto isso, um paciente da clínica causa problemas para House que podem ter sérias consequências.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 5 - O Amor é Cego";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Tracy é a jovem casada do episódio O Amor é Cego que de repente desenvolve um distúrbio respiratório. Ela é casada com seu namorado de infância, Jeremy. Ela é interpretada pela atriz Jurnee Smollett. Embora detida contra sua vontade por dois ladrões que ameaçaram estuprá-la e mantiveram seu marido sob a mira de uma arma, Tracy desmaiou repentinamente com dificuldades respiratórias em uma lanchonete quando os clientes estavam sendo assaltados.";

                        label2.Text = "Tracy";

                        break;

                    case "Ep 6 - O Que Será, Será":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A equipe passa por problemas logísticos para fazer exames em um paciente que pesa mais de 250 quilos devido a seu tamanho. Ao acordar de um coma, o homem se nega a fazer qualquer teste que tenha a ver com seu peso. Enquanto isso, House passa a noite na cadeia depois de ser preso pelo policial Tritter por diversas acusações.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 6 - O Que Será, Será";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "George é o paciente com obesidade mórbida do episódio Que Será Será. Ele foi interpretado pelo ator Pruitt Taylor Vince. O paciente é obeso mórbido. Ele pesava bem mais que o peso da maior balança do hospital, que chega a 350 libras. Com uma cintura de mais de 2,10 metros, estimava-se que ele pesava mais de 600 libras. O paciente foi encontrado inconsciente em um estado que simulava a morte em sua própria cama - ele não tinha pulso radial, batimentos cardíacos detectáveis, sua temperatura corporal estava próxima da temperatura ambiente do quarto, ele havia perdido o controle da bexiga, não estava respirando e seu as pupilas estavam fixas e dilatadas. ";

                        label2.Text = "";

                        break;

                    case "Ep 7 - Filho do Sujeito em Coma":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House decide acordar um paciente em coma para perguntar sobre o seu histórico familiar e o paciente decide passar seu último dia de vida com House e Wilson em outra cidade, longe do hospital. Seu filho pode ter uma doença genética e o pai é o único parente vivo. Enquanto isso, Michael Tritter se aproxima de Cameron, Chase e Foreman para tentar dividir a equipe. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 7 - Filho do Sujeito em Coma";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Kyle Wozniak é o personagem-título e paciente do episódio Filho do Sujeito em Coma. Seu pai é Gabriel Wozniak. Ele foi interpretado pelo ator Zeb Newman. O paciente tem uma história crônica de convulsões inexplicáveis. O Dr. House conhecia Kyle como um visitante da enfermaria de coma. Ele percebeu que Kyle sofria de acinetopsia intermitente, a incapacidade de ver objetos em movimento. Ao acender as luzes da sala, ele conseguiu induzir uma convulsão. Kyle foi internado.";

                        label2.Text = "Kyle Wozniak";

                        break;

                    case "Ep 8 - O Irmão Mais Velho":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando um orfão que toma conta de dois irmãos mais novos vomita incontrolavelmente e tem um ataque cardíaco enquanto trabalha numa festa de aniversário de crianças, House e a sua equipe descobrem uma série bizarra de sintomas e infecções. Enquanto isso, Tritter começa a dificultar a vida de Wilson impossibilitando-o de praticar medicina. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 8 - O Irmão Mais Velho";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Jack Walters é o paciente do episódio O Irmão Mais Velho que continua desenvolvendo novas infecções depois que as antigas são tratadas. Jack é o guardião legal de seus irmãos mais novos, Kama e Will. Ele é interpretado por Patrick Fugit, mais conhecido por interpretar William Miller, um jovem repórter da revista Rolling Stone em Quase Famosos, baseado no repórter adolescente da vida real Cameron Crowe. Jack foi levado ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro depois de vomitar e desmaiar no trabalho, apertando o peito. Os paramédicos tiveram que desfibrilá-lo em campo para estabilizar seu coração.";

                        label2.Text = "Jack Walters";

                        break;

                    case "Ep 9 - À Procura do Judas":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House cuida do caso de uma garota que foi diagnosticada com pancreatite. Os pais da menina não chegam a um consenso e o médico vai ao tribunal para conseguir permissão para tratar a paciente. Enquanto isso, Tritter continua sua estratégia para que House admita seu próprio uso de drogas. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 9 - À Procura do Judas";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Alice Hartman é a jovem paciente do episódio À procura do Judas. Ela é interpretada pela atriz Alyssa Shafer. Alice foi levada ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro por seu pai quando começou a sentir fortes dores abdominais enquanto visitava um parque de diversões.";

                        label2.Text = "Alice Hartman";

                        break;

                    case "Ep 10 - Feliz Natal":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Wilson propõe a House fazer um acordo com Tritter, mas o médico ranzinza recusa. Enquanto isso, Cuddy impede que House tome analgésicos e tira o doutor do caso dado para a equipe: uma menina anã de 15 anos que chegou ao hospital com anemia e um problema no pulmão. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 10 - Feliz Natal";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Abigail Ralphean é a paciente de baixa estatura do episódio Feliz Natal. Ela é interpretada pela atriz Kacie Borrowman. A paciente tem nanismo e hipoplasia capilar da cartilagem genética, herdada da mãe, que também tem a doença. Cuddy estava acompanhando Abigail após sua cirurgia para corrigir um colapso pulmonar. Abigail estava se recuperando bem. House apareceu para ver o Dr. Cuddy sobre um assunto pessoal e ficou intrigado com a cicatriz de Abigail e descobriu que era para corrigir o colapso do pulmão.";

                        label2.Text = "Abigail Ralphean";

                        break;

                    case "Ep 11 - Palavras e Ações":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House divide seu tempo entre o caso de um bombeiro que treme de frio descontroladamente, mesmo quando exposto ao fogo. Por causa de uma informação mal interpretada o paciente passar por uma cirurgia no cérebro. Enquanto isso, House enfrenta a reabilitação e o julgamento em que o doutor ranzinza é acusado de forjar prescrições médicas. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 11 - Palavras e Ações";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Derek Hoyt era o bombeiro que sofria de inúmeros problemas no episódio Palavras e Ações. Ele foi interpretado pelo ator Tory Kittles. Derek estava perto de um incêndio quando ficou desorientado e teve dificuldade para respirar. Sua parceira Amy o abordou antes que ele entrasse em um prédio em chamas.";

                        label2.Text = "Derek Hoyt";

                        break;

                    case "Ep 12 - Um Dia, Uma Sala":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House volta a usar o Vicodin depois do acontecimento com o Tritter. Cuddy faz uma aposta com House que diz que se ele não tocasse em um paciente ao diagnosticar ele ganharia 10 dólares. Quando House encontra Eve, que tem um DST e admite ter sido estuprada, ela recusa a ser tratado por outros médicos, admitindo somente o House. Enquanto isso, Cameron encontra um sem teto que é muito diferente dos outros. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 12 - Um Dia, Uma Sala";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Eve foi a vítima de estupro no episódio da 3ª temporada, One Day, One Room. Ela foi interpretada pela atriz Katheryn Winnick. No TV.com, a interpretação de Eve por Winnick foi escolhida por esmagadora maioria como o desempenho mais valioso do episódio, com 107 votos excelentes - 98 a mais que Hugh Laurie e um dos maiores totais de votos já registrados no site.  Eve veio à clínica pensando que tinha uma doença sexualmente transmissível. Ela viu o Dr. House, que foi banido para a clínica devido aos acontecimentos do episódio anterior. House pegou um esfregaço vaginal e enviou para teste. Algumas horas depois, os testes deram positivo para clamídia.";

                        label2.Text = "Eve";

                        break;

                    case "Ep 13 - Agulha Num Palheiro":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um rapaz de 16 anos é levado ao hospital com problemas respiratórios após um encontro com a namorada. House crê que este tem granulomatose de Wegener e em breve entra em confronto com os pais do rapaz cigano acerca do tratamento. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 13 - Agulha Num Palheiro";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Stevie Lipa é o paciente que sofre de dores extremas no torso no episódio Needle in a Haystack. Ele é interpretado pelo ator Jake Richardson. Enquanto beijava a namorada em seu carro, Stevie de repente começou a sofrer de parada respiratória. Sua namorada pediu ajuda e um policial próximo chamou uma ambulância para levá-lo às pressas ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro.";

                        label2.Text = "Stevie Lipa";

                        break;

                    case "Ep 14 - Insensível a Dor":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House tem um caso em que: Uma garota com uma incapacidade rara de sentir dor (Insensibilidade congênita à dor) tem um acidente de carro. Quando se lhe fazem testes começa a ter febre alta, delírios paranóicos e piora rapidamente. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 14 - Insensível a Dor";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Hannah Morgenthal é a paciente com CIPA no episódio Insensível a Dor. Ela é interpretada pela atriz Mika Boorem. Hannah se envolveu em um acidente automobilístico com sua mãe. Sua mãe ficou gravemente ferida, mas Hannah não perdeu a consciência e conseguiu ligar para o 911.";

                        label2.Text = "Hannah Morgenthal";

                        break;

                    case "Ep 15 - Meia Capacidade":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um músico autista com Savantismo e com o cérebro afetado tem convulsões apesar de estar medicado para as mesmas. Ao mesmo tempo todos ficam chocados por saber que o próprio House entrou em tratamento para câncer cerebral. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 15 - Meia Capacidade";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Patrick Obyedkov é o pianista sábio no episódio Meia Capacidade. Ele é interpretado pelo ator Dave Matthews. Patrick sofreu uma lesão cerebral traumática aos dez anos de idade. Embora suas faculdades mentais gerais tenham sido afetadas, ele começou a exibir grande talento musical, quando não exibia nenhum antes do acidente. Patrick foi levado ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro depois de sofrer uma forte dor de cabeça durante uma apresentação, durante a qual os dedos de sua mão esquerda ficaram contorcidos pela distonia. ";

                        label2.Text = "Patrick Obyedkov";

                        break;

                    case "Ep 16 - Confidencial":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House trata um fuzileiro americano vindo do Iraque, que tem sintomas consistentes com a Síndrome da Guerra do Golfo. Um sonho de House acerca do fuzileiro complica a sua gestão do caso. Enquanto isso Chase e Cameron transam frequente no trabalho, House desconfia. ";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 16 - Confidencial";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "John Kelley foi o paciente de Confidencial , um episódio da terceira temporada. Ele foi o paciente que House viu em um sonho imediatamente antes de obter seu arquivo no episódio. Ele é interpretado pelo ator Marc Blucas. O paciente era fuzileiro naval há 12 anos e estava estacionado no Iraque há dois anos. ";

                        label2.Text = "John Kelley";

                        break;

                    case "Ep 17 - Posição Fetal":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House trata uma fotógrafa grávida que teve um derrame cujo bebê pode matá-la. Cuddy se sensibiliza muito com o caso e participa do diagnóstico da mulher. Quando eles discutem sobre a vida do bebê, a mãe de recusa terminantemente a abortar e as coisas ficam difíceis quando ela piora.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 17 - Posição Fetal";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Emma Sloan é a fotógrafa grávida que sofre um derrame no episódio Posição Fetal. Ela é interpretada pela atriz Anne Elizabeth Ramsay. Emma foi levada ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro depois de sofrer um derrame durante uma sessão de fotos, que ela autodiagnosticou.";

                        label2.Text = "Emma Sloan";

                        break;

                    case "Ep 18 - Transportados Pelo Ar":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e Cuddy enfrentam uma doença subita que se alastra passageiros do avião de onde voltam de uma conferência em Singapura enquanto que Wilson e a equipe de House tratam uma mulher com convulsões.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 18 - Transportados Pelo Ar";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Fran é uma mulher que desmaia no meio de uma transação com uma prostituta no episódio Transportados Pelo Ar. Ela foi interpretada pela atriz Jenny O'Hara. Robin chamou uma ambulância e levou Fran ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro depois que Fran desmaiou em sua casa. Ela foi examinada pelo Dr. Wilson, que perguntou se ela havia sofrido traumatismo cranioencefálico. Ela negou que tivesse. No entanto, ele encontrou um adesivo de escopolamina em seu pescoço que Fran havia esquecido de remover.";

                        label2.Text = "Fran";

                        break;

                    case "Ep 19 - Viver a Idade":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma menina de 6 anos sofre de sintomas esperáveis em pessoas muito mais velhos. Tensões entre Cameron e Chase levam a que House lhes designam intencionalmente as mesmas tarefas, incluindo investigarem a casa da criança.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 19 - Viver a Idade";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Lucy é a menina de seis anos do episódio Viver a Idade. Ela foi interpretada pela atriz Bailee Madison. Ela é a irmã mais nova de Jasper. Há um ano, a mãe de Lucy morreu devido a complicações de um câncer no cérebro. Caso contrário, ela não teve problemas de saúde. Lucy foi levada ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro quando desmaiou na creche depois da escola com respiração acelerada.";

                        label2.Text = "Lucy";

                        break;

                    case "Ep 20 - Treinamento":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma co-artista perde a capacidade de tomar decisões, House e a sua equipe esforçam-se por encontrar a causa desse problema e o caso torna-se pessoal para Foreman.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 20 - Treinamento";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Lupe é a jovem que sofre de sintomas neurológicos no episódio Treinamento. Ela foi interpretada pela atriz Monique Gabriela Curnen. Lupe foi levada ao Hospital Universitário de Princeton-Plainsboro quando entrou em pânico depois de não conseguir escolher nenhuma carta em um jogo de monte de três cartas e desmaiou.";

                        label2.Text = "Lupe";

                        break;

                    case "Ep 21 - Família ":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A única hipótese de sobrevivência de um paciente de 14 anos com leucemia é um transplante de medula o seu irmão mais novo. Mas quando este fica doente, House e sua equipe tem de correr contra o tempo para salvar ambas as crianças.";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "Ep 21 - Família";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Matty é o jovem doador de medula óssea que desenvolve uma doença pouco antes de doar sua medula. Ele é o irmão mais novo de Nick, que recentemente recebeu tratamento de radiação para destruir a medula óssea restante, para que esteja pronto para o transplante. Nick sofre de leucemia. Matty é interpretado pelo ator Dabier. Matty estava se preparando para doar medula óssea a seu irmão mais velho, Nick, e Nick recebeu radioterapia para destruir sua medula óssea doente, em preparação para o tratamento. No entanto, quando a medula estava para ser extraída, Matty começou a espirrar.";

                        label2.Text = "Matty";

                        break;

                    case "Ep 22 - Resignação":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 23 - O Idiota":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 24 - Erro Humano":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 1 - Sozinho":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 2 - A Coisa Certa":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 3 - 97 Segundos":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 4 - Anjos da Guarda":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 5 - Espelho, Espelho Meu":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 6 - O Que For Preciso":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 7 - Feio":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 8 - Você Não Quer Saber":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 9 - Jogos":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 10 - A Mentira Não Se Compra":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 11 - Congelada":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 12 - Não Mude Nunca":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 13 - Adeus Sr Bonzinho":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 14 - Vivendo o Sonho":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 15 - A Cabeça do House":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 16 - O Coração de Wilson":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 1 - Morrer Muda Tudo":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 2 - Não é Câncer":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 3 - Eventos Adversos":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 4 - Marcas de nascença":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 5 - Sorte da Treze":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 6 - Alegria":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 7 - A Coceira":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 8 - Emancipação":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 9 - O Último Recurso":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 10 - Deixa Comer Bolo":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 11 - Alegria para o Mundo":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 12 - Sem Dor":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 13 - Bebê Enorme":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 14 - O Bem Maior":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 15 - Infiel":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 16 - O Lado Mais Suave":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 17 - O Contrato Social":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 18 - Vem Cá Bichano":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 19 - Encarcerado":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 20 - Explicação Simples":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 21 - Os Salvadores":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 22 - O House Dividido":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 23 - Embaixo da Minha Pele":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 24 - Agora os Dois Lados":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 1.1 e 1.2 - Derrotado ":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 3 - O Grande Fiasco":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 4 - O Tirano":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 5 - Carma Urgente":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 6 - Coração Valente":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 7 - Verdades Não Ditas":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 8 - Trabalho em Equipe":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 9 - Santa Ignorância":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 10 - Wilson":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 11 - Segredos":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 12 - Remorso":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 13 - Família é Família":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 14 - Um Dia Daqueles":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 15 - Vidas Particulares":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 16 - Buraco Negro":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 17 - Trancado":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 18 - A Queda do Cavaleiro":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 19 - Aberto ou Fechado?":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 20 - Questão de Escolha":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 21 - Bagagem":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 22 - Me Ajude":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 1 - E Agora?":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 2 - Egoísta":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 3 - Entrelinhas":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 4 - Massoterapia":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 5 - Paternidade Indesejada":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 6 - Politicagem":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 7 - Um Estranho Entre Nós":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 8 - Pequenos Sacrifícios":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 9 - Maior Que A Vida":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 10 - Atos e Consequências":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 11 - Médico de Família":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 12 - Você se Lembra?":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 13 - Duas Histórias":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 14 - À Prova de Recessão":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 15 - Bombas":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 16 - Fora do Curso":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 17 - A Queda do Homem":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 18 - Do Fundo do Baú":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 19 - A Última Tentação":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 20 - Mudanças":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 21 - Toma Lá, Dá Cá":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;
                    case "Ep 22 - Pós-Expediente":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 23 - Seguindo em Frente":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 1 - Vinte Vicodins":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 2 - Transplante":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 3 - Caso de Caridade":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 4 - Negócio Arriscado":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 5 - A Confissão":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 6 - Pais":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 7 - Morto e Enterrado":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 8 - Perigos da Paranóia":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 9 - Cara-Metade":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 10 - Fugitivos":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 11 - Culpa de Ninguém":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 12 - Chase":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 13 - O Homem da Casa":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 14 - O Amor é Cego":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 15 - Assoprando o Apito":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 16 - Verificação de Intestino":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 17 - Nós Precisamos dos Ovos":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 18 - Corpo e Alma":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 19 - A Palavra C":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 20 - Pós Morte":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 21 - Aguentando":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 22 - Todo Mundo Morre":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label1.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                }

            }
            else //escritores
            {
                string escr;
                escr = listBox1.Text;

                switch (escr)
                {
                    case "Ep 1 - Todo Mundo Mente":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label2.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                    case "Ep 2 - Paternidade":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label2.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;


                    case "Ep 3 - O Princípio De Occam":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label2.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;


                    case "Ep 4 - Maternidade":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label2.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;


                    case "Ep 5 - Criticado de uma Forma ou de Outra":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "";

                        pictureBox8.Image = Properties.Resources.som_off;

                        label2.Text = "";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;

                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            listBox2.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Ep 8 - Veneno")
            {
                pictureBox9.BackgroundImage = Properties.Resources.som_off;

                label2.Text = "Matt Davis";

            }
            else if (label1.Text == "Ep 21 - Três Histórias")
            {
                pictureBox9.BackgroundImage = Properties.Resources.som_off;

                label2.Text = "The Farmer";

                richTextBox2.Text = "O fazendeiro era um paciente sobre o qual House contou aos estudantes de medicina em Três Histórias. House não usou seu nome para proteger sua identidade. Ele é retratado durante a maior parte da narrativa por Brent Briscoe, mas ocasionalmente é retratado por Carmen Electra. O Dr. House estava dando uma palestra para um grupo de estudantes de medicina sobre três pacientes com dores nas pernas. Um deles era agricultor.";
            }
        }

        private bool button2WasClicked = false;
        private void button2_Click(object sender, EventArgs e)
        {
            button2WasClicked = true;

            int adicionador;

            for (adicionador = 0; adicionador < 4; adicionador++)
                if (button2WasClicked == true)
                {
                    adicionador = adicionador + 1;
                }

            if (adicionador == 0)
            {
                pictureBox9.BackgroundImage = Properties.Resources.som_off;
            }
            else if (adicionador == 1)
            {
                pictureBox9.BackgroundImage = Properties.Resources.som_off;
            }
            else if (adicionador == 2)
            {
                pictureBox9.BackgroundImage = Properties.Resources.som_off;
            }
            else
            {
                pictureBox9.BackgroundImage = Properties.Resources.som_off;
                adicionador = 0;
            }
            if (label1.Text == "Ep 8 - Veneno")
            {
                pictureBox9.BackgroundImage = Properties.Resources.som_off;

                label2.Text = "Chi Ling";

            }
            else if (label1.Text == "Ep 21 - Três Histórias")
            {
                pictureBox9.BackgroundImage = Properties.Resources.som_off;

                label2.Text = "The Farmer";

                richTextBox2.Text = "Jogador de Voleibol é um dos três estudos de caso do episódio Três Histórias. Durante a maior parte da narrativa, ela é interpretada pela atriz Andi Eystad, embora no início seja interpretada por Brent Briscoe, o ator que interpreta O Fazendeiro. A jogadora de vôlei foi levada ao pronto-socorro após cair durante o treino, reclamando de fortes dores na perna direita que a impediam de ficar em pé. Seu treinador achou que era uma distensão muscular.";
            }
        }
    }
}