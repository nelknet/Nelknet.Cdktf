namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId> = { assignments: ResizeArray<azurerm.MachineLearningDatastoreFileshare.MachineLearningDatastoreFileshareConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_fileshare">azurerm_machine_learning_datastore_fileshare</a>.
    /// </summary>
    type MachineLearningDatastoreFileshareBuilder(logicalId: string) =
        member _.Yield(_: unit) : MachineLearningDatastoreFileshareState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningDatastoreFileshareState<Missing, Missing, Missing>)

        member _.Zero(()) : MachineLearningDatastoreFileshareState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningDatastoreFileshareState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_fileshare#name-1">MachineLearningDatastoreFileshare#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MachineLearningDatastoreFileshareState<Missing, 'StorageFileshareId, 'WorkspaceId>, value: string) : MachineLearningDatastoreFileshareState<Present, 'StorageFileshareId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MachineLearningDatastoreFileshareState<Present, 'StorageFileshareId, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_fileshare#storage_fileshare_id-1">MachineLearningDatastoreFileshare#storage_fileshare_id</a>.
        /// </summary>
        [<CustomOperation "storage_fileshare_id">]
        member _.StorageFileshareId(state: MachineLearningDatastoreFileshareState<'Name, Missing, 'WorkspaceId>, value: string) : MachineLearningDatastoreFileshareState<'Name, Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.StorageFileshareId <- value)
            ({ assignments = state.assignments } : MachineLearningDatastoreFileshareState<'Name, Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_fileshare#workspace_id-1">MachineLearningDatastoreFileshare#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, Missing>, value: string) : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_fileshare#account_key-1">MachineLearningDatastoreFileshare#account_key</a>.
        /// </summary>
        [<CustomOperation "account_key">]
        member _.AccountKey(state: MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId>, value: string) : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.AccountKey <- value)
            state : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_fileshare#description-1">MachineLearningDatastoreFileshare#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId>, value: string) : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_fileshare#id-1">MachineLearningDatastoreFileshare#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId>, value: string) : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_fileshare#service_data_identity-1">MachineLearningDatastoreFileshare#service_data_identity</a>.
        /// </summary>
        [<CustomOperation "service_data_identity">]
        member _.ServiceDataIdentity(state: MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId>, value: string) : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ServiceDataIdentity <- value)
            state : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_fileshare#shared_access_signature-1">MachineLearningDatastoreFileshare#shared_access_signature</a>.
        /// </summary>
        [<CustomOperation "shared_access_signature">]
        member _.SharedAccessSignature(state: MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId>, value: string) : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.SharedAccessSignature <- value)
            state : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_fileshare#tags-1">MachineLearningDatastoreFileshare#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId>, value: seq<string * string>) : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_fileshare#timeouts-1">MachineLearningDatastoreFileshare#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId>, value: azurerm.MachineLearningDatastoreFileshare.MachineLearningDatastoreFileshareTimeouts) : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MachineLearningDatastoreFileshareState<'Name, 'StorageFileshareId, 'WorkspaceId>

        member _.Run(state: MachineLearningDatastoreFileshareState<Present, Present, Present>) : azurerm.MachineLearningDatastoreFileshare.MachineLearningDatastoreFileshare =
            let config = azurerm.MachineLearningDatastoreFileshare.MachineLearningDatastoreFileshareConfig()
            for setter in state.assignments do
                setter config
            azurerm.MachineLearningDatastoreFileshare.MachineLearningDatastoreFileshare(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.machineLearningDatastoreFileshare: missing required arguments. Must call: name, storage_fileshare_id, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: MachineLearningDatastoreFileshareState<_, _, _>) : azurerm.MachineLearningDatastoreFileshare.MachineLearningDatastoreFileshare =
            Unchecked.defaultof<azurerm.MachineLearningDatastoreFileshare.MachineLearningDatastoreFileshare>
