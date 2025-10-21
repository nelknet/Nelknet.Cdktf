namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId> = { assignments: ResizeArray<azurerm.MachineLearningDatastoreDatalakeGen2.MachineLearningDatastoreDatalakeGen2Config -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_datalake_gen2">azurerm_machine_learning_datastore_datalake_gen2</a>.
    /// </summary>
    type MachineLearningDatastoreDatalakeGen2Builder(logicalId: string) =
        member _.Yield(_: unit) : MachineLearningDatastoreDatalakeGen2State<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningDatastoreDatalakeGen2State<Missing, Missing, Missing>)

        member _.Zero(()) : MachineLearningDatastoreDatalakeGen2State<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MachineLearningDatastoreDatalakeGen2State<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_datalake_gen2#name-1">MachineLearningDatastoreDatalakeGen2#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MachineLearningDatastoreDatalakeGen2State<Missing, 'StorageContainerId, 'WorkspaceId>, value: string) : MachineLearningDatastoreDatalakeGen2State<Present, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MachineLearningDatastoreDatalakeGen2State<Present, 'StorageContainerId, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_datalake_gen2#storage_container_id-1">MachineLearningDatastoreDatalakeGen2#storage_container_id</a>.
        /// </summary>
        [<CustomOperation "storage_container_id">]
        member _.StorageContainerId(state: MachineLearningDatastoreDatalakeGen2State<'Name, Missing, 'WorkspaceId>, value: string) : MachineLearningDatastoreDatalakeGen2State<'Name, Present, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.StorageContainerId <- value)
            ({ assignments = state.assignments } : MachineLearningDatastoreDatalakeGen2State<'Name, Present, 'WorkspaceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_datalake_gen2#workspace_id-1">MachineLearningDatastoreDatalakeGen2#workspace_id</a>.
        /// </summary>
        [<CustomOperation "workspace_id">]
        member _.WorkspaceId(state: MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, Missing>, value: string) : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, Present> =
            state.assignments.Add(fun config -> config.WorkspaceId <- value)
            ({ assignments = state.assignments } : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_datalake_gen2#authority_url-1">MachineLearningDatastoreDatalakeGen2#authority_url</a>.
        /// </summary>
        [<CustomOperation "authority_url">]
        member _.AuthorityUrl(state: MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>, value: string) : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.AuthorityUrl <- value)
            state : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_datalake_gen2#client_id-1">MachineLearningDatastoreDatalakeGen2#client_id</a>.
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>, value: string) : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ClientId <- value)
            state : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_datalake_gen2#client_secret-1">MachineLearningDatastoreDatalakeGen2#client_secret</a>.
        /// </summary>
        [<CustomOperation "client_secret">]
        member _.ClientSecret(state: MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>, value: string) : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ClientSecret <- value)
            state : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_datalake_gen2#description-1">MachineLearningDatastoreDatalakeGen2#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>, value: string) : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_datalake_gen2#id-1">MachineLearningDatastoreDatalakeGen2#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>, value: string) : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_datalake_gen2#service_data_identity-1">MachineLearningDatastoreDatalakeGen2#service_data_identity</a>.
        /// </summary>
        [<CustomOperation "service_data_identity">]
        member _.ServiceDataIdentity(state: MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>, value: string) : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.ServiceDataIdentity <- value)
            state : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_datalake_gen2#tags-1">MachineLearningDatastoreDatalakeGen2#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>, value: seq<string * string>) : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_datalake_gen2#tenant_id-1">MachineLearningDatastoreDatalakeGen2#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>, value: string) : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            state : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/machine_learning_datastore_datalake_gen2#timeouts-1">MachineLearningDatastoreDatalakeGen2#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>, value: azurerm.MachineLearningDatastoreDatalakeGen2.MachineLearningDatastoreDatalakeGen2Timeouts) : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MachineLearningDatastoreDatalakeGen2State<'Name, 'StorageContainerId, 'WorkspaceId>

        member _.Run(state: MachineLearningDatastoreDatalakeGen2State<Present, Present, Present>) : azurerm.MachineLearningDatastoreDatalakeGen2.MachineLearningDatastoreDatalakeGen2 =
            let config = azurerm.MachineLearningDatastoreDatalakeGen2.MachineLearningDatastoreDatalakeGen2Config()
            for setter in state.assignments do
                setter config
            azurerm.MachineLearningDatastoreDatalakeGen2.MachineLearningDatastoreDatalakeGen2(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.machineLearningDatastoreDatalakeGen2: missing required arguments. Must call: name, storage_container_id, workspace_id.", 9999, IsError = true)>]
        member _.Run(_: MachineLearningDatastoreDatalakeGen2State<_, _, _>) : azurerm.MachineLearningDatastoreDatalakeGen2.MachineLearningDatastoreDatalakeGen2 =
            Unchecked.defaultof<azurerm.MachineLearningDatastoreDatalakeGen2.MachineLearningDatastoreDatalakeGen2>
