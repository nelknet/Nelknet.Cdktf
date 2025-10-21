namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermMonitorDataCollectionRuleState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_data_collection_rule">azurerm_monitor_data_collection_rule</a>.
    /// </summary>
    type DataAzurermMonitorDataCollectionRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermMonitorDataCollectionRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMonitorDataCollectionRuleState<Missing, Missing>)

        member _.Zero(()) : DataAzurermMonitorDataCollectionRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermMonitorDataCollectionRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_data_collection_rule#name-1">DataAzurermMonitorDataCollectionRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermMonitorDataCollectionRuleState<Missing, 'ResourceGroupName>, value: string) : DataAzurermMonitorDataCollectionRuleState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermMonitorDataCollectionRuleState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_data_collection_rule#resource_group_name-1">DataAzurermMonitorDataCollectionRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermMonitorDataCollectionRuleState<'Name, Missing>, value: string) : DataAzurermMonitorDataCollectionRuleState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermMonitorDataCollectionRuleState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_data_collection_rule#id-1">DataAzurermMonitorDataCollectionRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermMonitorDataCollectionRuleState<'Name, 'ResourceGroupName>, value: string) : DataAzurermMonitorDataCollectionRuleState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermMonitorDataCollectionRuleState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/monitor_data_collection_rule#timeouts-1">DataAzurermMonitorDataCollectionRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermMonitorDataCollectionRuleState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleTimeouts) : DataAzurermMonitorDataCollectionRuleState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermMonitorDataCollectionRuleState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermMonitorDataCollectionRuleState<Present, Present>) : azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRule =
            let config = azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermMonitorDataCollectionRule: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermMonitorDataCollectionRuleState<_, _>) : azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRule =
            Unchecked.defaultof<azurerm.DataAzurermMonitorDataCollectionRule.DataAzurermMonitorDataCollectionRule>
