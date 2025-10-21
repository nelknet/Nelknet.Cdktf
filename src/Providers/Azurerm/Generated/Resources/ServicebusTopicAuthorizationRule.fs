namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicebusTopicAuthorizationRuleState<'Name, 'TopicId> = { assignments: ResizeArray<azurerm.ServicebusTopicAuthorizationRule.ServicebusTopicAuthorizationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic_authorization_rule">azurerm_servicebus_topic_authorization_rule</a>.
    /// </summary>
    type ServicebusTopicAuthorizationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicebusTopicAuthorizationRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusTopicAuthorizationRuleState<Missing, Missing>)

        member _.Zero(()) : ServicebusTopicAuthorizationRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusTopicAuthorizationRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic_authorization_rule#name-1">ServicebusTopicAuthorizationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicebusTopicAuthorizationRuleState<Missing, 'TopicId>, value: string) : ServicebusTopicAuthorizationRuleState<Present, 'TopicId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicebusTopicAuthorizationRuleState<Present, 'TopicId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic_authorization_rule#topic_id-1">ServicebusTopicAuthorizationRule#topic_id</a>.
        /// </summary>
        [<CustomOperation "topic_id">]
        member _.TopicId(state: ServicebusTopicAuthorizationRuleState<'Name, Missing>, value: string) : ServicebusTopicAuthorizationRuleState<'Name, Present> =
            state.assignments.Add(fun config -> config.TopicId <- value)
            ({ assignments = state.assignments } : ServicebusTopicAuthorizationRuleState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic_authorization_rule#id-1">ServicebusTopicAuthorizationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>, value: string) : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic_authorization_rule#listen-1">ServicebusTopicAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>, value: bool) : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic_authorization_rule#listen-1">ServicebusTopicAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic_authorization_rule#manage-1">ServicebusTopicAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>, value: bool) : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic_authorization_rule#manage-1">ServicebusTopicAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic_authorization_rule#send-1">ServicebusTopicAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>, value: bool) : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic_authorization_rule#send-1">ServicebusTopicAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_topic_authorization_rule#timeouts-1">ServicebusTopicAuthorizationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>, value: azurerm.ServicebusTopicAuthorizationRule.ServicebusTopicAuthorizationRuleTimeouts) : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicebusTopicAuthorizationRuleState<'Name, 'TopicId>

        member _.Run(state: ServicebusTopicAuthorizationRuleState<Present, Present>) : azurerm.ServicebusTopicAuthorizationRule.ServicebusTopicAuthorizationRule =
            let config = azurerm.ServicebusTopicAuthorizationRule.ServicebusTopicAuthorizationRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.ServicebusTopicAuthorizationRule.ServicebusTopicAuthorizationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.servicebusTopicAuthorizationRule: missing required arguments. Must call: name, topic_id.", 9999, IsError = true)>]
        member _.Run(_: ServicebusTopicAuthorizationRuleState<_, _>) : azurerm.ServicebusTopicAuthorizationRule.ServicebusTopicAuthorizationRule =
            Unchecked.defaultof<azurerm.ServicebusTopicAuthorizationRule.ServicebusTopicAuthorizationRule>
