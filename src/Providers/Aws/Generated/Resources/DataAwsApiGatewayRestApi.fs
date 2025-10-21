namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsApiGatewayRestApiState<'Name> = { assignments: ResizeArray<aws.DataAwsApiGatewayRestApi.DataAwsApiGatewayRestApiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_rest_api">aws_api_gateway_rest_api</a>.
    /// </summary>
    type DataAwsApiGatewayRestApiBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsApiGatewayRestApiState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayRestApiState<Missing>)

        member _.Zero(()) : DataAwsApiGatewayRestApiState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsApiGatewayRestApiState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_rest_api#name-1">DataAwsApiGatewayRestApi#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsApiGatewayRestApiState<Missing>, value: string) : DataAwsApiGatewayRestApiState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAwsApiGatewayRestApiState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_rest_api#id-1">DataAwsApiGatewayRestApi#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsApiGatewayRestApiState<'Name>, value: string) : DataAwsApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/api_gateway_rest_api#tags-1">DataAwsApiGatewayRestApi#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsApiGatewayRestApiState<'Name>, value: seq<string * string>) : DataAwsApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsApiGatewayRestApiState<'Name>

        member _.Run(state: DataAwsApiGatewayRestApiState<Present>) : aws.DataAwsApiGatewayRestApi.DataAwsApiGatewayRestApi =
            let config = aws.DataAwsApiGatewayRestApi.DataAwsApiGatewayRestApiConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsApiGatewayRestApi.DataAwsApiGatewayRestApi(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsApiGatewayRestApi: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsApiGatewayRestApiState<_>) : aws.DataAwsApiGatewayRestApi.DataAwsApiGatewayRestApi =
            Unchecked.defaultof<aws.DataAwsApiGatewayRestApi.DataAwsApiGatewayRestApi>
