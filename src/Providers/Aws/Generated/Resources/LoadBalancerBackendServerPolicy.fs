namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LoadBalancerBackendServerPolicyState<'InstancePort, 'LoadBalancerName> = { assignments: ResizeArray<aws.LoadBalancerBackendServerPolicy.LoadBalancerBackendServerPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_backend_server_policy">aws_load_balancer_backend_server_policy</a>.
    /// </summary>
    type LoadBalancerBackendServerPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : LoadBalancerBackendServerPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LoadBalancerBackendServerPolicyState<Missing, Missing>)

        member _.Zero(()) : LoadBalancerBackendServerPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LoadBalancerBackendServerPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_backend_server_policy#instance_port-1">LoadBalancerBackendServerPolicy#instance_port</a>.
        /// </summary>
        [<CustomOperation "instance_port">]
        member _.InstancePort(state: LoadBalancerBackendServerPolicyState<Missing, 'LoadBalancerName>, value: double) : LoadBalancerBackendServerPolicyState<Present, 'LoadBalancerName> =
            state.assignments.Add(fun config -> config.InstancePort <- value)
            ({ assignments = state.assignments } : LoadBalancerBackendServerPolicyState<Present, 'LoadBalancerName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_backend_server_policy#load_balancer_name-1">LoadBalancerBackendServerPolicy#load_balancer_name</a>.
        /// </summary>
        [<CustomOperation "load_balancer_name">]
        member _.LoadBalancerName(state: LoadBalancerBackendServerPolicyState<'InstancePort, Missing>, value: string) : LoadBalancerBackendServerPolicyState<'InstancePort, Present> =
            state.assignments.Add(fun config -> config.LoadBalancerName <- value)
            ({ assignments = state.assignments } : LoadBalancerBackendServerPolicyState<'InstancePort, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_backend_server_policy#id-1">LoadBalancerBackendServerPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LoadBalancerBackendServerPolicyState<'InstancePort, 'LoadBalancerName>, value: string) : LoadBalancerBackendServerPolicyState<'InstancePort, 'LoadBalancerName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LoadBalancerBackendServerPolicyState<'InstancePort, 'LoadBalancerName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/load_balancer_backend_server_policy#policy_names-1">LoadBalancerBackendServerPolicy#policy_names</a>.
        /// </summary>
        [<CustomOperation "policy_names">]
        member _.PolicyNames(state: LoadBalancerBackendServerPolicyState<'InstancePort, 'LoadBalancerName>, value: seq<string>) : LoadBalancerBackendServerPolicyState<'InstancePort, 'LoadBalancerName> =
            state.assignments.Add(fun config -> config.PolicyNames <- (value |> Seq.toArray))
            state : LoadBalancerBackendServerPolicyState<'InstancePort, 'LoadBalancerName>

        member _.Run(state: LoadBalancerBackendServerPolicyState<Present, Present>) : aws.LoadBalancerBackendServerPolicy.LoadBalancerBackendServerPolicy =
            let config = aws.LoadBalancerBackendServerPolicy.LoadBalancerBackendServerPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.LoadBalancerBackendServerPolicy.LoadBalancerBackendServerPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.loadBalancerBackendServerPolicy: missing required arguments. Must call: instance_port, load_balancer_name.", 9999, IsError = true)>]
        member _.Run(_: LoadBalancerBackendServerPolicyState<_, _>) : aws.LoadBalancerBackendServerPolicy.LoadBalancerBackendServerPolicy =
            Unchecked.defaultof<aws.LoadBalancerBackendServerPolicy.LoadBalancerBackendServerPolicy>
