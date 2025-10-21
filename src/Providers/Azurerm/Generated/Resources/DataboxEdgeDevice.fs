namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataboxEdgeDeviceState<'Location, 'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.DataboxEdgeDevice.DataboxEdgeDeviceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databox_edge_device">azurerm_databox_edge_device</a>.
    /// </summary>
    type DataboxEdgeDeviceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataboxEdgeDeviceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataboxEdgeDeviceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataboxEdgeDeviceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataboxEdgeDeviceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databox_edge_device#location-1">DataboxEdgeDevice#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataboxEdgeDeviceState<Missing, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : DataboxEdgeDeviceState<Present, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataboxEdgeDeviceState<Present, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databox_edge_device#name-1">DataboxEdgeDevice#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataboxEdgeDeviceState<'Location, Missing, 'ResourceGroupName, 'SkuName>, value: string) : DataboxEdgeDeviceState<'Location, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataboxEdgeDeviceState<'Location, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databox_edge_device#resource_group_name-1">DataboxEdgeDevice#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataboxEdgeDeviceState<'Location, 'Name, Missing, 'SkuName>, value: string) : DataboxEdgeDeviceState<'Location, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataboxEdgeDeviceState<'Location, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databox_edge_device#sku_name-1">DataboxEdgeDevice#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: DataboxEdgeDeviceState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : DataboxEdgeDeviceState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : DataboxEdgeDeviceState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databox_edge_device#id-1">DataboxEdgeDevice#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataboxEdgeDeviceState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : DataboxEdgeDeviceState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataboxEdgeDeviceState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databox_edge_device#tags-1">DataboxEdgeDevice#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataboxEdgeDeviceState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : DataboxEdgeDeviceState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataboxEdgeDeviceState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databox_edge_device#timeouts-1">DataboxEdgeDevice#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataboxEdgeDeviceState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.DataboxEdgeDevice.DataboxEdgeDeviceTimeouts) : DataboxEdgeDeviceState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataboxEdgeDeviceState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: DataboxEdgeDeviceState<Present, Present, Present, Present>) : azurerm.DataboxEdgeDevice.DataboxEdgeDevice =
            let config = azurerm.DataboxEdgeDevice.DataboxEdgeDeviceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataboxEdgeDevice.DataboxEdgeDevice(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.databoxEdgeDevice: missing required arguments. Must call: location, name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: DataboxEdgeDeviceState<_, _, _, _>) : azurerm.DataboxEdgeDevice.DataboxEdgeDevice =
            Unchecked.defaultof<azurerm.DataboxEdgeDevice.DataboxEdgeDevice>
