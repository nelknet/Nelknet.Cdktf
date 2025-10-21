namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermVirtualHubState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermVirtualHub.DataAzurermVirtualHubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub">azurerm_virtual_hub</a>.
    /// </summary>
    type DataAzurermVirtualHubBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermVirtualHubState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualHubState<Missing, Missing>)

        member _.Zero(()) : DataAzurermVirtualHubState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermVirtualHubState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub#name-1">DataAzurermVirtualHub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermVirtualHubState<Missing, 'ResourceGroupName>, value: string) : DataAzurermVirtualHubState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualHubState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub#resource_group_name-1">DataAzurermVirtualHub#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermVirtualHubState<'Name, Missing>, value: string) : DataAzurermVirtualHubState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermVirtualHubState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub#id-1">DataAzurermVirtualHub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermVirtualHubState<'Name, 'ResourceGroupName>, value: string) : DataAzurermVirtualHubState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermVirtualHubState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/virtual_hub#timeouts-1">DataAzurermVirtualHub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermVirtualHubState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermVirtualHub.DataAzurermVirtualHubTimeouts) : DataAzurermVirtualHubState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermVirtualHubState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermVirtualHubState<Present, Present>) : azurerm.DataAzurermVirtualHub.DataAzurermVirtualHub =
            let config = azurerm.DataAzurermVirtualHub.DataAzurermVirtualHubConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermVirtualHub.DataAzurermVirtualHub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermVirtualHub: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermVirtualHubState<_, _>) : azurerm.DataAzurermVirtualHub.DataAzurermVirtualHub =
            Unchecked.defaultof<azurerm.DataAzurermVirtualHub.DataAzurermVirtualHub>
