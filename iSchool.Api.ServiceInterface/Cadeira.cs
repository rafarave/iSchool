using iSchool.Api.ServiceModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model = iSchool.Api.Core.Model;
using data = iSchool.Api.Core.Data;
using ServiceStack;
using ServiceStack.ServiceInterface;
using ServiceStack.Common.Web;

namespace iSchool.Api.ServiceInterface
{
	public class Cadeira : Service
	{
		public model.Cadeira Get(GetCadeira request)
		{
			data.Cadeira Cadeira = new data.Cadeira();
			return Cadeira.GetElement(request.Id);
		}
		public List<model.Cadeira> Get(GetCadeiras request)
		{
			return new data.Cadeira().GetCollection(0);
		}
		public HttpResult Post(NewCadeira request)
		{
			new data.Cadeira().Insert(request.Cadeira);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Put(UpdateCadeira request)
		{
			new data.Cadeira().Update(request.Cadeira);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public HttpResult Delete(DeleteCadeira request)
		{
			new data.Cadeira().Delete(request.Id);
			return new HttpResult(request, System.Net.HttpStatusCode.OK);
		}
		public CabecalhoListaChamada Get(GetCabecalhoListaChamada request)
		{
			model.Cadeira cadeira =
				new data.Cadeira().GetCabecalhoListaChamada(request.CadeiraId, request.PeriodoId);
			cadeira.Aulas = cadeira.Aulas.OrderBy(a => a.Data).ToList();
			cadeira.Avaliacoes = cadeira.Avaliacoes.OrderBy(a => a.Aplicada).ToList();
			CabecalhoListaChamada cabecalho = new CabecalhoListaChamada();
			foreach (model.Aula aula in cadeira.Aulas)
				cabecalho.AulasDadas.Add(aula.Id, aula.Data);
			foreach (model.Avaliacao avaliacao in cadeira.Avaliacoes)
				cabecalho.Avaliacoes.Add(avaliacao.Id, avaliacao.Nome);
			return cabecalho;
		}
		public List<ItemListaChamada> Get(GetListaChamada request)
		{
			model.Cadeira cadeira =
				new data.Cadeira().GetListaChamada(request.CadeiraId, request.PeriodoId);
			cadeira.Aulas = cadeira.Aulas.OrderBy(a => a.Data).ToList();
			cadeira.Avaliacoes = cadeira.Avaliacoes.OrderBy(a => a.Aplicada).ToList();
			List<ItemListaChamada> listaChamada = new List<ItemListaChamada>();
			foreach(model.Educando aluno in cadeira.Alunos)
			{
				ItemListaChamada itemChamada = new ItemListaChamada();
				itemChamada.CadeiraId = cadeira.Id;
				itemChamada.EducandoId = aluno.Id;
				itemChamada.NomeAluno = aluno.Aluno.Nome;
				itemChamada.NumeroChamadaAluno = aluno.OrdemChamada;
				foreach(model.Aula aula in cadeira.Aulas)
				{
					itemChamada.Presencas.Add(aula.Id, aula.Ausencias.Where(f => f.EducandoId == aluno.Id).Count() <= 0);
				}
				foreach(model.Avaliacao avaliacao in cadeira.Avaliacoes)
				{
					itemChamada.Avaliacoes.Add(avaliacao.Id,
						avaliacao.Notas.Where(n => n.EducandoId == aluno.Id).Count() > 0 ?
						avaliacao.Notas.FirstOrDefault(n => n.EducandoId == aluno.Id).Valor : (decimal)0
						);
				}
				listaChamada.Add(itemChamada);
			}
			return listaChamada;
		}
	}
}
