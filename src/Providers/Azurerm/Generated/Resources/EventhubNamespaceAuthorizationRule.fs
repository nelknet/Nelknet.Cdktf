namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.EventhubNamespaceAuthorizationRule.EventhubNamespaceAuthorizationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_authorization_rule">azurerm_eventhub_namespace_authorization_rule</a>.
    /// </summary>
    type EventhubNamespaceAuthorizationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventhubNamespaceAuthorizationRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubNamespaceAuthorizationRuleState<Missing, Missing, Missing>)

        member _.Zero(()) : EventhubNamespaceAuthorizationRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubNamespaceAuthorizationRuleState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_authorization_rule#name-1">EventhubNamespaceAuthorizationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EventhubNamespaceAuthorizationRuleState<Missing, 'NamespaceName, 'ResourceGroupName>, value: string) : EventhubNamespaceAuthorizationRuleState<Present, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EventhubNamespaceAuthorizationRuleState<Present, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_authorization_rule#namespace_name-1">EventhubNamespaceAuthorizationRule#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: EventhubNamespaceAuthorizationRuleState<'Name, Missing, 'ResourceGroupName>, value: string) : EventhubNamespaceAuthorizationRuleState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : EventhubNamespaceAuthorizationRuleState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_authorization_rule#resource_group_name-1">EventhubNamespaceAuthorizationRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, Missing>, value: string) : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_authorization_rule#id-1">EventhubNamespaceAuthorizationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_authorization_rule#listen-1">EventhubNamespaceAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_authorization_rule#listen-1">EventhubNamespaceAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_authorization_rule#manage-1">EventhubNamespaceAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_authorization_rule#manage-1">EventhubNamespaceAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_authorization_rule#send-1">EventhubNamespaceAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_authorization_rule#send-1">EventhubNamespaceAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_namespace_authorization_rule#timeouts-1">EventhubNamespaceAuthorizationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: azurerm.EventhubNamespaceAuthorizationRule.EventhubNamespaceAuthorizationRuleTimeouts) : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        member _.Run(state: EventhubNamespaceAuthorizationRuleState<Present, Present, Present>) : azurerm.EventhubNamespaceAuthorizationRule.EventhubNamespaceAuthorizationRule =
            let config = azurerm.EventhubNamespaceAuthorizationRule.EventhubNamespaceAuthorizationRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.EventhubNamespaceAuthorizationRule.EventhubNamespaceAuthorizationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventhubNamespaceAuthorizationRule: missing required arguments. Must call: name, namespace_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: EventhubNamespaceAuthorizationRuleState<_, _, _>) : azurerm.EventhubNamespaceAuthorizationRule.EventhubNamespaceAuthorizationRule =
            Unchecked.defaultof<azurerm.EventhubNamespaceAuthorizationRule.EventhubNamespaceAuthorizationRule>
