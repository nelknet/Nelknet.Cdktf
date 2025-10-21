namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Apigatewayv2ApiState<'Name, 'ProtocolType> = { assignments: ResizeArray<aws.Apigatewayv2Api.Apigatewayv2ApiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api">aws_apigatewayv2_api</a>.
    /// </summary>
    type Apigatewayv2ApiBuilder(logicalId: string) =
        member _.Yield(_: unit) : Apigatewayv2ApiState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2ApiState<Missing, Missing>)

        member _.Zero(()) : Apigatewayv2ApiState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2ApiState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#name-1">Apigatewayv2Api#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Apigatewayv2ApiState<Missing, 'ProtocolType>, value: string) : Apigatewayv2ApiState<Present, 'ProtocolType> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Apigatewayv2ApiState<Present, 'ProtocolType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#protocol_type-1">Apigatewayv2Api#protocol_type</a>.
        /// </summary>
        [<CustomOperation "protocol_type">]
        member _.ProtocolType(state: Apigatewayv2ApiState<'Name, Missing>, value: string) : Apigatewayv2ApiState<'Name, Present> =
            state.assignments.Add(fun config -> config.ProtocolType <- value)
            ({ assignments = state.assignments } : Apigatewayv2ApiState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#api_key_selection_expression-1">Apigatewayv2Api#api_key_selection_expression</a>.
        /// </summary>
        [<CustomOperation "api_key_selection_expression">]
        member _.ApiKeySelectionExpression(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: string) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.ApiKeySelectionExpression <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#body-1">Apigatewayv2Api#body</a>.
        /// </summary>
        [<CustomOperation "body">]
        member _.Body(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: string) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.Body <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// cors_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#cors_configuration-1">Apigatewayv2Api#cors_configuration</a>
        /// </summary>
        [<CustomOperation "cors_configuration">]
        member _.CorsConfiguration(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: aws.Apigatewayv2Api.Apigatewayv2ApiCorsConfiguration) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.CorsConfiguration <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#credentials_arn-1">Apigatewayv2Api#credentials_arn</a>.
        /// </summary>
        [<CustomOperation "credentials_arn">]
        member _.CredentialsArn(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: string) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.CredentialsArn <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#description-1">Apigatewayv2Api#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: string) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#disable_execute_api_endpoint-1">Apigatewayv2Api#disable_execute_api_endpoint</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_execute_api_endpoint">]
        member _.DisableExecuteApiEndpoint(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: bool) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.DisableExecuteApiEndpoint <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#disable_execute_api_endpoint-1">Apigatewayv2Api#disable_execute_api_endpoint</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_execute_api_endpoint">]
        member _.DisableExecuteApiEndpoint(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: HashiCorp.Cdktf.IResolvable) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.DisableExecuteApiEndpoint <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#fail_on_warnings-1">Apigatewayv2Api#fail_on_warnings</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fail_on_warnings">]
        member _.FailOnWarnings(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: bool) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.FailOnWarnings <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#fail_on_warnings-1">Apigatewayv2Api#fail_on_warnings</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fail_on_warnings">]
        member _.FailOnWarnings(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: HashiCorp.Cdktf.IResolvable) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.FailOnWarnings <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#id-1">Apigatewayv2Api#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: string) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#ip_address_type-1">Apigatewayv2Api#ip_address_type</a>.
        /// </summary>
        [<CustomOperation "ip_address_type">]
        member _.IpAddressType(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: string) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.IpAddressType <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#route_key-1">Apigatewayv2Api#route_key</a>.
        /// </summary>
        [<CustomOperation "route_key">]
        member _.RouteKey(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: string) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.RouteKey <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#route_selection_expression-1">Apigatewayv2Api#route_selection_expression</a>.
        /// </summary>
        [<CustomOperation "route_selection_expression">]
        member _.RouteSelectionExpression(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: string) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.RouteSelectionExpression <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#tags-1">Apigatewayv2Api#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: seq<string * string>) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#tags_all-1">Apigatewayv2Api#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: seq<string * string>) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#target-1">Apigatewayv2Api#target</a>.
        /// </summary>
        [<CustomOperation "target">]
        member _.Target(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: string) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.Target <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api#version-1">Apigatewayv2Api#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: Apigatewayv2ApiState<'Name, 'ProtocolType>, value: string) : Apigatewayv2ApiState<'Name, 'ProtocolType> =
            state.assignments.Add(fun config -> config.Version <- value)
            state : Apigatewayv2ApiState<'Name, 'ProtocolType>

        member _.Run(state: Apigatewayv2ApiState<Present, Present>) : aws.Apigatewayv2Api.Apigatewayv2Api =
            let config = aws.Apigatewayv2Api.Apigatewayv2ApiConfig()
            for setter in state.assignments do
                setter config
            aws.Apigatewayv2Api.Apigatewayv2Api(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apigatewayv2Api: missing required arguments. Must call: name, protocol_type.", 9999, IsError = true)>]
        member _.Run(_: Apigatewayv2ApiState<_, _>) : aws.Apigatewayv2Api.Apigatewayv2Api =
            Unchecked.defaultof<aws.Apigatewayv2Api.Apigatewayv2Api>
