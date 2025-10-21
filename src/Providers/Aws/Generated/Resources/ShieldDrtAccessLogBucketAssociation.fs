namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ShieldDrtAccessLogBucketAssociationState<'LogBucket, 'RoleArnAssociationId> = { assignments: ResizeArray<aws.ShieldDrtAccessLogBucketAssociation.ShieldDrtAccessLogBucketAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_drt_access_log_bucket_association">aws_shield_drt_access_log_bucket_association</a>.
    /// </summary>
    type ShieldDrtAccessLogBucketAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ShieldDrtAccessLogBucketAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ShieldDrtAccessLogBucketAssociationState<Missing, Missing>)

        member _.Zero(()) : ShieldDrtAccessLogBucketAssociationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ShieldDrtAccessLogBucketAssociationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_drt_access_log_bucket_association#log_bucket-1">ShieldDrtAccessLogBucketAssociation#log_bucket</a>.
        /// </summary>
        [<CustomOperation "log_bucket">]
        member _.LogBucket(state: ShieldDrtAccessLogBucketAssociationState<Missing, 'RoleArnAssociationId>, value: string) : ShieldDrtAccessLogBucketAssociationState<Present, 'RoleArnAssociationId> =
            state.assignments.Add(fun config -> config.LogBucket <- value)
            ({ assignments = state.assignments } : ShieldDrtAccessLogBucketAssociationState<Present, 'RoleArnAssociationId>)

        /// <summary>
        /// Unused. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_drt_access_log_bucket_association#role_arn_association_id-1">ShieldDrtAccessLogBucketAssociation#role_arn_association_id</a>
        /// </summary>
        [<CustomOperation "role_arn_association_id">]
        member _.RoleArnAssociationId(state: ShieldDrtAccessLogBucketAssociationState<'LogBucket, Missing>, value: string) : ShieldDrtAccessLogBucketAssociationState<'LogBucket, Present> =
            state.assignments.Add(fun config -> config.RoleArnAssociationId <- value)
            ({ assignments = state.assignments } : ShieldDrtAccessLogBucketAssociationState<'LogBucket, Present>)

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_drt_access_log_bucket_association#timeouts-1">ShieldDrtAccessLogBucketAssociation#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ShieldDrtAccessLogBucketAssociationState<'LogBucket, 'RoleArnAssociationId>, value: aws.ShieldDrtAccessLogBucketAssociation.ShieldDrtAccessLogBucketAssociationTimeouts) : ShieldDrtAccessLogBucketAssociationState<'LogBucket, 'RoleArnAssociationId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ShieldDrtAccessLogBucketAssociationState<'LogBucket, 'RoleArnAssociationId>

        member _.Run(state: ShieldDrtAccessLogBucketAssociationState<Present, Present>) : aws.ShieldDrtAccessLogBucketAssociation.ShieldDrtAccessLogBucketAssociation =
            let config = aws.ShieldDrtAccessLogBucketAssociation.ShieldDrtAccessLogBucketAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.ShieldDrtAccessLogBucketAssociation.ShieldDrtAccessLogBucketAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.shieldDrtAccessLogBucketAssociation: missing required arguments. Must call: log_bucket, role_arn_association_id.", 9999, IsError = true)>]
        member _.Run(_: ShieldDrtAccessLogBucketAssociationState<_, _>) : aws.ShieldDrtAccessLogBucketAssociation.ShieldDrtAccessLogBucketAssociation =
            Unchecked.defaultof<aws.ShieldDrtAccessLogBucketAssociation.ShieldDrtAccessLogBucketAssociation>
