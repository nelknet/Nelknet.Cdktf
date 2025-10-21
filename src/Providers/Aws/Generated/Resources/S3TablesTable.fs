namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3TablesTableState<'Format, 'Name, 'Namespace, 'TableBucketArn> = { assignments: ResizeArray<aws.S3TablesTable.S3TablesTableConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table">aws_s3tables_table</a>.
    /// </summary>
    type S3TablesTableBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3TablesTableState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3TablesTableState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : S3TablesTableState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : S3TablesTableState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#format-1">S3TablesTable#format</a>.
        /// </summary>
        [<CustomOperation "format">]
        member _.Format(state: S3TablesTableState<Missing, 'Name, 'Namespace, 'TableBucketArn>, value: string) : S3TablesTableState<Present, 'Name, 'Namespace, 'TableBucketArn> =
            state.assignments.Add(fun config -> config.Format <- value)
            ({ assignments = state.assignments } : S3TablesTableState<Present, 'Name, 'Namespace, 'TableBucketArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#name-1">S3TablesTable#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: S3TablesTableState<'Format, Missing, 'Namespace, 'TableBucketArn>, value: string) : S3TablesTableState<'Format, Present, 'Namespace, 'TableBucketArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : S3TablesTableState<'Format, Present, 'Namespace, 'TableBucketArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#namespace-1">S3TablesTable#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: S3TablesTableState<'Format, 'Name, Missing, 'TableBucketArn>, value: string) : S3TablesTableState<'Format, 'Name, Present, 'TableBucketArn> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            ({ assignments = state.assignments } : S3TablesTableState<'Format, 'Name, Present, 'TableBucketArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#table_bucket_arn-1">S3TablesTable#table_bucket_arn</a>.
        /// </summary>
        [<CustomOperation "table_bucket_arn">]
        member _.TableBucketArn(state: S3TablesTableState<'Format, 'Name, 'Namespace, Missing>, value: string) : S3TablesTableState<'Format, 'Name, 'Namespace, Present> =
            state.assignments.Add(fun config -> config.TableBucketArn <- value)
            ({ assignments = state.assignments } : S3TablesTableState<'Format, 'Name, 'Namespace, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#encryption_configuration-1">S3TablesTable#encryption_configuration</a>.
        /// </summary>
        [<CustomOperation "encryption_configuration">]
        member _.EncryptionConfiguration(state: S3TablesTableState<'Format, 'Name, 'Namespace, 'TableBucketArn>, value: aws.S3TablesTable.S3TablesTableEncryptionConfiguration) : S3TablesTableState<'Format, 'Name, 'Namespace, 'TableBucketArn> =
            state.assignments.Add(fun config -> config.EncryptionConfiguration <- value)
            state : S3TablesTableState<'Format, 'Name, 'Namespace, 'TableBucketArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table#maintenance_configuration-1">S3TablesTable#maintenance_configuration</a>.
        /// </summary>
        [<CustomOperation "maintenance_configuration">]
        member _.MaintenanceConfiguration(state: S3TablesTableState<'Format, 'Name, 'Namespace, 'TableBucketArn>, value: aws.S3TablesTable.S3TablesTableMaintenanceConfiguration) : S3TablesTableState<'Format, 'Name, 'Namespace, 'TableBucketArn> =
            state.assignments.Add(fun config -> config.MaintenanceConfiguration <- value)
            state : S3TablesTableState<'Format, 'Name, 'Namespace, 'TableBucketArn>

        member _.Run(state: S3TablesTableState<Present, Present, Present, Present>) : aws.S3TablesTable.S3TablesTable =
            let config = aws.S3TablesTable.S3TablesTableConfig()
            for setter in state.assignments do
                setter config
            aws.S3TablesTable.S3TablesTable(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3TablesTable: missing required arguments. Must call: format, name, namespace, table_bucket_arn.", 9999, IsError = true)>]
        member _.Run(_: S3TablesTableState<_, _, _, _>) : aws.S3TablesTable.S3TablesTable =
            Unchecked.defaultof<aws.S3TablesTable.S3TablesTable>
