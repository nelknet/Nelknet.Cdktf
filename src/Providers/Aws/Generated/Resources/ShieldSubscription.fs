namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ShieldSubscriptionState = { assignments: ResizeArray<aws.ShieldSubscription.ShieldSubscriptionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_subscription">aws_shield_subscription</a>.
    /// </summary>
    type ShieldSubscriptionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ShieldSubscriptionState =
            { assignments = ResizeArray() }

        member _.Zero(()) : ShieldSubscriptionState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Whether to automatically renew the subscription when it expires. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_subscription#auto_renew-1">ShieldSubscription#auto_renew</a>
        /// </summary>
        [<CustomOperation "auto_renew">]
        member _.AutoRenew(state: ShieldSubscriptionState, value: string) : ShieldSubscriptionState =
            state.assignments.Add(fun config -> config.AutoRenew <- value)
            state : ShieldSubscriptionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_subscription#skip_destroy-1">ShieldSubscription#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: ShieldSubscriptionState, value: bool) : ShieldSubscriptionState =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : ShieldSubscriptionState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/shield_subscription#skip_destroy-1">ShieldSubscription#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: ShieldSubscriptionState, value: HashiCorp.Cdktf.IResolvable) : ShieldSubscriptionState =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : ShieldSubscriptionState

        member _.Run(state: ShieldSubscriptionState) : aws.ShieldSubscription.ShieldSubscription =
            let config = aws.ShieldSubscription.ShieldSubscriptionConfig()
            for setter in state.assignments do
                setter config
            aws.ShieldSubscription.ShieldSubscription(StackContext.get (), logicalId, config)
