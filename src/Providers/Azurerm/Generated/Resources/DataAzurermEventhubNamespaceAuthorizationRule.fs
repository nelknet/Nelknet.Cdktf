namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermEventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermEventhubNamespaceAuthorizationRule.DataAzurermEventhubNamespaceAuthorizationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_namespace_authorization_rule">azurerm_eventhub_namespace_authorization_rule</a>.
    /// </summary>
    type DataAzurermEventhubNamespaceAuthorizationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermEventhubNamespaceAuthorizationRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventhubNamespaceAuthorizationRuleState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermEventhubNamespaceAuthorizationRuleState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventhubNamespaceAuthorizationRuleState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_namespace_authorization_rule#name-1">DataAzurermEventhubNamespaceAuthorizationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermEventhubNamespaceAuthorizationRuleState<Missing, 'NamespaceName, 'ResourceGroupName>, value: string) : DataAzurermEventhubNamespaceAuthorizationRuleState<Present, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubNamespaceAuthorizationRuleState<Present, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_namespace_authorization_rule#namespace_name-1">DataAzurermEventhubNamespaceAuthorizationRule#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: DataAzurermEventhubNamespaceAuthorizationRuleState<'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermEventhubNamespaceAuthorizationRuleState<'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubNamespaceAuthorizationRuleState<'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_namespace_authorization_rule#resource_group_name-1">DataAzurermEventhubNamespaceAuthorizationRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermEventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, Missing>, value: string) : DataAzurermEventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_namespace_authorization_rule#id-1">DataAzurermEventhubNamespaceAuthorizationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermEventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : DataAzurermEventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermEventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_namespace_authorization_rule#timeouts-1">DataAzurermEventhubNamespaceAuthorizationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermEventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>, value: azurerm.DataAzurermEventhubNamespaceAuthorizationRule.DataAzurermEventhubNamespaceAuthorizationRuleTimeouts) : DataAzurermEventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermEventhubNamespaceAuthorizationRuleState<'Name, 'NamespaceName, 'ResourceGroupName>

        member _.Run(state: DataAzurermEventhubNamespaceAuthorizationRuleState<Present, Present, Present>) : azurerm.DataAzurermEventhubNamespaceAuthorizationRule.DataAzurermEventhubNamespaceAuthorizationRule =
            let config = azurerm.DataAzurermEventhubNamespaceAuthorizationRule.DataAzurermEventhubNamespaceAuthorizationRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermEventhubNamespaceAuthorizationRule.DataAzurermEventhubNamespaceAuthorizationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermEventhubNamespaceAuthorizationRule: missing required arguments. Must call: name, namespace_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermEventhubNamespaceAuthorizationRuleState<_, _, _>) : azurerm.DataAzurermEventhubNamespaceAuthorizationRule.DataAzurermEventhubNamespaceAuthorizationRule =
            Unchecked.defaultof<azurerm.DataAzurermEventhubNamespaceAuthorizationRule.DataAzurermEventhubNamespaceAuthorizationRule>
