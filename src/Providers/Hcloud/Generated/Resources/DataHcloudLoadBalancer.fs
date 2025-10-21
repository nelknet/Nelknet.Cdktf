namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudLoadBalancerState = { assignments: ResizeArray<hcloud.DataHcloudLoadBalancer.DataHcloudLoadBalancerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer">hcloud_load_balancer</a>.
    /// </summary>
    type DataHcloudLoadBalancerBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudLoadBalancerState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudLoadBalancerState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer#id-1">DataHcloudLoadBalancer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudLoadBalancerState, value: double) : DataHcloudLoadBalancerState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudLoadBalancerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer#name-1">DataHcloudLoadBalancer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudLoadBalancerState, value: string) : DataHcloudLoadBalancerState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudLoadBalancerState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer#with_selector-1">DataHcloudLoadBalancer#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudLoadBalancerState, value: string) : DataHcloudLoadBalancerState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudLoadBalancerState

        member _.Run(state: DataHcloudLoadBalancerState) : hcloud.DataHcloudLoadBalancer.DataHcloudLoadBalancer =
            let config = hcloud.DataHcloudLoadBalancer.DataHcloudLoadBalancerConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudLoadBalancer.DataHcloudLoadBalancer(StackContext.get (), logicalId, config)
