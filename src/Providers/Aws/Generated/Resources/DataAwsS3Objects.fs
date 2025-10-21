namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsS3ObjectsState<'Bucket> = { assignments: ResizeArray<aws.DataAwsS3Objects.DataAwsS3ObjectsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_objects">aws_s3_objects</a>.
    /// </summary>
    type DataAwsS3ObjectsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsS3ObjectsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsS3ObjectsState<Missing>)

        member _.Zero(()) : DataAwsS3ObjectsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsS3ObjectsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_objects#bucket-1">DataAwsS3Objects#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: DataAwsS3ObjectsState<Missing>, value: string) : DataAwsS3ObjectsState<Present> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : DataAwsS3ObjectsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_objects#delimiter-1">DataAwsS3Objects#delimiter</a>.
        /// </summary>
        [<CustomOperation "delimiter">]
        member _.Delimiter(state: DataAwsS3ObjectsState<'Bucket>, value: string) : DataAwsS3ObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.Delimiter <- value)
            state : DataAwsS3ObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_objects#encoding_type-1">DataAwsS3Objects#encoding_type</a>.
        /// </summary>
        [<CustomOperation "encoding_type">]
        member _.EncodingType(state: DataAwsS3ObjectsState<'Bucket>, value: string) : DataAwsS3ObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.EncodingType <- value)
            state : DataAwsS3ObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_objects#fetch_owner-1">DataAwsS3Objects#fetch_owner</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fetch_owner">]
        member _.FetchOwner(state: DataAwsS3ObjectsState<'Bucket>, value: bool) : DataAwsS3ObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.FetchOwner <- value)
            state : DataAwsS3ObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_objects#fetch_owner-1">DataAwsS3Objects#fetch_owner</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "fetch_owner">]
        member _.FetchOwner(state: DataAwsS3ObjectsState<'Bucket>, value: HashiCorp.Cdktf.IResolvable) : DataAwsS3ObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.FetchOwner <- value)
            state : DataAwsS3ObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_objects#id-1">DataAwsS3Objects#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsS3ObjectsState<'Bucket>, value: string) : DataAwsS3ObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsS3ObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_objects#max_keys-1">DataAwsS3Objects#max_keys</a>.
        /// </summary>
        [<CustomOperation "max_keys">]
        member _.MaxKeys(state: DataAwsS3ObjectsState<'Bucket>, value: double) : DataAwsS3ObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.MaxKeys <- value)
            state : DataAwsS3ObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_objects#prefix-1">DataAwsS3Objects#prefix</a>.
        /// </summary>
        [<CustomOperation "prefix">]
        member _.Prefix(state: DataAwsS3ObjectsState<'Bucket>, value: string) : DataAwsS3ObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.Prefix <- value)
            state : DataAwsS3ObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_objects#request_payer-1">DataAwsS3Objects#request_payer</a>.
        /// </summary>
        [<CustomOperation "request_payer">]
        member _.RequestPayer(state: DataAwsS3ObjectsState<'Bucket>, value: string) : DataAwsS3ObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.RequestPayer <- value)
            state : DataAwsS3ObjectsState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/s3_objects#start_after-1">DataAwsS3Objects#start_after</a>.
        /// </summary>
        [<CustomOperation "start_after">]
        member _.StartAfter(state: DataAwsS3ObjectsState<'Bucket>, value: string) : DataAwsS3ObjectsState<'Bucket> =
            state.assignments.Add(fun config -> config.StartAfter <- value)
            state : DataAwsS3ObjectsState<'Bucket>

        member _.Run(state: DataAwsS3ObjectsState<Present>) : aws.DataAwsS3Objects.DataAwsS3Objects =
            let config = aws.DataAwsS3Objects.DataAwsS3ObjectsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsS3Objects.DataAwsS3Objects(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsS3Objects: missing required arguments. Must call: bucket.", 9999, IsError = true)>]
        member _.Run(_: DataAwsS3ObjectsState<_>) : aws.DataAwsS3Objects.DataAwsS3Objects =
            Unchecked.defaultof<aws.DataAwsS3Objects.DataAwsS3Objects>
