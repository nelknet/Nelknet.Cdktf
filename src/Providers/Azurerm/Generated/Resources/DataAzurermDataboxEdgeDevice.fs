namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermDataboxEdgeDeviceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermDataboxEdgeDevice.DataAzurermDataboxEdgeDeviceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databox_edge_device">azurerm_databox_edge_device</a>.
    /// </summary>
    type DataAzurermDataboxEdgeDeviceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermDataboxEdgeDeviceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataboxEdgeDeviceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermDataboxEdgeDeviceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermDataboxEdgeDeviceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databox_edge_device#name-1">DataAzurermDataboxEdgeDevice#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermDataboxEdgeDeviceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermDataboxEdgeDeviceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermDataboxEdgeDeviceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databox_edge_device#resource_group_name-1">DataAzurermDataboxEdgeDevice#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermDataboxEdgeDeviceState<'Name, Missing>, value: string) : DataAzurermDataboxEdgeDeviceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermDataboxEdgeDeviceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databox_edge_device#id-1">DataAzurermDataboxEdgeDevice#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermDataboxEdgeDeviceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermDataboxEdgeDeviceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermDataboxEdgeDeviceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/databox_edge_device#timeouts-1">DataAzurermDataboxEdgeDevice#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermDataboxEdgeDeviceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermDataboxEdgeDevice.DataAzurermDataboxEdgeDeviceTimeouts) : DataAzurermDataboxEdgeDeviceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermDataboxEdgeDeviceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermDataboxEdgeDeviceState<Present, Present>) : azurerm.DataAzurermDataboxEdgeDevice.DataAzurermDataboxEdgeDevice =
            let config = azurerm.DataAzurermDataboxEdgeDevice.DataAzurermDataboxEdgeDeviceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermDataboxEdgeDevice.DataAzurermDataboxEdgeDevice(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermDataboxEdgeDevice: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermDataboxEdgeDeviceState<_, _>) : azurerm.DataAzurermDataboxEdgeDevice.DataAzurermDataboxEdgeDevice =
            Unchecked.defaultof<azurerm.DataAzurermDataboxEdgeDevice.DataAzurermDataboxEdgeDevice>
