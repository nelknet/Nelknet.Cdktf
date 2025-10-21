namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StaticWebAppFunctionAppRegistrationState<'FunctionAppId, 'StaticWebAppId> = { assignments: ResizeArray<azurerm.StaticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistrationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app_function_app_registration">azurerm_static_web_app_function_app_registration</a>.
    /// </summary>
    type StaticWebAppFunctionAppRegistrationBuilder(logicalId: string) =
        member _.Yield(_: unit) : StaticWebAppFunctionAppRegistrationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StaticWebAppFunctionAppRegistrationState<Missing, Missing>)

        member _.Zero(()) : StaticWebAppFunctionAppRegistrationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : StaticWebAppFunctionAppRegistrationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app_function_app_registration#function_app_id-1">StaticWebAppFunctionAppRegistration#function_app_id</a>.
        /// </summary>
        [<CustomOperation "function_app_id">]
        member _.FunctionAppId(state: StaticWebAppFunctionAppRegistrationState<Missing, 'StaticWebAppId>, value: string) : StaticWebAppFunctionAppRegistrationState<Present, 'StaticWebAppId> =
            state.assignments.Add(fun config -> config.FunctionAppId <- value)
            ({ assignments = state.assignments } : StaticWebAppFunctionAppRegistrationState<Present, 'StaticWebAppId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app_function_app_registration#static_web_app_id-1">StaticWebAppFunctionAppRegistration#static_web_app_id</a>.
        /// </summary>
        [<CustomOperation "static_web_app_id">]
        member _.StaticWebAppId(state: StaticWebAppFunctionAppRegistrationState<'FunctionAppId, Missing>, value: string) : StaticWebAppFunctionAppRegistrationState<'FunctionAppId, Present> =
            state.assignments.Add(fun config -> config.StaticWebAppId <- value)
            ({ assignments = state.assignments } : StaticWebAppFunctionAppRegistrationState<'FunctionAppId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app_function_app_registration#id-1">StaticWebAppFunctionAppRegistration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StaticWebAppFunctionAppRegistrationState<'FunctionAppId, 'StaticWebAppId>, value: string) : StaticWebAppFunctionAppRegistrationState<'FunctionAppId, 'StaticWebAppId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StaticWebAppFunctionAppRegistrationState<'FunctionAppId, 'StaticWebAppId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/static_web_app_function_app_registration#timeouts-1">StaticWebAppFunctionAppRegistration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StaticWebAppFunctionAppRegistrationState<'FunctionAppId, 'StaticWebAppId>, value: azurerm.StaticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistrationTimeouts) : StaticWebAppFunctionAppRegistrationState<'FunctionAppId, 'StaticWebAppId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StaticWebAppFunctionAppRegistrationState<'FunctionAppId, 'StaticWebAppId>

        member _.Run(state: StaticWebAppFunctionAppRegistrationState<Present, Present>) : azurerm.StaticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistration =
            let config = azurerm.StaticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistrationConfig()
            for setter in state.assignments do
                setter config
            azurerm.StaticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.staticWebAppFunctionAppRegistration: missing required arguments. Must call: function_app_id, static_web_app_id.", 9999, IsError = true)>]
        member _.Run(_: StaticWebAppFunctionAppRegistrationState<_, _>) : azurerm.StaticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistration =
            Unchecked.defaultof<azurerm.StaticWebAppFunctionAppRegistration.StaticWebAppFunctionAppRegistration>
