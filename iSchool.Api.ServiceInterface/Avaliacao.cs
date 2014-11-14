using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using iSchool.Api.ServiceModel;
using model = iSchool.Api.Core.Model;
using data = iSchool.Api.Core.Data;
using ServiceStack;
using ServiceStack.ServiceInterface;
namespace iSchool.Api.ServiceInterface
{
	public class Avaliacao : Service
	{
		public model.Avaliacao Get(GetAvaliacao request)
		{
			data.Avaliacao aluno = new data.Avaliacao();
			return aluno.GetElement(request.Id);
		}
		public List<model.Avaliacao> Get(GetAvaliacoes request)
		{
			return new data.Avaliacao().GetCollection(0);
		}
		public void Insert(NewAvaliacao request)
		{
			new data.Avaliacao().Insert(request.Avaliacao);
		}
		public void Update(UpdateAvaliacao request)
		{
			new data.Avaliacao().Update(request.Avaliacao);
		}
		public void Delete(DeleteAvaliacao request)
		{
			new data.Avaliacao().Delete(request.Id);
		}
	}
}
