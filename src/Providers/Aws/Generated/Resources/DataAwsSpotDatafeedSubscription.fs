namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSpotDatafeedSubscriptionState = { assignments: ResizeArray<aws.DataAwsSpotDatafeedSubscription.DataAwsSpotDatafeedSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/spot_datafeed_subscription">aws_spot_datafeed_subscription</a>.
    /// </summary>
    type DataAwsSpotDatafeedSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSpotDatafeedSubscriptionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsSpotDatafeedSubscriptionState =
            { assignments = ResizeArray() }



        member _.Run(state: DataAwsSpotDatafeedSubscriptionState) : aws.DataAwsSpotDatafeedSubscription.DataAwsSpotDatafeedSubscription =
            let config = aws.DataAwsSpotDatafeedSubscription.DataAwsSpotDatafeedSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSpotDatafeedSubscription.DataAwsSpotDatafeedSubscription(StackContext.get (), logicalId, config)
