namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbCookieStickinessPolicyState<'LbPort, 'LoadBalancer, 'Name> = { assignments: ResizeArray<aws.LbCookieStickinessPolicy.LbCookieStickinessPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_cookie_stickiness_policy">aws_lb_cookie_stickiness_policy</a>.
    /// </summary>
    type LbCookieStickinessPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbCookieStickinessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbCookieStickinessPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : LbCookieStickinessPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbCookieStickinessPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_cookie_stickiness_policy#lb_port-1">LbCookieStickinessPolicy#lb_port</a>.
        /// </summary>
        [<CustomOperation "lb_port">]
        member _.LbPort(state: LbCookieStickinessPolicyState<Missing, 'LoadBalancer, 'Name>, value: double) : LbCookieStickinessPolicyState<Present, 'LoadBalancer, 'Name> =
            state.assignments.Add(fun config -> config.LbPort <- value)
            ({ assignments = state.assignments } : LbCookieStickinessPolicyState<Present, 'LoadBalancer, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_cookie_stickiness_policy#load_balancer-1">LbCookieStickinessPolicy#load_balancer</a>.
        /// </summary>
        [<CustomOperation "load_balancer">]
        member _.LoadBalancer(state: LbCookieStickinessPolicyState<'LbPort, Missing, 'Name>, value: string) : LbCookieStickinessPolicyState<'LbPort, Present, 'Name> =
            state.assignments.Add(fun config -> config.LoadBalancer <- value)
            ({ assignments = state.assignments } : LbCookieStickinessPolicyState<'LbPort, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_cookie_stickiness_policy#name-1">LbCookieStickinessPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LbCookieStickinessPolicyState<'LbPort, 'LoadBalancer, Missing>, value: string) : LbCookieStickinessPolicyState<'LbPort, 'LoadBalancer, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LbCookieStickinessPolicyState<'LbPort, 'LoadBalancer, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_cookie_stickiness_policy#cookie_expiration_period-1">LbCookieStickinessPolicy#cookie_expiration_period</a>.
        /// </summary>
        [<CustomOperation "cookie_expiration_period">]
        member _.CookieExpirationPeriod(state: LbCookieStickinessPolicyState<'LbPort, 'LoadBalancer, 'Name>, value: double) : LbCookieStickinessPolicyState<'LbPort, 'LoadBalancer, 'Name> =
            state.assignments.Add(fun config -> config.CookieExpirationPeriod <- value)
            state : LbCookieStickinessPolicyState<'LbPort, 'LoadBalancer, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_cookie_stickiness_policy#id-1">LbCookieStickinessPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbCookieStickinessPolicyState<'LbPort, 'LoadBalancer, 'Name>, value: string) : LbCookieStickinessPolicyState<'LbPort, 'LoadBalancer, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbCookieStickinessPolicyState<'LbPort, 'LoadBalancer, 'Name>

        member _.Run(state: LbCookieStickinessPolicyState<Present, Present, Present>) : aws.LbCookieStickinessPolicy.LbCookieStickinessPolicy =
            let config = aws.LbCookieStickinessPolicy.LbCookieStickinessPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.LbCookieStickinessPolicy.LbCookieStickinessPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lbCookieStickinessPolicy: missing required arguments. Must call: lb_port, load_balancer, name.", 9999, IsError = true)>]
        member _.Run(_: LbCookieStickinessPolicyState<_, _, _>) : aws.LbCookieStickinessPolicy.LbCookieStickinessPolicy =
            Unchecked.defaultof<aws.LbCookieStickinessPolicy.LbCookieStickinessPolicy>
