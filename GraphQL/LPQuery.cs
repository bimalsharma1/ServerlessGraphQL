using GraphQL.Instrumentation;
using GraphQL.Types;
using GraphQLDynamo.GraphQL.Types;
using GraphQLDynamo.Interfaces;
using GraphQLDynamo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLDynamo.GraphQL
{
	public class LPQuery: ObjectGraphType
	{
		public LPQuery(ILPService lpService)
		{
			Field<ListGraphType<LPType>>(
				"LP",
				resolve: context => lpService.GetLPs()
				);
		}
	}
}
