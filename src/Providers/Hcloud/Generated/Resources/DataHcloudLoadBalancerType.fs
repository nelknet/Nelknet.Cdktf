namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudLoadBalancerTypeState = { assignments: ResizeArray<hcloud.DataHcloudLoadBalancerType.DataHcloudLoadBalancerTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer_type">hcloud_load_balancer_type</a>.
    /// </summary>
    type DataHcloudLoadBalancerTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudLoadBalancerTypeState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudLoadBalancerTypeState =
            { assignments = ResizeArray() }

        /// <summary>
        /// ID of the Load Balancer Type. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer_type#id-1">DataHcloudLoadBalancerType#id</a> Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataHcloudLoadBalancerTypeState, value: double) : DataHcloudLoadBalancerTypeState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataHcloudLoadBalancerTypeState

        /// <summary>
        /// Name of the Load Balancer Type. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer_type#name-1">DataHcloudLoadBalancerType#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataHcloudLoadBalancerTypeState, value: string) : DataHcloudLoadBalancerTypeState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataHcloudLoadBalancerTypeState

        member _.Run(state: DataHcloudLoadBalancerTypeState) : hcloud.DataHcloudLoadBalancerType.DataHcloudLoadBalancerType =
            let config = hcloud.DataHcloudLoadBalancerType.DataHcloudLoadBalancerTypeConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudLoadBalancerType.DataHcloudLoadBalancerType(StackContext.get (), logicalId, config)
