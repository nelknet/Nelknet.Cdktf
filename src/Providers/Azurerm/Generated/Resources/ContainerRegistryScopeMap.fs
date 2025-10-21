namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ContainerRegistryScopeMap.ContainerRegistryScopeMapConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_scope_map">azurerm_container_registry_scope_map</a>.
    /// </summary>
    type ContainerRegistryScopeMapBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerRegistryScopeMapState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryScopeMapState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ContainerRegistryScopeMapState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryScopeMapState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_scope_map#actions-1">ContainerRegistryScopeMap#actions</a>.
        /// </summary>
        [<CustomOperation "actions">]
        member _.Actions(state: ContainerRegistryScopeMapState<Missing, 'ContainerRegistryName, 'Name, 'ResourceGroupName>, value: seq<string>) : ContainerRegistryScopeMapState<Present, 'ContainerRegistryName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Actions <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ContainerRegistryScopeMapState<Present, 'ContainerRegistryName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_scope_map#container_registry_name-1">ContainerRegistryScopeMap#container_registry_name</a>.
        /// </summary>
        [<CustomOperation "container_registry_name">]
        member _.ContainerRegistryName(state: ContainerRegistryScopeMapState<'Actions, Missing, 'Name, 'ResourceGroupName>, value: string) : ContainerRegistryScopeMapState<'Actions, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContainerRegistryName <- value)
            ({ assignments = state.assignments } : ContainerRegistryScopeMapState<'Actions, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_scope_map#name-1">ContainerRegistryScopeMap#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, Missing, 'ResourceGroupName>, value: string) : ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_scope_map#resource_group_name-1">ContainerRegistryScopeMap#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, 'Name, Missing>, value: string) : ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_scope_map#description-1">ContainerRegistryScopeMap#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, 'Name, 'ResourceGroupName>, value: string) : ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_scope_map#id-1">ContainerRegistryScopeMap#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, 'Name, 'ResourceGroupName>, value: string) : ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_scope_map#timeouts-1">ContainerRegistryScopeMap#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, 'Name, 'ResourceGroupName>, value: azurerm.ContainerRegistryScopeMap.ContainerRegistryScopeMapTimeouts) : ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerRegistryScopeMapState<'Actions, 'ContainerRegistryName, 'Name, 'ResourceGroupName>

        member _.Run(state: ContainerRegistryScopeMapState<Present, Present, Present, Present>) : azurerm.ContainerRegistryScopeMap.ContainerRegistryScopeMap =
            let config = azurerm.ContainerRegistryScopeMap.ContainerRegistryScopeMapConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerRegistryScopeMap.ContainerRegistryScopeMap(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerRegistryScopeMap: missing required arguments. Must call: actions, container_registry_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ContainerRegistryScopeMapState<_, _, _, _>) : azurerm.ContainerRegistryScopeMap.ContainerRegistryScopeMap =
            Unchecked.defaultof<azurerm.ContainerRegistryScopeMap.ContainerRegistryScopeMap>
