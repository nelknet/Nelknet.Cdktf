namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.EventhubAuthorizationRule.EventhubAuthorizationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_authorization_rule">azurerm_eventhub_authorization_rule</a>.
    /// </summary>
    type EventhubAuthorizationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : EventhubAuthorizationRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubAuthorizationRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : EventhubAuthorizationRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EventhubAuthorizationRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_authorization_rule#eventhub_name-1">EventhubAuthorizationRule#eventhub_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_name">]
        member _.EventhubName(state: EventhubAuthorizationRuleState<Missing, 'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : EventhubAuthorizationRuleState<Present, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EventhubName <- value)
            ({ assignments = state.assignments } : EventhubAuthorizationRuleState<Present, 'Name, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_authorization_rule#name-1">EventhubAuthorizationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EventhubAuthorizationRuleState<'EventhubName, Missing, 'NamespaceName, 'ResourceGroupName>, value: string) : EventhubAuthorizationRuleState<'EventhubName, Present, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EventhubAuthorizationRuleState<'EventhubName, Present, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_authorization_rule#namespace_name-1">EventhubAuthorizationRule#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: EventhubAuthorizationRuleState<'EventhubName, 'Name, Missing, 'ResourceGroupName>, value: string) : EventhubAuthorizationRuleState<'EventhubName, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : EventhubAuthorizationRuleState<'EventhubName, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_authorization_rule#resource_group_name-1">EventhubAuthorizationRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, Missing>, value: string) : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_authorization_rule#id-1">EventhubAuthorizationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_authorization_rule#listen-1">EventhubAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_authorization_rule#listen-1">EventhubAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_authorization_rule#manage-1">EventhubAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_authorization_rule#manage-1">EventhubAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_authorization_rule#send-1">EventhubAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_authorization_rule#send-1">EventhubAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/eventhub_authorization_rule#timeouts-1">EventhubAuthorizationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: azurerm.EventhubAuthorizationRule.EventhubAuthorizationRuleTimeouts) : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        member _.Run(state: EventhubAuthorizationRuleState<Present, Present, Present, Present>) : azurerm.EventhubAuthorizationRule.EventhubAuthorizationRule =
            let config = azurerm.EventhubAuthorizationRule.EventhubAuthorizationRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.EventhubAuthorizationRule.EventhubAuthorizationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.eventhubAuthorizationRule: missing required arguments. Must call: eventhub_name, name, namespace_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: EventhubAuthorizationRuleState<_, _, _, _>) : azurerm.EventhubAuthorizationRule.EventhubAuthorizationRule =
            Unchecked.defaultof<azurerm.EventhubAuthorizationRule.EventhubAuthorizationRule>
