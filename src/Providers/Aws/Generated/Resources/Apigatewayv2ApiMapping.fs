namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Apigatewayv2ApiMappingState<'ApiId, 'DomainName, 'Stage> = { assignments: ResizeArray<aws.Apigatewayv2ApiMapping.Apigatewayv2ApiMappingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api_mapping">aws_apigatewayv2_api_mapping</a>.
    /// </summary>
    type Apigatewayv2ApiMappingBuilder(logicalId: string) =
        member _.Yield(_: unit) : Apigatewayv2ApiMappingState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2ApiMappingState<Missing, Missing, Missing>)

        member _.Zero(()) : Apigatewayv2ApiMappingState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Apigatewayv2ApiMappingState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api_mapping#api_id-1">Apigatewayv2ApiMapping#api_id</a>.
        /// </summary>
        [<CustomOperation "api_id">]
        member _.ApiId(state: Apigatewayv2ApiMappingState<Missing, 'DomainName, 'Stage>, value: string) : Apigatewayv2ApiMappingState<Present, 'DomainName, 'Stage> =
            state.assignments.Add(fun config -> config.ApiId <- value)
            ({ assignments = state.assignments } : Apigatewayv2ApiMappingState<Present, 'DomainName, 'Stage>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api_mapping#domain_name-1">Apigatewayv2ApiMapping#domain_name</a>.
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: Apigatewayv2ApiMappingState<'ApiId, Missing, 'Stage>, value: string) : Apigatewayv2ApiMappingState<'ApiId, Present, 'Stage> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : Apigatewayv2ApiMappingState<'ApiId, Present, 'Stage>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api_mapping#stage-1">Apigatewayv2ApiMapping#stage</a>.
        /// </summary>
        [<CustomOperation "stage">]
        member _.Stage(state: Apigatewayv2ApiMappingState<'ApiId, 'DomainName, Missing>, value: string) : Apigatewayv2ApiMappingState<'ApiId, 'DomainName, Present> =
            state.assignments.Add(fun config -> config.Stage <- value)
            ({ assignments = state.assignments } : Apigatewayv2ApiMappingState<'ApiId, 'DomainName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api_mapping#api_mapping_key-1">Apigatewayv2ApiMapping#api_mapping_key</a>.
        /// </summary>
        [<CustomOperation "api_mapping_key">]
        member _.ApiMappingKey(state: Apigatewayv2ApiMappingState<'ApiId, 'DomainName, 'Stage>, value: string) : Apigatewayv2ApiMappingState<'ApiId, 'DomainName, 'Stage> =
            state.assignments.Add(fun config -> config.ApiMappingKey <- value)
            state : Apigatewayv2ApiMappingState<'ApiId, 'DomainName, 'Stage>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/apigatewayv2_api_mapping#id-1">Apigatewayv2ApiMapping#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Apigatewayv2ApiMappingState<'ApiId, 'DomainName, 'Stage>, value: string) : Apigatewayv2ApiMappingState<'ApiId, 'DomainName, 'Stage> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Apigatewayv2ApiMappingState<'ApiId, 'DomainName, 'Stage>

        member _.Run(state: Apigatewayv2ApiMappingState<Present, Present, Present>) : aws.Apigatewayv2ApiMapping.Apigatewayv2ApiMapping =
            let config = aws.Apigatewayv2ApiMapping.Apigatewayv2ApiMappingConfig()
            for setter in state.assignments do
                setter config
            aws.Apigatewayv2ApiMapping.Apigatewayv2ApiMapping(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apigatewayv2ApiMapping: missing required arguments. Must call: api_id, domain_name, stage.", 9999, IsError = true)>]
        member _.Run(_: Apigatewayv2ApiMappingState<_, _, _>) : aws.Apigatewayv2ApiMapping.Apigatewayv2ApiMapping =
            Unchecked.defaultof<aws.Apigatewayv2ApiMapping.Apigatewayv2ApiMapping>
