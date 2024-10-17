#!/bin/bash

dotnet new tool-manifest -v quiet
dotnet tool install --local Microsoft.OpenApi.Kiota -v quiet

##### Enhance Client ######

enhance_api_docs_url="https://apidocs.enhance.com/spec/oas3-api.yaml"
enhance_api_docs_file="src/WebsiteMaintainer.Infrastructure/ApiSpecifications/enhance-api.yaml"
    
curl -s "$enhance_api_docs_url" -o "$enhance_api_docs_file"

#Replace int with integer to get correct types
sed -i 's/\bint\b/integer/g' $enhance_api_docs_file

#### Kinsta Client ####

kinsta_api_docs_file="src/WebsiteMaintainer.Infrastructure/ApiSpecifications/kinsta-api.json"

dotnet kiota generate -l CSharp -c EnhanceClient -n Enhance.Client -d=$enhance_api_docs_file -o=./src/WebsiteMaintainer.Infrastructure/Clients/Enhance --ebc false --co true
dotnet kiota generate -l CSharp -c KinstaClient -n Kinsta.Client -d=$kinsta_api_docs_file -o=./src/WebsiteMaintainer.Infrastructure/Clients/Kinsta --ebc false --co true

##### #####dotnet tool install --local Microsoft.OpenApi.Kiota -v quiet
