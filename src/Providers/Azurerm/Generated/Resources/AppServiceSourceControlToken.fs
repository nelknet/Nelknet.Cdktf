namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServiceSourceControlTokenState<'Token, 'Type> = { assignments: ResizeArray<azurerm.AppServiceSourceControlToken.AppServiceSourceControlTokenConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_token">azurerm_app_service_source_control_token</a>.
    /// </summary>
    type AppServiceSourceControlTokenBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServiceSourceControlTokenState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceSourceControlTokenState<Missing, Missing>)

        member _.Zero(()) : AppServiceSourceControlTokenState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServiceSourceControlTokenState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_token#token-1">AppServiceSourceControlToken#token</a>.
        /// </summary>
        [<CustomOperation "token">]
        member _.Token(state: AppServiceSourceControlTokenState<Missing, 'Type>, value: string) : AppServiceSourceControlTokenState<Present, 'Type> =
            state.assignments.Add(fun config -> config.Token <- value)
            ({ assignments = state.assignments } : AppServiceSourceControlTokenState<Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_token#type-1">AppServiceSourceControlToken#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: AppServiceSourceControlTokenState<'Token, Missing>, value: string) : AppServiceSourceControlTokenState<'Token, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : AppServiceSourceControlTokenState<'Token, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_token#id-1">AppServiceSourceControlToken#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServiceSourceControlTokenState<'Token, 'Type>, value: string) : AppServiceSourceControlTokenState<'Token, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServiceSourceControlTokenState<'Token, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_token#timeouts-1">AppServiceSourceControlToken#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServiceSourceControlTokenState<'Token, 'Type>, value: azurerm.AppServiceSourceControlToken.AppServiceSourceControlTokenTimeouts) : AppServiceSourceControlTokenState<'Token, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServiceSourceControlTokenState<'Token, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_source_control_token#token_secret-1">AppServiceSourceControlToken#token_secret</a>.
        /// </summary>
        [<CustomOperation "token_secret">]
        member _.TokenSecret(state: AppServiceSourceControlTokenState<'Token, 'Type>, value: string) : AppServiceSourceControlTokenState<'Token, 'Type> =
            state.assignments.Add(fun config -> config.TokenSecret <- value)
            state : AppServiceSourceControlTokenState<'Token, 'Type>

        member _.Run(state: AppServiceSourceControlTokenState<Present, Present>) : azurerm.AppServiceSourceControlToken.AppServiceSourceControlToken =
            let config = azurerm.AppServiceSourceControlToken.AppServiceSourceControlTokenConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServiceSourceControlToken.AppServiceSourceControlToken(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServiceSourceControlToken: missing required arguments. Must call: token, type.", 9999, IsError = true)>]
        member _.Run(_: AppServiceSourceControlTokenState<_, _>) : azurerm.AppServiceSourceControlToken.AppServiceSourceControlToken =
            Unchecked.defaultof<azurerm.AppServiceSourceControlToken.AppServiceSourceControlToken>
