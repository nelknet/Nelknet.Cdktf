namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.IothubEndpointStorageContainer.IothubEndpointStorageContainerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container">azurerm_iothub_endpoint_storage_container</a>.
    /// </summary>
    type IothubEndpointStorageContainerBuilder(logicalId: string) =
        member _.Yield(_: unit) : IothubEndpointStorageContainerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubEndpointStorageContainerState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : IothubEndpointStorageContainerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : IothubEndpointStorageContainerState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container#container_name-1">IothubEndpointStorageContainer#container_name</a>.
        /// </summary>
        [<CustomOperation "container_name">]
        member _.ContainerName(state: IothubEndpointStorageContainerState<Missing, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointStorageContainerState<Present, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContainerName <- value)
            ({ assignments = state.assignments } : IothubEndpointStorageContainerState<Present, 'IothubId, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container#iothub_id-1">IothubEndpointStorageContainer#iothub_id</a>.
        /// </summary>
        [<CustomOperation "iothub_id">]
        member _.IothubId(state: IothubEndpointStorageContainerState<'ContainerName, Missing, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointStorageContainerState<'ContainerName, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IothubId <- value)
            ({ assignments = state.assignments } : IothubEndpointStorageContainerState<'ContainerName, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container#name-1">IothubEndpointStorageContainer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IothubEndpointStorageContainerState<'ContainerName, 'IothubId, Missing, 'ResourceGroupName>, value: string) : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container#resource_group_name-1">IothubEndpointStorageContainer#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, Missing>, value: string) : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container#authentication_type-1">IothubEndpointStorageContainer#authentication_type</a>.
        /// </summary>
        [<CustomOperation "authentication_type">]
        member _.AuthenticationType(state: IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AuthenticationType <- value)
            state : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container#batch_frequency_in_seconds-1">IothubEndpointStorageContainer#batch_frequency_in_seconds</a>.
        /// </summary>
        [<CustomOperation "batch_frequency_in_seconds">]
        member _.BatchFrequencyInSeconds(state: IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>, value: double) : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BatchFrequencyInSeconds <- value)
            state : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container#connection_string-1">IothubEndpointStorageContainer#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container#encoding-1">IothubEndpointStorageContainer#encoding</a>.
        /// </summary>
        [<CustomOperation "encoding">]
        member _.Encoding(state: IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Encoding <- value)
            state : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container#endpoint_uri-1">IothubEndpointStorageContainer#endpoint_uri</a>.
        /// </summary>
        [<CustomOperation "endpoint_uri">]
        member _.EndpointUri(state: IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EndpointUri <- value)
            state : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container#file_name_format-1">IothubEndpointStorageContainer#file_name_format</a>.
        /// </summary>
        [<CustomOperation "file_name_format">]
        member _.FileNameFormat(state: IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FileNameFormat <- value)
            state : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container#id-1">IothubEndpointStorageContainer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container#identity_id-1">IothubEndpointStorageContainer#identity_id</a>.
        /// </summary>
        [<CustomOperation "identity_id">]
        member _.IdentityId(state: IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>, value: string) : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IdentityId <- value)
            state : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container#max_chunk_size_in_bytes-1">IothubEndpointStorageContainer#max_chunk_size_in_bytes</a>.
        /// </summary>
        [<CustomOperation "max_chunk_size_in_bytes">]
        member _.MaxChunkSizeInBytes(state: IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>, value: double) : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MaxChunkSizeInBytes <- value)
            state : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/iothub_endpoint_storage_container#timeouts-1">IothubEndpointStorageContainer#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>, value: azurerm.IothubEndpointStorageContainer.IothubEndpointStorageContainerTimeouts) : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IothubEndpointStorageContainerState<'ContainerName, 'IothubId, 'Name, 'ResourceGroupName>

        member _.Run(state: IothubEndpointStorageContainerState<Present, Present, Present, Present>) : azurerm.IothubEndpointStorageContainer.IothubEndpointStorageContainer =
            let config = azurerm.IothubEndpointStorageContainer.IothubEndpointStorageContainerConfig()
            for setter in state.assignments do
                setter config
            azurerm.IothubEndpointStorageContainer.IothubEndpointStorageContainer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.iothubEndpointStorageContainer: missing required arguments. Must call: container_name, iothub_id, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: IothubEndpointStorageContainerState<_, _, _, _>) : azurerm.IothubEndpointStorageContainer.IothubEndpointStorageContainer =
            Unchecked.defaultof<azurerm.IothubEndpointStorageContainer.IothubEndpointStorageContainer>
