namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppCookieStickinessPolicyState<'CookieName, 'LbPort, 'LoadBalancer, 'Name> = { assignments: ResizeArray<aws.AppCookieStickinessPolicy.AppCookieStickinessPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/app_cookie_stickiness_policy">aws_app_cookie_stickiness_policy</a>.
    /// </summary>
    type AppCookieStickinessPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppCookieStickinessPolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppCookieStickinessPolicyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppCookieStickinessPolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppCookieStickinessPolicyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/app_cookie_stickiness_policy#cookie_name-1">AppCookieStickinessPolicy#cookie_name</a>.
        /// </summary>
        [<CustomOperation "cookie_name">]
        member _.CookieName(state: AppCookieStickinessPolicyState<Missing, 'LbPort, 'LoadBalancer, 'Name>, value: string) : AppCookieStickinessPolicyState<Present, 'LbPort, 'LoadBalancer, 'Name> =
            state.assignments.Add(fun config -> config.CookieName <- value)
            ({ assignments = state.assignments } : AppCookieStickinessPolicyState<Present, 'LbPort, 'LoadBalancer, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/app_cookie_stickiness_policy#lb_port-1">AppCookieStickinessPolicy#lb_port</a>.
        /// </summary>
        [<CustomOperation "lb_port">]
        member _.LbPort(state: AppCookieStickinessPolicyState<'CookieName, Missing, 'LoadBalancer, 'Name>, value: double) : AppCookieStickinessPolicyState<'CookieName, Present, 'LoadBalancer, 'Name> =
            state.assignments.Add(fun config -> config.LbPort <- value)
            ({ assignments = state.assignments } : AppCookieStickinessPolicyState<'CookieName, Present, 'LoadBalancer, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/app_cookie_stickiness_policy#load_balancer-1">AppCookieStickinessPolicy#load_balancer</a>.
        /// </summary>
        [<CustomOperation "load_balancer">]
        member _.LoadBalancer(state: AppCookieStickinessPolicyState<'CookieName, 'LbPort, Missing, 'Name>, value: string) : AppCookieStickinessPolicyState<'CookieName, 'LbPort, Present, 'Name> =
            state.assignments.Add(fun config -> config.LoadBalancer <- value)
            ({ assignments = state.assignments } : AppCookieStickinessPolicyState<'CookieName, 'LbPort, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/app_cookie_stickiness_policy#name-1">AppCookieStickinessPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppCookieStickinessPolicyState<'CookieName, 'LbPort, 'LoadBalancer, Missing>, value: string) : AppCookieStickinessPolicyState<'CookieName, 'LbPort, 'LoadBalancer, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppCookieStickinessPolicyState<'CookieName, 'LbPort, 'LoadBalancer, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/app_cookie_stickiness_policy#id-1">AppCookieStickinessPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppCookieStickinessPolicyState<'CookieName, 'LbPort, 'LoadBalancer, 'Name>, value: string) : AppCookieStickinessPolicyState<'CookieName, 'LbPort, 'LoadBalancer, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppCookieStickinessPolicyState<'CookieName, 'LbPort, 'LoadBalancer, 'Name>

        member _.Run(state: AppCookieStickinessPolicyState<Present, Present, Present, Present>) : aws.AppCookieStickinessPolicy.AppCookieStickinessPolicy =
            let config = aws.AppCookieStickinessPolicy.AppCookieStickinessPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.AppCookieStickinessPolicy.AppCookieStickinessPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appCookieStickinessPolicy: missing required arguments. Must call: cookie_name, lb_port, load_balancer, name.", 9999, IsError = true)>]
        member _.Run(_: AppCookieStickinessPolicyState<_, _, _, _>) : aws.AppCookieStickinessPolicy.AppCookieStickinessPolicy =
            Unchecked.defaultof<aws.AppCookieStickinessPolicy.AppCookieStickinessPolicy>
