namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsCustomDbEngineVersionState<'Engine, 'EngineVersion> = { assignments: ResizeArray<aws.RdsCustomDbEngineVersion.RdsCustomDbEngineVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version">aws_rds_custom_db_engine_version</a>.
    /// </summary>
    type RdsCustomDbEngineVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsCustomDbEngineVersionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsCustomDbEngineVersionState<Missing, Missing>)

        member _.Zero(()) : RdsCustomDbEngineVersionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RdsCustomDbEngineVersionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#engine-1">RdsCustomDbEngineVersion#engine</a>.
        /// </summary>
        [<CustomOperation "engine">]
        member _.Engine(state: RdsCustomDbEngineVersionState<Missing, 'EngineVersion>, value: string) : RdsCustomDbEngineVersionState<Present, 'EngineVersion> =
            state.assignments.Add(fun config -> config.Engine <- value)
            ({ assignments = state.assignments } : RdsCustomDbEngineVersionState<Present, 'EngineVersion>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#engine_version-1">RdsCustomDbEngineVersion#engine_version</a>.
        /// </summary>
        [<CustomOperation "engine_version">]
        member _.EngineVersion(state: RdsCustomDbEngineVersionState<'Engine, Missing>, value: string) : RdsCustomDbEngineVersionState<'Engine, Present> =
            state.assignments.Add(fun config -> config.EngineVersion <- value)
            ({ assignments = state.assignments } : RdsCustomDbEngineVersionState<'Engine, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#database_installation_files_s3_bucket_name-1">RdsCustomDbEngineVersion#database_installation_files_s3_bucket_name</a>.
        /// </summary>
        [<CustomOperation "database_installation_files_s3_bucket_name">]
        member _.DatabaseInstallationFilesS3BucketName(state: RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>, value: string) : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion> =
            state.assignments.Add(fun config -> config.DatabaseInstallationFilesS3BucketName <- value)
            state : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#database_installation_files_s3_prefix-1">RdsCustomDbEngineVersion#database_installation_files_s3_prefix</a>.
        /// </summary>
        [<CustomOperation "database_installation_files_s3_prefix">]
        member _.DatabaseInstallationFilesS3Prefix(state: RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>, value: string) : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion> =
            state.assignments.Add(fun config -> config.DatabaseInstallationFilesS3Prefix <- value)
            state : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#description-1">RdsCustomDbEngineVersion#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>, value: string) : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#filename-1">RdsCustomDbEngineVersion#filename</a>.
        /// </summary>
        [<CustomOperation "filename">]
        member _.Filename(state: RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>, value: string) : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion> =
            state.assignments.Add(fun config -> config.Filename <- value)
            state : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#id-1">RdsCustomDbEngineVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>, value: string) : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#kms_key_id-1">RdsCustomDbEngineVersion#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>, value: string) : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#manifest-1">RdsCustomDbEngineVersion#manifest</a>.
        /// </summary>
        [<CustomOperation "manifest">]
        member _.Manifest(state: RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>, value: string) : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion> =
            state.assignments.Add(fun config -> config.Manifest <- value)
            state : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#manifest_hash-1">RdsCustomDbEngineVersion#manifest_hash</a>.
        /// </summary>
        [<CustomOperation "manifest_hash">]
        member _.ManifestHash(state: RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>, value: string) : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion> =
            state.assignments.Add(fun config -> config.ManifestHash <- value)
            state : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#source_image_id-1">RdsCustomDbEngineVersion#source_image_id</a>.
        /// </summary>
        [<CustomOperation "source_image_id">]
        member _.SourceImageId(state: RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>, value: string) : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion> =
            state.assignments.Add(fun config -> config.SourceImageId <- value)
            state : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#status-1">RdsCustomDbEngineVersion#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>, value: string) : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#tags-1">RdsCustomDbEngineVersion#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>, value: seq<string * string>) : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#tags_all-1">RdsCustomDbEngineVersion#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>, value: seq<string * string>) : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_custom_db_engine_version#timeouts-1">RdsCustomDbEngineVersion#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>, value: aws.RdsCustomDbEngineVersion.RdsCustomDbEngineVersionTimeouts) : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RdsCustomDbEngineVersionState<'Engine, 'EngineVersion>

        member _.Run(state: RdsCustomDbEngineVersionState<Present, Present>) : aws.RdsCustomDbEngineVersion.RdsCustomDbEngineVersion =
            let config = aws.RdsCustomDbEngineVersion.RdsCustomDbEngineVersionConfig()
            for setter in state.assignments do
                setter config
            aws.RdsCustomDbEngineVersion.RdsCustomDbEngineVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsCustomDbEngineVersion: missing required arguments. Must call: engine, engine_version.", 9999, IsError = true)>]
        member _.Run(_: RdsCustomDbEngineVersionState<_, _>) : aws.RdsCustomDbEngineVersion.RdsCustomDbEngineVersion =
            Unchecked.defaultof<aws.RdsCustomDbEngineVersion.RdsCustomDbEngineVersion>
