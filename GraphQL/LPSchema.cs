using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLDynamo.GraphQL
{
	class LPSchema : Schema
	{
		public LPSchema(IDependencyResolver resolver): base(resolver)
		{
			Query = resolver.Resolve<LPQuery>();
		}
	}
}
