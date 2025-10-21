namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontMonitoringSubscriptionState<'DistributionId, 'MonitoringSubscription> = { assignments: ResizeArray<aws.CloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_monitoring_subscription">aws_cloudfront_monitoring_subscription</a>.
    /// </summary>
    type CloudfrontMonitoringSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontMonitoringSubscriptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontMonitoringSubscriptionState<Missing, Missing>)

        member _.Zero(()) : CloudfrontMonitoringSubscriptionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontMonitoringSubscriptionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_monitoring_subscription#distribution_id-1">CloudfrontMonitoringSubscription#distribution_id</a>.
        /// </summary>
        [<CustomOperation "distribution_id">]
        member _.DistributionId(state: CloudfrontMonitoringSubscriptionState<Missing, 'MonitoringSubscription>, value: string) : CloudfrontMonitoringSubscriptionState<Present, 'MonitoringSubscription> =
            state.assignments.Add(fun config -> config.DistributionId <- value)
            ({ assignments = state.assignments } : CloudfrontMonitoringSubscriptionState<Present, 'MonitoringSubscription>)

        /// <summary>
        /// monitoring_subscription block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_monitoring_subscription#monitoring_subscription-1">CloudfrontMonitoringSubscription#monitoring_subscription</a>
        /// </summary>
        [<CustomOperation "monitoring_subscription">]
        member _.MonitoringSubscription(state: CloudfrontMonitoringSubscriptionState<'DistributionId, Missing>, value: aws.CloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionMonitoringSubscription) : CloudfrontMonitoringSubscriptionState<'DistributionId, Present> =
            state.assignments.Add(fun config -> config.MonitoringSubscription <- value)
            ({ assignments = state.assignments } : CloudfrontMonitoringSubscriptionState<'DistributionId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_monitoring_subscription#id-1">CloudfrontMonitoringSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudfrontMonitoringSubscriptionState<'DistributionId, 'MonitoringSubscription>, value: string) : CloudfrontMonitoringSubscriptionState<'DistributionId, 'MonitoringSubscription> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudfrontMonitoringSubscriptionState<'DistributionId, 'MonitoringSubscription>

        member _.Run(state: CloudfrontMonitoringSubscriptionState<Present, Present>) : aws.CloudfrontMonitoringSubscription.CloudfrontMonitoringSubscription =
            let config = aws.CloudfrontMonitoringSubscription.CloudfrontMonitoringSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontMonitoringSubscription.CloudfrontMonitoringSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontMonitoringSubscription: missing required arguments. Must call: distribution_id, monitoring_subscription.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontMonitoringSubscriptionState<_, _>) : aws.CloudfrontMonitoringSubscription.CloudfrontMonitoringSubscription =
            Unchecked.defaultof<aws.CloudfrontMonitoringSubscription.CloudfrontMonitoringSubscription>
