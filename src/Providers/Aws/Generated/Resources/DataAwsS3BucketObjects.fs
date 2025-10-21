namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsS3BucketObjectsState<'Bucket> = { assignments: ResizeArray<aws.DataAwsS3BucketObjects.DataAwsS3BucketObjectsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket_objects">aws_s3_bucket_objects</a>.
    /// </summary>
    type DataAwsS3BucketObjectsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsS3BucketObjectsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsS3BucketObjectsState<Missing>)

        member _.Zero(()) : DataAwsS3BucketObjectsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsS3BucketObjectsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket_objects#bucket-1">DataAwsS3BucketObjects#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: DataAwsS3BucketObjectsState<Missing>, value: string) : DataAwsS3BucketObjectsState<Present> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : DataAwsS3BucketObjectsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket_objects#delimiter-1">DataAwsS3BucketObjects#delimiter</a>.
        /// </summary>
        [<CustomOperation "delimiter">]
        member _.Delimiter(state: DataAwsS3BucketObjectsState<'Bucket>, value: string) : DataAwsS3BucketObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.Delimiter <- value)
            state : DataAwsS3BucketObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket_objects#encoding_type-1">DataAwsS3BucketObjects#encoding_type</a>.
        /// </summary>
        [<CustomOperation "encoding_type">]
        member _.EncodingType(state: DataAwsS3BucketObjectsState<'Bucket>, value: string) : DataAwsS3BucketObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.EncodingType <- value)
            state : DataAwsS3BucketObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket_objects#fetch_owner-1">DataAwsS3BucketObjects#fetch_owner</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fetch_owner">]
        member _.FetchOwner(state: DataAwsS3BucketObjectsState<'Bucket>, value: bool) : DataAwsS3BucketObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.FetchOwner <- value)
            state : DataAwsS3BucketObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket_objects#fetch_owner-1">DataAwsS3BucketObjects#fetch_owner</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fetch_owner">]
        member _.FetchOwner(state: DataAwsS3BucketObjectsState<'Bucket>, value: HashiCorp.Cdktf.IResolvable) : DataAwsS3BucketObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.FetchOwner <- value)
            state : DataAwsS3BucketObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket_objects#id-1">DataAwsS3BucketObjects#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsS3BucketObjectsState<'Bucket>, value: string) : DataAwsS3BucketObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsS3BucketObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket_objects#max_keys-1">DataAwsS3BucketObjects#max_keys</a>.
        /// </summary>
        [<CustomOperation "max_keys">]
        member _.MaxKeys(state: DataAwsS3BucketObjectsState<'Bucket>, value: double) : DataAwsS3BucketObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.MaxKeys <- value)
            state : DataAwsS3BucketObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket_objects#prefix-1">DataAwsS3BucketObjects#prefix</a>.
        /// </summary>
        [<CustomOperation "prefix">]
        member _.Prefix(state: DataAwsS3BucketObjectsState<'Bucket>, value: string) : DataAwsS3BucketObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.Prefix <- value)
            state : DataAwsS3BucketObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_bucket_objects#start_after-1">DataAwsS3BucketObjects#start_after</a>.
        /// </summary>
        [<CustomOperation "start_after">]
        member _.StartAfter(state: DataAwsS3BucketObjectsState<'Bucket>, value: string) : DataAwsS3BucketObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.StartAfter <- value)
            state : DataAwsS3BucketObjectsState<'Bucket>

        member _.Run(state: DataAwsS3BucketObjectsState<Present>) : aws.DataAwsS3BucketObjects.DataAwsS3BucketObjects =
            let config = aws.DataAwsS3BucketObjects.DataAwsS3BucketObjectsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsS3BucketObjects.DataAwsS3BucketObjects(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsS3BucketObjects: missing required arguments. Must call: bucket.", 9999, IsError = true)>]
        member _.Run(_: DataAwsS3BucketObjectsState<_>) : aws.DataAwsS3BucketObjects.DataAwsS3BucketObjects =
            Unchecked.defaultof<aws.DataAwsS3BucketObjects.DataAwsS3BucketObjects>
