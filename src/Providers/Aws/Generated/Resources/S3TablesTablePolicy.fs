namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3TablesTablePolicyState<'Name, 'Namespace, 'ResourcePolicy, 'TableBucketArn> = { assignments: ResizeArray<aws.S3TablesTablePolicy.S3TablesTablePolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_policy">aws_s3tables_table_policy</a>.
    /// </summary>
    type S3TablesTablePolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3TablesTablePolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3TablesTablePolicyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : S3TablesTablePolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3TablesTablePolicyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_policy#name-1">S3TablesTablePolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: S3TablesTablePolicyState<Missing, 'Namespace, 'ResourcePolicy, 'TableBucketArn>, value: string) : S3TablesTablePolicyState<Present, 'Namespace, 'ResourcePolicy, 'TableBucketArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : S3TablesTablePolicyState<Present, 'Namespace, 'ResourcePolicy, 'TableBucketArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_policy#namespace-1">S3TablesTablePolicy#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: S3TablesTablePolicyState<'Name, Missing, 'ResourcePolicy, 'TableBucketArn>, value: string) : S3TablesTablePolicyState<'Name, Present, 'ResourcePolicy, 'TableBucketArn> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            ({ assignments = state.assignments } : S3TablesTablePolicyState<'Name, Present, 'ResourcePolicy, 'TableBucketArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_policy#resource_policy-1">S3TablesTablePolicy#resource_policy</a>.
        /// </summary>
        [<CustomOperation "resource_policy">]
        member _.ResourcePolicy(state: S3TablesTablePolicyState<'Name, 'Namespace, Missing, 'TableBucketArn>, value: string) : S3TablesTablePolicyState<'Name, 'Namespace, Present, 'TableBucketArn> =
            state.assignments.Add(fun config -> config.ResourcePolicy <- value)
            ({ assignments = state.assignments } : S3TablesTablePolicyState<'Name, 'Namespace, Present, 'TableBucketArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_policy#table_bucket_arn-1">S3TablesTablePolicy#table_bucket_arn</a>.
        /// </summary>
        [<CustomOperation "table_bucket_arn">]
        member _.TableBucketArn(state: S3TablesTablePolicyState<'Name, 'Namespace, 'ResourcePolicy, Missing>, value: string) : S3TablesTablePolicyState<'Name, 'Namespace, 'ResourcePolicy, Present> =
            state.assignments.Add(fun config -> config.TableBucketArn <- value)
            ({ assignments = state.assignments } : S3TablesTablePolicyState<'Name, 'Namespace, 'ResourcePolicy, Present>)

        member _.Run(state: S3TablesTablePolicyState<Present, Present, Present, Present>) : aws.S3TablesTablePolicy.S3TablesTablePolicy =
            let config = aws.S3TablesTablePolicy.S3TablesTablePolicyConfig()
            for setter in state.assignments do
                setter config
            aws.S3TablesTablePolicy.S3TablesTablePolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3TablesTablePolicy: missing required arguments. Must call: name, namespace, resource_policy, table_bucket_arn.", 9999, IsError = true)>]
        member _.Run(_: S3TablesTablePolicyState<_, _, _, _>) : aws.S3TablesTablePolicy.S3TablesTablePolicy =
            Unchecked.defaultof<aws.S3TablesTablePolicy.S3TablesTablePolicy>
