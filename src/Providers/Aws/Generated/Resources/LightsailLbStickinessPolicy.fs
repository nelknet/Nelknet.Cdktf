namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailLbStickinessPolicyState<'CookieDuration, 'Enabled, 'LbName> = { assignments: ResizeArray<aws.LightsailLbStickinessPolicy.LightsailLbStickinessPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_stickiness_policy">aws_lightsail_lb_stickiness_policy</a>.
    /// </summary>
    type LightsailLbStickinessPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailLbStickinessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailLbStickinessPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : LightsailLbStickinessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailLbStickinessPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_stickiness_policy#cookie_duration-1">LightsailLbStickinessPolicy#cookie_duration</a>.
        /// </summary>
        [<CustomOperation "cookie_duration">]
        member _.CookieDuration(state: LightsailLbStickinessPolicyState<Missing, 'Enabled, 'LbName>, value: double) : LightsailLbStickinessPolicyState<Present, 'Enabled, 'LbName> =
            state.assignments.Add(fun config -> config.CookieDuration <- value)
            ({ assignments = state.assignments } : LightsailLbStickinessPolicyState<Present, 'Enabled, 'LbName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_stickiness_policy#enabled-1">LightsailLbStickinessPolicy#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LightsailLbStickinessPolicyState<'CookieDuration, Missing, 'LbName>, value: bool) : LightsailLbStickinessPolicyState<'CookieDuration, Present, 'LbName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : LightsailLbStickinessPolicyState<'CookieDuration, Present, 'LbName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_stickiness_policy#enabled-1">LightsailLbStickinessPolicy#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LightsailLbStickinessPolicyState<'CookieDuration, Missing, 'LbName>, value: HashiCorp.Cdktf.IResolvable) : LightsailLbStickinessPolicyState<'CookieDuration, Present, 'LbName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : LightsailLbStickinessPolicyState<'CookieDuration, Present, 'LbName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_stickiness_policy#lb_name-1">LightsailLbStickinessPolicy#lb_name</a>.
        /// </summary>
        [<CustomOperation "lb_name">]
        member _.LbName(state: LightsailLbStickinessPolicyState<'CookieDuration, 'Enabled, Missing>, value: string) : LightsailLbStickinessPolicyState<'CookieDuration, 'Enabled, Present> =
            state.assignments.Add(fun config -> config.LbName <- value)
            ({ assignments = state.assignments } : LightsailLbStickinessPolicyState<'CookieDuration, 'Enabled, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_stickiness_policy#id-1">LightsailLbStickinessPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailLbStickinessPolicyState<'CookieDuration, 'Enabled, 'LbName>, value: string) : LightsailLbStickinessPolicyState<'CookieDuration, 'Enabled, 'LbName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailLbStickinessPolicyState<'CookieDuration, 'Enabled, 'LbName>

        member _.Run(state: LightsailLbStickinessPolicyState<Present, Present, Present>) : aws.LightsailLbStickinessPolicy.LightsailLbStickinessPolicy =
            let config = aws.LightsailLbStickinessPolicy.LightsailLbStickinessPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailLbStickinessPolicy.LightsailLbStickinessPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailLbStickinessPolicy: missing required arguments. Must call: cookie_duration, enabled, lb_name.", 9999, IsError = true)>]
        member _.Run(_: LightsailLbStickinessPolicyState<_, _, _>) : aws.LightsailLbStickinessPolicy.LightsailLbStickinessPolicy =
            Unchecked.defaultof<aws.LightsailLbStickinessPolicy.LightsailLbStickinessPolicy>
