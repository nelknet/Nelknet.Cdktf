namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3TablesNamespaceState<'Namespace, 'TableBucketArn> = { assignments: ResizeArray<aws.S3TablesNamespace.S3TablesNamespaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_namespace">aws_s3tables_namespace</a>.
    /// </summary>
    type S3TablesNamespaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3TablesNamespaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3TablesNamespaceState<Missing, Missing>)

        member _.Zero(()) : S3TablesNamespaceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : S3TablesNamespaceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_namespace#namespace-1">S3TablesNamespace#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: S3TablesNamespaceState<Missing, 'TableBucketArn>, value: string) : S3TablesNamespaceState<Present, 'TableBucketArn> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            ({ assignments = state.assignments } : S3TablesNamespaceState<Present, 'TableBucketArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_namespace#table_bucket_arn-1">S3TablesNamespace#table_bucket_arn</a>.
        /// </summary>
        [<CustomOperation "table_bucket_arn">]
        member _.TableBucketArn(state: S3TablesNamespaceState<'Namespace, Missing>, value: string) : S3TablesNamespaceState<'Namespace, Present> =
            state.assignments.Add(fun config -> config.TableBucketArn <- value)
            ({ assignments = state.assignments } : S3TablesNamespaceState<'Namespace, Present>)

        member _.Run(state: S3TablesNamespaceState<Present, Present>) : aws.S3TablesNamespace.S3TablesNamespace =
            let config = aws.S3TablesNamespace.S3TablesNamespaceConfig()
            for setter in state.assignments do
                setter config
            aws.S3TablesNamespace.S3TablesNamespace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3TablesNamespace: missing required arguments. Must call: namespace, table_bucket_arn.", 9999, IsError = true)>]
        member _.Run(_: S3TablesNamespaceState<_, _>) : aws.S3TablesNamespace.S3TablesNamespace =
            Unchecked.defaultof<aws.S3TablesNamespace.S3TablesNamespace>
