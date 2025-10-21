namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogDeliveryDestinationState<'Name> = { assignments: ResizeArray<aws.CloudwatchLogDeliveryDestination.CloudwatchLogDeliveryDestinationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_destination">aws_cloudwatch_log_delivery_destination</a>.
    /// </summary>
    type CloudwatchLogDeliveryDestinationBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogDeliveryDestinationState<Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogDeliveryDestinationState<Missing>)

        member _.Zero(()) : CloudwatchLogDeliveryDestinationState<Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogDeliveryDestinationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_destination#name-1">CloudwatchLogDeliveryDestination#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudwatchLogDeliveryDestinationState<Missing>, value: string) : CloudwatchLogDeliveryDestinationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudwatchLogDeliveryDestinationState<Present>)

        /// <summary>
        /// delivery_destination_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_destination#delivery_destination_configuration-1">CloudwatchLogDeliveryDestination#delivery_destination_configuration</a> Accepts: aws.IResolvable | aws.CloudwatchLogDeliveryDestination.CloudwatchLogDeliveryDestinationDeliveryDestinationConfiguration[]
        /// </summary>
        [<CustomOperation "delivery_destination_configuration">]
        member _.DeliveryDestinationConfiguration(state: CloudwatchLogDeliveryDestinationState<'Name>, value: HashiCorp.Cdktf.IResolvable) : CloudwatchLogDeliveryDestinationState<'Name> =
            state.assignments.Add(fun config -> config.DeliveryDestinationConfiguration <- value)
            state : CloudwatchLogDeliveryDestinationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_destination#output_format-1">CloudwatchLogDeliveryDestination#output_format</a>.
        /// </summary>
        [<CustomOperation "output_format">]
        member _.OutputFormat(state: CloudwatchLogDeliveryDestinationState<'Name>, value: string) : CloudwatchLogDeliveryDestinationState<'Name> =
            state.assignments.Add(fun config -> config.OutputFormat <- value)
            state : CloudwatchLogDeliveryDestinationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_destination#tags-1">CloudwatchLogDeliveryDestination#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CloudwatchLogDeliveryDestinationState<'Name>, value: seq<string * string>) : CloudwatchLogDeliveryDestinationState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CloudwatchLogDeliveryDestinationState<'Name>

        member _.Run(state: CloudwatchLogDeliveryDestinationState<Present>) : aws.CloudwatchLogDeliveryDestination.CloudwatchLogDeliveryDestination =
            let config = aws.CloudwatchLogDeliveryDestination.CloudwatchLogDeliveryDestinationConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogDeliveryDestination.CloudwatchLogDeliveryDestination(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchLogDeliveryDestination: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchLogDeliveryDestinationState<_>) : aws.CloudwatchLogDeliveryDestination.CloudwatchLogDeliveryDestination =
            Unchecked.defaultof<aws.CloudwatchLogDeliveryDestination.CloudwatchLogDeliveryDestination>
