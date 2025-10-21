namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory> = { assignments: ResizeArray<aws.DatasyncLocationS3.DatasyncLocationS3Config -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_s3">aws_datasync_location_s3</a>.
    /// </summary>
    type DatasyncLocationS3Builder(logicalId: string) =
        member _.Yield(_: unit) : DatasyncLocationS3State<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationS3State<Missing, Missing, Missing>)

        member _.Zero(()) : DatasyncLocationS3State<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatasyncLocationS3State<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_s3#s3_bucket_arn-1">DatasyncLocationS3#s3_bucket_arn</a>.
        /// </summary>
        [<CustomOperation "s3_bucket_arn">]
        member _.S3BucketArn(state: DatasyncLocationS3State<Missing, 'S3Config, 'Subdirectory>, value: string) : DatasyncLocationS3State<Present, 'S3Config, 'Subdirectory> =
            state.assignments.Add(fun config -> config.S3BucketArn <- value)
            ({ assignments = state.assignments } : DatasyncLocationS3State<Present, 'S3Config, 'Subdirectory>)

        /// <summary>
        /// s3_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_s3#s3_config-1">DatasyncLocationS3#s3_config</a>
        /// </summary>
        [<CustomOperation "s3_config">]
        member _.S3Config(state: DatasyncLocationS3State<'S3BucketArn, Missing, 'Subdirectory>, value: aws.DatasyncLocationS3.DatasyncLocationS3S3Config) : DatasyncLocationS3State<'S3BucketArn, Present, 'Subdirectory> =
            state.assignments.Add(fun config -> config.S3Config <- value)
            ({ assignments = state.assignments } : DatasyncLocationS3State<'S3BucketArn, Present, 'Subdirectory>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_s3#subdirectory-1">DatasyncLocationS3#subdirectory</a>.
        /// </summary>
        [<CustomOperation "subdirectory">]
        member _.Subdirectory(state: DatasyncLocationS3State<'S3BucketArn, 'S3Config, Missing>, value: string) : DatasyncLocationS3State<'S3BucketArn, 'S3Config, Present> =
            state.assignments.Add(fun config -> config.Subdirectory <- value)
            ({ assignments = state.assignments } : DatasyncLocationS3State<'S3BucketArn, 'S3Config, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_s3#agent_arns-1">DatasyncLocationS3#agent_arns</a>.
        /// </summary>
        [<CustomOperation "agent_arns">]
        member _.AgentArns(state: DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory>, value: seq<string>) : DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory> =
            state.assignments.Add(fun config -> config.AgentArns <- (value |> Seq.toArray))
            state : DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_s3#id-1">DatasyncLocationS3#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory>, value: string) : DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_s3#s3_storage_class-1">DatasyncLocationS3#s3_storage_class</a>.
        /// </summary>
        [<CustomOperation "s3_storage_class">]
        member _.S3StorageClass(state: DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory>, value: string) : DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory> =
            state.assignments.Add(fun config -> config.S3StorageClass <- value)
            state : DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_s3#tags-1">DatasyncLocationS3#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory>, value: seq<string * string>) : DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/datasync_location_s3#tags_all-1">DatasyncLocationS3#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory>, value: seq<string * string>) : DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DatasyncLocationS3State<'S3BucketArn, 'S3Config, 'Subdirectory>

        member _.Run(state: DatasyncLocationS3State<Present, Present, Present>) : aws.DatasyncLocationS3.DatasyncLocationS3 =
            let config = aws.DatasyncLocationS3.DatasyncLocationS3Config()
            for setter in state.assignments do
                setter config
            aws.DatasyncLocationS3.DatasyncLocationS3(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.datasyncLocationS3: missing required arguments. Must call: s3_bucket_arn, s3_config, subdirectory.", 9999, IsError = true)>]
        member _.Run(_: DatasyncLocationS3State<_, _, _>) : aws.DatasyncLocationS3.DatasyncLocationS3 =
            Unchecked.defaultof<aws.DatasyncLocationS3.DatasyncLocationS3>
