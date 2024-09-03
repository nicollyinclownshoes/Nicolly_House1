 using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Nicolly_House1
{
    public partial class Form2 : Form
    {
        SoundPlayer _soundPlayer = new SoundPlayer(Properties.Resources.musica);
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
         *     - o bttn(1) e (2) são usados pra mudar a imagem quando se tem mais de um paciente
         * 'produção e elenco'
         *     - nome da grpbx(6) fica no radiobutton
         *     - posição da grpbx(6) fica no r_bttn
         *     - o listBox1_SelectedIndexChanged não controla o que é enviado pra grpbx(7), ja que nessa versão elas não estão relacionadas
         */
        private void Form2_Load(object sender, EventArgs e)
        {

            listBox2.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;

        }

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
                richTextBox2.Size = new Size(188, 142);
                groupBox8.Location = new Point(334, 31);
                groupBox8.Size = new Size(226, 165);

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
                comboBox1.Items.Add("2008");
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
                        button1.Visible = false;
                        button2.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp1;

                        pictureBox2.Image = Properties.Resources.som_off;
                        pictureBox3.Image = Properties.Resources.som_off;
                        pictureBox4.Image = Properties.Resources.som_off;
                        pictureBox5.Image = Properties.Resources.som_off;
                        pictureBox6.Image = Properties.Resources.som_off;
                        pictureBox7.Image = Properties.Resources.som_off;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "James Wilson";
                        checkBox3.Text = "Lisa Cuddy";
                        checkBox4.Text = "Alisson Cameron";
                        checkBox5.Text = "Robert Chase";
                        checkBox6.Text = "Eric Foreman";

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
                        button1.Visible = false;
                        button2.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp2;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "James Wilson";
                        checkBox3.Text = "Lisa Cuddy";
                        checkBox4.Text = "Robert Chase";
                        checkBox5.Text = "Eric Foreman";
                        checkBox6.Text = "Alisson Cameron";

                        pictureBox2.Image = Properties.Resources.som_off;
                        pictureBox3.Image = Properties.Resources.som_off;
                        pictureBox4.Image = Properties.Resources.som_off;
                        pictureBox5.Image = Properties.Resources.som_off;
                        pictureBox6.Image = Properties.Resources.som_off;
                        pictureBox7.Image = Properties.Resources.som_off;

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
                        button1.Visible = false;
                        button2.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp3;

                        pictureBox2.Image = Properties.Resources.som_off;
                        pictureBox3.Image = Properties.Resources.som_off;
                        pictureBox4.Image = Properties.Resources.som_off;
                        pictureBox5.Image = Properties.Resources.som_off;
                        pictureBox6.Image = Properties.Resources.som_off;
                        pictureBox7.Image = Properties.Resources.som_off;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "James Wilson";
                        checkBox3.Text = "Lisa Cuddy";
                        checkBox4.Text = "Alisson Cameron";
                        checkBox5.Text = "Robert Chase";
                        checkBox6.Text = "Eric Foreman";

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
                        button1.Visible = false;
                        button2.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp4;

                        pictureBox2.Image = Properties.Resources.som_off;
                        pictureBox3.Image = Properties.Resources.som_off;
                        pictureBox4.Image = Properties.Resources.som_off;
                        pictureBox5.Image = Properties.Resources.som_off;
                        pictureBox6.Image = Properties.Resources.som_off;
                        pictureBox7.Image = Properties.Resources.som_off;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "James Wilson";
                        checkBox3.Text = "Amber Volakis";
                        checkBox4.Text = "Chris Taub";
                        checkBox5.Text = "Lawrence Kutner";
                        checkBox6.Text = "Remy 'Thirteen' Hadley";

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
                        button1.Visible = false;
                        button2.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp5;

                        pictureBox2.Image = Properties.Resources.som_off;
                        pictureBox3.Image = Properties.Resources.som_off;
                        pictureBox4.Image = Properties.Resources.som_off;
                        pictureBox5.Image = Properties.Resources.som_off;
                        pictureBox6.Image = Properties.Resources.som_off;
                        pictureBox7.Image = Properties.Resources.som_off;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "James Wilson";
                        checkBox3.Text = "Lisa Cuddy";
                        checkBox4.Text = "Chris Taub";
                        checkBox5.Text = "Lawrence Kutner";
                        checkBox6.Text = "Remy 'Thirteen' Hadley";

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
                        button1.Visible = false;
                        button2.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp6;

                        pictureBox2.Image = Properties.Resources.som_off;
                        pictureBox3.Image = Properties.Resources.som_off;
                        pictureBox4.Image = Properties.Resources.som_off;
                        pictureBox5.Image = Properties.Resources.som_off;
                        pictureBox6.Image = Properties.Resources.som_off;
                        pictureBox7.Image = Properties.Resources.som_off;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "Juan 'Alvie' Alvarez";
                        checkBox3.Text = "Lisa Cuddy";
                        checkBox4.Text = "Alisson Cameron";
                        checkBox5.Text = "Robert Chase";
                        checkBox6.Text = "Eric Foreman";

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
                        button1.Visible = false;
                        button2.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp7;

                        pictureBox2.Image = Properties.Resources.som_off;
                        pictureBox3.Image = Properties.Resources.som_off;
                        pictureBox4.Image = Properties.Resources.som_off;
                        pictureBox5.Image = Properties.Resources.som_off;
                        pictureBox6.Image = Properties.Resources.som_off;
                        pictureBox7.Image = Properties.Resources.som_off;

                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "Martha Masters";
                        checkBox3.Text = "Lisa Cuddy";
                        checkBox4.Text = "Chris Taub";
                        checkBox5.Text = "Robert Chase";
                        checkBox6.Text = "Eric Foreman";

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
                        button1.Visible = false;
                        button2.Visible = false;

                        pictureBox1.Image = Properties.Resources.temp8;

                        pictureBox2.Image = Properties.Resources.som_off;
                        pictureBox3.Image = Properties.Resources.som_off;
                        pictureBox4.Image = Properties.Resources.som_off;
                        pictureBox5.Image = Properties.Resources.som_off;
                        pictureBox6.Image = Properties.Resources.som_off;
                        pictureBox7.Image = Properties.Resources.som_off;


                        checkBox1.Text = "Gregory House";
                        checkBox2.Text = "James Wilson";
                        checkBox3.Text = "Jessica Adams";
                        checkBox4.Text = "Chris Taub";
                        checkBox5.Text = "Chi Park";
                        checkBox6.Text = "Eric Foreman";

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
                        button1.Visible = false;
                        button2.Visible = false;

                        pictureBox1.Image = Properties.Resources.house_team_2004;

                        checkBox1.Text = "Hugh Laurie";
                        checkBox2.Text = "Robert Sean Leonard";
                        checkBox3.Text = "Lisa Edelstein";
                        checkBox4.Text = "Jessica Morisson";
                        checkBox5.Text = "Jesse Spencer";
                        checkBox6.Text = "Omar Epps";

                        listBox2.Items.Clear();
                        listBox2.Items.Add("Greg Yaitanes");
                        listBox2.Items.Add("Deran Sarafian");
                        listBox2.Items.Add("Daniel 'Dan' Attias");
                        listBox2.Items.Add("Daniel Sackheim ");
                        listBox2.Items.Add("Miguel Sapochnik");
                        listBox2.Items.Add("David Platt");
                        listBox2.Items.Add("Matt Shakman");
                        listBox2.Items.Add("Juan José Campanella");

                        listBox1.Items.Clear(); 
                        listBox1.Items.Add("David Shore");
                        listBox1.Items.Add("David Hoselton");
                        listBox1.Items.Add("Sara Hess");


                        break;

                    case "2008":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;
                        pictureBox1.Image = Properties.Resources.house_team_2008;

                        checkBox1.Text = "Hugh Laurie";
                        checkBox2.Text = "Lin Manuel Miranda";
                        checkBox3.Text = "Anne Dudek";
                        checkBox4.Text = "Peter Jacobson";
                        checkBox5.Text = "Kal Penn";
                        checkBox6.Text = "Olivia Wilde";

                        listBox2.Items.Clear();
                        listBox2.Items.Add("Greg Yaitanes");
                        listBox2.Items.Add("Deran Sarafian");
                        listBox2.Items.Add("Daniel 'Dan' Attias");
                        listBox2.Items.Add("Daniel Sackheim ");
                        listBox2.Items.Add("Miguel Sapochnik");
                        listBox2.Items.Add("David Platt");
                        listBox2.Items.Add("Matt Shakman");
                        listBox2.Items.Add("Juan José Campanella");

                        listBox1.Items.Clear();
                        listBox1.Items.Add("David Shore");
                        listBox1.Items.Add("David Hoselton");
                        listBox1.Items.Add("Sara Hess");

                        break;

                    case "2012":
                        groupBox3.Visible = true;
                        groupBox4.Visible = true;
                        groupBox5.Visible = true;
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;
                        pictureBox1.Image = Properties.Resources.house_team_2012;

                        checkBox1.Text = "Hugh Laurie";
                        checkBox2.Text = "Robert Sean Leonard";
                        checkBox3.Text = "Odette Anabelle";
                        checkBox4.Text = "Peter Jacobson";
                        checkBox5.Text = "Charlene Yi";
                        checkBox6.Text = "Omar Epps";
                      
                        listBox2.Items.Clear();
                        listBox2.Items.Add("Greg Yaitanes");
                        listBox2.Items.Add("Deran Sarafian");
                        listBox2.Items.Add("Daniel 'Dan' Attias");
                        listBox2.Items.Add("Daniel Sackheim ");
                        listBox2.Items.Add("Miguel Sapochnik");
                        listBox2.Items.Add("David Platt");
                        listBox2.Items.Add("Matt Shakman");
                        listBox1.Items.Add("Juan José Campanella");

                        listBox1.Items.Clear();
                        listBox1.Items.Add("David Shore");
                        listBox1.Items.Add("David Hoselton");
                        listBox1.Items.Add("Sara Hess");

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
                    //Temporada 1
                    case "Ep 1 - Todo Mundo Mente":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma professora de 29 anos não conseguiu pronunciar palavras direito e desmaia na sala de aula. É levada para o hospital Princeton-Plainsboro, onde o Dr. House e a sua equipe vão resolver a situação do doente";

                        pictureBox8.Image = Properties.Resources.ep1_thumbnail;

                        label1.Text = "Ep 1 - Todo Mundo Mente";

                        pictureBox9.Image = Properties.Resources.paciente_ep1_season1;

                        richTextBox2.Text = "Rebecca Adler foi a paciente do episódio Piloto. Ela foi interpretada pela atriz Robin Tunney. Adler é a primeira paciente que House e sua equipe trataram e curaram com sucesso na série.";

                        label2.Text = "Rebecca Adler";

                        break;

                    case "Ep 2 - Paternidade":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um jovem jogador de Lacrosse de 16 anos sofre de visão dupla e alucinações. Durante o tratamento, House sabe de partida que ele é adotado mas a situação complica-se quando é necessário saber o histórico médico da mãe biológica.";

                        pictureBox8.Image = Properties.Resources.ep2_thumbnail;

                        label1.Text = "Ep 2 - Paternidade";

                        pictureBox9.Image = Properties.Resources.paciente_ep2_season1;

                        richTextBox2.Text = "Dan era o jogador de lacrosse do ensino médio no episódio Paternidade. Dan tinha um histórico recente de visão dupla de início súbito e terrores noturnos. Depois de não serem diagnosticados, seus pais contataram o Dr. House e marcaram uma consulta.";

                        label2.Text = "Dan";

                        break;


                    case "Ep 3 - O Princípio De Occam":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Dr. House e a sua equipe tentam encontrar a solução para o desmaio de um universitário após fazer sexo \"agressivo\" com sua namorada.";

                        pictureBox8.Image = Properties.Resources.ep3_thumbnail;

                        label1.Text = "Ep 3 - O Princípio De Occam";

                        pictureBox9.Image = Properties.Resources.paciente_ep3_season1;

                        richTextBox2.Text = "Brandon Merrell foi o paciente do episódio O Princípio De Occam. Brandon foi levado ao pronto-socorro depois de desmaiar após fazer sexo. Sua namorada notou que antes de desmaiar ele estava reclamando de tosse e náusea e tinha uma erupção cutânea no abdômen.";

                        label2.Text = "Brandon Merrell";

                        break;


                    case "Ep 4 - Maternidade":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Na maternidade, alguns bebês são infectados por uma bactéria e começam a ter febre e convulsões. Para descobrir qual a doença e sua cura, House se vê obrigado a sacrificar um desses bebês e descobrir como eles foram infectados.";

                        pictureBox8.Image = Properties.Resources.ep4_thumbnail;

                        label1.Text = "Ep 4 - Maternidade";

                        pictureBox9.Image = Properties.Resources.paciente_ep4_season1;

                        richTextBox2.Text = "Bebê Chen-Lupino nasceu com 9 meses, filho de duas lésbicas. O Dr. House estava vasculhando as maternidades em busca de sinais de epidemia e descobriu que o paciente acabara de desenvolver febre. Ele convenceu a Dra. Cuddy de que isso mostrava que uma infecção estava se espalhando pela maternidade.";

                        label2.Text = "Chen-Lupino";

                        break;


                    case "Ep 5 - Criticado de uma Forma ou de Outra":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Dr. House trata uma alergia de uma freira que estava com as mãos inchadas e pensava que isso que era um estigma, mas vê-se enganado quando ela quase morre.";

                        pictureBox8.Image = Properties.Resources.ep5_thumbnail;

                        label1.Text = "Ep 5 - Criticado de uma Forma ou de Outra";

                        pictureBox9.Image = Properties.Resources.paciente_ep5_season1;

                        richTextBox2.Text = "Irmã Mary Augustine foi a paciente no episódio Criticado de uma Forma ou de Outra. A paciente chegou tarde à clínica e foi encaminhada ao Dr. House. A pele de suas mãos estava extremamente áspera e ela estava sangrando.";

                        label2.Text = "Irmã Mary Augustine";

                        break;


                    case "Ep 6 - O Método de Sócrates":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma mãe esquizofrénica aparece no hospital depois de ter uma trombose. Quando uma estranha chamada telefônica é feita a partir do quarto da paciente, House faz um outro diagnóstico sobre ela.";

                        pictureBox8.Image = Properties.Resources.ep6_thumbnail;

                        label1.Text = "Ep 6 - O Método de Sócrates";

                        pictureBox9.Image = Properties.Resources.paciente_ep6_season1;

                        richTextBox2.Text = "Lucy Palmeiro é a paciente esquizofrênica do episódio O Método de Sócrates. Ela é interpretada pela atriz Stacy Edwards. A paciente foi diagnosticada com esquizofrenia há um ano e havia perdido o emprego como resultado da deterioração de sua condição. Ela morava com o filho jovem e recebia assistência social. Ela sofria de paranóia e alucinações auditivas.";

                        label2.Text = "Lucy Palmeiro";

                        break;


                    case "Ep 7 - Fidelidade":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um homem ao chegar em casa, encontra sua mulher dormindo e quando tenta acordá-la ela tem um ataque de raiva repentino. House e sua equipe acham que ela tem Doença do sono, mas não parecem haver evidências de ela ter contraído a doença.";

                        pictureBox8.Image = Properties.Resources.ep7_thumbnail;

                        label1.Text = "Ep 7 - Fidelidade";

                        pictureBox9.Image = Properties.Resources.paciente_ep7_season1;

                        richTextBox2.Text = "Elise Snow é a paciente com hipersonia no episódio Fidelidade. Ela é interpretada pela atriz Myndy Crist. A paciente foi levada ao Hospital Universitário de Princeton-Plainsboro depois de ficar doente por três dias e não ter saído da cama. Quando o marido tentou acordá-la, ela o atacou com raiva e depois pediu desculpas e disse que devia ter algo errado com ela.";

                        label2.Text = "Elise Snow";

                        break;


                    case "Ep 8 - Veneno":
                        groupBox6.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe investigam um misterioso envenenamento no estudante do Ensino Médio Matt Davis, enquanto outro adolescente é trazido para o hospital com os mesmos sintomas, mas com quase nada em comum com Matt.";

                        pictureBox8.Image = Properties.Resources.ep8_thumbnail;

                        label1.Text = "Ep 8 - Veneno"; 

                        pictureBox9.Image = Properties.Resources.paciente_ep8_season1;

                        label2.Text = "";

                        richTextBox2.Text = "Matt Davis foi um dos dois pacientes com uma doença inexplicável no episódio Veneno. Ele foi interpretado pelo ator John Patrick Amedori. Matt foi internado após desmaiar durante o exame de cálculo de colocação avançada. Ele descreveu estar enjoado e desorientado. Ele sofria de bradicardia grave – sua frequência cardíaca estava em 48 e caindo rapidamente. O Dr. Foreman levou o caso ao Dr. House. Chi Ling foi o segundo paciente a apresentar sintomas de intoxicação por organofosfatos no episódio Veneno. Ele foi interpretado pelo ator Ulysses Lee. Chi foi trazido com sintomas idênticos aos de Matt Davis, incluindo bradicardia grave. Sua frequência cardíaca era de 49 e suas estatísticas de O2 caíram para 84%.";

                        break;


                    case "Ep 9 - Me Deixe Morrer":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;
                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando um lendário músico de jazz desmaia a meio de uma atuação, House e a sua equipe deparam-se com dificuldades técnicas em tratá-lo. Descobrem que este tem Esclerose lateral amiotrófica mas quando ele ordena que não lhe procedam os procedimentos de ressurreição, House desobedece e acaba em tribunal.";

                        pictureBox8.Image = Properties.Resources.ep9_thumbnail;

                        label1.Text = "Ep 9 - Me Deixe Morrer";

                        pictureBox9.Image = Properties.Resources.paciente_ep9_season1;

                        richTextBox2.Text = "John Henry Giles é o famoso trompetista de jazz que foi o paciente do episódio DNR. Ele foi interpretado pelo ator Harry J. Lennix. Giles foi diagnosticado com esclerose lateral amiotrófica e atualmente está confinado a uma cadeira de rodas porque está paralisado abaixo da cintura. Ele ficou deprimido ao perceber que o efeito progressivo da doença estava paralisando lentamente seu diafragma. Embora ele tenha dificuldade para respirar, sua condição o impediu de exercer o tipo de controle respiratório necessário para tocar trompete.";

                        label2.Text = "John Henry Giles";

                        break;


                    case "Ep 10 - Históricos de Pacientes":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma sem-teto tem convulsões e é levada ao Hospital, os empregados do Hospital Princeton-Plainsboro e Foreman acham que ela está fingindo os ataques para conseguir uma refeição de graça e um lugar para dormir, porém Wilson insiste para que House se interesse pelo caso.";

                        pictureBox8.Image = Properties.Resources.ep10_thumbnail;

                        label1.Text = "Ep 10 - Históricos de Pacientes";

                        pictureBox9.Image = Properties.Resources.paciente_ep10_season1;

                        richTextBox2.Text = "Victoria Madsen foi a paciente sem-teto do episódio Históricos de Pacientes. Ela é interpretada pela atriz Leslie Hope. A paciente foi internada como uma desconhecida após desmaiar durante uma briga com um policial. Ela não tinha identificação e parecia não lembrar seu nome. Suspeitou-se de overdose de drogas, mas seu exame toxicológico deu negativo.";

                        label2.Text = "Victoria Madsen";

                        break;


                    case "Ep 11 - Desintoxicação":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Cuddy aposta com House um mês de trabalho na clínica se este conseguir ficar sem Vicodin por uma semana enquanto tenta descobrir a razão de uma vítima de um acidente de automóvel não parar de sangrar.";

                        pictureBox8.Image = Properties.Resources.ep11_thumbnail;

                        label1.Text = "Ep 11 - Desintoxicação";

                        pictureBox9.Image = Properties.Resources.paciente_ep11_season1;

                        richTextBox2.Text = "Pam era a namorada de Keith Foster no episódio Detox da 1ª temporada. Ela foi interpretada pela atriz Amanda Seyfried. Pam convenceu Keith a dar um passeio no carro que a falecida mãe de Keith comprou para seu pai. Ela sofreu um acidente depois de ver que Keith estava sangrando pelo nariz.";

                        label2.Text = "Pam";

                        break;


                    case "Ep 12 - Medicina Esportiva":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando a estrela do basebol Hank Wiggen de repente parte o braço, descobre que tem um caso bizarro de perda óssea. House sabe que o paciente tem histórico de uso de drogas e esteróides, porém o paciente pode estar escondendo algo a mais.";

                        pictureBox8.Image = Properties.Resources.ep12_thumbnail;

                        label1.Text = "Ep 12 - Medicina Esportiva";

                        pictureBox9.Image = Properties.Resources.paciente_ep12_season1;

                        richTextBox2.Text = "Hank Wiggen é um famoso arremessador de beisebol que está saindo de uma suspensão por uso de drogas. Ele é o paciente do episódio Medicina Esportiva e é interpretado pelo ator Scott Foley. O paciente foi internado quando seu osso ulnar direito quebrou logo abaixo do ombro enquanto lançava uma bola de beisebol durante uma filmagem comercial.";

                        label2.Text = "Hank Wiggen";

                        break;


                    case "Ep 13 - Amaldiçoado":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Após consultar um tabuleiro de Ouija acerca da sua vida, um garoto pensa que vai morrer. O pai de Chase vai ao hospital encontrar-se com Wilson e ajudar House a diagnosticar o paciente.";

                        pictureBox8.Image = Properties.Resources.ep13_thumbnail;

                        label1.Text = "Ep 13 - Amaldiçoado";

                        pictureBox9.Image = Properties.Resources.paciente_ep13_season1;

                        richTextBox2.Text = "Gabe Reilich é o jovem paciente do episódio Amaldiçoado. Ele é interpretado pelo ator Daryl Sabara. Gabe foi internado no hospital depois de sofrer de tosse, fadiga e febre por quase uma semana. Ele também estava com o peito congestionado e tossindo com catarro verde.";

                        label2.Text = "Gabe Reilich";

                        break;


                    case "Ep 14 - Controle":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma mulher de negócios é admitida no hospital após ter tido uma paralisia inexplicável e fortes dores em sua perna durante uma conferência. Descobre-se que ela tem tudo: vida perfeita, emprego perfeito e corpo perfeito. Enquanto isso, o bilionário Edward Vogler começa a financiar o hospital.";

                        pictureBox8.Image = Properties.Resources.ep14_thumbnail;

                        label1.Text = "Ep 14 - Controle";

                        pictureBox9.Image = Properties.Resources.paciente_ep14_season1;

                        richTextBox2.Text = "Carly Forlano era a paciente CEO do episódio Controle. Ela foi interpretada pela atriz Sarah Clarke. Sem o conhecimento da equipe médica, Carly sofria de bulimia e tomava ipecacuanha, medicamento que provoca vômito, três vezes por semana. Porém, também fica claro que a paciente quase não tem tempo de lazer e trabalha quase sem parar enquanto está acordada. Sua mãe morreu de câncer de cólon. Ela corre muito para se exercitar.";

                        label2.Text = "";

                        break;


                    case "Ep 15 - Regras de Gangsters":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House trata um homem que é testemunha num caso relacionado com a máfia, cujo irmão mafioso avisa House para não lhe dê alta - nem o diagnóstico. Vogler e Cuddy continuam a discutir a importância de House no hospital.";

                        pictureBox8.Image = Properties.Resources.ep15_thumbnail;

                        label1.Text = "Ep 15 - Regras de Gangsters";

                        pictureBox9.Image = Properties.Resources.paciente_ep15_season1;

                        richTextBox2.Text = "Joey Arnello foi o paciente no episódio Mob Rules da 1ª temporada. Ele é irmão de Bill Arnello. Ele foi interpretado pelo ator Joseph Lyle Taylor. Joey mascava chiclete de nicotina para se livrar do vício de fumar. Joey desmaiou depois de comer uma refeição e se levantou para ir ao banheiro. Ele não pôde ser reanimado pelos agentes federais que estavam com ele e foi internado em coma no Hospital Universitário Princeton-Plainsboro.";

                        label2.Text = "Joey Arnello";

                        break;


                    case "Ep 16 - Gorda":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House se esforça para descobrir porque uma garota obesa de dez anos teve um ataque cardíaco enquanto pulava corda. Vogler ordena que House demita um de sua equipe no prazo de uma semana.";

                        pictureBox8.Image = Properties.Resources.ep16_thumbnail;

                        label1.Text = "Ep 16 - Gorda";

                        pictureBox9.Image = Properties.Resources.paciente_ep16_season1;

                        richTextBox2.Text = "Jessica Simms foi a paciente do episódio Heavy. Ela foi interpretada pela atriz Jennifer Stone. Jessica é gravemente obesa - bem no percentil 99º de peso para meninas de sua idade ou altura e pelo menos um desvio padrão acima do peso médio para sua faixa etária. Ela foi submetida a um regime rigoroso de dieta e exercícios, mas não perdeu peso, o que fez com que seu médico de cuidados primários chegasse à conclusão de que ela estava comendo demais. Jessica foi internada no Hospital Universitário de Princeton-Plainsboro após desmaiar durante um exercício orientado por seu professor de educação física.";

                        label2.Text = "Jessica Simms";

                        break;


                    case "Ep 17 - O Exemplo":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando um candidato presidencial adoece em campanha, House é forçado por Vogler a tomar conta do caso, além de ter que fazer um discurso sobre um novo remédio criado pela companhia de Vogler. ";

                        pictureBox8.Image = Properties.Resources.ep17_thumbnail;

                        label1.Text = "Ep 17 - O Exemplo";

                        pictureBox9.Image = Properties.Resources.paciente_ep17_season1;

                        richTextBox2.Text = "Gary H. Wright foi o senador que concorreu à presidência no episódio O Exemplo. O personagem é vagamente baseado no então senador júnior dos EUA por Illinois, o ex-presidente Barack Obama. Gary teve convulsões devido à epilepsia infantil. Durante uma convulsão, ele mordeu a língua. No entanto, as convulsões cessaram quando ele tinha 6 anos e ele não tomava remédios desde os 10 anos. Ele não revelou sua epilepsia à equipe médica e explicou a cicatriz na língua como uma lesão infantil. Gary estava fazendo um discurso para uma grande multidão quando começou a sentir náusea e mal-estar.";

                        label2.Text = "Gary H. Wright";

                        break;


                    case "Ep 18 - Bebês e Água Para Banho":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Vogler tenta demitir House, enquanto que House trata uma paciente grávida com disfunções do cérebro e dos rins, a paciente deve fazer a escolha mais importante de sua vida, onde ela tem que escolher entre a sua vida e a do bebê. Vogler vota com outros membros do conselho do hospital para ver se House continua ou não no hospital e Wilson é ameaçado a ser demitido por ser o único a votar contra House sair do hospital. Vogler acaba sendo supreso com a decisão final dos membros do conselho médico no final do episódio que teve uma reviravolta graças a intervenção da administradora chefe do hospital Lisa Cuddy em favor do Dr.House.";

                        pictureBox8.Image = Properties.Resources.ep18_thumbnail;

                        label1.Text = "Ep 18 - Bebês e Água Para Banho";

                        pictureBox9.Image = Properties.Resources.paciente_ep18_season1;

                        richTextBox2.Text = "Naomi era a paciente grávida de Bebês e Água Para Banho. Quando ela tinha 18 anos, ela teve uma menina chamada Grace, que morreu da doença infantil de Alexander. Ela também abortou 3 vezes antes. No entanto, ela estava atualmente na 28ª semana de uma gravidez sem intercorrências. Naomi, que estava grávida de 28 semanas, estava levando o marido bêbado para casa. Enquanto conversavam sobre como seriam as coisas quando o bebê nascesse, Naomi desmaiou momentaneamente e eles evitaram por pouco um acidente de carro.";

                        label2.Text = "Naomi Randolph";

                        break;


                    case "Ep 19 - Crianças":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Durante o caos de uma epidemia de Meningite, House descobre uma paciente cujos sintomas não se relacionam com os da epidemia.";

                        pictureBox8.Image = Properties.Resources.ep19_thumbnail;

                        label1.Text = "Ep 19 - Crianças";

                        pictureBox9.Image = Properties.Resources.paciente_ep19_season1;

                        richTextBox2.Text = "Mary Carroll foi a mergulhadora do episódio Kids. Ela foi interpretada pela atriz Skye McCole Bartusiak. Mary é uma mergulhadora competitiva. Ela tinha uma erupção na pele, que ela atribuiu ao seu novo maiô. Ela também tinha torcicolo. Mary chegou ao hospital junto com várias centenas de outras pessoas devido a um surto de meningite em uma competição de mergulho com a participação de 2.500 pessoas.";

                        label2.Text = "Mary Carroll";

                        break;


                    case "Ep 20 - O Amor dói":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Após os modos rudes de House terem assustado um homem, House tenta pedir desculpas e o homem acaba tendo um derrame. House marca um encontro com Cameron para que esta volta ao hospital.";

                        pictureBox8.Image = Properties.Resources.ep20_thumbnail;

                        label1.Text = "Ep 20 - O Amor dói";

                        pictureBox9.Image = Properties.Resources.paciente_ep20_season1;

                        richTextBox2.Text = "Harvey Park é o paciente do episódio O Amor dói. Ele é interpretado pelo ator John Cho. O paciente sofreu uma fratura na mandíbula, necessitando de uma grande cirurgia reconstrutiva e, como resultado, tem uma placa de aço que mantém sua mandíbula unida. Ele frequentemente usa praticantes de medicina alternativa.";

                        label2.Text = "Harvey Park";

                        break;


                    case "Ep 21 - Três Histórias":
                        groupBox6.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Cuddy força House a dar uma palestra para estudantes em que o tema é \"como diagnosticar\" um caso em que três pacientes têm fortes dores nas pernas.O episódio acaba revelando algumas coisas sobre o passado de House.";

                        pictureBox8.Image = Properties.Resources.ep21_thumbnail;

                        label1.Text = "Ep 21 - Três Histórias";

                        pictureBox9.Image = Properties.Resources.paciente_ep20_season1;

                        richTextBox2.Text = "";

                        label2.Text = "";

                        break;


                    case "Ep 22 - Lua de Mel":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Depois de uma longa argumentação (e de drogar a sua bebida), Stacy consegue que o seu marido seja admitido no hospital para realizar uma bateria de testes que resultam negativos apesar de seus sintomas crescentes indicarem que está a morrer.";

                        pictureBox8.Image = Properties.Resources.ep22_thumbnail;

                        label1.Text = "Ep 22 - Lua de Mel";

                        pictureBox9.Image = Properties.Resources.paciente_ep22_season1;

                        richTextBox2.Text = "Mark Warner foi um personagem recorrente em House, MD durante a primeira e a segunda temporada. Ele é marido da Conselheira Geral de Princeton-Plainsboro, Stacy Warner. Mark apareceu pela primeira vez no episódio Lua de Mel, quando Stacy pediu a House que investigasse sua dor abdominal e alterações de humor.";

                        label2.Text = "Mark Warner";

                        break;

                    //Temporada 2 ----------------------------------------------

                    case "Ep 1 - Aceitação":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um homem condenado à morte tem um ataque cardíaco após ter visões com as pessoas que matou, é aceito no hospital e House voluntaria-se para investigar, apesar das objeções da sua equipe.";

                        pictureBox8.Image = Properties.Resources.ep1_thumbnail_s2;

                        label1.Text = "Ep 1 - Aceitação";

                        pictureBox9.Image = Properties.Resources.paciente_ep1_season2;

                        richTextBox2.Text = "Clarence foi o presidiário do corredor da morte no episódio Aceitação. Ele foi interpretado pelo ator/rapper LL Cool J. Clarence cometeu quatro homicídios - ele assassinou sua namorada, um guarda penitenciário e dois de seus companheiros de prisão. Clarence era um preso no corredor da morte que começou a ter alucinações sobre as pessoas que matou durante seu período de exercício. Ele gritou para ser liberado do pátio de exercícios e depois caiu no chão.";

                        label2.Text = "Clarence";

                        break;

                    case "Ep 2 - Autópsia":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Wilson convence House a tratar uma menina com câncer terminal que teve alucinações. A menina se mostra bem mais madura e corajosa do que sua idade e ela decide enfrentar uma operação arriscada para conseguir mais algum tempo de vida. ";

                        pictureBox8.Image = Properties.Resources.ep2_thumbnail_s2;

                        label1.Text = "Ep 2 - Autópsia";

                        pictureBox9.Image = Properties.Resources.paciente_ep2_season2;

                        richTextBox2.Text = "Andie era a paciente terminal com câncer no episódio Autopsy. Ela foi interpretada pela atriz Sasha Pieterse. Andie foi diagnosticada com rabdomiossarcoma alveolar, um câncer terminal. Ela passou por cinco grandes cirurgias, um transplante de medula óssea, quatorze rodadas de quimioterapia e radioterapia.";

                        label2.Text = "Andie";

                        break;

                    case "Ep 3 - A Queda do Telhado":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um telhador com asma cai inesperadamente do teto da casa da Dr.ª Cuddy.";

                        pictureBox8.Image = Properties.Resources.ep3_thumbnail_s2;

                        label1.Text = "Ep 3 - A Queda do Telhado";

                        pictureBox9.Image = Properties.Resources.paciente_ep3_season2;

                        richTextBox2.Text = "Alfredo é o faz-tudo latino-americano que caiu do telhado de Lisa Cuddy. Ele foi interpretado pelo ator Ignacio Serricchio. Alfredo sofria de asma que afetava sua respiração. Ele também tinha cicatrizes de obras. Alfredo estava consertando o telhado da Cuddy quando caiu. Ele já havia reclamado que sua asma estava piorando, mas a Dra. Cuddy pediu que ele concluísse o trabalho no telhado dela.";

                        label2.Text = "Alfredo";

                        break;

                    case "Ep 4 - Tuberculose":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um famoso médico adoece trabalhando na África e é então examinado por House. Todos acreditam que ele tenha tuberculose, menos House. A estranha relação desse médico doente com Cameron causa uma certa curiosidade em House.";

                        pictureBox8.Image = Properties.Resources.ep4_thumbnail_s2;

                        label1.Text = "Ep 4 - Tuberculose";

                        pictureBox9.Image = Properties.Resources.paciente_ep4_season2;

                        richTextBox2.Text = "Sebastian Charles é o famoso médico tuberculoso que se torna paciente no episódio 'Tuberculose'. Ele foi interpretado pelo ator Ron Livingston. O personagem está envolvido na obtenção de medicamentos para quem sofre de tuberculose na África e seu nome já foi citado diversas vezes como indicado ao Prêmio Nobel da Paz.";

                        label2.Text = "Sebastian Charles";

                        break;

                    case "Ep 5 - O Garoto do Papai":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um estudante recém formado em Princeton tem sérios espasmos e sente choques em sua coluna durante a festa de formatura. Enquanto isso, os pais de House resolvem aparecer.";

                        pictureBox8.Image = Properties.Resources.ep5_thumbnail_s2;

                        label1.Text = "Ep 5 - O Garoto do Papai";

                        pictureBox9.Image = Properties.Resources.paciente_ep4_season2;

                        richTextBox2.Text = "Carnell Hall é um recém-formado pela Universidade de Princeton que sofre de sensações inexplicáveis, semelhantes a choques elétricos no episódio Daddy's Boy. Ele é interpretado pelo ator Vicellous Shannon. Ao comemorar na noite anterior à cerimônia de formatura, Carnell sentiu sensações contínuas na parte inferior das costas, como um choque elétrico intenso e doloroso.";

                        label2.Text = "Carnell Hall";

                        break;

                    case "Ep 6 - A Corrida":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um conhecido ciclista é levado a House depois de desmaiar numa corrida. É surpreendentemente honesto acerca de vários medicamentos ilegais e técnicas que aplicou a si próprio, mas a sua doença não é causada por nenhum deles. Enquanto isso Cameron fica indignada pela falta de ética do ciclista.";

                        pictureBox8.Image = Properties.Resources.ep6_thumbnail_s2;

                        label1.Text = "Ep 6 - A Corrida";

                        pictureBox9.Image = Properties.Resources.paciente_ep6_season2;

                        richTextBox2.Text = "Jeff está em primeiro lugar em uma corrida beneficente de ciclismo quando de repente começa a ofegar, fica desorientado e cai da bicicleta.";

                        label2.Text = "Jeff Forrester";

                        break;

                    case "Ep 7 - A Caça":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House finalmente aceita tratar um vizinho gay com AIDS, que entra choque anafilático após trombar no carro de Wilson, acabando por descobrir que a sua doença pode ser mais do que aparenta. Então, Cameron fica perturbada pois pensa que foi infectada depois que o paciente tosse sangue na boca da médica.";

                        pictureBox8.Image = Properties.Resources.ep7_thumbnail_s2;

                        label1.Text = "Ep 7 - A Caça";

                        pictureBox9.Image = Properties.Resources.paciente_ep7_season2;

                        richTextBox2.Text = "Kalvin Ryan era o paciente com AIDS que apareceu no episódio Hunting. Kalvin contraiu HIV através de sexo anal desprotegido ou através do compartilhamento de agulhas. No entanto, ele está tomando antirretrovirais e sua contagem de células T está dentro dos limites. No entanto, ele continua a ter relações sexuais desprotegidas com outros homens seropositivos e usa regularmente drogas recreativas, como ecstasy e metanfetaminas.";

                        label2.Text = "Kalvin Ryan";

                        break;

                    case "Ep 8 - O Erro":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Após uma mulher com fortes dores gástricas morrer ao encargo de Chase, este e House têm de enfrentar um grupo de médicos para ouvir acerca dos seus destinos.";

                        pictureBox8.Image = Properties.Resources.ep8_thumbnail_s2;

                        label1.Text = "Ep 8 - O Erro";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Kayla McGinley é a paciente de O Erro que morre devido à negligência de Chase. Ela é interpretada pela atriz Allison Smith.";

                        label2.Text = "Kayla McGinley";

                        break;

                    case "Ep 9 - A Decepção":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma mulher é admitida no hospital após um ataque epiléptico, enquanto todos pedem para que esta seja retirada do hospital quando se descobre que esta tem Síndrome de Munchausen; no entanto, House acha que ela tem uma doença escondida.";

                        pictureBox8.Image = Properties.Resources.ep9_thumbnail_s2;

                        label1.Text = "Ep 9 - A Decepção";

                        pictureBox9.Image = Properties.Resources.paciente_ep9_season2;

                        richTextBox2.Text = "Anica Jovanovich era a paciente com síndrome de Münchausen no episódio A Decepção. Ela foi interpretada pela atriz Cynthia Nixon.";

                        label2.Text = "Anica Jovanovich";

                        break;

                    case "Ep 10 - Falha de comunicação":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um famoso jornalista desmaia no escritório da empresa da sua revista. Apesar de agir normalmente depois de se levantar torna-se claro pela forma como baralha as palavras que sofre de afasia. Enquanto isso, House e Stacy exploram sua relação.";

                        pictureBox8.Image = Properties.Resources.ep10_thumbnail_s2;

                        label1.Text = "Ep 10 - Falha de comunicação";

                        pictureBox9.Image = Properties.Resources.paciente_ep10_season2;

                        richTextBox2.Text = "Fletcher foi diagnosticado como bipolar, mas não contou a ninguém. Seu transtorno bipolar o fez buscar excitação. Ele tomou topamax para tentar controlar, mas para tentar pará-lo completamente fez uma cingulotomia bilateral. Ele também tinha histórico de uso de pílulas para dormir e anfetaminas.";

                        label2.Text = "Fletcher Stone";

                        break;

                    case "Ep 11 - Preciso Saber":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e Stacy tentam reparar a sua relação, enquanto o resto da equipe tenta diagnosticar uma mulher com espasmos musculares e ataques de raiva constantes. Enquanto isso sai o resultado do exame de HIV de Cameron, mas esta tem medo de abri-lo.";

                        pictureBox8.Image = Properties.Resources.ep11_thumbnail_s2;

                        label1.Text = "Ep 11 - Preciso Saber";

                        pictureBox9.Image = Properties.Resources.paciente_ep11_season2;

                        richTextBox2.Text = "Margo Dalton é a ocupada mulher e mãe de carreira que desenvolve espasmos musculares incontroláveis ​​​​no episódio Need to Know. Ela é interpretada pela atriz Julie Warner. A paciente está tentando engravidar e toma medicamentos para fertilidade há treze meses.";

                        label2.Text = "Margo Dalton";

                        break;

                    case "Ep 12 - Distrações":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Surgem problemas logísticos quando House e a sua equipe não conseguem fazer todos os testes normais numa vítima de queimaduras.";

                        pictureBox8.Image = Properties.Resources.ep12_thumbnail_s2;

                        label1.Text = "Ep 12 - Distrações";

                        pictureBox9.Image = Properties.Resources.paciente_ep12_season2;

                        richTextBox2.Text = "Adam é o jovem paciente queimado no episódio Distrações. Ele foi interpretado pelo ator James Immekus. Adam sofreu queimaduras graves em mais de 40% de seu corpo em um acidente de quadriciclo. Ele foi levado às pressas de helicóptero para o Hospital Universitário Princeton-Plainsboro. Ele foi imediatamente colocado em ringer com lactato. Ele foi anestesiado para lidar com a dor das queimaduras durante o processo de recuperação e colocado em uma sala limpa para prevenir infecções.";

                        label2.Text = "Adam Kelvey";

                        break;

                    case "Ep 13 - Superficial":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Dr. House trata uma supermodelo com vício de heroína que tem um inesperado ataque de raiva e um desmaio num desfile e, no processo descobre segredos importantes sobre ela.";

                        pictureBox8.Image = Properties.Resources.ep13_thumbnail_s2;

                        label1.Text = "Ep 13 - Superficial";

                        pictureBox9.Image = Properties.Resources.paciente_ep13_season2;

                        richTextBox2.Text = "Alexandria Robinson era a paciente supermodelo em Skin Deep. Embora a paciente tivesse características sexuais secundárias bem desenvolvidas, ela ainda não havia começado a menstruar. Alex também era viciado em heroína.";

                        label2.Text = "Alexandria Robinson";

                        break;

                    case "Ep 14 - O Sexo Mata":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House tenta tratar um homem que tem uma convulsão de ausência, mas não percebe que este necessita de um coração novo. Quando o comitê de transplantes vota \"não\" a um coração novo, House tenta conseguir um de uma mulher morta cujos orgãos também foram rejeitados pelo comitê.";

                        pictureBox8.Image = Properties.Resources.ep14_thumbnail_s2;

                        label1.Text = "Ep 14 - O Sexo Mata";

                        pictureBox9.Image = Properties.Resources.paciente_ep14_season2;

                        richTextBox2.Text = "Henry Arrington, um aposentado de 65 anos com histórico de refluxo ácido, compareceu ao pronto-socorro acompanhado de sua filha de 20 anos após sofrer uma crise de ausência. Ele foi examinado por Eric Foreman, que o internou. O Dr. House foi designado como seu médico assistente quando a causa da convulsão não foi imediatamente aparente.";

                        label2.Text = "Henry Arrington";

                        break;

                    case "Ep 15 - Sem Pista":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando um homem começa a ter dificuldades em respirar, House acaba por ter de questionar as razões para o seu casamento. Enquanto isso, Wilson se muda para a casa de House devido as brigas em seu casamento e se torna vítima de várias brincadeirinhas.";

                        pictureBox8.Image = Properties.Resources.ep15_thumbnail_s2;

                        label1.Text = "Ep 15 - Sem Pista";

                        pictureBox9.Image = Properties.Resources.paciente_ep15_season2;

                        richTextBox2.Text = "Bob Palko é o paciente de Clueless que House suspeita ter sido envenenado por sua esposa aparentemente amorosa. Ele é interpretado pelo ator Eddie Mills.";

                        label2.Text = "Bob Palko";

                        break;

                    case "Ep 16 - Por Segurança":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House trata de uma adolescente que passou por um tratamento com forte medicação após um transplante de coração. Ela tem uma séria reação alérgica e entra em choque logo após a visita de seu namorado. Enquanto isso, House e Wilson enfrentam os problemas surgidos da convivência no mesmo apartamento.";

                        pictureBox8.Image = Properties.Resources.ep16_thumbnail_s2;

                        label1.Text = "Ep 16 - Por Segurança";

                        pictureBox9.Image = Properties.Resources.paciente_ep16_season2;

                        richTextBox2.Text = "Melinda Bardach foi a paciente do episódio Safe. Ela foi interpretada pela atriz Michelle Trachtenberg. Melinda tinha histórico de alergia grave a amendoim, picadas de abelha e penicilina. Enquanto seus pais estavam fora, ela sofreu uma reação alérgica grave e não tomou EpiPen. Ela decidiu tentar ir de carro até o hospital, mas no caminho ficou tonta e sofreu um acidente automobilístico. Ela sofreu um trauma grave no peito que resultou em parada cardíaca. Ela recebeu um transplante de coração e recebeu imunossupressores.  Seus pais montaram uma sala limpa em sua casa, recusaram-se a deixá-la sair e estabeleceram limites rígidos para visitantes.";

                        label2.Text = "Melinda Badarch";

                        break;
                    case "Ep 17 - Aposta Tudo":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um menino apresenta os mesmos sintomas de um paciente de House que morreu há anos. Assim, o médico acredita que pode prever o curso da doença do garoto. Enquanto isso, é organizada uma noite de poker em benefício do Departamento de Oncologia.";

                        pictureBox8.Image = Properties.Resources.ep17_thumbnail_s2;

                        label1.Text = "Ep 17 - Aposta Tudo";

                        pictureBox9.Image = Properties.Resources.paciente_ep17_season2;

                        richTextBox2.Text = "Ian Alston era o jovem paciente que sofria de diarreia com sangue que House estava convencido de que estava morrendo da mesma doença que matou outro paciente seu doze anos antes, no episódio All In. Ele foi interpretado pelo ator Carter Page.";

                        label2.Text = "Ian Alston";

                        break;

                    case "Ep 18 - Cachorro que Dorme Não Mente":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House corre contra o tempo para atender uma paciente que sofre de um caso fatal de insônia. Enquanto isso, Cameron se enfurece com Foreman, que roubou um artigo escrito pela médica.";

                        pictureBox8.Image = Properties.Resources.ep18_thumbnail_s2;

                        label1.Text = "Ep 18 - Cachorro que Dorme Não Mente";

                        pictureBox9.Image = Properties.Resources.paciente_ep18_season2;

                        richTextBox2.Text = "Hannah era a mulher que não dormia há dez dias no episódio Cachorro que Dorme Não Mente. Ela foi interpretada pela atriz Jayma Mays. Hannah havia recentemente tomado esteróides para hera venenosa e ibuprofeno para um joelho que machucou enquanto esquiava. Ela relatou que não dormia há dez dias. Hannah tomou um frasco inteiro de pílulas para dormir para tentar ajudá-la a dormir. Seu parceiro Max a encontrou no chão do banheiro, ainda consciente, e chamou uma ambulância. Eles foram levados ao pronto-socorro de Princeton-Plainsboro.";

                        label2.Text = "Hannah";

                        break;

                    case "Ep 19 - House VS Deus":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um curandeiro religioso adolescente aparece no hospital com um problema originalmente de fácil diagnóstico e durante a sua estada parece fazer encolher o tumor de um paciente com cancro. Wilson se sente rejeitado quando descobre que o médico participa de um jogo semanal de poker e House sente falta do amigo em sua casa.";

                        pictureBox8.Image = Properties.Resources.ep19_thumbnail_s2;

                        label1.Text = "Ep 19 - House VS Deus";

                        pictureBox9.Image = Properties.Resources.paciente_ep19_season2;

                        richTextBox2.Text = "Boyd foi o paciente curandeiro no episódio \"House vs. Deus\". Boyd tomou aspirina para dores de cabeça. Ele também bebeu muita água para se manter hidratado. Boyd estava dando um sermão quando seu abdômen ficou tenso, ele caiu de joelhos e disse ao pai que precisava de um médico. Como viaja muito, come muito fast food. Seu pai disse aos médicos que ele ouvia a palavra do Senhor desde os 10 anos.";

                        label2.Text = "Boyd";

                        break;

                    case "Ep 20 - Euforia, Parte 1":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um policial ferido à bala é atendido pela equipe e sofre de estranhos ataques de riso. House e seus companheiros ficam perplexos com o caso. Foreman começa a apresentar os mesmos sintomas, levando a equipe a acelerar a investigação sobre a causa da doença.";

                        pictureBox8.Image = Properties.Resources.ep20_thumbnail_s2;

                        label1.Text = "Ep 20 - Euforia, Parte 1";

                        pictureBox9.Image = Properties.Resources.paciente_ep20_season2;

                        richTextBox2.Text = "Joe Luria era o policial eufórico de Euphoria. Joe estava perseguindo um criminoso chamado \"Babyshoes\" quando não conseguiu controlar o riso. Babyshoes aproveitou a oportunidade para tentar atirar nele, mas a bala estilhaçou-se no colete à prova de balas de Joe, embora fragmentos da bala tenham atingido sua cabeça, jogando Joe no chão. Porém, depois disso, Joe continuou a rir.";

                        label2.Text = "Joe Luria";

                        break;

                    case "Ep 21 - Euforia, Parte 2":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Foreman continua a apresentar sintomas semelhantes aos de um policial internado no hospital, acometido por crises de riso. House acredita que a solução para a doença esteja no apartamento do agente de polícia. Tudo se complica mais quando Foreman infecta Cameron também, obrigando a médica a achar a solução do caso para salvar ambas as vidas. A médica não pega a doença.";

                        pictureBox8.Image = Properties.Resources.ep21_thumbnail_s2;

                        label1.Text = "Ep 21 - Euforia, Parte 2";

                        pictureBox9.Image = Properties.Resources.paciente_ep21_season2;

                        richTextBox2.Text = "O Dr. Foreman esteve envolvido no tratamento de um paciente que primeiro exibiu euforia, depois cegueira que o paciente não conseguia perceber e depois uma dor tremenda. O Dr. Foreman foi o único médico que esteve no apartamento do paciente. House começou a ficar preocupado com seu comportamento quando o Dr. Cameron relatou comportamento pouco profissional em torno do paciente e o Dr. Foreman sorriu quando o Dr. House realizou um experimento atirando em um cadáver. Logo depois, o Dr. Foreman começou a rir quando o paciente ficou taquicárdico e começou a sangrar.";

                        label2.Text = "Dr. Eric Foreman";

                        break;
                    case "Ep 22 - Para sempre":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma jovem mãe sofre uma convulsão enquanto dá banho em seu filho recém-nascido e quase o afoga. House e sua equipe trabalham nos dois casos ao mesmo tempo: tentam salvar o bebê e descobrir a causa das convulsões da mãe.";

                        pictureBox8.Image = Properties.Resources.ep22_thumbnail_s2;

                        label1.Text = "Ep 22 - Para Sempre";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Kara Mason foi a paciente do Forever. Ela foi interpretada pela atriz Hillary Tuck. O nome dela é provavelmente uma homenagem à personagem Cara Mason da saga de Terry Goodkind: A Espada da Verdade. A paciente havia dado à luz recentemente e estava cuidando de seu filho recém-nascido, Mikey. O marido de Kara encontrou Kara inconsciente em uma banheira cheia de água, e seu filho Mickey debaixo d'água e aparentemente sem respirar. Ele estava com eles apenas alguns momentos antes e ambos agiam normalmente.";

                        label2.Text = "Kara Mason";

                        break;

                    case "Ep 23 - Quem é o seu pai?":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um ex-companheiro da banda de House pede ao médico que atenda sua recém-descoberta filha de 16 anos. Vítima do furacão Katrina, a garota sofre de alucinações desde o desastre. Embora House tema que o amigo esteja sendo enganado, aceita trabalhar no caso.";

                        pictureBox8.Image = Properties.Resources.ep23_thumbnail_s2;

                        label1.Text = "Ep 23 - Quem é o seu pai?";

                        pictureBox9.Image = Properties.Resources.paciente_ep23_season2;

                        richTextBox2.Text = "Leona é a aparente filha biológica do velho amigo de House, Dylan Crandall, no episódio Quem é o seu pai?. Ela é neta do famoso pianista de jazz Jesse Baker. Ela é interpretada pela atriz Aasha Davis. Leona estava viajando de avião com Dylan quando de repente começou a ter alucinações de que o avião estava enchendo de água. Ela sofreu uma taquicardia extrema e desmaiou.";

                        label2.Text = "Leona";

                        break;

                    case "Ep 24 - Sem Motivo":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando um homem com a língua inchada é admitido no hospital, um homem misterioso atira em House, mas quando o caso é totalmente sem sentido, House tenta descobrir porque sua perna não dói.";

                        pictureBox8.Image = Properties.Resources.ep24_thumbnail_s2;

                        label1.Text = "Ep 24 - Sem Motivo";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "---";

                        label2.Text = "Sem Paciente";

                        break;

                    //Temporada 3 ----------------------------------------------

                    case "Ep 1 - O Significado das Coisas":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House volta com a sua perna recuperada e completamente sem dor, e resolve tratar de dois pacientes simultaneamente: Richard, paralisado depois de uma operação de câncer no cérebro há oito anos, tenta se suicidar, e Caren, uma jovem mulher paralisada do pescoço para baixo depois de uma sessão de Yoga. Quando House começa a diagnosticar e tratar os seus pacientes, o time nota uma forma de tratamento diferente desde sua recuperação. ";

                        pictureBox8.Image = Properties.Resources.ep1_thumbnail_s3;

                        label1.Text = "Ep 1 - O Significado das Coisas";

                        pictureBox9.Image = Properties.Resources.paciente_ep1_season3;

                        richTextBox2.Text = "Richard McNeil era o irlandês-americano paralisado que se tornou o paciente em O Significado das Coisas. Oito anos atrás (antes do episódio), Richard foi diagnosticado com câncer no cérebro. Foi realizada uma cirurgia para remover completamente o câncer, mas o deixou em estado vegetativo, incapaz de andar ou falar. Ele tem uma cadeira de rodas eletrônica, pois ainda tem algum controle sobre os dedos. Nos últimos oito anos ele teve 214 sintomas, muitos deles repetidos. Richard estava em uma reunião de família quando aparentemente dirigiu sua cadeira de rodas elétrica para dentro da piscina. Ele foi levado para o Hospital Universitário Princeton-Plainsboro.";

                        label2.Text = "Richard McNeil";

                        break;

                    case "Ep 2 - Com ou Sem Bengala":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House tem um dificil caso medico em que: um garoto de 7 anos, produto de uma fertilização in vitro, que alega ter um rastreador alienígena em seu pescoço, além de ser cobaia de experiências desses aliens. Quando descobre-se que ele realmente possuía um pino metálico no pescoço os pais dele começam a dar mais crédito ao que o filho fala. Enquanto isso, Cameron se choca quando descobre que Cuddy e Wilson estão mentindo para House sobre o diagnóstico do último caso do médico mal-humorado. ";

                        pictureBox8.Image = Properties.Resources.ep2_thumbnail_s3;

                        label1.Text = "Ep 2 - Com ou Sem Bengala";

                        pictureBox9.Image = Properties.Resources.paciente_ep2_season3;

                        richTextBox2.Text = "Clancy Green é o jovem paciente que teve alucinações sobre abduções alienígenas no episódio Cane and Able. Ele é interpretado pelo ator Skyler Gisondo. Clancy foi o resultado de fertilização in vitro. Ele tomou todas as vacinas. Ele quebrou o osso ulnar direito quando tinha três anos, resultando no uso de um pino cirúrgico de titânio para manter os ossos do braço direito unidos. Ele teve catapora quando tinha cinco anos. Ele também tinha um histórico de fantasias de abdução alienígena. Clancy foi levado ao Hospital Universitário de Princeton-Plainsboro depois de ser encontrado inconsciente em seu gramado pela manhã, sangrando pelo reto.";

                        label2.Text = "Clancy Green";

                        break;

                    case "Ep 3 - Autorizações":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "O paciente de House, Ezra Powell (Participação especial de Joel Grey), um conhecido médico pesquisador que desmaia em seu laboratório. House não consegue diagnosticar o problema e o paciente pede para que o deixem morrer. Uma paciente começa a desenvolver uma paixonite por House. Além disso, o médico mal-humorado volta a sentir dores na perna e passa a usar a bengala novamente.";

                        pictureBox8.Image = Properties.Resources.ep3_thumbnail_s3;

                        label1.Text = "Ep 3 - Autorizações";

                        pictureBox9.Image = Properties.Resources.paciente_ep3_season3;

                        richTextBox2.Text = "Ezra Powell foi um personagem do episódio Autorizações. Ele era um cientista pesquisador de 71 anos que perdeu a consciência enquanto trabalhava em seu laboratório. Powell é retratado como um cientista famoso e prolífico que ajudou a desenvolver o protocolo para o teste de estresse e a linguagem diagnóstica padrão para dores no peito. Ele é interpretado pelo ator vencedor do Oscar Joel Gray.";

                        label2.Text = "Ezra Powell";

                        break;

                    case "Ep 4 - Rabiscos na Areia":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House assume o caso de um garoto autista, que grita aparentemente sem motivo. Contudo, após uma efusão pleural, House não sabe o que pensar. Cuddy ignora o pedido de House de deixar o antigo tapete no escritório dele, então ele começa a diagnosticar em outras salas, até na de Wilson. ";

                        pictureBox8.Image = Properties.Resources.ep4_thumbnail_s3;

                        label1.Text = "Ep 4 - Rabiscos na Areia";

                        pictureBox9.Image = Properties.Resources.paciente_ep4_season3;

                        richTextBox2.Text = "Adam Kelvey é o jovem paciente autista do episódio Rabiscos na Areia. Ele é interpretado pelo ator Braeden Lemasters. O paciente foi diagnosticado com autismo e desde então seus pais deixaram o emprego para cuidar dele. Ele tem grandes necessidades de apoio, é incapaz de falar ou se comunicar e geralmente não responde a estímulos externos. ";

                        label2.Text = "Adam Kelvey";

                        break;

                    case "Ep 5 - O Amor é Cego":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma mulher é assaltada com o marido e começa a sofrer problemas respiratórios e dor no estômago. Durante o diagnóstico do problema, o marido também começa a desenvolver os mesmos sintomas que ela. Enquanto isso, um paciente da clínica causa problemas para House que podem ter sérias consequências.";

                        pictureBox8.Image = Properties.Resources.ep5_thumbnail_s3;

                        label1.Text = "Ep 5 - O Amor é Cego";

                        pictureBox9.Image = Properties.Resources.paciente_ep5_season3;

                        richTextBox2.Text = "Tracy é a jovem casada do episódio O Amor é Cego que de repente desenvolve um distúrbio respiratório. Ela é casada com seu namorado de infância, Jeremy. Ela é interpretada pela atriz Jurnee Smollett. Embora detida contra sua vontade por dois ladrões que ameaçaram estuprá-la e mantiveram seu marido sob a mira de uma arma, Tracy desmaiou repentinamente com dificuldades respiratórias em uma lanchonete quando os clientes estavam sendo assaltados.";

                        label2.Text = "Tracy";

                        break;

                    case "Ep 6 - O Que Será, Será":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A equipe passa por problemas logísticos para fazer exames em um paciente que pesa mais de 250 quilos devido a seu tamanho. Ao acordar de um coma, o homem se nega a fazer qualquer teste que tenha a ver com seu peso. Enquanto isso, House passa a noite na cadeia depois de ser preso pelo policial Tritter por diversas acusações.";

                        pictureBox8.Image = Properties.Resources.ep6_thumbnail_s3;

                        label1.Text = "Ep 6 - O Que Será, Será";

                        pictureBox9.Image = Properties.Resources.paciente_ep6_season3;

                        richTextBox2.Text = "George é o paciente com obesidade mórbida do episódio Que Será Será. Ele foi interpretado pelo ator Pruitt Taylor Vince. O paciente é obeso mórbido. Ele pesava bem mais que o peso da maior balança do hospital, que chega a 350 libras. Com uma cintura de mais de 2,10 metros, estimava-se que ele pesava mais de 600 libras. O paciente foi encontrado inconsciente em um estado que simulava a morte em sua própria cama - ele não tinha pulso radial, batimentos cardíacos detectáveis, sua temperatura corporal estava próxima da temperatura ambiente do quarto, ele havia perdido o controle da bexiga, não estava respirando e seu as pupilas estavam fixas e dilatadas. ";

                        label2.Text = "George";

                        break;

                    case "Ep 7 - Filho do Sujeito em Coma":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House decide acordar um paciente em coma para perguntar sobre o seu histórico familiar e o paciente decide passar seu último dia de vida com House e Wilson em outra cidade, longe do hospital. Seu filho pode ter uma doença genética e o pai é o único parente vivo. Enquanto isso, Michael Tritter se aproxima de Cameron, Chase e Foreman para tentar dividir a equipe. ";

                        pictureBox8.Image = Properties.Resources.ep7_thumbnail_s3;

                        label1.Text = "Ep 7 - Filho do Sujeito em Coma";

                        pictureBox9.Image = Properties.Resources.paciente_ep7_season3;

                        richTextBox2.Text = "Kyle Wozniak é o personagem-título e paciente do episódio Filho do Sujeito em Coma. Seu pai é Gabriel Wozniak. Ele foi interpretado pelo ator Zeb Newman. O paciente tem uma história crônica de convulsões inexplicáveis. O Dr. House conhecia Kyle como um visitante da enfermaria de coma. Ele percebeu que Kyle sofria de acinetopsia intermitente, a incapacidade de ver objetos em movimento. Ao acender as luzes da sala, ele conseguiu induzir uma convulsão. Kyle foi internado.";

                        label2.Text = "Kyle Wozniak";

                        break;

                    case "Ep 8 - O Irmão Mais Velho":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando um orfão que toma conta de dois irmãos mais novos vomita incontrolavelmente e tem um ataque cardíaco enquanto trabalha numa festa de aniversário de crianças, House e a sua equipe descobrem uma série bizarra de sintomas e infecções. Enquanto isso, Tritter começa a dificultar a vida de Wilson impossibilitando-o de praticar medicina. ";

                        pictureBox8.Image = Properties.Resources.ep7_thumbnail_s3;

                        label1.Text = "Ep 8 - O Irmão Mais Velho";

                        pictureBox9.Image = Properties.Resources.paciente_ep8_season3;

                        richTextBox2.Text = "Jack Walters é o paciente do episódio O Irmão Mais Velho que continua desenvolvendo novas infecções depois que as antigas são tratadas. Jack é o guardião legal de seus irmãos mais novos, Kama e Will. Ele é interpretado por Patrick Fugit, mais conhecido por interpretar William Miller, um jovem repórter da revista Rolling Stone em Quase Famosos, baseado no repórter adolescente da vida real Cameron Crowe. Jack foi levado ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro depois de vomitar e desmaiar no trabalho, apertando o peito. Os paramédicos tiveram que desfibrilá-lo em campo para estabilizar seu coração.";

                        label2.Text = "Jack Walters";

                        break;

                    case "Ep 9 - À Procura do Judas":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House cuida do caso de uma garota que foi diagnosticada com pancreatite. Os pais da menina não chegam a um consenso e o médico vai ao tribunal para conseguir permissão para tratar a paciente. Enquanto isso, Tritter continua sua estratégia para que House admita seu próprio uso de drogas. ";

                        pictureBox8.Image = Properties.Resources.ep9_thumbnail_s3;

                        label1.Text = "Ep 9 - À Procura do Judas";

                        pictureBox9.Image = Properties.Resources.paciente_ep9_season3;

                        richTextBox2.Text = "Alice Hartman é a jovem paciente do episódio À procura do Judas. Ela é interpretada pela atriz Alyssa Shafer. Alice foi levada ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro por seu pai quando começou a sentir fortes dores abdominais enquanto visitava um parque de diversões.";

                        label2.Text = "Alice Hartman";

                        break;

                    case "Ep 10 - Feliz Natal":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Wilson propõe a House fazer um acordo com Tritter, mas o médico ranzinza recusa. Enquanto isso, Cuddy impede que House tome analgésicos e tira o doutor do caso dado para a equipe: uma menina anã de 15 anos que chegou ao hospital com anemia e um problema no pulmão. ";

                        pictureBox8.Image = Properties.Resources.ep10_thumbnail_s3;

                        label1.Text = "Ep 10 - Feliz Natal";

                        pictureBox9.Image = Properties.Resources.paciente_ep10_season3;

                        richTextBox2.Text = "Abigail Ralphean é a paciente de baixa estatura do episódio Feliz Natal. Ela é interpretada pela atriz Kacie Borrowman. A paciente tem nanismo e hipoplasia capilar da cartilagem genética, herdada da mãe, que também tem a doença. Cuddy estava acompanhando Abigail após sua cirurgia para corrigir um colapso pulmonar. Abigail estava se recuperando bem. House apareceu para ver o Dr. Cuddy sobre um assunto pessoal e ficou intrigado com a cicatriz de Abigail e descobriu que era para corrigir o colapso do pulmão.";

                        label2.Text = "Abigail Ralphean";

                        break;

                    case "Ep 11 - Palavras e Ações":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House divide seu tempo entre o caso de um bombeiro que treme de frio descontroladamente, mesmo quando exposto ao fogo. Por causa de uma informação mal interpretada o paciente passar por uma cirurgia no cérebro. Enquanto isso, House enfrenta a reabilitação e o julgamento em que o doutor ranzinza é acusado de forjar prescrições médicas. ";

                        pictureBox8.Image = Properties.Resources.ep11_thumbnail_s3;

                        label1.Text = "Ep 11 - Palavras e Ações";

                        pictureBox9.Image = Properties.Resources.paciente_ep11_season3;

                        richTextBox2.Text = "Derek Hoyt era o bombeiro que sofria de inúmeros problemas no episódio Palavras e Ações. Ele foi interpretado pelo ator Tory Kittles. Derek estava perto de um incêndio quando ficou desorientado e teve dificuldade para respirar. Sua parceira Amy o abordou antes que ele entrasse em um prédio em chamas.";

                        label2.Text = "Derek Hoyt";

                        break;

                    case "Ep 12 - Um Dia, Uma Sala":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House volta a usar o Vicodin depois do acontecimento com o Tritter. Cuddy faz uma aposta com House que diz que se ele não tocasse em um paciente ao diagnosticar ele ganharia 10 dólares. Quando House encontra Eve, que tem um DST e admite ter sido estuprada, ela recusa a ser tratado por outros médicos, admitindo somente o House. Enquanto isso, Cameron encontra um sem teto que é muito diferente dos outros. ";

                        pictureBox8.Image = Properties.Resources.ep12_thumbnail_s3;

                        label1.Text = "Ep 12 - Um Dia, Uma Sala";

                        pictureBox9.Image = Properties.Resources.paciente_ep12_season3;

                        richTextBox2.Text = "Eve foi a vítima de estupro no episódio da 3ª temporada, One Day, One Room. Ela foi interpretada pela atriz Katheryn Winnick. No TV.com, a interpretação de Eve por Winnick foi escolhida por esmagadora maioria como o desempenho mais valioso do episódio, com 107 votos excelentes - 98 a mais que Hugh Laurie e um dos maiores totais de votos já registrados no site.  Eve veio à clínica pensando que tinha uma doença sexualmente transmissível. Ela viu o Dr. House, que foi banido para a clínica devido aos acontecimentos do episódio anterior. House pegou um esfregaço vaginal e enviou para teste. Algumas horas depois, os testes deram positivo para clamídia.";

                        label2.Text = "Eve";

                        break;

                    case "Ep 13 - Agulha Num Palheiro":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um rapaz de 16 anos é levado ao hospital com problemas respiratórios após um encontro com a namorada. House crê que este tem granulomatose de Wegener e em breve entra em confronto com os pais do rapaz cigano acerca do tratamento. ";

                        pictureBox8.Image = Properties.Resources.ep13_thumbnail_s3;

                        label1.Text = "Ep 13 - Agulha Num Palheiro";

                        pictureBox9.Image = Properties.Resources.paciente_ep13_season3;

                        richTextBox2.Text = "Stevie Lipa é o paciente que sofre de dores extremas no torso no episódio Needle in a Haystack. Ele é interpretado pelo ator Jake Richardson. Enquanto beijava a namorada em seu carro, Stevie de repente começou a sofrer de parada respiratória. Sua namorada pediu ajuda e um policial próximo chamou uma ambulância para levá-lo às pressas ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro.";

                        label2.Text = "Stevie Lipa";

                        break;

                    case "Ep 14 - Insensível a Dor":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House tem um caso em que: Uma garota com uma incapacidade rara de sentir dor (Insensibilidade congênita à dor) tem um acidente de carro. Quando se lhe fazem testes começa a ter febre alta, delírios paranóicos e piora rapidamente. ";

                        pictureBox8.Image = Properties.Resources.ep14_thumbnail_s3;

                        label1.Text = "Ep 14 - Insensível a Dor";

                        pictureBox9.Image = Properties.Resources.paciente_ep14_season3;

                        richTextBox2.Text = "Hannah Morgenthal é a paciente com CIPA no episódio Insensível a Dor. Ela é interpretada pela atriz Mika Boorem. Hannah se envolveu em um acidente automobilístico com sua mãe. Sua mãe ficou gravemente ferida, mas Hannah não perdeu a consciência e conseguiu ligar para o 911.";

                        label2.Text = "Hannah Morgenthal";

                        break;

                    case "Ep 15 - Meia Capacidade":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um músico autista com Savantismo e com o cérebro afetado tem convulsões apesar de estar medicado para as mesmas. Ao mesmo tempo todos ficam chocados por saber que o próprio House entrou em tratamento para câncer cerebral. ";

                        pictureBox8.Image = Properties.Resources.ep15_thumbnail_s3;

                        label1.Text = "Ep 15 - Meia Capacidade";

                        pictureBox9.Image = Properties.Resources.paciente_ep1_season3;

                        richTextBox2.Text = "Patrick Obyedkov é o pianista sábio no episódio Meia Capacidade. Ele é interpretado pelo ator Dave Matthews. Patrick sofreu uma lesão cerebral traumática aos dez anos de idade. Embora suas faculdades mentais gerais tenham sido afetadas, ele começou a exibir grande talento musical, quando não exibia nenhum antes do acidente. Patrick foi levado ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro depois de sofrer uma forte dor de cabeça durante uma apresentação, durante a qual os dedos de sua mão esquerda ficaram contorcidos pela distonia. ";

                        label2.Text = "Patrick Obyedkov";

                        break;

                    case "Ep 16 - Confidencial":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House trata um fuzileiro americano vindo do Iraque, que tem sintomas consistentes com a Síndrome da Guerra do Golfo. Um sonho de House acerca do fuzileiro complica a sua gestão do caso. Enquanto isso Chase e Cameron transam frequente no trabalho, House desconfia. ";

                        pictureBox8.Image = Properties.Resources.ep16_thumbnail_s3;

                        label1.Text = "Ep 16 - Confidencial";

                        pictureBox9.Image = Properties.Resources.paciente_ep16_season3;

                        richTextBox2.Text = "John Kelley foi o paciente de Confidencial , um episódio da terceira temporada. Ele foi o paciente que House viu em um sonho imediatamente antes de obter seu arquivo no episódio. Ele é interpretado pelo ator Marc Blucas. O paciente era fuzileiro naval há 12 anos e estava estacionado no Iraque há dois anos. ";

                        label2.Text = "John Kelley";

                        break;

                    case "Ep 17 - Posição Fetal":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House trata uma fotógrafa grávida que teve um derrame cujo bebê pode matá-la. Cuddy se sensibiliza muito com o caso e participa do diagnóstico da mulher. Quando eles discutem sobre a vida do bebê, a mãe de recusa terminantemente a abortar e as coisas ficam difíceis quando ela piora.";

                        pictureBox8.Image = Properties.Resources.ep17_thumbnail_s3;

                        label1.Text = "Ep 17 - Posição Fetal";

                        pictureBox9.Image = Properties.Resources.paciente_ep17_season3;

                        richTextBox2.Text = "Emma Sloan é a fotógrafa grávida que sofre um derrame no episódio Posição Fetal. Ela é interpretada pela atriz Anne Elizabeth Ramsay. Emma foi levada ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro depois de sofrer um derrame durante uma sessão de fotos, que ela autodiagnosticou.";

                        label2.Text = "Emma Sloan";

                        break;

                    case "Ep 18 - Transportados Pelo Ar":
                        groupBox6.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e Cuddy enfrentam uma doença subita que se alastra passageiros do avião de onde voltam de uma conferência em Singapura enquanto que Wilson e a equipe de House tratam uma mulher com convulsões.";

                        pictureBox8.Image = Properties.Resources.ep18_thumbnail_s3;

                        label1.Text = "Ep 18 - Transportados Pelo Ar";


                        richTextBox2.Text = "Fran é uma mulher que desmaia no meio de uma transação com uma prostituta no episódio Transportados Pelo Ar. Ela foi interpretada pela atriz Jenny O'Hara. Robin chamou uma ambulância e levou Fran ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro depois que Fran desmaiou em sua casa. Ela foi examinada pelo Dr. Wilson, que perguntou se ela havia sofrido traumatismo cranioencefálico. Ela negou que tivesse. No entanto, ele encontrou um adesivo de escopolamina em seu pescoço que Fran havia esquecido de remover. Peng é outro passageiro doente a bordo do voo. Ele é interpretado pelo ator Jamison Yang. Peng era passageiro de um voo transpolar direto de 18 horas de Cingapura para Nova York. Depois de beber muito, ele começou a sentir náuseas e vômitos. O Dr. House atribuiu os sintomas à embriaguez. No entanto, a comissária de bordo estava preocupada. Ela perguntou se alguém falava coreano, já que Peng não falava mais nada e, quando ninguém falava, ela perguntou se havia médico a bordo. O Dr. House foi buscar a Dra. Cuddy.";

                        label2.Text = "";

                        break;

                    case "Ep 19 - Viver a Idade":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma menina de 6 anos sofre de sintomas esperáveis em pessoas muito mais velhos. Tensões entre Cameron e Chase levam a que House lhes designam intencionalmente as mesmas tarefas, incluindo investigarem a casa da criança.";

                        pictureBox8.Image = Properties.Resources.ep19_thumbnail_s3;

                        label1.Text = "Ep 19 - Viver a Idade";

                        pictureBox9.Image = Properties.Resources.paciente_ep19_season3;

                        richTextBox2.Text = "Lucy é a menina de seis anos do episódio Viver a Idade. Ela foi interpretada pela atriz Bailee Madison. Ela é a irmã mais nova de Jasper. Há um ano, a mãe de Lucy morreu devido a complicações de um câncer no cérebro. Caso contrário, ela não teve problemas de saúde. Lucy foi levada ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro quando desmaiou na creche depois da escola com respiração acelerada.";

                        label2.Text = "Lucy";

                        break;

                    case "Ep 20 - Treinamento":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma co-artista perde a capacidade de tomar decisões, House e a sua equipe esforçam-se por encontrar a causa desse problema e o caso torna-se pessoal para Foreman.";

                        pictureBox8.Image = Properties.Resources.ep20_thumbnail_s3;

                        label1.Text = "Ep 20 - Treinamento";

                        pictureBox9.Image = Properties.Resources.paciente_ep20_season3;

                        richTextBox2.Text = "Lupe é a jovem que sofre de sintomas neurológicos no episódio Treinamento. Ela foi interpretada pela atriz Monique Gabriela Curnen. Lupe foi levada ao Hospital Universitário de Princeton-Plainsboro quando entrou em pânico depois de não conseguir escolher nenhuma carta em um jogo de monte de três cartas e desmaiou.";

                        label2.Text = "Lupe";

                        break;

                    case "Ep 21 - Família ":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A única hipótese de sobrevivência de um paciente de 14 anos com leucemia é um transplante de medula o seu irmão mais novo. Mas quando este fica doente, House e sua equipe tem de correr contra o tempo para salvar ambas as crianças.";

                        pictureBox8.Image = Properties.Resources.ep21_thumbnail_s3;

                        label1.Text = "Ep 21 - Família";


                        richTextBox2.Text = "Matty é o jovem doador de medula óssea que desenvolve uma doença pouco antes de doar sua medula. Ele é o irmão mais novo de Nick, que recentemente recebeu tratamento de radiação para destruir a medula óssea restante, para que esteja pronto para o transplante. Nick sofre de leucemia. Matty é interpretado pelo ator Dabier. Matty estava se preparando para doar medula óssea a seu irmão mais velho, Nick, e Nick recebeu radioterapia para destruir sua medula óssea doente, em preparação para o tratamento. No entanto, quando a medula estava para ser extraída, Matty começou a espirrar.";

                        label2.Text = "Matty";

                        break;

                    case "Ep 22 - Resignação":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Continua a especulação acerca da demissão de Foreman, enquanto que uma garota chamada Addie é admitida após sangrar pela boca durante a prática de artes marciais. House e Wilson estão em segredo preocupados um com o outro. ";

                        pictureBox8.Image = Properties.Resources.ep22_thumbnail_s3;

                        label1.Text = "Ep 22 - Resignação";

                        pictureBox9.Image = Properties.Resources.paciente_ep22_season3;

                        richTextBox2.Text = " Addie é a estudante universitária que adoece misteriosamente no episódio Renúncia. Ela foi interpretada pela atriz Lyndsy Fonseca.  Addie foi levada ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro quando começou a tossir sangue durante uma aula de caratê. Embora ela estivesse se esforçando, ela não sofreu nenhum trauma durante a aula.";

                        label2.Text = "Addie";

                        break;

                    case "Ep 23 - O Idiota":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House encontra alguém à sua altura na forma de Nathan Harrison, um rapaz de 16 anos especialista em xadrez com dores de cabeça intensas e problemas de comportamento, que consegue irritar e ofender todos os membros da equipe de House durante o tratamento. No entanto, a frustração de Foreman com House chega a um novo nível quando este parece sabotar a sua entrevista de trabalho noutro hospital.";

                        pictureBox8.Image = Properties.Resources.ep23_thumbnail_s3;

                        label1.Text = "Ep 23 - O Idiota";

                        pictureBox9.Image = Properties.Resources.paciente_ep23_season3;

                        richTextBox2.Text = "Nate Harrison é o personagem-título e paciente no episódio da 3ª temporada, O Idiota. Ele é interpretado pelo ator Nick Lane. Nate foi levado ao Hospital Universitário de Princeton-Plainsboro quando, durante um torneio de xadrez rápido, de repente atacou o outro jogador e desmaiou com uma forte dor de cabeça.";

                        label2.Text = "Nate Harrison";

                        break;

                    case "Ep 24 - Erro Humano":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e a sua equipe aceitam um caso de uma jovem mulher que, com o seu marido, é resgatada no mar vinda de Cuba numa tentativa desesperada de ver House e de conseguir um diagnóstico para a sua doença. Durante a sua estada no hospital, desenvolve um novo sintoma; o seu coração para - mas ela continua a falar… Entretanto, Foreman prepara-se para o seu último dia no hospital Princeton-Plainssboro; House demite Chase, por isso Cameron se demite.";

                        pictureBox8.Image = Properties.Resources.ep24_thumbnail_s3;

                        label1.Text = "Ep 24 - Erro Humano";

                        pictureBox9.Image = Properties.Resources.paciente_ep24_season3;

                        richTextBox2.Text = "Marina Hernández é a jovem cubana que, acompanhada de seu marido Esteban Hernández, foge de Cuba em uma lancha na tentativa desesperada de consultar o Dr. House para diagnosticar sua doença, o que deixou os médicos cubanos perplexos. Ela foi interpretada pela atriz Mercedes Renard.";

                        label2.Text = "Marina Hernández";

                        break;

                    //Temporada 4 ----------------------------------------------

                    case "Ep 1 - Sozinho":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando um edifício de escritórios cai, House tem de trabalhar depressa para diagnosticar uma mulher, Megan, que sobreviveu ao desastre. Devido ao seu estado, a única forma de comunicação de Megan é piscar os olhos. House, sem a sua equipe, uma vez que Cameron e Foreman se demitiram e que demitiu Chase, discute as suas idéias com um funcionário da limpeza do hospital. Enquanto House persiste em diagnosticar Megan sozinho, percebe que o caso não é o que parece e que a solidão pode não ser a resposta.";

                        pictureBox8.Image = Properties.Resources.ep1_thumbnail_s4;

                        label1.Text = "Ep 1 - Sozinho";

                        pictureBox9.Image = Properties.Resources.paciente_ep1_season4;

                        richTextBox2.Text = "Megan Bradberry é a mulher considerada a paciente do episódio Sozinho. Ela foi interpretada pela atriz Bevin Prince. Elizabeth Masters é a mulher que se acredita ser uma paciente chamada Megan Bradberry, no episódio Alone. Ela foi interpretada pela atriz Liliya Toneva. Liz estava trabalhando no escritório quando o prédio começou a tremer e desabou. Ela foi identificada erroneamente na cena do colapso como Megan Bradberry, uma colega de Liz, pelo namorado de Bradberry. Como os paramédicos são treinados para nunca adivinhar a identificação de uma família, ela foi internada com o nome de Bradberry.";

                        label2.Text = "Megan Bradberry";

                        break;

                    case "Ep 2 - A Coisa Certa":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma piloto de caça chamada Greta, candidata a um programa de treino da NASA vai ter com House. Greta sofre de uma desordem neurológica através da qual converte imagens visuais em sons, ou ouve com os olhos(sinestesia). Sabendo que a NASA rejeitaria qualquer possibilidade de se tornar uma astronauta se soubesse do seu problema, Greta pede a House que a trate em segredo. Enquanto isso, House se surpreende ao pensar ver Cameron, Chase e Foreman nos corredores do hospital.";

                        pictureBox8.Image = Properties.Resources.ep2_thumbnail_s4;

                        label1.Text = "Ep 2 - A Coisa Certa";

                        pictureBox9.Image = Properties.Resources.paciente_ep2_season4;

                        richTextBox2.Text = "Greta Cooper é a piloto da Força Aérea e potencial astronauta que sofre de sinestesia em A Coisa Certa. Ela é interpretada pela atriz Essence Atkins. A Capitã Cooper ficou desorientada em um simulador de aeronave, caindo. Ela procurou o Dr. House para diagnóstico e tratamento, oferecendo-lhe US$ 50.000 em dinheiro para diagnosticá-la de forma confidencial.";

                        label2.Text = "Greta Cooper";

                        break;

                    case "Ep 3 - 97 Segundos":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Os dez candidatos finais a um trabalho no hospital competem ferozmente quando house os divide em duas equipes por sexo. É lhes indicado diagnosticar um homem numa cadeira de rodas com atrofia muscular que sufoca lentamente. Enquanto as duas equipes tentam cada uma superar a outra, aparecem complicações quando uma equipe trata o paciente mas não dá seguimento ao tratamento. Enquanto os estudantes estão ocupados com a sua função, House experimenta em si próprio para ver o que acontece nos momentos em que as pessoas estão entre a vida e a morte. Enquanto isso, Foreman dirige a sua equipe no seu novo trabalho em outro hospital, e recorre ao uso de um tratamento muito ao estilo de House para ajudar um paciente.";

                        pictureBox8.Image = Properties.Resources.ep3_thumbnail_s4;

                        label1.Text = "Ep 3 - 97 Segundos";

                        pictureBox9.Image = Properties.Resources.paciente_ep3_season4;

                        richTextBox2.Text = "O paciente sofre de atrofia muscular espinhal, uma doença genética incurável que o mantém confinado a uma cadeira de rodas. O paciente foi levado ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro quando perdeu a consciência, resultado de uma queda repentina na pressão arterial que normalmente teria resultado em desmaio e recuperação da consciência, mas devido à sua posição vertical na cadeira de rodas resultou em inconsciência persistente.";

                        label2.Text = "Thomas Stark";

                        break;

                    case "Ep 4 - Anjos da Guarda":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Enquanto está tendo um ataque, uma maquiadora de mortos alucina que está sendo estuprada por um morto para o qual ela está trabalhando. Depois no hospital, ela se comporta como se sua mãe morta estivesse no quarto com ela. Enquanto isso, Cameron dá alguns avisos a um dos cadidadatos a vaga no time de House; Foreman almoça com Cuddy.";

                        pictureBox8.Image = Properties.Resources.ep4_thumbnail_s4;

                        label1.Text = "Ep 4 - Anjos da Guarda";

                        pictureBox9.Image = Properties.Resources.paciente_ep4_season4;

                        richTextBox2.Text = "Irene é uma personagem de House, que apareceu no episódio Guardian Angels. Ela é uma cosmetologista de uma funerária ucraniana que sofre de vívidas alucinações e delírios. Ela foi interpretada pela atriz Azura Skye.  Irene foi levada ao Hospital Universitário de Princeton-Plainsboro quando seu colega de trabalho Martin, na funerária, a encontrou desmaiada no chão, perto de sua área de trabalho, tendo uma convulsão.";

                        label2.Text = "Irene";

                        break;

                    case "Ep 5 - Espelho, Espelho Meu":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Foreman retorna ao hospital e é designado para supervisionar os candidatos à equipe de House. Um homem é roubado e sofre uma parada respiratória. Ele não tem nenhuma memória sobre quem ele é, mas ao criar a sua própria personalidade temporária, usa a personalidade da pessoa mais dominante na sala (síndrome do espelho). Sua habilidade de manipular a sua personalidade intriga House, que manipula o homem a julgar os outros e, finalmente, julga se House é mais dominante do que Cuddy.";

                        pictureBox8.Image = Properties.Resources.ep5_thumbnail_s4;

                        label1.Text = "Ep 5 - Espelho, Espelho Meu";

                        pictureBox9.Image = Properties.Resources.paciente_ep5_season4;

                        richTextBox2.Text = "Robert Elliot, também conhecido como Sr. X, é o paciente desconhecido no episódio 'Espelho, Espelho Meu' após ser assaltado. Ele passa a imitar a personalidade dos médicos que o tratam e logo é apelidado de “Paciente Espelho”. Ele é interpretado pelo ator Frank Whaley. O paciente foi internado quando foi descoberto após uma ligação para o 911 sozinho na rua, com as mãos e os joelhos, tossindo incontrolavelmente e com dificuldade respiratória. Ele não tinha identificação.";

                        label2.Text = "Robert Elliot";

                        break;

                    case "Ep 6 - O Que For Preciso":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House é recrutado pela CIA para ajudar no diagnóstico de uma doença mortal e desconhecida em um agente. O caso do agente está sendo supervisionado pela Dr. Samira Terzi, que oferece poucas informações sobre o histórico médico do paciente e de suas missões anteriores. Com essas informações limitadas demais para prosseguir, House usa alguns métodos não-ortodoxicos para tentar \"quebrar o sistema\" e determinar o diagnóstico a tempo de salvar a vida do seu paciente misterioso. Enquanto isso, Foreman encontra resistência dos seis candidatos quando eles começam a questionar o seu diagnóstico sobre uma motorista que teve síncope após uma corrida";

                        pictureBox8.Image = Properties.Resources.ep6_thumbnail_s4;

                        label1.Text = "Ep 6 - O Que For Preciso";

                        pictureBox9.Image = Properties.Resources.paciente_ep6_season4;

                        richTextBox2.Text = "Casey Alfonso é a piloto de corrida que desmaiou após uma corrida no episódio 'O Que For Preciso'. Ela é interpretada pela atriz Amy Dudgeon.  Casey desmaiou durante uma entrevista logo após terminar uma corrida. Ela foi levada ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro e recebeu líquidos. Ela reclamou que durante a corrida e pouco antes do colapso, estava se sentindo desorientada.";

                        label2.Text = "Casey Alfonso";

                        break;

                    case "Ep 7 - Feio":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe estão participando de um documentário sobre um adolescente com uma grave deformidade facial que sofre um ataque cardíaco durante o procedimento de reconstrução facial. Enquanto trabalham no diagnóstico do garoto, House encontra-se \"distraído\" por alguns candidatos que tentam veementemente uma vaga na sua equipe, e este questiona os seus próprios motivos para tê-los escolhidos.";

                        pictureBox8.Image = Properties.Resources.ep7_thumbnail_s4;

                        label1.Text = "Ep 7 - Feio";

                        pictureBox9.Image = Properties.Resources.paciente_ep7_season4;

                        richTextBox2.Text = "Kenny Arnold é um paciente com uma grave deformidade facial na linha média no episódio Feio. Ele é filho de Joe Arnold. Ele foi interpretado pelo ator Khleo Thomas. O paciente tem encefalocele nasal frontal com fenda na linha média, que deformou gravemente o lado esquerdo da face. Enquanto o paciente se preparava para a cirurgia, mas antes da administração da anestesia, ele começou a sofrer de taquicardia e sua frequência cardíaca disparou para mais de 180 bpm.";

                        label2.Text = "Kenny Arnold";

                        break;

                    case "Ep 8 - Você Não Quer Saber":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House encontra um mágico que teve uma falha cardíaca durante uma fuga debaixo d'água. Enquanto o restante dos candidatos tentam diagnosticar o mágico, House está determinado a provar que ele fingiu o problema para encobrir seu erro durante a apresentação. Enquanto isso, House faz mais um jogo com sua equipe envolvendo a Cuddy, garantindo ao vencedor a imunidade da eliminação e a chance de nomear outros dois candidatos para \"sair do jogo\".";

                        pictureBox8.Image = Properties.Resources.ep8_thumbnail_s4;

                        label1.Text = "Ep 8 - Você Não Quer Saber";

                        pictureBox9.Image = Properties.Resources.paciente_ep8_season4;

                        richTextBox2.Text = "Flynn é o mágico que quase se afoga em sua própria caixa chinesa de tortura de água no episódio Você não quer saber. Ele é retratado pelo mágico e ator da vida real Steve Valentine.  Enquanto assistia a um show de mágica, o Dr. Cole percebe que um truque deu errado quando nota sangue saindo da boca do mágico. Ele também chamou o Dr. Kutner ao palco e eles conseguiram ressuscitá-lo. ";

                        label2.Text = "Flynn";

                        break;

                    case "Ep 9 - Jogos":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House atribui os candidatos a um caso particularmente difícil envolvendo um punk guitarrista com uma história de abuso de drogas e desobediência civil, enquanto Cuddy pressiona House a fazer uma decisão final e contratar sua nova equipe. House promete uma posição garantida sobre a sua equipe para o candidato que acerte o diagnóstico do paciente. Enquanto isso, Wilson informa um antigo paciente que ele havia lhe diagnosticado com câncer terminal que vai agora passar a viver, o que faz o paciente querer processá-lo. ";

                        pictureBox8.Image = Properties.Resources.ep9_thumbnail_s4;

                        label1.Text = "Ep 9 - Jogos";

                        pictureBox9.Image = Properties.Resources.paciente_ep9_season4;

                        richTextBox2.Text = "Jimmy Quidd (nascido Jim Moscowitz) é o músico de punk rock que desmaia pouco antes de subir ao palco no episódio Games. Ele é interpretado pelo ator Jeremy Renner.  O paciente tem um longo histórico de abuso de substâncias e é fumante inveterado. Ele freqüentemente se envolve em brigas. Ele também mente com frequência, principalmente sobre sua idade.  Quidd foi levado ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro depois de tossir sangue e desmaiar do lado de fora de uma boate onde deveria tocar. ";

                        label2.Text = "Jimmy Quidd";

                        break;

                    case "Ep 10 - A Mentira Não Se Compra":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe tratam de uma mulher que sofre de uma paralisia súbita das mãos que faz sua filha cair, enquanto ela estava subindo uma parede de escalada. A mulher diz que não esconde nada de sua filha e vice-versa. Enquanto a mulher e sua filha permanecem no hospital, House está convencido de que a mulher está retendo uma informação.";

                        pictureBox8.Image = Properties.Resources.ep10_thumbnail_s4;

                        label1.Text = "Ep 10 - A Mentira Não Se Compra";

                        pictureBox9.Image = Properties.Resources.paciente_ep10_season4;

                        richTextBox2.Text = "Maggie Archer é a paciente do episódio A Mentira Não Se Compra.  A paciente tinha histórico familiar de câncer de mama e herdou a mutação BRCA e foi submetida a mastectomia eletiva como medida preventiva. Ela não optou pelo uso de implantes mamários reconstrutivos.  A paciente foi levada ao Hospital Universitário de Princeton-Plainsboro quando perdeu o controle de uma corda de segurança que segurava sua filha durante uma escalada. Como resultado, a filha quebrou o braço. A paciente não conseguia mover os dedos.";

                        label2.Text = "Maggie Archer";

                        break;

                    case "Ep 11 - Congelada":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando a Dr. Cate Milton (participação especial de Mira Sorvino), uma psiquiatra presa no Pólo Sul adoece numa estação de pesquisa com somente um médico, fica difícil fazer qualquer teste, ela e o Dr. House tem um relacionamento a longa distância. Há muito poucos medicamentos na estação, House e sua equipe tem de recorrer a tratar ela via webcam.";

                        pictureBox8.Image = Properties.Resources.ep11_thumbnail_s4;

                        label1.Text = "Ep 11 - Congelada";

                        pictureBox9.Image = Properties.Resources.paciente_ep11_season4;

                        richTextBox2.Text = "Cate Milton é a psiquiatra pesquisadora do Pólo Sul que contrai uma doença misteriosa e precisa ser diagnosticada à distância por House no episódio Frozen. Ela é interpretada pela atriz ganhadora do Oscar Mira Sorvino. O personagem é baseado no caso real do Dr. Jerri Nielsen (1952-2009), que foi diagnosticado com câncer enquanto estava no Pólo Sul em 1998. Enquanto cuidava de um ferimento no mecânico da estação Seth, o Dr. dor abdominal e vômito. Como ela era a única médica na estação, a equipe entrou em contato com o Hospital Universitário de Princeton-Plainsboro, já que o Dr. Milton era membro adjunto do corpo docente. ";

                        label2.Text = "Cate Milton";

                        break;

                    case "Ep 12 - Não Mude Nunca":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe tratam de uma mulher teve um colapso em seu casamento. Seus resultados vêm até teste negativo para uma variedade de doenças comuns e ela só fica doente sentada ou em pé, o que leva a equipe a suspeitar de jogo sujo. Quando eles descobrem que a mulher tinha sido uma produtora musical antes de se converter ao Judaísmo chassídico, House insiste em que as pessoas não mudam, e que isso aparentemente pode ser um sintoma da doença que ela tem. Enquanto isso, House tem que lidar com seu relacionamento com Wilson, que acabou de arrumar uma namorada, Amber, justamente a médica que fora demitida da equipe de House.";

                        pictureBox8.Image = Properties.Resources.ep12_thumbnail_s4;

                        label1.Text = "Ep 12 - Não Mude Nunca";

                        pictureBox9.Image = Properties.Resources.paciente_ep12_season4;

                        richTextBox2.Text = "Roz é a noiva hassídica que desmaia na recepção de seu casamento no episódio Não Mude Nunca. Ela é interpretada pela atriz Laura Silverman.  A paciente tinha consumido heroína recreativa até cerca de seis meses atrás, quando abraçou o hassidismo. Roz foi levada ao Hospital Universitário de Princeton-Plainsboro depois da recepção de seu casamento, onde desmaiou. ";

                        label2.Text = "Roz";

                        break;

                    case "Ep 13 - Adeus Sr Bonzinho":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House suspeita em uma sala de emergência de um doente que tem um problema maior do que o inicialmente foi diagnosticado com base no fato de que o paciente é muito agradável. House fica cético quanto as questões de saúde do paciente que tem muita disposição, a equipe tenta ir ao fundo da sua doença, e o caso fica complicado quando o paciente começa a ficar irritado. Entretanto, House e Amber estão em desacordo sobre quanto tempo eles têm com Wilson, e Cuddy manda a House fazer uma análise do desempenho da equipe.";

                        pictureBox8.Image = Properties.Resources.ep13_thumbnail_s4;

                        label1.Text = "Ep 13 - Adeus Sr Bonzinho";

                        pictureBox9.Image = Properties.Resources.paciente_ep13_season4;

                        richTextBox2.Text = "Jeff é o paciente do episódio Adeus Sr Bonzinho. Ele é marido de Deb, enfermeira do Hospital Universitário de Princeton-Plainsboro. Ele é interpretado pelo ator Paul Rae. Jeff estava visitando sua esposa no piquete durante a greve das enfermeiras quando perdeu o controle dos movimentos dos olhos e desmaiou. Ele foi levado ao pronto-socorro, mas rapidamente agiu normalmente e devido à greve os médicos ficaram sobrecarregados e não puderam realizar um exame mais completo. No entanto, o Dr. House estava passando pelo pronto-socorro e se perguntou por que o paciente estava sentado em uma cama, satisfeito, quando era óbvio que ele já estava lá há muito tempo.";

                        label2.Text = "Jeff";

                        break;

                    case "Ep 14 - Vivendo o Sonho":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House está convencido que um dos atores de sua novela (Participação especial de Jason Lewis) \"Prescrição Paixão\" tem uma doença grave após observar seus sintomas na televisão. House decide intervir nesse assuntos, mas tanto o ator e a equipe de House acha que não há nenhuma doença. Enquanto isso, House e Amber disputam o Wilson, e Cuddy tenta manter as aparências quando um inspetor faz uma visita inesperada de Princeton-Plainsboro. ";

                        pictureBox8.Image = Properties.Resources.ep14_thumbnail_s4;

                        label1.Text = "Ep 14 - Vivendo o Sonho";

                        pictureBox9.Image = Properties.Resources.paciente_ep14_season4;

                        richTextBox2.Text = "Evan Greer é o paciente do episódio Vivendo o Sonho. Ele é o ator que interpreta Brock Sterling na novela favorita de House. Na realidade, ele próprio é interpretado pelo ator da vida real Jason Lewis. House, que é fã de Greer, notou que a leitura de suas falas ficou mais lenta recentemente. Dr. House acreditava que ele tinha um tumor occipital que estava resultando neste sintoma.";

                        label2.Text = "Evan Greer";

                        break;

                    case "Ep 15 - A Cabeça do House":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um acidente de ônibus deixa House com um sério traumatismo craniano e amnésia parcial. Ele começa a acreditar que um paciente no ônibus apresenta uma doença mortal e luta para se lembrar quem era o doente e o que teria. ";

                        pictureBox8.Image = Properties.Resources.ep15_thumbnail_s4;

                        label1.Text = "Ep 15 - A Cabeça do House";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "O motorista do ônibus era o personagem em quem House acreditava ter visto um sintoma antes do acidente do ônibus. paciente foi levado ao pronto-socorro de Princeton-Plainsboro com lacerações causadas por um acidente de ônibus. O Dr. House estava no ônibus e acreditava ter visto um sintoma antes do acidente. Ele examinou o paciente e notou um p no peito, abaixo do pescoço, que ele acreditava indicar leucemia. No entanto, o Dr. Wilson ressaltou que esse sintoma era apenas um hematoma causado pelo cinto de segurança do paciente. O paciente negou ter tido convulsão e disse que o ônibus foi atropelado por um caminhão de lixo. Wilson argumentou que se o Dr. House tivesse visto o início de uma convulsão, ele teria dito ao motorista para encostar. ";

                        label2.Text = "Motorista";

                        break;

                    case "Ep 16 - O Coração de Wilson":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Dentro da cabeça de House está a chave para salvar a paciente de sua condição, e a Amizade de House e o Wilson está sendo testada quando as memórias do dia do acidente de ônibus está prestes a mudar a vida de todos.";

                        pictureBox8.Image = Properties.Resources.ep16_thumbnail_s4;

                        label1.Text = "Ep 16 - O Coração de Wilson";

                        pictureBox9.Image = Properties.Resources.paciente_ep16_season4;

                        richTextBox2.Text = "A paciente ficou gravemente ferida em um acidente de ônibus e foi internada como desconhecida no Princeton General Hospital. A cirurgia para reparar os rins danificados e outras lesões foi bem-sucedida e a paciente foi colocada em diálise. No entanto, no pós-operatório, ela não conseguiu recuperar a consciência e desenvolveu taquicardia persistente bem após a cirurgia. Ela recebeu potássio, adenosina e verapamil sem efeito. Ela estava marcada para uma angiografia coronária, mas havia pacientes mais gravemente feridos à sua frente.";

                        label2.Text = "Anne Dudek";

                        break;

                    //Temporada 5 ----------------------------------------------

                    case "Ep 1 - Morrer Muda Tudo":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Depois de uma tragédia pessoal, Wilson decide abandonar o hospital e seu relacionamento com House. Enquanto isso, Treze enfrenta seu problema médico enquanto ajuda a tratar de uma assistente executiva que alucina com formigas subindo em seu corpo e que tem uma personalidade parecida com a de Treze.";

                        pictureBox8.Image = Properties.Resources.ep1_thumbnail_s5;

                        label1.Text = "Ep 1 - Morrer Muda Tudo";

                        pictureBox9.Image = Properties.Resources.paciente_ep1_season5;

                        richTextBox2.Text = "Patty Michener era a chefe de Lou no episódio da 5ª temporada, Morrer Muda Tudo. Ela foi interpretada pela atriz Jamie Rose. Quando Lou começou a agir de maneira estranha, Patty foi indiferente até perceber que Lou tinha um problema sério. Ela então perguntou calmamente se alguém iria ligar para o 911.";

                        label2.Text = "Patty Michener";

                        break;

                    case "Ep 2 - Não é Câncer":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um doador de orgãos é responsável por causar a morte de vários beneficiários, e a equipe tem que salvar as últimas duas pessoas que receberam os órgãos. Enquanto isso, House contrata um detetive privado para vigiar sua equipe e Wilson.";

                        pictureBox8.Image = Properties.Resources.ep2_thumbnail_s5;

                        label1.Text = "Ep 2 - Não é Câncer";

                        pictureBox9.Image = Properties.Resources.paciente_ep2_season5;

                        richTextBox2.Text = "Apple é uma personagem que apareceu em Não é Câncer. Ela foi a transplantada de córnea do grupo de pacientes que morreram de doenças misteriosas após receberem transplantes do mesmo doador. Ela foi interpretada pela atriz Felicia Day. Cinco anos antes, a Apple havia recebido um transplante de córnea para corrigir a cegueira resultante de danos prolongados na córnea. Quando quatro dos beneficiários morreram com uma diferença de oito meses entre si por causas independentes, Remy Hadley procurou a Apple e a encontrou dando aulas de matemática. Ela correu de volta para o Hospital Universitário de Princeton-Plainsboro para ser tratada pelo Dr. House junto com o outro receptor sobrevivente, que estava muito doente.";

                        label2.Text = "Apple";

                        break;

                    case "Ep 3 - Eventos Adversos":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma doença não diagnosticada de um pintor afeta seu trabalho, e House e sua equipe tem que olhar as pinturas do homem para saber o que há de errado com ele.";

                        pictureBox8.Image = Properties.Resources.ep3_thumbnail_s5;

                        label1.Text = "Ep 3 - Eventos Adversos";

                        pictureBox9.Image = Properties.Resources.paciente_ep3_season5;

                        richTextBox2.Text = "Brandon é o paciente artista que sofre de dificuldades de percepção no episódio Eventos Adversos. Ele é interpretado pelo ator Breckin Meyer. Brandon foi levado ao hospital quando pintou um quadro em estilo distorcido que ele acreditava ter sido pintado em estilo realista, mostrando agnosia visual de início agudo. A equipe do Dr. House revisou outros trabalhos recentes do paciente, que não mostraram qualquer evidência de distorção.";

                        label2.Text = "Brandon";

                        break;

                    case "Ep 4 - Marcas de nascença":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Enquanto viaja para o funeral de seu pai, juntamente com Wilson, House precisa ajudar a equipe, por celular, com o diagnóstico diferencial de uma jovem chinesa que teve um colapso enquanto procurava por seus pais biológicos. House faz a pazes com seu melhor amigo, que volta para o hospital.";

                        pictureBox8.Image = Properties.Resources.ep4_thumbnail_s5;

                        label1.Text = "Ep 4 - Marcas de nascença";

                        pictureBox9.Image = Properties.Resources.paciente_ep4_season5;

                        richTextBox2.Text = "Nicole é uma jovem nascida na China que foi adotada por pais americanos. No entanto, ela voltou para a China ainda jovem para encontrar seus pais biológicos, mas quando os encontrou foi rejeitada por eles. Ela imediatamente começou a sofrer sintomas que persistiram em seu retorno a Nova Jersey. Ela é interpretada pela atriz Samantha Quan. Durante uma viagem à China, Nicole estava em um templo budista quando começou a sentir dores abdominais terríveis e a vomitar sangue. Os médicos na China cortaram parte do seu intestino, mas quando ela regressou aos Estados Unidos a dor continuou a piorar. Ela foi ao pronto-socorro do Hospital Universitário Princeton-Plainsboro. ";

                        label2.Text = "Nicole";

                        break;

                    case "Ep 5 - Sorte da Treze":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma mulher com quem a Treze passou uma noite fica doente e tem um ataque no apartamento da médica estagiária. Ela leva a mulher para o Hospital Princeton-Plainsboro onde House e a equipe cuidam do caso. Enquanto isso, House lida com a volta de Wilson para hospital e teme que seu amigo tenha mudado. ";

                        pictureBox8.Image = Properties.Resources.ep5_thumbnail_s5;

                        label1.Text = "Ep 5 - Sorte da Treze";

                        pictureBox9.Image = Properties.Resources.paciente_ep5_season5;

                        richTextBox2.Text = "Spencer é a mulher bissexual que Treze conhece em um bar e vai para a cama com quem sofre uma convulsão após fazerem sexo. Ela é interpretada pela atriz Angela Gots. Spencer foi levada ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro acompanhada pelo Dr. Hadley depois de sofrer uma convulsão tônico-clônica por cerca de três minutos. ";

                        label2.Text = "Spencer";

                        break;

                    case "Ep 6 - Alegria":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A equipe pega um caso de um paciente de meia-idade que sofre de sucessivos lapsos de tempo e sonambulismo. Eles logo descobrem que a filha de 12 anos também era sonâmbula. A saúde do homem piora e a sua filha também começa a apresentar novos sintomas. Enquanto isso, House descobre que Cuddy irá adotar um bebê dentro de duas semanas. No entanto, a mãe biológica do bebê aprensenta vermelhidão em um dos braços e Cuddy tem que tomar conta do caso, assumindo assim, duas funções: a de médica e a de mãe em potencial.";

                        pictureBox8.Image = Properties.Resources.ep6_thumbnail_s5;

                        label1.Text = "Ep 6 - Alegria";

                        pictureBox9.Image = Properties.Resources.paciente_ep6_season5;

                        richTextBox2.Text = "Jerry Harmon, nascido como Jamal Hammoud, é o paciente que sofre de desmaios no episódio Alegria. Ele é o pai de Samantha Harmon. Ele foi interpretado pelo ator Salvator Xuereb. Jerry chegou ao Hospital Universitário de Princeton-Plainsboro depois que sua filha voltou da escola e percebeu que não conseguia se lembrar do que fez durante a maior parte do dia. Ele pensou que apenas alguns momentos haviam se passado desde que ela saiu de casa, sete horas antes.  ";

                        label2.Text = "Jerry Harmon";

                        break;

                    case "Ep 7 - A Coceira":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um homem com agorafobia fica doente e se recusa deixar sua casa para ser tratado no hospital. Portanto, House e a equipe vão à casa dele para descobrir o que pode estar errado. Cameron se encarrega do caso porque ela já tinha tratado do homem no passado, e ela e o time improvisam maneiras de tratá-lo dentro de sua casa. Entretanto, a condição do paciente piora e fica difícil tratá-lo em sua casa, por isso House e o time esboçam um plano para levá-lo ao hospital para cirurgia sem que isso cause qualquer problema. Enquanto isso, Cameron e Chase tentam resolver problemas em seu relacionamento, e House lida com uma coceira impertinente, com Wilson fazendo suas próprias analogias sobre o problema.";

                        pictureBox8.Image = Properties.Resources.ep7_thumbnail_s5;

                        label1.Text = "Ep 7 - A Coceira";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Nozick é o paciente agorafóbico do episódio A Coceira. O paciente desmaiou em sua casa. Seus vizinhos contataram os serviços de emergência que arrombaram sua porta para recuperar o paciente. Porém, ao ser levado para fora, sofreu extrema ansiedade devido à agorafobia, atacou a equipe de emergência e voltou correndo para casa exigindo ficar sozinho. ";

                        label2.Text = "Nozick";

                        break;

                    case "Ep 8 - Emancipação":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "O time pega o caso de uma fabricante de uma indústria de 16 anos que tem seus pulmões infiltrados por um fluido durante o trabalho. A adolescente informa a House que é uma menor emancipada que cuida de si mesma desde que os pais morreram. O time começa o tratamento para problemas cardíacos, mas quando Kutner prefere simpatizar com a paciente em vez de obedecer House, ele e o time acham que ela pode não estar dizendo a verdade. Enquanto isso, Foreman pede permissão de House para trabalhar em uma triagem clínica e House rejeita a proposta. Para provar que pode trabalhar sem a supervisão de House, Foreman pega um caso pediátrico. Mas quando uma inexplicável doença leva a criança para beira da morte, Foreman começa a se questionar se pode viver livre da supervisão de House. ";

                        pictureBox8.Image = Properties.Resources.ep8_thumbnail_s5;

                        label1.Text = "Ep 8 - Emancipação";

                        richTextBox2.Text = "Sophia Isabel Velez é a menor emancipada do episódio Emancipação. Ela é interpretada pela atriz Emily Rios. A paciente foi levada ao Hospital Universitário de Princeton-Plainsboro depois de desmaiar em uma linha de montagem em seu local de trabalho enquanto discutia com um de seus subordinados. Jonah era o paciente de quatro anos que foi o primeiro caso individual de Eric Foreman como médico assistente no Hospital Universitário de Princeton-Plainsboro. Ele é filho de Melinda e irmão de Evan. Ele foi interpretado pelo ator Kyle Silverstein.";

                        label2.Text = "";

                        break;

                    case "Ep 9 - O Último Recurso":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um homem invade o escritório de Cuddy e faz House, Treze e vários doentes reféns. O que reivindica? Um diagnóstico. O homem faz de Treze cobaia dos seus tratamentos e House precisa terminar a batalha antes que a polícia de intervenção abra fogo.";

                        pictureBox8.Image = Properties.Resources.ep9_thumbnail_s5;

                        label1.Text = "Ep 9 - O Último Recurso";

                        pictureBox9.Image = Properties.Resources.paciente_ep9_season5;

                        richTextBox2.Text = "Jason é o paciente que manteve vários pacientes, Gregory House e Treze como reféns, para serem tratados no episódio O Último Recurso. Ele é interpretado pelo ator Željko Ivanek. O paciente vinha apresentando sérias dificuldades respiratórias, fadiga constante, palpitações cardíacas, insônia e erupções cutâneas intermitentes nos últimos dois anos. Ele consultou dezesseis médicos diferentes sem obter um diagnóstico. Ele havia feito três tomografias computadorizadas de corpo inteiro, duas ressonâncias magnéticas, sete exames de sangue e uma consulta de homeopatia.  ";

                        label2.Text = "Jason";

                        break;

                    case "Ep 10 - Deixa Comer Bolo":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma Personal Trainer tem um colapso durante um comercial. Enquanto isso, Treze está participando dos testes clínicos criados por Foreman; Kutner cria uma clínica médica online usando o nome de House; e Cuddy se muda para a sala de House enquanto a dela está sendo reformada. ";

                        pictureBox8.Image = Properties.Resources.ep10_thumbnail_s5;

                        label1.Text = "Ep 10 - Deixa Comer Bolo";

                        pictureBox9.Image = Properties.Resources.paciente_ep10_season5;

                        richTextBox2.Text = "Emmy é o ex-guru do fitness obeso no episódio Deixa Comer Bolo. Ela é retratada pela atriz Samantha Shelton. Emmy desmaiou após exercícios moderados quando ficou incapaz de respirar e caiu em uma série de assentos do estádio, quebrando o tornozelo no processo. Ela foi levada ao pronto-socorro do Hospital Universitário Princeton-Plainsboro. O caso foi atribuído ao Dr. House. ";

                        label2.Text = "Emmy";

                        break;

                    case "Ep 11 - Alegria para o Mundo":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma garota obesa que é ridicularizada por colegas de escola sofre alucinações e desmaios, House, Cuddy (ocupando o lugar de Foreman e Treze, ocupados com os testes), Taub e Kutner tentam resolver. Cuddy se apega pela menina, e House aposta com Wilson que pode ser gentil com um paciente.";

                        pictureBox8.Image = Properties.Resources.ep11_thumbnail_s5;

                        label1.Text = "Ep 11 - Alegria para o Mundo";

                        pictureBox9.Image = Properties.Resources.paciente_ep11_season5;

                        richTextBox2.Text = "Natalie Soellner é uma jovem com sobrepeso no episódio Alegria para o Mundo. Ela é interpretada pela atriz B.K. Cannon. Natalie é uma estudante do ensino médio de dezesseis anos com excesso de peso e vítima de bullying frequente, embora seja uma excelente aluna e voluntária frequente. No show de Natal da escola, ela apresenta tontura, tem alucinações visuais, começa a vomitar e desmaia, embora permaneça consciente. ";

                        label2.Text = "Natalie Soellner";

                        break;

                    case "Ep 12 - Sem Dor":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe são responsáveis por um paciente que sente uma dor interminável e incontrolável por todo o seu corpo e tenta cometer suicídio várias vezes para se livrar disso. Enquanto isso Cuddy está experimentando cuidar de seu novo bebê, Rachel, o que a deixa com menos tempo para o hospital e menos tempo para House. Foreman e Treze tentam lidar com os problemas de sua relação. ";

                        pictureBox8.Image = Properties.Resources.ep12_thumbnail_s5;

                        label1.Text = "Ep 12 - Sem Dor";

                        pictureBox9.Image = Properties.Resources.paciente_ep12_season5;

                        richTextBox2.Text = "Jeff foi o paciente que tentou suicídio no episódio Sem Dor.  Jeff sofria de dores crônicas agudas há muitos anos e nenhum médico conseguia encontrar uma causa ou cura, e ficou claro que o incidente no carro não foi sua primeira tentativa de suicídio. ";

                        label2.Text = "Jeff";

                        break;

                    case "Ep 13 - Bebê Enorme":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Cuddy decide passar mais tempo com sua bebê e deixa Cameron cuidando da Administração do Hospital. A equipe trata uma professora de pessoas especiais cuja bondade inerente é considerada um sintoma. Foreman toma uma importante decisão quanto a participação da Treze na triagem de drogas clínicas. ";

                        pictureBox8.Image = Properties.Resources.ep13_thumbnail_s5;

                        label1.Text = "Ep 13 - Bebê Enorme";

                        pictureBox9.Image = Properties.Resources.paciente_ep13_season5;

                        richTextBox2.Text = "Sarah é a professora que desmaia na aula no episódio Bebê Enorme. Ela é interpretada pela atriz Erika Flores. Sarah foi levada ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro depois de tossir sangue e desmaiar enquanto dava uma aula. ";

                        label2.Text = "Sarah";

                        break;

                    case "Ep 14 - O Bem Maior":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe tratam de uma mulher que tem um colapso em uma aula de Culinária. Quando eles descobrem que ela desistiu de sua carreira como renomada pesquisadora do câncer para procurar a felicidade em outro lugar, os membros da equipe começam a questionar sua felicidade (ou a falta dela). Enquanto isso, Treze experimenta as reações colaterais do seu tratamento para Huntington, e Cuddy retalia House dando a ele um gosto de sua própria medicina. ";

                        pictureBox8.Image = Properties.Resources.ep14_thumbnail_s5;

                        label1.Text = "Ep 14 - O Bem Maior";

                        pictureBox9.Image = Properties.Resources.paciente_ep14_season5;

                        richTextBox2.Text = "Dra. Dana Miller foi a ex-paciente oncologista do O Bem Maior. Ela é interpretada pela atriz Judith Scott. Dana estava na aula de culinária quando começou a perder o foco e tossir. Ela olhou para seu reflexo e percebeu que seus lábios estavam ficando azuis. Ela contou aos acompanhantes que apresentava cianose, dores nas costas e no peito e pneumotórax espontâneo. Ela disse a eles que era médica e, pouco antes de desmaiar, disse que precisava de um médico imediatamente. ";

                        label2.Text = "Dra. Dana Miller";

                        break;

                    case "Ep 15 - Infiel":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando um padre que ajuda sem-tetos vê Cristo sangrando em sua porta, ele é admitido no hospital. House pega o caso como distração enquanto ele confronta Foreman e Treze quanto ao relacionamentos dos dois. A equipe logo descobre que o padre tinha sido envolvido em um escândalo que o fez perder a sua fé. No entanto, tal como eles estão prestes a julgar o seu caso, a situação do doente fica drasticamente pior, e House encara seu passado e sua crença em pessoas sem fé. ";

                        pictureBox8.Image = Properties.Resources.ep15_thumbnail_s5;

                        label1.Text = "Ep 15 - Infiel";

                        pictureBox9.Image = Properties.Resources.paciente_ep15_season5;

                        richTextBox2.Text = "Padre Daniel Bresson é o padre da missão que chega ao hospital após ter uma alucinação com Jesus. Ele é interpretado pelo ator Jimmi Simpson. Após cumprir suas funções na missão, Padre Daniel ouviu batidas na porta e, ao abri-la, viu à sua frente Jesus Cristo flutuando e ferido. Ele foi ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro. ";

                        label2.Text = "Padre Daniel Bresson";

                        break;

                    case "Ep 16 - O Lado Mais Suave":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A equipe encontra um adolescente que teve um colapso com graves dores pélvicas após a jogar basquete. Testes revelam o menino tem mosaicismo genético, ou ambos do sexo masculino e feminino em seu DNA, e os pais do rapaz informam a House que o garoto nunca soube disso. Eles escolheram um gênero sexual para ele quando ele nasceu e foi criado em conformidade, nunca informando-o sobre a sua condição. No entanto, quando seu estado piora e sua vida está ameaçada, os pais se perguntam se eles fizeram a decisão certa. Enquanto isso, Cuddy e Wilson suspeitam que algo está errado com House, quando ele começa a agir agradavelmente. Quando eles descobrem que a chocante resposta, eles têm de enfrentar a perspectiva de que House pode estar sendo mudado para sempre. ";

                        pictureBox8.Image = Properties.Resources.ep16_thumbnail_s5;

                        label1.Text = "Ep 16 - O Lado Mais Suave";

                        pictureBox9.Image = Properties.Resources.paciente_ep16_season5;

                        richTextBox2.Text = "Jackson Smith era o paciente com mosaicismo genético no episódio O Lado Mais Suave, que desmaiou após um jogo de basquete. Ele é interpretado pelo ator Dominic Scott Kay. Jackson estava jogando basquete quando apertou a barriga e caiu inconsciente no chão. Ele não estava com nenhum sofrimento físico óbvio antes de desmaiar. Ele foi levado ao pronto-socorro do Hospital Universitário Princeton-Plainsboro, onde se queixou de dores persistentes na pélvis.";

                        label2.Text = "Jackson Smith";

                        break;

                    case "Ep 17 - O Contrato Social":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe pegam o caso de Nick (Jay Karnes), um editor de livros que perde sua inibição e insulta todos os seus colegas em um jantar uma noite antes de cair adoecido. O time descobre que Nick tem Inibição do Lobo Frontal, que faz com que ele vocalize todos os seus pensamentos, resultando em explosões de insultos. Nick faz observações sobre a equipe e ele tem que lidar com as consequências de ser incapaz de mentir para a esposa e outras pessoas importantes na vida dele. Enquanto isso, House suspeita que Wilson e Taub estão escondendo alguma coisa e decide descobrir o que é. ";

                        pictureBox8.Image = Properties.Resources.ep16_thumbnail_s5;

                        label1.Text = "Ep 17 - O Contrato Social";

                        pictureBox9.Image = Properties.Resources.paciente_ep17_season5;

                        richTextBox2.Text = "Nick Greenwald é o editor do livro com desinibição do lobo frontal no episódio O Contrato Social. Ele foi interpretado pelo ator Jay Karnes. Nick foi levado ao Hospital Universitário de Princeton-Plainsboro depois de não conseguir parar de fazer comentários maldosos sobre o autor para quem trabalhava e seus colegas em um jantar. Ele desenvolveu uma hemorragia nasal e desmaiou. ";

                        label2.Text = "Nick Greenwald";

                        break;

                    case "Ep 18 - Vem Cá Bichano":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A enfermeira Morgan (participação especial de Judy Greer) falsifica uma doença para conseguir a atenção de House quando um gato de estimação da casa onde ela trabalha dorme próximo a ela. Dizem que o gato alerta pessoas que estão prestes a morrer e isso se torna realidade com uma precisão alarmante. House tenta provar que essa teoria é falsa mas quando Morgan tem um colapso, ele e sua equipe terão que ir ao fundo desse mistério. ";

                        pictureBox8.Image = Properties.Resources.ep18_thumbnail_s5;

                        label1.Text = "Ep 18 - Vem Cá Bichano";

                        pictureBox9.Image = Properties.Resources.paciente_ep18_season5;

                        richTextBox2.Text = "Morgan West é a enfermeira que engana House fazendo-o pensar que ela está doente porque o “gato da morte” a escolheu. Ela aparece no episódio Vem Cá Bichano. Ela é interpretada pela atriz Judy Greer. Morgan veio à clínica e foi designado para cuidar do Dr. House. Ela reclamou de ter resfriado durante todo o inverno e de se sentir esgotada, como se alguma doença grave estivesse surgindo. Ela não tinha dor de garganta nem coriza. Ela pediu ao Dr. House para fazer um hemograma completo e um exame de tireoide, então desmaiou e teve uma convulsão. ";

                        label2.Text = "Morgan West";

                        break;

                    case "Ep 19 - Encarcerado":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Em um episódio especial de House, é mostrado o caso de Lee (participação especial de Mos Def), um homem que acorda em Nova York, após um acidente de bicicleta, incapaz de se mover ou se comunicar de qualquer forma. House, ferido depois de um acidente de moto, ocupa uma cama próxima a Lee e rapidamente começa a incomodar os doutores que o tratam insitindo que Lee tem a síndrome do encarceramento. Depois de House transferir Lee para o Hospital Princeton Plainsboro, a equipe tenta \"desencarcerá-lo\". Enquanto isso, Wilson suspeita que House esconde algo desde sua visita a Nova York. ";

                        pictureBox8.Image = Properties.Resources.ep19_thumbnail_s5;
                        button1.Visible = false;
                        button2.Visible = false;

                        label1.Text = "Ep 19 - Encarcerado";

                        pictureBox9.Image = Properties.Resources.paciente_ep19_season5;

                        richTextBox2.Text = "Lee é o paciente que sofre de síndrome do encarceramento no episódio Encarcerado. Ele é interpretado pelo ator e rapper Mos Def. Lee foi levado ao pronto-socorro de um hospital em Middletown, Nova York, após sofrer um acidente catastrófico de bicicleta. Ele permaneceu inconsciente e teve atividade EEG insignificante. Como tal, seu médico assistente considerou que ele estava com morte cerebral e planos foram feitos para colher seus órgãos para transplante.  ";

                        label2.Text = "Lee";

                        break;

                    case "Ep 20 - Explicação Simples":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "O hospital todo sofre um forte abalo, enquanto Charlotte (participação especial de Colleen Camp), uma senhora que passou 6 meses cuidando de seu marido Eddie (participação especial de Meat Loaf), quando ela tem um colapso respiratório. O casal se torna um mistério para a equipe quando Eddie começa a melhorar e Charlotte, a piorar. O impensável começa a se tornar realidade quando parece que Charlotte morrerá antes que seu marido e a equipe tem que fazer uma difícil decisão. Nesse Episódio, um acontecimeto, mudará totalmente a equipe de House, e a ele mesmo.";

                        pictureBox8.Image = Properties.Resources.ep20_thumbnail_s5;

                        label1.Text = "Ep 20 - Explicação Simples";

                        pictureBox9.Image = Properties.Resources.paciente_ep20_season5;

                        richTextBox2.Text = "Eddie Novack é o paciente aparentemente terminal do episódio \"Explicação Simples\". Ele é o marido de Charlotte Novack. Ele foi interpretado pelo ator/cantor Meat Loaf. Charlotte afirmou que Eddie melhorou quando ela começou a ficar doente, pois ele conseguiu se sentar na cama para pedir ajuda. No entanto, o Dr. House atribuiu isso a uma onda de adrenalina.";

                        label2.Text = "Eddie Novack";

                        break;

                    case "Ep 21 - Os Salvadores":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Cameron adia suas férias com Chase para pedir a House que aceite o caso de um ambientalista radical que tem um colapso no meio de um protesto. Suspeito com os motivos dela, House aceita. Desde que ela o colocou no caso, House força Cameron à tomar a liderança e fazer vários testes no paciente. Enquanto isso, House está inseguro com nova dieta saudável de Wilson. ";

                        pictureBox8.Image = Properties.Resources.ep21_thumbnail_s5;

                        label1.Text = "Ep 21 - Os Salvadores";

                        pictureBox9.Image = Properties.Resources.paciente_ep21_season5;

                        richTextBox2.Text = "Doug Svensen é o ativista ambiental que foi paciente no episódio Salvadores. O paciente foi internado após ficar desorientado e incapaz de ficar de pé enquanto protestava em uma manifestação ambiental, embora tenha mantido a consciência.";

                        label2.Text = "Doug Svensen";

                        break;

                    case "Ep 22 - O House Dividido":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "O episódio mostra o caso de um garoto surdo de 14 anos, Seth (Ryan Lane), que tem um colapso no meio de uma competição de Luta depois de 'ouvir' explosões é levado ao Princeton-Plainsboro, e a equipe enfranta um dilema ético com a mãe de Seth (Clare Carey) sobre um implante coclear. Enquanto isso, House sofre de falta de sono, e começa a jogar truques com a própria mente. Entretanto, House decide que precisa de ajuda e visita Cuddy.";

                        pictureBox8.Image = Properties.Resources.ep22_thumbnail_s5;

                        label1.Text = "Ep 22 - O House Dividido";

                        pictureBox9.Image = Properties.Resources.paciente_ep22_season5;

                        richTextBox2.Text = "Seth Miller é o paciente surdo do episódio O  House Dividido. O paciente ficou profundamente surdo aos 4 anos de idade, uma complicação da meningite. As partes do cérebro que recebem e processam o som não estão danificadas, mas os nervos entre os ouvidos e o cérebro foram danificados e não funcionam. O paciente foi internado quando começou a ter a sensação de ouvir ruídos explosivos na cabeça. Dr. Foreman apontou que as causas mais comuns dessa sensação são insônia, enxaquecas e traumatismo cranioencefálico. No entanto, o paciente não teve nenhum desses problemas.";

                        label2.Text = "Seth Miller";

                        break;

                    case "Ep 23 - Embaixo da Minha Pele":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe são desafiados com o caso de uma bailarina (Jamie Tisdale) que teve um colapso pulmonar durante uma performance. Após enfrentar a perspectiva de jamais dançar de novo, o futuro da bailarina se torna mais sinistro quando o tratamento faz com que sua pele comece a descamar. House precisa resolver esse enigma enquanto tenta curar sua insônia. ";

                        pictureBox8.Image = Properties.Resources.ep23_thumbnail_s5;

                        label1.Text = "Ep 23 - Embaixo da Minha Pele";

                        pictureBox9.Image = Properties.Resources.paciente_ep23_season5;

                        richTextBox2.Text = "Penelope é a paciente bailarina do episódio Embaixo da Minha Pele. Ela é interpretada pela atriz Jamie Tisdale. A paciente foi internada quando apresentou dificuldade para respirar após cair da altura dos ombros durante o ensaio. Não havia sinais de trauma, tumores, perfurações nos pulmões, hematomas ou DST. Apesar de estar a tomar oxigénio suplementar, o seu nível de oxigénio no sangue nunca foi superior a 60% e os seus pulmões continuaram a colapsar apesar da presença de um dreno torácico. ";

                        label2.Text = "Penelope";

                        break;

                    case "Ep 24 - Agora os Dois Lados":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe ficam intrigados com o caso de Scott (Participação especial de Ashton Holmes), um homem que teve o lado esquerdo e direito do cérebro operados independentemente, levando-o a ter duas personalidades distintas e nenhum controle sobre suas ações. Os dois lados do cérebro lutam por dominação, o que dificulta a descoberta do problema. A equipe é forçada a usar métodos não usuais para ele cooperar. Enquanto isso, quando House se recusa a ir a clínica, Cuddy faz com que House gaste seu tempo com um paciente em particular";

                        pictureBox8.Image = Properties.Resources.ep24_thumbnail_s5;

                        label1.Text = "Ep 24 - Agora os Dois Lados";

                        pictureBox9.Image = Properties.Resources.paciente_ep24_season5;

                        richTextBox2.Text = "Scott é um paciente que passou recentemente por uma cirurgia no cérebro, fazendo com que o hemisfério direito de seu cérebro fosse uma pessoa diferente do esquerdo. Enquanto janta com a esposa, sua mão esquerda joga pãezinhos em alguém. Quando a pessoa o confronta, sua mão esquerda derrama a bebida sobre ele e uma lágrima de sangue aparece em seu olho.";

                        label2.Text = "Scott";

                        break;

                    //Temporada 6 ----------------------------------------------

                    case "Ep 1.1 e 1.2 - Derrotado ":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House passa por desintoxicação, na esperança de parar de ter as alucinações que o atormentam. Dr. Nolan se recusa a assinar os papéis que permitem a restituição da licença médica de House, a menos que House participe, de fato, da própria recuperação mental. House leva um paciente, que acredita ser um super-herói, para um parque de diversões. Lá eles vão a um avião de brinquedo, fazendo o paciente acreditar que pode voar. Depois que o paciente se joga de um edifício, House concorda que precisa de ajuda e vai procurar Dr. Nolan para fazer o tratamento. Depois de fazer o tratamento, House é considerado saudável o suficiente para deixar Mayfield.";

                        pictureBox8.Image = Properties.Resources.ep1_thumbnail_s6;

                        label1.Text = "Ep 1.1 e 1.2 - Derrotado";

                        pictureBox9.Image = Properties.Resources.paciente_ep2_season6;

                        richTextBox2.Text = "---";

                        label2.Text = "Sem paciente";

                        break;

                    case "Ep 3 - O Grande Fiasco":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House se demite do hospital, Foreman assume enquanto lida com um paciente que insiste em se envolver no diagnóstico e chega a colocar uma recompensa na internet para quem diagnosticar corretamente, Foreman e treze tem problemas no relacionamento e no trabalho, enquanto Wilson e Cuddy se preocupam se House voltou a se drogar. ";

                        pictureBox8.Image = Properties.Resources.ep3_thumbnail_s6;

                        label1.Text = "Ep 3 - O Grande Fiasco";

                        pictureBox9.Image = Properties.Resources.paciente_ep3_season6;

                        richTextBox2.Text = "Vince Pearson foi o desenvolvedor de videogame que foi o primeiro caso de Foreman como chefe indiscutível do departamento de diagnóstico no episódio O Grande Fiasco . Ele foi interpretado pelo ator Rick D. Wasserman. Vince chegou ao hospital com a sensação de que suas mãos estavam pegando fogo. Na sala de emergência, seu caso foi entregue ao Dr. Hadley, que descartou síndrome do túnel do carpo e trauma, e fez uma bateria completa de exames de sangue que deram normal. ";

                        label2.Text = "Vince Pearson";

                        break;

                    case "Ep 4 - O Tirano":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A equipe trata um controverso político africano chamado Dibala que adoeceu enquanto estava vindo à América fazer um discurso na Organização das Nações Unidas. Enquanto isso, Wilson tenta se conciliar com um vizinho hostil (Murphy), sobrevivente da Guerra do Vietnã.";

                        pictureBox8.Image = Properties.Resources.ep4_thumbnail_s6;

                        label1.Text = "Ep 4 - O Tirano";

                        pictureBox9.Image = Properties.Resources.paciente_ep4_season6;

                        richTextBox2.Text = "O Presidente Dibala foi o implacável ditador africano que foi o paciente no episódio O Tirano. Ele foi morto pelo tratamento que Foreman lhe deu porque Chase mascarou qual era a verdadeira doença de Dibala. Dibala foi internado após vomitar sangue. Dra. Cameron O caso foi atribuído ao Dr. Foreman, que pediu a ajuda do Dr. Chase e Dra. Cameron. opôs-se ao tratamento de Dibala, mas o Dr. Cuddy observou que o Presidente Dibala era um convidado do governo dos EUA e pediu-lhe que permanecesse.";

                        label2.Text = "O Presidente Dibala";

                        break;

                    case "Ep 5 - Carma Urgente":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Mesmo sem licença médica, House atende o filho do bilionário Roy Randall, que sofre de uma doença misteriosa. O pai acredita ser um mal causado por carma. Tudo que toca vira dinheiro mas, segundo crê, isso está afetando negativamente a sua família. Enquanto isso, Foreman tenta encobrir as provas da alteração, feita por Chase, dos exames de Dibala (episódio anterior).";

                        pictureBox8.Image = Properties.Resources.ep5_thumbnail_s6;

                        label1.Text = "Ep 5 - Carma Urgente";

                        pictureBox9.Image = Properties.Resources.paciente_ep5_season6;

                        richTextBox2.Text = "Jack Randall era o menino com uma doença inexplicável no episódio Carma Urgente. Ele foi interpretado pelo ator Tanner Maguire. Jack consultou 17 médicos que não conseguiram diagnosticar suas condições. Jack foi tratado com antibióticos, mas a febre e a dor abdominal pioraram. Clostridium difficile foi descartado, assim como insuficiência renal por diabetes mellitus. A febre e a dor aumentavam de intensidade e Jack também sofria de desidratação, diarreia e perda de peso. Ele não estava acampando e sua única viagem fora dos Estados Unidos foi para o Canadá.";

                        label2.Text = "Jack Randall";

                        break;

                    case "Ep 6 - Coração Valente":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um policial pensa que vai morrer em breve, aos 40 anos, pela mesma doença que matou seu pai, avô e bisavô, e por isso não quer começar uma família, para não deixar um filho sozinho como aconteceu com ele. Mas o que Dony não sabia é que já tinha um filho com uma ex-namorada. Enquanto isso, House tem motivos para acreditar estar tendo alucinações novamente e busca investigar a causa. ";

                        pictureBox8.Image = Properties.Resources.ep6_thumbnail_s6;

                        label1.Text = "Ep 6 - Coração Valente";

                        pictureBox9.Image = Properties.Resources.paciente_ep6_season6;

                        richTextBox2.Text = "Donny Compson é o imprudente detetive da polícia que tem certeza de que morrerá antes de completar 40 anos no episódio Coração Valente. Ele é interpretado pelo ator Jon Seda. anto o pai de Donny, quanto o avô paterno e o bisavô da linha paterna morreram de insuficiência cardíaca logo após completar 40 anos. Como resultado, Donny se tornou fatalista e corre riscos em seu trabalho, resultando em vários ossos quebrados e outros ferimentos. Donny foi levado ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro quando caiu de aproximadamente 9 metros enquanto perseguia um suspeito. ";

                        label2.Text = "Donny Compson";

                        break;

                    case "Ep 7 - Verdades Não Ditas":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House descobriu que Cuddy está namorando o detetive Lucas, que havia sido contratado por ele para vigiar Wilson. O médico ranzinza se declara para ela em uma festa do congresso que participavam. Mas Cuddy alega que é mãe e precisa de alguém que lhe dê segurança. House também prova ser um bom amigo.";

                        pictureBox8.Image = Properties.Resources.ep7_thumbnail_s6;

                        label1.Text = "Ep 7 - Verdades Não Ditas";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Jordan é a adolescente que sofre de apêndices gravemente inchados e dificuldades de memória no episódio Verdades Não Ditas. Ela é interpretada pela atriz Annabelle Attanasio. Enquanto Jordan tomava café da manhã com alguns amigos, um deles percebeu que seu pé direito estava inchado. Ela então percebeu que suas mãos estavam inchando e ela desmaiou. ";

                        label2.Text = "Jordan";

                        break;

                    case "Ep 8 - Trabalho em Equipe":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "O ator de filmes pornográficos Hank Hardwick sente dores pulsantes nos olhos. Durante todo o episódio, House tenta reunir sua antiga equipe, com Foreman, Cameron, Chase, Treze, e Taub. Taub e Treze inicialmente recusam, mas depois aceitam. Nesse episódio Cameron deixa a equipe e volta para Chicago, mas antes diz que amava o House e irá partir pos Chase não estava sabendo diferenciar o certo e o errado. No final mostra Lucas e Cuddy andando pelo saguão da Princeton-Plainsboro e House os olhando.";

                        pictureBox8.Image = Properties.Resources.ep8_thumbnail_s6;

                        label1.Text = "Ep 8 - Trabalho em Equipe";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Hank Hardwick (nascido Henry Lefkowitz) é o astro de cinema adulto que começa a sofrer de fotofobia no episódio Trabalho em Equipe. Ele é interpretado pelo ator Troy Garity. Como estrela de cinema adulto, Hank teve vários parceiros sexuais e percebe que corre risco de contrair doenças sexualmente transmissíveis. Ele faz exames a cada três meses e já foi tratado para essas doenças no passado. Hank foi levado ao Hospital Universitário de Princeton-Plainsboro depois de reclamar de dor de cabeça e irritação nos olhos e gritar de dor quando as luzes do estúdio foram acesas sobre ele.";

                        label2.Text = "Hank Hardwick";

                        break;

                    case "Ep 9 - Santa Ignorância":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Na véspera do dia de Ação de Graças, House e sua equipe pegam o caso de James Sidis, um gênio com QI de 178 que largou tudo para ser entregador. House tenta acabar com relacionamento de Lucas e Cuddy. Cuddy diz que terminou com Lucas mas no final House descobre que ela mentiu para ele.";

                        pictureBox8.Image = Properties.Resources.ep9_thumbnail_s6;

                        label1.Text = "Ep 9 - Santa Ignorância";

                        pictureBox9.Image = Properties.Resources.paciente_ep8_season6;

                        richTextBox2.Text = "James Sidas é um físico e escritor excepcionalmente brilhante que trocou sua carreira de sucesso por um emprego como mensageiro. A pessoa mais jovem a se formar no MIT, ele tem um QI de 178 e publicou três livros e 35 artigos, todos antes dos 18 anos. Ele é interpretado pelo ator Esteban Powell. É possível que Shore tenha baseado Sidas em William James Sidis, um prodígio matemático e linguístico. Sidas foi internado no hospital quando se viu desorientado e incapaz de controlar o movimento da mão. Ao exame, descobriu-se que ele tinha ataxia, anemia e tosse leve. ";

                        label2.Text = "James Sidas";

                        break;

                    case "Ep 10 - Wilson":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Wilson trata um amigo que foi seu paciente anteriormente, por leucemia, e após um tratamento arriscado, causando falência hepática, Wilson deve decidir se dará ou não um pedaço de seu fígado a Tucker.";

                        pictureBox8.Image = Properties.Resources.ep10_thumbnail_s6;

                        label1.Text = "Ep 10 - Wilson";

                        pictureBox9.Image = Properties.Resources.paciente_ep9_season6;

                        richTextBox2.Text = "Tucker é o paciente do episódio Wilson, um velho amigo e ex-paciente de Wilson. Ele e Wilson vão caçar todos os anos para comemorar que ele ainda está livre do câncer. Tucker foi diagnosticado com leucemia pelo Dr. Wilson em 30 de maio de 2004. Naquela época, ele tinha cerca de seis meses de vida se seu tratamento não desse certo. No entanto, Wilson o tratou com quimioterapia e ele sobreviveu por mais seis meses. Em 2009, ele já havia passado cinco anos sem mais sintomas e continua amigo íntimo de Wilson. Enquanto caçava, Tucker de repente perdeu o controle das pernas e tornou-se incapaz de mover o braço. Wilson suspeitou de um derrame, mas conseguiu levá-lo de volta ao carro e ao Hospital Universitário de Princeton-Plainsboro. ";

                        label2.Text = "Tucker";

                        break;

                    case "Ep 11 - Segredos":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando o traficante Mickey misteriosamente desmaia no meio de uma negociação seu parceiro leva-o ao Hospital Princeton Plainsboro para descobrir a causa de seu problema. Enquanto isso House e Wilson travam uma batalha para ver quem conseguirá ter a nova vizinha ao seu lado. ";

                        pictureBox8.Image = Properties.Resources.ep11_thumbnail_s6;

                        label1.Text = "Ep 11 - Segredos";

                        pictureBox9.Image = Properties.Resources.paciente_ep10_season6;

                        richTextBox2.Text = "Mickey é o policial disfarçado envolvido em um tráfico de drogas que desmaia toda vez que ouve um barulho alto no episódio Segredos. Ele é interpretado pelo ator Ethan Embry. O paciente procurou tratamento para lacerações faciais. No entanto, ele não revelou a causa de seus ferimentos e recusou-se a compartilhar seu histórico médico com os médicos ou a orientá-los sobre quaisquer registros médicos anteriores. A única informação que ele compartilhou foi que, três anos antes, ele havia sofrido de distensão nas costas.";

                        label2.Text = "Mickey";

                        break;

                    case "Ep 12 - Remorso":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House decide aceitar o caso de uma bonita executiva devido à sua beleza, e os outros homens da equipe ficam igualmente encantados. Apenas Thirteen não é afetada enquanto eles tentam determinar a causa de sua doença. Enquanto isso, House tenta resolver seu passado com um antigo colega de faculdade com quem ele foi injusto. ";

                        pictureBox8.Image = Properties.Resources.ep12_thumbnail_s6;

                        label1.Text = "Ep 12 - Remorso";

                        pictureBox9.Image = Properties.Resources.paciente_ep11_season6;

                        richTextBox2.Text = "Valerie é a jovem executiva que ouve ruídos explosivos que não existem e que Treze determina ser um psicopata no episódio Remorso. Ela é interpretada pela atriz Beau Garrett. O paciente chegou ao Hospital Universitário de Princeton-Plainsboro reclamando de intensa dor de ouvido intermitente. Ela já havia consultado outros seis médicos que não conseguiram chegar a um diagnóstico. O Dr. House concordou em aceitar o caso. ";

                        label2.Text = "Valerie";

                        break;

                    case "Ep 13 - Família é Família":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe correm para tratar um jogador de futebol a tempo dele competir nos testes para NFL. Porém quando o paciente experiencia um ataque violento de sintomas não usuais, a equipe enfrenta problemas para chegar a um consenso sobre o melhor tratamento. Enquanto isso, o irmão de Foreman faz uma visita surpresa ao hospital. ";

                        pictureBox8.Image = Properties.Resources.ep13_thumbnail_s6;

                        label1.Text = "Ep 13 - Família é Família";

                        pictureBox9.Image = Properties.Resources.paciente_ep12_season6;

                        richTextBox2.Text = "Daryl foi o jogador de futebol americano universitário e candidato profissional no episódio Família é Família. Ele foi interpretado pelo ator Da'Vone McDonald. Daryl joga como atacante ofensivo. Ele tem 6'7 de altura e pesa 310 libras. Ele recebe regularmente injeções de lidocaína para lidar com a dor das lesões no futebol. Daryl perdeu a paciência em um jogo de futebol e começou a espancar o jogador que ele estava bloqueando durante o jogo. No entanto, , após o incidente, ele continuou batendo na cabeça com o capacete. ";

                        label2.Text = "Daryl";

                        break;

                    case "Ep 14 - Um Dia Daqueles":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Cuddy tira um dia para cuidar si quando ela precisa lidar com sua vida pessoal, profissional e com House e sua equipe.";

                        pictureBox8.Image = Properties.Resources.ep14_thumbnail_s6;

                        label1.Text = "Ep 14 - Um Dia Daqueles";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "---";

                        label2.Text = "Sem paciente";

                        break;

                    case "Ep 15 - Vidas Particulares":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A equipe trata um blogueira famosa, mas encontram dificuldades em tratá-la, quando ela insiste em discutir todos os procedimentos e os médicos em seu blog. Enquanto isso, House e Wilson acabam descobrindo segredos um do outro.";

                        pictureBox8.Image = Properties.Resources.ep15_thumbnail_s6;

                        label1.Text = "Ep 15 - Vidas Particulares";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Frankie foi a blogueira admitida em Princeton Plainsboro no episódio Vidas Particulares. Ela foi interpretada pela atriz Laura Prepon. Frankie é vegetariana há vários meses, embora continue a comer peixe. Frankie chegou ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro depois de apresentar vários hematomas no rosto e sangramento pela boca. Ela foi internada para observação depois que os médicos determinaram que ela tinha algum tipo de colaguopatia. ";

                        label2.Text = "Frankie";

                        break;

                    case "Ep 16 - Buraco Negro":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma estudante tem uma doença que a equipe tem dificuldades em diagnosticar. Enquanto isso, Taub tem problemas no relacionamento. Há um desafio da parte de House para Wilson comprar mobília nova.";

                        pictureBox8.Image = Properties.Resources.ep16_thumbnail_s6;

                        label1.Text = "Ep 16 - Buraco Negro";

                        pictureBox9.Image = Properties.Resources.paciente_ep16_season6;

                        richTextBox2.Text = "Abby Nash é a adolescente que sofre de alucinações no episódio Buraco Negro. Ela é interpretada pela atriz Cali Fredrichs. Abby foi levada às pressas para o Hospital Universitário de Princeton-Plainsboro quando seu namorado percebeu que uma espuma rosa escorria de sua boca e ela parou de respirar enquanto eles estavam juntos em um show de planetário. ";

                        label2.Text = "Abby Nash";

                        break;

                    case "Ep 17 - Trancado":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;
 
                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando um recém-nascido desaparece da maternidade, o hospital Princeton Plainsboro entra em confinamento, impedindo qualquer um de entrar, sair ou mudar de área dentro do hospital. House e sua equipe estão presos em várias partes do prédio: Foreman e Taub na sala de arquivo, Wilson e Treze na cafeteria, House em um quarto com um paciente (David Strathairn) e Chase com a sua ex-mulher Cameron. Enquanto Isso, Cuddy ajuda a polícia a achar o bebê. ";

                        pictureBox8.Image = Properties.Resources.ep17_thumbnail_s6;

                        label1.Text = "Ep 17 - Trancado";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "---";

                        label2.Text = "Sem paciente";

                        break;

                    case "Ep 18 - A Queda do Cavaleiro":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Ep 18 - A Queda do Cavaleiro";

                        pictureBox8.Image = Properties.Resources.ep18_thumbnail_s6;

                        label1.Text = "Ep 18 - A Queda do Cavaleiro";

                        pictureBox9.Image = Properties.Resources.paciente_ep18_season6;

                        richTextBox2.Text = "Sir William é o \"cavaleiro\" que desmaiou após derrotar outro cavaleiro durante uma batalha em uma feira renascentista no episódio A Queda do Cavaleiro. Ele foi interpretado pelo ator Noah Segan. Depois de derrotar um adversário muito maior, William ficou desorientado. Quando ele tirou o capacete, a Rainha Shannon percebeu que o branco dos olhos de Williams estava vermelho. Ele logo desmaiou. King Miles ligou para o 911 pedindo uma ambulância.";

                        label2.Text = "Sir William";

                        break;

                    case "Ep 19 - Aberto ou Fechado?":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e a sua equipe ficam com o caso de Julia, que tem um casamento aberto e fica doente durante um encontro com o seu namorado. Por mais perplexo que possa parecer, Julia é feliz e saudável, mas a sua poliandria deixa a equipe desorientada. Entretanto, House testa o relacionamento de Wilson com Sam.";

                        pictureBox8.Image = Properties.Resources.ep19_thumbnail_s6;

                        label1.Text = "Ep 19 - Aberto ou Fechado?";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Julia era a mulher do casamento aberto que foi a paciente do episódio 'Aberto ou Fechado?'. Ela foi interpretada pela atriz Sarah Wayne Callies. Enquanto estava com seu amante Damien, Julia começou a reclamar de dores de estômago. Ela chamou por seu marido Tom. Ela foi levada ao pronto-socorro do Hospital Universitário Princeton-Plainsboro. Ela estava com febre, mas eles conseguiram descartar a maioria das condições comuns que causam febre e dor abdominal. ";

                        label2.Text = "Julia";

                        break;

                    case "Ep 20 - Questão de Escolha":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A equipe tenta diagnosticar a doença do noivo de uma mulher, e ela fica surpresa ao descobrir os segredos que ele vem guardando dela. Entretanto, House decide aproveitar as suas horas livres para sair e cantar com Chase e Foreman. ";

                        pictureBox8.Image = Properties.Resources.ep20_thumbnail_s6;

                        label1.Text = "Ep 20 - Questão de Escolha";

                        pictureBox9.Image = Properties.Resources.paciente_ep20_season6;

                        richTextBox2.Text = "Theodore Philip \"Ted\" (ou \"Teddy\") Taylor foi o paciente no episódio Questão de Escolha. Ele foi interpretado pelo ator Adam Garcia. \r\nTed foi levado ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro quando se viu incapaz de falar em seu casamento com sua noiva Nicole, depois se viu incapaz de respirar adequadamente e desmaiou.\r\n";

                        label2.Text = "Theodore Philip Taylor";

                        break;

                    case "Ep 21 - Bagagem":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Durante uma sessão com Dr. Nolan, House reconta o caso de uma mulher que chega às emergências do Hospital Princeton Plainsboro com uma doença misteriosa e sem se lembrar quem ela é. Enquanto tenta descobrir a doença, House precisa de ajudá-la a relembrar sua identidade. ";

                        pictureBox8.Image = Properties.Resources.ep21_thumbnail_s6;

                        label1.Text = "Ep 21 - Bagagem";

                        pictureBox9.Image = Properties.Resources.paciente_ep21_season6;

                        richTextBox2.Text = "Sidney Merrick, originalmente conhecida como \"Sra. X\", era a paciente que sofria de perda de memória no episódio Bagagem. Ela foi interpretada pela atriz Zoe McLellan. Sidney foi levada ao Hospital Universitário de Princeton-Plainsboro quando quase foi atropelada por um veículo enquanto corria. Logo foi determinado que ela estava desorientada e sofrendo de amnésia. ";

                        label2.Text = "Sidney Merrick";

                        break;

                    case "Ep 22 - Me Ajude":
                        groupBox6.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A equipe trabalha durante uma catástrofe. Cuddy, House e a equipe se juntam a uma unidade de busca e resgate para atender os que mais precisam de cuidados médicos no local onde ocorre uma emergência. ";

                        pictureBox8.Image = Properties.Resources.ep21_thumbnail_s6;

                        label1.Text = "Ep 22 - Me Ajude";

                        richTextBox2.Text = "Jay Dolce foi o operador de guindaste que adormeceu no trabalho causando um colapso e vários ferimentos e morte no episódio Me Ajude. Ele foi interpretado pelo ator Doug Kruse. Muitos funcionários do Hospital Universitário de Princeton-Plainsboro estavam ajudando no colapso de um guindaste em Trenton, Nova Jersey, quando a equipe de emergência finalmente chegou ao operador de guindaste ferido, Jay. Hanna era a mulher presa sob o concreto caído no episódio Me Ajude. Ela é a esposa de Charles. Ela foi interpretada pela atriz China Shavers. Em maio de 2010, um guindaste desabou sobre um prédio em Trenton, Nova Jersey, ferindo e matando mais de cem pessoas. Médicos de vários hospitais em um grande raio da cidade foram chamados ao local para fazer triagem e administrar primeiros socorros. Gregory House, um diagnosticador do Hospital Universitário de Princeton-Plainsboro, ouviu um barulho nos escombros de alguém batendo em um cano próximo. Ele alertou o pessoal de emergência no local, mas eles não conseguiram detectar nenhum som na área e seus cães não conseguiram sentir o cheiro. O Dr. House decidiu investigar mais a fundo e rastejou até o estacionamento. De repente, alguém pegou sua bengala e pediu ajuda.";

                        label2.Text = "";

                        break;

                    //Temporada 7 ----------------------------------------------

                    case "Ep 1 - E Agora?":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e Cuddy decidem explorar a relação, e tirar uma folga do hospital. Enquanto isso, a equipe precisa resolver problemas no hospital; Chase, Foreman e Taub desconfiam que Treze vai fazer um tratamento experimental em Roma.";

                        pictureBox8.Image = Properties.Resources.ep1_thumbnail_s7;

                        label1.Text = "Ep 1 - E Agora?";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "---";

                        label2.Text = "Sem Paciente";

                        break;

                    case "Ep 2 - Egoísta":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e Cuddy decidem revelar o namoro deles para o hospital. Uma garota ativa (convidada especial Alyson Stoner) precisa de transplante de pulmão e é compatível com o irmão, o que reduziria significantemente a vida dele que tem DCM. House e Cuddy tentam lidar com o relacionamento no trabalho. ";

                        pictureBox8.Image = Properties.Resources.ep2_thumbnail_s7;

                        label1.Text = "Ep 2 - Egoísta";

                        pictureBox9.Image = Properties.Resources.paciente_ep2_season7;

                        richTextBox2.Text = "Della é uma skatista adolescente que desmaiou na pista de skate no episódio Egoísta. Ela é interpretada pelo ator Alyson Stoner. A paciente participa de diversas atividades atléticas, incluindo skate competitivo e basquete. A paciente desmaiou durante uma apresentação de skate. Ela foi levada para o Hospital Universitário Princeton-Plainsboro. No caminho, os CMTs chegaram à conclusão de que o coração dela havia parado. A sala de emergência descobriu uma arritmia. ";

                        label2.Text = "Della";

                        break;

                    case "Ep 3 - Entrelinhas":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Alice Tanner, famosa escritora de uma série de livros, tenta se suicidar mas fracassa ao sofrer uma convulsão enquanto tentava atirar em sua própria boca. Enquanto desvenda a doença e os motivos que geram na mulher no desejo de se matar, House também tenta encontrar gostos em comum entre ele e Cuddy. ";

                        pictureBox8.Image = Properties.Resources.ep3_thumbnail_s7;

                        label1.Text = "Ep 3 - Entrelinhas";

                        pictureBox9.Image = Properties.Resources.paciente_ep3_season7;

                        richTextBox2.Text = "Alice Tanner é a autora da popular série de livros \"Jack Cannon: Boy Detective\" no episódio Entrelinhas. Ela é interpretada pela atriz Amy Irving. Alice foi internada no pronto-socorro do Hospital Universitário de Princeton-Plainsboro quando sua empregada descobriu que ela havia convulsionado e desmaiado em seu escritório. Não havia nenhum médico disponível no pronto-socorro para cuidar de Alice imediatamente, mas a notícia se espalhou para o Dr. House, que era um grande fã de seu trabalho e decidiu examiná-la. ";

                        label2.Text = "Alice Tanner";

                        break;

                    case "Ep 4 - Massoterapia":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe tratam de uma mulher que sofrem de vômitos graves, mas no decorrer do tratamento, a equipe descobre que ela não é quem ela diz que é. Além disso, um novo membro da equipe de House é recebido com uma prova de fogo. Enquanto isso, a massagista de House faz com que House e Cuddy encarem o fato de que ambos têm reservas sobre a sua relação. ";

                        pictureBox8.Image = Properties.Resources.ep4_thumbnail_s7;

                        label1.Text = "Ep 4 - Massoterapia";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Margaret McPherson é a paciente do episódio Massoterapia. Ela foi interpretada pela atriz Erin Cahill. Ela é a esposa de Billy McPherson. Billy levou Margaret ao Hospital Universitário de Princeton-Plainsboro depois que ela começou a reclamar de dores de estômago e a vomitar. O caso foi atribuído ao Dr. House. Foreman relatou que, além da forte dor de estômago e vômitos, a paciente vinha sofrendo de menos dor nos três dias anteriores e seus testes da função hepática estavam elevados.";

                        label2.Text = "Margaret McPherson";

                        break;

                    case "Ep 5 - Paternidade Indesejada":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando uma criança sofre com problemas respiratórios e falência renal, House e sua equipe precisam investigar o histórico médico da mãe para descobrir uma resposta. Eles chegam a um diagnóstico que força a mãe a colocar em risco não apenas a saúde de seu filho mas também a sua. Enquanto isso, Taub e Foreman devem encontrar uma nova médica para ocupar o lugar deixado por Thirteen. House e Wilson aprendem algumas coisas sobre paternidade quando tomam conta da filha de Cuddy.";

                        pictureBox8.Image = Properties.Resources.ep5_thumbnail_s7;

                        label1.Text = "Ep 5 - Paternidade Indesejada";

                        pictureBox9.Image = Properties.Resources.paciente_ep5_season7_abbey;

                        richTextBox2.Text = "Abbey é a mãe da recém-nascida doente Kayla no episódio Paternidade Indesejada. Ela já tinha uma filha adulta, Justine. Ela foi interpretada pela atriz Jennifer Gray.  Abbey tinha quase 40 anos quando decidiu ter seu segundo filho. Sua gravidez transcorreu sem intercorrências e seu trabalho de parto, embora demorado, não foi digno de nota. No entanto, quando Kayla nasceu, ela estava gravemente hipóxica e foi levada para a Unidade de Terapia Intensiva Neonatal. Quando parecia não haver motivo para os problemas respiratórios de Kayla, Kayla foi transferida para House para diagnóstico. ";

                        label2.Text = "Abbey";

                        break;

                    case "Ep 6 - Politicagem":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Brilhante estudante de medicina Martha M. Masters (Amber Tamblyn) se junta à equipe da insistência de Cuddy, e seu primeiro caso é o tratamento de um gerente de campanha, que fica doente com uma erupção cutânea, levando a insuficiência hepática. Mas a \"moralidade\" de Masters coloca-a em desacordo com House e o resto da sua equipe. Enquanto isso, House debate se vale a pena mentir para Cuddy para salvar a vida de seu paciente.";

                        pictureBox8.Image = Properties.Resources.ep6_thumbnail_s7;

                        label1.Text = "Ep 6 - Politicagem";

                        pictureBox9.Image = Properties.Resources.paciente_ep6_season7;

                        richTextBox2.Text = "Joe Dugan é o paciente do Politicagem. Ele é o gerente de campanha do senador Harold Anderson. Ele é interpretado pelo ator Jack Coleman. Joe apresentou coceira e erupção na pele e foi levado de ambulância ao Hospital Universitário Princeton-Plainsboro. Ao exame, apresentava pupura palpável e níveis elevados de ALT e AST, indicando lesão hepática. Danos no fígado explicavam as crioglobulinas no sangue. No entanto, a causa do dano hepático era desconhecida – o paciente não apresentava sinais de abuso de drogas ou álcool. ";

                        label2.Text = "Joe Dugan";

                        break;

                    case "Ep 7 - Um Estranho Entre Nós":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um pote de medicamentos com mais 200 anos de idade encontrado nos restos de um navio naufragado vaza na mão de uma adolescente, e ela chega ao Princeton Plainsboro com sintomas semelhantes aos de varíola. O diretor do Centro de Controle de Doenças, o Dr. Dave Broda, institui o trancamento do hospital e suspende a investigação de diagnósticos da equipe do Dr. House. Então Masters suspeita dos motivos de Broda e se convence de que a paciente está sofrendo de uma doença diferente. O pai da garota logo apresenta sintomas parecidos, e House é forçado a tomar uma decisão impensada que pode colocar sua própria vida em risco. Enquanto isso, Wilson e Sam consolam um paciente de quimioterapia de 6 anos de idade, o que os leva a repensar seu relacionamento. ";

                        pictureBox8.Image = Properties.Resources.ep7_thumbnail_s7;

                        label1.Text = "Ep 7 - Um Estranho Entre Nós";

                        pictureBox9.Image = Properties.Resources.paciente_ep7_season7_julie;

                        richTextBox2.Text = "Julie é a paciente adolescente que foi exposta à antiga amostra médica em Um Estranho Entre Nós . Ela foi interpretada pela atriz Hayley Chase. A paciente recuperou uma amostra médica de um naufrágio enquanto mergulhava nas Bermudas. Ela quebrou o pote e ficou exposta ao que se revelou serem crostas quando cortou a mão no vidro. ";

                        label2.Text = "Julie";

                        break;

                    case "Ep 8 - Pequenos Sacrifícios":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um paciente é admitido no Princeton Plainsboro após reencenar a crucificação. Enquanto isso, House e sua equipe assistem ao casamento de um colega de trabalho. O relacionamento de Wilson com Sam dá uma reviravolta inesperada e Taub questiona sua mulher sobre seu relacionamento com um membro de um grupo de apoio a infidelidade. ";

                        pictureBox8.Image = Properties.Resources.ep8_thumbnail_s7;

                        label1.Text = "Ep 8 - Pequenos Sacrifícios";

                        pictureBox9.Image = Properties.Resources.paciente_ep8_season7;

                        richTextBox2.Text = "Ramon Silva é o homem que se tornou paciente após reconstruir a crucificação no episódio Pequenos Sacrifícios. Ele é o pai de Marisa Silva. Ele foi interpretado pelo ator Kuno Becker. Durante sua reconstrução, Ramon teve pontas cravadas nas palmas das mãos, embora o peso de suas mãos fosse sustentado por cordas. Enquanto Ramon reconstruía a crucificação, um fluido escuro começou a escorrer de sua boca. Seus companheiros o desceram e o levaram ao pronto-socorro do Hospital Universitário Princeton-Plainsboro. Além de tossir sangue, ele estava com febre. ";

                        label2.Text = "Ramon Silva";

                        break;

                    case "Ep 9 - Maior Que A Vida":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Quando um homem se joga na linha do metrô para salvar uma desconhecida que caiu nos trilhos, ele miraculosamente emerge da cena sem machucado mas, sem aviso, entra em colapso. Tanto os funcionários do hospital quanto toda a cidade ficam tocados pela atitude do homem, mas quando a equipe começa a investigar seu diagnóstico eles descobrem que o ato heróico não foi capaz de transformar seus hábitos. Enquanto isso, House tenta evitar o jantar de aniversário de Cuddy com sua mãe, Arlene. Taub recebe atenção indesejada quando seu rosto estampa as propagandas do hospital. Enquanto ele e sua esposa voltam a ter intimidade, a perspectiva de Masters o faz perceber que é chegada a hora de refletir sobre seu casamento.";

                        pictureBox8.Image = Properties.Resources.ep9_thumbnail_s7;

                        label1.Text = "Ep 9 - Maior Que A Vida";

                        pictureBox9.Image = Properties.Resources.paciente_ep9_season7;

                        richTextBox2.Text = "Jack é o herói do metrô e o paciente do episódio Maior Que A Vida. Ele é marido de Eva e pai de Daisy. Ele foi interpretado pelo ator Matthew Lillard.  O paciente faz parte de uma banda chamada Suicide Season e viaja frequentemente pelo país. Jack estava com sua filha Daisy em uma plataforma do metrô quando viu uma mulher tendo uma convulsão que havia caído da plataforma. Jack foi ajudá-la e conseguiu cobri-la pouco antes de um trem passar por cima dos dois. Ele não parecia estar ferido, mas quando se levantou, caiu de volta nos trilhos. ";

                        label2.Text = "Jack";

                        break;

                    case "Ep 10 - Atos e Consequências":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um adolescente no começo da carreira militar sofre de sintomas peculiares depois de aguentar um treinamento intensivo e, misteriosamente, seu sargento também é admitido para tratamento, apresentando sintomas similares. Incapaz de encontrar a causa da doença que acomete os dois, a equipe busca por pistas no histórico médico da família do militar em treinamento. Masters e House descobrem uma ligação única entre o sargento e seu aprendiz. Enquanto isso, uma foto indecente de Chase é postada numa rede social na internet, depois que ele tem três diferentes encontros românticos, e Chase está determinado a descobrir qual garota está tentando envergonhá-lo publicamente. Sentindo que Cuddy está estressada quanto ao ingresso de sua filha Rachel numa pré-escola de prestígio, então House secretamente prepara Rachel para as entrevistas nas escolas e descobre uma vulnerabilidade para a menina.";

                        pictureBox8.Image = Properties.Resources.ep10_thumbnail_s7;

                        label1.Text = "Ep 10 - Atos e Consequências";

                        pictureBox9.Image = Properties.Resources.paciente_ep10_season7;

                        richTextBox2.Text = "Driscoll foi o instrutor do campo disciplinar em Atos e Consequências. Ele foi interpretado pelo ator Sasha Roiz.  O paciente é um ex-fuzileiro naval com um extenso histórico de viagens. Enquanto conduzia pessoas de um acampamento de jovens por uma pista de obstáculos em um dia chuvoso, Driscoll sofreu fortes dores nas costas que o deixaram incapaz de se mover ou ficar de pé. Ele finalmente caiu no chão enquanto a dor continuava. ";

                        label2.Text = "Driscoll";

                        break;

                    case "Ep 11 - Médico de Família":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A mãe de Cuddy, Arlene, é internada no Princeton Plansboro depois de reclamar de sintomas incomuns, mas a teimosa Arlene insiste que House seja removido do caso, forçando House a vir com uma não convencional - e ilegal- forma de tratar a paciente. House instrui sua equipe a seguir seu exemplo, e eles descobrem detalhes da vida pessoal de Arlene que ela mantém segredo de Cuddy e sua irmã Lucinda (atriz convidada Paula Marshall). Enquanto isso, a ex-mulher de Taub, Rachel, o coloca em contato com seu irmão que contrata Taub para trabalhar com ele em troca da tão precisada renda, que acaba tendo muito desgaste físico. Mais tarde, Cuddy põem sua confiança em House para garantir que a mãe receba o tratamento médico necessário, as atitudes que House toma quanto a esse tratamento fazem com que haja um conflito com a estudante de medicina Masters, uma vez que as práticas éticas e morais são esquecidas por House.";

                        pictureBox8.Image = Properties.Resources.ep11_thumbnail_s7;

                        label1.Text = "Ep 11 - Médico de Família";

                        pictureBox9.Image = Properties.Resources.paciente_ep11_season7;

                        richTextBox2.Text = "Arlene é a paciente principal do episódio Médico de Família. Arlene estava fazendo compras com as filhas Julia e Lisa quando começou a sofrer de palpitações. Sua filha Lisa a levou ao pronto-socorro do Hospital Universitário Princeton-Plainsboro, onde seus exames mostraram anemia macrocítica e fibrilação atrial. ";

                        label2.Text = "Arlene Cuddy";

                        break;

                    case "Ep 12 - Você se Lembra?":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;
                        

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Masters tenta diminuir a distância entre um paciente com memória perfeita e sua irmã, já que o rancor da paciente ameaça seu tratamento. Enquanto isso, House tenta ajudar Wilson a conseguir um encontro, mas descobre que seu amigo já tem alguém, e Foreman se oferece para ajudar Taub nos estudos para um próximo teste médico. ";

                        pictureBox8.Image = Properties.Resources.ep12_thumbnail_s7;

                        label1.Text = "Ep 12 - Você se Lembra?";

                        pictureBox9.Image = Properties.Resources.paciente_ep12_season7;

                        richTextBox2.Text = "Nadia é a garçonete com hipertimésia no episódio 'Você se Lembra?'. Ela foi interpretada pela atriz Tina Holmes. A hipertimésia da paciente permite que ela se lembre de cada detalhe de sua vida desde que entrou na puberdade. Esta condição é muito rara, com menos de dez casos relatados.  A paciente perdeu peso recentemente com uma dieta vegana. Nadia estava no trabalho quando de repente perdeu o equilíbrio. As pessoas que a ajudaram notaram lacerações em suas pernas e ela reclamou que não conseguia movê-las. ";

                        label2.Text = "Nadia";

                        break;

                    case "Ep 13 - Duas Histórias":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House participa do Dia de Carreira nas escolas e quebra algumas regras ao compartilhar histórias médicas explícitas. Esperando fora da sala de diretores, ele encontra dois alunos da quinta série que avaliam os problemas no relacionamento de House e tenta ajudá-lo a entender como seu egoísmo o impediu de mostrar a Cuddy o que ele realmente sente. ";

                        pictureBox8.Image = Properties.Resources.ep13_thumbnail_s7;

                        label1.Text = "Ep 13 - Duas Histórias";

                        pictureBox9.Image = Properties.Resources.paciente_ep13_season7;

                        richTextBox2.Text = "Phillip Wright é o paciente quase esquecido no episódio Duas Histórias. Ele foi interpretado pelo ator Willis Chung. Phillip chegou ao Rutgers Student Medical Center com tosse intensa. Ele foi diagnosticado com bronquite aguda, mas suas culturas de sangue e escarro foram negativas. Ele foi transferido para o Hospital Universitário de Princeton-Plainsboro e designado para o Dr. House quando todos os outros diagnósticos comuns foram descartados. Suas estatísticas de O2 estavam caindo.";


                        label2.Text = "Phillip Wright";

                        break;

                    case "Ep 14 - À Prova de Recessão":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um paciente é admitido em Princeton Plainsboro após uma erupção cutânea causada pela exposição a substâncias químicas em seu trabalho. No processo de tratamento do paciente, House e sua equipe descobrem que a esposa do homem ainda acredita que ele administra um negócio imobiliário lucrativo. House deve escolher entre ir a um evento de caridade para apoiar Cuddy ou ficar com seu paciente. Ao tratar o paciente, Chase e Masters aprendem sobre relacionamentos.";

                        pictureBox8.Image = Properties.Resources.ep14_thumbnail_s7;

                        label1.Text = "Ep 14 - À Prova de Recessão";

                        pictureBox9.Image = Properties.Resources.paciente_ep14_season7;

                        richTextBox2.Text = "Bert Eskey é o paciente que era incorporador imobiliário no episódio À Prova de Recessão. Ele foi interpretado pelo ator Adrian LaTourelle. Bert começou a desenvolver erupção na pele e dificuldade respiratória em um restaurante depois de comer frutos do mar vivos. Ele foi levado ao pronto-socorro do Hospital Universitário Princeton-Plainsboro. Parecia ser choque anafilático. Ele foi testado para alergias, mas deu negativo para todos os alérgenos conhecidos. ";

                        label2.Text = "Bert Eskey";

                        break;

                    case "Ep 15 - Bombas":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Cuddy enfrenta novidades preocupantes que a obriga a reavaliar as suas prioridades, enquanto uma série de sonhos mostram relances do seu relacionamento com House e sua vida em geral. Enquanto House está preocupado com Cuddy, a equipe trata de um adolescente problemático, cujo agravamento dos sintomas e as cicatrizes do corpo indicam que ela pode ter mais do que uma doença física. ";

                        pictureBox8.Image = Properties.Resources.ep15_thumbnail_s7;

                        label1.Text = "Ep 15 - Bombas";

                        pictureBox9.Image = Properties.Resources.paciente_ep15_season7;

                        richTextBox2.Text = "Cuddy enfrentou a possibilidade de ter câncer terminal. Durante o episódio, ela experimentou uma série de sequências de sonhos que sugeriam que ela acreditava que House era um parceiro não confiável. House evitou ficar ao lado da cama dela. Quando House finalmente apareceu, Cuddy percebeu mais tarde que ele devia ter levado Vicodin para ficar com ela. Ela confrontou House sobre o uso de Vicodin e terminou com ele.";

                        label2.Text = "Lisa Cuddy";

                        break;

                    case "Ep 16 - Fora do Curso":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A equipe trata de um toureiro profissional que é atacado por um touro. A equipe deve determinar as causas do desaparecimento dos sintomas do paciente e as crises que ele tem, recebendo conselhos de House fora do hospital, enquanto ele resolve problemas não relacionados com o caso. Masters desenvolve uma paixão pelo paciente.";

                        pictureBox8.Image = Properties.Resources.ep16_thumbnail_s7;

                        label1.Text = "Ep 16 - Fora do Curso";

                        pictureBox9.Image = Properties.Resources.paciente_ep16_season7;

                        richTextBox2.Text = "Lane é o paciente campeão de rodeio no episódio Fora do Curso. Ele é um cavaleiro de touro que é admitido em Princeton-Plainsboro depois que um touro o ataca. Ele foi interpretado pelo ator Chad Faust. Devido à sua ocupação, o paciente sofreu múltiplas lesões traumáticas que exigiram extenso reparo cirúrgico. Ele tem hastes de metal que prendem os ossos de cada membro. Ele tem pinos estabilizando sua coluna. Ele tem cinco parafusos e uma placa de titânio no crânio. Lane terminou com sucesso uma montaria em touro. Ele foi derrubado, mas rapidamente se levantou. No entanto, ele ficou desorientado na arena e não conseguiu se mover. ";

                        label2.Text = "Lane";

                        break;

                    case "Ep 17 - A Queda do Homem":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um jovem sem-teto e ex-viciado em drogas é encontrado em um Parque mostrando sinais de disfunção olfativa e horríveis cicatrizes e marcas de queimadura no peito. Com uma identidade incerta o paciente piorando gravemente das condições, a equipe procura os registros pessoais e antecedentes familiares do paciente, a fim de compreender o seu desprendimento. Enquanto isso, Cuddy confidencia a Wilson e manifesta a sua culpa por acabar com seu relacionamento com House, e assim a equipe descobre um segredo perturbador sobre o homem cuja vida tentam salvar. ";

                        pictureBox8.Image = Properties.Resources.ep17_thumbnail_s7;

                        label1.Text = "Ep 17 - A Queda do Homem";

                        pictureBox9.Image = Properties.Resources.paciente_ep17_season7;

                        richTextBox2.Text = "Danny Jennings (nome verdadeiro desconhecido) é o paciente sem-teto no episódio A Queda do Homem, que mais tarde se revelou um serial killer canibal. Ele foi interpretado pelo ator Chris Marquette. O site Buddy TV escolheu Danny como seu melhor paciente da série. Danny foi acidentalmente queimado em um acidente com um modelo de foguete. No entanto, os construtores do modelo que vieram em seu auxílio e contataram o 911 informaram ao pessoal de emergência que Danny teve dificuldade em distinguir cheiros antes de perder a consciência. ";

                        label2.Text = "Danny Jennings";

                        break;

                    case "Ep 18 - Do Fundo do Baú":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "O encontro de House com a ex-funcionaria \"treze\" que desapareceu durante um ano inteiro revela alguns segredos sombrios escondidos, enquanto isso, a equipe deve encontrar uma cura para um homem cuja casa está repleta de lixo";

                        pictureBox8.Image = Properties.Resources.ep18_thumbnail_s7;

                        label1.Text = "Ep 18 - Do Fundo do Baú";

                        pictureBox9.Image = Properties.Resources.paciente_ep18_season7;

                        richTextBox2.Text = "Brian é o professor de ciências do ensino médio que inicialmente parece ser um colecionador no episódio Do Fundo do Baú . Ele é o marido de Nina. Ele é interpretado pelo ator Terry Maratos. Brian começou a tossir sangue durante a sala de casa. Ele foi levado ao pronto-socorro do Hospital Universitário Princeton-Plainsboro onde, além de hemoptise, apresentou calafrios, dores de cabeça e dores no peito. ";

                        label2.Text = "Brian";

                        break;

                    case "Ep 19 - A Última Tentação":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Masters enfrenta uma escolha difícil em sua carreira no último dia como estudante de medicina e luta com a escolha de continuar no caminho de se tornar uma cirurgiã ou aceitar a rara oportunidade de se juntar à equipe de House oficialmente. Enquanto isso, a equipe cuida de uma menina de 16 anos que inexplicavelmente caiu dias antes de embarcar em um tour ambicioso em um barco a vela ao redor do mundo. Apesar do diagnóstico capaz de mudar a vida do paciente, a família do paciente insiste que ela volte para o mar a tempo de quebrar um recorde. Mas, para surpresa da equipe, incluindo a House, Masters toma uma decisão ousada em relação ao tratamento da paciente.";

                        pictureBox8.Image = Properties.Resources.ep19_thumbnail_s7;

                        label1.Text = "Ep 19 - A Última Tentação";

                        pictureBox9.Image = Properties.Resources.paciente_ep18_season7;

                        richTextBox2.Text = "Kendall Pearson é a jovem que planeja estabelecer o recorde de pessoa mais jovem a velejar ao redor do mundo. Ela é filha de Bobby Pearson e Paige Pearson. Ela é interpretada pela atriz Michelle DeFraites. Kendall desmaiou durante um treino. Ela se recuperou rapidamente, mas os patrocinadores de sua viagem insistiram na autorização médica antes que ela pudesse partir. Ela foi internada no Hospital Universitário de Princeton-Plainsboro e designada para cuidar do Dr. House e sua equipe. ";

                        label2.Text = "Kendall Pearson";

                        break;

                    case "Ep 20 - Mudanças":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Depois de sofrer uma paralisia parcial enquanto está a procura de um amor perdido, o ganhador da loteria Cyrus Harry é trazido para o Princeton Plainsboro para ser tratado por House e sua equipe. A mãe de Cuddy (convidada especial Candice Bergen) ameaça processar o hospital por má prática de medicina, colocando as licenças médicas de Cuddy e House em risco. Chase e Foreman fazem uma aposta que testa cada um deles de maneiras diferentes.";

                        pictureBox8.Image = Properties.Resources.ep20_thumbnail_s7;

                        label1.Text = "Ep 20 - Mudanças";

                        pictureBox9.Image = Properties.Resources.paciente_ep20_season7;

                        richTextBox2.Text = "Cyrus Harry é o doente ganhador da loteria que está procurando por sua ex-namorada Jennifer Williams no episódio Mudanças. Seu primo e motorista de limusine é Phil. Ele era mecânico de geladeiras antes de ganhar na loteria. Ele foi interpretado pelo ator Donal Logue. Cyrus desmaiou quando não conseguiu mover a perna. Seu primo chamou uma ambulância e Cyrus foi levado ao pronto-socorro do Hospital Universitário Princeton-Plainsboro. Ele fez uma tomografia computadorizada da cabeça, uma punção lombar, uma ressonância magnética da coluna e uma eletromiografia, mas todos os resultados foram normais.";

                        label2.Text = "Cyrus Harry";

                        break;

                    case "Ep 21 - Toma Lá, Dá Cá":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Logo após o teste de uma bomba, uma mulher tem uma crise de convulsão. House perde uma aposta contra Wilson e se recusa a pagar pela aposta, afirmando que o pugilista em que havia apostado estaria doente e sem condições para lutar. House está sofrendo com altas dores na perna e começa a usar uma droga experimental que promete regenerar o músculo de sua perna. Ele rouba algumas amostras do laborátorio";

                        pictureBox8.Image = Properties.Resources.ep21_thumbnail_s7;

                        label1.Text = "Ep 21 - Toma Lá, Dá Cá";

                        pictureBox9.Image = Properties.Resources.paciente_ep21_season7;

                        richTextBox2.Text = "Wendy Lee é uma cientista de mísseis do Departamento de Defesa dos EUA que foi a paciente no episódio Toma Lá, Dá Cá. Ela é namorada de Ceaser, um de seus colegas de trabalho. Ela foi interpretada pela atriz Linda Park. O Dr. Lee desmaiou com uma convulsão durante um teste de míssil sem apresentar quaisquer outros sintomas de antemão. Ela foi levada às pressas para o Hospital Universitário Princeton-Plainsboro. Quando nenhuma razão imediata para suas convulsões foi determinada, ela foi encaminhada ao Dr. Gregory House. ";

                        label2.Text = "Wendy Lee";

                        break;
                    case "Ep 22 - Pós-Expediente":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma ex-presidiária amiga da Treze chega ao apartamento dela necessitando de cuidados médicos depois de ter sido esfaqueada. Como a mulher se recusa a ir para o hospital, ela acaba pedindo ajuda a Chase, quando sua amiga perde a sensação e o movimento do seu braço. Taub começa a aceitar uma notícia que pode mudar sua vida. Equanto isso, House descobre que a droga experimental que ele está usando causa tumores fatais em sua perna, ele decide fazer uma cirurgia em si mesmo. No entanto, ele não pode completar a cirurgia, e acaba precisando da ajuda da Cuddy. ";

                        pictureBox8.Image = Properties.Resources.ep22_thumbnail_s7;

                        label1.Text = "Ep 22 - Pós-Expediente";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Darrien McCurdy é uma ex-presidiária que cumpriu pena com Treze quando Treze estava na prisão. Ela atuou como mentora e protetora de Treze. Ela pede ajuda ao Treze quando é esfaqueada no episódio Pós-Expediente. Ela foi interpretada pela atriz Amy Landecker. Darrien tem um longo histórico de abuso de substâncias e tem hepatite C. Ela toma interferon. Darrien foi esfaqueada pelo namorado quando a polícia invadiu uma casa de crack na tentativa de distrair a polícia. Em vez disso, a polícia chamou uma ambulância para buscar Darrien e perseguiu o namorado. Darrien, que estava em liberdade condicional, temeu ser mandada de volta para a prisão e, em vez disso, saiu do local, roubou um carro e foi até o apartamento do Dr. Hadley, que ela conheceu quando as duas estavam na prisão. ";

                        label2.Text = "Darrien McCurdy";

                        break;

                    case "Ep 23 - Seguindo em Frente":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A equipe trata de uma artista performática, que deliberadamente fez-se doente, querendo transformar o departamento de diagnóstico em sua nova obra. Então House deve descobrir quais sintomas são reais e quais são auto-infligidas e sua equipe se questiona se o tratamento realmente é necessário ou se não estão caindo em uma armadilha, participando da obra de arte dela. Enquanto isso, uma situação faz com que House tome uma atitude inesperada que pode mudar seu relacionamento com Cuddy e Wilson para sempre. ";

                        pictureBox8.Image = Properties.Resources.ep23_thumbnail_s7;

                        label1.Text = "Ep 23 - Seguindo em Frente";

                        pictureBox9.Image = Properties.Resources.paciente_ep23_season7;

                        richTextBox2.Text = "Afsoun Hamidi foi a artista performática paciente no episódio Seguindo em Frente. Ela recebeu um MacArthur Genius Grant por seu trabalho. Ela foi interpretada pela atriz Shohreh Aghdashloo. A personagem foi possivelmente baseado na artista performática da vida real Marina Abramović. Hamidi desmaiou durante uma apresentação depois de ser mergulhada em diluente e ameaçado com um fósforo. Seu assistente, Luca, interveio contra suas instruções. Ela foi levada ao pronto-socorro do Hospital Universitário de Princeton-Plainsboro, onde foi encontrada arritmia, hematócrito baixo e variabilidade inconsistente da frequência cardíaca. ";

                        label2.Text = "Afsoun Hamidi";

                        break;

                    //Temporada 8 ----------------------------------------------

                    case "Ep 1 - Vinte Vicodins":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House está preso por ter entrado violentamente com seu carro na casa de Cuddy. Lá ele vê um caso médico em um dos prisioneiros, ao mesmo tempo que precisa entrar na linha com seus inimigos para que possa conseguir sua condicional. ";

                        pictureBox8.Image = Properties.Resources.ep1_thumbnail_s8;

                        label1.Text = "Ep 1 - Vinte Vicodins";

                        pictureBox9.Image = Properties.Resources.paciente_ep1_season8;

                        richTextBox2.Text = "Nick era um prisioneiro que sofria de uma doença misteriosa no episódio Vinte Vicodin. Sua namorada era Nicole. Ele foi interpretado pelo ator Sebastian Sozzi. Nick havia sido preso por tráfico de drogas. Ele começou a sentir dores incomuns nos joelhos e cotovelos. Ao saber que Gregory House, que estava preso por danos materiais, era um ex-médico, ele o abordou na cela e contou-lhe sobre os sintomas. House o encaminhou para a clínica da prisão. ";

                        label2.Text = "Nick";

                        break;

                    case "Ep 2 - Transplante":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Dr. Foreman, agora administrador do hospital de Princeton-Plainsboro (que está sofrendo um período de verba curta), consegue uma condicional a House para que ele trate de um pulmão que será usado em um transplante na paciente de Wilson. Nesse episódio House terá que solucionar o caso com a nova e primeira integrante de sua equipe, Dra. Park, e reatar a amizade com seu ex-melhor amigo. ";

                        pictureBox8.Image = Properties.Resources.ep2_thumbnail_s8;

                        label1.Text = "Ep 2 - Transplante";

                        pictureBox9.Image = Properties.Resources.paciente_ep2_season8;

                        richTextBox2.Text = "---";

                        label2.Text = "Pulmão";

                        break;

                    case "Ep 3 - Caso de Caridade":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House pega um caso de um homem que era rico e decidiu doar praticamente tudo o que tinha. A equipe fica em discordância sobre o altruísmo ser ou não um sintoma. Enquanto isso, Treze fica confusa com a questão de voltar ao hospital. ";

                        pictureBox8.Image = Properties.Resources.ep3_thumbnail_s8;

                        label1.Text = "Ep 3 - Caso de Caridade";

                        pictureBox9.Image = Properties.Resources.paciente_ep2_season8;

                        richTextBox2.Text = "Benjamin Byrd foi o filantropo generoso no episódio 'Caso de Caridade'. Ele foi interpretado pelo ator Wentworth Miller. Benjamin desmaiou do lado de fora de um centro social para o qual acabara de fazer uma grande doação. Ele foi levado ao pronto-socorro do Hospital Universitário Princeton-Plainsboro. Eles não encontraram nada de errado com ele e sentiram que ele havia desmaiado depois de ficar de pé por várias horas em um dia quente. ";

                        label2.Text = "Benjamin Byrd";

                        break;

                    case "Ep 4 - Negócio Arriscado":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um CEO acaba misteriosamente doente apenas alguns dias antes de assinar um contrato que iria relocar toda a força de trabalho da companhia para a China. House tenta selar um contrato secreto com o paciente, mas quando as condições físicas dele pioram, o time deve lutar contra o relógio para salvar sua vida. Enquanto isso, Park se prepara para a audiência no comitê disciplinar do Princeton Plainsboro, presidido por Foreman. Uma busca nos riscos da empresa do paciente feita pela Dra. Adams revela seus sentimentos mais profundos a respeito de lealdade.";

                        pictureBox8.Image = Properties.Resources.ep4_thumbnail_s8;

                        label1.Text = "Ep 4 - Negócio Arriscado";

                        pictureBox9.Image = Properties.Resources.paciente_ep3_season8;

                        richTextBox2.Text = "Thad Barton é o rico proprietário de uma empresa que se torna paciente em 'Negócio Arriscado'. Ele é o pai de Ainsley Barton. Ele foi interpretado pelo ator Michael Nouri. Thad sofre de artrite. Ele tem um extenso histórico de viagens à China, mas já tomou todas as vacinas. Thad foi levado ao Hospital Universitário de Princeton-Plainsboro quando começou a ter problemas de percepção - tudo parecia muito pequeno. ";

                        label2.Text = "Thad Barton";

                        break;

                    case "Ep 5 - A Confissão":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um homem bastante respeitado em sua comunidade (interpretado por Jamie Bamber, de Battlestar Gallactica) tem um colapso de uma hora para outra. No processo de diagnosticar sua doença, o time descobre que o paciente tem escondido segredos sombrios e desonestos a respeito de sua vida profissional e pessoal. Porém, quando o paciente confessa abertamente suas falhas para a família e para a comunidade, ele acaba comprometendo as chances de conseguir o tratamento médico apropriado. Enquanto isso, House não vai parar até manipular Taub a fazer um teste de DNA para provar que ele é o pai de suas duas filhas de seis meses cada, nascidas de mães diferentes.";

                        pictureBox8.Image = Properties.Resources.ep5_thumbnail_s8;

                        label1.Text = "Ep 5 - A Confissão";

                        pictureBox9.Image = Properties.Resources.paciente_ep5_season8;

                        richTextBox2.Text = "Bob Harris foi o herói da pequena cidade que foi o paciente no episódio A Confissão. Ele é interpretado pelo ator Jamie Bamber. Bob chegou ao Hospital Universitário de Princeton-Plainsboro apresentando fibrilação ventricular. No entanto, ele não apresentou sinais de qualquer patologia cardíaca ou qualquer outro sintoma.  ";

                        label2.Text = "Bob Harris";

                        break;

                    case "Ep 6 - Pais":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um adolescente que tentava seguir os passos do falecido pai como um apresentador é admitido no Princeton-Plainsboro com uma paralisia parcial. Quando procuram por um doador de medula compatível nos parentes próximos, a equipe descobre um perturbador segredo de família. Enquanto isso, House procura formas inusitadas para remover o monitor da prisão de sua canela, para que possa acompanhar uma luta de boxe na cidade de Atlantic City. Ao mesmo tempo, ele trata um paciente que está convencido de que sofre de diabetes. Para completar, Taub precisa tomar uma importante decisão quando sua ex-esposa Rachel conta que pretende mudar para o outro lado do país com a filha. ";

                        pictureBox8.Image = Properties.Resources.ep6_thumbnail_s8;

                        label1.Text = "Ep 6 - Pais";

                        pictureBox9.Image = Properties.Resources.paciente_ep6_season8;

                        richTextBox2.Text = "Ben Parker foi o paciente do episódio Pais. Sua mãe é Janey Parker e seu padrasto é Ron Parker. Ele foi interpretado pelo ator Harrison Thomas. Ben foi atingido na virilha durante uma apresentação e de repente ficou incapaz de mover o braço ou a perna. Ele foi levado ao Hospital Universitário de Princeton-Plainsboro, onde o pronto-socorro determinou que ele havia sofrido um ataque isquêmico transitório. No entanto, uma tomografia computadorizada de sua cabeça e uma angiografia cerebral foram normais. Seus parâmetros de coagulação também estavam normais. O caso foi atribuído ao Dr. House. ";

                        label2.Text = "Ben Parker";

                        break;

                    case "Ep 7 - Morto e Enterrado":
                        groupBox6.Visible = true;
                        button1.Visible = true;
                        button2.Visible = true;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe assumem o caso de uma garota com anafilaxia, mas descobrem que o caso é mais grave quando é descoberto que ela está grávida, mesmo afirmando que é virgem. Enquanto isso House se interessa pelo caso de um garoto que já está morto, mesmo Foreman dizendo a ele para se concentrar no caso da paciente.";

                        label1.Text = "Ep 7 - Morto e Enterrado";

                        richTextBox2.Text = "Drew Lemayne era o garoto morto que House estava obcecado em diagnosticar no episódio da 8ª temporada, Morto e Enterrado. Ele não é visto, exceto por um curto período de tempo, quando seu corpo é mostrado. Ele era filho de Emory Lemayne e Mickey Lemayne-Darro. Iris foi a paciente no episódio da 8ª temporada, Morto e Enterrado. Ela foi interpretada pela atriz Madison Davenport. Iris tinha um histórico de alterações de humor. Ela sofreu um acidente de carro aos dois anos de idade. Ela sofreu apenas ferimentos leves, mas seu pai morreu. Iris sofreu reações anafiláticas idiopáticas intermitentes. Dois dos médicos da sala de emergência não conseguiram encontrar a causa. Iris foi a paciente no episódio da 8ª temporada, Dead & Buried. Ela foi interpretada pela atriz Madison Davenport. Iris tinha um histórico de alterações de humor. Ela sofreu um acidente de carro aos dois anos de idade. Ela sofreu apenas ferimentos leves, mas seu pai morreu.";

                        label2.Text = "";

                        break;

                    case "Ep 8 - Perigos da Paranóia":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "O time pega o caso de um procurador que teve um aparente ataque cardíaco enquanto resolvia um caso. Quando descobrem um arsenal de armas na casa dele, eles devem descobrir se isso é superproteção ou paranóia. Taub ajuda Foreman com questões amorosas e Park descobre que deve se abrir mais.";

                        pictureBox8.Image = Properties.Resources.ep8_thumbnail_s8;

                        label1.Text = "Ep 8 - Perigos da Paranóia";

                        pictureBox9.Image = Properties.Resources.paciente_ep8_season8;

                        richTextBox2.Text = "Tommy foi o paciente do episódio Perigos da Paranóia. Ele é casado com Olívia. Ele foi interpretado pelo ator Vincent Spano. Tommy estava no meio de um interrogatório no tribunal, quando pediu ao juiz a prorrogação porque pensou que estava tendo um ataque cardíaco. O juiz chamou uma ambulância. ";

                        label2.Text = "Tommy";

                        break;

                    case "Ep 9 - Cara-Metade":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um homem com a Doença de Alzheimer começa a vomitar durante o tratamento para a doença e também exibe raiva súbita enquanto está internado. Então House e sua equipe devem diagnosticar esses novos sintomas de \"Alzheimer\".Enquanto isso House faz uma aposta com Wilson para tentar provar que a assexualidade de uma mulher é causada por uma doença.";

                        pictureBox8.Image = Properties.Resources.ep9_thumbnail_s8;

                        label1.Text = "Ep 9 - Cara-Metade";

                        pictureBox9.Image = Properties.Resources.paciente_ep9_season8;

                        richTextBox2.Text = "Andres Tavares foi o paciente do episódio Cara-Metade da 8ª temporada. É casado com Natalie Tavares. Foi interpretado pelo ator Ivo Nandi. O paciente sofre de doença de Alzheimer familiar de início precoce e apresenta a típica perda de memória de curto prazo e alterações de humor típicas da doença. Ele apresentava sintomas há cerca de quatro anos. Ele está, no entanto, consciente o suficiente para saber que tem a doença. Ele havia se recuperado recentemente de uma dor de garganta. O paciente estava no hospital para exames de rotina antes de entrar em um ensaio clínico quando começou a vomitar sangue. ";

                        label2.Text = "Andres Tavares";

                        break;

                    case "Ep 10 - Fugitivos":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Uma adolescente (Bridgit Mendler) precisa de um consentimento de um adulto para ser tratada por House e sua equipe, mas ela alega que está fugindo de um lar abusivo. Quando a mãe dela aparece, todos percebem que a relação entre elas é mais complicada do que parece. Enquanto isso, Taub não consegue se conectar com suas duas filhas e House quer explorar a relação de Foreman com uma moça chamada Anita. ";

                        pictureBox8.Image = Properties.Resources.ep10_thumbnail_s8;

                        label1.Text = "Ep 10 - Fugitivos";

                        pictureBox9.Image = Properties.Resources.paciente_ep10_season8;

                        richTextBox2.Text = "Callie Rogers era uma adolescente que foi a paciente da semana de Gregory House em Fugitivos. A paciente chegou à clínica com problemas respiratórios que ela pensava serem devidos à asma. Ela e seu pai foram atendidos pelo Dr. House. ";

                        label2.Text = "Callie Rogers";

                        break;

                    case "Ep 11 - Culpa de Ninguém":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House tem sua carreira ameaçada quando um professor de química que ele estava tratando tem um surto psicótico grave e fere um dos membros do hospital (Chase). Então ele passa por uma audiência com o Dr. Walter Cofield, antigo mentor de Foreman.";

                        pictureBox8.Image = Properties.Resources.ep11_thumbnail_s8;

                        label1.Text = "Ep 11 - Culpa de Ninguém";

                        pictureBox9.Image = Properties.Resources.paciente_ep11_season8;

                        richTextBox2.Text = "Bill Koppelman é um professor de química do ensino médio de 32 anos. Ele desmaiou enquanto corria e ficou paralisado nas quatro extremidades. No entanto, seus exames não mostraram sinais de acidente vascular cerebral ou lesões estruturais, e não houve ossos quebrados ou outros sinais de trauma. House diz que foi mielite transversa. Dr. Foreman diz que ninguém fez a ressonância magnética. Ele então pediu ao Dr. House para assumir o caso. ";

                        label2.Text = "Bill Koppelman";

                        break;

                    case "Ep 12 - Chase":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A fé religiosa de Chase se abala quando ele trata uma jovem freira. Além disso, ele e House chegam a um desacordo fundamental sobre a paciente que pode finalmente acabar com a reputação de Chase como \"homem cooperativo\" de House, mas também trazem os métodos de House, sua reputação e objetividade a uma análise mais séria.";

                        pictureBox8.Image = Properties.Resources.ep12_thumbnail_s8;

                        label1.Text = "Ep 12 - Chase";

                        pictureBox9.Image = Properties.Resources.paciente_ep12_season8;

                        richTextBox2.Text = "Moira Parker foi a paciente do episódio Chase da 8ª temporada. Ela foi interpretada pela atriz Julie Mond. Moira veio à clínica reclamando de dor intensa e súbita no ombro esquerdo. Ela foi vista pelo Dr. Chase. O acompanhante do paciente disse ao Dr. Chase que nada do que eles fizeram para aliviar a dor funcionou. Ela não tinha dor no peito ou tontura. Ela estava sentada e orando quando a dor apareceu. ";

                        label2.Text = "Moira Parker";

                        break;

                    case "Ep 13 - O Homem da Casa":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A esposa de green card de House, Dominika, vai retornar para provar às autoridades que ela e House são realmente casados. House, por sua vez, conduzirá a um curso rápido em que ambos irão aprender um pouco sobre amor e casamento.";

                        pictureBox8.Image = Properties.Resources.ep13_thumbnail_s8;

                        label1.Text = "Ep 13 - O Homem da Casa";

                        pictureBox9.Image = Properties.Resources.paciente_ep13_season8;

                        richTextBox2.Text = "Joe Reese foi o especialista em casamento e paciente no episódio da 8ª temporada, O Homem da Casa. Ele é casado com Marlene Reese. Ele foi interpretado pelo ator Jake Weber. O paciente foi tratado de um pulso quebrado há cerca de dois anos. Joe começou a ter problemas para falar e desmaiou enquanto dava uma palestra sobre problemas conjugais. Ele foi levado ao pronto-socorro do Hospital Universitário Princeton-Plainsboro. ";

                        label2.Text = "Joe Reese";

                        break;

                    case "Ep 14 - O Amor é Cego":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe assumem o caso de Will Westwood, um homem bem sucedido, independente e cego, que está prestes a pedir sua namorada em casamento. Mas antes que ele possa propor, ele é abatido por uma misteriosa doença. Agora House e sua equipe tentam salvá-lo, e no processo, Will se depara com uma decisão que mudará sua vida para sempre. Enquanto isso, a mãe de House o surpreende em Princeton Plainsboro para lhe contar sobre um novo relacionamento.";

                        pictureBox8.Image = Properties.Resources.ep14_thumbnail_s8;

                        label1.Text = "Ep 14 - O Amor é Cego";

                        pictureBox9.Image = Properties.Resources.paciente_ep14_season8;

                        richTextBox2.Text = "Will Westwood é o paciente cego do episódio da 8ª temporada, 'O Amor é Cego'. Ele foi interpretado pelo ator Michael B. Jordan. O paciente é cego desde o nascimento e tem diabetes mellitus. Will ficou desorientado ao atravessar a rua quando o som em seu ambiente tornou-se extremamente alto para ele.";

                        label2.Text = "Will Westwood";

                        break;

                    case "Ep 15 - Assoprando o Apito":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um soldado (Arlen Escarpeta) retornando do exterior, acusado de traição depois de lançar um vídeo mostrando soldados matando civis, tem um colapso e é levado para Princeton-Plainsboro. Ele logo recusa o tratamento até que ele tenha a oportunidade de explicar a sua decisão para as massas. Enquanto isso, Adams e sua equipe acreditam que House está gravemente doente.";

                        pictureBox8.Image = Properties.Resources.ep15_thumbnail_s8;

                        label1.Text = "Ep 15 - Assoprando o Apito";

                        pictureBox9.Image = Properties.Resources.paciente_ep15_season8;

                        richTextBox2.Text = "Brant Macklin foi o soldado do exército que vazou informações para a mídia e se tornou o paciente no episódio da 8ª temporada, Assoprando o Apito. Ele é o irmão mais novo de Hayes Macklin, cunhado de Joni Macklin e tio de Evan Macklin. Ele foi interpretado pelo ator Arlen Escarpeta. O paciente havia retornado recentemente do Afeganistão, onde trabalhava como funcionário júnior da inteligência, interagindo com a população local. Brant estava sob custódia do exército por causa de acusações de traição quando desmaiou enquanto era escoltado através de um aeroporto. Ele continuou a sofrer uma série de convulsões tônico-clônicas. ";

                        label2.Text = "Brant Macklin";

                        break;

                    case "Ep 16 - Verificação de Intestino":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House e sua equipe assumem o caso de um jogador de hóquei da liga menor (Greg Finley), que começou a tossir sangue depois de uma briga no gelo. Enquanto isso, House revela um grande segredo do passado de Wilson, e Park se muda para o apartamento de Chase depois de uma briga com sua mãe.";

                        pictureBox8.Image = Properties.Resources.ep16_thumbnail_s8;

                        label1.Text = "Ep 16 - Verificação de Intestino";

                        pictureBox9.Image = Properties.Resources.paciente_ep16_season8;

                        richTextBox2.Text = "Bobby Hatcher era o executor da liga secundária de hóquei e paciente do 'Verificação de Intestino'. Ele jogou pelo time fictício da American Hockey League, The Trenton Torsos, provavelmente dirigido pelo New Jersey Devils. Ele foi interpretado pelo ator Greg Finley. O paciente perdeu recentemente três dentes devido a lesão traumática. Ele sofreu inúmeras outras lesões traumáticas, muitas das quais exigiram visitas ao pronto-socorro e cirurgia. Ele sofreu três concussões desde os dez anos de idade. Durante um jogo de hóquei entre os dois times menores, o Torsos e os Spartans, um jogador foi brutalmente verificado depois que o disco saiu de sua posse, e os árbitros nunca marcaram uma penalidade de cobrança. ";

                        label2.Text = "Bobby Hatcher";

                        break;

                    case "Ep 17 - Nós Precisamos dos Ovos":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;

                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Um homem (Kevin Christy) é internado no hospital quando ele começa a chorar sangue, mas a equipe suspeita de um componente neurológico quando encontram sua \"namorada\" - uma boneca de sexo bastante realista com quem ele está apaixonado. Enquanto isso, House confronta suas inseguranças quando sua prostituta / acompanhante Emily decide deixá-lo.";

                        pictureBox8.Image = Properties.Resources.ep17_thumbnail_s8;

                        label1.Text = "Ep 17 - Nós Precisamos dos Ovos";

                        pictureBox9.Image = Properties.Resources.som_off;

                        richTextBox2.Text = "Henry foi o paciente no episódio da 8ª temporada, Nós Precisamos dos Ovos. Ele foi interpretado pelo ator Kevin Christy. Kevin estava em um carnaval com sua vizinha Molly quando ela percebeu que havia sangue vazando de seu olho direito. Eles foram para o pronto-socorro do Hospital Universitário Princeton-Plainsboro. ";

                        label2.Text = "Henry";

                        break;

                    case "Ep 18 - Corpo e Alma":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;
                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A equipe luta para diagnosticar um paciente cujo avô acha que ele está possuído. Enquanto isso, Park e Chase têm sonhos sexuais um sobre o outro. Dominika descobre que House jogou fora seu green card, e Wilson revela a House que ele tem câncer. ";

                        pictureBox8.Image = Properties.Resources.ep18_thumbnail_s8;

                        label1.Text = "Ep 18 - Corpo e Alma";

                        pictureBox9.Image = Properties.Resources.paciente_ep18_season8;

                        richTextBox2.Text = "Lue era a jovem paciente do episódio Corpo e Alma da 8ª temporada. Ele é filho de Lida e neto de Xang (por parte de seu pai Kau). Ele foi interpretado pelo ator Riley Lennon Nice. Lue é de herança Hmong. A doença SUNDS é considerada exclusiva deste grupo étnico. O paciente não tinha história de asma ou alergias. Lue sofria de pesadelos frequentes de que uma senhora idosa tentava estrangulá-lo. No entanto, após seu pesadelo mais recente, ele apresentou dificuldade respiratória que evoluiu para parada respiratória. ";

                        label2.Text = "Lue";

                        break;

                    case "Ep 19 - A Palavra C":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;
                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "House tenta curar o câncer de Wilson antes que seu amigo morra. Enquanto isso, os outros médicos em Princeton-Plainsboro devem trabalhar com outra médica - a mãe de seu paciente. ";

                        pictureBox8.Image = Properties.Resources.ep19_thumbnail_s8;

                        label1.Text = "Ep 19 - A Palavra C";

                        pictureBox9.Image = Properties.Resources.paciente_ep19_season8;

                        richTextBox2.Text = "Emily Lawson é a jovem paciente do episódio da 8ª temporada, A  Palavra C. Ela é filha de Elizabeth Lawson e Simon Lawson. Ela é interpretada pela atriz Rachel Eggleston.  Emily tem uma doença genética causada por ter duas cópias do gene que causa ataxia telangiectasia ou \"AT\". Sua condição imita AT, mas apresenta sintomas diferentes. Emily foi levada ao pronto-socorro do Hospital Universitário Princeton-Plainsboro depois de cair de um carrossel em um parque de diversões. Ela foi encontrada inconsciente na parte central do passeio, com sangramento nasal e problemas respiratórios. ";

                        label2.Text = "Emily Lawson";

                        break;

                    case "Ep 20 - Pós Morte":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;
                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "A equipe de House deve convencer o paciente, um médico do Princeton-Plainsboro (Jamie Elman) que House está encarregado de seu caso depois que ele misteriosamente desaparece. Enquanto isso, House, sai na verdade em umas pequenas férias com Wilson enquanto Wilson assume a identidade de Kyle Calloway, que tem uma personalidade bastante parecida com a de House. Wilson volta a si. Chase se demite. House pega os resultados da tomografia de Wilson e acabam por ser más notícias para o oncologista.";

                        pictureBox8.Image = Properties.Resources.ep20_thumbnail_s8;

                        label1.Text = "Ep 20 - Pós Morte";

                        pictureBox9.Image = Properties.Resources.paciente_ep20_season8;

                        richTextBox2.Text = "Peter Treiber é um jovem patologista do Hospital Universitário Princeton-Plainsboro. Ele se torna o paciente do episódio Pós Morte. Ele foi interpretado pelo ator Jamie Elman. Ele é provavelmente um dos médicos mais desagradáveis ​​de Princeton-Plainsboro. Ele não confia em nenhum médico, exceto Gregory House. Cerca de dois anos antes do início da série, ele queria se juntar à equipe de diagnóstico de House, mas Robert Chase foi escolhido. O Dr. Treiber estava realizando uma autópsia em uma jovem quando de repente fez uma incisão em sua própria cabeça, em vez de na cabeça do sujeito da autópsia. Um enfermeiro entrou e o encontrou sangrando muito pela incisão e reclamando que estava com frio. Uma tomografia computadorizada de crânio e um exame toxicológico estavam limpos.";

                        label2.Text = "Peter Treiber";

                        break;

                    case "Ep 21 - Aguentando":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;
                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Treze (participação especial de Olivia Wilde) volta para dar conselhos a Wilson sobre o câncer e como enfrentar sua própria mortalidade. A equipe acredita que os sintomas de um paciente estão sendo causados ​​por problemas físicos e psicológicos. Enquanto isso, Foreman usa uma nova tática para tentar controlar House pois ele começa a ficar fora de controle. House tem de voltar a cadeia por 6 meses por uma pegadinha que saiu errado, enquanto Wilson decide que não vai fazer mais quimioterapia e assim, só terá 5 meses de vida.";

                        pictureBox8.Image = Properties.Resources.ep21_thumbnail_s8;

                        label1.Text = "Ep 21 - Aguentando";

                        pictureBox9.Image = Properties.Resources.paciente_ep21_season8;

                        richTextBox2.Text = "Derrick é o estudante universitário de 19 anos do episódio Aguentando. Ele foi interpretado pelo ator Skylar Astin. Derrick foi internado com uma forte hemorragia nasal e tontura que se desenvolveu durante seu treino como líder de torcida. Ele fez uma tomografia computadorizada de cabeça pelo atendente do pronto-socorro, mas foi normal. O caso foi atribuído ao Dr. House. O Dr. Taub achou que poderia ser um derrame leve, mas a Dra. Adams ressaltou que isso não explicava o sangramento nasal do paciente. O Dr. House achou que provavelmente fosse um granuloma de linha média e solicitou uma tomografia PET.";

                        label2.Text = "Derrick";

                        break;

                    case "Ep 22 - Todo Mundo Morre":
                        groupBox6.Visible = true;
                        button1.Visible = false;
                        button2.Visible = false;
                        groupBox6.Text = "Paciente";

                        richTextBox1.Text = "Último episódio da série. O paciente de House, um viciado em drogas, obriga-o a olhar para trás em sua própria vida. House deve decidir se ele quer continuar como está ou passar por uma mudança, o que vai acontecer no futuro e lidar com seus próprios problemas e suas lutas pessoais. House acorda num prédio em chamas e o paciente está morto. Com sua vida desmoronando ao seu redor, House alucina com as pessoas de seu passado enquanto ele decide se vale a pena viver ou morrer.";

                        pictureBox8.Image = Properties.Resources.ep22_thumbnail_s8;

                        label1.Text = "Ep 22 - Todo Mundo Morre";

                        pictureBox9.Image = Properties.Resources.paciente_ep22_season8;

                        richTextBox2.Text = "Oliver era o paciente da clínica em busca de drogas que Gregory House tratou no final da série Todo Mundo Morre. Ele foi o último paciente de House. Ele foi interpretado pelo ator James LeGros. Oliver veio para a clínica. Ele pediu à enfermeira que anotasse em seu prontuário que ele era alérgico à codeína. Ele foi visto pelo Dr. House. Ele estava bem vestido, bem arrumado e barbeado. No entanto, o Dr. House notou que seu terno estava usado, embora ele estivesse impecavelmente vestido.";

                        label2.Text = "Oliver";

                        break;

                }

            }
            //escritores
            else
            {
                string esc;
                esc = listBox1.Text;

                switch (esc)
                {
                    case "David Shore":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Escritor";

                        richTextBox1.Text = "David Shore é o criador, um dos escritores e diretores da série House M.D.. Ele escreveu os seguites episódios:\r\nPiloto/Todo Mundo Mente\r\nO Princípio de Occam\r\nMedicina Esportiva\r\nBebês e Água Para Banho\r\nTrês Histórias\r\nSuperficial\r\nEuforia, Parte 2\r\nSem Motivo\r\nO Significado das Coisas\r\nCom ou Sem Bengala\r\nUm Dia, Uma Sala\r\nSozinho\r\nAdeus Sr. Bonzinho\r\nNão é Câncer\r\nDerrotado\r\nVerdades Não Ditas\r\nRemorso\r\nFamília é Família\r\nUm Dia Daqueles\r\nToma Lá, Dá Cá\r\nTodo Mundo Morre";

                        pictureBox8.Image = Properties.Resources.david_shore;

                        label2.Text = "David Shore";

                        break;

                    case "Sara Hess":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Escritora";

                        richTextBox1.Text = "Sara Hess é escritora e editora de histórias em House, M.D.. Ela tem créditos de redação nos seguintes episódios:\r\nA Corrida\r\nCachorro que Dorme Não Mente\r\nÀ Procura do Judas\r\nViver a Idade\r\nVocê não quer saber\r\nVivendo o sonho\r\nA Cabeça do House\r\nSorte da Treze\r\nO Bem Maior\r\nO Grande Fiasco\r\nCarma Urgente\r\nCoração Valente\r\nSegredos\r\nAberto ou Fechado?\r\nMaior Que A Vida\r\nBombas\r\nDo Fundo do Baú\r\nCaso de Caridade\r\nO Homem da Casa\r\nNós Precisamos dos Ovos";

                        pictureBox8.Image = Properties.Resources.sara_hess;

                        label2.Text = "Sara Hess";

                        break;

                    case "David Hoselton":
                        groupBox6.Visible = true;

                        groupBox6.Text = "Escritor";

                        richTextBox1.Text = "David Hoselton é escritor, editor de histórias e produtor de House M.D.. Ele tem créditos de redação nos seguintes episódios:\r\nInfiel\r\nAlegria\r\nAdeus Sr. Bonzinho\r\nAnjos da Guarda\r\nTransportado Pelo Ar\r\nRabiscos na areia\r\n\r\nEle se juntou a House como editor executivo da série na 3ª temporada e tornou-se co-produtor na 4ª temporada,\r\npassando a produtor na 5ª temporada e produtor supervisor na 6ª temporada.";

                        pictureBox8.Image = Properties.Resources.david_hoselton;

                        label2.Text = "David Hoselton";

                        break;
                }
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e) //diretores
        {
            string dir;
            dir = listBox2.Text;

            switch (dir)
            {
                case "Greg Yaitanes":
                    groupBox5.Visible = true;

                    groupBox5.Text = "Diretor";

                    richTextBox1.Text = "Greg Yaitanes é um diretor americano vencedor do Emmy.  Ele é creditado como diretor em 30 episódios de House M.D.:\r\nCriticado de Uma Forma ou Outra\r\nO Garoto do Papai\r\nCachorro que Dorme não Mente\r\nSorte da Treze\r\nA Coceira\r\nInfiel\r\nExplicação Simples\r\nO House Dividido\r\nO Grande Fiasco\r\nSanta Ignorância\r\nBuraco Negro\r\nAberto ou Fechado?\r\nE Agora?\r\nEntrelinhas\r\nPaternidade Indesejada\r\nPequenos Sacrifícios\r\nDuas Histórias\r\nBombas\r\nToma Lá, Dá Cá\r\nSeguindo Em Frente\r\nVinte Vicodins\r\nCaso de Caridade\r\nPais\r\nCara-Metade\r\nCulpa de Ninguém";

                    pictureBox8.Image = Properties.Resources.greg_yaitanes;

                    label2.Text = "Greg Yaitanes";

                    break;

                case "Deran Sarafian":
                    groupBox5.Visible = true;

                    groupBox5.Text = "Diretor";

                    richTextBox1.Text = "Deran Sarafian é um diretor, produtor, ator e escritor americano de herança armênia. Ele dirigiu 22 episódios de House, MD:\r\nCrianças\r\nAutópsia\r\nA Decepção\r\nSem Pista\r\nEuforia, Parte 1\r\nEuforia, Parte 2\r\nO Significado Das Coisas\r\nO Que Será, Será\r\nÀ Procura do Judas\r\nInsensível a Dor\r\nConfidencial\r\nSozinho\r\nA Coisa Certa\r\nAnjos da Guarda\r\nJogos\r\nNão Mude Nunca\r\nAdeus Sr. Bonzinho\r\nMorrer Muda Tudo\r\nAlegria\r\nDeixa Comer Bolo\r\nBebê Enorme\r\nO Lado Mais Suave\r\n";

                    pictureBox8.Image = Properties.Resources.deran_sarafian;

                    label2.Text = "Deran Sarafian";

                    break;


                case "Daniel 'Dan' Attias":
                    groupBox5.Visible = true;

                    groupBox5.Text = "Diretor";

                    richTextBox1.Text = "Daniel 'Dan' Attias é um diretor de filmes e séries, e em House M.D., ele dirigiu oito episódios:\r\nHistóricos de Pacientes\r\nAceitação\r\nA Queda do Telhado\r\nDistrações\r\nFilho do Sujeito em Coma\r\nEncarcerado\r\nEgoísta\r\nTransplante";

                    pictureBox8.Image = Properties.Resources.dan_attias;

                    label2.Text = "Daniel 'Dan' Attias";

                    break;


                case "Daniel Sackheim":
                    groupBox5.Visible = true;

                    groupBox5.Text = "Diretor";

                    richTextBox1.Text = "Daniel Sackheim é produtor executivo de House, M.D.. Ele também dirigiu sete episódios:\r\nAmaldiçoado\r\nPara Sempre\r\nCom ou Sem Bengala\r\nO Irmão Mais Velho\r\nPalavras e Ações\r\nViver a Idade\r\nO Idiota";

                    pictureBox8.Image = Properties.Resources.daniel_asackheim;

                    label2.Text = "Daniel Sackheim";

                    break;


                case "Miguel Sapochnik":
                    groupBox5.Visible = true;

                    groupBox5.Text = "Diretor";

                    richTextBox1.Text = "Miguel Sapochnik (nascido Miguel Rosenberg-Sapochnik) é um diretor de cinema e televisão britânico, mais conhecido por seu filme de 2010, Repo Men. Em House, M.D., ele dirigiu seis episódios:\r\nMaior Que A Vida\r\nMédico de Família\r\nPós-Expediente\r\nMorto e Enterrado\r\nVerificação de Intestino\r\nAguentando";

                    pictureBox8.Image = Properties.Resources.miguel_sapochnik;

                    label2.Text = "Miguel Sapochnik";

                    break;

                case "David Platt":
                    groupBox5.Visible = true;

                    groupBox5.Text = "Diretor";

                    richTextBox1.Text = "David Platt é um diretor de televisão e mixador de som responsável pela direção de cinco episódios de House M.D.:\r\nO Amor É Cego\r\n97 Segundos\r\nEspelho, Espelho Meu\r\nMarcas de Nascença\r\nVocê se Lembra?";

                    pictureBox8.Image = Properties.Resources.david_platt;

                    label2.Text = "David Platt";

                    break;

                case "Matt Shakman":
                    groupBox5.Visible = true;

                    groupBox5.Text = "Diretor";

                    richTextBox1.Text = "Matt Shakman é um diretor, produtor e ator americano. Em House, M.D., ele tem créditos de direção em cinco episódios:\r\nPosição Fetal\r\nA Mentira Não Se Compra\r\nDo Fundo Do Baú\r\nChase";

                    pictureBox8.Image = Properties.Resources.matt_shakman;

                    label2.Text = "Matt Shakman";

                    break;

                case "Juan José Campanella":
                    groupBox5.Visible = true;

                    groupBox5.Text = "Diretor";

                    richTextBox1.Text = "Juan José Campanella é um diretor de cinema e televisão argentino. Em House, MD ele dirigiu cinco episódios: \r\nQuestão de Escolha\r\nA Queda do Cavaleiro\r\nVem Cá Bichano\r\nO que for preciso\r\nUm Dia, Uma Sala";

                    pictureBox8.Image = Properties.Resources.juan_jose;

                    label2.Text = "Juan José Campanella";

                    break;
            }
        }

        //setas de mudar a imagem
        private bool button1WasClicked = false;
        private void button1_Click(object sender, EventArgs e)
        {
            button1WasClicked = true;

            if (label1.Text == "Ep 8 - Veneno")
            {
                pictureBox9.Image = Properties.Resources.som_off;

                label2.Text = "Matt Davis";

            }
            else if (label1.Text == "Ep 21 - Três Histórias")
            {
                int adicionador1;

                for (adicionador1 = 0; adicionador1 < 4; adicionador1++)
                    if (button1WasClicked == true)
                    {
                        adicionador1 = adicionador1 + 1;
                    }

                if (adicionador1 == 0)
                {
                    pictureBox9.Image = Properties.Resources.paciente_ep21_season1_farmer;

                    label2.Text = "O Fazendeiro";

                    richTextBox2.Text = "O fazendeiro era um paciente sobre o qual House contou aos estudantes de medicina em Três Histórias. House não usou seu nome para proteger sua identidade. Ele é retratado durante a maior parte da narrativa por Brent Briscoe, mas ocasionalmente é retratado por Carmen Electra. O Dr. House estava dando uma palestra para um grupo de estudantes de medicina sobre três pacientes com dores nas pernas. Um deles era agricultor.";
                }
                else if (adicionador1 == 1)
                {
                    pictureBox9.Image = Properties.Resources.paciente_ep21_season1_carmen;

                    label2.Text = "Jogadora de Voleibol";

                    richTextBox2.Text = "'Jogadora de Voleibol' é um dos três estudos de caso do episódio Três Histórias. Durante a maior parte da narrativa, ela é interpretada pela atriz Andi Eystad, embora no início seja interpretada por Brent Briscoe, o ator que interpreta O Fazendeiro. A jogadora de vôlei foi levada ao pronto-socorro após cair durante o treino, reclamando de fortes dores na perna direita que a impediam de ficar em pé. Seu treinador achou que era uma distensão muscular.";
                }
                else if (adicionador1 == 2)
                {
                    pictureBox9.Image = Properties.Resources.paciente_ep21_season1_house;

                    label2.Text = "Homem de 30 e Poucos Anos";

                    richTextBox2.Text = "'Homem de 30 e Poucos Anos' é um dos três estudos de caso do episódio Três Histórias. O nome do paciente fica oculto ao chamá-lo de Carmen Electra, que retrata o paciente em alguns momentos da narrativa. Durante a maior parte da narrativa, ele é representado pelo ator James Saxenmeyer. No entanto, uma vez que o paciente é revelado ao público como uma lembrança do incidente que levou à deficiência de House, ele é interpretado por Hugh Laurie.";
                }
                else
                {
                    pictureBox9.Image = Properties.Resources.som_off;
                    adicionador1 = 0;

                    label2.Text = "Dr. Riley";

                    richTextBox2.Text = "Riley era o médico doente cuja doença forçou Lisa Cuddy a fazer com que Gregory House desse uma palestra para um grupo de estudantes de medicina no episódio Três Histórias. Riley não é visto no episódio. Durante a palestra, House usa a caneca feita à mão de Riley escrita \"O Melhor Pai do Mundo\" para pegar um pouco de água e, depois de tomar um gole, imediatamente cospe e para de beber da caneca. Após a palestra, ele pergunta como o \"Melhor Pai do Mundo\" permitiria que seus filhos usassem tinta à base de chumbo - Riley tem envenenamento por metais pesados ​​devido ao esmalte de chumbo na caneca, o que explica tanto seus sintomas atuais quanto suas ausências contínuas.";
                }

            }
            else if (label1.Text == "Ep 18 - Transportado Pelo Ar")
            {
                pictureBox9.Image = Properties.Resources.paciente_ep18_season3_fran;

                label2.Text = "Fran";
            }
            else if (label1.Text == "Ep 8 - Emancipação")
            {
                pictureBox9.Image = Properties.Resources.paciente_ep8_season5;

                label2.Text = "Sophia Isabel Velez ";
            }
            else if (label1.Text == "Ep 7 - Morto e Enterrado")
            {
                pictureBox9.Image = Properties.Resources.paciente_ep7_season8_1;

                label2.Text = "Iris";
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

            //------------------------
            if (label1.Text == "Ep 8 - Veneno")
            {
                pictureBox9.Image = Properties.Resources.paciente_ep8_season1;

                label2.Text = "Chi Ling";

            }
            else if (label1.Text == "Ep 21 - Três Histórias")
            {
                if (adicionador == 0)
                {
                    pictureBox9.Image = Properties.Resources.paciente_ep21_season1_farmer;

                    label2.Text = "O Fazendeiro";

                    richTextBox2.Text = "O fazendeiro era um paciente sobre o qual House contou aos estudantes de medicina em Três Histórias. House não usou seu nome para proteger sua identidade. Ele é retratado durante a maior parte da narrativa por Brent Briscoe, mas ocasionalmente é retratado por Carmen Electra. O Dr. House estava dando uma palestra para um grupo de estudantes de medicina sobre três pacientes com dores nas pernas. Um deles era agricultor.";
                }
                else if (adicionador == 1)
                {
                    pictureBox9.Image = Properties.Resources.paciente_ep21_season1_carmen;

                    label2.Text = "Jogadora de Voleibol";

                    richTextBox2.Text = "'Jogadora de Voleibol' é um dos três estudos de caso do episódio Três Histórias. Durante a maior parte da narrativa, ela é interpretada pela atriz Andi Eystad, embora no início seja interpretada por Brent Briscoe, o ator que interpreta O Fazendeiro. A jogadora de vôlei foi levada ao pronto-socorro após cair durante o treino, reclamando de fortes dores na perna direita que a impediam de ficar em pé. Seu treinador achou que era uma distensão muscular.";

                }
                else if (adicionador == 2)
                {
                    pictureBox9.Image = Properties.Resources.paciente_ep21_season1_house;

                    label2.Text = "Homem de 30 e Poucos Anos";

                    richTextBox2.Text = "'Homem de 30 e Poucos Anos' é um dos três estudos de caso do episódio Três Histórias. O nome do paciente fica oculto ao chamá-lo de Carmen Electra, que retrata o paciente em alguns momentos da narrativa. Durante a maior parte da narrativa, ele é representado pelo ator James Saxenmeyer. No entanto, uma vez que o paciente é revelado ao público como uma lembrança do incidente que levou à deficiência de House, ele é interpretado por Hugh Laurie.";
                }
                else
                {
                    pictureBox9.Image = Properties.Resources.som_off;
                    adicionador = 0;

                    label2.Text = "Dr. Riley";

                    richTextBox2.Text = "Riley era o médico doente cuja doença forçou Lisa Cuddy a fazer com que Gregory House desse uma palestra para um grupo de estudantes de medicina no episódio Três Histórias. Riley não é visto no episódio. Durante a palestra, House usa a caneca feita à mão de Riley escrita \"O Melhor Pai do Mundo\" para pegar um pouco de água e, depois de tomar um gole, imediatamente cospe e para de beber da caneca. Após a palestra, ele pergunta como o \"Melhor Pai do Mundo\" permitiria que seus filhos usassem tinta à base de chumbo - Riley tem envenenamento por metais pesados ​​devido ao esmalte de chumbo na caneca, o que explica tanto seus sintomas atuais quanto suas ausências contínuas.";
                }
                 
            }
            else if (label1.Text == "Ep 18 - Transportado Pelo Ar")
            {
                pictureBox9.Image = Properties.Resources.paciente_ep18_season3_peng;

                label2.Text = "Peng";
            }
            else if (label1.Text == "Ep 8 - Emancipação")
            {
                pictureBox9.Image = Properties.Resources.paciente_ep8_season5;

                label2.Text = "Jonah";
            }
            else if (label1.Text == "Ep 7 - Morto e Enterrado")
            {
                pictureBox9.Image = Properties.Resources.som_off;

                label2.Text = "David Lemaine";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                pictureBox2.Image = Properties.Resources.som_off;
            }
            else { 
            string temp;
            temp = comboBox1.Text;

            switch (temp)
            {
                case ("Temporada 1"):

                    pictureBox2.Image = Properties.Resources.greghouse_season1;

                    break;

                case ("Temporada 2"):

                    pictureBox2.Image = Properties.Resources.greghouse_season2;

                    break;

                case ("Temporada 3"):

                    pictureBox2.Image = Properties.Resources.greghouse_season3;

                    break;

                case ("Temporada 4"):

                    pictureBox2.Image = Properties.Resources.greghouse_season4;

                    break;

                case ("Temporada 5"):

                    pictureBox2.Image = Properties.Resources.greghouse_season5;

                    break;

                case ("Temporada 6"):

                    pictureBox2.Image = Properties.Resources.greghouse_season6;

                    break;

                case ("Temporada 7"):

                    pictureBox2.Image = Properties.Resources.greghouse_season7;

                    break;

                case ("Temporada 8"):

                    pictureBox2.Image = Properties.Resources.greghouse_season8;

                    break;

                case ("2004"):

                    pictureBox2.Image = Properties.Resources.hugh_laurie_2004;

                    break;

                case ("2008"):

                    pictureBox2.Image = Properties.Resources.hugh_laurie_2008;

                    break;

                case ("2012"):

                    pictureBox2.Image = Properties.Resources.hugh_laurie_2012;

                    break;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == false)
            {
                pictureBox3.Image = Properties.Resources.som_off;
            }
            else { 
            string temp;
            temp = comboBox1.Text;

            switch (temp)
            {
                case ("Temporada 1"):

                    pictureBox3.Image = Properties.Resources.wilson_season1;

                    break;

                case ("Temporada 2"):

                    pictureBox3.Image = Properties.Resources.wilson_season2;

                    break;

                case ("Temporada 3"):

                    pictureBox3.Image = Properties.Resources.wilson_season3;

                    break;

                case ("Temporada 4"):

                    pictureBox3.Image = Properties.Resources.wilson_season4;

                    break;

                case ("Temporada 5"):

                    pictureBox3.Image = Properties.Resources.wilson_season5;

                    break;

                case ("Temporada 6"):

                    pictureBox3.Image = Properties.Resources.juan_season6;

                    break;

                case ("Temporada 7"):

                    pictureBox3.Image = Properties.Resources.masters_season7;

                    break;

                case ("Temporada 8"):

                    pictureBox3.Image = Properties.Resources.wilson_season8;

                    break;

                case ("2004"):

                    pictureBox3.Image = Properties.Resources.robert_sean_2004;

                    break;

                case ("2008"):

                    pictureBox3.Image = Properties.Resources.juan_season6;

                    break;

                case ("2012"):

                    pictureBox3.Image = Properties.Resources.robert_sean_2012;

                    break;
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == false)
            {
                pictureBox4.Image = Properties.Resources.som_off;
            }
            else { 

            string temp;
            temp = comboBox1.Text;

            switch (temp)
            {
                case ("Temporada 1"):

                    pictureBox4.Image = Properties.Resources.lisacuddy_season1;

                    break;

                case ("Temporada 2"):

                    pictureBox4.Image = Properties.Resources.stacy_season2;

                    break;

                case ("Temporada 3"):

                    pictureBox4.Image = Properties.Resources.lisacuddy_season3;

                    break;

                case ("Temporada 4"):

                    pictureBox4.Image = Properties.Resources.amber_season4;

                    break;

                case ("Temporada 5"):

                    pictureBox4.Image = Properties.Resources.lisacuddy_season5;

                    break;

                case ("Temporada 6"):

                    pictureBox4.Image = Properties.Resources.lisacuddy_season6;

                    break;

                case ("Temporada 7"):

                    pictureBox4.Image = Properties.Resources.lisacuddy_season7;

                    break;

                case ("Temporada 8"):

                    pictureBox4.Image = Properties.Resources.adams_season8;

                    break;

                case ("2004"):

                    pictureBox4.Image = Properties.Resources.lisa_edelstein_2004;

                    break;

                case ("2008"):

                    pictureBox4.Image = Properties.Resources.anne_dudek_2008;

                    break;

                case ("2012"):

                    pictureBox4.Image = Properties.Resources.odette_annabele_2012;

                    break;
            }
            }
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == false)
            {
                pictureBox5.Image = Properties.Resources.som_off;
            }
            else
            {
                string temp;
                temp = comboBox1.Text;

                switch (temp)
                {
                    case ("Temporada 1"):

                        pictureBox5.Image = Properties.Resources.cameron_season1;

                        break;

                    case ("Temporada 2"):

                        pictureBox5.Image = Properties.Resources.cameron_season2;

                        break;

                    case ("Temporada 3"):

                        pictureBox5.Image = Properties.Resources.cameron_season3;

                        break;

                    case ("Temporada 4"):

                        pictureBox5.Image = Properties.Resources.taub_season4;

                        break;

                    case ("Temporada 5"):

                        pictureBox5.Image = Properties.Resources.taub_season5;

                        break;

                    case ("Temporada 6"):

                        pictureBox5.Image = Properties.Resources.cameron_season6;

                        break;

                    case ("Temporada 7"):

                        pictureBox5.Image = Properties.Resources.taub_season7;

                        break;

                    case ("Temporada 8"):

                        pictureBox5.Image = Properties.Resources.taub_season8;

                        break;

                    case ("2004"):

                        pictureBox5.Image = Properties.Resources.jeniffer_morisson_2004;

                        break;

                    case ("2008"):

                        pictureBox5.Image = Properties.Resources.peter_jacobson_2008;

                        break;

                    case ("2012"):

                        pictureBox5.Image = Properties.Resources.peter_jacobson_2012;

                        break;

                }

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == false)
            {
                pictureBox6.Image = Properties.Resources.som_off;
            }
            else { 

            string temp;
            temp = comboBox1.Text;

            switch (temp)
            {
                case ("Temporada 1"):

                    pictureBox6.Image = Properties.Resources.chase_season1;

                    break;

                case ("Temporada 2"):

                    pictureBox6.Image = Properties.Resources.chase_season2;

                    break;

                case ("Temporada 3"):

                    pictureBox6.Image = Properties.Resources.chase_season3;

                    break;

                case ("Temporada 4"):

                    pictureBox6.Image = Properties.Resources.kutner_season4;

                    break;

                case ("Temporada 5"):

                    pictureBox6.Image = Properties.Resources.kutner_season5;

                    break;

                case ("Temporada 6"):

                    pictureBox6.Image = Properties.Resources.chase_season6;

                    break;

                case ("Temporada 7"):

                    pictureBox6.Image = Properties.Resources.chase_season7;

                    break;

                case ("Temporada 8"):

                    pictureBox6.Image = Properties.Resources.chi_season8;

                    break;

                case ("2004"):

                    pictureBox6.Image = Properties.Resources.jesse_spencer_2004;

                    break;

                case ("2008"):

                    pictureBox6.Image = Properties.Resources.kal_penn_2008;

                    break;

                case ("2012"):

                    pictureBox6.Image = Properties.Resources.charlene_yi_2012;

                    break;

                }
            }
        }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == false)
            {
                pictureBox7.Image = Properties.Resources.som_off;
            }
            else {

                string temp;
                temp = comboBox1.Text;

                switch (temp)
                {
                    case ("Temporada 1"):

                        pictureBox7.Image = Properties.Resources.foreman_season1;

                        break;

                    case ("Temporada 2"):

                        pictureBox7.Image = Properties.Resources.foreman_season2;

                        break;

                    case ("Temporada 3"):

                        pictureBox7.Image = Properties.Resources.foreman_season3;

                        break;

                    case ("Temporada 4"):

                        pictureBox7.Image = Properties.Resources.thirteen_season4;

                        break;

                    case ("Temporada 5"):

                        pictureBox7.Image = Properties.Resources.thirteen_season5;

                        break;

                    case ("Temporada 6"):

                        pictureBox7.Image = Properties.Resources.foreman_season6;

                        break;

                    case ("Temporada 7"):

                        pictureBox7.Image = Properties.Resources.foreman_season7;

                        break;

                    case ("Temporada 8"):

                        pictureBox7.Image = Properties.Resources.foreman_season8;

                        break;

                    case ("2004"):

                        pictureBox7.Image = Properties.Resources.omar_epps_2004;

                        break;

                    case ("2008"):

                        pictureBox7.Image = Properties.Resources.olivia_wilde_2008;

                        break;

                    case ("2012"):

                        pictureBox7.Image = Properties.Resources.omar_epps_2012;

                        break;

                }
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked) { 
            pictureBox11.Image = Properties.Resources.som_on;

            _soundPlayer.Play();
           _soundPlayer.PlayLooping(); 
            } else
            {
                pictureBox11.Image = Properties.Resources.som_off11;

                _soundPlayer.Stop();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}