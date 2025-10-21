namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayBasePathMappingState<'ApiId, 'DomainName> = { assignments: ResizeArray<aws.ApiGatewayBasePathMapping.ApiGatewayBasePathMappingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_base_path_mapping">aws_api_gateway_base_path_mapping</a>.
    /// </summary>
    type ApiGatewayBasePathMappingBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayBasePathMappingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayBasePathMappingState<Missing, Missing>)

        member _.Zero(()) : ApiGatewayBasePathMappingState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayBasePathMappingState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_base_path_mapping#api_id-1">ApiGatewayBasePathMapping#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: ApiGatewayBasePathMappingState<Missing, 'DomainName>, value: string) : ApiGatewayBasePathMappingState<Present, 'DomainName> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayBasePathMappingState<Present, 'DomainName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_base_path_mapping#domain_name-1">ApiGatewayBasePathMapping#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: ApiGatewayBasePathMappingState<'ApiId, Missing>, value: string) : ApiGatewayBasePathMappingState<'ApiId, Present> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : ApiGatewayBasePathMappingState<'ApiId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_base_path_mapping#base_path-1">ApiGatewayBasePathMapping#base_path</a>.
        /// </summary>
        [<CustomOperation "base_path">]
        member _.BasePath(state: ApiGatewayBasePathMappingState<'ApiId, 'DomainName>, value: string) : ApiGatewayBasePathMappingState<'ApiId, 'DomainName> =
            state.assignments.Add(fun config -> config.BasePath <- value)
            state : ApiGatewayBasePathMappingState<'ApiId, 'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_base_path_mapping#domain_name_id-1">ApiGatewayBasePathMapping#domain_name_id</a>.
        /// </summary>
        [<CustomOperation "domain_name_id">]
        member _.DomainNameId(state: ApiGatewayBasePathMappingState<'ApiId, 'DomainName>, value: string) : ApiGatewayBasePathMappingState<'ApiId, 'DomainName> =
            state.assignments.Add(fun config -> config.DomainNameId <- value)
            state : ApiGatewayBasePathMappingState<'ApiId, 'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_base_path_mapping#id-1">ApiGatewayBasePathMapping#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayBasePathMappingState<'ApiId, 'DomainName>, value: string) : ApiGatewayBasePathMappingState<'ApiId, 'DomainName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayBasePathMappingState<'ApiId, 'DomainName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_base_path_mapping#stage_name-1">ApiGatewayBasePathMapping#stage_name</a>.
        /// </summary>
        [<CustomOperation "stage_name">]
        member _.StageName(state: ApiGatewayBasePathMappingState<'ApiId, 'DomainName>, value: string) : ApiGatewayBasePathMappingState<'ApiId, 'DomainName> =
            state.assignments.Add(fun config -> config.StageName <- value)
            state : ApiGatewayBasePathMappingState<'ApiId, 'DomainName>

        member _.Run(state: ApiGatewayBasePathMappingState<Present, Present>) : aws.ApiGatewayBasePathMapping.ApiGatewayBasePathMapping =
            let config = aws.ApiGatewayBasePathMapping.ApiGatewayBasePathMappingConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayBasePathMapping.ApiGatewayBasePathMapping(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayBasePathMapping: missing required arguments. Must call: api_id, domain_name.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayBasePathMappingState<_, _>) : aws.ApiGatewayBasePathMapping.ApiGatewayBasePathMapping =
            Unchecked.defaultof<aws.ApiGatewayBasePathMapping.ApiGatewayBasePathMapping>
