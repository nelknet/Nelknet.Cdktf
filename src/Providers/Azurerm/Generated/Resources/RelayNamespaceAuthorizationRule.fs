namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.RelayNamespaceAuthorizationRule.RelayNamespaceAuthorizationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace_authorization_rule">azurerm_relay_namespace_authorization_rule</a>.
    /// </summary>
    type RelayNamespaceAuthorizationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : RelayNamespaceAuthorizationRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RelayNamespaceAuthorizationRuleState<Missing, Missing, Missing>)

        member _.Zero(()) : RelayNamespaceAuthorizationRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RelayNamespaceAuthorizationRuleState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace_authorization_rule#name-1">RelayNamespaceAuthorizationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RelayNamespaceAuthorizationRuleState<Missing, 'NamespaceName, 'ResourceGroupName>, value: string) : RelayNamespaceAuthorizationRuleState<Present, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RelayNamespaceAuthorizationRuleState<Present, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace_authorization_rule#namespace_name-1">RelayNamespaceAuthorizationRule#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: RelayNamespaceAuthorizationRuleState<'Name, Missing, 'ResourceGroupName>, value: string) : RelayNamespaceAuthorizationRuleState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : RelayNamespaceAuthorizationRuleState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace_authorization_rule#resource_group_name-1">RelayNamespaceAuthorizationRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, Missing>, value: string) : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace_authorization_rule#id-1">RelayNamespaceAuthorizationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace_authorization_rule#listen-1">RelayNamespaceAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace_authorization_rule#listen-1">RelayNamespaceAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace_authorization_rule#manage-1">RelayNamespaceAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace_authorization_rule#manage-1">RelayNamespaceAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace_authorization_rule#send-1">RelayNamespaceAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace_authorization_rule#send-1">RelayNamespaceAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/relay_namespace_authorization_rule#timeouts-1">RelayNamespaceAuthorizationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: azurerm.RelayNamespaceAuthorizationRule.RelayNamespaceAuthorizationRuleTimeouts) : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RelayNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        member _.Run(state: RelayNamespaceAuthorizationRuleState<Present, Present, Present>) : azurerm.RelayNamespaceAuthorizationRule.RelayNamespaceAuthorizationRule =
            let config = azurerm.RelayNamespaceAuthorizationRule.RelayNamespaceAuthorizationRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.RelayNamespaceAuthorizationRule.RelayNamespaceAuthorizationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.relayNamespaceAuthorizationRule: missing required arguments. Must call: name, namespace_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: RelayNamespaceAuthorizationRuleState<_, _, _>) : azurerm.RelayNamespaceAuthorizationRule.RelayNamespaceAuthorizationRule =
            Unchecked.defaultof<azurerm.RelayNamespaceAuthorizationRule.RelayNamespaceAuthorizationRule>
