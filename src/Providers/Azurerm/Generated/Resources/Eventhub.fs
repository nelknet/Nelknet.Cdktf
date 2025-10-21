namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.Eventhub.EventhubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub">azurerm_eventhub</a>.
    /// </summary>
    type EventhubBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventhubState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : EventhubState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#message_retention-1">Eventhub#message_retention</a>.
        /// </summary>
        [<CustomOperation "message_retention">]
        member _.MessageRetention(state: EventhubState<Missing, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName>, value: double) : EventhubState<Present, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MessageRetention <- value)
            ({ assignments = state.assignments } : EventhubState<Present, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#name-1">Eventhub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EventhubState<'MessageRetention, Missing, 'NamespaceName, 'PartitionCount, 'ResourceGroupName>, value: string) : EventhubState<'MessageRetention, Present, 'NamespaceName, 'PartitionCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EventhubState<'MessageRetention, Present, 'NamespaceName, 'PartitionCount, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#namespace_name-1">Eventhub#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: EventhubState<'MessageRetention, 'Name, Missing, 'PartitionCount, 'ResourceGroupName>, value: string) : EventhubState<'MessageRetention, 'Name, Present, 'PartitionCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : EventhubState<'MessageRetention, 'Name, Present, 'PartitionCount, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#partition_count-1">Eventhub#partition_count</a>.
        /// </summary>
        [<CustomOperation "partition_count">]
        member _.PartitionCount(state: EventhubState<'MessageRetention, 'Name, 'NamespaceName, Missing, 'ResourceGroupName>, value: double) : EventhubState<'MessageRetention, 'Name, 'NamespaceName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PartitionCount <- value)
            ({ assignments = state.assignments } : EventhubState<'MessageRetention, 'Name, 'NamespaceName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#resource_group_name-1">Eventhub#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, Missing>, value: string) : EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, Present>)

        /// <summary>
        /// capture_description block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#capture_description-1">Eventhub#capture_description</a>
        /// </summary>
        [<CustomOperation "capture_description">]
        member _.CaptureDescription(state: EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName>, value: azurerm.Eventhub.EventhubCaptureDescription) : EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CaptureDescription <- value)
            state : EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#id-1">Eventhub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName>, value: string) : EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#status-1">Eventhub#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName>, value: string) : EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub#timeouts-1">Eventhub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName>, value: azurerm.Eventhub.EventhubTimeouts) : EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventhubState<'MessageRetention, 'Name, 'NamespaceName, 'PartitionCount, 'ResourceGroupName>

        member _.Run(state: EventhubState<Present, Present, Present, Present, Present>) : azurerm.Eventhub.Eventhub =
            let config = azurerm.Eventhub.EventhubConfig()
            for setter in state.assignments do
                setter config
            azurerm.Eventhub.Eventhub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventhub: missing required arguments. Must call: message_retention, name, namespace_name, partition_count, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: EventhubState<_, _, _, _, _>) : azurerm.Eventhub.Eventhub =
            Unchecked.defaultof<azurerm.Eventhub.Eventhub>
