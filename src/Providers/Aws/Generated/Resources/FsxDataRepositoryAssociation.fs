namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath> = { assignments: ResizeArray<aws.FsxDataRepositoryAssociation.FsxDataRepositoryAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association">aws_fsx_data_repository_association</a>.
    /// </summary>
    type FsxDataRepositoryAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : FsxDataRepositoryAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxDataRepositoryAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : FsxDataRepositoryAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxDataRepositoryAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#data_repository_path-1">FsxDataRepositoryAssociation#data_repository_path</a>.
        /// </summary>
        [<CustomOperation "data_repository_path">]
        member _.DataRepositoryPath(state: FsxDataRepositoryAssociationState<Missing, 'FileSystemId, 'FileSystemPath>, value: string) : FsxDataRepositoryAssociationState<Present, 'FileSystemId, 'FileSystemPath> =
            state.assignments.Add(fun config -> config.DataRepositoryPath <- value)
            ({ assignments = state.assignments } : FsxDataRepositoryAssociationState<Present, 'FileSystemId, 'FileSystemPath>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#file_system_id-1">FsxDataRepositoryAssociation#file_system_id</a>.
        /// </summary>
        [<CustomOperation "file_system_id">]
        member _.FileSystemId(state: FsxDataRepositoryAssociationState<'DataRepositoryPath, Missing, 'FileSystemPath>, value: string) : FsxDataRepositoryAssociationState<'DataRepositoryPath, Present, 'FileSystemPath> =
            state.assignments.Add(fun config -> config.FileSystemId <- value)
            ({ assignments = state.assignments } : FsxDataRepositoryAssociationState<'DataRepositoryPath, Present, 'FileSystemPath>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#file_system_path-1">FsxDataRepositoryAssociation#file_system_path</a>.
        /// </summary>
        [<CustomOperation "file_system_path">]
        member _.FileSystemPath(state: FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, Missing>, value: string) : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, Present> =
            state.assignments.Add(fun config -> config.FileSystemPath <- value)
            ({ assignments = state.assignments } : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#batch_import_meta_data_on_create-1">FsxDataRepositoryAssociation#batch_import_meta_data_on_create</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "batch_import_meta_data_on_create">]
        member _.BatchImportMetaDataOnCreate(state: FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>, value: bool) : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath> =
            state.assignments.Add(fun config -> config.BatchImportMetaDataOnCreate <- value)
            state : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#batch_import_meta_data_on_create-1">FsxDataRepositoryAssociation#batch_import_meta_data_on_create</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "batch_import_meta_data_on_create">]
        member _.BatchImportMetaDataOnCreate(state: FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>, value: HashiCorp.Cdktf.IResolvable) : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath> =
            state.assignments.Add(fun config -> config.BatchImportMetaDataOnCreate <- value)
            state : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#delete_data_in_filesystem-1">FsxDataRepositoryAssociation#delete_data_in_filesystem</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_data_in_filesystem">]
        member _.DeleteDataInFilesystem(state: FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>, value: bool) : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath> =
            state.assignments.Add(fun config -> config.DeleteDataInFilesystem <- value)
            state : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#delete_data_in_filesystem-1">FsxDataRepositoryAssociation#delete_data_in_filesystem</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "delete_data_in_filesystem">]
        member _.DeleteDataInFilesystem(state: FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>, value: HashiCorp.Cdktf.IResolvable) : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath> =
            state.assignments.Add(fun config -> config.DeleteDataInFilesystem <- value)
            state : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#id-1">FsxDataRepositoryAssociation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>, value: string) : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#imported_file_chunk_size-1">FsxDataRepositoryAssociation#imported_file_chunk_size</a>.
        /// </summary>
        [<CustomOperation "imported_file_chunk_size">]
        member _.ImportedFileChunkSize(state: FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>, value: double) : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath> =
            state.assignments.Add(fun config -> config.ImportedFileChunkSize <- value)
            state : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>

        /// <summary>
        /// s3 block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#s3-1">FsxDataRepositoryAssociation#s3</a>
        /// </summary>
        [<CustomOperation "s3">]
        member _.S3(state: FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>, value: aws.FsxDataRepositoryAssociation.FsxDataRepositoryAssociationS3) : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath> =
            state.assignments.Add(fun config -> config.S3 <- value)
            state : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#tags-1">FsxDataRepositoryAssociation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>, value: seq<string * string>) : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#tags_all-1">FsxDataRepositoryAssociation#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>, value: seq<string * string>) : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_data_repository_association#timeouts-1">FsxDataRepositoryAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>, value: aws.FsxDataRepositoryAssociation.FsxDataRepositoryAssociationTimeouts) : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FsxDataRepositoryAssociationState<'DataRepositoryPath, 'FileSystemId, 'FileSystemPath>

        member _.Run(state: FsxDataRepositoryAssociationState<Present, Present, Present>) : aws.FsxDataRepositoryAssociation.FsxDataRepositoryAssociation =
            let config = aws.FsxDataRepositoryAssociation.FsxDataRepositoryAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.FsxDataRepositoryAssociation.FsxDataRepositoryAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.fsxDataRepositoryAssociation: missing required arguments. Must call: data_repository_path, file_system_id, file_system_path.", 9999, IsError = true)>]
        member _.Run(_: FsxDataRepositoryAssociationState<_, _, _>) : aws.FsxDataRepositoryAssociation.FsxDataRepositoryAssociation =
            Unchecked.defaultof<aws.FsxDataRepositoryAssociation.FsxDataRepositoryAssociation>
