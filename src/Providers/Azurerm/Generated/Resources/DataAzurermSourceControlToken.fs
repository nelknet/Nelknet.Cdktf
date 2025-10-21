namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermSourceControlTokenState<'Type> = { assignments: ResizeArray<azurerm.DataAzurermSourceControlToken.DataAzurermSourceControlTokenConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/source_control_token">azurerm_source_control_token</a>.
    /// </summary>
    type DataAzurermSourceControlTokenBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermSourceControlTokenState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSourceControlTokenState<Missing>)

        member _.Zero(()) : DataAzurermSourceControlTokenState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermSourceControlTokenState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/source_control_token#type-1">DataAzurermSourceControlToken#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: DataAzurermSourceControlTokenState<Missing>, value: string) : DataAzurermSourceControlTokenState<Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : DataAzurermSourceControlTokenState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/source_control_token#id-1">DataAzurermSourceControlToken#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermSourceControlTokenState<'Type>, value: string) : DataAzurermSourceControlTokenState<'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermSourceControlTokenState<'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/source_control_token#timeouts-1">DataAzurermSourceControlToken#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermSourceControlTokenState<'Type>, value: azurerm.DataAzurermSourceControlToken.DataAzurermSourceControlTokenTimeouts) : DataAzurermSourceControlTokenState<'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermSourceControlTokenState<'Type>

        member _.Run(state: DataAzurermSourceControlTokenState<Present>) : azurerm.DataAzurermSourceControlToken.DataAzurermSourceControlToken =
            let config = azurerm.DataAzurermSourceControlToken.DataAzurermSourceControlTokenConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermSourceControlToken.DataAzurermSourceControlToken(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermSourceControlToken: missing required arguments. Must call: type.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermSourceControlTokenState<_>) : azurerm.DataAzurermSourceControlToken.DataAzurermSourceControlToken =
            Unchecked.defaultof<azurerm.DataAzurermSourceControlToken.DataAzurermSourceControlToken>
