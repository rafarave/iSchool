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
	public class Disciplina : Service
	{
		public model.Disciplina Get(GetDisciplina request)
		{
			data.Disciplina aluno = new data.Disciplina();
			return aluno.GetElement(request.Id);
		}
		public List<model.Disciplina> Get(GetDisciplinas request)
		{
			return new data.Disciplina().GetCollection(0);
		}
		public void Insert(NewDisciplina request)
		{
			new data.Disciplina().Insert(request.Disciplina);
		}
		public void Update(UpdateDisciplina request)
		{
			new data.Disciplina().Update(request.Disciplina);
		}
		public void Delete(DeleteDisciplina request)
		{
			new data.Disciplina().Delete(request.Id);
		}
	}
}
