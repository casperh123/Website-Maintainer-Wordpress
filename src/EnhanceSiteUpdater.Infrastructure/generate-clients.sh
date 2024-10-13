#!/bin/bash

dotnet new tool-manifest -v quiet
dotnet tool install --local Microsoft.OpenApi.Kiota -v quiet

##### Generate Enhance Clients ######

enhance_api_docs_url="https://apidocs.enhance.com/spec/oas3-api.yaml"
enhance_api_docs_file="./ApiSpecifications/enhance-api.yaml"
    
curl -s "$enhance_api_docs_url" -o "$enhance_api_docs_file"

#Replace int with integer to get correct types
sed -i 's/\bint\b/integer/g' $enhance_api_docs_file

sudo dotnet kiota generate -l CSharp -c EnhanceClient -n Enhance.Client -d=./ApiSpecifications/enhance-api.yaml -o=./Clients/Enhance --ebc false --co true

##### #####