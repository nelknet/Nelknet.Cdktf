namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMonitorActionGroupState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_action_group">azurerm_monitor_action_group</a>.
    /// </summary>
    type DataAzurermMonitorActionGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMonitorActionGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMonitorActionGroupState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMonitorActionGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMonitorActionGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_action_group#name-1">DataAzurermMonitorActionGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMonitorActionGroupState<Missing, 'ResourceGroupName>, value: string) : DataAzurermMonitorActionGroupState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMonitorActionGroupState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_action_group#resource_group_name-1">DataAzurermMonitorActionGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermMonitorActionGroupState<'Name, Missing>, value: string) : DataAzurermMonitorActionGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermMonitorActionGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_action_group#id-1">DataAzurermMonitorActionGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMonitorActionGroupState<'Name, 'ResourceGroupName>, value: string) : DataAzurermMonitorActionGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMonitorActionGroupState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_action_group#timeouts-1">DataAzurermMonitorActionGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMonitorActionGroupState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupTimeouts) : DataAzurermMonitorActionGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMonitorActionGroupState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermMonitorActionGroupState<Present, Present>) : azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroup =
            let config = azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMonitorActionGroup: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMonitorActionGroupState<_, _>) : azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroup =
            Unchecked.defaultof<azurerm.DataAzurermMonitorActionGroup.DataAzurermMonitorActionGroup>
