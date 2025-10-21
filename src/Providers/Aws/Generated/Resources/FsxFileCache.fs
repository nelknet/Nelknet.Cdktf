namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds> = { assignments: ResizeArray<aws.FsxFileCache.FsxFileCacheConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache">aws_fsx_file_cache</a>.
    /// </summary>
    type FsxFileCacheBuilder(logicalId: string) =
        member _.Yield(_: unit) : FsxFileCacheState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxFileCacheState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FsxFileCacheState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FsxFileCacheState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#file_cache_type-1">FsxFileCache#file_cache_type</a>.
        /// </summary>
        [<CustomOperation "file_cache_type">]
        member _.FileCacheType(state: FsxFileCacheState<Missing, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>, value: string) : FsxFileCacheState<Present, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.FileCacheType <- value)
            ({ assignments = state.assignments } : FsxFileCacheState<Present, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#file_cache_type_version-1">FsxFileCache#file_cache_type_version</a>.
        /// </summary>
        [<CustomOperation "file_cache_type_version">]
        member _.FileCacheTypeVersion(state: FsxFileCacheState<'FileCacheType, Missing, 'StorageCapacity, 'SubnetIds>, value: string) : FsxFileCacheState<'FileCacheType, Present, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.FileCacheTypeVersion <- value)
            ({ assignments = state.assignments } : FsxFileCacheState<'FileCacheType, Present, 'StorageCapacity, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#storage_capacity-1">FsxFileCache#storage_capacity</a>.
        /// </summary>
        [<CustomOperation "storage_capacity">]
        member _.StorageCapacity(state: FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, Missing, 'SubnetIds>, value: double) : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, Present, 'SubnetIds> =
            state.assignments.Add(fun config -> config.StorageCapacity <- value)
            ({ assignments = state.assignments } : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, Present, 'SubnetIds>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#subnet_ids-1">FsxFileCache#subnet_ids</a>.
        /// </summary>
        [<CustomOperation "subnet_ids">]
        member _.SubnetIds(state: FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, Missing>, value: seq<string>) : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, Present> =
            state.assignments.Add(fun config -> config.SubnetIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#copy_tags_to_data_repository_associations-1">FsxFileCache#copy_tags_to_data_repository_associations</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_data_repository_associations">]
        member _.CopyTagsToDataRepositoryAssociations(state: FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>, value: bool) : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.CopyTagsToDataRepositoryAssociations <- value)
            state : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#copy_tags_to_data_repository_associations-1">FsxFileCache#copy_tags_to_data_repository_associations</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "copy_tags_to_data_repository_associations">]
        member _.CopyTagsToDataRepositoryAssociations(state: FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>, value: HashiCorp.Cdktf.IResolvable) : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.CopyTagsToDataRepositoryAssociations <- value)
            state : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// data_repository_association block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#data_repository_association-1">FsxFileCache#data_repository_association</a> Accepts: aws.IResolvable | aws.FsxFileCache.FsxFileCacheDataRepositoryAssociation[]
        /// </summary>
        [<CustomOperation "data_repository_association">]
        member _.DataRepositoryAssociation(state: FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>, value: HashiCorp.Cdktf.IResolvable) : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.DataRepositoryAssociation <- value)
            state : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#id-1">FsxFileCache#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>, value: string) : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#kms_key_id-1">FsxFileCache#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>, value: string) : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// lustre_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#lustre_configuration-1">FsxFileCache#lustre_configuration</a> Accepts: aws.IResolvable | aws.FsxFileCache.FsxFileCacheLustreConfiguration[]
        /// </summary>
        [<CustomOperation "lustre_configuration">]
        member _.LustreConfiguration(state: FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>, value: HashiCorp.Cdktf.IResolvable) : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.LustreConfiguration <- value)
            state : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#security_group_ids-1">FsxFileCache#security_group_ids</a>.
        /// </summary>
        [<CustomOperation "security_group_ids">]
        member _.SecurityGroupIds(state: FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>, value: seq<string>) : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.SecurityGroupIds <- (value |> Seq.toArray))
            state : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#tags-1">FsxFileCache#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>, value: seq<string * string>) : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#tags_all-1">FsxFileCache#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>, value: seq<string * string>) : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fsx_file_cache#timeouts-1">FsxFileCache#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>, value: aws.FsxFileCache.FsxFileCacheTimeouts) : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FsxFileCacheState<'FileCacheType, 'FileCacheTypeVersion, 'StorageCapacity, 'SubnetIds>

        member _.Run(state: FsxFileCacheState<Present, Present, Present, Present>) : aws.FsxFileCache.FsxFileCache =
            let config = aws.FsxFileCache.FsxFileCacheConfig()
            for setter in state.assignments do
                setter config
            aws.FsxFileCache.FsxFileCache(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.fsxFileCache: missing required arguments. Must call: file_cache_type, file_cache_type_version, storage_capacity, subnet_ids.", 9999, IsError = true)>]
        member _.Run(_: FsxFileCacheState<_, _, _, _>) : aws.FsxFileCache.FsxFileCache =
            Unchecked.defaultof<aws.FsxFileCache.FsxFileCache>
