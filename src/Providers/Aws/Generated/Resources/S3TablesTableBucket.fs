namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type S3TablesTableBucketState<'Name> = { assignments: ResizeArray<aws.S3TablesTableBucket.S3TablesTableBucketConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket">aws_s3tables_table_bucket</a>.
    /// </summary>
    type S3TablesTableBucketBuilder(logicalId: string) =
        member _.Yield(_: unit) : S3TablesTableBucketState<Missing> =
            ({ assignments = ResizeArray() } : S3TablesTableBucketState<Missing>)

        member _.Zero(()) : S3TablesTableBucketState<Missing> =
            ({ assignments = ResizeArray() } : S3TablesTableBucketState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#name-1">S3TablesTableBucket#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: S3TablesTableBucketState<Missing>, value: string) : S3TablesTableBucketState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : S3TablesTableBucketState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#encryption_configuration-1">S3TablesTableBucket#encryption_configuration</a>.
        /// </summary>
        [<CustomOperation "encryption_configuration">]
        member _.EncryptionConfiguration(state: S3TablesTableBucketState<'Name>, value: aws.S3TablesTableBucket.S3TablesTableBucketEncryptionConfiguration) : S3TablesTableBucketState<'Name> =
            state.assignments.Add(fun config -> config.EncryptionConfiguration <- value)
            state : S3TablesTableBucketState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3tables_table_bucket#maintenance_configuration-1">S3TablesTableBucket#maintenance_configuration</a>.
        /// </summary>
        [<CustomOperation "maintenance_configuration">]
        member _.MaintenanceConfiguration(state: S3TablesTableBucketState<'Name>, value: aws.S3TablesTableBucket.S3TablesTableBucketMaintenanceConfiguration) : S3TablesTableBucketState<'Name> =
            state.assignments.Add(fun config -> config.MaintenanceConfiguration <- value)
            state : S3TablesTableBucketState<'Name>

        member _.Run(state: S3TablesTableBucketState<Present>) : aws.S3TablesTableBucket.S3TablesTableBucket =
            let config = aws.S3TablesTableBucket.S3TablesTableBucketConfig()
            for setter in state.assignments do
                setter config
            aws.S3TablesTableBucket.S3TablesTableBucket(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.s3TablesTableBucket: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: S3TablesTableBucketState<_>) : aws.S3TablesTableBucket.S3TablesTableBucket =
            Unchecked.defaultof<aws.S3TablesTableBucket.S3TablesTableBucket>
