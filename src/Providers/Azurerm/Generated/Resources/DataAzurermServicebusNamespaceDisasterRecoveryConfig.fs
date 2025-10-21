namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name> = { assignments: ResizeArray<azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_disaster_recovery_config">azurerm_servicebus_namespace_disaster_recovery_config</a>.
    /// </summary>
    type DataAzurermServicebusNamespaceDisasterRecoveryConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<Missing>)

        member _.Zero(()) : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<Missing> =
            ({ assignments = ResizeArray() } : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_disaster_recovery_config#name-1">DataAzurermServicebusNamespaceDisasterRecoveryConfig#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermServicebusNamespaceDisasterRecoveryConfigState<Missing>, value: string) : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_disaster_recovery_config#alias_authorization_rule_id-1">DataAzurermServicebusNamespaceDisasterRecoveryConfig#alias_authorization_rule_id</a>.
        /// </summary>
        [<CustomOperation "alias_authorization_rule_id">]
        member _.AliasAuthorizationRuleId(state: DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name>, value: string) : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name> =
            state.assignments.Add(fun config -> config.AliasAuthorizationRuleId <- value)
            state : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_disaster_recovery_config#id-1">DataAzurermServicebusNamespaceDisasterRecoveryConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name>, value: string) : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_disaster_recovery_config#namespace_id-1">DataAzurermServicebusNamespaceDisasterRecoveryConfig#namespace_id</a>.
        /// </summary>
        [<CustomOperation "namespace_id">]
        member _.NamespaceId(state: DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name>, value: string) : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name> =
            state.assignments.Add(fun config -> config.NamespaceId <- value)
            state : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_disaster_recovery_config#namespace_name-1">DataAzurermServicebusNamespaceDisasterRecoveryConfig#namespace_name</a>.
        /// </summary>
        [<CustomOperation "namespace_name">]
        member _.NamespaceName(state: DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name>, value: string) : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name> =
            state.assignments.Add(fun config -> config.NamespaceName <- value)
            state : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_disaster_recovery_config#resource_group_name-1">DataAzurermServicebusNamespaceDisasterRecoveryConfig#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name>, value: string) : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            state : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/servicebus_namespace_disaster_recovery_config#timeouts-1">DataAzurermServicebusNamespaceDisasterRecoveryConfig#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name>, value: azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfigTimeouts) : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermServicebusNamespaceDisasterRecoveryConfigState<'Name>

        member _.Run(state: DataAzurermServicebusNamespaceDisasterRecoveryConfigState<Present>) : azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfig =
            let config = azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfigConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermServicebusNamespaceDisasterRecoveryConfig: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermServicebusNamespaceDisasterRecoveryConfigState<_>) : azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfig =
            Unchecked.defaultof<azurerm.DataAzurermServicebusNamespaceDisasterRecoveryConfig.DataAzurermServicebusNamespaceDisasterRecoveryConfig>
