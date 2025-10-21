namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.IothubEndpointServicebusQueue.IothubEndpointServicebusQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_queue">azurerm_iothub_endpoint_servicebus_queue</a>.
    /// </summary>
    type IothubEndpointServicebusQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubEndpointServicebusQueueState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubEndpointServicebusQueueState<Missing, Missing, Missing>)

        member _.Zero(()) : IothubEndpointServicebusQueueState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubEndpointServicebusQueueState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_queue#iothub_id-1">IothubEndpointServicebusQueue#iothub_id</a>.
        /// </summary>
        [<CustomOperation "iothub_id">]
        member _.IothubId(state: IothubEndpointServicebusQueueState<Missing, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointServicebusQueueState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IothubId <- value)
            ({ assignments = state.assignments } : IothubEndpointServicebusQueueState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_queue#name-1">IothubEndpointServicebusQueue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubEndpointServicebusQueueState<'IothubId, Missing, 'ResourceGroupName>, value: string) : IothubEndpointServicebusQueueState<'IothubId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubEndpointServicebusQueueState<'IothubId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_queue#resource_group_name-1">IothubEndpointServicebusQueue#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubEndpointServicebusQueueState<'IothubId, 'Name, Missing>, value: string) : IothubEndpointServicebusQueueState<'IothubId, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubEndpointServicebusQueueState<'IothubId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_queue#authentication_type-1">IothubEndpointServicebusQueue#authentication_type</a>.
        /// </summary>
        [<CustomOperation "authentication_type">]
        member _.AuthenticationType(state: IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AuthenticationType <- value)
            state : IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_queue#connection_string-1">IothubEndpointServicebusQueue#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_queue#endpoint_uri-1">IothubEndpointServicebusQueue#endpoint_uri</a>.
        /// </summary>
        [<CustomOperation "endpoint_uri">]
        member _.EndpointUri(state: IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EndpointUri <- value)
            state : IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_queue#entity_path-1">IothubEndpointServicebusQueue#entity_path</a>.
        /// </summary>
        [<CustomOperation "entity_path">]
        member _.EntityPath(state: IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EntityPath <- value)
            state : IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_queue#id-1">IothubEndpointServicebusQueue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_queue#identity_id-1">IothubEndpointServicebusQueue#identity_id</a>.
        /// </summary>
        [<CustomOperation "identity_id">]
        member _.IdentityId(state: IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IdentityId <- value)
            state : IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_queue#timeouts-1">IothubEndpointServicebusQueue#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName>, value: azurerm.IothubEndpointServicebusQueue.IothubEndpointServicebusQueueTimeouts) : IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubEndpointServicebusQueueState<'IothubId, 'Name, 'ResourceGroupName>

        member _.Run(state: IothubEndpointServicebusQueueState<Present, Present, Present>) : azurerm.IothubEndpointServicebusQueue.IothubEndpointServicebusQueue =
            let config = azurerm.IothubEndpointServicebusQueue.IothubEndpointServicebusQueueConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubEndpointServicebusQueue.IothubEndpointServicebusQueue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubEndpointServicebusQueue: missing required arguments. Must call: iothub_id, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: IothubEndpointServicebusQueueState<_, _, _>) : azurerm.IothubEndpointServicebusQueue.IothubEndpointServicebusQueue =
            Unchecked.defaultof<azurerm.IothubEndpointServicebusQueue.IothubEndpointServicebusQueue>
