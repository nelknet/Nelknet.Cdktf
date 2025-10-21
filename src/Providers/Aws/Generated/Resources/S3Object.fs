namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ObjectState<'Bucket, 'Key> = { assignments: ResizeArray<aws.S3Object.S3ObjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object">aws_s3_object</a>.
    /// </summary>
    type S3ObjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ObjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ObjectState<Missing, Missing>)

        member _.Zero(()) : S3ObjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ObjectState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#bucket-1">S3Object#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3ObjectState<Missing, 'Key>, value: string) : S3ObjectState<Present, 'Key> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3ObjectState<Present, 'Key>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#key-1">S3Object#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: S3ObjectState<'Bucket, Missing>, value: string) : S3ObjectState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : S3ObjectState<'Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#acl-1">S3Object#acl</a>.
        /// </summary>
        [<CustomOperation "acl">]
        member _.Acl(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Acl <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#bucket_key_enabled-1">S3Object#bucket_key_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bucket_key_enabled">]
        member _.BucketKeyEnabled(state: S3ObjectState<'Bucket, 'Key>, value: bool) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.BucketKeyEnabled <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#bucket_key_enabled-1">S3Object#bucket_key_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bucket_key_enabled">]
        member _.BucketKeyEnabled(state: S3ObjectState<'Bucket, 'Key>, value: HashiCorp.Cdktf.IResolvable) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.BucketKeyEnabled <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#cache_control-1">S3Object#cache_control</a>.
        /// </summary>
        [<CustomOperation "cache_control">]
        member _.CacheControl(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.CacheControl <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#checksum_algorithm-1">S3Object#checksum_algorithm</a>.
        /// </summary>
        [<CustomOperation "checksum_algorithm">]
        member _.ChecksumAlgorithm(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ChecksumAlgorithm <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#content-1">S3Object#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Content <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#content_base64-1">S3Object#content_base64</a>.
        /// </summary>
        [<CustomOperation "content_base64">]
        member _.ContentBase64(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ContentBase64 <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#content_disposition-1">S3Object#content_disposition</a>.
        /// </summary>
        [<CustomOperation "content_disposition">]
        member _.ContentDisposition(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ContentDisposition <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#content_encoding-1">S3Object#content_encoding</a>.
        /// </summary>
        [<CustomOperation "content_encoding">]
        member _.ContentEncoding(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ContentEncoding <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#content_language-1">S3Object#content_language</a>.
        /// </summary>
        [<CustomOperation "content_language">]
        member _.ContentLanguage(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ContentLanguage <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#content_type-1">S3Object#content_type</a>.
        /// </summary>
        [<CustomOperation "content_type">]
        member _.ContentType(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ContentType <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#etag-1">S3Object#etag</a>.
        /// </summary>
        [<CustomOperation "etag">]
        member _.Etag(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Etag <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#force_destroy-1">S3Object#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: S3ObjectState<'Bucket, 'Key>, value: bool) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#force_destroy-1">S3Object#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: S3ObjectState<'Bucket, 'Key>, value: HashiCorp.Cdktf.IResolvable) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#id-1">S3Object#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#kms_key_id-1">S3Object#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#metadata-1">S3Object#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: S3ObjectState<'Bucket, 'Key>, value: seq<string * string>) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#object_lock_legal_hold_status-1">S3Object#object_lock_legal_hold_status</a>.
        /// </summary>
        [<CustomOperation "object_lock_legal_hold_status">]
        member _.ObjectLockLegalHoldStatus(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ObjectLockLegalHoldStatus <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#object_lock_mode-1">S3Object#object_lock_mode</a>.
        /// </summary>
        [<CustomOperation "object_lock_mode">]
        member _.ObjectLockMode(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ObjectLockMode <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#object_lock_retain_until_date-1">S3Object#object_lock_retain_until_date</a>.
        /// </summary>
        [<CustomOperation "object_lock_retain_until_date">]
        member _.ObjectLockRetainUntilDate(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ObjectLockRetainUntilDate <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// override_provider block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#override_provider-1">S3Object#override_provider</a>
        /// </summary>
        [<CustomOperation "override_provider">]
        member _.OverrideProvider(state: S3ObjectState<'Bucket, 'Key>, value: aws.S3Object.S3ObjectOverrideProvider) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.OverrideProvider <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#server_side_encryption-1">S3Object#server_side_encryption</a>.
        /// </summary>
        [<CustomOperation "server_side_encryption">]
        member _.ServerSideEncryption(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ServerSideEncryption <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#source-1">S3Object#source</a>.
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Source <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#source_hash-1">S3Object#source_hash</a>.
        /// </summary>
        [<CustomOperation "source_hash">]
        member _.SourceHash(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.SourceHash <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#storage_class-1">S3Object#storage_class</a>.
        /// </summary>
        [<CustomOperation "storage_class">]
        member _.StorageClass(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.StorageClass <- value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#tags-1">S3Object#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: S3ObjectState<'Bucket, 'Key>, value: seq<string * string>) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#tags_all-1">S3Object#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: S3ObjectState<'Bucket, 'Key>, value: seq<string * string>) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : S3ObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object#website_redirect-1">S3Object#website_redirect</a>.
        /// </summary>
        [<CustomOperation "website_redirect">]
        member _.WebsiteRedirect(state: S3ObjectState<'Bucket, 'Key>, value: string) : S3ObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.WebsiteRedirect <- value)
            state : S3ObjectState<'Bucket, 'Key>

        member _.Run(state: S3ObjectState<Present, Present>) : aws.S3Object.S3Object =
            let config = aws.S3Object.S3ObjectConfig()
            for setter in state.assignments do
                setter config
            aws.S3Object.S3Object(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3Object: missing required arguments. Must call: bucket, key.", 9999, IsError = true)>]
        member _.Run(_: S3ObjectState<_, _>) : aws.S3Object.S3Object =
            Unchecked.defaultof<aws.S3Object.S3Object>
