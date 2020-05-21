using GraphQL.Types;
using GraphQLDynamo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLDynamo.GraphQL.Types
{
	public class LPType: ObjectGraphType<LP>
	{
		public LPType()
		{
			Field(t => t.Id);
			Field(t => t.MeterPointCode);
			Field(t => t.SerialNumber);
			Field(t => t.Units);
			Field(t => t.PlantCode);
			Field(t => t.DataType);
			Field(t => t.DataValue);
			Field(t => t.Status);
		}
	}
}
