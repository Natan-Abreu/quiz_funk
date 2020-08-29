/*
 * Created by SharpDevelop.
 * User: Natan G. de Abreu
 * Date: 06/10/2019
 * Time: 00:26
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace quiz_funk
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//Declarando as variáveis globais
		int acertos=0;
		
		//Ao clicar no LABEL COMEÇAR, será executado o código abaixo
		void Label16Click(object sender, EventArgs e)
		{
			
				
			
			label2.Visible = true;
			label16.Visible = false;
		}
		
		//Ao clicar na resposta certa...
		void PictureBox6Click(object sender, EventArgs e)
		{
			pictureBox6.Visible = false; //MC correto
			label2.Visible = false; //Pergunta ou trecho de funk
			label11.Visible = false; //Nome do MC em baixo da foto
			MessageBox.Show("Você acertou esse trecho de música!"); //Caixa de texto
			acertos+= 1; //Soma de acertos
			label15.Text = acertos.ToString(); //Enviando para o label mostrar ao jogador
			label3.Visible = true; //Próxima pergunta
			
			pictureBox1.Load("fundo_dois_program.jpg");
			
			label4.Visible = false;
			label5.Visible = false;
			label6.Visible = false;
		}
		
		//Ao clicar na resposta certa...
		void PictureBox5Click(object sender, EventArgs e)
		{
			pictureBox5.Visible = false; //MC correto
			label3.Visible = false; //Pergunta ou trecho de funk
			label10.Visible = false; //Nome do MC em baixo da foto
			MessageBox.Show("Você acertou esse trecho de música!"); //Caixa de texto
			acertos+= 1; //Soma de acertos
			label15.Text = acertos.ToString(); //Enviando para o label mostrar ao jogador
			label5.Visible = true; //Próxima pergunta
			
			pictureBox1.Load("fundo_tres_program.jpg");
			
			label3.Visible = false;
			label4.Visible = false;
			label6.Visible = false;
		}
		
		//Ao clicar na resposta certa...
		void PictureBox2Click(object sender, EventArgs e)
		{
			pictureBox2.Visible = false; //MC correto
			label5.Visible = false; //Pergunta ou trecho de funk
			label7.Visible = false; //Nome do MC em baixo da foto
			MessageBox.Show("UAU, CÊ É BRABO MERMO HEIN!"); //Caixa de texto
			acertos+= 1; //Soma de acertos
			label15.Text = acertos.ToString(); //Enviando para o label mostrar ao jogador
			label4.Visible = true; //Próxima pergunta
			
			pictureBox1.Load("fundo_quatro_program.jpg");
			
			label3.Visible = false;
			label5.Visible = false;
			label6.Visible = false;
			
		}
		
		//Ao clicar na resposta certa...
		void PictureBox4Click(object sender, EventArgs e)
		{
			pictureBox4.Visible = false; //MC correto
			label4.Visible = false; //Pergunta ou trecho de funk
			label9.Visible = false; //Nome do MC em baixo da foto
			MessageBox.Show("UAU, CÊ É BRABO MERMO HEIN! MC FRANK É ZIKA!"); //Caixa de texto
			acertos+= 1; //Soma de acertos
			label15.Text = acertos.ToString(); //Enviando para o label mostrar ao jogador
			label6.Visible = true; //Próxima pergunta
			pictureBox7.Visible = true;
			label17.Visible = true;
			
			pictureBox1.Load("fundo_dois_program.jpg");
			
			label3.Visible = false;
			label4.Visible = false;
			label5.Visible = false;
		}
		
		//Ao clicar na resposta certa...
		void PictureBox3Click(object sender, EventArgs e)
		{
			pictureBox3.Visible = false; //MC correto
			label6.Visible = false; //Pergunta ou trecho de funk
			label8.Visible = false; //Nome do MC em baixo da foto
			MessageBox.Show("Uma relíquia do MC Daleste! Brabo demais..."); //Caixa de texto
			acertos+= 1; //Soma de acertos
			label15.Text = acertos.ToString(); //Enviando para o label mostrar ao jogador
			MessageBox.Show("Você chegou ao fim do quiz! Pressione 'OK' para ver sua pontuação final..."); //Caixa de texto
			label17.Visible = true;			
			
			//Estrutura de decisão para o nível de funkeiro do usuário
			if (acertos>=4) {
				MessageBox.Show("Você é 100% funkeiro! Acertou boa parte dos MC´s..."); //Caixa de texto
			} else
				if (acertos<4 || acertos==2) {
					MessageBox.Show("Você é 70% funkeiro! Não acertou muitos MC´s..."); //Caixa de texto
			} else {
					MessageBox.Show("Você é 10% funkeiro! Acredito que você não pertence ao mundo do funk..."); //Caixa de texto		
			}
			label18.Visible = true;
		}
		
		//Ao clicar no botão REINICIAR
		void Label18Click(object sender, EventArgs e)
		{
			pictureBox1.Load("fundo_program.jpg");
			
			label18.Visible = false;
			pictureBox7.Visible = false;
			label17.Visible = false;
			
			label2.Visible = true;
			label16.Visible = false;
			
			acertos= acertos*0; //Zerando a pontuação do jogador
			
			label15.Text = acertos.ToString("-");
			
			pictureBox2.Visible = true;
			pictureBox3.Visible = true;
			pictureBox4.Visible = true;
			pictureBox5.Visible = true;
			pictureBox6.Visible = true;
			
			label7.Visible = true;
			label8.Visible = true;
			label9.Visible = true;
			label10.Visible = true;
			label11.Visible = true;
			
			label3.Visible = false;
			label4.Visible = false;
			label5.Visible = false;
			label6.Visible = false;
		}
		
		//Se clicar no MC Menor da VG, que é a resposta errada
		void PictureBox7Click(object sender, EventArgs e)
		{
			label6.Visible = false; //Pergunta ou trecho de funk
			MessageBox.Show("Você errou!!!"); //Caixa de texto
			acertos+= 0; //Soma de acertos
			label15.Text = acertos.ToString(); //Enviando para o label mostrar ao jogador

			//Estrutura de decisão para o nível de funkeiro do usuário
			if (acertos>=4) {
				MessageBox.Show("Você é 100% funkeiro! Acertou boa parte dos MC´s..."); //Caixa de texto
			} else
				if (acertos<4 || acertos==2) {
					MessageBox.Show("Você é 70% funkeiro! Não acertou muitos MC´s..."); //Caixa de texto
			} else {
					MessageBox.Show("Você é 10% funkeiro! Acredito que você não pertence ao mundo do funk..."); //Caixa de texto		
			}
			label18.Visible = true;			
		}
	}
}
