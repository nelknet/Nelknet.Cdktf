namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudLoadBalancersState = { assignments: ResizeArray<hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancers">hcloud_load_balancers</a>.
    /// </summary>
    type DataHcloudLoadBalancersBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudLoadBalancersState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudLoadBalancersState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancers#id-1">DataHcloudLoadBalancers#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudLoadBalancersState, value: string) : DataHcloudLoadBalancersState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudLoadBalancersState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancers#with_selector-1">DataHcloudLoadBalancers#with_selector</a>.
        /// </summary>
        [<CustomOperation "with_selector">]
        member _.WithSelector(state: DataHcloudLoadBalancersState, value: string) : DataHcloudLoadBalancersState =
            state.assignments.Add(fun config -> config.WithSelector <- value)
            state : DataHcloudLoadBalancersState

        member _.Run(state: DataHcloudLoadBalancersState) : hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancers =
            let config = hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancersConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudLoadBalancers.DataHcloudLoadBalancers(StackContext.get (), logicalId, config)
