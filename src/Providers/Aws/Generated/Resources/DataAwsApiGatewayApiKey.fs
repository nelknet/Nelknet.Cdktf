namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApiGatewayApiKeyState<'Id> = { assignments: ResizeArray<aws.DataAwsApiGatewayApiKey.DataAwsApiGatewayApiKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_api_key">aws_api_gateway_api_key</a>.
    /// </summary>
    type DataAwsApiGatewayApiKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApiGatewayApiKeyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayApiKeyState<Missing>)

        member _.Zero(()) : DataAwsApiGatewayApiKeyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayApiKeyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_api_key#id-1">DataAwsApiGatewayApiKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsApiGatewayApiKeyState<Missing>, value: string) : DataAwsApiGatewayApiKeyState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewayApiKeyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_api_key#tags-1">DataAwsApiGatewayApiKey#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsApiGatewayApiKeyState<'Id>, value: seq<string * string>) : DataAwsApiGatewayApiKeyState<'Id> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsApiGatewayApiKeyState<'Id>

        member _.Run(state: DataAwsApiGatewayApiKeyState<Present>) : aws.DataAwsApiGatewayApiKey.DataAwsApiGatewayApiKey =
            let config = aws.DataAwsApiGatewayApiKey.DataAwsApiGatewayApiKeyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApiGatewayApiKey.DataAwsApiGatewayApiKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsApiGatewayApiKey: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsApiGatewayApiKeyState<_>) : aws.DataAwsApiGatewayApiKey.DataAwsApiGatewayApiKey =
            Unchecked.defaultof<aws.DataAwsApiGatewayApiKey.DataAwsApiGatewayApiKey>
