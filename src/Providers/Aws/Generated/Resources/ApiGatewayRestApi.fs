namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayRestApiState<'Name> = { assignments: ResizeArray<aws.ApiGatewayRestApi.ApiGatewayRestApiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api">aws_api_gateway_rest_api</a>.
    /// </summary>
    type ApiGatewayRestApiBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayRestApiState<Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayRestApiState<Missing>)

        member _.Zero(()) : ApiGatewayRestApiState<Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayRestApiState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#name-1">ApiGatewayRestApi#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiGatewayRestApiState<Missing>, value: string) : ApiGatewayRestApiState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiGatewayRestApiState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#api_key_source-1">ApiGatewayRestApi#api_key_source</a>.
        /// </summary>
        [<CustomOperation "api_key_source">]
        member _.ApiKeySource(state: ApiGatewayRestApiState<'Name>, value: string) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.ApiKeySource <- value)
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#binary_media_types-1">ApiGatewayRestApi#binary_media_types</a>.
        /// </summary>
        [<CustomOperation "binary_media_types">]
        member _.BinaryMediaTypes(state: ApiGatewayRestApiState<'Name>, value: seq<string>) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.BinaryMediaTypes <- (value |> Seq.toArray))
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#body-1">ApiGatewayRestApi#body</a>.
        /// </summary>
        [<CustomOperation "body">]
        member _.Body(state: ApiGatewayRestApiState<'Name>, value: string) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.Body <- value)
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#description-1">ApiGatewayRestApi#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiGatewayRestApiState<'Name>, value: string) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#disable_execute_api_endpoint-1">ApiGatewayRestApi#disable_execute_api_endpoint</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_execute_api_endpoint">]
        member _.DisableExecuteApiEndpoint(state: ApiGatewayRestApiState<'Name>, value: bool) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.DisableExecuteApiEndpoint <- value)
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#disable_execute_api_endpoint-1">ApiGatewayRestApi#disable_execute_api_endpoint</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_execute_api_endpoint">]
        member _.DisableExecuteApiEndpoint(state: ApiGatewayRestApiState<'Name>, value: HashiCorp.Cdktf.IResolvable) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.DisableExecuteApiEndpoint <- value)
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// endpoint_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#endpoint_configuration-1">ApiGatewayRestApi#endpoint_configuration</a>
        /// </summary>
        [<CustomOperation "endpoint_configuration">]
        member _.EndpointConfiguration(state: ApiGatewayRestApiState<'Name>, value: aws.ApiGatewayRestApi.ApiGatewayRestApiEndpointConfiguration) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.EndpointConfiguration <- value)
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#fail_on_warnings-1">ApiGatewayRestApi#fail_on_warnings</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fail_on_warnings">]
        member _.FailOnWarnings(state: ApiGatewayRestApiState<'Name>, value: bool) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.FailOnWarnings <- value)
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#fail_on_warnings-1">ApiGatewayRestApi#fail_on_warnings</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fail_on_warnings">]
        member _.FailOnWarnings(state: ApiGatewayRestApiState<'Name>, value: HashiCorp.Cdktf.IResolvable) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.FailOnWarnings <- value)
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#id-1">ApiGatewayRestApi#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayRestApiState<'Name>, value: string) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#minimum_compression_size-1">ApiGatewayRestApi#minimum_compression_size</a>.
        /// </summary>
        [<CustomOperation "minimum_compression_size">]
        member _.MinimumCompressionSize(state: ApiGatewayRestApiState<'Name>, value: string) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.MinimumCompressionSize <- value)
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#parameters-1">ApiGatewayRestApi#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: ApiGatewayRestApiState<'Name>, value: seq<string * string>) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#policy-1">ApiGatewayRestApi#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: ApiGatewayRestApiState<'Name>, value: string) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#put_rest_api_mode-1">ApiGatewayRestApi#put_rest_api_mode</a>.
        /// </summary>
        [<CustomOperation "put_rest_api_mode">]
        member _.PutRestApiMode(state: ApiGatewayRestApiState<'Name>, value: string) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.PutRestApiMode <- value)
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#tags-1">ApiGatewayRestApi#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApiGatewayRestApiState<'Name>, value: seq<string * string>) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApiGatewayRestApiState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_rest_api#tags_all-1">ApiGatewayRestApi#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ApiGatewayRestApiState<'Name>, value: seq<string * string>) : ApiGatewayRestApiState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ApiGatewayRestApiState<'Name>

        member _.Run(state: ApiGatewayRestApiState<Present>) : aws.ApiGatewayRestApi.ApiGatewayRestApi =
            let config = aws.ApiGatewayRestApi.ApiGatewayRestApiConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayRestApi.ApiGatewayRestApi(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayRestApi: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayRestApiState<_>) : aws.ApiGatewayRestApi.ApiGatewayRestApi =
            Unchecked.defaultof<aws.ApiGatewayRestApi.ApiGatewayRestApi>
