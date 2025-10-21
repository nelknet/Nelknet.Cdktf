namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name> = { assignments: ResizeArray<azurerm.DataAzurermContainerRegistryCacheRule.DataAzurermContainerRegistryCacheRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_cache_rule">azurerm_container_registry_cache_rule</a>.
    /// </summary>
    type DataAzurermContainerRegistryCacheRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermContainerRegistryCacheRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerRegistryCacheRuleState<Missing, Missing>)

        member _.Zero(()) : DataAzurermContainerRegistryCacheRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermContainerRegistryCacheRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_cache_rule#container_registry_id-1">DataAzurermContainerRegistryCacheRule#container_registry_id</a>.
        /// </summary>
        [<CustomOperation "container_registry_id">]
        member _.ContainerRegistryId(state: DataAzurermContainerRegistryCacheRuleState<Missing, 'Name>, value: string) : DataAzurermContainerRegistryCacheRuleState<Present, 'Name> =
            state.assignments.Add(fun config -> config.ContainerRegistryId <- value)
            ({ assignments = state.assignments } : DataAzurermContainerRegistryCacheRuleState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_cache_rule#name-1">DataAzurermContainerRegistryCacheRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermContainerRegistryCacheRuleState<'ContainerRegistryId, Missing>, value: string) : DataAzurermContainerRegistryCacheRuleState<'ContainerRegistryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermContainerRegistryCacheRuleState<'ContainerRegistryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_cache_rule#id-1">DataAzurermContainerRegistryCacheRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name>, value: string) : DataAzurermContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/container_registry_cache_rule#timeouts-1">DataAzurermContainerRegistryCacheRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name>, value: azurerm.DataAzurermContainerRegistryCacheRule.DataAzurermContainerRegistryCacheRuleTimeouts) : DataAzurermContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermContainerRegistryCacheRuleState<'ContainerRegistryId, 'Name>

        member _.Run(state: DataAzurermContainerRegistryCacheRuleState<Present, Present>) : azurerm.DataAzurermContainerRegistryCacheRule.DataAzurermContainerRegistryCacheRule =
            let config = azurerm.DataAzurermContainerRegistryCacheRule.DataAzurermContainerRegistryCacheRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermContainerRegistryCacheRule.DataAzurermContainerRegistryCacheRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermContainerRegistryCacheRule: missing required arguments. Must call: container_registry_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermContainerRegistryCacheRuleState<_, _>) : azurerm.DataAzurermContainerRegistryCacheRule.DataAzurermContainerRegistryCacheRule =
            Unchecked.defaultof<azurerm.DataAzurermContainerRegistryCacheRule.DataAzurermContainerRegistryCacheRule>
