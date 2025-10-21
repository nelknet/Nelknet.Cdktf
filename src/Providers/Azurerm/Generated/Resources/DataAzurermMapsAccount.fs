namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMapsAccountState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermMapsAccount.DataAzurermMapsAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/maps_account">azurerm_maps_account</a>.
    /// </summary>
    type DataAzurermMapsAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMapsAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMapsAccountState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMapsAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMapsAccountState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/maps_account#name-1">DataAzurermMapsAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMapsAccountState<Missing, 'ResourceGroupName>, value: string) : DataAzurermMapsAccountState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMapsAccountState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/maps_account#resource_group_name-1">DataAzurermMapsAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermMapsAccountState<'Name, Missing>, value: string) : DataAzurermMapsAccountState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermMapsAccountState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/maps_account#id-1">DataAzurermMapsAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMapsAccountState<'Name, 'ResourceGroupName>, value: string) : DataAzurermMapsAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMapsAccountState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/maps_account#tags-1">DataAzurermMapsAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAzurermMapsAccountState<'Name, 'ResourceGroupName>, value: seq<string * string>) : DataAzurermMapsAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAzurermMapsAccountState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/maps_account#timeouts-1">DataAzurermMapsAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMapsAccountState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermMapsAccount.DataAzurermMapsAccountTimeouts) : DataAzurermMapsAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMapsAccountState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermMapsAccountState<Present, Present>) : azurerm.DataAzurermMapsAccount.DataAzurermMapsAccount =
            let config = azurerm.DataAzurermMapsAccount.DataAzurermMapsAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMapsAccount.DataAzurermMapsAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMapsAccount: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMapsAccountState<_, _>) : azurerm.DataAzurermMapsAccount.DataAzurermMapsAccount =
            Unchecked.defaultof<azurerm.DataAzurermMapsAccount.DataAzurermMapsAccount>
