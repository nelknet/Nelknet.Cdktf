namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.NotificationHubAuthorizationRule.NotificationHubAuthorizationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_authorization_rule">azurerm_notification_hub_authorization_rule</a>.
    /// </summary>
    type NotificationHubAuthorizationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : NotificationHubAuthorizationRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NotificationHubAuthorizationRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NotificationHubAuthorizationRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NotificationHubAuthorizationRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_authorization_rule#name-1">NotificationHubAuthorizationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NotificationHubAuthorizationRuleState<Missing, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>, value: string) : NotificationHubAuthorizationRuleState<Present, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NotificationHubAuthorizationRuleState<Present, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_authorization_rule#namespace_name-1">NotificationHubAuthorizationRule#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: NotificationHubAuthorizationRuleState<'Name, Missing, 'NotificationHubName, 'ResourceGroupName>, value: string) : NotificationHubAuthorizationRuleState<'Name, Present, 'NotificationHubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : NotificationHubAuthorizationRuleState<'Name, Present, 'NotificationHubName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_authorization_rule#notification_hub_name-1">NotificationHubAuthorizationRule#notification_hub_name</a>.
        /// </summary>
        [<CustomOperation "notification_hub_name">]
        member _.NotificationHubName(state: NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, Missing, 'ResourceGroupName>, value: string) : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NotificationHubName <- value)
            ({ assignments = state.assignments } : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_authorization_rule#resource_group_name-1">NotificationHubAuthorizationRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, Missing>, value: string) : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_authorization_rule#id-1">NotificationHubAuthorizationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>, value: string) : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_authorization_rule#listen-1">NotificationHubAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>, value: bool) : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_authorization_rule#listen-1">NotificationHubAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_authorization_rule#manage-1">NotificationHubAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>, value: bool) : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_authorization_rule#manage-1">NotificationHubAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_authorization_rule#send-1">NotificationHubAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>, value: bool) : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_authorization_rule#send-1">NotificationHubAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/notification_hub_authorization_rule#timeouts-1">NotificationHubAuthorizationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>, value: azurerm.NotificationHubAuthorizationRule.NotificationHubAuthorizationRuleTimeouts) : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NotificationHubAuthorizationRuleState<'Name, 'NamespaceName, 'NotificationHubName, 'ResourceGroupName>

        member _.Run(state: NotificationHubAuthorizationRuleState<Present, Present, Present, Present>) : azurerm.NotificationHubAuthorizationRule.NotificationHubAuthorizationRule =
            let config = azurerm.NotificationHubAuthorizationRule.NotificationHubAuthorizationRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.NotificationHubAuthorizationRule.NotificationHubAuthorizationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.notificationHubAuthorizationRule: missing required arguments. Must call: name, namespace_name, notification_hub_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: NotificationHubAuthorizationRuleState<_, _, _, _>) : azurerm.NotificationHubAuthorizationRule.NotificationHubAuthorizationRule =
            Unchecked.defaultof<azurerm.NotificationHubAuthorizationRule.NotificationHubAuthorizationRule>
