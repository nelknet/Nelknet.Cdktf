namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId> = { assignments: ResizeArray<azurerm.AutomationConnectionServicePrincipal.AutomationConnectionServicePrincipalConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_service_principal">azurerm_automation_connection_service_principal</a>.
    /// </summary>
    type AutomationConnectionServicePrincipalBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutomationConnectionServicePrincipalState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationConnectionServicePrincipalState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AutomationConnectionServicePrincipalState<Missing, Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutomationConnectionServicePrincipalState<Missing, Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_service_principal#application_id-1">AutomationConnectionServicePrincipal#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: AutomationConnectionServicePrincipalState<Missing, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId>, value: string) : AutomationConnectionServicePrincipalState<Present, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : AutomationConnectionServicePrincipalState<Present, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_service_principal#automation_account_name-1">AutomationConnectionServicePrincipal#automation_account_name</a>.
        /// </summary>
        [<CustomOperation "automation_account_name">]
        member _.AutomationAccountName(state: AutomationConnectionServicePrincipalState<'ApplicationId, Missing, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId>, value: string) : AutomationConnectionServicePrincipalState<'ApplicationId, Present, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId> =
            state.assignments.Add(fun config -> config.AutomationAccountName <- value)
            ({ assignments = state.assignments } : AutomationConnectionServicePrincipalState<'ApplicationId, Present, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_service_principal#certificate_thumbprint-1">AutomationConnectionServicePrincipal#certificate_thumbprint</a>.
        /// </summary>
        [<CustomOperation "certificate_thumbprint">]
        member _.CertificateThumbprint(state: AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, Missing, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId>, value: string) : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, Present, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId> =
            state.assignments.Add(fun config -> config.CertificateThumbprint <- value)
            ({ assignments = state.assignments } : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, Present, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_service_principal#name-1">AutomationConnectionServicePrincipal#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, Missing, 'ResourceGroupName, 'SubscriptionId, 'TenantId>, value: string) : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, Present, 'ResourceGroupName, 'SubscriptionId, 'TenantId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, Present, 'ResourceGroupName, 'SubscriptionId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_service_principal#resource_group_name-1">AutomationConnectionServicePrincipal#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, Missing, 'SubscriptionId, 'TenantId>, value: string) : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, Present, 'SubscriptionId, 'TenantId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, Present, 'SubscriptionId, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_service_principal#subscription_id-1">AutomationConnectionServicePrincipal#subscription_id</a>.
        /// </summary>
        [<CustomOperation "subscription_id">]
        member _.SubscriptionId(state: AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, Missing, 'TenantId>, value: string) : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.SubscriptionId <- value)
            ({ assignments = state.assignments } : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_service_principal#tenant_id-1">AutomationConnectionServicePrincipal#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, Missing>, value: string) : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_service_principal#description-1">AutomationConnectionServicePrincipal#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId>, value: string) : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_service_principal#id-1">AutomationConnectionServicePrincipal#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId>, value: string) : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/automation_connection_service_principal#timeouts-1">AutomationConnectionServicePrincipal#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId>, value: azurerm.AutomationConnectionServicePrincipal.AutomationConnectionServicePrincipalTimeouts) : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutomationConnectionServicePrincipalState<'ApplicationId, 'AutomationAccountName, 'CertificateThumbprint, 'Name, 'ResourceGroupName, 'SubscriptionId, 'TenantId>

        member _.Run(state: AutomationConnectionServicePrincipalState<Present, Present, Present, Present, Present, Present, Present>) : azurerm.AutomationConnectionServicePrincipal.AutomationConnectionServicePrincipal =
            let config = azurerm.AutomationConnectionServicePrincipal.AutomationConnectionServicePrincipalConfig()
            for setter in state.assignments do
                setter config
            azurerm.AutomationConnectionServicePrincipal.AutomationConnectionServicePrincipal(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.automationConnectionServicePrincipal: missing required arguments. Must call: application_id, automation_account_name, certificate_thumbprint, name, resource_group_name, subscription_id, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: AutomationConnectionServicePrincipalState<_, _, _, _, _, _, _>) : azurerm.AutomationConnectionServicePrincipal.AutomationConnectionServicePrincipal =
            Unchecked.defaultof<azurerm.AutomationConnectionServicePrincipal.AutomationConnectionServicePrincipal>
