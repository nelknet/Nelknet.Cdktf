namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbSslNegotiationPolicyState<'LbPort, 'LoadBalancer, 'Name> = { assignments: ResizeArray<aws.LbSslNegotiationPolicy.LbSslNegotiationPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_ssl_negotiation_policy">aws_lb_ssl_negotiation_policy</a>.
    /// </summary>
    type LbSslNegotiationPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbSslNegotiationPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbSslNegotiationPolicyState<Missing, Missing, Missing>)

        member _.Zero(()) : LbSslNegotiationPolicyState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbSslNegotiationPolicyState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_ssl_negotiation_policy#lb_port-1">LbSslNegotiationPolicy#lb_port</a>.
        /// </summary>
        [<CustomOperation "lb_port">]
        member _.LbPort(state: LbSslNegotiationPolicyState<Missing, 'LoadBalancer, 'Name>, value: double) : LbSslNegotiationPolicyState<Present, 'LoadBalancer, 'Name> =
            state.assignments.Add(fun config -> config.LbPort <- value)
            ({ assignments = state.assignments } : LbSslNegotiationPolicyState<Present, 'LoadBalancer, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_ssl_negotiation_policy#load_balancer-1">LbSslNegotiationPolicy#load_balancer</a>.
        /// </summary>
        [<CustomOperation "load_balancer">]
        member _.LoadBalancer(state: LbSslNegotiationPolicyState<'LbPort, Missing, 'Name>, value: string) : LbSslNegotiationPolicyState<'LbPort, Present, 'Name> =
            state.assignments.Add(fun config -> config.LoadBalancer <- value)
            ({ assignments = state.assignments } : LbSslNegotiationPolicyState<'LbPort, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_ssl_negotiation_policy#name-1">LbSslNegotiationPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LbSslNegotiationPolicyState<'LbPort, 'LoadBalancer, Missing>, value: string) : LbSslNegotiationPolicyState<'LbPort, 'LoadBalancer, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LbSslNegotiationPolicyState<'LbPort, 'LoadBalancer, Present>)

        /// <summary>
        /// attribute block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_ssl_negotiation_policy#attribute-1">LbSslNegotiationPolicy#attribute</a> Accepts: aws.IResolvable | aws.LbSslNegotiationPolicy.LbSslNegotiationPolicyAttribute[]
        /// </summary>
        [<CustomOperation "attribute">]
        member _.Attribute(state: LbSslNegotiationPolicyState<'LbPort, 'LoadBalancer, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LbSslNegotiationPolicyState<'LbPort, 'LoadBalancer, 'Name> =
            state.assignments.Add(fun config -> config.Attribute <- value)
            state : LbSslNegotiationPolicyState<'LbPort, 'LoadBalancer, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_ssl_negotiation_policy#id-1">LbSslNegotiationPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbSslNegotiationPolicyState<'LbPort, 'LoadBalancer, 'Name>, value: string) : LbSslNegotiationPolicyState<'LbPort, 'LoadBalancer, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbSslNegotiationPolicyState<'LbPort, 'LoadBalancer, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lb_ssl_negotiation_policy#triggers-1">LbSslNegotiationPolicy#triggers</a>.
        /// </summary>
        [<CustomOperation "triggers">]
        member _.Triggers(state: LbSslNegotiationPolicyState<'LbPort, 'LoadBalancer, 'Name>, value: seq<string * string>) : LbSslNegotiationPolicyState<'LbPort, 'LoadBalancer, 'Name> =
            state.assignments.Add(fun config -> config.Triggers <- dict value)
            state : LbSslNegotiationPolicyState<'LbPort, 'LoadBalancer, 'Name>

        member _.Run(state: LbSslNegotiationPolicyState<Present, Present, Present>) : aws.LbSslNegotiationPolicy.LbSslNegotiationPolicy =
            let config = aws.LbSslNegotiationPolicy.LbSslNegotiationPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.LbSslNegotiationPolicy.LbSslNegotiationPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lbSslNegotiationPolicy: missing required arguments. Must call: lb_port, load_balancer, name.", 9999, IsError = true)>]
        member _.Run(_: LbSslNegotiationPolicyState<_, _, _>) : aws.LbSslNegotiationPolicy.LbSslNegotiationPolicy =
            Unchecked.defaultof<aws.LbSslNegotiationPolicy.LbSslNegotiationPolicy>
