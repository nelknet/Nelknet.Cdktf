namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubConsumerGroupState<'EventhubEndpointName, 'IothubName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.IothubConsumerGroup.IothubConsumerGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_consumer_group">azurerm_iothub_consumer_group</a>.
    /// </summary>
    type IothubConsumerGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubConsumerGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubConsumerGroupState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : IothubConsumerGroupState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubConsumerGroupState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_consumer_group#eventhub_endpoint_name-1">IothubConsumerGroup#eventhub_endpoint_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_endpoint_name">]
        member _.EventhubEndpointName(state: IothubConsumerGroupState<Missing, 'IothubName, 'Name, 'ResourceGroupName>, value: string) : IothubConsumerGroupState<Present, 'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EventhubEndpointName <- value)
            ({ assignments = state.assignments } : IothubConsumerGroupState<Present, 'IothubName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_consumer_group#iothub_name-1">IothubConsumerGroup#iothub_name</a>.
        /// </summary>
        [<CustomOperation "iothub_name">]
        member _.IothubName(state: IothubConsumerGroupState<'EventhubEndpointName, Missing, 'Name, 'ResourceGroupName>, value: string) : IothubConsumerGroupState<'EventhubEndpointName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IothubName <- value)
            ({ assignments = state.assignments } : IothubConsumerGroupState<'EventhubEndpointName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_consumer_group#name-1">IothubConsumerGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubConsumerGroupState<'EventhubEndpointName, 'IothubName, Missing, 'ResourceGroupName>, value: string) : IothubConsumerGroupState<'EventhubEndpointName, 'IothubName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubConsumerGroupState<'EventhubEndpointName, 'IothubName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_consumer_group#resource_group_name-1">IothubConsumerGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubConsumerGroupState<'EventhubEndpointName, 'IothubName, 'Name, Missing>, value: string) : IothubConsumerGroupState<'EventhubEndpointName, 'IothubName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubConsumerGroupState<'EventhubEndpointName, 'IothubName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_consumer_group#id-1">IothubConsumerGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubConsumerGroupState<'EventhubEndpointName, 'IothubName, 'Name, 'ResourceGroupName>, value: string) : IothubConsumerGroupState<'EventhubEndpointName, 'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubConsumerGroupState<'EventhubEndpointName, 'IothubName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_consumer_group#timeouts-1">IothubConsumerGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubConsumerGroupState<'EventhubEndpointName, 'IothubName, 'Name, 'ResourceGroupName>, value: azurerm.IothubConsumerGroup.IothubConsumerGroupTimeouts) : IothubConsumerGroupState<'EventhubEndpointName, 'IothubName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubConsumerGroupState<'EventhubEndpointName, 'IothubName, 'Name, 'ResourceGroupName>

        member _.Run(state: IothubConsumerGroupState<Present, Present, Present, Present>) : azurerm.IothubConsumerGroup.IothubConsumerGroup =
            let config = azurerm.IothubConsumerGroup.IothubConsumerGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubConsumerGroup.IothubConsumerGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubConsumerGroup: missing required arguments. Must call: eventhub_endpoint_name, iothub_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: IothubConsumerGroupState<_, _, _, _>) : azurerm.IothubConsumerGroup.IothubConsumerGroup =
            Unchecked.defaultof<azurerm.IothubConsumerGroup.IothubConsumerGroup>
