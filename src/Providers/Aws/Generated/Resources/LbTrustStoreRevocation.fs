namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbTrustStoreRevocationState<'RevocationsS3Bucket, 'RevocationsS3Key, 'TrustStoreArn> = { assignments: ResizeArray<aws.LbTrustStoreRevocation.LbTrustStoreRevocationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store_revocation">aws_lb_trust_store_revocation</a>.
    /// </summary>
    type LbTrustStoreRevocationBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbTrustStoreRevocationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbTrustStoreRevocationState<Missing, Missing, Missing>)

        member _.Zero(()) : LbTrustStoreRevocationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbTrustStoreRevocationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store_revocation#revocations_s3_bucket-1">LbTrustStoreRevocation#revocations_s3_bucket</a>.
        /// </summary>
        [<CustomOperation "revocations_s3_bucket">]
        member _.RevocationsS3Bucket(state: LbTrustStoreRevocationState<Missing, 'RevocationsS3Key, 'TrustStoreArn>, value: string) : LbTrustStoreRevocationState<Present, 'RevocationsS3Key, 'TrustStoreArn> =
            state.assignments.Add(fun config -> config.RevocationsS3Bucket <- value)
            ({ assignments = state.assignments } : LbTrustStoreRevocationState<Present, 'RevocationsS3Key, 'TrustStoreArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store_revocation#revocations_s3_key-1">LbTrustStoreRevocation#revocations_s3_key</a>.
        /// </summary>
        [<CustomOperation "revocations_s3_key">]
        member _.RevocationsS3Key(state: LbTrustStoreRevocationState<'RevocationsS3Bucket, Missing, 'TrustStoreArn>, value: string) : LbTrustStoreRevocationState<'RevocationsS3Bucket, Present, 'TrustStoreArn> =
            state.assignments.Add(fun config -> config.RevocationsS3Key <- value)
            ({ assignments = state.assignments } : LbTrustStoreRevocationState<'RevocationsS3Bucket, Present, 'TrustStoreArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store_revocation#trust_store_arn-1">LbTrustStoreRevocation#trust_store_arn</a>.
        /// </summary>
        [<CustomOperation "trust_store_arn">]
        member _.TrustStoreArn(state: LbTrustStoreRevocationState<'RevocationsS3Bucket, 'RevocationsS3Key, Missing>, value: string) : LbTrustStoreRevocationState<'RevocationsS3Bucket, 'RevocationsS3Key, Present> =
            state.assignments.Add(fun config -> config.TrustStoreArn <- value)
            ({ assignments = state.assignments } : LbTrustStoreRevocationState<'RevocationsS3Bucket, 'RevocationsS3Key, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store_revocation#id-1">LbTrustStoreRevocation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbTrustStoreRevocationState<'RevocationsS3Bucket, 'RevocationsS3Key, 'TrustStoreArn>, value: string) : LbTrustStoreRevocationState<'RevocationsS3Bucket, 'RevocationsS3Key, 'TrustStoreArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbTrustStoreRevocationState<'RevocationsS3Bucket, 'RevocationsS3Key, 'TrustStoreArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store_revocation#revocations_s3_object_version-1">LbTrustStoreRevocation#revocations_s3_object_version</a>.
        /// </summary>
        [<CustomOperation "revocations_s3_object_version">]
        member _.RevocationsS3ObjectVersion(state: LbTrustStoreRevocationState<'RevocationsS3Bucket, 'RevocationsS3Key, 'TrustStoreArn>, value: string) : LbTrustStoreRevocationState<'RevocationsS3Bucket, 'RevocationsS3Key, 'TrustStoreArn> =
            state.assignments.Add(fun config -> config.RevocationsS3ObjectVersion <- value)
            state : LbTrustStoreRevocationState<'RevocationsS3Bucket, 'RevocationsS3Key, 'TrustStoreArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_trust_store_revocation#timeouts-1">LbTrustStoreRevocation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LbTrustStoreRevocationState<'RevocationsS3Bucket, 'RevocationsS3Key, 'TrustStoreArn>, value: aws.LbTrustStoreRevocation.LbTrustStoreRevocationTimeouts) : LbTrustStoreRevocationState<'RevocationsS3Bucket, 'RevocationsS3Key, 'TrustStoreArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LbTrustStoreRevocationState<'RevocationsS3Bucket, 'RevocationsS3Key, 'TrustStoreArn>

        member _.Run(state: LbTrustStoreRevocationState<Present, Present, Present>) : aws.LbTrustStoreRevocation.LbTrustStoreRevocation =
            let config = aws.LbTrustStoreRevocation.LbTrustStoreRevocationConfig()
            for setter in state.assignments do
                setter config
            aws.LbTrustStoreRevocation.LbTrustStoreRevocation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lbTrustStoreRevocation: missing required arguments. Must call: revocations_s3_bucket, revocations_s3_key, trust_store_arn.", 9999, IsError = true)>]
        member _.Run(_: LbTrustStoreRevocationState<_, _, _>) : aws.LbTrustStoreRevocation.LbTrustStoreRevocation =
            Unchecked.defaultof<aws.LbTrustStoreRevocation.LbTrustStoreRevocation>
