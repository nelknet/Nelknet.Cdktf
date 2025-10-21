namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermContainerRegistryToken.DataAzurermContainerRegistryTokenConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_token">azurerm_container_registry_token</a>.
    /// </summary>
    type DataAzurermContainerRegistryTokenBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermContainerRegistryTokenState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerRegistryTokenState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermContainerRegistryTokenState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerRegistryTokenState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_token#container_registry_name-1">DataAzurermContainerRegistryToken#container_registry_name</a>.
        /// </summary>
        [<CustomOperation "container_registry_name">]
        member _.ContainerRegistryName(state: DataAzurermContainerRegistryTokenState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermContainerRegistryTokenState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContainerRegistryName <- value)
            ({ assignments = state.assignments } : DataAzurermContainerRegistryTokenState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_token#name-1">DataAzurermContainerRegistryToken#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermContainerRegistryTokenState<'ContainerRegistryName, Missing, 'ResourceGroupName>, value: string) : DataAzurermContainerRegistryTokenState<'ContainerRegistryName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermContainerRegistryTokenState<'ContainerRegistryName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_token#resource_group_name-1">DataAzurermContainerRegistryToken#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermContainerRegistryTokenState<'ContainerRegistryName, 'Name, Missing>, value: string) : DataAzurermContainerRegistryTokenState<'ContainerRegistryName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermContainerRegistryTokenState<'ContainerRegistryName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_token#id-1">DataAzurermContainerRegistryToken#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_token#timeouts-1">DataAzurermContainerRegistryToken#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermContainerRegistryToken.DataAzurermContainerRegistryTokenTimeouts) : DataAzurermContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermContainerRegistryTokenState<'ContainerRegistryName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermContainerRegistryTokenState<Present, Present, Present>) : azurerm.DataAzurermContainerRegistryToken.DataAzurermContainerRegistryToken =
            let config = azurerm.DataAzurermContainerRegistryToken.DataAzurermContainerRegistryTokenConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermContainerRegistryToken.DataAzurermContainerRegistryToken(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermContainerRegistryToken: missing required arguments. Must call: container_registry_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermContainerRegistryTokenState<_, _, _>) : azurerm.DataAzurermContainerRegistryToken.DataAzurermContainerRegistryToken =
            Unchecked.defaultof<azurerm.DataAzurermContainerRegistryToken.DataAzurermContainerRegistryToken>
