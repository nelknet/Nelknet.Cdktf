namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LoadBalancerNetworkState<'LoadBalancerId> = { assignments: ResizeArray<hcloud.LoadBalancerNetwork.LoadBalancerNetworkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network">hcloud_load_balancer_network</a>.
    /// </summary>
    type LoadBalancerNetworkBuilder(logicalId: string) =
        member _.Yield(_: unit) : LoadBalancerNetworkState<Missing> =
            ({ assignments = ResizeArray() } : LoadBalancerNetworkState<Missing>)

        member _.Zero(()) : LoadBalancerNetworkState<Missing> =
            ({ assignments = ResizeArray() } : LoadBalancerNetworkState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network#load_balancer_id-1">LoadBalancerNetwork#load_balancer_id</a>.
        /// </summary>
        [<CustomOperation "load_balancer_id">]
        member _.LoadBalancerId(state: LoadBalancerNetworkState<Missing>, value: double) : LoadBalancerNetworkState<Present> =
            state.assignments.Add(fun config -> config.LoadBalancerId <- value)
            ({ assignments = state.assignments } : LoadBalancerNetworkState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network#enable_public_interface-1">LoadBalancerNetwork#enable_public_interface</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "enable_public_interface">]
        member _.EnablePublicInterface(state: LoadBalancerNetworkState<'LoadBalancerId>, value: bool) : LoadBalancerNetworkState<'LoadBalancerId> =
            state.assignments.Add(fun config -> config.EnablePublicInterface <- value)
            state : LoadBalancerNetworkState<'LoadBalancerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network#enable_public_interface-1">LoadBalancerNetwork#enable_public_interface</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "enable_public_interface">]
        member _.EnablePublicInterface(state: LoadBalancerNetworkState<'LoadBalancerId>, value: HashiCorp.Cdktf.IResolvable) : LoadBalancerNetworkState<'LoadBalancerId> =
            state.assignments.Add(fun config -> config.EnablePublicInterface <- value)
            state : LoadBalancerNetworkState<'LoadBalancerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network#id-1">LoadBalancerNetwork#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LoadBalancerNetworkState<'LoadBalancerId>, value: string) : LoadBalancerNetworkState<'LoadBalancerId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LoadBalancerNetworkState<'LoadBalancerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network#ip-1">LoadBalancerNetwork#ip</a>.
        /// </summary>
        [<CustomOperation "ip">]
        member _.Ip(state: LoadBalancerNetworkState<'LoadBalancerId>, value: string) : LoadBalancerNetworkState<'LoadBalancerId> =
            state.assignments.Add(fun config -> config.Ip <- value)
            state : LoadBalancerNetworkState<'LoadBalancerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network#network_id-1">LoadBalancerNetwork#network_id</a>.
        /// </summary>
        [<CustomOperation "network_id">]
        member _.NetworkId(state: LoadBalancerNetworkState<'LoadBalancerId>, value: double) : LoadBalancerNetworkState<'LoadBalancerId> =
            state.assignments.Add(fun config -> config.NetworkId <- value)
            state : LoadBalancerNetworkState<'LoadBalancerId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_network#subnet_id-1">LoadBalancerNetwork#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: LoadBalancerNetworkState<'LoadBalancerId>, value: string) : LoadBalancerNetworkState<'LoadBalancerId> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : LoadBalancerNetworkState<'LoadBalancerId>

        member _.Run(state: LoadBalancerNetworkState<Present>) : hcloud.LoadBalancerNetwork.LoadBalancerNetwork =
            let config = hcloud.LoadBalancerNetwork.LoadBalancerNetworkConfig()
            for setter in state.assignments do
                setter config
            hcloud.LoadBalancerNetwork.LoadBalancerNetwork(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.loadBalancerNetwork: missing required arguments. Must call: load_balancer_id.", 9999, IsError = true)>]
        member _.Run(_: LoadBalancerNetworkState<_>) : hcloud.LoadBalancerNetwork.LoadBalancerNetwork =
            Unchecked.defaultof<hcloud.LoadBalancerNetwork.LoadBalancerNetwork>
