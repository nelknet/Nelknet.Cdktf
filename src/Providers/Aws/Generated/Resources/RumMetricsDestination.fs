namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RumMetricsDestinationState<'AppMonitorName, 'Destination> = { assignments: ResizeArray<aws.RumMetricsDestination.RumMetricsDestinationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_metrics_destination">aws_rum_metrics_destination</a>.
    /// </summary>
    type RumMetricsDestinationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RumMetricsDestinationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RumMetricsDestinationState<Missing, Missing>)

        member _.Zero(()) : RumMetricsDestinationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : RumMetricsDestinationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_metrics_destination#app_monitor_name-1">RumMetricsDestination#app_monitor_name</a>.
        /// </summary>
        [<CustomOperation "app_monitor_name">]
        member _.AppMonitorName(state: RumMetricsDestinationState<Missing, 'Destination>, value: string) : RumMetricsDestinationState<Present, 'Destination> =
            state.assignments.Add(fun config -> config.AppMonitorName <- value)
            ({ assignments = state.assignments } : RumMetricsDestinationState<Present, 'Destination>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_metrics_destination#destination-1">RumMetricsDestination#destination</a>.
        /// </summary>
        [<CustomOperation "destination">]
        member _.Destination(state: RumMetricsDestinationState<'AppMonitorName, Missing>, value: string) : RumMetricsDestinationState<'AppMonitorName, Present> =
            state.assignments.Add(fun config -> config.Destination <- value)
            ({ assignments = state.assignments } : RumMetricsDestinationState<'AppMonitorName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_metrics_destination#destination_arn-1">RumMetricsDestination#destination_arn</a>.
        /// </summary>
        [<CustomOperation "destination_arn">]
        member _.DestinationArn(state: RumMetricsDestinationState<'AppMonitorName, 'Destination>, value: string) : RumMetricsDestinationState<'AppMonitorName, 'Destination> =
            state.assignments.Add(fun config -> config.DestinationArn <- value)
            state : RumMetricsDestinationState<'AppMonitorName, 'Destination>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_metrics_destination#iam_role_arn-1">RumMetricsDestination#iam_role_arn</a>.
        /// </summary>
        [<CustomOperation "iam_role_arn">]
        member _.IamRoleArn(state: RumMetricsDestinationState<'AppMonitorName, 'Destination>, value: string) : RumMetricsDestinationState<'AppMonitorName, 'Destination> =
            state.assignments.Add(fun config -> config.IamRoleArn <- value)
            state : RumMetricsDestinationState<'AppMonitorName, 'Destination>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rum_metrics_destination#id-1">RumMetricsDestination#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RumMetricsDestinationState<'AppMonitorName, 'Destination>, value: string) : RumMetricsDestinationState<'AppMonitorName, 'Destination> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RumMetricsDestinationState<'AppMonitorName, 'Destination>

        member _.Run(state: RumMetricsDestinationState<Present, Present>) : aws.RumMetricsDestination.RumMetricsDestination =
            let config = aws.RumMetricsDestination.RumMetricsDestinationConfig()
            for setter in state.assignments do
                setter config
            aws.RumMetricsDestination.RumMetricsDestination(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rumMetricsDestination: missing required arguments. Must call: app_monitor_name, destination.", 9999, IsError = true)>]
        member _.Run(_: RumMetricsDestinationState<_, _>) : aws.RumMetricsDestination.RumMetricsDestination =
            Unchecked.defaultof<aws.RumMetricsDestination.RumMetricsDestination>
