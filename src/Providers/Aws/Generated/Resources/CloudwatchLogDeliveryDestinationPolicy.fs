namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudwatchLogDeliveryDestinationPolicyState<'DeliveryDestinationName, 'DeliveryDestinationPolicy> = { assignments: ResizeArray<aws.CloudwatchLogDeliveryDestinationPolicy.CloudwatchLogDeliveryDestinationPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_destination_policy">aws_cloudwatch_log_delivery_destination_policy</a>.
    /// </summary>
    type CloudwatchLogDeliveryDestinationPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudwatchLogDeliveryDestinationPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogDeliveryDestinationPolicyState<Missing, Missing>)

        member _.Zero(()) : CloudwatchLogDeliveryDestinationPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudwatchLogDeliveryDestinationPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_destination_policy#delivery_destination_name-1">CloudwatchLogDeliveryDestinationPolicy#delivery_destination_name</a>.
        /// </summary>
        [<CustomOperation "delivery_destination_name">]
        member _.DeliveryDestinationName(state: CloudwatchLogDeliveryDestinationPolicyState<Missing, 'DeliveryDestinationPolicy>, value: string) : CloudwatchLogDeliveryDestinationPolicyState<Present, 'DeliveryDestinationPolicy> =
            state.assignments.Add(fun config -> config.DeliveryDestinationName <- value)
            ({ assignments = state.assignments } : CloudwatchLogDeliveryDestinationPolicyState<Present, 'DeliveryDestinationPolicy>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudwatch_log_delivery_destination_policy#delivery_destination_policy-1">CloudwatchLogDeliveryDestinationPolicy#delivery_destination_policy</a>.
        /// </summary>
        [<CustomOperation "delivery_destination_policy">]
        member _.DeliveryDestinationPolicy(state: CloudwatchLogDeliveryDestinationPolicyState<'DeliveryDestinationName, Missing>, value: string) : CloudwatchLogDeliveryDestinationPolicyState<'DeliveryDestinationName, Present> =
            state.assignments.Add(fun config -> config.DeliveryDestinationPolicy <- value)
            ({ assignments = state.assignments } : CloudwatchLogDeliveryDestinationPolicyState<'DeliveryDestinationName, Present>)

        member _.Run(state: CloudwatchLogDeliveryDestinationPolicyState<Present, Present>) : aws.CloudwatchLogDeliveryDestinationPolicy.CloudwatchLogDeliveryDestinationPolicy =
            let config = aws.CloudwatchLogDeliveryDestinationPolicy.CloudwatchLogDeliveryDestinationPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.CloudwatchLogDeliveryDestinationPolicy.CloudwatchLogDeliveryDestinationPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudwatchLogDeliveryDestinationPolicy: missing required arguments. Must call: delivery_destination_name, delivery_destination_policy.", 9999, IsError = true)>]
        member _.Run(_: CloudwatchLogDeliveryDestinationPolicyState<_, _>) : aws.CloudwatchLogDeliveryDestinationPolicy.CloudwatchLogDeliveryDestinationPolicy =
            Unchecked.defaultof<aws.CloudwatchLogDeliveryDestinationPolicy.CloudwatchLogDeliveryDestinationPolicy>
