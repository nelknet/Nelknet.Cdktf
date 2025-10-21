namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.IothubEndpointEventhub.IothubEndpointEventhubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_eventhub">azurerm_iothub_endpoint_eventhub</a>.
    /// </summary>
    type IothubEndpointEventhubBuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubEndpointEventhubState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubEndpointEventhubState<Missing, Missing, Missing>)

        member _.Zero(()) : IothubEndpointEventhubState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubEndpointEventhubState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_eventhub#iothub_id-1">IothubEndpointEventhub#iothub_id</a>.
        /// </summary>
        [<CustomOperation "iothub_id">]
        member _.IothubId(state: IothubEndpointEventhubState<Missing, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointEventhubState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IothubId <- value)
            ({ assignments = state.assignments } : IothubEndpointEventhubState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_eventhub#name-1">IothubEndpointEventhub#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubEndpointEventhubState<'IothubId, Missing, 'ResourceGroupName>, value: string) : IothubEndpointEventhubState<'IothubId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubEndpointEventhubState<'IothubId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_eventhub#resource_group_name-1">IothubEndpointEventhub#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubEndpointEventhubState<'IothubId, 'Name, Missing>, value: string) : IothubEndpointEventhubState<'IothubId, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubEndpointEventhubState<'IothubId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_eventhub#authentication_type-1">IothubEndpointEventhub#authentication_type</a>.
        /// </summary>
        [<CustomOperation "authentication_type">]
        member _.AuthenticationType(state: IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AuthenticationType <- value)
            state : IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_eventhub#connection_string-1">IothubEndpointEventhub#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_eventhub#endpoint_uri-1">IothubEndpointEventhub#endpoint_uri</a>.
        /// </summary>
        [<CustomOperation "endpoint_uri">]
        member _.EndpointUri(state: IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EndpointUri <- value)
            state : IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_eventhub#entity_path-1">IothubEndpointEventhub#entity_path</a>.
        /// </summary>
        [<CustomOperation "entity_path">]
        member _.EntityPath(state: IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EntityPath <- value)
            state : IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_eventhub#id-1">IothubEndpointEventhub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_eventhub#identity_id-1">IothubEndpointEventhub#identity_id</a>.
        /// </summary>
        [<CustomOperation "identity_id">]
        member _.IdentityId(state: IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IdentityId <- value)
            state : IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_eventhub#timeouts-1">IothubEndpointEventhub#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName>, value: azurerm.IothubEndpointEventhub.IothubEndpointEventhubTimeouts) : IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubEndpointEventhubState<'IothubId, 'Name, 'ResourceGroupName>

        member _.Run(state: IothubEndpointEventhubState<Present, Present, Present>) : azurerm.IothubEndpointEventhub.IothubEndpointEventhub =
            let config = azurerm.IothubEndpointEventhub.IothubEndpointEventhubConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubEndpointEventhub.IothubEndpointEventhub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubEndpointEventhub: missing required arguments. Must call: iothub_id, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: IothubEndpointEventhubState<_, _, _>) : azurerm.IothubEndpointEventhub.IothubEndpointEventhub =
            Unchecked.defaultof<azurerm.IothubEndpointEventhub.IothubEndpointEventhub>
