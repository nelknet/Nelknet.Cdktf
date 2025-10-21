namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiGatewayMethodSettingsState<'MethodPath, 'RestApiId, 'Settings, 'StageName> = { assignments: ResizeArray<aws.ApiGatewayMethodSettings.ApiGatewayMethodSettingsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method_settings">aws_api_gateway_method_settings</a>.
    /// </summary>
    type ApiGatewayMethodSettingsBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiGatewayMethodSettingsState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayMethodSettingsState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiGatewayMethodSettingsState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiGatewayMethodSettingsState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method_settings#method_path-1">ApiGatewayMethodSettings#method_path</a>.
        /// </summary>
        [<CustomOperation "method_path">]
        member _.MethodPath(state: ApiGatewayMethodSettingsState<Missing, 'RestApiId, 'Settings, 'StageName>, value: string) : ApiGatewayMethodSettingsState<Present, 'RestApiId, 'Settings, 'StageName> =
            state.assignments.Add(fun config -> config.MethodPath <- value)
            ({ assignments = state.assignments } : ApiGatewayMethodSettingsState<Present, 'RestApiId, 'Settings, 'StageName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method_settings#rest_api_id-1">ApiGatewayMethodSettings#rest_api_id</a>.
        /// </summary>
        [<CustomOperation "rest_api_id">]
        member _.RestApiId(state: ApiGatewayMethodSettingsState<'MethodPath, Missing, 'Settings, 'StageName>, value: string) : ApiGatewayMethodSettingsState<'MethodPath, Present, 'Settings, 'StageName> =
            state.assignments.Add(fun config -> config.RestApiId <- value)
            ({ assignments = state.assignments } : ApiGatewayMethodSettingsState<'MethodPath, Present, 'Settings, 'StageName>)

        /// <summary>
        /// settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method_settings#settings-1">ApiGatewayMethodSettings#settings</a>
        /// </summary>
        [<CustomOperation "settings">]
        member _.Settings(state: ApiGatewayMethodSettingsState<'MethodPath, 'RestApiId, Missing, 'StageName>, value: aws.ApiGatewayMethodSettings.ApiGatewayMethodSettingsSettings) : ApiGatewayMethodSettingsState<'MethodPath, 'RestApiId, Present, 'StageName> =
            state.assignments.Add(fun config -> config.Settings <- value)
            ({ assignments = state.assignments } : ApiGatewayMethodSettingsState<'MethodPath, 'RestApiId, Present, 'StageName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method_settings#stage_name-1">ApiGatewayMethodSettings#stage_name</a>.
        /// </summary>
        [<CustomOperation "stage_name">]
        member _.StageName(state: ApiGatewayMethodSettingsState<'MethodPath, 'RestApiId, 'Settings, Missing>, value: string) : ApiGatewayMethodSettingsState<'MethodPath, 'RestApiId, 'Settings, Present> =
            state.assignments.Add(fun config -> config.StageName <- value)
            ({ assignments = state.assignments } : ApiGatewayMethodSettingsState<'MethodPath, 'RestApiId, 'Settings, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/api_gateway_method_settings#id-1">ApiGatewayMethodSettings#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiGatewayMethodSettingsState<'MethodPath, 'RestApiId, 'Settings, 'StageName>, value: string) : ApiGatewayMethodSettingsState<'MethodPath, 'RestApiId, 'Settings, 'StageName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiGatewayMethodSettingsState<'MethodPath, 'RestApiId, 'Settings, 'StageName>

        member _.Run(state: ApiGatewayMethodSettingsState<Present, Present, Present, Present>) : aws.ApiGatewayMethodSettings.ApiGatewayMethodSettings =
            let config = aws.ApiGatewayMethodSettings.ApiGatewayMethodSettingsConfig()
            for setter in state.assignments do
                setter config
            aws.ApiGatewayMethodSettings.ApiGatewayMethodSettings(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.apiGatewayMethodSettings: missing required arguments. Must call: method_path, rest_api_id, settings, stage_name.", 9999, IsError = true)>]
        member _.Run(_: ApiGatewayMethodSettingsState<_, _, _, _>) : aws.ApiGatewayMethodSettings.ApiGatewayMethodSettings =
            Unchecked.defaultof<aws.ApiGatewayMethodSettings.ApiGatewayMethodSettings>
