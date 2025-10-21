namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage">azurerm_data_factory_linked_service_azure_blob_storage</a>.
    /// </summary>
    type DataFactoryLinkedServiceAzureBlobStorageBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryLinkedServiceAzureBlobStorageState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceAzureBlobStorageState<Missing, Missing>)

        member _.Zero(()) : DataFactoryLinkedServiceAzureBlobStorageState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryLinkedServiceAzureBlobStorageState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#data_factory_id-1">DataFactoryLinkedServiceAzureBlobStorage#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryLinkedServiceAzureBlobStorageState<Missing, 'Name>, value: string) : DataFactoryLinkedServiceAzureBlobStorageState<Present, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureBlobStorageState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#name-1">DataFactoryLinkedServiceAzureBlobStorage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, Missing>, value: string) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#additional_properties-1">DataFactoryLinkedServiceAzureBlobStorage#additional_properties</a>.
        /// </summary>
        [<CustomOperation "additional_properties">]
        member _.AdditionalProperties(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.AdditionalProperties <- dict value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#annotations-1">DataFactoryLinkedServiceAzureBlobStorage#annotations</a>.
        /// </summary>
        [<CustomOperation "annotations">]
        member _.Annotations(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: seq<string>) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Annotations <- (value |> Seq.toArray))
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#connection_string-1">DataFactoryLinkedServiceAzureBlobStorage#connection_string</a>.
        /// </summary>
        [<CustomOperation "connection_string">]
        member _.ConnectionString(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionString <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#connection_string_insecure-1">DataFactoryLinkedServiceAzureBlobStorage#connection_string_insecure</a>.
        /// </summary>
        [<CustomOperation "connection_string_insecure">]
        member _.ConnectionStringInsecure(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ConnectionStringInsecure <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#description-1">DataFactoryLinkedServiceAzureBlobStorage#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#id-1">DataFactoryLinkedServiceAzureBlobStorage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#integration_runtime_name-1">DataFactoryLinkedServiceAzureBlobStorage#integration_runtime_name</a>.
        /// </summary>
        [<CustomOperation "integration_runtime_name">]
        member _.IntegrationRuntimeName(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.IntegrationRuntimeName <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// key_vault_sas_token block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#key_vault_sas_token-1">DataFactoryLinkedServiceAzureBlobStorage#key_vault_sas_token</a>
        /// </summary>
        [<CustomOperation "key_vault_sas_token">]
        member _.KeyVaultSasToken(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorageKeyVaultSasToken) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.KeyVaultSasToken <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#parameters-1">DataFactoryLinkedServiceAzureBlobStorage#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: seq<string * string>) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#sas_uri-1">DataFactoryLinkedServiceAzureBlobStorage#sas_uri</a>.
        /// </summary>
        [<CustomOperation "sas_uri">]
        member _.SasUri(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.SasUri <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#service_endpoint-1">DataFactoryLinkedServiceAzureBlobStorage#service_endpoint</a>.
        /// </summary>
        [<CustomOperation "service_endpoint">]
        member _.ServiceEndpoint(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ServiceEndpoint <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#service_principal_id-1">DataFactoryLinkedServiceAzureBlobStorage#service_principal_id</a>.
        /// </summary>
        [<CustomOperation "service_principal_id">]
        member _.ServicePrincipalId(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ServicePrincipalId <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#service_principal_key-1">DataFactoryLinkedServiceAzureBlobStorage#service_principal_key</a>.
        /// </summary>
        [<CustomOperation "service_principal_key">]
        member _.ServicePrincipalKey(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ServicePrincipalKey <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// service_principal_linked_key_vault_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#service_principal_linked_key_vault_key-1">DataFactoryLinkedServiceAzureBlobStorage#service_principal_linked_key_vault_key</a>
        /// </summary>
        [<CustomOperation "service_principal_linked_key_vault_key">]
        member _.ServicePrincipalLinkedKeyVaultKey(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorageServicePrincipalLinkedKeyVaultKey) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.ServicePrincipalLinkedKeyVaultKey <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#storage_kind-1">DataFactoryLinkedServiceAzureBlobStorage#storage_kind</a>.
        /// </summary>
        [<CustomOperation "storage_kind">]
        member _.StorageKind(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.StorageKind <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#tenant_id-1">DataFactoryLinkedServiceAzureBlobStorage#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: string) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#timeouts-1">DataFactoryLinkedServiceAzureBlobStorage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: azurerm.DataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorageTimeouts) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#use_managed_identity-1">DataFactoryLinkedServiceAzureBlobStorage#use_managed_identity</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_managed_identity">]
        member _.UseManagedIdentity(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: bool) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.UseManagedIdentity <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_linked_service_azure_blob_storage#use_managed_identity-1">DataFactoryLinkedServiceAzureBlobStorage#use_managed_identity</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "use_managed_identity">]
        member _.UseManagedIdentity(state: DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name> =
            state.assignments.Add(fun config -> config.UseManagedIdentity <- value)
            state : DataFactoryLinkedServiceAzureBlobStorageState<'DataFactoryId, 'Name>

        member _.Run(state: DataFactoryLinkedServiceAzureBlobStorageState<Present, Present>) : azurerm.DataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorage =
            let config = azurerm.DataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorageConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryLinkedServiceAzureBlobStorage: missing required arguments. Must call: data_factory_id, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryLinkedServiceAzureBlobStorageState<_, _>) : azurerm.DataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorage =
            Unchecked.defaultof<azurerm.DataFactoryLinkedServiceAzureBlobStorage.DataFactoryLinkedServiceAzureBlobStorage>
