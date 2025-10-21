namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermBatchCertificateState<'AccountName, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermBatchCertificate.DataAzurermBatchCertificateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_certificate">azurerm_batch_certificate</a>.
    /// </summary>
    type DataAzurermBatchCertificateBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermBatchCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBatchCertificateState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermBatchCertificateState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermBatchCertificateState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_certificate#account_name-1">DataAzurermBatchCertificate#account_name</a>.
        /// </summary>
        [<CustomOperation "account_name">]
        member _.AccountName(state: DataAzurermBatchCertificateState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataAzurermBatchCertificateState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountName <- value)
            ({ assignments = state.assignments } : DataAzurermBatchCertificateState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_certificate#name-1">DataAzurermBatchCertificate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermBatchCertificateState<'AccountName, Missing, 'ResourceGroupName>, value: string) : DataAzurermBatchCertificateState<'AccountName, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermBatchCertificateState<'AccountName, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_certificate#resource_group_name-1">DataAzurermBatchCertificate#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermBatchCertificateState<'AccountName, 'Name, Missing>, value: string) : DataAzurermBatchCertificateState<'AccountName, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermBatchCertificateState<'AccountName, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_certificate#id-1">DataAzurermBatchCertificate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermBatchCertificateState<'AccountName, 'Name, 'ResourceGroupName>, value: string) : DataAzurermBatchCertificateState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermBatchCertificateState<'AccountName, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/batch_certificate#timeouts-1">DataAzurermBatchCertificate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermBatchCertificateState<'AccountName, 'Name, 'ResourceGroupName>, value: azurerm.DataAzurermBatchCertificate.DataAzurermBatchCertificateTimeouts) : DataAzurermBatchCertificateState<'AccountName, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermBatchCertificateState<'AccountName, 'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermBatchCertificateState<Present, Present, Present>) : azurerm.DataAzurermBatchCertificate.DataAzurermBatchCertificate =
            let config = azurerm.DataAzurermBatchCertificate.DataAzurermBatchCertificateConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermBatchCertificate.DataAzurermBatchCertificate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermBatchCertificate: missing required arguments. Must call: account_name, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermBatchCertificateState<_, _, _>) : azurerm.DataAzurermBatchCertificate.DataAzurermBatchCertificate =
            Unchecked.defaultof<azurerm.DataAzurermBatchCertificate.DataAzurermBatchCertificate>
