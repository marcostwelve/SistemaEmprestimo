﻿using System.ComponentModel.DataAnnotations;

namespace EmprestimoJogos.Models
{
	public class EmprestimoModel
	{
		public int Id { get; set; }

		[Required(ErrorMessage = "Digite o nome do recebedor")]
        public string Recebedor { get; set; }

		[Required(ErrorMessage = "Digite o nome do Fornecedor")]
		public string Fornecedor { get; set;}

		[Required(ErrorMessage = "Digite o nome do jogo")]
		public string JogoEmprestado { get; set; }
		public DateTime DataAtualizacao {  get; set; }
    }
}
