namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDataShareAccountState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermDataShareAccount.DataAzurermDataShareAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_account">azurerm_data_share_account</a>.
    /// </summary>
    type DataAzurermDataShareAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDataShareAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataShareAccountState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDataShareAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataShareAccountState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_account#name-1">DataAzurermDataShareAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDataShareAccountState<Missing, 'ResourceGroupName>, value: string) : DataAzurermDataShareAccountState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDataShareAccountState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_account#resource_group_name-1">DataAzurermDataShareAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDataShareAccountState<'Name, Missing>, value: string) : DataAzurermDataShareAccountState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDataShareAccountState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_account#id-1">DataAzurermDataShareAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDataShareAccountState<'Name, 'ResourceGroupName>, value: string) : DataAzurermDataShareAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDataShareAccountState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/data_share_account#timeouts-1">DataAzurermDataShareAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDataShareAccountState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDataShareAccount.DataAzurermDataShareAccountTimeouts) : DataAzurermDataShareAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDataShareAccountState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermDataShareAccountState<Present, Present>) : azurerm.DataAzurermDataShareAccount.DataAzurermDataShareAccount =
            let config = azurerm.DataAzurermDataShareAccount.DataAzurermDataShareAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDataShareAccount.DataAzurermDataShareAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDataShareAccount: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDataShareAccountState<_, _>) : azurerm.DataAzurermDataShareAccount.DataAzurermDataShareAccount =
            Unchecked.defaultof<azurerm.DataAzurermDataShareAccount.DataAzurermDataShareAccount>
