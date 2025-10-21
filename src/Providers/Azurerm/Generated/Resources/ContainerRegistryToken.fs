namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, 'ScopeMapId> = { assignments: ResizeArray<azurerm.ContainerRegistryToken.ContainerRegistryTokenConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token">azurerm_container_registry_token</a>.
    /// </summary>
    type ContainerRegistryTokenBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerRegistryTokenState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryTokenState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ContainerRegistryTokenState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerRegistryTokenState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token#container_registry_name-1">ContainerRegistryToken#container_registry_name</a>.
        /// </summary>
        [<CustomOperation "container_registry_name">]
        member _.ContainerRegistryName(state: ContainerRegistryTokenState<Missing, 'Name, 'ResourceGroupName, 'ScopeMapId>, value: string) : ContainerRegistryTokenState<Present, 'Name, 'ResourceGroupName, 'ScopeMapId> =
            state.assignments.Add(fun config -> config.ContainerRegistryName <- value)
            ({ assignments = state.assignments } : ContainerRegistryTokenState<Present, 'Name, 'ResourceGroupName, 'ScopeMapId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token#name-1">ContainerRegistryToken#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerRegistryTokenState<'ContainerRegistryName, Missing, 'ResourceGroupName, 'ScopeMapId>, value: string) : ContainerRegistryTokenState<'ContainerRegistryName, Present, 'ResourceGroupName, 'ScopeMapId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerRegistryTokenState<'ContainerRegistryName, Present, 'ResourceGroupName, 'ScopeMapId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token#resource_group_name-1">ContainerRegistryToken#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ContainerRegistryTokenState<'ContainerRegistryName, 'Name, Missing, 'ScopeMapId>, value: string) : ContainerRegistryTokenState<'ContainerRegistryName, 'Name, Present, 'ScopeMapId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ContainerRegistryTokenState<'ContainerRegistryName, 'Name, Present, 'ScopeMapId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token#scope_map_id-1">ContainerRegistryToken#scope_map_id</a>.
        /// </summary>
        [<CustomOperation "scope_map_id">]
        member _.ScopeMapId(state: ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, Missing>, value: string) : ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ScopeMapId <- value)
            ({ assignments = state.assignments } : ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token#enabled-1">ContainerRegistryToken#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, 'ScopeMapId>, value: bool) : ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, 'ScopeMapId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, 'ScopeMapId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token#enabled-1">ContainerRegistryToken#enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, 'ScopeMapId>, value: HashiCorp.Cdktf.IResolvable) : ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, 'ScopeMapId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, 'ScopeMapId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token#id-1">ContainerRegistryToken#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, 'ScopeMapId>, value: string) : ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, 'ScopeMapId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, 'ScopeMapId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_registry_token#timeouts-1">ContainerRegistryToken#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, 'ScopeMapId>, value: azurerm.ContainerRegistryToken.ContainerRegistryTokenTimeouts) : ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, 'ScopeMapId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName, 'ScopeMapId>

        member _.Run(state: ContainerRegistryTokenState<Present, Present, Present, Present>) : azurerm.ContainerRegistryToken.ContainerRegistryToken =
            let config = azurerm.ContainerRegistryToken.ContainerRegistryTokenConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerRegistryToken.ContainerRegistryToken(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerRegistryToken: missing required arguments. Must call: container_registry_name, name, resource_group_name, scope_map_id.", 9999, IsError = true)>]
        member _.Run(_: ContainerRegistryTokenState<_, _, _, _>) : azurerm.ContainerRegistryToken.ContainerRegistryToken =
            Unchecked.defaultof<azurerm.ContainerRegistryToken.ContainerRegistryToken>
