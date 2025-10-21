namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId> = { assignments: ResizeArray<azurerm.ServicebusNamespaceAuthorizationRule.ServicebusNamespaceAuthorizationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_authorization_rule">azurerm_servicebus_namespace_authorization_rule</a>.
    /// </summary>
    type ServicebusNamespaceAuthorizationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicebusNamespaceAuthorizationRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusNamespaceAuthorizationRuleState<Missing, Missing>)

        member _.Zero(()) : ServicebusNamespaceAuthorizationRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusNamespaceAuthorizationRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_authorization_rule#name-1">ServicebusNamespaceAuthorizationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicebusNamespaceAuthorizationRuleState<Missing, 'NamespaceId>, value: string) : ServicebusNamespaceAuthorizationRuleState<Present, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicebusNamespaceAuthorizationRuleState<Present, 'NamespaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_authorization_rule#namespace_id-1">ServicebusNamespaceAuthorizationRule#namespace_id</a>.
        /// </summary>
        [<CustomOperation "namespace_id">]
        member _.NamespaceId(state: ServicebusNamespaceAuthorizationRuleState<'Name, Missing>, value: string) : ServicebusNamespaceAuthorizationRuleState<'Name, Present> =
            state.assignments.Add(fun config -> config.NamespaceId <- value)
            ({ assignments = state.assignments } : ServicebusNamespaceAuthorizationRuleState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_authorization_rule#id-1">ServicebusNamespaceAuthorizationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>, value: string) : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_authorization_rule#listen-1">ServicebusNamespaceAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>, value: bool) : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_authorization_rule#listen-1">ServicebusNamespaceAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_authorization_rule#manage-1">ServicebusNamespaceAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>, value: bool) : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_authorization_rule#manage-1">ServicebusNamespaceAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_authorization_rule#send-1">ServicebusNamespaceAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>, value: bool) : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_authorization_rule#send-1">ServicebusNamespaceAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_authorization_rule#timeouts-1">ServicebusNamespaceAuthorizationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>, value: azurerm.ServicebusNamespaceAuthorizationRule.ServicebusNamespaceAuthorizationRuleTimeouts) : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicebusNamespaceAuthorizationRuleState<'Name, 'NamespaceId>

        member _.Run(state: ServicebusNamespaceAuthorizationRuleState<Present, Present>) : azurerm.ServicebusNamespaceAuthorizationRule.ServicebusNamespaceAuthorizationRule =
            let config = azurerm.ServicebusNamespaceAuthorizationRule.ServicebusNamespaceAuthorizationRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.ServicebusNamespaceAuthorizationRule.ServicebusNamespaceAuthorizationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.servicebusNamespaceAuthorizationRule: missing required arguments. Must call: name, namespace_id.", 9999, IsError = true)>]
        member _.Run(_: ServicebusNamespaceAuthorizationRuleState<_, _>) : azurerm.ServicebusNamespaceAuthorizationRule.ServicebusNamespaceAuthorizationRule =
            Unchecked.defaultof<azurerm.ServicebusNamespaceAuthorizationRule.ServicebusNamespaceAuthorizationRule>
