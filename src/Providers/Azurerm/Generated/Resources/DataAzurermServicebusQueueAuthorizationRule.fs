namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermServicebusQueueAuthorizationRuleState<'Name> = { assignments: ResizeArray<azurerm.DataAzurermServicebusQueueAuthorizationRule.DataAzurermServicebusQueueAuthorizationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue_authorization_rule">azurerm_servicebus_queue_authorization_rule</a>.
    /// </summary>
    type DataAzurermServicebusQueueAuthorizationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermServicebusQueueAuthorizationRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusQueueAuthorizationRuleState<Missing>)

        member _.Zero(()) : DataAzurermServicebusQueueAuthorizationRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusQueueAuthorizationRuleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue_authorization_rule#name-1">DataAzurermServicebusQueueAuthorizationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermServicebusQueueAuthorizationRuleState<Missing>, value: string) : DataAzurermServicebusQueueAuthorizationRuleState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermServicebusQueueAuthorizationRuleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue_authorization_rule#id-1">DataAzurermServicebusQueueAuthorizationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermServicebusQueueAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusQueueAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermServicebusQueueAuthorizationRuleState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue_authorization_rule#namespace_name-1">DataAzurermServicebusQueueAuthorizationRule#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: DataAzurermServicebusQueueAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusQueueAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            state : DataAzurermServicebusQueueAuthorizationRuleState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue_authorization_rule#queue_id-1">DataAzurermServicebusQueueAuthorizationRule#queue_id</a>.
        /// </summary>
        [<CustomOperation "queue_id">]
        member _.QueueId(state: DataAzurermServicebusQueueAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusQueueAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.QueueId <- value)
            state : DataAzurermServicebusQueueAuthorizationRuleState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue_authorization_rule#queue_name-1">DataAzurermServicebusQueueAuthorizationRule#queue_name</a>.
        /// </summary>
        [<CustomOperation "queue_name">]
        member _.QueueName(state: DataAzurermServicebusQueueAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusQueueAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.QueueName <- value)
            state : DataAzurermServicebusQueueAuthorizationRuleState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue_authorization_rule#resource_group_name-1">DataAzurermServicebusQueueAuthorizationRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermServicebusQueueAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusQueueAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            state : DataAzurermServicebusQueueAuthorizationRuleState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_queue_authorization_rule#timeouts-1">DataAzurermServicebusQueueAuthorizationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermServicebusQueueAuthorizationRuleState<'Name>, value: azurerm.DataAzurermServicebusQueueAuthorizationRule.DataAzurermServicebusQueueAuthorizationRuleTimeouts) : DataAzurermServicebusQueueAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermServicebusQueueAuthorizationRuleState<'Name>

        member _.Run(state: DataAzurermServicebusQueueAuthorizationRuleState<Present>) : azurerm.DataAzurermServicebusQueueAuthorizationRule.DataAzurermServicebusQueueAuthorizationRule =
            let config = azurerm.DataAzurermServicebusQueueAuthorizationRule.DataAzurermServicebusQueueAuthorizationRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermServicebusQueueAuthorizationRule.DataAzurermServicebusQueueAuthorizationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermServicebusQueueAuthorizationRule: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermServicebusQueueAuthorizationRuleState<_>) : azurerm.DataAzurermServicebusQueueAuthorizationRule.DataAzurermServicebusQueueAuthorizationRule =
            Unchecked.defaultof<azurerm.DataAzurermServicebusQueueAuthorizationRule.DataAzurermServicebusQueueAuthorizationRule>
