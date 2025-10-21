namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, 'ResourceGroupName, 'SubscriptionId> = { assignments: ResizeArray<azurerm.AutomationConnectionCertificate.AutomationConnectionCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_certificate">azurerm_automation_connection_certificate</a>.
    /// </summary>
    type AutomationConnectionCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationConnectionCertificateState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationConnectionCertificateState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationConnectionCertificateState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationConnectionCertificateState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_certificate#automation_account_name-1">AutomationConnectionCertificate#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationConnectionCertificateState<Missing, 'AutomationCertificateName, 'Name, 'ResourceGroupName, 'SubscriptionId>, value: string) : AutomationConnectionCertificateState<Present, 'AutomationCertificateName, 'Name, 'ResourceGroupName, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationConnectionCertificateState<Present, 'AutomationCertificateName, 'Name, 'ResourceGroupName, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_certificate#automation_certificate_name-1">AutomationConnectionCertificate#automation_certificate_name</a>.
        /// </summary>
        [<CustomOperation "automation_certificate_name">]
        member _.AutomationCertificateName(state: AutomationConnectionCertificateState<'AutomationAccountName, Missing, 'Name, 'ResourceGroupName, 'SubscriptionId>, value: string) : AutomationConnectionCertificateState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.AutomationCertificateName <- value)
            ({ assignments = state.assignments } : AutomationConnectionCertificateState<'AutomationAccountName, Present, 'Name, 'ResourceGroupName, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_certificate#name-1">AutomationConnectionCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, Missing, 'ResourceGroupName, 'SubscriptionId>, value: string) : AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, Present, 'ResourceGroupName, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, Present, 'ResourceGroupName, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_certificate#resource_group_name-1">AutomationConnectionCertificate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, Missing, 'SubscriptionId>, value: string) : AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, Present, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, Present, 'SubscriptionId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_certificate#subscription_id-1">AutomationConnectionCertificate#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, 'ResourceGroupName, Missing>, value: string) : AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            ({ assignments = state.assignments } : AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_certificate#description-1">AutomationConnectionCertificate#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, 'ResourceGroupName, 'SubscriptionId>, value: string) : AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, 'ResourceGroupName, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, 'ResourceGroupName, 'SubscriptionId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_certificate#id-1">AutomationConnectionCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, 'ResourceGroupName, 'SubscriptionId>, value: string) : AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, 'ResourceGroupName, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, 'ResourceGroupName, 'SubscriptionId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_certificate#timeouts-1">AutomationConnectionCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, 'ResourceGroupName, 'SubscriptionId>, value: azurerm.AutomationConnectionCertificate.AutomationConnectionCertificateTimeouts) : AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, 'ResourceGroupName, 'SubscriptionId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationConnectionCertificateState<'AutomationAccountName, 'AutomationCertificateName, 'Name, 'ResourceGroupName, 'SubscriptionId>

        member _.Run(state: AutomationConnectionCertificateState<Present, Present, Present, Present, Present>) : azurerm.AutomationConnectionCertificate.AutomationConnectionCertificate =
            let config = azurerm.AutomationConnectionCertificate.AutomationConnectionCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationConnectionCertificate.AutomationConnectionCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationConnectionCertificate: missing required arguments. Must call: automation_account_name, automation_certificate_name, name, resource_group_name, subscription_id.", 9999, IsError = true)>]
        member _.Run(_: AutomationConnectionCertificateState<_, _, _, _, _>) : azurerm.AutomationConnectionCertificate.AutomationConnectionCertificate =
            Unchecked.defaultof<azurerm.AutomationConnectionCertificate.AutomationConnectionCertificate>
