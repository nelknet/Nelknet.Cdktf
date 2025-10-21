namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermServicebusTopicAuthorizationRuleState<'Name> = { assignments: ResizeArray<azurerm.DataAzurermServicebusTopicAuthorizationRule.DataAzurermServicebusTopicAuthorizationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic_authorization_rule">azurerm_servicebus_topic_authorization_rule</a>.
    /// </summary>
    type DataAzurermServicebusTopicAuthorizationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermServicebusTopicAuthorizationRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusTopicAuthorizationRuleState<Missing>)

        member _.Zero(()) : DataAzurermServicebusTopicAuthorizationRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusTopicAuthorizationRuleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic_authorization_rule#name-1">DataAzurermServicebusTopicAuthorizationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermServicebusTopicAuthorizationRuleState<Missing>, value: string) : DataAzurermServicebusTopicAuthorizationRuleState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermServicebusTopicAuthorizationRuleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic_authorization_rule#id-1">DataAzurermServicebusTopicAuthorizationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermServicebusTopicAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusTopicAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermServicebusTopicAuthorizationRuleState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic_authorization_rule#namespace_name-1">DataAzurermServicebusTopicAuthorizationRule#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: DataAzurermServicebusTopicAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusTopicAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            state : DataAzurermServicebusTopicAuthorizationRuleState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic_authorization_rule#queue_name-1">DataAzurermServicebusTopicAuthorizationRule#queue_name</a>.
        /// </summary>
        [<CustomOperation "queue_name">]
        member _.QueueName(state: DataAzurermServicebusTopicAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusTopicAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.QueueName <- value)
            state : DataAzurermServicebusTopicAuthorizationRuleState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic_authorization_rule#resource_group_name-1">DataAzurermServicebusTopicAuthorizationRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermServicebusTopicAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusTopicAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            state : DataAzurermServicebusTopicAuthorizationRuleState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic_authorization_rule#timeouts-1">DataAzurermServicebusTopicAuthorizationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermServicebusTopicAuthorizationRuleState<'Name>, value: azurerm.DataAzurermServicebusTopicAuthorizationRule.DataAzurermServicebusTopicAuthorizationRuleTimeouts) : DataAzurermServicebusTopicAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermServicebusTopicAuthorizationRuleState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic_authorization_rule#topic_id-1">DataAzurermServicebusTopicAuthorizationRule#topic_id</a>.
        /// </summary>
        [<CustomOperation "topic_id">]
        member _.TopicId(state: DataAzurermServicebusTopicAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusTopicAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.TopicId <- value)
            state : DataAzurermServicebusTopicAuthorizationRuleState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_topic_authorization_rule#topic_name-1">DataAzurermServicebusTopicAuthorizationRule#topic_name</a>.
        /// </summary>
        [<CustomOperation "topic_name">]
        member _.TopicName(state: DataAzurermServicebusTopicAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusTopicAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.TopicName <- value)
            state : DataAzurermServicebusTopicAuthorizationRuleState<'Name>

        member _.Run(state: DataAzurermServicebusTopicAuthorizationRuleState<Present>) : azurerm.DataAzurermServicebusTopicAuthorizationRule.DataAzurermServicebusTopicAuthorizationRule =
            let config = azurerm.DataAzurermServicebusTopicAuthorizationRule.DataAzurermServicebusTopicAuthorizationRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermServicebusTopicAuthorizationRule.DataAzurermServicebusTopicAuthorizationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermServicebusTopicAuthorizationRule: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermServicebusTopicAuthorizationRuleState<_>) : azurerm.DataAzurermServicebusTopicAuthorizationRule.DataAzurermServicebusTopicAuthorizationRule =
            Unchecked.defaultof<azurerm.DataAzurermServicebusTopicAuthorizationRule.DataAzurermServicebusTopicAuthorizationRule>
