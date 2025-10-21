namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventhubNamespaceDisasterRecoveryConfigState<'Name, 'NamespaceName, 'PartnerNamespaceId, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.EventhubNamespaceDisasterRecoveryConfig.EventhubNamespaceDisasterRecoveryConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_disaster_recovery_config">azurerm_eventhub_namespace_disaster_recovery_config</a>.
    /// </summary>
    type EventhubNamespaceDisasterRecoveryConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventhubNamespaceDisasterRecoveryConfigState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubNamespaceDisasterRecoveryConfigState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : EventhubNamespaceDisasterRecoveryConfigState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubNamespaceDisasterRecoveryConfigState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_disaster_recovery_config#name-1">EventhubNamespaceDisasterRecoveryConfig#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EventhubNamespaceDisasterRecoveryConfigState<Missing, 'NamespaceName, 'PartnerNamespaceId, 'ResourceGroupName>, value: string) : EventhubNamespaceDisasterRecoveryConfigState<Present, 'NamespaceName, 'PartnerNamespaceId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EventhubNamespaceDisasterRecoveryConfigState<Present, 'NamespaceName, 'PartnerNamespaceId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_disaster_recovery_config#namespace_name-1">EventhubNamespaceDisasterRecoveryConfig#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: EventhubNamespaceDisasterRecoveryConfigState<'Name, Missing, 'PartnerNamespaceId, 'ResourceGroupName>, value: string) : EventhubNamespaceDisasterRecoveryConfigState<'Name, Present, 'PartnerNamespaceId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : EventhubNamespaceDisasterRecoveryConfigState<'Name, Present, 'PartnerNamespaceId, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_disaster_recovery_config#partner_namespace_id-1">EventhubNamespaceDisasterRecoveryConfig#partner_namespace_id</a>.
        /// </summary>
        [<CustomOperation "partner_namespace_id">]
        member _.PartnerNamespaceId(state: EventhubNamespaceDisasterRecoveryConfigState<'Name, 'NamespaceName, Missing, 'ResourceGroupName>, value: string) : EventhubNamespaceDisasterRecoveryConfigState<'Name, 'NamespaceName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PartnerNamespaceId <- value)
            ({ assignments = state.assignments } : EventhubNamespaceDisasterRecoveryConfigState<'Name, 'NamespaceName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_disaster_recovery_config#resource_group_name-1">EventhubNamespaceDisasterRecoveryConfig#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: EventhubNamespaceDisasterRecoveryConfigState<'Name, 'NamespaceName, 'PartnerNamespaceId, Missing>, value: string) : EventhubNamespaceDisasterRecoveryConfigState<'Name, 'NamespaceName, 'PartnerNamespaceId, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : EventhubNamespaceDisasterRecoveryConfigState<'Name, 'NamespaceName, 'PartnerNamespaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_disaster_recovery_config#id-1">EventhubNamespaceDisasterRecoveryConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventhubNamespaceDisasterRecoveryConfigState<'Name, 'NamespaceName, 'PartnerNamespaceId, 'ResourceGroupName>, value: string) : EventhubNamespaceDisasterRecoveryConfigState<'Name, 'NamespaceName, 'PartnerNamespaceId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventhubNamespaceDisasterRecoveryConfigState<'Name, 'NamespaceName, 'PartnerNamespaceId, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_disaster_recovery_config#timeouts-1">EventhubNamespaceDisasterRecoveryConfig#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventhubNamespaceDisasterRecoveryConfigState<'Name, 'NamespaceName, 'PartnerNamespaceId, 'ResourceGroupName>, value: azurerm.EventhubNamespaceDisasterRecoveryConfig.EventhubNamespaceDisasterRecoveryConfigTimeouts) : EventhubNamespaceDisasterRecoveryConfigState<'Name, 'NamespaceName, 'PartnerNamespaceId, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventhubNamespaceDisasterRecoveryConfigState<'Name, 'NamespaceName, 'PartnerNamespaceId, 'ResourceGroupName>

        member _.Run(state: EventhubNamespaceDisasterRecoveryConfigState<Present, Present, Present, Present>) : azurerm.EventhubNamespaceDisasterRecoveryConfig.EventhubNamespaceDisasterRecoveryConfig =
            let config = azurerm.EventhubNamespaceDisasterRecoveryConfig.EventhubNamespaceDisasterRecoveryConfigConfig()
            for setter in state.assignments do
                setter config
            azurerm.EventhubNamespaceDisasterRecoveryConfig.EventhubNamespaceDisasterRecoveryConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventhubNamespaceDisasterRecoveryConfig: missing required arguments. Must call: name, namespace_name, partner_namespace_id, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: EventhubNamespaceDisasterRecoveryConfigState<_, _, _, _>) : azurerm.EventhubNamespaceDisasterRecoveryConfig.EventhubNamespaceDisasterRecoveryConfig =
            Unchecked.defaultof<azurerm.EventhubNamespaceDisasterRecoveryConfig.EventhubNamespaceDisasterRecoveryConfig>
