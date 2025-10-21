namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ProxyProtocolPolicyState<'InstancePorts, 'LoadBalancer> = { assignments: ResizeArray<aws.ProxyProtocolPolicy.ProxyProtocolPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/proxy_protocol_policy">aws_proxy_protocol_policy</a>.
    /// </summary>
    type ProxyProtocolPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : ProxyProtocolPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ProxyProtocolPolicyState<Missing, Missing>)

        member _.Zero(()) : ProxyProtocolPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ProxyProtocolPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/proxy_protocol_policy#instance_ports-1">ProxyProtocolPolicy#instance_ports</a>.
        /// </summary>
        [<CustomOperation "instance_ports">]
        member _.InstancePorts(state: ProxyProtocolPolicyState<Missing, 'LoadBalancer>, value: seq<string>) : ProxyProtocolPolicyState<Present, 'LoadBalancer> =
            state.assignments.Add(fun config -> config.InstancePorts <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ProxyProtocolPolicyState<Present, 'LoadBalancer>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/proxy_protocol_policy#load_balancer-1">ProxyProtocolPolicy#load_balancer</a>.
        /// </summary>
        [<CustomOperation "load_balancer">]
        member _.LoadBalancer(state: ProxyProtocolPolicyState<'InstancePorts, Missing>, value: string) : ProxyProtocolPolicyState<'InstancePorts, Present> =
            state.assignments.Add(fun config -> config.LoadBalancer <- value)
            ({ assignments = state.assignments } : ProxyProtocolPolicyState<'InstancePorts, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/proxy_protocol_policy#id-1">ProxyProtocolPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ProxyProtocolPolicyState<'InstancePorts, 'LoadBalancer>, value: string) : ProxyProtocolPolicyState<'InstancePorts, 'LoadBalancer> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ProxyProtocolPolicyState<'InstancePorts, 'LoadBalancer>

        member _.Run(state: ProxyProtocolPolicyState<Present, Present>) : aws.ProxyProtocolPolicy.ProxyProtocolPolicy =
            let config = aws.ProxyProtocolPolicy.ProxyProtocolPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.ProxyProtocolPolicy.ProxyProtocolPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.proxyProtocolPolicy: missing required arguments. Must call: instance_ports, load_balancer.", 9999, IsError = true)>]
        member _.Run(_: ProxyProtocolPolicyState<_, _>) : aws.ProxyProtocolPolicy.ProxyProtocolPolicy =
            Unchecked.defaultof<aws.ProxyProtocolPolicy.ProxyProtocolPolicy>
