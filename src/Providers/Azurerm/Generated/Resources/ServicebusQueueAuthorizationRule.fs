namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicebusQueueAuthorizationRuleState<'Name, 'QueueId> = { assignments: ResizeArray<azurerm.ServicebusQueueAuthorizationRule.ServicebusQueueAuthorizationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue_authorization_rule">azurerm_servicebus_queue_authorization_rule</a>.
    /// </summary>
    type ServicebusQueueAuthorizationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicebusQueueAuthorizationRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusQueueAuthorizationRuleState<Missing, Missing>)

        member _.Zero(()) : ServicebusQueueAuthorizationRuleState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusQueueAuthorizationRuleState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue_authorization_rule#name-1">ServicebusQueueAuthorizationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicebusQueueAuthorizationRuleState<Missing, 'QueueId>, value: string) : ServicebusQueueAuthorizationRuleState<Present, 'QueueId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicebusQueueAuthorizationRuleState<Present, 'QueueId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue_authorization_rule#queue_id-1">ServicebusQueueAuthorizationRule#queue_id</a>.
        /// </summary>
        [<CustomOperation "queue_id">]
        member _.QueueId(state: ServicebusQueueAuthorizationRuleState<'Name, Missing>, value: string) : ServicebusQueueAuthorizationRuleState<'Name, Present> =
            state.assignments.Add(fun config -> config.QueueId <- value)
            ({ assignments = state.assignments } : ServicebusQueueAuthorizationRuleState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue_authorization_rule#id-1">ServicebusQueueAuthorizationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>, value: string) : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue_authorization_rule#listen-1">ServicebusQueueAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>, value: bool) : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue_authorization_rule#listen-1">ServicebusQueueAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue_authorization_rule#manage-1">ServicebusQueueAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>, value: bool) : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue_authorization_rule#manage-1">ServicebusQueueAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue_authorization_rule#send-1">ServicebusQueueAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>, value: bool) : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue_authorization_rule#send-1">ServicebusQueueAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>, value: HashiCorp.Cdktf.IResolvable) : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_queue_authorization_rule#timeouts-1">ServicebusQueueAuthorizationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>, value: azurerm.ServicebusQueueAuthorizationRule.ServicebusQueueAuthorizationRuleTimeouts) : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicebusQueueAuthorizationRuleState<'Name, 'QueueId>

        member _.Run(state: ServicebusQueueAuthorizationRuleState<Present, Present>) : azurerm.ServicebusQueueAuthorizationRule.ServicebusQueueAuthorizationRule =
            let config = azurerm.ServicebusQueueAuthorizationRule.ServicebusQueueAuthorizationRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.ServicebusQueueAuthorizationRule.ServicebusQueueAuthorizationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.servicebusQueueAuthorizationRule: missing required arguments. Must call: name, queue_id.", 9999, IsError = true)>]
        member _.Run(_: ServicebusQueueAuthorizationRuleState<_, _>) : azurerm.ServicebusQueueAuthorizationRule.ServicebusQueueAuthorizationRule =
            Unchecked.defaultof<azurerm.ServicebusQueueAuthorizationRule.ServicebusQueueAuthorizationRule>
