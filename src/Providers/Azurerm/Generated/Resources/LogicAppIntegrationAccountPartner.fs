namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LogicAppIntegrationAccountPartner.LogicAppIntegrationAccountPartnerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_partner">azurerm_logic_app_integration_account_partner</a>.
    /// </summary>
    type LogicAppIntegrationAccountPartnerBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppIntegrationAccountPartnerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountPartnerState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppIntegrationAccountPartnerState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountPartnerState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// business_identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_partner#business_identity-1">LogicAppIntegrationAccountPartner#business_identity</a> Accepts: azurerm.IResolvable | azurerm.LogicAppIntegrationAccountPartner.LogicAppIntegrationAccountPartnerBusinessIdentity[]
        /// </summary>
        [<CustomOperation "business_identity">]
        member _.BusinessIdentity(state: LogicAppIntegrationAccountPartnerState<Missing, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : LogicAppIntegrationAccountPartnerState<Present, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BusinessIdentity <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountPartnerState<Present, 'IntegrationAccountName, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_partner#integration_account_name-1">LogicAppIntegrationAccountPartner#integration_account_name</a>.
        /// </summary>
        [<CustomOperation "integration_account_name">]
        member _.IntegrationAccountName(state: LogicAppIntegrationAccountPartnerState<'BusinessIdentity, Missing, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountPartnerState<'BusinessIdentity, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IntegrationAccountName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountPartnerState<'BusinessIdentity, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_partner#name-1">LogicAppIntegrationAccountPartner#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, Missing, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_partner#resource_group_name-1">LogicAppIntegrationAccountPartner#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, 'Name, Missing>, value: string) : LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_partner#id-1">LogicAppIntegrationAccountPartner#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_partner#metadata-1">LogicAppIntegrationAccountPartner#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Metadata <- value)
            state : LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_partner#timeouts-1">LogicAppIntegrationAccountPartner#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.LogicAppIntegrationAccountPartner.LogicAppIntegrationAccountPartnerTimeouts) : LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppIntegrationAccountPartnerState<'BusinessIdentity, 'IntegrationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: LogicAppIntegrationAccountPartnerState<Present, Present, Present, Present>) : azurerm.LogicAppIntegrationAccountPartner.LogicAppIntegrationAccountPartner =
            let config = azurerm.LogicAppIntegrationAccountPartner.LogicAppIntegrationAccountPartnerConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppIntegrationAccountPartner.LogicAppIntegrationAccountPartner(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppIntegrationAccountPartner: missing required arguments. Must call: business_identity, integration_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LogicAppIntegrationAccountPartnerState<_, _, _, _>) : azurerm.LogicAppIntegrationAccountPartner.LogicAppIntegrationAccountPartner =
            Unchecked.defaultof<azurerm.LogicAppIntegrationAccountPartner.LogicAppIntegrationAccountPartner>
