namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermBillingEnrollmentAccountScopeState<'BillingAccountName, 'EnrollmentAccountName> = { assignments: ResizeArray<azurerm.DataAzurermBillingEnrollmentAccountScope.DataAzurermBillingEnrollmentAccountScopeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_enrollment_account_scope">azurerm_billing_enrollment_account_scope</a>.
    /// </summary>
    type DataAzurermBillingEnrollmentAccountScopeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermBillingEnrollmentAccountScopeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBillingEnrollmentAccountScopeState<Missing, Missing>)

        member _.Zero(()) : DataAzurermBillingEnrollmentAccountScopeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBillingEnrollmentAccountScopeState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_enrollment_account_scope#billing_account_name-1">DataAzurermBillingEnrollmentAccountScope#billing_account_name</a>.
        /// </summary>
        [<CustomOperation "billing_account_name">]
        member _.BillingAccountName(state: DataAzurermBillingEnrollmentAccountScopeState<Missing, 'EnrollmentAccountName>, value: string) : DataAzurermBillingEnrollmentAccountScopeState<Present, 'EnrollmentAccountName> =
            state.assignments.Add(fun config -> config.BillingAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermBillingEnrollmentAccountScopeState<Present, 'EnrollmentAccountName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_enrollment_account_scope#enrollment_account_name-1">DataAzurermBillingEnrollmentAccountScope#enrollment_account_name</a>.
        /// </summary>
        [<CustomOperation "enrollment_account_name">]
        member _.EnrollmentAccountName(state: DataAzurermBillingEnrollmentAccountScopeState<'BillingAccountName, Missing>, value: string) : DataAzurermBillingEnrollmentAccountScopeState<'BillingAccountName, Present> =
            state.assignments.Add(fun config -> config.EnrollmentAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermBillingEnrollmentAccountScopeState<'BillingAccountName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_enrollment_account_scope#id-1">DataAzurermBillingEnrollmentAccountScope#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermBillingEnrollmentAccountScopeState<'BillingAccountName, 'EnrollmentAccountName>, value: string) : DataAzurermBillingEnrollmentAccountScopeState<'BillingAccountName, 'EnrollmentAccountName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermBillingEnrollmentAccountScopeState<'BillingAccountName, 'EnrollmentAccountName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_enrollment_account_scope#timeouts-1">DataAzurermBillingEnrollmentAccountScope#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermBillingEnrollmentAccountScopeState<'BillingAccountName, 'EnrollmentAccountName>, value: azurerm.DataAzurermBillingEnrollmentAccountScope.DataAzurermBillingEnrollmentAccountScopeTimeouts) : DataAzurermBillingEnrollmentAccountScopeState<'BillingAccountName, 'EnrollmentAccountName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermBillingEnrollmentAccountScopeState<'BillingAccountName, 'EnrollmentAccountName>

        member _.Run(state: DataAzurermBillingEnrollmentAccountScopeState<Present, Present>) : azurerm.DataAzurermBillingEnrollmentAccountScope.DataAzurermBillingEnrollmentAccountScope =
            let config = azurerm.DataAzurermBillingEnrollmentAccountScope.DataAzurermBillingEnrollmentAccountScopeConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermBillingEnrollmentAccountScope.DataAzurermBillingEnrollmentAccountScope(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermBillingEnrollmentAccountScope: missing required arguments. Must call: billing_account_name, enrollment_account_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermBillingEnrollmentAccountScopeState<_, _>) : azurerm.DataAzurermBillingEnrollmentAccountScope.DataAzurermBillingEnrollmentAccountScope =
            Unchecked.defaultof<azurerm.DataAzurermBillingEnrollmentAccountScope.DataAzurermBillingEnrollmentAccountScope>
