namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedshiftLoggingState<'ClusterIdentifier> = { assignments: ResizeArray<aws.RedshiftLogging.RedshiftLoggingConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_logging">aws_redshift_logging</a>.
    /// </summary>
    type RedshiftLoggingBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedshiftLoggingState<Missing> =
            ({ assignments = ResizeArray() } : RedshiftLoggingState<Missing>)

        member _.Zero(()) : RedshiftLoggingState<Missing> =
            ({ assignments = ResizeArray() } : RedshiftLoggingState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_logging#cluster_identifier-1">RedshiftLogging#cluster_identifier</a>.
        /// </summary>
        [<CustomOperation "cluster_identifier">]
        member _.ClusterIdentifier(state: RedshiftLoggingState<Missing>, value: string) : RedshiftLoggingState<Present> =
            state.assignments.Add(fun config -> config.ClusterIdentifier <- value)
            ({ assignments = state.assignments } : RedshiftLoggingState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_logging#bucket_name-1">RedshiftLogging#bucket_name</a>.
        /// </summary>
        [<CustomOperation "bucket_name">]
        member _.BucketName(state: RedshiftLoggingState<'ClusterIdentifier>, value: string) : RedshiftLoggingState<'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.BucketName <- value)
            state : RedshiftLoggingState<'ClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_logging#log_destination_type-1">RedshiftLogging#log_destination_type</a>.
        /// </summary>
        [<CustomOperation "log_destination_type">]
        member _.LogDestinationType(state: RedshiftLoggingState<'ClusterIdentifier>, value: string) : RedshiftLoggingState<'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.LogDestinationType <- value)
            state : RedshiftLoggingState<'ClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_logging#log_exports-1">RedshiftLogging#log_exports</a>.
        /// </summary>
        [<CustomOperation "log_exports">]
        member _.LogExports(state: RedshiftLoggingState<'ClusterIdentifier>, value: seq<string>) : RedshiftLoggingState<'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.LogExports <- (value |> Seq.toArray))
            state : RedshiftLoggingState<'ClusterIdentifier>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/redshift_logging#s3_key_prefix-1">RedshiftLogging#s3_key_prefix</a>.
        /// </summary>
        [<CustomOperation "s3_key_prefix">]
        member _.S3KeyPrefix(state: RedshiftLoggingState<'ClusterIdentifier>, value: string) : RedshiftLoggingState<'ClusterIdentifier> =
            state.assignments.Add(fun config -> config.S3KeyPrefix <- value)
            state : RedshiftLoggingState<'ClusterIdentifier>

        member _.Run(state: RedshiftLoggingState<Present>) : aws.RedshiftLogging.RedshiftLogging =
            let config = aws.RedshiftLogging.RedshiftLoggingConfig()
            for setter in state.assignments do
                setter config
            aws.RedshiftLogging.RedshiftLogging(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.redshiftLogging: missing required arguments. Must call: cluster_identifier.", 9999, IsError = true)>]
        member _.Run(_: RedshiftLoggingState<_>) : aws.RedshiftLogging.RedshiftLogging =
            Unchecked.defaultof<aws.RedshiftLogging.RedshiftLogging>
