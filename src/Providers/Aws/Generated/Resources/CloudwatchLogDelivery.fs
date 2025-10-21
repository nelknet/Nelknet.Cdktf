namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogDeliveryState<'DeliveryDestinationArn, 'DeliverySourceName> = { assignments: ResizeArray<aws.CloudwatchLogDelivery.CloudwatchLogDeliveryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery">aws_cloudwatch_log_delivery</a>.
    /// </summary>
    type CloudwatchLogDeliveryBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogDeliveryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogDeliveryState<Missing, Missing>)

        member _.Zero(()) : CloudwatchLogDeliveryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogDeliveryState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery#delivery_destination_arn-1">CloudwatchLogDelivery#delivery_destination_arn</a>.
        /// </summary>
        [<CustomOperation "delivery_destination_arn">]
        member _.DeliveryDestinationArn(state: CloudwatchLogDeliveryState<Missing, 'DeliverySourceName>, value: string) : CloudwatchLogDeliveryState<Present, 'DeliverySourceName> =
            state.assignments.Add(fun config -> config.DeliveryDestinationArn <- value)
            ({ assignments = state.assignments } : CloudwatchLogDeliveryState<Present, 'DeliverySourceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery#delivery_source_name-1">CloudwatchLogDelivery#delivery_source_name</a>.
        /// </summary>
        [<CustomOperation "delivery_source_name">]
        member _.DeliverySourceName(state: CloudwatchLogDeliveryState<'DeliveryDestinationArn, Missing>, value: string) : CloudwatchLogDeliveryState<'DeliveryDestinationArn, Present> =
            state.assignments.Add(fun config -> config.DeliverySourceName <- value)
            ({ assignments = state.assignments } : CloudwatchLogDeliveryState<'DeliveryDestinationArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery#field_delimiter-1">CloudwatchLogDelivery#field_delimiter</a>.
        /// </summary>
        [<CustomOperation "field_delimiter">]
        member _.FieldDelimiter(state: CloudwatchLogDeliveryState<'DeliveryDestinationArn, 'DeliverySourceName>, value: string) : CloudwatchLogDeliveryState<'DeliveryDestinationArn, 'DeliverySourceName> =
            state.assignments.Add(fun config -> config.FieldDelimiter <- value)
            state : CloudwatchLogDeliveryState<'DeliveryDestinationArn, 'DeliverySourceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery#record_fields-1">CloudwatchLogDelivery#record_fields</a>.
        /// </summary>
        [<CustomOperation "record_fields">]
        member _.RecordFields(state: CloudwatchLogDeliveryState<'DeliveryDestinationArn, 'DeliverySourceName>, value: seq<string>) : CloudwatchLogDeliveryState<'DeliveryDestinationArn, 'DeliverySourceName> =
            state.assignments.Add(fun config -> config.RecordFields <- (value |> Seq.toArray))
            state : CloudwatchLogDeliveryState<'DeliveryDestinationArn, 'DeliverySourceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery#s3_delivery_configuration-1">CloudwatchLogDelivery#s3_delivery_configuration</a>. Accepts: aws.IResolvable | aws.CloudwatchLogDelivery.CloudwatchLogDeliveryS3DeliveryConfiguration[]
        /// </summary>
        [<CustomOperation "s3_delivery_configuration">]
        member _.S3DeliveryConfiguration(state: CloudwatchLogDeliveryState<'DeliveryDestinationArn, 'DeliverySourceName>, value: HashiCorp.Cdktf.IResolvable) : CloudwatchLogDeliveryState<'DeliveryDestinationArn, 'DeliverySourceName> =
            state.assignments.Add(fun config -> config.S3DeliveryConfiguration <- value)
            state : CloudwatchLogDeliveryState<'DeliveryDestinationArn, 'DeliverySourceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery#tags-1">CloudwatchLogDelivery#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudwatchLogDeliveryState<'DeliveryDestinationArn, 'DeliverySourceName>, value: seq<string * string>) : CloudwatchLogDeliveryState<'DeliveryDestinationArn, 'DeliverySourceName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudwatchLogDeliveryState<'DeliveryDestinationArn, 'DeliverySourceName>

        member _.Run(state: CloudwatchLogDeliveryState<Present, Present>) : aws.CloudwatchLogDelivery.CloudwatchLogDelivery =
            let config = aws.CloudwatchLogDelivery.CloudwatchLogDeliveryConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogDelivery.CloudwatchLogDelivery(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchLogDelivery: missing required arguments. Must call: delivery_destination_arn, delivery_source_name.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchLogDeliveryState<_, _>) : aws.CloudwatchLogDelivery.CloudwatchLogDelivery =
            Unchecked.defaultof<aws.CloudwatchLogDelivery.CloudwatchLogDelivery>
