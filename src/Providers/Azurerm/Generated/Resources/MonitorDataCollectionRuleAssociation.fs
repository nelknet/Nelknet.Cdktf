namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MonitorDataCollectionRuleAssociationState<'TargetResourceId> = { assignments: ResizeArray<azurerm.MonitorDataCollectionRuleAssociation.MonitorDataCollectionRuleAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule_association">azurerm_monitor_data_collection_rule_association</a>.
    /// </summary>
    type MonitorDataCollectionRuleAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : MonitorDataCollectionRuleAssociationState<Missing> =
            ({ assignments = ResizeArray() } : MonitorDataCollectionRuleAssociationState<Missing>)

        member _.Zero(()) : MonitorDataCollectionRuleAssociationState<Missing> =
            ({ assignments = ResizeArray() } : MonitorDataCollectionRuleAssociationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule_association#target_resource_id-1">MonitorDataCollectionRuleAssociation#target_resource_id</a>.
        /// </summary>
        [<CustomOperation "target_resource_id">]
        member _.TargetResourceId(state: MonitorDataCollectionRuleAssociationState<Missing>, value: string) : MonitorDataCollectionRuleAssociationState<Present> =
            state.assignments.Add(fun config -> config.TargetResourceId <- value)
            ({ assignments = state.assignments } : MonitorDataCollectionRuleAssociationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule_association#data_collection_endpoint_id-1">MonitorDataCollectionRuleAssociation#data_collection_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "data_collection_endpoint_id">]
        member _.DataCollectionEndpointId(state: MonitorDataCollectionRuleAssociationState<'TargetResourceId>, value: string) : MonitorDataCollectionRuleAssociationState<'TargetResourceId> =
            state.assignments.Add(fun config -> config.DataCollectionEndpointId <- value)
            state : MonitorDataCollectionRuleAssociationState<'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule_association#data_collection_rule_id-1">MonitorDataCollectionRuleAssociation#data_collection_rule_id</a>.
        /// </summary>
        [<CustomOperation "data_collection_rule_id">]
        member _.DataCollectionRuleId(state: MonitorDataCollectionRuleAssociationState<'TargetResourceId>, value: string) : MonitorDataCollectionRuleAssociationState<'TargetResourceId> =
            state.assignments.Add(fun config -> config.DataCollectionRuleId <- value)
            state : MonitorDataCollectionRuleAssociationState<'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule_association#description-1">MonitorDataCollectionRuleAssociation#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MonitorDataCollectionRuleAssociationState<'TargetResourceId>, value: string) : MonitorDataCollectionRuleAssociationState<'TargetResourceId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MonitorDataCollectionRuleAssociationState<'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule_association#id-1">MonitorDataCollectionRuleAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MonitorDataCollectionRuleAssociationState<'TargetResourceId>, value: string) : MonitorDataCollectionRuleAssociationState<'TargetResourceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MonitorDataCollectionRuleAssociationState<'TargetResourceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule_association#name-1">MonitorDataCollectionRuleAssociation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MonitorDataCollectionRuleAssociationState<'TargetResourceId>, value: string) : MonitorDataCollectionRuleAssociationState<'TargetResourceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : MonitorDataCollectionRuleAssociationState<'TargetResourceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/monitor_data_collection_rule_association#timeouts-1">MonitorDataCollectionRuleAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MonitorDataCollectionRuleAssociationState<'TargetResourceId>, value: azurerm.MonitorDataCollectionRuleAssociation.MonitorDataCollectionRuleAssociationTimeouts) : MonitorDataCollectionRuleAssociationState<'TargetResourceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MonitorDataCollectionRuleAssociationState<'TargetResourceId>

        member _.Run(state: MonitorDataCollectionRuleAssociationState<Present>) : azurerm.MonitorDataCollectionRuleAssociation.MonitorDataCollectionRuleAssociation =
            let config = azurerm.MonitorDataCollectionRuleAssociation.MonitorDataCollectionRuleAssociationConfig()
            for setter in state.assignments do
                setter config
            azurerm.MonitorDataCollectionRuleAssociation.MonitorDataCollectionRuleAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.monitorDataCollectionRuleAssociation: missing required arguments. Must call: target_resource_id.", 9999, IsError = true)>]
        member _.Run(_: MonitorDataCollectionRuleAssociationState<_>) : azurerm.MonitorDataCollectionRuleAssociation.MonitorDataCollectionRuleAssociation =
            Unchecked.defaultof<azurerm.MonitorDataCollectionRuleAssociation.MonitorDataCollectionRuleAssociation>
