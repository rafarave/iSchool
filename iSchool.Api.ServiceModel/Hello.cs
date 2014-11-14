using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack;
using ServiceStack.ServiceHost;

namespace iSchool.Api.ServiceModel
{
	public class HelloResponse
	{
		public string Result { get; set; }
	}

	[Route("/hello/{Name}")]
	public class Hello : IReturn<HelloResponse>
	{
		public string Name { get; set; }
	}

}