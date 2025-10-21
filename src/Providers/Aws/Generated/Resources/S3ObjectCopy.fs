namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3ObjectCopyState<'Bucket, 'Key, 'Source> = { assignments: ResizeArray<aws.S3ObjectCopy.S3ObjectCopyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy">aws_s3_object_copy</a>.
    /// </summary>
    type S3ObjectCopyBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3ObjectCopyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ObjectCopyState<Missing, Missing, Missing>)

        member _.Zero(()) : S3ObjectCopyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3ObjectCopyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#bucket-1">S3ObjectCopy#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3ObjectCopyState<Missing, 'Key, 'Source>, value: string) : S3ObjectCopyState<Present, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : S3ObjectCopyState<Present, 'Key, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#key-1">S3ObjectCopy#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: S3ObjectCopyState<'Bucket, Missing, 'Source>, value: string) : S3ObjectCopyState<'Bucket, Present, 'Source> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : S3ObjectCopyState<'Bucket, Present, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#source-1">S3ObjectCopy#source</a>.
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: S3ObjectCopyState<'Bucket, 'Key, Missing>, value: string) : S3ObjectCopyState<'Bucket, 'Key, Present> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : S3ObjectCopyState<'Bucket, 'Key, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#acl-1">S3ObjectCopy#acl</a>.
        /// </summary>
        [<CustomOperation "acl">]
        member _.Acl(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.Acl <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#bucket_key_enabled-1">S3ObjectCopy#bucket_key_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bucket_key_enabled">]
        member _.BucketKeyEnabled(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: bool) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.BucketKeyEnabled <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#bucket_key_enabled-1">S3ObjectCopy#bucket_key_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "bucket_key_enabled">]
        member _.BucketKeyEnabled(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: HashiCorp.Cdktf.IResolvable) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.BucketKeyEnabled <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#cache_control-1">S3ObjectCopy#cache_control</a>.
        /// </summary>
        [<CustomOperation "cache_control">]
        member _.CacheControl(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.CacheControl <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#checksum_algorithm-1">S3ObjectCopy#checksum_algorithm</a>.
        /// </summary>
        [<CustomOperation "checksum_algorithm">]
        member _.ChecksumAlgorithm(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.ChecksumAlgorithm <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#content_disposition-1">S3ObjectCopy#content_disposition</a>.
        /// </summary>
        [<CustomOperation "content_disposition">]
        member _.ContentDisposition(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.ContentDisposition <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#content_encoding-1">S3ObjectCopy#content_encoding</a>.
        /// </summary>
        [<CustomOperation "content_encoding">]
        member _.ContentEncoding(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.ContentEncoding <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#content_language-1">S3ObjectCopy#content_language</a>.
        /// </summary>
        [<CustomOperation "content_language">]
        member _.ContentLanguage(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.ContentLanguage <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#content_type-1">S3ObjectCopy#content_type</a>.
        /// </summary>
        [<CustomOperation "content_type">]
        member _.ContentType(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.ContentType <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#copy_if_match-1">S3ObjectCopy#copy_if_match</a>.
        /// </summary>
        [<CustomOperation "copy_if_match">]
        member _.CopyIfMatch(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.CopyIfMatch <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#copy_if_modified_since-1">S3ObjectCopy#copy_if_modified_since</a>.
        /// </summary>
        [<CustomOperation "copy_if_modified_since">]
        member _.CopyIfModifiedSince(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.CopyIfModifiedSince <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#copy_if_none_match-1">S3ObjectCopy#copy_if_none_match</a>.
        /// </summary>
        [<CustomOperation "copy_if_none_match">]
        member _.CopyIfNoneMatch(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.CopyIfNoneMatch <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#copy_if_unmodified_since-1">S3ObjectCopy#copy_if_unmodified_since</a>.
        /// </summary>
        [<CustomOperation "copy_if_unmodified_since">]
        member _.CopyIfUnmodifiedSince(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.CopyIfUnmodifiedSince <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#customer_algorithm-1">S3ObjectCopy#customer_algorithm</a>.
        /// </summary>
        [<CustomOperation "customer_algorithm">]
        member _.CustomerAlgorithm(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.CustomerAlgorithm <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#customer_key-1">S3ObjectCopy#customer_key</a>.
        /// </summary>
        [<CustomOperation "customer_key">]
        member _.CustomerKey(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.CustomerKey <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#customer_key_md5-1">S3ObjectCopy#customer_key_md5</a>.
        /// </summary>
        [<CustomOperation "customer_key_md5">]
        member _.CustomerKeyMd5(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.CustomerKeyMd5 <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#expected_bucket_owner-1">S3ObjectCopy#expected_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "expected_bucket_owner">]
        member _.ExpectedBucketOwner(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.ExpectedBucketOwner <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#expected_source_bucket_owner-1">S3ObjectCopy#expected_source_bucket_owner</a>.
        /// </summary>
        [<CustomOperation "expected_source_bucket_owner">]
        member _.ExpectedSourceBucketOwner(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.ExpectedSourceBucketOwner <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#expires-1">S3ObjectCopy#expires</a>.
        /// </summary>
        [<CustomOperation "expires">]
        member _.Expires(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.Expires <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#force_destroy-1">S3ObjectCopy#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: bool) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#force_destroy-1">S3ObjectCopy#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: HashiCorp.Cdktf.IResolvable) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// grant block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#grant-1">S3ObjectCopy#grant</a> Accepts: aws.IResolvable | aws.S3ObjectCopy.S3ObjectCopyGrant[]
        /// </summary>
        [<CustomOperation "grant">]
        member _.Grant(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: HashiCorp.Cdktf.IResolvable) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.Grant <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#id-1">S3ObjectCopy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#kms_encryption_context-1">S3ObjectCopy#kms_encryption_context</a>.
        /// </summary>
        [<CustomOperation "kms_encryption_context">]
        member _.KmsEncryptionContext(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.KmsEncryptionContext <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#kms_key_id-1">S3ObjectCopy#kms_key_id</a>.
        /// </summary>
        [<CustomOperation "kms_key_id">]
        member _.KmsKeyId(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.KmsKeyId <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#metadata-1">S3ObjectCopy#metadata</a>.
        /// </summary>
        [<CustomOperation "metadata">]
        member _.Metadata(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: seq<string * string>) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.Metadata <- dict value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#metadata_directive-1">S3ObjectCopy#metadata_directive</a>.
        /// </summary>
        [<CustomOperation "metadata_directive">]
        member _.MetadataDirective(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.MetadataDirective <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#object_lock_legal_hold_status-1">S3ObjectCopy#object_lock_legal_hold_status</a>.
        /// </summary>
        [<CustomOperation "object_lock_legal_hold_status">]
        member _.ObjectLockLegalHoldStatus(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.ObjectLockLegalHoldStatus <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#object_lock_mode-1">S3ObjectCopy#object_lock_mode</a>.
        /// </summary>
        [<CustomOperation "object_lock_mode">]
        member _.ObjectLockMode(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.ObjectLockMode <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#object_lock_retain_until_date-1">S3ObjectCopy#object_lock_retain_until_date</a>.
        /// </summary>
        [<CustomOperation "object_lock_retain_until_date">]
        member _.ObjectLockRetainUntilDate(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.ObjectLockRetainUntilDate <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// override_provider block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#override_provider-1">S3ObjectCopy#override_provider</a>
        /// </summary>
        [<CustomOperation "override_provider">]
        member _.OverrideProvider(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: aws.S3ObjectCopy.S3ObjectCopyOverrideProvider) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.OverrideProvider <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#request_payer-1">S3ObjectCopy#request_payer</a>.
        /// </summary>
        [<CustomOperation "request_payer">]
        member _.RequestPayer(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.RequestPayer <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#server_side_encryption-1">S3ObjectCopy#server_side_encryption</a>.
        /// </summary>
        [<CustomOperation "server_side_encryption">]
        member _.ServerSideEncryption(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.ServerSideEncryption <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#source_customer_algorithm-1">S3ObjectCopy#source_customer_algorithm</a>.
        /// </summary>
        [<CustomOperation "source_customer_algorithm">]
        member _.SourceCustomerAlgorithm(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.SourceCustomerAlgorithm <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#source_customer_key-1">S3ObjectCopy#source_customer_key</a>.
        /// </summary>
        [<CustomOperation "source_customer_key">]
        member _.SourceCustomerKey(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.SourceCustomerKey <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#source_customer_key_md5-1">S3ObjectCopy#source_customer_key_md5</a>.
        /// </summary>
        [<CustomOperation "source_customer_key_md5">]
        member _.SourceCustomerKeyMd5(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.SourceCustomerKeyMd5 <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#storage_class-1">S3ObjectCopy#storage_class</a>.
        /// </summary>
        [<CustomOperation "storage_class">]
        member _.StorageClass(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.StorageClass <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#tagging_directive-1">S3ObjectCopy#tagging_directive</a>.
        /// </summary>
        [<CustomOperation "tagging_directive">]
        member _.TaggingDirective(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.TaggingDirective <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#tags-1">S3ObjectCopy#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: seq<string * string>) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#tags_all-1">S3ObjectCopy#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: seq<string * string>) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_object_copy#website_redirect-1">S3ObjectCopy#website_redirect</a>.
        /// </summary>
        [<CustomOperation "website_redirect">]
        member _.WebsiteRedirect(state: S3ObjectCopyState<'Bucket, 'Key, 'Source>, value: string) : S3ObjectCopyState<'Bucket, 'Key, 'Source> =
            state.assignments.Add(fun config -> config.WebsiteRedirect <- value)
            state : S3ObjectCopyState<'Bucket, 'Key, 'Source>

        member _.Run(state: S3ObjectCopyState<Present, Present, Present>) : aws.S3ObjectCopy.S3ObjectCopy =
            let config = aws.S3ObjectCopy.S3ObjectCopyConfig()
            for setter in state.assignments do
                setter config
            aws.S3ObjectCopy.S3ObjectCopy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3ObjectCopy: missing required arguments. Must call: bucket, key, source.", 9999, IsError = true)>]
        member _.Run(_: S3ObjectCopyState<_, _, _>) : aws.S3ObjectCopy.S3ObjectCopy =
            Unchecked.defaultof<aws.S3ObjectCopy.S3ObjectCopy>
