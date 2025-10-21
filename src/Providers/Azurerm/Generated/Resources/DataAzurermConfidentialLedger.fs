namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermConfidentialLedgerState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedgerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/confidential_ledger">azurerm_confidential_ledger</a>.
    /// </summary>
    type DataAzurermConfidentialLedgerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermConfidentialLedgerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermConfidentialLedgerState<Missing, Missing>)

        member _.Zero(()) : DataAzurermConfidentialLedgerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermConfidentialLedgerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/confidential_ledger#name-1">DataAzurermConfidentialLedger#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermConfidentialLedgerState<Missing, 'ResourceGroupName>, value: string) : DataAzurermConfidentialLedgerState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermConfidentialLedgerState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/confidential_ledger#resource_group_name-1">DataAzurermConfidentialLedger#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermConfidentialLedgerState<'Name, Missing>, value: string) : DataAzurermConfidentialLedgerState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermConfidentialLedgerState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/confidential_ledger#id-1">DataAzurermConfidentialLedger#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermConfidentialLedgerState<'Name, 'ResourceGroupName>, value: string) : DataAzurermConfidentialLedgerState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermConfidentialLedgerState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/confidential_ledger#timeouts-1">DataAzurermConfidentialLedger#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermConfidentialLedgerState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedgerTimeouts) : DataAzurermConfidentialLedgerState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermConfidentialLedgerState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermConfidentialLedgerState<Present, Present>) : azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedger =
            let config = azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedgerConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedger(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermConfidentialLedger: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermConfidentialLedgerState<_, _>) : azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedger =
            Unchecked.defaultof<azurerm.DataAzurermConfidentialLedger.DataAzurermConfidentialLedger>
