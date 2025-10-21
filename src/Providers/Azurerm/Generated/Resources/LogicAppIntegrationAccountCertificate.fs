namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.LogicAppIntegrationAccountCertificate.LogicAppIntegrationAccountCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_certificate">azurerm_logic_app_integration_account_certificate</a>.
    /// </summary>
    type LogicAppIntegrationAccountCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : LogicAppIntegrationAccountCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountCertificateState<Missing, Missing, Missing>)

        member _.Zero(()) : LogicAppIntegrationAccountCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LogicAppIntegrationAccountCertificateState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_certificate#integration_account_name-1">LogicAppIntegrationAccountCertificate#integration_account_name</a>.
        /// </summary>
        [<CustomOperation "integration_account_name">]
        member _.IntegrationAccountName(state: LogicAppIntegrationAccountCertificateState<Missing, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountCertificateState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IntegrationAccountName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountCertificateState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_certificate#name-1">LogicAppIntegrationAccountCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, Missing, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_certificate#resource_group_name-1">LogicAppIntegrationAccountCertificate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, Missing>, value: string) : LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_certificate#id-1">LogicAppIntegrationAccountCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// key_vault_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_certificate#key_vault_key-1">LogicAppIntegrationAccountCertificate#key_vault_key</a>
        /// </summary>
        [<CustomOperation "key_vault_key">]
        member _.KeyVaultKey(state: LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.LogicAppIntegrationAccountCertificate.LogicAppIntegrationAccountCertificateKeyVaultKey) : LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeyVaultKey <- value)
            state : LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_certificate#metadata-1">LogicAppIntegrationAccountCertificate#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Metadata <- value)
            state : LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_certificate#public_certificate-1">LogicAppIntegrationAccountCertificate#public_certificate</a>.
        /// </summary>
        [<CustomOperation "public_certificate">]
        member _.PublicCertificate(state: LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: string) : LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicCertificate <- value)
            state : LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/logic_app_integration_account_certificate#timeouts-1">LogicAppIntegrationAccountCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName>, value: azurerm.LogicAppIntegrationAccountCertificate.LogicAppIntegrationAccountCertificateTimeouts) : LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LogicAppIntegrationAccountCertificateState<'IntegrationAccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: LogicAppIntegrationAccountCertificateState<Present, Present, Present>) : azurerm.LogicAppIntegrationAccountCertificate.LogicAppIntegrationAccountCertificate =
            let config = azurerm.LogicAppIntegrationAccountCertificate.LogicAppIntegrationAccountCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.LogicAppIntegrationAccountCertificate.LogicAppIntegrationAccountCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.logicAppIntegrationAccountCertificate: missing required arguments. Must call: integration_account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: LogicAppIntegrationAccountCertificateState<_, _, _>) : azurerm.LogicAppIntegrationAccountCertificate.LogicAppIntegrationAccountCertificate =
            Unchecked.defaultof<azurerm.LogicAppIntegrationAccountCertificate.LogicAppIntegrationAccountCertificate>
