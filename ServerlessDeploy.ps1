$Env:SLS_DEBUG = "*"

#dotnet tool update -g Amazon.Lambda.Tools
# dotnet lambda package --configuration release --framework netcoreapp2.1 --output-package ./../package/Alveo.Service.Venue.0.0.0.zip
#dotnet lambda package --configuration release --framework netcoreapp3.1 --output-package ./bin/release/GraphQL.zip -h

npm install serverless-domain-manager
npm install serverless-pseudo-parameters
#npm install serverless-plugin-existing-s3 --no-save --loglevel=error
npm install  api-gateway-stage-tag-plugin
npm install  serverless-tag-cloud-watch-logs
npm install  serverless-dynamodb-pitr
#serverless create_domain
#serverless deploy --verbose
serverless deploy --verbose

#serverless remove