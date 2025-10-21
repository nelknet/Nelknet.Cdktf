namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermContainerRegistryScopeMapState<'ContainerRegistryName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermContainerRegistryScopeMap.DataAzurermContainerRegistryScopeMapConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_scope_map">azurerm_container_registry_scope_map</a>.
    /// </summary>
    type DataAzurermContainerRegistryScopeMapBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermContainerRegistryScopeMapState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerRegistryScopeMapState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermContainerRegistryScopeMapState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerRegistryScopeMapState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_scope_map#container_registry_name-1">DataAzurermContainerRegistryScopeMap#container_registry_name</a>.
        /// </summary>
        [<CustomOperation "container_registry_name">]
        member _.ContainerRegistryName(state: DataAzurermContainerRegistryScopeMapState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermContainerRegistryScopeMapState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContainerRegistryName <- value)
            ({ assignments = state.assignments } : DataAzurermContainerRegistryScopeMapState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_scope_map#name-1">DataAzurermContainerRegistryScopeMap#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermContainerRegistryScopeMapState<'ContainerRegistryName, Missing, 'ResourceGroupName>, value: string) : DataAzurermContainerRegistryScopeMapState<'ContainerRegistryName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermContainerRegistryScopeMapState<'ContainerRegistryName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_scope_map#resource_group_name-1">DataAzurermContainerRegistryScopeMap#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermContainerRegistryScopeMapState<'ContainerRegistryName, 'Name, Missing>, value: string) : DataAzurermContainerRegistryScopeMapState<'ContainerRegistryName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermContainerRegistryScopeMapState<'ContainerRegistryName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_scope_map#id-1">DataAzurermContainerRegistryScopeMap#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermContainerRegistryScopeMapState<'ContainerRegistryName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermContainerRegistryScopeMapState<'ContainerRegistryName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermContainerRegistryScopeMapState<'ContainerRegistryName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_scope_map#timeouts-1">DataAzurermContainerRegistryScopeMap#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermContainerRegistryScopeMapState<'ContainerRegistryName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermContainerRegistryScopeMap.DataAzurermContainerRegistryScopeMapTimeouts) : DataAzurermContainerRegistryScopeMapState<'ContainerRegistryName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermContainerRegistryScopeMapState<'ContainerRegistryName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermContainerRegistryScopeMapState<Present, Present, Present>) : azurerm.DataAzurermContainerRegistryScopeMap.DataAzurermContainerRegistryScopeMap =
            let config = azurerm.DataAzurermContainerRegistryScopeMap.DataAzurermContainerRegistryScopeMapConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermContainerRegistryScopeMap.DataAzurermContainerRegistryScopeMap(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermContainerRegistryScopeMap: missing required arguments. Must call: container_registry_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermContainerRegistryScopeMapState<_, _, _>) : azurerm.DataAzurermContainerRegistryScopeMap.DataAzurermContainerRegistryScopeMap =
            Unchecked.defaultof<azurerm.DataAzurermContainerRegistryScopeMap.DataAzurermContainerRegistryScopeMap>
