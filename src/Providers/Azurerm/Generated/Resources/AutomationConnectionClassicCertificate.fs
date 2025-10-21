namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName> = { assignments: ResizeArray<azurerm.AutomationConnectionClassicCertificate.AutomationConnectionClassicCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_classic_certificate">azurerm_automation_connection_classic_certificate</a>.
    /// </summary>
    type AutomationConnectionClassicCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationConnectionClassicCertificateState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationConnectionClassicCertificateState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationConnectionClassicCertificateState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationConnectionClassicCertificateState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_classic_certificate#automation_account_name-1">AutomationConnectionClassicCertificate#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationConnectionClassicCertificateState<Missing, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName>, value: string) : AutomationConnectionClassicCertificateState<Present, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationConnectionClassicCertificateState<Present, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_classic_certificate#certificate_asset_name-1">AutomationConnectionClassicCertificate#certificate_asset_name</a>.
        /// </summary>
        [<CustomOperation "certificate_asset_name">]
        member _.CertificateAssetName(state: AutomationConnectionClassicCertificateState<'AutomationAccountName, Missing, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName>, value: string) : AutomationConnectionClassicCertificateState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName> =
            state.assignments.Add(fun config -> config.CertificateAssetName <- value)
            ({ assignments = state.assignments } : AutomationConnectionClassicCertificateState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_classic_certificate#name-1">AutomationConnectionClassicCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, Missing, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName>, value: string) : AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, Present, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, Present, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_classic_certificate#resource_group_name-1">AutomationConnectionClassicCertificate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, Missing, 'SubscriptionId, 'SubscriptionName>, value: string) : AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, Present, 'SubscriptionId, 'SubscriptionName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, Present, 'SubscriptionId, 'SubscriptionName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_classic_certificate#subscription_id-1">AutomationConnectionClassicCertificate#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, Missing, 'SubscriptionName>, value: string) : AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, Present, 'SubscriptionName> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            ({ assignments = state.assignments } : AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, Present, 'SubscriptionName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_classic_certificate#subscription_name-1">AutomationConnectionClassicCertificate#subscription_name</a>.
        /// </summary>
        [<CustomOperation "subscription_name">]
        member _.SubscriptionName(state: AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, Missing>, value: string) : AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, Present> =
            state.assignments.Add(fun config -> config.SubscriptionName <- value)
            ({ assignments = state.assignments } : AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_classic_certificate#description-1">AutomationConnectionClassicCertificate#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName>, value: string) : AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_classic_certificate#id-1">AutomationConnectionClassicCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName>, value: string) : AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_classic_certificate#timeouts-1">AutomationConnectionClassicCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName>, value: azurerm.AutomationConnectionClassicCertificate.AutomationConnectionClassicCertificateTimeouts) : AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationConnectionClassicCertificateState<'AutomationAccountName, 'CertificateAssetName, 'Name, 'ResourceGroupName, 'SubscriptionId, 'SubscriptionName>

        member _.Run(state: AutomationConnectionClassicCertificateState<Present, Present, Present, Present, Present, Present>) : azurerm.AutomationConnectionClassicCertificate.AutomationConnectionClassicCertificate =
            let config = azurerm.AutomationConnectionClassicCertificate.AutomationConnectionClassicCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationConnectionClassicCertificate.AutomationConnectionClassicCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationConnectionClassicCertificate: missing required arguments. Must call: automation_account_name, certificate_asset_name, name, resource_group_name, subscription_id, subscription_name.", 9999, IsError = true)>]
        member _.Run(_: AutomationConnectionClassicCertificateState<_, _, _, _, _, _>) : azurerm.AutomationConnectionClassicCertificate.AutomationConnectionClassicCertificate =
            Unchecked.defaultof<azurerm.AutomationConnectionClassicCertificate.AutomationConnectionClassicCertificate>
