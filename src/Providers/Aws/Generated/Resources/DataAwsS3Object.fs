namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsS3ObjectState<'Bucket, 'Key> = { assignments: ResizeArray<aws.DataAwsS3Object.DataAwsS3ObjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_object">aws_s3_object</a>.
    /// </summary>
    type DataAwsS3ObjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsS3ObjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsS3ObjectState<Missing, Missing>)

        member _.Zero(()) : DataAwsS3ObjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsS3ObjectState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_object#bucket-1">DataAwsS3Object#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: DataAwsS3ObjectState<Missing, 'Key>, value: string) : DataAwsS3ObjectState<Present, 'Key> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : DataAwsS3ObjectState<Present, 'Key>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_object#key-1">DataAwsS3Object#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: DataAwsS3ObjectState<'Bucket, Missing>, value: string) : DataAwsS3ObjectState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : DataAwsS3ObjectState<'Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_object#checksum_mode-1">DataAwsS3Object#checksum_mode</a>.
        /// </summary>
        [<CustomOperation "checksum_mode">]
        member _.ChecksumMode(state: DataAwsS3ObjectState<'Bucket, 'Key>, value: string) : DataAwsS3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ChecksumMode <- value)
            state : DataAwsS3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_object#id-1">DataAwsS3Object#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsS3ObjectState<'Bucket, 'Key>, value: string) : DataAwsS3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsS3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_object#range-1">DataAwsS3Object#range</a>.
        /// </summary>
        [<CustomOperation "range">]
        member _.Range(state: DataAwsS3ObjectState<'Bucket, 'Key>, value: string) : DataAwsS3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Range <- value)
            state : DataAwsS3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_object#tags-1">DataAwsS3Object#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsS3ObjectState<'Bucket, 'Key>, value: seq<string * string>) : DataAwsS3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsS3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_object#version_id-1">DataAwsS3Object#version_id</a>.
        /// </summary>
        [<CustomOperation "version_id">]
        member _.VersionId(state: DataAwsS3ObjectState<'Bucket, 'Key>, value: string) : DataAwsS3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.VersionId <- value)
            state : DataAwsS3ObjectState<'Bucket, 'Key>

        member _.Run(state: DataAwsS3ObjectState<Present, Present>) : aws.DataAwsS3Object.DataAwsS3Object =
            let config = aws.DataAwsS3Object.DataAwsS3ObjectConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsS3Object.DataAwsS3Object(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsS3Object: missing required arguments. Must call: bucket, key.", 9999, IsError = true)>]
        member _.Run(_: DataAwsS3ObjectState<_, _>) : aws.DataAwsS3Object.DataAwsS3Object =
            Unchecked.defaultof<aws.DataAwsS3Object.DataAwsS3Object>
