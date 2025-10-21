namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailLbHttpsRedirectionPolicyState<'Enabled, 'LbName> = { assignments: ResizeArray<aws.LightsailLbHttpsRedirectionPolicy.LightsailLbHttpsRedirectionPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_https_redirection_policy">aws_lightsail_lb_https_redirection_policy</a>.
    /// </summary>
    type LightsailLbHttpsRedirectionPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailLbHttpsRedirectionPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailLbHttpsRedirectionPolicyState<Missing, Missing>)

        member _.Zero(()) : LightsailLbHttpsRedirectionPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailLbHttpsRedirectionPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_https_redirection_policy#enabled-1">LightsailLbHttpsRedirectionPolicy#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LightsailLbHttpsRedirectionPolicyState<Missing, 'LbName>, value: bool) : LightsailLbHttpsRedirectionPolicyState<Present, 'LbName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : LightsailLbHttpsRedirectionPolicyState<Present, 'LbName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_https_redirection_policy#enabled-1">LightsailLbHttpsRedirectionPolicy#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: LightsailLbHttpsRedirectionPolicyState<Missing, 'LbName>, value: HashiCorp.Cdktf.IResolvable) : LightsailLbHttpsRedirectionPolicyState<Present, 'LbName> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            ({ assignments = state.assignments } : LightsailLbHttpsRedirectionPolicyState<Present, 'LbName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_https_redirection_policy#lb_name-1">LightsailLbHttpsRedirectionPolicy#lb_name</a>.
        /// </summary>
        [<CustomOperation "lb_name">]
        member _.LbName(state: LightsailLbHttpsRedirectionPolicyState<'Enabled, Missing>, value: string) : LightsailLbHttpsRedirectionPolicyState<'Enabled, Present> =
            state.assignments.Add(fun config -> config.LbName <- value)
            ({ assignments = state.assignments } : LightsailLbHttpsRedirectionPolicyState<'Enabled, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_lb_https_redirection_policy#id-1">LightsailLbHttpsRedirectionPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailLbHttpsRedirectionPolicyState<'Enabled, 'LbName>, value: string) : LightsailLbHttpsRedirectionPolicyState<'Enabled, 'LbName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailLbHttpsRedirectionPolicyState<'Enabled, 'LbName>

        member _.Run(state: LightsailLbHttpsRedirectionPolicyState<Present, Present>) : aws.LightsailLbHttpsRedirectionPolicy.LightsailLbHttpsRedirectionPolicy =
            let config = aws.LightsailLbHttpsRedirectionPolicy.LightsailLbHttpsRedirectionPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailLbHttpsRedirectionPolicy.LightsailLbHttpsRedirectionPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailLbHttpsRedirectionPolicy: missing required arguments. Must call: enabled, lb_name.", 9999, IsError = true)>]
        member _.Run(_: LightsailLbHttpsRedirectionPolicyState<_, _>) : aws.LightsailLbHttpsRedirectionPolicy.LightsailLbHttpsRedirectionPolicy =
            Unchecked.defaultof<aws.LightsailLbHttpsRedirectionPolicy.LightsailLbHttpsRedirectionPolicy>
