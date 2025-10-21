namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataHcloudLoadBalancerTypesState = { assignments: ResizeArray<hcloud.DataHcloudLoadBalancerTypes.DataHcloudLoadBalancerTypesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/data-sources/load_balancer_types">hcloud_load_balancer_types</a>.
    /// </summary>
    type DataHcloudLoadBalancerTypesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataHcloudLoadBalancerTypesState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataHcloudLoadBalancerTypesState =
            { assignments = ResizeArray() }



        member _.Run(state: DataHcloudLoadBalancerTypesState) : hcloud.DataHcloudLoadBalancerTypes.DataHcloudLoadBalancerTypes =
            let config = hcloud.DataHcloudLoadBalancerTypes.DataHcloudLoadBalancerTypesConfig()
            for setter in state.assignments do
                setter config
            hcloud.DataHcloudLoadBalancerTypes.DataHcloudLoadBalancerTypes(StackContext.get (), logicalId, config)
