namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key> = { assignments: ResizeArray<aws.LbTrustStore.LbTrustStoreConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store">aws_lb_trust_store</a>.
    /// </summary>
    type LbTrustStoreBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbTrustStoreState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LbTrustStoreState<Missing, Missing>)

        member _.Zero(()) : LbTrustStoreState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LbTrustStoreState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store#ca_certificates_bundle_s3_bucket-1">LbTrustStore#ca_certificates_bundle_s3_bucket</a>.
        /// </summary>
        [<CustomOperation "ca_certificates_bundle_s3_bucket">]
        member _.CaCertificatesBundleS3Bucket(state: LbTrustStoreState<Missing, 'CaCertificatesBundleS3Key>, value: string) : LbTrustStoreState<Present, 'CaCertificatesBundleS3Key> =
            state.assignments.Add(fun config -> config.CaCertificatesBundleS3Bucket <- value)
            ({ assignments = state.assignments } : LbTrustStoreState<Present, 'CaCertificatesBundleS3Key>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store#ca_certificates_bundle_s3_key-1">LbTrustStore#ca_certificates_bundle_s3_key</a>.
        /// </summary>
        [<CustomOperation "ca_certificates_bundle_s3_key">]
        member _.CaCertificatesBundleS3Key(state: LbTrustStoreState<'CaCertificatesBundleS3Bucket, Missing>, value: string) : LbTrustStoreState<'CaCertificatesBundleS3Bucket, Present> =
            state.assignments.Add(fun config -> config.CaCertificatesBundleS3Key <- value)
            ({ assignments = state.assignments } : LbTrustStoreState<'CaCertificatesBundleS3Bucket, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store#ca_certificates_bundle_s3_object_version-1">LbTrustStore#ca_certificates_bundle_s3_object_version</a>.
        /// </summary>
        [<CustomOperation "ca_certificates_bundle_s3_object_version">]
        member _.CaCertificatesBundleS3ObjectVersion(state: LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key>, value: string) : LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key> =
            state.assignments.Add(fun config -> config.CaCertificatesBundleS3ObjectVersion <- value)
            state : LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store#id-1">LbTrustStore#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key>, value: string) : LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store#name-1">LbTrustStore#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key>, value: string) : LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store#name_prefix-1">LbTrustStore#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key>, value: string) : LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store#tags-1">LbTrustStore#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key>, value: seq<string * string>) : LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store#tags_all-1">LbTrustStore#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key>, value: seq<string * string>) : LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store#timeouts-1">LbTrustStore#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key>, value: aws.LbTrustStore.LbTrustStoreTimeouts) : LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LbTrustStoreState<'CaCertificatesBundleS3Bucket, 'CaCertificatesBundleS3Key>

        member _.Run(state: LbTrustStoreState<Present, Present>) : aws.LbTrustStore.LbTrustStore =
            let config = aws.LbTrustStore.LbTrustStoreConfig()
            for setter in state.assignments do
                setter config
            aws.LbTrustStore.LbTrustStore(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lbTrustStore: missing required arguments. Must call: ca_certificates_bundle_s3_bucket, ca_certificates_bundle_s3_key.", 9999, IsError = true)>]
        member _.Run(_: LbTrustStoreState<_, _>) : aws.LbTrustStore.LbTrustStore =
            Unchecked.defaultof<aws.LbTrustStore.LbTrustStore>
