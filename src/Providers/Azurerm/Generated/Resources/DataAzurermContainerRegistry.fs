namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermContainerRegistryState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermContainerRegistry.DataAzurermContainerRegistryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry">azurerm_container_registry</a>.
    /// </summary>
    type DataAzurermContainerRegistryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermContainerRegistryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerRegistryState<Missing, Missing>)

        member _.Zero(()) : DataAzurermContainerRegistryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerRegistryState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry#name-1">DataAzurermContainerRegistry#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermContainerRegistryState<Missing, 'ResourceGroupName>, value: string) : DataAzurermContainerRegistryState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermContainerRegistryState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry#resource_group_name-1">DataAzurermContainerRegistry#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermContainerRegistryState<'Name, Missing>, value: string) : DataAzurermContainerRegistryState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermContainerRegistryState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry#id-1">DataAzurermContainerRegistry#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermContainerRegistryState<'Name, 'ResourceGroupName>, value: string) : DataAzurermContainerRegistryState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermContainerRegistryState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry#timeouts-1">DataAzurermContainerRegistry#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermContainerRegistryState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermContainerRegistry.DataAzurermContainerRegistryTimeouts) : DataAzurermContainerRegistryState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermContainerRegistryState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermContainerRegistryState<Present, Present>) : azurerm.DataAzurermContainerRegistry.DataAzurermContainerRegistry =
            let config = azurerm.DataAzurermContainerRegistry.DataAzurermContainerRegistryConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermContainerRegistry.DataAzurermContainerRegistry(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermContainerRegistry: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermContainerRegistryState<_, _>) : azurerm.DataAzurermContainerRegistry.DataAzurermContainerRegistry =
            Unchecked.defaultof<azurerm.DataAzurermContainerRegistry.DataAzurermContainerRegistry>
