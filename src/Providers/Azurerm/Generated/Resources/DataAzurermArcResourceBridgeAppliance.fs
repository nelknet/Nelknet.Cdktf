namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermArcResourceBridgeApplianceState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermArcResourceBridgeAppliance.DataAzurermArcResourceBridgeApplianceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/arc_resource_bridge_appliance">azurerm_arc_resource_bridge_appliance</a>.
    /// </summary>
    type DataAzurermArcResourceBridgeApplianceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermArcResourceBridgeApplianceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermArcResourceBridgeApplianceState<Missing, Missing>)

        member _.Zero(()) : DataAzurermArcResourceBridgeApplianceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermArcResourceBridgeApplianceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/arc_resource_bridge_appliance#name-1">DataAzurermArcResourceBridgeAppliance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermArcResourceBridgeApplianceState<Missing, 'ResourceGroupName>, value: string) : DataAzurermArcResourceBridgeApplianceState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermArcResourceBridgeApplianceState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/arc_resource_bridge_appliance#resource_group_name-1">DataAzurermArcResourceBridgeAppliance#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermArcResourceBridgeApplianceState<'Name, Missing>, value: string) : DataAzurermArcResourceBridgeApplianceState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermArcResourceBridgeApplianceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/arc_resource_bridge_appliance#id-1">DataAzurermArcResourceBridgeAppliance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermArcResourceBridgeApplianceState<'Name, 'ResourceGroupName>, value: string) : DataAzurermArcResourceBridgeApplianceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermArcResourceBridgeApplianceState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/arc_resource_bridge_appliance#timeouts-1">DataAzurermArcResourceBridgeAppliance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermArcResourceBridgeApplianceState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermArcResourceBridgeAppliance.DataAzurermArcResourceBridgeApplianceTimeouts) : DataAzurermArcResourceBridgeApplianceState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermArcResourceBridgeApplianceState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermArcResourceBridgeApplianceState<Present, Present>) : azurerm.DataAzurermArcResourceBridgeAppliance.DataAzurermArcResourceBridgeAppliance =
            let config = azurerm.DataAzurermArcResourceBridgeAppliance.DataAzurermArcResourceBridgeApplianceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermArcResourceBridgeAppliance.DataAzurermArcResourceBridgeAppliance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermArcResourceBridgeAppliance: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermArcResourceBridgeApplianceState<_, _>) : azurerm.DataAzurermArcResourceBridgeAppliance.DataAzurermArcResourceBridgeAppliance =
            Unchecked.defaultof<azurerm.DataAzurermArcResourceBridgeAppliance.DataAzurermArcResourceBridgeAppliance>
