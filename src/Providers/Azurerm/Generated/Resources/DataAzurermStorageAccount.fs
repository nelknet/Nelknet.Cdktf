namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageAccountState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermStorageAccount.DataAzurermStorageAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account">azurerm_storage_account</a>.
    /// </summary>
    type DataAzurermStorageAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageAccountState<Missing, Missing>)

        member _.Zero(()) : DataAzurermStorageAccountState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageAccountState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account#name-1">DataAzurermStorageAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermStorageAccountState<Missing, 'ResourceGroupName>, value: string) : DataAzurermStorageAccountState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermStorageAccountState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account#resource_group_name-1">DataAzurermStorageAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermStorageAccountState<'Name, Missing>, value: string) : DataAzurermStorageAccountState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermStorageAccountState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account#id-1">DataAzurermStorageAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStorageAccountState<'Name, 'ResourceGroupName>, value: string) : DataAzurermStorageAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStorageAccountState<'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account#min_tls_version-1">DataAzurermStorageAccount#min_tls_version</a>.
        /// </summary>
        [<CustomOperation "min_tls_version">]
        member _.MinTlsVersion(state: DataAzurermStorageAccountState<'Name, 'ResourceGroupName>, value: string) : DataAzurermStorageAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MinTlsVersion <- value)
            state : DataAzurermStorageAccountState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account#timeouts-1">DataAzurermStorageAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageAccountState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermStorageAccount.DataAzurermStorageAccountTimeouts) : DataAzurermStorageAccountState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageAccountState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermStorageAccountState<Present, Present>) : azurerm.DataAzurermStorageAccount.DataAzurermStorageAccount =
            let config = azurerm.DataAzurermStorageAccount.DataAzurermStorageAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageAccount.DataAzurermStorageAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageAccount: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageAccountState<_, _>) : azurerm.DataAzurermStorageAccount.DataAzurermStorageAccount =
            Unchecked.defaultof<azurerm.DataAzurermStorageAccount.DataAzurermStorageAccount>
