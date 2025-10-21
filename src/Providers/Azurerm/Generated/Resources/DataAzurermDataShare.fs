namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDataShareState<'AccountId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermDataShare.DataAzurermDataShareConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share">azurerm_data_share</a>.
    /// </summary>
    type DataAzurermDataShareBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDataShareState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataShareState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDataShareState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataShareState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share#account_id-1">DataAzurermDataShare#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: DataAzurermDataShareState<Missing, 'Name>, value: string) : DataAzurermDataShareState<Present, 'Name> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : DataAzurermDataShareState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share#name-1">DataAzurermDataShare#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDataShareState<'AccountId, Missing>, value: string) : DataAzurermDataShareState<'AccountId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDataShareState<'AccountId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share#id-1">DataAzurermDataShare#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDataShareState<'AccountId, 'Name>, value: string) : DataAzurermDataShareState<'AccountId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDataShareState<'AccountId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share#timeouts-1">DataAzurermDataShare#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDataShareState<'AccountId, 'Name>, value: azurerm.DataAzurermDataShare.DataAzurermDataShareTimeouts) : DataAzurermDataShareState<'AccountId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDataShareState<'AccountId, 'Name>

        member _.Run(state: DataAzurermDataShareState<Present, Present>) : azurerm.DataAzurermDataShare.DataAzurermDataShare =
            let config = azurerm.DataAzurermDataShare.DataAzurermDataShareConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDataShare.DataAzurermDataShare(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDataShare: missing required arguments. Must call: account_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDataShareState<_, _>) : azurerm.DataAzurermDataShare.DataAzurermDataShare =
            Unchecked.defaultof<azurerm.DataAzurermDataShare.DataAzurermDataShare>
