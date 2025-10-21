namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicebusNamespaceDisasterRecoveryConfigState<'Name, 'PartnerNamespaceId, 'PrimaryNamespaceId> = { assignments: ResizeArray<azurerm.ServicebusNamespaceDisasterRecoveryConfig.ServicebusNamespaceDisasterRecoveryConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_disaster_recovery_config">azurerm_servicebus_namespace_disaster_recovery_config</a>.
    /// </summary>
    type ServicebusNamespaceDisasterRecoveryConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicebusNamespaceDisasterRecoveryConfigState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusNamespaceDisasterRecoveryConfigState<Missing, Missing, Missing>)

        member _.Zero(()) : ServicebusNamespaceDisasterRecoveryConfigState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicebusNamespaceDisasterRecoveryConfigState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_disaster_recovery_config#name-1">ServicebusNamespaceDisasterRecoveryConfig#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicebusNamespaceDisasterRecoveryConfigState<Missing, 'PartnerNamespaceId, 'PrimaryNamespaceId>, value: string) : ServicebusNamespaceDisasterRecoveryConfigState<Present, 'PartnerNamespaceId, 'PrimaryNamespaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicebusNamespaceDisasterRecoveryConfigState<Present, 'PartnerNamespaceId, 'PrimaryNamespaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_disaster_recovery_config#partner_namespace_id-1">ServicebusNamespaceDisasterRecoveryConfig#partner_namespace_id</a>.
        /// </summary>
        [<CustomOperation "partner_namespace_id">]
        member _.PartnerNamespaceId(state: ServicebusNamespaceDisasterRecoveryConfigState<'Name, Missing, 'PrimaryNamespaceId>, value: string) : ServicebusNamespaceDisasterRecoveryConfigState<'Name, Present, 'PrimaryNamespaceId> =
            state.assignments.Add(fun config -> config.PartnerNamespaceId <- value)
            ({ assignments = state.assignments } : ServicebusNamespaceDisasterRecoveryConfigState<'Name, Present, 'PrimaryNamespaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_disaster_recovery_config#primary_namespace_id-1">ServicebusNamespaceDisasterRecoveryConfig#primary_namespace_id</a>.
        /// </summary>
        [<CustomOperation "primary_namespace_id">]
        member _.PrimaryNamespaceId(state: ServicebusNamespaceDisasterRecoveryConfigState<'Name, 'PartnerNamespaceId, Missing>, value: string) : ServicebusNamespaceDisasterRecoveryConfigState<'Name, 'PartnerNamespaceId, Present> =
            state.assignments.Add(fun config -> config.PrimaryNamespaceId <- value)
            ({ assignments = state.assignments } : ServicebusNamespaceDisasterRecoveryConfigState<'Name, 'PartnerNamespaceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_disaster_recovery_config#alias_authorization_rule_id-1">ServicebusNamespaceDisasterRecoveryConfig#alias_authorization_rule_id</a>.
        /// </summary>
        [<CustomOperation "alias_authorization_rule_id">]
        member _.AliasAuthorizationRuleId(state: ServicebusNamespaceDisasterRecoveryConfigState<'Name, 'PartnerNamespaceId, 'PrimaryNamespaceId>, value: string) : ServicebusNamespaceDisasterRecoveryConfigState<'Name, 'PartnerNamespaceId, 'PrimaryNamespaceId> =
            state.assignments.Add(fun config -> config.AliasAuthorizationRuleId <- value)
            state : ServicebusNamespaceDisasterRecoveryConfigState<'Name, 'PartnerNamespaceId, 'PrimaryNamespaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_disaster_recovery_config#id-1">ServicebusNamespaceDisasterRecoveryConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicebusNamespaceDisasterRecoveryConfigState<'Name, 'PartnerNamespaceId, 'PrimaryNamespaceId>, value: string) : ServicebusNamespaceDisasterRecoveryConfigState<'Name, 'PartnerNamespaceId, 'PrimaryNamespaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicebusNamespaceDisasterRecoveryConfigState<'Name, 'PartnerNamespaceId, 'PrimaryNamespaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/servicebus_namespace_disaster_recovery_config#timeouts-1">ServicebusNamespaceDisasterRecoveryConfig#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicebusNamespaceDisasterRecoveryConfigState<'Name, 'PartnerNamespaceId, 'PrimaryNamespaceId>, value: azurerm.ServicebusNamespaceDisasterRecoveryConfig.ServicebusNamespaceDisasterRecoveryConfigTimeouts) : ServicebusNamespaceDisasterRecoveryConfigState<'Name, 'PartnerNamespaceId, 'PrimaryNamespaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicebusNamespaceDisasterRecoveryConfigState<'Name, 'PartnerNamespaceId, 'PrimaryNamespaceId>

        member _.Run(state: ServicebusNamespaceDisasterRecoveryConfigState<Present, Present, Present>) : azurerm.ServicebusNamespaceDisasterRecoveryConfig.ServicebusNamespaceDisasterRecoveryConfig =
            let config = azurerm.ServicebusNamespaceDisasterRecoveryConfig.ServicebusNamespaceDisasterRecoveryConfigConfig()
            for setter in state.assignments do
                setter config
            azurerm.ServicebusNamespaceDisasterRecoveryConfig.ServicebusNamespaceDisasterRecoveryConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.servicebusNamespaceDisasterRecoveryConfig: missing required arguments. Must call: name, partner_namespace_id, primary_namespace_id.", 9999, IsError = true)>]
        member _.Run(_: ServicebusNamespaceDisasterRecoveryConfigState<_, _, _>) : azurerm.ServicebusNamespaceDisasterRecoveryConfig.ServicebusNamespaceDisasterRecoveryConfig =
            Unchecked.defaultof<azurerm.ServicebusNamespaceDisasterRecoveryConfig.ServicebusNamespaceDisasterRecoveryConfig>
