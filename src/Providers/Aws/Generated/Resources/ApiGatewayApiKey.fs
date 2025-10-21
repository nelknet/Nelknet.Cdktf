namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayApiKeyState<'Name> = { assignments: ResizeArray<aws.ApiGatewayApiKey.ApiGatewayApiKeyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_api_key">aws_api_gateway_api_key</a>.
    /// </summary>
    type ApiGatewayApiKeyBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayApiKeyState<Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayApiKeyState<Missing>)

        member _.Zero(()) : ApiGatewayApiKeyState<Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayApiKeyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_api_key#name-1">ApiGatewayApiKey#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiGatewayApiKeyState<Missing>, value: string) : ApiGatewayApiKeyState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiGatewayApiKeyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_api_key#customer_id-1">ApiGatewayApiKey#customer_id</a>.
        /// </summary>
        [<CustomOperation "customer_id">]
        member _.CustomerId(state: ApiGatewayApiKeyState<'Name>, value: string) : ApiGatewayApiKeyState<'Name> =
            state.assignments.Add(fun config -> config.CustomerId <- value)
            state : ApiGatewayApiKeyState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_api_key#description-1">ApiGatewayApiKey#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ApiGatewayApiKeyState<'Name>, value: string) : ApiGatewayApiKeyState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ApiGatewayApiKeyState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_api_key#enabled-1">ApiGatewayApiKey#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ApiGatewayApiKeyState<'Name>, value: bool) : ApiGatewayApiKeyState<'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : ApiGatewayApiKeyState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_api_key#enabled-1">ApiGatewayApiKey#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ApiGatewayApiKeyState<'Name>, value: HashiCorp.Cdktf.IResolvable) : ApiGatewayApiKeyState<'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : ApiGatewayApiKeyState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_api_key#id-1">ApiGatewayApiKey#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayApiKeyState<'Name>, value: string) : ApiGatewayApiKeyState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayApiKeyState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_api_key#tags-1">ApiGatewayApiKey#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApiGatewayApiKeyState<'Name>, value: seq<string * string>) : ApiGatewayApiKeyState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApiGatewayApiKeyState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_api_key#tags_all-1">ApiGatewayApiKey#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ApiGatewayApiKeyState<'Name>, value: seq<string * string>) : ApiGatewayApiKeyState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ApiGatewayApiKeyState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_api_key#value-1">ApiGatewayApiKey#value</a>.
        /// </summary>
        [<CustomOperation "value">]
        member _.Value(state: ApiGatewayApiKeyState<'Name>, value: string) : ApiGatewayApiKeyState<'Name> =
            state.assignments.Add(fun config -> config.Value <- value)
            state : ApiGatewayApiKeyState<'Name>

        member _.Run(state: ApiGatewayApiKeyState<Present>) : aws.ApiGatewayApiKey.ApiGatewayApiKey =
            let config = aws.ApiGatewayApiKey.ApiGatewayApiKeyConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayApiKey.ApiGatewayApiKey(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayApiKey: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayApiKeyState<_>) : aws.ApiGatewayApiKey.ApiGatewayApiKey =
            Unchecked.defaultof<aws.ApiGatewayApiKey.ApiGatewayApiKey>
