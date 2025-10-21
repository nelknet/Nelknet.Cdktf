namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedisFirewallRuleState<'EndIp, 'Name, 'RedisCacheName, 'ResourceGroupName, 'StartIp> = { assignments: ResizeArray<azurerm.RedisFirewallRule.RedisFirewallRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_firewall_rule">azurerm_redis_firewall_rule</a>.
    /// </summary>
    type RedisFirewallRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedisFirewallRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedisFirewallRuleState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RedisFirewallRuleState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedisFirewallRuleState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_firewall_rule#end_ip-1">RedisFirewallRule#end_ip</a>.
        /// </summary>
        [<CustomOperation "end_ip">]
        member _.EndIp(state: RedisFirewallRuleState<Missing, 'Name, 'RedisCacheName, 'ResourceGroupName, 'StartIp>, value: string) : RedisFirewallRuleState<Present, 'Name, 'RedisCacheName, 'ResourceGroupName, 'StartIp> =
            state.assignments.Add(fun config -> config.EndIp <- value)
            ({ assignments = state.assignments } : RedisFirewallRuleState<Present, 'Name, 'RedisCacheName, 'ResourceGroupName, 'StartIp>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_firewall_rule#name-1">RedisFirewallRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RedisFirewallRuleState<'EndIp, Missing, 'RedisCacheName, 'ResourceGroupName, 'StartIp>, value: string) : RedisFirewallRuleState<'EndIp, Present, 'RedisCacheName, 'ResourceGroupName, 'StartIp> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RedisFirewallRuleState<'EndIp, Present, 'RedisCacheName, 'ResourceGroupName, 'StartIp>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_firewall_rule#redis_cache_name-1">RedisFirewallRule#redis_cache_name</a>.
        /// </summary>
        [<CustomOperation "redis_cache_name">]
        member _.RedisCacheName(state: RedisFirewallRuleState<'EndIp, 'Name, Missing, 'ResourceGroupName, 'StartIp>, value: string) : RedisFirewallRuleState<'EndIp, 'Name, Present, 'ResourceGroupName, 'StartIp> =
            state.assignments.Add(fun config -> config.RedisCacheName <- value)
            ({ assignments = state.assignments } : RedisFirewallRuleState<'EndIp, 'Name, Present, 'ResourceGroupName, 'StartIp>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_firewall_rule#resource_group_name-1">RedisFirewallRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RedisFirewallRuleState<'EndIp, 'Name, 'RedisCacheName, Missing, 'StartIp>, value: string) : RedisFirewallRuleState<'EndIp, 'Name, 'RedisCacheName, Present, 'StartIp> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RedisFirewallRuleState<'EndIp, 'Name, 'RedisCacheName, Present, 'StartIp>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_firewall_rule#start_ip-1">RedisFirewallRule#start_ip</a>.
        /// </summary>
        [<CustomOperation "start_ip">]
        member _.StartIp(state: RedisFirewallRuleState<'EndIp, 'Name, 'RedisCacheName, 'ResourceGroupName, Missing>, value: string) : RedisFirewallRuleState<'EndIp, 'Name, 'RedisCacheName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.StartIp <- value)
            ({ assignments = state.assignments } : RedisFirewallRuleState<'EndIp, 'Name, 'RedisCacheName, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_firewall_rule#id-1">RedisFirewallRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedisFirewallRuleState<'EndIp, 'Name, 'RedisCacheName, 'ResourceGroupName, 'StartIp>, value: string) : RedisFirewallRuleState<'EndIp, 'Name, 'RedisCacheName, 'ResourceGroupName, 'StartIp> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedisFirewallRuleState<'EndIp, 'Name, 'RedisCacheName, 'ResourceGroupName, 'StartIp>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_firewall_rule#timeouts-1">RedisFirewallRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RedisFirewallRuleState<'EndIp, 'Name, 'RedisCacheName, 'ResourceGroupName, 'StartIp>, value: azurerm.RedisFirewallRule.RedisFirewallRuleTimeouts) : RedisFirewallRuleState<'EndIp, 'Name, 'RedisCacheName, 'ResourceGroupName, 'StartIp> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RedisFirewallRuleState<'EndIp, 'Name, 'RedisCacheName, 'ResourceGroupName, 'StartIp>

        member _.Run(state: RedisFirewallRuleState<Present, Present, Present, Present, Present>) : azurerm.RedisFirewallRule.RedisFirewallRule =
            let config = azurerm.RedisFirewallRule.RedisFirewallRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.RedisFirewallRule.RedisFirewallRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.redisFirewallRule: missing required arguments. Must call: end_ip, name, redis_cache_name, resource_group_name, start_ip.", 9999, IsError = true)>]
        member _.Run(_: RedisFirewallRuleState<_, _, _, _, _>) : azurerm.RedisFirewallRule.RedisFirewallRule =
            Unchecked.defaultof<azurerm.RedisFirewallRule.RedisFirewallRule>
