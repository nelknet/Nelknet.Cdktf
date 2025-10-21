namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.IothubEndpointServicebusTopic.IothubEndpointServicebusTopicConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_topic">azurerm_iothub_endpoint_servicebus_topic</a>.
    /// </summary>
    type IothubEndpointServicebusTopicBuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubEndpointServicebusTopicState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubEndpointServicebusTopicState<Missing, Missing, Missing>)

        member _.Zero(()) : IothubEndpointServicebusTopicState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubEndpointServicebusTopicState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_topic#iothub_id-1">IothubEndpointServicebusTopic#iothub_id</a>.
        /// </summary>
        [<CustomOperation "iothub_id">]
        member _.IothubId(state: IothubEndpointServicebusTopicState<Missing, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointServicebusTopicState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IothubId <- value)
            ({ assignments = state.assignments } : IothubEndpointServicebusTopicState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_topic#name-1">IothubEndpointServicebusTopic#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubEndpointServicebusTopicState<'IothubId, Missing, 'ResourceGroupName>, value: string) : IothubEndpointServicebusTopicState<'IothubId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubEndpointServicebusTopicState<'IothubId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_topic#resource_group_name-1">IothubEndpointServicebusTopic#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubEndpointServicebusTopicState<'IothubId, 'Name, Missing>, value: string) : IothubEndpointServicebusTopicState<'IothubId, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubEndpointServicebusTopicState<'IothubId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_topic#authentication_type-1">IothubEndpointServicebusTopic#authentication_type</a>.
        /// </summary>
        [<CustomOperation "authentication_type">]
        member _.AuthenticationType(state: IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AuthenticationType <- value)
            state : IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_topic#connection_string-1">IothubEndpointServicebusTopic#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_topic#endpoint_uri-1">IothubEndpointServicebusTopic#endpoint_uri</a>.
        /// </summary>
        [<CustomOperation "endpoint_uri">]
        member _.EndpointUri(state: IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EndpointUri <- value)
            state : IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_topic#entity_path-1">IothubEndpointServicebusTopic#entity_path</a>.
        /// </summary>
        [<CustomOperation "entity_path">]
        member _.EntityPath(state: IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EntityPath <- value)
            state : IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_topic#id-1">IothubEndpointServicebusTopic#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_topic#identity_id-1">IothubEndpointServicebusTopic#identity_id</a>.
        /// </summary>
        [<CustomOperation "identity_id">]
        member _.IdentityId(state: IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IdentityId <- value)
            state : IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_servicebus_topic#timeouts-1">IothubEndpointServicebusTopic#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName>, value: azurerm.IothubEndpointServicebusTopic.IothubEndpointServicebusTopicTimeouts) : IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubEndpointServicebusTopicState<'IothubId, 'Name, 'ResourceGroupName>

        member _.Run(state: IothubEndpointServicebusTopicState<Present, Present, Present>) : azurerm.IothubEndpointServicebusTopic.IothubEndpointServicebusTopic =
            let config = azurerm.IothubEndpointServicebusTopic.IothubEndpointServicebusTopicConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubEndpointServicebusTopic.IothubEndpointServicebusTopic(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubEndpointServicebusTopic: missing required arguments. Must call: iothub_id, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: IothubEndpointServicebusTopicState<_, _, _>) : azurerm.IothubEndpointServicebusTopic.IothubEndpointServicebusTopic =
            Unchecked.defaultof<azurerm.IothubEndpointServicebusTopic.IothubEndpointServicebusTopic>
