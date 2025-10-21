namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3TablesTableBucketPolicyState<'ResourcePolicy, 'TableBucketArn> = { assignments: ResizeArray<aws.S3TablesTableBucketPolicy.S3TablesTableBucketPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket_policy">aws_s3tables_table_bucket_policy</a>.
    /// </summary>
    type S3TablesTableBucketPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3TablesTableBucketPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3TablesTableBucketPolicyState<Missing, Missing>)

        member _.Zero(()) : S3TablesTableBucketPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3TablesTableBucketPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket_policy#resource_policy-1">S3TablesTableBucketPolicy#resource_policy</a>.
        /// </summary>
        [<CustomOperation "resource_policy">]
        member _.ResourcePolicy(state: S3TablesTableBucketPolicyState<Missing, 'TableBucketArn>, value: string) : S3TablesTableBucketPolicyState<Present, 'TableBucketArn> =
            state.assignments.Add(fun config -> config.ResourcePolicy <- value)
            ({ assignments = state.assignments } : S3TablesTableBucketPolicyState<Present, 'TableBucketArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket_policy#table_bucket_arn-1">S3TablesTableBucketPolicy#table_bucket_arn</a>.
        /// </summary>
        [<CustomOperation "table_bucket_arn">]
        member _.TableBucketArn(state: S3TablesTableBucketPolicyState<'ResourcePolicy, Missing>, value: string) : S3TablesTableBucketPolicyState<'ResourcePolicy, Present> =
            state.assignments.Add(fun config -> config.TableBucketArn <- value)
            ({ assignments = state.assignments } : S3TablesTableBucketPolicyState<'ResourcePolicy, Present>)

        member _.Run(state: S3TablesTableBucketPolicyState<Present, Present>) : aws.S3TablesTableBucketPolicy.S3TablesTableBucketPolicy =
            let config = aws.S3TablesTableBucketPolicy.S3TablesTableBucketPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.S3TablesTableBucketPolicy.S3TablesTableBucketPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3TablesTableBucketPolicy: missing required arguments. Must call: resource_policy, table_bucket_arn.", 9999, IsError = true)>]
        member _.Run(_: S3TablesTableBucketPolicyState<_, _>) : aws.S3TablesTableBucketPolicy.S3TablesTableBucketPolicy =
            Unchecked.defaultof<aws.S3TablesTableBucketPolicy.S3TablesTableBucketPolicy>
