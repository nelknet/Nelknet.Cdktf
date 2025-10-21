namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbPostgresqlFirewallRuleState<'ClusterId, 'EndIpAddress, 'Name, 'StartIpAddress> = { assignments: ResizeArray<azurerm.CosmosdbPostgresqlFirewallRule.CosmosdbPostgresqlFirewallRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_firewall_rule">azurerm_cosmosdb_postgresql_firewall_rule</a>.
    /// </summary>
    type CosmosdbPostgresqlFirewallRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbPostgresqlFirewallRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbPostgresqlFirewallRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbPostgresqlFirewallRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbPostgresqlFirewallRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_firewall_rule#cluster_id-1">CosmosdbPostgresqlFirewallRule#cluster_id</a>.
        /// </summary>
        [<CustomOperation "cluster_id">]
        member _.ClusterId(state: CosmosdbPostgresqlFirewallRuleState<Missing, 'EndIpAddress, 'Name, 'StartIpAddress>, value: string) : CosmosdbPostgresqlFirewallRuleState<Present, 'EndIpAddress, 'Name, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.ClusterId <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlFirewallRuleState<Present, 'EndIpAddress, 'Name, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_firewall_rule#end_ip_address-1">CosmosdbPostgresqlFirewallRule#end_ip_address</a>.
        /// </summary>
        [<CustomOperation "end_ip_address">]
        member _.EndIpAddress(state: CosmosdbPostgresqlFirewallRuleState<'ClusterId, Missing, 'Name, 'StartIpAddress>, value: string) : CosmosdbPostgresqlFirewallRuleState<'ClusterId, Present, 'Name, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.EndIpAddress <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlFirewallRuleState<'ClusterId, Present, 'Name, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_firewall_rule#name-1">CosmosdbPostgresqlFirewallRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbPostgresqlFirewallRuleState<'ClusterId, 'EndIpAddress, Missing, 'StartIpAddress>, value: string) : CosmosdbPostgresqlFirewallRuleState<'ClusterId, 'EndIpAddress, Present, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlFirewallRuleState<'ClusterId, 'EndIpAddress, Present, 'StartIpAddress>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_firewall_rule#start_ip_address-1">CosmosdbPostgresqlFirewallRule#start_ip_address</a>.
        /// </summary>
        [<CustomOperation "start_ip_address">]
        member _.StartIpAddress(state: CosmosdbPostgresqlFirewallRuleState<'ClusterId, 'EndIpAddress, 'Name, Missing>, value: string) : CosmosdbPostgresqlFirewallRuleState<'ClusterId, 'EndIpAddress, 'Name, Present> =
            state.assignments.Add(fun config -> config.StartIpAddress <- value)
            ({ assignments = state.assignments } : CosmosdbPostgresqlFirewallRuleState<'ClusterId, 'EndIpAddress, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_firewall_rule#id-1">CosmosdbPostgresqlFirewallRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbPostgresqlFirewallRuleState<'ClusterId, 'EndIpAddress, 'Name, 'StartIpAddress>, value: string) : CosmosdbPostgresqlFirewallRuleState<'ClusterId, 'EndIpAddress, 'Name, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbPostgresqlFirewallRuleState<'ClusterId, 'EndIpAddress, 'Name, 'StartIpAddress>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_postgresql_firewall_rule#timeouts-1">CosmosdbPostgresqlFirewallRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbPostgresqlFirewallRuleState<'ClusterId, 'EndIpAddress, 'Name, 'StartIpAddress>, value: azurerm.CosmosdbPostgresqlFirewallRule.CosmosdbPostgresqlFirewallRuleTimeouts) : CosmosdbPostgresqlFirewallRuleState<'ClusterId, 'EndIpAddress, 'Name, 'StartIpAddress> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbPostgresqlFirewallRuleState<'ClusterId, 'EndIpAddress, 'Name, 'StartIpAddress>

        member _.Run(state: CosmosdbPostgresqlFirewallRuleState<Present, Present, Present, Present>) : azurerm.CosmosdbPostgresqlFirewallRule.CosmosdbPostgresqlFirewallRule =
            let config = azurerm.CosmosdbPostgresqlFirewallRule.CosmosdbPostgresqlFirewallRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbPostgresqlFirewallRule.CosmosdbPostgresqlFirewallRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbPostgresqlFirewallRule: missing required arguments. Must call: cluster_id, end_ip_address, name, start_ip_address.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbPostgresqlFirewallRuleState<_, _, _, _>) : azurerm.CosmosdbPostgresqlFirewallRule.CosmosdbPostgresqlFirewallRule =
            Unchecked.defaultof<azurerm.CosmosdbPostgresqlFirewallRule.CosmosdbPostgresqlFirewallRule>
