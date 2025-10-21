namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName> = { assignments: ResizeArray<azurerm.StorageMoverJobDefinition.StorageMoverJobDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_job_definition">azurerm_storage_mover_job_definition</a>.
    /// </summary>
    type StorageMoverJobDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageMoverJobDefinitionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageMoverJobDefinitionState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StorageMoverJobDefinitionState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageMoverJobDefinitionState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_job_definition#copy_mode-1">StorageMoverJobDefinition#copy_mode</a>.
        /// </summary>
        [<CustomOperation "copy_mode">]
        member _.CopyMode(state: StorageMoverJobDefinitionState<Missing, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName>, value: string) : StorageMoverJobDefinitionState<Present, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName> =
            state.assignments.Add(fun config -> config.CopyMode <- value)
            ({ assignments = state.assignments } : StorageMoverJobDefinitionState<Present, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_job_definition#name-1">StorageMoverJobDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageMoverJobDefinitionState<'CopyMode, Missing, 'SourceName, 'StorageMoverProjectId, 'TargetName>, value: string) : StorageMoverJobDefinitionState<'CopyMode, Present, 'SourceName, 'StorageMoverProjectId, 'TargetName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageMoverJobDefinitionState<'CopyMode, Present, 'SourceName, 'StorageMoverProjectId, 'TargetName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_job_definition#source_name-1">StorageMoverJobDefinition#source_name</a>.
        /// </summary>
        [<CustomOperation "source_name">]
        member _.SourceName(state: StorageMoverJobDefinitionState<'CopyMode, 'Name, Missing, 'StorageMoverProjectId, 'TargetName>, value: string) : StorageMoverJobDefinitionState<'CopyMode, 'Name, Present, 'StorageMoverProjectId, 'TargetName> =
            state.assignments.Add(fun config -> config.SourceName <- value)
            ({ assignments = state.assignments } : StorageMoverJobDefinitionState<'CopyMode, 'Name, Present, 'StorageMoverProjectId, 'TargetName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_job_definition#storage_mover_project_id-1">StorageMoverJobDefinition#storage_mover_project_id</a>.
        /// </summary>
        [<CustomOperation "storage_mover_project_id">]
        member _.StorageMoverProjectId(state: StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, Missing, 'TargetName>, value: string) : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, Present, 'TargetName> =
            state.assignments.Add(fun config -> config.StorageMoverProjectId <- value)
            ({ assignments = state.assignments } : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, Present, 'TargetName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_job_definition#target_name-1">StorageMoverJobDefinition#target_name</a>.
        /// </summary>
        [<CustomOperation "target_name">]
        member _.TargetName(state: StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, Missing>, value: string) : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, Present> =
            state.assignments.Add(fun config -> config.TargetName <- value)
            ({ assignments = state.assignments } : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_job_definition#agent_name-1">StorageMoverJobDefinition#agent_name</a>.
        /// </summary>
        [<CustomOperation "agent_name">]
        member _.AgentName(state: StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName>, value: string) : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName> =
            state.assignments.Add(fun config -> config.AgentName <- value)
            state : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_job_definition#description-1">StorageMoverJobDefinition#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName>, value: string) : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_job_definition#id-1">StorageMoverJobDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName>, value: string) : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_job_definition#source_sub_path-1">StorageMoverJobDefinition#source_sub_path</a>.
        /// </summary>
        [<CustomOperation "source_sub_path">]
        member _.SourceSubPath(state: StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName>, value: string) : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName> =
            state.assignments.Add(fun config -> config.SourceSubPath <- value)
            state : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_job_definition#target_sub_path-1">StorageMoverJobDefinition#target_sub_path</a>.
        /// </summary>
        [<CustomOperation "target_sub_path">]
        member _.TargetSubPath(state: StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName>, value: string) : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName> =
            state.assignments.Add(fun config -> config.TargetSubPath <- value)
            state : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_mover_job_definition#timeouts-1">StorageMoverJobDefinition#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName>, value: azurerm.StorageMoverJobDefinition.StorageMoverJobDefinitionTimeouts) : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageMoverJobDefinitionState<'CopyMode, 'Name, 'SourceName, 'StorageMoverProjectId, 'TargetName>

        member _.Run(state: StorageMoverJobDefinitionState<Present, Present, Present, Present, Present>) : azurerm.StorageMoverJobDefinition.StorageMoverJobDefinition =
            let config = azurerm.StorageMoverJobDefinition.StorageMoverJobDefinitionConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageMoverJobDefinition.StorageMoverJobDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageMoverJobDefinition: missing required arguments. Must call: copy_mode, name, source_name, storage_mover_project_id, target_name.", 9999, IsError = true)>]
        member _.Run(_: StorageMoverJobDefinitionState<_, _, _, _, _>) : azurerm.StorageMoverJobDefinition.StorageMoverJobDefinition =
            Unchecked.defaultof<azurerm.StorageMoverJobDefinition.StorageMoverJobDefinition>
