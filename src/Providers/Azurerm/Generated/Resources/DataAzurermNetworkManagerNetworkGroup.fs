namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermNetworkManagerNetworkGroupState<'Name, 'NetworkManagerId> = { assignments: ResizeArray<azurerm.DataAzurermNetworkManagerNetworkGroup.DataAzurermNetworkManagerNetworkGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager_network_group">azurerm_network_manager_network_group</a>.
    /// </summary>
    type DataAzurermNetworkManagerNetworkGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermNetworkManagerNetworkGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetworkManagerNetworkGroupState<Missing, Missing>)

        member _.Zero(()) : DataAzurermNetworkManagerNetworkGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermNetworkManagerNetworkGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager_network_group#name-1">DataAzurermNetworkManagerNetworkGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermNetworkManagerNetworkGroupState<Missing, 'NetworkManagerId>, value: string) : DataAzurermNetworkManagerNetworkGroupState<Present, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermNetworkManagerNetworkGroupState<Present, 'NetworkManagerId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager_network_group#network_manager_id-1">DataAzurermNetworkManagerNetworkGroup#network_manager_id</a>.
        /// </summary>
        [<CustomOperation "network_manager_id">]
        member _.NetworkManagerId(state: DataAzurermNetworkManagerNetworkGroupState<'Name, Missing>, value: string) : DataAzurermNetworkManagerNetworkGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.NetworkManagerId <- value)
            ({ assignments = state.assignments } : DataAzurermNetworkManagerNetworkGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager_network_group#id-1">DataAzurermNetworkManagerNetworkGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermNetworkManagerNetworkGroupState<'Name, 'NetworkManagerId>, value: string) : DataAzurermNetworkManagerNetworkGroupState<'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermNetworkManagerNetworkGroupState<'Name, 'NetworkManagerId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/network_manager_network_group#timeouts-1">DataAzurermNetworkManagerNetworkGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermNetworkManagerNetworkGroupState<'Name, 'NetworkManagerId>, value: azurerm.DataAzurermNetworkManagerNetworkGroup.DataAzurermNetworkManagerNetworkGroupTimeouts) : DataAzurermNetworkManagerNetworkGroupState<'Name, 'NetworkManagerId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermNetworkManagerNetworkGroupState<'Name, 'NetworkManagerId>

        member _.Run(state: DataAzurermNetworkManagerNetworkGroupState<Present, Present>) : azurerm.DataAzurermNetworkManagerNetworkGroup.DataAzurermNetworkManagerNetworkGroup =
            let config = azurerm.DataAzurermNetworkManagerNetworkGroup.DataAzurermNetworkManagerNetworkGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermNetworkManagerNetworkGroup.DataAzurermNetworkManagerNetworkGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermNetworkManagerNetworkGroup: missing required arguments. Must call: name, network_manager_id.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermNetworkManagerNetworkGroupState<_, _>) : azurerm.DataAzurermNetworkManagerNetworkGroup.DataAzurermNetworkManagerNetworkGroup =
            Unchecked.defaultof<azurerm.DataAzurermNetworkManagerNetworkGroup.DataAzurermNetworkManagerNetworkGroup>
