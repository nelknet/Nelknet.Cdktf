namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.RelayHybridConnectionAuthorizationRule.RelayHybridConnectionAuthorizationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection_authorization_rule">azurerm_relay_hybrid_connection_authorization_rule</a>.
    /// </summary>
    type RelayHybridConnectionAuthorizationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : RelayHybridConnectionAuthorizationRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RelayHybridConnectionAuthorizationRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RelayHybridConnectionAuthorizationRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RelayHybridConnectionAuthorizationRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection_authorization_rule#hybrid_connection_name-1">RelayHybridConnectionAuthorizationRule#hybrid_connection_name</a>.
        /// </summary>
        [<CustomOperation "hybrid_connection_name">]
        member _.HybridConnectionName(state: RelayHybridConnectionAuthorizationRuleState<Missing, 'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : RelayHybridConnectionAuthorizationRuleState<Present, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HybridConnectionName <- value)
            ({ assignments = state.assignments } : RelayHybridConnectionAuthorizationRuleState<Present, 'Name, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection_authorization_rule#name-1">RelayHybridConnectionAuthorizationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, Missing, 'NamespaceName, 'ResourceGroupName>, value: string) : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, Present, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, Present, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection_authorization_rule#namespace_name-1">RelayHybridConnectionAuthorizationRule#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, Missing, 'ResourceGroupName>, value: string) : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection_authorization_rule#resource_group_name-1">RelayHybridConnectionAuthorizationRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, Missing>, value: string) : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection_authorization_rule#id-1">RelayHybridConnectionAuthorizationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection_authorization_rule#listen-1">RelayHybridConnectionAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection_authorization_rule#listen-1">RelayHybridConnectionAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection_authorization_rule#manage-1">RelayHybridConnectionAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection_authorization_rule#manage-1">RelayHybridConnectionAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection_authorization_rule#send-1">RelayHybridConnectionAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection_authorization_rule#send-1">RelayHybridConnectionAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_hybrid_connection_authorization_rule#timeouts-1">RelayHybridConnectionAuthorizationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: azurerm.RelayHybridConnectionAuthorizationRule.RelayHybridConnectionAuthorizationRuleTimeouts) : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RelayHybridConnectionAuthorizationRuleState<'HybridConnectionName, 'Name, 'NamespaceName, 'ResourceGroupName>

        member _.Run(state: RelayHybridConnectionAuthorizationRuleState<Present, Present, Present, Present>) : azurerm.RelayHybridConnectionAuthorizationRule.RelayHybridConnectionAuthorizationRule =
            let config = azurerm.RelayHybridConnectionAuthorizationRule.RelayHybridConnectionAuthorizationRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.RelayHybridConnectionAuthorizationRule.RelayHybridConnectionAuthorizationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.relayHybridConnectionAuthorizationRule: missing required arguments. Must call: hybrid_connection_name, name, namespace_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: RelayHybridConnectionAuthorizationRuleState<_, _, _, _>) : azurerm.RelayHybridConnectionAuthorizationRule.RelayHybridConnectionAuthorizationRule =
            Unchecked.defaultof<azurerm.RelayHybridConnectionAuthorizationRule.RelayHybridConnectionAuthorizationRule>
