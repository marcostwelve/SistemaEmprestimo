using ClosedXML.Excel;
using EmprestimoJogos.Data;
using EmprestimoJogos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace EmprestimoJogos.Controllers
{
	public class EmprestimoController : Controller
	{
		private readonly ApplicationDbContext _db;
		public EmprestimoController(ApplicationDbContext db)
		{
			_db = db;
		}

		[HttpGet]
		public IActionResult Index()
		{
			IEnumerable<EmprestimoModel> emprestimos = _db.Emprestimos;
			return View(emprestimos);
		}

		[HttpGet]
		public IActionResult Cadastrar()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Editar(int? id)
		{
			if(id == null || id == 0)
			{
				return NotFound();
			}

			EmprestimoModel emprestimo  = _db.Emprestimos.FirstOrDefault(x => x.Id == id);

			if(emprestimo == null) 
			{
				return NotFound();
			}

			return View(emprestimo);
		}

		[HttpGet]
		public IActionResult Excluir(int? id)
		{
			if(id == null || id == 0)
			{
				return NotFound();
			}

			EmprestimoModel emprestimo = _db.Emprestimos.FirstOrDefault(x => x.Id == id);
			if(emprestimo == null)
			{
				return NotFound();
			}

			return View(emprestimo);
		}

		[HttpGet]
		public IActionResult Exportar()
        {
			var dados = GetDados();

			using (XLWorkbook workbook = new XLWorkbook())
			{
				workbook.AddWorksheet(dados, "Dados Empréstimos");

				using (MemoryStream ms = new MemoryStream())
				{
					workbook.SaveAs(ms);
					return File(ms.ToArray(), "application/vnd.openxmlformats-officedocument.spredsheetml.sheet", "Empréstimo.xls");
				}
			}
        }

		private DataTable GetDados()
		{
			DataTable dataTable = new DataTable();

			dataTable.TableName = "Dados empréstimos";
			dataTable.Columns.Add("Recebedor", typeof(string));
			dataTable.Columns.Add("Fornecedor", typeof(string));
			dataTable.Columns.Add("Jogo", typeof(string));
			dataTable.Columns.Add("Data Empréstimo", typeof(DateTime));

			var dados = _db.Emprestimos.ToList();

			if(dados.Count > 0)
			{
				dados.ForEach(emprestimo =>
				{
					dataTable.Rows.Add(emprestimo.Recebedor, emprestimo.Fornecedor, emprestimo.JogoEmprestado, emprestimo.DataAtualizacao);
				});
			}


			return dataTable;
		}

		[HttpPost]
		public IActionResult Cadastrar(EmprestimoModel emprestimo) 
		{
			if(ModelState.IsValid)
			{
				emprestimo.DataAtualizacao = DateTime.Now;
				_db.Emprestimos.Add(emprestimo);
				_db.SaveChanges();

				TempData["MensagemSucesso"] = "Cadastro realizado com sucesso!";
				return RedirectToAction("Index");
			}
			TempData["MensageErro"] = "Não foi possível cadastrar um novo empréstimo!";
			return View();
		}

		[HttpPost]
		public IActionResult  Editar(EmprestimoModel emprestimo)
		{
			if(ModelState.IsValid)
			{
				var emprestimoDB = _db.Emprestimos.Find(emprestimo.Id);

				emprestimoDB.Fornecedor = emprestimo.Fornecedor;
				emprestimoDB.Recebedor = emprestimo.Recebedor;
				emprestimoDB.JogoEmprestado = emprestimo.JogoEmprestado;

				_db.Emprestimos.Update(emprestimoDB);
				_db.SaveChanges();

				TempData["MensagemSucesso"] = "Cadastro alterado com sucesso!";
				return RedirectToAction("Index");
			}

			TempData["MensagemErro"] = "Não foi possível editar o empréstimo!";
			return View(emprestimo);
		}

		[HttpPost]
		public IActionResult Excluir(EmprestimoModel emprestimo)
		{
			if(emprestimo == null)
			{
				return NotFound();
			}

			_db.Emprestimos.Remove(emprestimo);
			_db.SaveChanges();

			TempData["MensagemSucesso"] = "Cadastro excluído com sucesso!";
			return RedirectToAction("Index");
		}
	}
}
