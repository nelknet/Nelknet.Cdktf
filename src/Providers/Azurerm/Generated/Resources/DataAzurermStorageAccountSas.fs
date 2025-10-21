namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start> = { assignments: ResizeArray<azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas">azurerm_storage_account_sas</a>.
    /// </summary>
    type DataAzurermStorageAccountSasBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageAccountSasState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageAccountSasState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermStorageAccountSasState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageAccountSasState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#connection_string-1">DataAzurermStorageAccountSas#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: DataAzurermStorageAccountSasState<Missing, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start>, value: string) : DataAzurermStorageAccountSasState<Present, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            ({ assignments = state.assignments } : DataAzurermStorageAccountSasState<Present, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#expiry-1">DataAzurermStorageAccountSas#expiry</a>.
        /// </summary>
        [<CustomOperation "expiry">]
        member _.Expiry(state: DataAzurermStorageAccountSasState<'ConnectionString, Missing, 'Permissions, 'ResourceTypes, 'Services, 'Start>, value: string) : DataAzurermStorageAccountSasState<'ConnectionString, Present, 'Permissions, 'ResourceTypes, 'Services, 'Start> =
            state.assignments.Add(fun config -> config.Expiry <- value)
            ({ assignments = state.assignments } : DataAzurermStorageAccountSasState<'ConnectionString, Present, 'Permissions, 'ResourceTypes, 'Services, 'Start>)

        /// <summary>
        /// permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#permissions-1">DataAzurermStorageAccountSas#permissions</a>
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, Missing, 'ResourceTypes, 'Services, 'Start>, value: azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSasPermissions) : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, Present, 'ResourceTypes, 'Services, 'Start> =
            state.assignments.Add(fun config -> config.Permissions <- value)
            ({ assignments = state.assignments } : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, Present, 'ResourceTypes, 'Services, 'Start>)

        /// <summary>
        /// resource_types block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#resource_types-1">DataAzurermStorageAccountSas#resource_types</a>
        /// </summary>
        [<CustomOperation "resource_types">]
        member _.ResourceTypes(state: DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, Missing, 'Services, 'Start>, value: azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSasResourceTypes) : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, Present, 'Services, 'Start> =
            state.assignments.Add(fun config -> config.ResourceTypes <- value)
            ({ assignments = state.assignments } : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, Present, 'Services, 'Start>)

        /// <summary>
        /// services block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#services-1">DataAzurermStorageAccountSas#services</a>
        /// </summary>
        [<CustomOperation "services">]
        member _.Services(state: DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, Missing, 'Start>, value: azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSasServices) : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, Present, 'Start> =
            state.assignments.Add(fun config -> config.Services <- value)
            ({ assignments = state.assignments } : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, Present, 'Start>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#start-1">DataAzurermStorageAccountSas#start</a>.
        /// </summary>
        [<CustomOperation "start">]
        member _.Start(state: DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, Missing>, value: string) : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, Present> =
            state.assignments.Add(fun config -> config.Start <- value)
            ({ assignments = state.assignments } : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#https_only-1">DataAzurermStorageAccountSas#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start>, value: bool) : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#https_only-1">DataAzurermStorageAccountSas#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start>, value: HashiCorp.Cdktf.IResolvable) : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#id-1">DataAzurermStorageAccountSas#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start>, value: string) : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#ip_addresses-1">DataAzurermStorageAccountSas#ip_addresses</a>.
        /// </summary>
        [<CustomOperation "ip_addresses">]
        member _.IpAddresses(state: DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start>, value: string) : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start> =
            state.assignments.Add(fun config -> config.IpAddresses <- value)
            state : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#signed_version-1">DataAzurermStorageAccountSas#signed_version</a>.
        /// </summary>
        [<CustomOperation "signed_version">]
        member _.SignedVersion(state: DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start>, value: string) : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start> =
            state.assignments.Add(fun config -> config.SignedVersion <- value)
            state : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_sas#timeouts-1">DataAzurermStorageAccountSas#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start>, value: azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSasTimeouts) : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageAccountSasState<'ConnectionString, 'Expiry, 'Permissions, 'ResourceTypes, 'Services, 'Start>

        member _.Run(state: DataAzurermStorageAccountSasState<Present, Present, Present, Present, Present, Present>) : azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSas =
            let config = azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSasConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSas(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageAccountSas: missing required arguments. Must call: connection_string, expiry, permissions, resource_types, services, start.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageAccountSasState<_, _, _, _, _, _>) : azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSas =
            Unchecked.defaultof<azurerm.DataAzurermStorageAccountSas.DataAzurermStorageAccountSas>
