namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcNetworkPerformanceMetricSubscriptionState<'Destination, 'Source> = { assignments: ResizeArray<aws.VpcNetworkPerformanceMetricSubscription.VpcNetworkPerformanceMetricSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_network_performance_metric_subscription">aws_vpc_network_performance_metric_subscription</a>.
    /// </summary>
    type VpcNetworkPerformanceMetricSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcNetworkPerformanceMetricSubscriptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcNetworkPerformanceMetricSubscriptionState<Missing, Missing>)

        member _.Zero(()) : VpcNetworkPerformanceMetricSubscriptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcNetworkPerformanceMetricSubscriptionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_network_performance_metric_subscription#destination-1">VpcNetworkPerformanceMetricSubscription#destination</a>.
        /// </summary>
        [<CustomOperation "destination">]
        member _.Destination(state: VpcNetworkPerformanceMetricSubscriptionState<Missing, 'Source>, value: string) : VpcNetworkPerformanceMetricSubscriptionState<Present, 'Source> =
            state.assignments.Add(fun config -> config.Destination <- value)
            ({ assignments = state.assignments } : VpcNetworkPerformanceMetricSubscriptionState<Present, 'Source>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_network_performance_metric_subscription#source-1">VpcNetworkPerformanceMetricSubscription#source</a>.
        /// </summary>
        [<CustomOperation "source">]
        member _.Source(state: VpcNetworkPerformanceMetricSubscriptionState<'Destination, Missing>, value: string) : VpcNetworkPerformanceMetricSubscriptionState<'Destination, Present> =
            state.assignments.Add(fun config -> config.Source <- value)
            ({ assignments = state.assignments } : VpcNetworkPerformanceMetricSubscriptionState<'Destination, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_network_performance_metric_subscription#id-1">VpcNetworkPerformanceMetricSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcNetworkPerformanceMetricSubscriptionState<'Destination, 'Source>, value: string) : VpcNetworkPerformanceMetricSubscriptionState<'Destination, 'Source> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcNetworkPerformanceMetricSubscriptionState<'Destination, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_network_performance_metric_subscription#metric-1">VpcNetworkPerformanceMetricSubscription#metric</a>.
        /// </summary>
        [<CustomOperation "metric">]
        member _.Metric(state: VpcNetworkPerformanceMetricSubscriptionState<'Destination, 'Source>, value: string) : VpcNetworkPerformanceMetricSubscriptionState<'Destination, 'Source> =
            state.assignments.Add(fun config -> config.Metric <- value)
            state : VpcNetworkPerformanceMetricSubscriptionState<'Destination, 'Source>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_network_performance_metric_subscription#statistic-1">VpcNetworkPerformanceMetricSubscription#statistic</a>.
        /// </summary>
        [<CustomOperation "statistic">]
        member _.Statistic(state: VpcNetworkPerformanceMetricSubscriptionState<'Destination, 'Source>, value: string) : VpcNetworkPerformanceMetricSubscriptionState<'Destination, 'Source> =
            state.assignments.Add(fun config -> config.Statistic <- value)
            state : VpcNetworkPerformanceMetricSubscriptionState<'Destination, 'Source>

        member _.Run(state: VpcNetworkPerformanceMetricSubscriptionState<Present, Present>) : aws.VpcNetworkPerformanceMetricSubscription.VpcNetworkPerformanceMetricSubscription =
            let config = aws.VpcNetworkPerformanceMetricSubscription.VpcNetworkPerformanceMetricSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.VpcNetworkPerformanceMetricSubscription.VpcNetworkPerformanceMetricSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcNetworkPerformanceMetricSubscription: missing required arguments. Must call: destination, source.", 9999, IsError = true)>]
        member _.Run(_: VpcNetworkPerformanceMetricSubscriptionState<_, _>) : aws.VpcNetworkPerformanceMetricSubscription.VpcNetworkPerformanceMetricSubscription =
            Unchecked.defaultof<aws.VpcNetworkPerformanceMetricSubscription.VpcNetworkPerformanceMetricSubscription>
