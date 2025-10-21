namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.EventhubConsumerGroup.EventhubConsumerGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_consumer_group">azurerm_eventhub_consumer_group</a>.
    /// </summary>
    type EventhubConsumerGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventhubConsumerGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubConsumerGroupState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : EventhubConsumerGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubConsumerGroupState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_consumer_group#eventhub_name-1">EventhubConsumerGroup#eventhub_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_name">]
        member _.EventhubName(state: EventhubConsumerGroupState<Missing, 'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : EventhubConsumerGroupState<Present, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EventhubName <- value)
            ({ assignments = state.assignments } : EventhubConsumerGroupState<Present, 'Name, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_consumer_group#name-1">EventhubConsumerGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EventhubConsumerGroupState<'EventhubName, Missing, 'NamespaceName, 'ResourceGroupName>, value: string) : EventhubConsumerGroupState<'EventhubName, Present, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EventhubConsumerGroupState<'EventhubName, Present, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_consumer_group#namespace_name-1">EventhubConsumerGroup#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: EventhubConsumerGroupState<'EventhubName, 'Name, Missing, 'ResourceGroupName>, value: string) : EventhubConsumerGroupState<'EventhubName, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : EventhubConsumerGroupState<'EventhubName, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_consumer_group#resource_group_name-1">EventhubConsumerGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: EventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, Missing>, value: string) : EventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : EventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_consumer_group#id-1">EventhubConsumerGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : EventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_consumer_group#timeouts-1">EventhubConsumerGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: azurerm.EventhubConsumerGroup.EventhubConsumerGroupTimeouts) : EventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_consumer_group#user_metadata-1">EventhubConsumerGroup#user_metadata</a>.
        /// </summary>
        [<CustomOperation "user_metadata">]
        member _.UserMetadata(state: EventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : EventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.UserMetadata <- value)
            state : EventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        member _.Run(state: EventhubConsumerGroupState<Present, Present, Present, Present>) : azurerm.EventhubConsumerGroup.EventhubConsumerGroup =
            let config = azurerm.EventhubConsumerGroup.EventhubConsumerGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.EventhubConsumerGroup.EventhubConsumerGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventhubConsumerGroup: missing required arguments. Must call: eventhub_name, name, namespace_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: EventhubConsumerGroupState<_, _, _, _>) : azurerm.EventhubConsumerGroup.EventhubConsumerGroup =
            Unchecked.defaultof<azurerm.EventhubConsumerGroup.EventhubConsumerGroup>
