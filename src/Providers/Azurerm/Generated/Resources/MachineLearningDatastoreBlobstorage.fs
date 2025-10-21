namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId> = { assignments: ResizeArray<azurerm.MachineLearningDatastoreBlobstorage.MachineLearningDatastoreBlobstorageConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_blobstorage">azurerm_machine_learning_datastore_blobstorage</a>.
    /// </summary>
    type MachineLearningDatastoreBlobstorageBuilder(logicalId: string) =
        member _.Yield(_: unit) : MachineLearningDatastoreBlobstorageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningDatastoreBlobstorageState<Missing, Missing, Missing>)

        member _.Zero(()) : MachineLearningDatastoreBlobstorageState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningDatastoreBlobstorageState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_blobstorage#name-1">MachineLearningDatastoreBlobstorage#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MachineLearningDatastoreBlobstorageState<Missing, 'StorageContainerId, 'WorkspaceId>, value: string) : MachineLearningDatastoreBlobstorageState<Present, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MachineLearningDatastoreBlobstorageState<Present, 'StorageContainerId, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_blobstorage#storage_container_id-1">MachineLearningDatastoreBlobstorage#storage_container_id</a>.
        /// </summary>
        [<CustomOperation "storage_container_id">]
        member _.StorageContainerId(state: MachineLearningDatastoreBlobstorageState<'Name, Missing, 'WorkspaceId>, value: string) : MachineLearningDatastoreBlobstorageState<'Name, Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.StorageContainerId <- value)
            ({ assignments = state.assignments } : MachineLearningDatastoreBlobstorageState<'Name, Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_blobstorage#workspace_id-1">MachineLearningDatastoreBlobstorage#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, Missing>, value: string) : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_blobstorage#account_key-1">MachineLearningDatastoreBlobstorage#account_key</a>.
        /// </summary>
        [<CustomOperation "account_key">]
        member _.AccountKey(state: MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>, value: string) : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.AccountKey <- value)
            state : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_blobstorage#description-1">MachineLearningDatastoreBlobstorage#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>, value: string) : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_blobstorage#id-1">MachineLearningDatastoreBlobstorage#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>, value: string) : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_blobstorage#is_default-1">MachineLearningDatastoreBlobstorage#is_default</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_default">]
        member _.IsDefault(state: MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>, value: bool) : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.IsDefault <- value)
            state : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_blobstorage#is_default-1">MachineLearningDatastoreBlobstorage#is_default</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_default">]
        member _.IsDefault(state: MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>, value: HashiCorp.Cdktf.IResolvable) : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.IsDefault <- value)
            state : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_blobstorage#service_data_auth_identity-1">MachineLearningDatastoreBlobstorage#service_data_auth_identity</a>.
        /// </summary>
        [<CustomOperation "service_data_auth_identity">]
        member _.ServiceDataAuthIdentity(state: MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>, value: string) : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ServiceDataAuthIdentity <- value)
            state : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_blobstorage#shared_access_signature-1">MachineLearningDatastoreBlobstorage#shared_access_signature</a>.
        /// </summary>
        [<CustomOperation "shared_access_signature">]
        member _.SharedAccessSignature(state: MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>, value: string) : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.SharedAccessSignature <- value)
            state : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_blobstorage#tags-1">MachineLearningDatastoreBlobstorage#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>, value: seq<string * string>) : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_blobstorage#timeouts-1">MachineLearningDatastoreBlobstorage#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>, value: azurerm.MachineLearningDatastoreBlobstorage.MachineLearningDatastoreBlobstorageTimeouts) : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MachineLearningDatastoreBlobstorageState<'Name, 'StorageContainerId, 'WorkspaceId>

        member _.Run(state: MachineLearningDatastoreBlobstorageState<Present, Present, Present>) : azurerm.MachineLearningDatastoreBlobstorage.MachineLearningDatastoreBlobstorage =
            let config = azurerm.MachineLearningDatastoreBlobstorage.MachineLearningDatastoreBlobstorageConfig()
            for setter in state.assignments do
                setter config
            azurerm.MachineLearningDatastoreBlobstorage.MachineLearningDatastoreBlobstorage(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.machineLearningDatastoreBlobstorage: missing required arguments. Must call: name, storage_container_id, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: MachineLearningDatastoreBlobstorageState<_, _, _>) : azurerm.MachineLearningDatastoreBlobstorage.MachineLearningDatastoreBlobstorage =
            Unchecked.defaultof<azurerm.MachineLearningDatastoreBlobstorage.MachineLearningDatastoreBlobstorage>
