namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermEventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermEventhubConsumerGroup.DataAzurermEventhubConsumerGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_consumer_group">azurerm_eventhub_consumer_group</a>.
    /// </summary>
    type DataAzurermEventhubConsumerGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermEventhubConsumerGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventhubConsumerGroupState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermEventhubConsumerGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventhubConsumerGroupState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_consumer_group#eventhub_name-1">DataAzurermEventhubConsumerGroup#eventhub_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_name">]
        member _.EventhubName(state: DataAzurermEventhubConsumerGroupState<Missing, 'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : DataAzurermEventhubConsumerGroupState<Present, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EventhubName <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubConsumerGroupState<Present, 'Name, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_consumer_group#name-1">DataAzurermEventhubConsumerGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermEventhubConsumerGroupState<'EventhubName, Missing, 'NamespaceName, 'ResourceGroupName>, value: string) : DataAzurermEventhubConsumerGroupState<'EventhubName, Present, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubConsumerGroupState<'EventhubName, Present, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_consumer_group#namespace_name-1">DataAzurermEventhubConsumerGroup#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: DataAzurermEventhubConsumerGroupState<'EventhubName, 'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermEventhubConsumerGroupState<'EventhubName, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubConsumerGroupState<'EventhubName, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_consumer_group#resource_group_name-1">DataAzurermEventhubConsumerGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermEventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, Missing>, value: string) : DataAzurermEventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_consumer_group#id-1">DataAzurermEventhubConsumerGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermEventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : DataAzurermEventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermEventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_consumer_group#timeouts-1">DataAzurermEventhubConsumerGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermEventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: azurerm.DataAzurermEventhubConsumerGroup.DataAzurermEventhubConsumerGroupTimeouts) : DataAzurermEventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermEventhubConsumerGroupState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        member _.Run(state: DataAzurermEventhubConsumerGroupState<Present, Present, Present, Present>) : azurerm.DataAzurermEventhubConsumerGroup.DataAzurermEventhubConsumerGroup =
            let config = azurerm.DataAzurermEventhubConsumerGroup.DataAzurermEventhubConsumerGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermEventhubConsumerGroup.DataAzurermEventhubConsumerGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermEventhubConsumerGroup: missing required arguments. Must call: eventhub_name, name, namespace_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermEventhubConsumerGroupState<_, _, _, _>) : azurerm.DataAzurermEventhubConsumerGroup.DataAzurermEventhubConsumerGroup =
            Unchecked.defaultof<azurerm.DataAzurermEventhubConsumerGroup.DataAzurermEventhubConsumerGroup>
