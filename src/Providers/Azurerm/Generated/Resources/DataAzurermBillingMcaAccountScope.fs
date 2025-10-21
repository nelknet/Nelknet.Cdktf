namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermBillingMcaAccountScopeState<'BillingAccountName, 'BillingProfileName, 'InvoiceSectionName> = { assignments: ResizeArray<azurerm.DataAzurermBillingMcaAccountScope.DataAzurermBillingMcaAccountScopeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_mca_account_scope">azurerm_billing_mca_account_scope</a>.
    /// </summary>
    type DataAzurermBillingMcaAccountScopeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermBillingMcaAccountScopeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBillingMcaAccountScopeState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermBillingMcaAccountScopeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBillingMcaAccountScopeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_mca_account_scope#billing_account_name-1">DataAzurermBillingMcaAccountScope#billing_account_name</a>.
        /// </summary>
        [<CustomOperation "billing_account_name">]
        member _.BillingAccountName(state: DataAzurermBillingMcaAccountScopeState<Missing, 'BillingProfileName, 'InvoiceSectionName>, value: string) : DataAzurermBillingMcaAccountScopeState<Present, 'BillingProfileName, 'InvoiceSectionName> =
            state.assignments.Add(fun config -> config.BillingAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermBillingMcaAccountScopeState<Present, 'BillingProfileName, 'InvoiceSectionName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_mca_account_scope#billing_profile_name-1">DataAzurermBillingMcaAccountScope#billing_profile_name</a>.
        /// </summary>
        [<CustomOperation "billing_profile_name">]
        member _.BillingProfileName(state: DataAzurermBillingMcaAccountScopeState<'BillingAccountName, Missing, 'InvoiceSectionName>, value: string) : DataAzurermBillingMcaAccountScopeState<'BillingAccountName, Present, 'InvoiceSectionName> =
            state.assignments.Add(fun config -> config.BillingProfileName <- value)
            ({ assignments = state.assignments } : DataAzurermBillingMcaAccountScopeState<'BillingAccountName, Present, 'InvoiceSectionName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_mca_account_scope#invoice_section_name-1">DataAzurermBillingMcaAccountScope#invoice_section_name</a>.
        /// </summary>
        [<CustomOperation "invoice_section_name">]
        member _.InvoiceSectionName(state: DataAzurermBillingMcaAccountScopeState<'BillingAccountName, 'BillingProfileName, Missing>, value: string) : DataAzurermBillingMcaAccountScopeState<'BillingAccountName, 'BillingProfileName, Present> =
            state.assignments.Add(fun config -> config.InvoiceSectionName <- value)
            ({ assignments = state.assignments } : DataAzurermBillingMcaAccountScopeState<'BillingAccountName, 'BillingProfileName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_mca_account_scope#id-1">DataAzurermBillingMcaAccountScope#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermBillingMcaAccountScopeState<'BillingAccountName, 'BillingProfileName, 'InvoiceSectionName>, value: string) : DataAzurermBillingMcaAccountScopeState<'BillingAccountName, 'BillingProfileName, 'InvoiceSectionName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermBillingMcaAccountScopeState<'BillingAccountName, 'BillingProfileName, 'InvoiceSectionName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_mca_account_scope#timeouts-1">DataAzurermBillingMcaAccountScope#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermBillingMcaAccountScopeState<'BillingAccountName, 'BillingProfileName, 'InvoiceSectionName>, value: azurerm.DataAzurermBillingMcaAccountScope.DataAzurermBillingMcaAccountScopeTimeouts) : DataAzurermBillingMcaAccountScopeState<'BillingAccountName, 'BillingProfileName, 'InvoiceSectionName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermBillingMcaAccountScopeState<'BillingAccountName, 'BillingProfileName, 'InvoiceSectionName>

        member _.Run(state: DataAzurermBillingMcaAccountScopeState<Present, Present, Present>) : azurerm.DataAzurermBillingMcaAccountScope.DataAzurermBillingMcaAccountScope =
            let config = azurerm.DataAzurermBillingMcaAccountScope.DataAzurermBillingMcaAccountScopeConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermBillingMcaAccountScope.DataAzurermBillingMcaAccountScope(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermBillingMcaAccountScope: missing required arguments. Must call: billing_account_name, billing_profile_name, invoice_section_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermBillingMcaAccountScopeState<_, _, _>) : azurerm.DataAzurermBillingMcaAccountScope.DataAzurermBillingMcaAccountScope =
            Unchecked.defaultof<azurerm.DataAzurermBillingMcaAccountScope.DataAzurermBillingMcaAccountScope>
