using Amazon.Lambda.Core;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Amazon.Lambda.APIGatewayEvents;
using GraphQLDynamo.GraphQL;
using System;
using GraphQL;
using Microsoft.Extensions.DependencyInjection;
using GraphQL.Types;
using GraphQLDynamo.Interfaces;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace GraphQLDynamo
{
    public class Handler: Schema
    {
        private readonly IObjectGraphType _data = new ObjectGraphType();
        public Handler()
        {
  
        }

        public Handler(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<LPQuery>();
            _data = Query;
        }
        public async Task<APIGatewayProxyResponse> GetData(APIGatewayProxyRequest request, ILambdaContext context)
        {
     
            context.Logger.LogLine($"Found data");

            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonConvert.SerializeObject(_data)
 
            };

            return response;
        }
    }

    public class Message {
        public string Data { get; set; }
    }
}
