namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermServicebusNamespaceAuthorizationRuleState<'Name> = { assignments: ResizeArray<azurerm.DataAzurermServicebusNamespaceAuthorizationRule.DataAzurermServicebusNamespaceAuthorizationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_authorization_rule">azurerm_servicebus_namespace_authorization_rule</a>.
    /// </summary>
    type DataAzurermServicebusNamespaceAuthorizationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermServicebusNamespaceAuthorizationRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusNamespaceAuthorizationRuleState<Missing>)

        member _.Zero(()) : DataAzurermServicebusNamespaceAuthorizationRuleState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusNamespaceAuthorizationRuleState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_authorization_rule#name-1">DataAzurermServicebusNamespaceAuthorizationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermServicebusNamespaceAuthorizationRuleState<Missing>, value: string) : DataAzurermServicebusNamespaceAuthorizationRuleState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermServicebusNamespaceAuthorizationRuleState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_authorization_rule#id-1">DataAzurermServicebusNamespaceAuthorizationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermServicebusNamespaceAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusNamespaceAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermServicebusNamespaceAuthorizationRuleState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_authorization_rule#namespace_id-1">DataAzurermServicebusNamespaceAuthorizationRule#namespace_id</a>.
        /// </summary>
        [<CustomOperation "namespace_id">]
        member _.NamespaceId(state: DataAzurermServicebusNamespaceAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusNamespaceAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.NamespaceId <- value)
            state : DataAzurermServicebusNamespaceAuthorizationRuleState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_authorization_rule#namespace_name-1">DataAzurermServicebusNamespaceAuthorizationRule#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: DataAzurermServicebusNamespaceAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusNamespaceAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            state : DataAzurermServicebusNamespaceAuthorizationRuleState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_authorization_rule#resource_group_name-1">DataAzurermServicebusNamespaceAuthorizationRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermServicebusNamespaceAuthorizationRuleState<'Name>, value: string) : DataAzurermServicebusNamespaceAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            state : DataAzurermServicebusNamespaceAuthorizationRuleState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_authorization_rule#timeouts-1">DataAzurermServicebusNamespaceAuthorizationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermServicebusNamespaceAuthorizationRuleState<'Name>, value: azurerm.DataAzurermServicebusNamespaceAuthorizationRule.DataAzurermServicebusNamespaceAuthorizationRuleTimeouts) : DataAzurermServicebusNamespaceAuthorizationRuleState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermServicebusNamespaceAuthorizationRuleState<'Name>

        member _.Run(state: DataAzurermServicebusNamespaceAuthorizationRuleState<Present>) : azurerm.DataAzurermServicebusNamespaceAuthorizationRule.DataAzurermServicebusNamespaceAuthorizationRule =
            let config = azurerm.DataAzurermServicebusNamespaceAuthorizationRule.DataAzurermServicebusNamespaceAuthorizationRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermServicebusNamespaceAuthorizationRule.DataAzurermServicebusNamespaceAuthorizationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermServicebusNamespaceAuthorizationRule: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermServicebusNamespaceAuthorizationRuleState<_>) : azurerm.DataAzurermServicebusNamespaceAuthorizationRule.DataAzurermServicebusNamespaceAuthorizationRule =
            Unchecked.defaultof<azurerm.DataAzurermServicebusNamespaceAuthorizationRule.DataAzurermServicebusNamespaceAuthorizationRule>
