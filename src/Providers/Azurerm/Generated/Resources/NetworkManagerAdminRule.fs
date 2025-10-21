namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol> = { assignments: ResizeArray<azurerm.NetworkManagerAdminRule.NetworkManagerAdminRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule">azurerm_network_manager_admin_rule</a>.
    /// </summary>
    type NetworkManagerAdminRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : NetworkManagerAdminRuleState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerAdminRuleState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NetworkManagerAdminRuleState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NetworkManagerAdminRuleState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#action-1">NetworkManagerAdminRule#action</a>.
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: NetworkManagerAdminRuleState<Missing, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>, value: string) : NetworkManagerAdminRuleState<Present, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : NetworkManagerAdminRuleState<Present, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#admin_rule_collection_id-1">NetworkManagerAdminRule#admin_rule_collection_id</a>.
        /// </summary>
        [<CustomOperation "admin_rule_collection_id">]
        member _.AdminRuleCollectionId(state: NetworkManagerAdminRuleState<'Action, Missing, 'Direction, 'Name, 'Priority, 'Protocol>, value: string) : NetworkManagerAdminRuleState<'Action, Present, 'Direction, 'Name, 'Priority, 'Protocol> =
            state.assignments.Add(fun config -> config.AdminRuleCollectionId <- value)
            ({ assignments = state.assignments } : NetworkManagerAdminRuleState<'Action, Present, 'Direction, 'Name, 'Priority, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#direction-1">NetworkManagerAdminRule#direction</a>.
        /// </summary>
        [<CustomOperation "direction">]
        member _.Direction(state: NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, Missing, 'Name, 'Priority, 'Protocol>, value: string) : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, Present, 'Name, 'Priority, 'Protocol> =
            state.assignments.Add(fun config -> config.Direction <- value)
            ({ assignments = state.assignments } : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, Present, 'Name, 'Priority, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#name-1">NetworkManagerAdminRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, Missing, 'Priority, 'Protocol>, value: string) : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, Present, 'Priority, 'Protocol> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, Present, 'Priority, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#priority-1">NetworkManagerAdminRule#priority</a>.
        /// </summary>
        [<CustomOperation "priority">]
        member _.Priority(state: NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, Missing, 'Protocol>, value: double) : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, Present, 'Protocol> =
            state.assignments.Add(fun config -> config.Priority <- value)
            ({ assignments = state.assignments } : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, Present, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#protocol-1">NetworkManagerAdminRule#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, Missing>, value: string) : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, Present> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#description-1">NetworkManagerAdminRule#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>, value: string) : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>

        /// <summary>
        /// destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#destination-1">NetworkManagerAdminRule#destination</a> Accepts: azurerm.IResolvable | azurerm.NetworkManagerAdminRule.NetworkManagerAdminRuleDestination[]
        /// </summary>
        [<CustomOperation "destination">]
        member _.Destination(state: NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>, value: HashiCorp.Cdktf.IResolvable) : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol> =
            state.assignments.Add(fun config -> config.Destination <- value)
            state : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#destination_port_ranges-1">NetworkManagerAdminRule#destination_port_ranges</a>.
        /// </summary>
        [<CustomOperation "destination_port_ranges">]
        member _.DestinationPortRanges(state: NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>, value: seq<string>) : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol> =
            state.assignments.Add(fun config -> config.DestinationPortRanges <- (value |> Seq.toArray))
            state : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#id-1">NetworkManagerAdminRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>, value: string) : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>

        /// <summary>
        /// source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#source-1">NetworkManagerAdminRule#source</a> Accepts: azurerm.IResolvable | azurerm.NetworkManagerAdminRule.NetworkManagerAdminRuleSource[]
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>, value: HashiCorp.Cdktf.IResolvable) : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol> =
            state.assignments.Add(fun config -> config.Source <- value)
            state : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#source_port_ranges-1">NetworkManagerAdminRule#source_port_ranges</a>.
        /// </summary>
        [<CustomOperation "source_port_ranges">]
        member _.SourcePortRanges(state: NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>, value: seq<string>) : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol> =
            state.assignments.Add(fun config -> config.SourcePortRanges <- (value |> Seq.toArray))
            state : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/network_manager_admin_rule#timeouts-1">NetworkManagerAdminRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>, value: azurerm.NetworkManagerAdminRule.NetworkManagerAdminRuleTimeouts) : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NetworkManagerAdminRuleState<'Action, 'AdminRuleCollectionId, 'Direction, 'Name, 'Priority, 'Protocol>

        member _.Run(state: NetworkManagerAdminRuleState<Present, Present, Present, Present, Present, Present>) : azurerm.NetworkManagerAdminRule.NetworkManagerAdminRule =
            let config = azurerm.NetworkManagerAdminRule.NetworkManagerAdminRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.NetworkManagerAdminRule.NetworkManagerAdminRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.networkManagerAdminRule: missing required arguments. Must call: action, admin_rule_collection_id, direction, name, priority, protocol.", 9999, IsError = true)>]
        member _.Run(_: NetworkManagerAdminRuleState<_, _, _, _, _, _>) : azurerm.NetworkManagerAdminRule.NetworkManagerAdminRule =
            Unchecked.defaultof<azurerm.NetworkManagerAdminRule.NetworkManagerAdminRule>
