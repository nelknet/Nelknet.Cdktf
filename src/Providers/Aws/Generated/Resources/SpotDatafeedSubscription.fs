namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpotDatafeedSubscriptionState<'Bucket> = { assignments: ResizeArray<aws.SpotDatafeedSubscription.SpotDatafeedSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_datafeed_subscription">aws_spot_datafeed_subscription</a>.
    /// </summary>
    type SpotDatafeedSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpotDatafeedSubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : SpotDatafeedSubscriptionState<Missing>)

        member _.Zero(()) : SpotDatafeedSubscriptionState<Missing> =
            ({ assignments = ResizeArray() } : SpotDatafeedSubscriptionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_datafeed_subscription#bucket-1">SpotDatafeedSubscription#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: SpotDatafeedSubscriptionState<Missing>, value: string) : SpotDatafeedSubscriptionState<Present> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : SpotDatafeedSubscriptionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_datafeed_subscription#id-1">SpotDatafeedSubscription#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpotDatafeedSubscriptionState<'Bucket>, value: string) : SpotDatafeedSubscriptionState<'Bucket> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpotDatafeedSubscriptionState<'Bucket>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_datafeed_subscription#prefix-1">SpotDatafeedSubscription#prefix</a>.
        /// </summary>
        [<CustomOperation "prefix">]
        member _.Prefix(state: SpotDatafeedSubscriptionState<'Bucket>, value: string) : SpotDatafeedSubscriptionState<'Bucket> =
            state.assignments.Add(fun config -> config.Prefix <- value)
            state : SpotDatafeedSubscriptionState<'Bucket>

        member _.Run(state: SpotDatafeedSubscriptionState<Present>) : aws.SpotDatafeedSubscription.SpotDatafeedSubscription =
            let config = aws.SpotDatafeedSubscription.SpotDatafeedSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.SpotDatafeedSubscription.SpotDatafeedSubscription(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.spotDatafeedSubscription: missing required arguments. Must call: bucket.", 9999, IsError = true)>]
        member _.Run(_: SpotDatafeedSubscriptionState<_>) : aws.SpotDatafeedSubscription.SpotDatafeedSubscription =
            Unchecked.defaultof<aws.SpotDatafeedSubscription.SpotDatafeedSubscription>
