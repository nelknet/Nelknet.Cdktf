namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketObjectState<'Bucket, 'Key> = { assignments: ResizeArray<aws.S3BucketObject.S3BucketObjectConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object">aws_s3_bucket_object</a>.
    /// </summary>
    type S3BucketObjectBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketObjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketObjectState<Missing, Missing>)

        member _.Zero(()) : S3BucketObjectState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3BucketObjectState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#bucket-1">S3BucketObject#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketObjectState<Missing, 'Key>, value: string) : S3BucketObjectState<Present, 'Key> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3BucketObjectState<Present, 'Key>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#key-1">S3BucketObject#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: S3BucketObjectState<'Bucket, Missing>, value: string) : S3BucketObjectState<'Bucket, Present> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : S3BucketObjectState<'Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#acl-1">S3BucketObject#acl</a>.
        /// </summary>
        [<CustomOperation "acl">]
        member _.Acl(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Acl <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#bucket_key_enabled-1">S3BucketObject#bucket_key_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bucket_key_enabled">]
        member _.BucketKeyEnabled(state: S3BucketObjectState<'Bucket, 'Key>, value: bool) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.BucketKeyEnabled <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#bucket_key_enabled-1">S3BucketObject#bucket_key_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bucket_key_enabled">]
        member _.BucketKeyEnabled(state: S3BucketObjectState<'Bucket, 'Key>, value: HashiCorp.Cdktf.IResolvable) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.BucketKeyEnabled <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#cache_control-1">S3BucketObject#cache_control</a>.
        /// </summary>
        [<CustomOperation "cache_control">]
        member _.CacheControl(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.CacheControl <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#content-1">S3BucketObject#content</a>.
        /// </summary>
        [<CustomOperation "content">]
        member _.Content(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Content <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#content_base64-1">S3BucketObject#content_base64</a>.
        /// </summary>
        [<CustomOperation "content_base64">]
        member _.ContentBase64(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ContentBase64 <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#content_disposition-1">S3BucketObject#content_disposition</a>.
        /// </summary>
        [<CustomOperation "content_disposition">]
        member _.ContentDisposition(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ContentDisposition <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#content_encoding-1">S3BucketObject#content_encoding</a>.
        /// </summary>
        [<CustomOperation "content_encoding">]
        member _.ContentEncoding(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ContentEncoding <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#content_language-1">S3BucketObject#content_language</a>.
        /// </summary>
        [<CustomOperation "content_language">]
        member _.ContentLanguage(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ContentLanguage <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#content_type-1">S3BucketObject#content_type</a>.
        /// </summary>
        [<CustomOperation "content_type">]
        member _.ContentType(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ContentType <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#etag-1">S3BucketObject#etag</a>.
        /// </summary>
        [<CustomOperation "etag">]
        member _.Etag(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Etag <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#force_destroy-1">S3BucketObject#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: S3BucketObjectState<'Bucket, 'Key>, value: bool) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#force_destroy-1">S3BucketObject#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: S3BucketObjectState<'Bucket, 'Key>, value: HashiCorp.Cdktf.IResolvable) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#id-1">S3BucketObject#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#kms_key_id-1">S3BucketObject#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#metadata-1">S3BucketObject#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: S3BucketObjectState<'Bucket, 'Key>, value: seq<string * string>) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#object_lock_legal_hold_status-1">S3BucketObject#object_lock_legal_hold_status</a>.
        /// </summary>
        [<CustomOperation "object_lock_legal_hold_status">]
        member _.ObjectLockLegalHoldStatus(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ObjectLockLegalHoldStatus <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#object_lock_mode-1">S3BucketObject#object_lock_mode</a>.
        /// </summary>
        [<CustomOperation "object_lock_mode">]
        member _.ObjectLockMode(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ObjectLockMode <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#object_lock_retain_until_date-1">S3BucketObject#object_lock_retain_until_date</a>.
        /// </summary>
        [<CustomOperation "object_lock_retain_until_date">]
        member _.ObjectLockRetainUntilDate(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ObjectLockRetainUntilDate <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#server_side_encryption-1">S3BucketObject#server_side_encryption</a>.
        /// </summary>
        [<CustomOperation "server_side_encryption">]
        member _.ServerSideEncryption(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.ServerSideEncryption <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#source-1">S3BucketObject#source</a>.
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Source <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#source_hash-1">S3BucketObject#source_hash</a>.
        /// </summary>
        [<CustomOperation "source_hash">]
        member _.SourceHash(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.SourceHash <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#storage_class-1">S3BucketObject#storage_class</a>.
        /// </summary>
        [<CustomOperation "storage_class">]
        member _.StorageClass(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.StorageClass <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#tags-1">S3BucketObject#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: S3BucketObjectState<'Bucket, 'Key>, value: seq<string * string>) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#tags_all-1">S3BucketObject#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: S3BucketObjectState<'Bucket, 'Key>, value: seq<string * string>) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : S3BucketObjectState<'Bucket, 'Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket_object#website_redirect-1">S3BucketObject#website_redirect</a>.
        /// </summary>
        [<CustomOperation "website_redirect">]
        member _.WebsiteRedirect(state: S3BucketObjectState<'Bucket, 'Key>, value: string) : S3BucketObjectState<'Bucket, 'Key> =
            state.assignments.Add(fun config -> config.WebsiteRedirect <- value)
            state : S3BucketObjectState<'Bucket, 'Key>

        member _.Run(state: S3BucketObjectState<Present, Present>) : aws.S3BucketObject.S3BucketObject =
            let config = aws.S3BucketObject.S3BucketObjectConfig()
            for setter in state.assignments do
                setter config
            aws.S3BucketObject.S3BucketObject(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3BucketObject: missing required arguments. Must call: bucket, key.", 9999, IsError = true)>]
        member _.Run(_: S3BucketObjectState<_, _>) : aws.S3BucketObject.S3BucketObject =
            Unchecked.defaultof<aws.S3BucketObject.S3BucketObject>
