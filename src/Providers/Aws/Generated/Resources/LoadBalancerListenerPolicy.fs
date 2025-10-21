namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LoadBalancerListenerPolicyState<'LoadBalancerName, 'LoadBalancerPort> = { assignments: ResizeArray<aws.LoadBalancerListenerPolicy.LoadBalancerListenerPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_listener_policy">aws_load_balancer_listener_policy</a>.
    /// </summary>
    type LoadBalancerListenerPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : LoadBalancerListenerPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LoadBalancerListenerPolicyState<Missing, Missing>)

        member _.Zero(()) : LoadBalancerListenerPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LoadBalancerListenerPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_listener_policy#load_balancer_name-1">LoadBalancerListenerPolicy#load_balancer_name</a>.
        /// </summary>
        [<CustomOperation "load_balancer_name">]
        member _.LoadBalancerName(state: LoadBalancerListenerPolicyState<Missing, 'LoadBalancerPort>, value: string) : LoadBalancerListenerPolicyState<Present, 'LoadBalancerPort> =
            state.assignments.Add(fun config -> config.LoadBalancerName <- value)
            ({ assignments = state.assignments } : LoadBalancerListenerPolicyState<Present, 'LoadBalancerPort>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_listener_policy#load_balancer_port-1">LoadBalancerListenerPolicy#load_balancer_port</a>.
        /// </summary>
        [<CustomOperation "load_balancer_port">]
        member _.LoadBalancerPort(state: LoadBalancerListenerPolicyState<'LoadBalancerName, Missing>, value: double) : LoadBalancerListenerPolicyState<'LoadBalancerName, Present> =
            state.assignments.Add(fun config -> config.LoadBalancerPort <- value)
            ({ assignments = state.assignments } : LoadBalancerListenerPolicyState<'LoadBalancerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_listener_policy#id-1">LoadBalancerListenerPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LoadBalancerListenerPolicyState<'LoadBalancerName, 'LoadBalancerPort>, value: string) : LoadBalancerListenerPolicyState<'LoadBalancerName, 'LoadBalancerPort> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LoadBalancerListenerPolicyState<'LoadBalancerName, 'LoadBalancerPort>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_listener_policy#policy_names-1">LoadBalancerListenerPolicy#policy_names</a>.
        /// </summary>
        [<CustomOperation "policy_names">]
        member _.PolicyNames(state: LoadBalancerListenerPolicyState<'LoadBalancerName, 'LoadBalancerPort>, value: seq<string>) : LoadBalancerListenerPolicyState<'LoadBalancerName, 'LoadBalancerPort> =
            state.assignments.Add(fun config -> config.PolicyNames <- (value |> Seq.toArray))
            state : LoadBalancerListenerPolicyState<'LoadBalancerName, 'LoadBalancerPort>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_listener_policy#triggers-1">LoadBalancerListenerPolicy#triggers</a>.
        /// </summary>
        [<CustomOperation "triggers">]
        member _.Triggers(state: LoadBalancerListenerPolicyState<'LoadBalancerName, 'LoadBalancerPort>, value: seq<string * string>) : LoadBalancerListenerPolicyState<'LoadBalancerName, 'LoadBalancerPort> =
            state.assignments.Add(fun config -> config.Triggers <- dict value)
            state : LoadBalancerListenerPolicyState<'LoadBalancerName, 'LoadBalancerPort>

        member _.Run(state: LoadBalancerListenerPolicyState<Present, Present>) : aws.LoadBalancerListenerPolicy.LoadBalancerListenerPolicy =
            let config = aws.LoadBalancerListenerPolicy.LoadBalancerListenerPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.LoadBalancerListenerPolicy.LoadBalancerListenerPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.loadBalancerListenerPolicy: missing required arguments. Must call: load_balancer_name, load_balancer_port.", 9999, IsError = true)>]
        member _.Run(_: LoadBalancerListenerPolicyState<_, _>) : aws.LoadBalancerListenerPolicy.LoadBalancerListenerPolicy =
            Unchecked.defaultof<aws.LoadBalancerListenerPolicy.LoadBalancerListenerPolicy>
