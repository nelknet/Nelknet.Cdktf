namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkManagerAdminRuleCollectionState<'Name, 'NetworkGroupIds, 'SecurityAdminConfigurationId> = { assignments: ResizeArray<azurerm.NetworkManagerAdminRuleCollection.NetworkManagerAdminRuleCollectionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule_collection">azurerm_network_manager_admin_rule_collection</a>.
    /// </summary>
    type NetworkManagerAdminRuleCollectionBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkManagerAdminRuleCollectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerAdminRuleCollectionState<Missing, Missing, Missing>)

        member _.Zero(()) : NetworkManagerAdminRuleCollectionState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerAdminRuleCollectionState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule_collection#name-1">NetworkManagerAdminRuleCollection#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkManagerAdminRuleCollectionState<Missing, 'NetworkGroupIds, 'SecurityAdminConfigurationId>, value: string) : NetworkManagerAdminRuleCollectionState<Present, 'NetworkGroupIds, 'SecurityAdminConfigurationId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkManagerAdminRuleCollectionState<Present, 'NetworkGroupIds, 'SecurityAdminConfigurationId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule_collection#network_group_ids-1">NetworkManagerAdminRuleCollection#network_group_ids</a>.
        /// </summary>
        [<CustomOperation "network_group_ids">]
        member _.NetworkGroupIds(state: NetworkManagerAdminRuleCollectionState<'Name, Missing, 'SecurityAdminConfigurationId>, value: seq<string>) : NetworkManagerAdminRuleCollectionState<'Name, Present, 'SecurityAdminConfigurationId> =
            state.assignments.Add(fun config -> config.NetworkGroupIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : NetworkManagerAdminRuleCollectionState<'Name, Present, 'SecurityAdminConfigurationId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule_collection#security_admin_configuration_id-1">NetworkManagerAdminRuleCollection#security_admin_configuration_id</a>.
        /// </summary>
        [<CustomOperation "security_admin_configuration_id">]
        member _.SecurityAdminConfigurationId(state: NetworkManagerAdminRuleCollectionState<'Name, 'NetworkGroupIds, Missing>, value: string) : NetworkManagerAdminRuleCollectionState<'Name, 'NetworkGroupIds, Present> =
            state.assignments.Add(fun config -> config.SecurityAdminConfigurationId <- value)
            ({ assignments = state.assignments } : NetworkManagerAdminRuleCollectionState<'Name, 'NetworkGroupIds, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule_collection#description-1">NetworkManagerAdminRuleCollection#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkManagerAdminRuleCollectionState<'Name, 'NetworkGroupIds, 'SecurityAdminConfigurationId>, value: string) : NetworkManagerAdminRuleCollectionState<'Name, 'NetworkGroupIds, 'SecurityAdminConfigurationId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkManagerAdminRuleCollectionState<'Name, 'NetworkGroupIds, 'SecurityAdminConfigurationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule_collection#id-1">NetworkManagerAdminRuleCollection#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkManagerAdminRuleCollectionState<'Name, 'NetworkGroupIds, 'SecurityAdminConfigurationId>, value: string) : NetworkManagerAdminRuleCollectionState<'Name, 'NetworkGroupIds, 'SecurityAdminConfigurationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkManagerAdminRuleCollectionState<'Name, 'NetworkGroupIds, 'SecurityAdminConfigurationId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule_collection#timeouts-1">NetworkManagerAdminRuleCollection#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkManagerAdminRuleCollectionState<'Name, 'NetworkGroupIds, 'SecurityAdminConfigurationId>, value: azurerm.NetworkManagerAdminRuleCollection.NetworkManagerAdminRuleCollectionTimeouts) : NetworkManagerAdminRuleCollectionState<'Name, 'NetworkGroupIds, 'SecurityAdminConfigurationId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkManagerAdminRuleCollectionState<'Name, 'NetworkGroupIds, 'SecurityAdminConfigurationId>

        member _.Run(state: NetworkManagerAdminRuleCollectionState<Present, Present, Present>) : azurerm.NetworkManagerAdminRuleCollection.NetworkManagerAdminRuleCollection =
            let config = azurerm.NetworkManagerAdminRuleCollection.NetworkManagerAdminRuleCollectionConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkManagerAdminRuleCollection.NetworkManagerAdminRuleCollection(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkManagerAdminRuleCollection: missing required arguments. Must call: name, network_group_ids, security_admin_configuration_id.", 9999, IsError = true)>]
        member _.Run(_: NetworkManagerAdminRuleCollectionState<_, _, _>) : azurerm.NetworkManagerAdminRuleCollection.NetworkManagerAdminRuleCollection =
            Unchecked.defaultof<azurerm.NetworkManagerAdminRuleCollection.NetworkManagerAdminRuleCollection>
