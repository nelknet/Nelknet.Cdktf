namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LoadBalancerTargetAState<'LoadBalancerId, 'Type> = { assignments: ResizeArray<hcloud.LoadBalancerTarget.LoadBalancerTargetAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target">hcloud_load_balancer_target</a>.
    /// </summary>
    type LoadBalancerTargetABuilder(logicalId: string) =
        member _.Yield(_: unit) : LoadBalancerTargetAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LoadBalancerTargetAState<Missing, Missing>)

        member _.Zero(()) : LoadBalancerTargetAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LoadBalancerTargetAState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#load_balancer_id-1">LoadBalancerTargetA#load_balancer_id</a>.
        /// </summary>
        [<CustomOperation "load_balancer_id">]
        member _.LoadBalancerId(state: LoadBalancerTargetAState<Missing, 'Type>, value: double) : LoadBalancerTargetAState<Present, 'Type> =
            state.assignments.Add(fun config -> config.LoadBalancerId <- value)
            ({ assignments = state.assignments } : LoadBalancerTargetAState<Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#type-1">LoadBalancerTargetA#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: LoadBalancerTargetAState<'LoadBalancerId, Missing>, value: string) : LoadBalancerTargetAState<'LoadBalancerId, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : LoadBalancerTargetAState<'LoadBalancerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#id-1">LoadBalancerTargetA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LoadBalancerTargetAState<'LoadBalancerId, 'Type>, value: string) : LoadBalancerTargetAState<'LoadBalancerId, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LoadBalancerTargetAState<'LoadBalancerId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#ip-1">LoadBalancerTargetA#ip</a>.
        /// </summary>
        [<CustomOperation "ip">]
        member _.Ip(state: LoadBalancerTargetAState<'LoadBalancerId, 'Type>, value: string) : LoadBalancerTargetAState<'LoadBalancerId, 'Type> =
            state.assignments.Add(fun config -> config.Ip <- value)
            state : LoadBalancerTargetAState<'LoadBalancerId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#label_selector-1">LoadBalancerTargetA#label_selector</a>.
        /// </summary>
        [<CustomOperation "label_selector">]
        member _.LabelSelector(state: LoadBalancerTargetAState<'LoadBalancerId, 'Type>, value: string) : LoadBalancerTargetAState<'LoadBalancerId, 'Type> =
            state.assignments.Add(fun config -> config.LabelSelector <- value)
            state : LoadBalancerTargetAState<'LoadBalancerId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#server_id-1">LoadBalancerTargetA#server_id</a>.
        /// </summary>
        [<CustomOperation "server_id">]
        member _.ServerId(state: LoadBalancerTargetAState<'LoadBalancerId, 'Type>, value: double) : LoadBalancerTargetAState<'LoadBalancerId, 'Type> =
            state.assignments.Add(fun config -> config.ServerId <- value)
            state : LoadBalancerTargetAState<'LoadBalancerId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#use_private_ip-1">LoadBalancerTargetA#use_private_ip</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "use_private_ip">]
        member _.UsePrivateIp(state: LoadBalancerTargetAState<'LoadBalancerId, 'Type>, value: bool) : LoadBalancerTargetAState<'LoadBalancerId, 'Type> =
            state.assignments.Add(fun config -> config.UsePrivateIp <- value)
            state : LoadBalancerTargetAState<'LoadBalancerId, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_target#use_private_ip-1">LoadBalancerTargetA#use_private_ip</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "use_private_ip">]
        member _.UsePrivateIp(state: LoadBalancerTargetAState<'LoadBalancerId, 'Type>, value: HashiCorp.Cdktf.IResolvable) : LoadBalancerTargetAState<'LoadBalancerId, 'Type> =
            state.assignments.Add(fun config -> config.UsePrivateIp <- value)
            state : LoadBalancerTargetAState<'LoadBalancerId, 'Type>

        member _.Run(state: LoadBalancerTargetAState<Present, Present>) : hcloud.LoadBalancerTarget.LoadBalancerTargetA =
            let config = hcloud.LoadBalancerTarget.LoadBalancerTargetAConfig()
            for setter in state.assignments do
                setter config
            hcloud.LoadBalancerTarget.LoadBalancerTargetA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.loadBalancerTargetA: missing required arguments. Must call: load_balancer_id, type.", 9999, IsError = true)>]
        member _.Run(_: LoadBalancerTargetAState<_, _>) : hcloud.LoadBalancerTarget.LoadBalancerTargetA =
            Unchecked.defaultof<hcloud.LoadBalancerTarget.LoadBalancerTargetA>
