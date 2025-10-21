namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermEventhubAuthorizationRule.DataAzurermEventhubAuthorizationRuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_authorization_rule">azurerm_eventhub_authorization_rule</a>.
    /// </summary>
    type DataAzurermEventhubAuthorizationRuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermEventhubAuthorizationRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventhubAuthorizationRuleState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermEventhubAuthorizationRuleState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermEventhubAuthorizationRuleState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_authorization_rule#eventhub_name-1">DataAzurermEventhubAuthorizationRule#eventhub_name</a>.
        /// </summary>
        [<CustomOperation "eventhub_name">]
        member _.EventhubName(state: DataAzurermEventhubAuthorizationRuleState<Missing, 'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : DataAzurermEventhubAuthorizationRuleState<Present, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EventhubName <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubAuthorizationRuleState<Present, 'Name, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_authorization_rule#name-1">DataAzurermEventhubAuthorizationRule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermEventhubAuthorizationRuleState<'EventhubName, Missing, 'NamespaceName, 'ResourceGroupName>, value: string) : DataAzurermEventhubAuthorizationRuleState<'EventhubName, Present, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubAuthorizationRuleState<'EventhubName, Present, 'NamespaceName, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_authorization_rule#namespace_name-1">DataAzurermEventhubAuthorizationRule#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, Missing, 'ResourceGroupName>, value: string) : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_authorization_rule#resource_group_name-1">DataAzurermEventhubAuthorizationRule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, Missing>, value: string) : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_authorization_rule#id-1">DataAzurermEventhubAuthorizationRule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: string) : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_authorization_rule#listen-1">DataAzurermEventhubAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_authorization_rule#listen-1">DataAzurermEventhubAuthorizationRule#listen</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "listen">]
        member _.Listen(state: DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Listen <- value)
            state : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_authorization_rule#manage-1">DataAzurermEventhubAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_authorization_rule#manage-1">DataAzurermEventhubAuthorizationRule#manage</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "manage">]
        member _.Manage(state: DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Manage <- value)
            state : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_authorization_rule#send-1">DataAzurermEventhubAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: bool) : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_authorization_rule#send-1">DataAzurermEventhubAuthorizationRule#send</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "send">]
        member _.Send(state: DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Send <- value)
            state : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/eventhub_authorization_rule#timeouts-1">DataAzurermEventhubAuthorizationRule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>, value: azurerm.DataAzurermEventhubAuthorizationRule.DataAzurermEventhubAuthorizationRuleTimeouts) : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermEventhubAuthorizationRuleState<'EventhubName, 'Name, 'NamespaceName, 'ResourceGroupName>

        member _.Run(state: DataAzurermEventhubAuthorizationRuleState<Present, Present, Present, Present>) : azurerm.DataAzurermEventhubAuthorizationRule.DataAzurermEventhubAuthorizationRule =
            let config = azurerm.DataAzurermEventhubAuthorizationRule.DataAzurermEventhubAuthorizationRuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermEventhubAuthorizationRule.DataAzurermEventhubAuthorizationRule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermEventhubAuthorizationRule: missing required arguments. Must call: eventhub_name, name, namespace_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermEventhubAuthorizationRuleState<_, _, _, _>) : azurerm.DataAzurermEventhubAuthorizationRule.DataAzurermEventhubAuthorizationRule =
            Unchecked.defaultof<azurerm.DataAzurermEventhubAuthorizationRule.DataAzurermEventhubAuthorizationRule>
