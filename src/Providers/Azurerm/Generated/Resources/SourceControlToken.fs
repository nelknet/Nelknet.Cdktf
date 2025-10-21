namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SourceControlTokenState<'Token, 'Type> = { assignments: ResizeArray<azurerm.SourceControlToken.SourceControlTokenConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/source_control_token">azurerm_source_control_token</a>.
    /// </summary>
    type SourceControlTokenBuilder(logicalId: string) =
        member _.Yield(_: unit) : SourceControlTokenState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SourceControlTokenState<Missing, Missing>)

        member _.Zero(()) : SourceControlTokenState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SourceControlTokenState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/source_control_token#token-1">SourceControlToken#token</a>.
        /// </summary>
        [<CustomOperation "token">]
        member _.Token(state: SourceControlTokenState<Missing, 'Type>, value: string) : SourceControlTokenState<Present, 'Type> =
            state.assignments.Add(fun config -> config.Token <- value)
            ({ assignments = state.assignments } : SourceControlTokenState<Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/source_control_token#type-1">SourceControlToken#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: SourceControlTokenState<'Token, Missing>, value: string) : SourceControlTokenState<'Token, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : SourceControlTokenState<'Token, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/source_control_token#id-1">SourceControlToken#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SourceControlTokenState<'Token, 'Type>, value: string) : SourceControlTokenState<'Token, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SourceControlTokenState<'Token, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/source_control_token#timeouts-1">SourceControlToken#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SourceControlTokenState<'Token, 'Type>, value: azurerm.SourceControlToken.SourceControlTokenTimeouts) : SourceControlTokenState<'Token, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SourceControlTokenState<'Token, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/source_control_token#token_secret-1">SourceControlToken#token_secret</a>.
        /// </summary>
        [<CustomOperation "token_secret">]
        member _.TokenSecret(state: SourceControlTokenState<'Token, 'Type>, value: string) : SourceControlTokenState<'Token, 'Type> =
            state.assignments.Add(fun config -> config.TokenSecret <- value)
            state : SourceControlTokenState<'Token, 'Type>

        member _.Run(state: SourceControlTokenState<Present, Present>) : azurerm.SourceControlToken.SourceControlToken =
            let config = azurerm.SourceControlToken.SourceControlTokenConfig()
            for setter in state.assignments do
                setter config
            azurerm.SourceControlToken.SourceControlToken(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.sourceControlToken: missing required arguments. Must call: token, type.", 9999, IsError = true)>]
        member _.Run(_: SourceControlTokenState<_, _>) : azurerm.SourceControlToken.SourceControlToken =
            Unchecked.defaultof<azurerm.SourceControlToken.SourceControlToken>
