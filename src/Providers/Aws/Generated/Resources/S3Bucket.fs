namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3BucketState = { assignments: ResizeArray<aws.S3Bucket.S3BucketConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket">aws_s3_bucket</a>.
    /// </summary>
    type S3BucketBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3BucketState =
            { assignments = ResizeArray() }

        member _.Zero(()) : S3BucketState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#acceleration_status-1">S3Bucket#acceleration_status</a>.
        /// </summary>
        [<CustomOperation "acceleration_status">]
        member _.AccelerationStatus(state: S3BucketState, value: string) : S3BucketState =
            state.assignments.Add(fun config -> config.AccelerationStatus <- value)
            state : S3BucketState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#acl-1">S3Bucket#acl</a>.
        /// </summary>
        [<CustomOperation "acl">]
        member _.Acl(state: S3BucketState, value: string) : S3BucketState =
            state.assignments.Add(fun config -> config.Acl <- value)
            state : S3BucketState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#bucket-1">S3Bucket#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: S3BucketState, value: string) : S3BucketState =
            state.assignments.Add(fun config -> config.Bucket <- value)
            state : S3BucketState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#bucket_prefix-1">S3Bucket#bucket_prefix</a>.
        /// </summary>
        [<CustomOperation "bucket_prefix">]
        member _.BucketPrefix(state: S3BucketState, value: string) : S3BucketState =
            state.assignments.Add(fun config -> config.BucketPrefix <- value)
            state : S3BucketState

        /// <summary>
        /// cors_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#cors_rule-1">S3Bucket#cors_rule</a> Accepts: aws.IResolvable | aws.S3Bucket.S3BucketCorsRule[]
        /// </summary>
        [<CustomOperation "cors_rule">]
        member _.CorsRule(state: S3BucketState, value: HashiCorp.Cdktf.IResolvable) : S3BucketState =
            state.assignments.Add(fun config -> config.CorsRule <- value)
            state : S3BucketState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#force_destroy-1">S3Bucket#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: S3BucketState, value: bool) : S3BucketState =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : S3BucketState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#force_destroy-1">S3Bucket#force_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_destroy">]
        member _.ForceDestroy(state: S3BucketState, value: HashiCorp.Cdktf.IResolvable) : S3BucketState =
            state.assignments.Add(fun config -> config.ForceDestroy <- value)
            state : S3BucketState

        /// <summary>
        /// grant block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#grant-1">S3Bucket#grant</a> Accepts: aws.IResolvable | aws.S3Bucket.S3BucketGrant[]
        /// </summary>
        [<CustomOperation "grant">]
        member _.Grant(state: S3BucketState, value: HashiCorp.Cdktf.IResolvable) : S3BucketState =
            state.assignments.Add(fun config -> config.Grant <- value)
            state : S3BucketState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#id-1">S3Bucket#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: S3BucketState, value: string) : S3BucketState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : S3BucketState

        /// <summary>
        /// lifecycle_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#lifecycle_rule-1">S3Bucket#lifecycle_rule</a> Accepts: aws.IResolvable | aws.S3Bucket.S3BucketLifecycleRule[]
        /// </summary>
        [<CustomOperation "lifecycle_rule">]
        member _.LifecycleRule(state: S3BucketState, value: HashiCorp.Cdktf.IResolvable) : S3BucketState =
            state.assignments.Add(fun config -> config.LifecycleRule <- value)
            state : S3BucketState

        /// <summary>
        /// logging block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#logging-1">S3Bucket#logging</a>
        /// </summary>
        [<CustomOperation "logging">]
        member _.Logging(state: S3BucketState, value: aws.S3Bucket.S3BucketLogging) : S3BucketState =
            state.assignments.Add(fun config -> config.Logging <- value)
            state : S3BucketState

        /// <summary>
        /// object_lock_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#object_lock_configuration-1">S3Bucket#object_lock_configuration</a>
        /// </summary>
        [<CustomOperation "object_lock_configuration">]
        member _.ObjectLockConfiguration(state: S3BucketState, value: aws.S3Bucket.S3BucketObjectLockConfiguration) : S3BucketState =
            state.assignments.Add(fun config -> config.ObjectLockConfiguration <- value)
            state : S3BucketState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#object_lock_enabled-1">S3Bucket#object_lock_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "object_lock_enabled">]
        member _.ObjectLockEnabled(state: S3BucketState, value: bool) : S3BucketState =
            state.assignments.Add(fun config -> config.ObjectLockEnabled <- value)
            state : S3BucketState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#object_lock_enabled-1">S3Bucket#object_lock_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "object_lock_enabled">]
        member _.ObjectLockEnabled(state: S3BucketState, value: HashiCorp.Cdktf.IResolvable) : S3BucketState =
            state.assignments.Add(fun config -> config.ObjectLockEnabled <- value)
            state : S3BucketState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#policy-1">S3Bucket#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: S3BucketState, value: string) : S3BucketState =
            state.assignments.Add(fun config -> config.Policy <- value)
            state : S3BucketState

        /// <summary>
        /// replication_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#replication_configuration-1">S3Bucket#replication_configuration</a>
        /// </summary>
        [<CustomOperation "replication_configuration">]
        member _.ReplicationConfiguration(state: S3BucketState, value: aws.S3Bucket.S3BucketReplicationConfiguration) : S3BucketState =
            state.assignments.Add(fun config -> config.ReplicationConfiguration <- value)
            state : S3BucketState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#request_payer-1">S3Bucket#request_payer</a>.
        /// </summary>
        [<CustomOperation "request_payer">]
        member _.RequestPayer(state: S3BucketState, value: string) : S3BucketState =
            state.assignments.Add(fun config -> config.RequestPayer <- value)
            state : S3BucketState

        /// <summary>
        /// server_side_encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#server_side_encryption_configuration-1">S3Bucket#server_side_encryption_configuration</a>
        /// </summary>
        [<CustomOperation "server_side_encryption_configuration">]
        member _.ServerSideEncryptionConfiguration(state: S3BucketState, value: aws.S3Bucket.S3BucketServerSideEncryptionConfiguration) : S3BucketState =
            state.assignments.Add(fun config -> config.ServerSideEncryptionConfiguration <- value)
            state : S3BucketState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#tags-1">S3Bucket#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: S3BucketState, value: seq<string * string>) : S3BucketState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : S3BucketState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#tags_all-1">S3Bucket#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: S3BucketState, value: seq<string * string>) : S3BucketState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : S3BucketState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#timeouts-1">S3Bucket#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: S3BucketState, value: aws.S3Bucket.S3BucketTimeouts) : S3BucketState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : S3BucketState

        /// <summary>
        /// versioning block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#versioning-1">S3Bucket#versioning</a>
        /// </summary>
        [<CustomOperation "versioning">]
        member _.Versioning(state: S3BucketState, value: aws.S3Bucket.S3BucketVersioning) : S3BucketState =
            state.assignments.Add(fun config -> config.Versioning <- value)
            state : S3BucketState

        /// <summary>
        /// website block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_bucket#website-1">S3Bucket#website</a>
        /// </summary>
        [<CustomOperation "website">]
        member _.Website(state: S3BucketState, value: aws.S3Bucket.S3BucketWebsite) : S3BucketState =
            state.assignments.Add(fun config -> config.Website <- value)
            state : S3BucketState

        member _.Run(state: S3BucketState) : aws.S3Bucket.S3Bucket =
            let config = aws.S3Bucket.S3BucketConfig()
            for setter in state.assignments do
                setter config
            aws.S3Bucket.S3Bucket(StackContext.get (), logicalId, config)
