namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start> = { assignments: ResizeArray<azurerm.DataAzurermStorageAccountBlobContainerSas.DataAzurermStorageAccountBlobContainerSasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas">azurerm_storage_account_blob_container_sas</a>.
    /// </summary>
    type DataAzurermStorageAccountBlobContainerSasBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermStorageAccountBlobContainerSasState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageAccountBlobContainerSasState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataAzurermStorageAccountBlobContainerSasState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermStorageAccountBlobContainerSasState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#connection_string-1">DataAzurermStorageAccountBlobContainerSas#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: DataAzurermStorageAccountBlobContainerSasState<Missing, 'ContainerName, 'Expiry, 'Permissions, 'Start>, value: string) : DataAzurermStorageAccountBlobContainerSasState<Present, 'ContainerName, 'Expiry, 'Permissions, 'Start> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            ({ assignments = state.assignments } : DataAzurermStorageAccountBlobContainerSasState<Present, 'ContainerName, 'Expiry, 'Permissions, 'Start>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#container_name-1">DataAzurermStorageAccountBlobContainerSas#container_name</a>.
        /// </summary>
        [<CustomOperation "container_name">]
        member _.ContainerName(state: DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, Missing, 'Expiry, 'Permissions, 'Start>, value: string) : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, Present, 'Expiry, 'Permissions, 'Start> =
            state.assignments.Add(fun config -> config.ContainerName <- value)
            ({ assignments = state.assignments } : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, Present, 'Expiry, 'Permissions, 'Start>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#expiry-1">DataAzurermStorageAccountBlobContainerSas#expiry</a>.
        /// </summary>
        [<CustomOperation "expiry">]
        member _.Expiry(state: DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, Missing, 'Permissions, 'Start>, value: string) : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, Present, 'Permissions, 'Start> =
            state.assignments.Add(fun config -> config.Expiry <- value)
            ({ assignments = state.assignments } : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, Present, 'Permissions, 'Start>)

        /// <summary>
        /// permissions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#permissions-1">DataAzurermStorageAccountBlobContainerSas#permissions</a>
        /// </summary>
        [<CustomOperation "permissions">]
        member _.Permissions(state: DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, Missing, 'Start>, value: azurerm.DataAzurermStorageAccountBlobContainerSas.DataAzurermStorageAccountBlobContainerSasPermissions) : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, Present, 'Start> =
            state.assignments.Add(fun config -> config.Permissions <- value)
            ({ assignments = state.assignments } : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, Present, 'Start>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#start-1">DataAzurermStorageAccountBlobContainerSas#start</a>.
        /// </summary>
        [<CustomOperation "start">]
        member _.Start(state: DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, Missing>, value: string) : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, Present> =
            state.assignments.Add(fun config -> config.Start <- value)
            ({ assignments = state.assignments } : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#cache_control-1">DataAzurermStorageAccountBlobContainerSas#cache_control</a>.
        /// </summary>
        [<CustomOperation "cache_control">]
        member _.CacheControl(state: DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>, value: string) : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start> =
            state.assignments.Add(fun config -> config.CacheControl <- value)
            state : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#content_disposition-1">DataAzurermStorageAccountBlobContainerSas#content_disposition</a>.
        /// </summary>
        [<CustomOperation "content_disposition">]
        member _.ContentDisposition(state: DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>, value: string) : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start> =
            state.assignments.Add(fun config -> config.ContentDisposition <- value)
            state : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#content_encoding-1">DataAzurermStorageAccountBlobContainerSas#content_encoding</a>.
        /// </summary>
        [<CustomOperation "content_encoding">]
        member _.ContentEncoding(state: DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>, value: string) : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start> =
            state.assignments.Add(fun config -> config.ContentEncoding <- value)
            state : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#content_language-1">DataAzurermStorageAccountBlobContainerSas#content_language</a>.
        /// </summary>
        [<CustomOperation "content_language">]
        member _.ContentLanguage(state: DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>, value: string) : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start> =
            state.assignments.Add(fun config -> config.ContentLanguage <- value)
            state : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#content_type-1">DataAzurermStorageAccountBlobContainerSas#content_type</a>.
        /// </summary>
        [<CustomOperation "content_type">]
        member _.ContentType(state: DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>, value: string) : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start> =
            state.assignments.Add(fun config -> config.ContentType <- value)
            state : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#https_only-1">DataAzurermStorageAccountBlobContainerSas#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>, value: bool) : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#https_only-1">DataAzurermStorageAccountBlobContainerSas#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>, value: HashiCorp.Cdktf.IResolvable) : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#id-1">DataAzurermStorageAccountBlobContainerSas#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>, value: string) : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#ip_address-1">DataAzurermStorageAccountBlobContainerSas#ip_address</a>.
        /// </summary>
        [<CustomOperation "ip_address">]
        member _.IpAddress(state: DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>, value: string) : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start> =
            state.assignments.Add(fun config -> config.IpAddress <- value)
            state : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/storage_account_blob_container_sas#timeouts-1">DataAzurermStorageAccountBlobContainerSas#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>, value: azurerm.DataAzurermStorageAccountBlobContainerSas.DataAzurermStorageAccountBlobContainerSasTimeouts) : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermStorageAccountBlobContainerSasState<'ConnectionString, 'ContainerName, 'Expiry, 'Permissions, 'Start>

        member _.Run(state: DataAzurermStorageAccountBlobContainerSasState<Present, Present, Present, Present, Present>) : azurerm.DataAzurermStorageAccountBlobContainerSas.DataAzurermStorageAccountBlobContainerSas =
            let config = azurerm.DataAzurermStorageAccountBlobContainerSas.DataAzurermStorageAccountBlobContainerSasConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermStorageAccountBlobContainerSas.DataAzurermStorageAccountBlobContainerSas(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermStorageAccountBlobContainerSas: missing required arguments. Must call: connection_string, container_name, expiry, permissions, start.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermStorageAccountBlobContainerSasState<_, _, _, _, _>) : azurerm.DataAzurermStorageAccountBlobContainerSas.DataAzurermStorageAccountBlobContainerSas =
            Unchecked.defaultof<azurerm.DataAzurermStorageAccountBlobContainerSas.DataAzurermStorageAccountBlobContainerSas>
