namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermBillingMpaAccountScopeState<'BillingAccountName, 'CustomerName> = { assignments: ResizeArray<azurerm.DataAzurermBillingMpaAccountScope.DataAzurermBillingMpaAccountScopeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_mpa_account_scope">azurerm_billing_mpa_account_scope</a>.
    /// </summary>
    type DataAzurermBillingMpaAccountScopeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermBillingMpaAccountScopeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBillingMpaAccountScopeState<Missing, Missing>)

        member _.Zero(()) : DataAzurermBillingMpaAccountScopeState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBillingMpaAccountScopeState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_mpa_account_scope#billing_account_name-1">DataAzurermBillingMpaAccountScope#billing_account_name</a>.
        /// </summary>
        [<CustomOperation "billing_account_name">]
        member _.BillingAccountName(state: DataAzurermBillingMpaAccountScopeState<Missing, 'CustomerName>, value: string) : DataAzurermBillingMpaAccountScopeState<Present, 'CustomerName> =
            state.assignments.Add(fun config -> config.BillingAccountName <- value)
            ({ assignments = state.assignments } : DataAzurermBillingMpaAccountScopeState<Present, 'CustomerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_mpa_account_scope#customer_name-1">DataAzurermBillingMpaAccountScope#customer_name</a>.
        /// </summary>
        [<CustomOperation "customer_name">]
        member _.CustomerName(state: DataAzurermBillingMpaAccountScopeState<'BillingAccountName, Missing>, value: string) : DataAzurermBillingMpaAccountScopeState<'BillingAccountName, Present> =
            state.assignments.Add(fun config -> config.CustomerName <- value)
            ({ assignments = state.assignments } : DataAzurermBillingMpaAccountScopeState<'BillingAccountName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_mpa_account_scope#id-1">DataAzurermBillingMpaAccountScope#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermBillingMpaAccountScopeState<'BillingAccountName, 'CustomerName>, value: string) : DataAzurermBillingMpaAccountScopeState<'BillingAccountName, 'CustomerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermBillingMpaAccountScopeState<'BillingAccountName, 'CustomerName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/billing_mpa_account_scope#timeouts-1">DataAzurermBillingMpaAccountScope#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermBillingMpaAccountScopeState<'BillingAccountName, 'CustomerName>, value: azurerm.DataAzurermBillingMpaAccountScope.DataAzurermBillingMpaAccountScopeTimeouts) : DataAzurermBillingMpaAccountScopeState<'BillingAccountName, 'CustomerName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermBillingMpaAccountScopeState<'BillingAccountName, 'CustomerName>

        member _.Run(state: DataAzurermBillingMpaAccountScopeState<Present, Present>) : azurerm.DataAzurermBillingMpaAccountScope.DataAzurermBillingMpaAccountScope =
            let config = azurerm.DataAzurermBillingMpaAccountScope.DataAzurermBillingMpaAccountScopeConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermBillingMpaAccountScope.DataAzurermBillingMpaAccountScope(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermBillingMpaAccountScope: missing required arguments. Must call: billing_account_name, customer_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermBillingMpaAccountScopeState<_, _>) : azurerm.DataAzurermBillingMpaAccountScope.DataAzurermBillingMpaAccountScope =
            Unchecked.defaultof<azurerm.DataAzurermBillingMpaAccountScope.DataAzurermBillingMpaAccountScope>
