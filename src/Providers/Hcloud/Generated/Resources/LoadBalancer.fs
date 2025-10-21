namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LoadBalancerState<'LoadBalancerType, 'Name> = { assignments: ResizeArray<hcloud.LoadBalancer.LoadBalancerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer">hcloud_load_balancer</a>.
    /// </summary>
    type LoadBalancerBuilder(logicalId: string) =
        member _.Yield(_: unit) : LoadBalancerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LoadBalancerState<Missing, Missing>)

        member _.Zero(()) : LoadBalancerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LoadBalancerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#load_balancer_type-1">LoadBalancer#load_balancer_type</a>.
        /// </summary>
        [<CustomOperation "load_balancer_type">]
        member _.LoadBalancerType(state: LoadBalancerState<Missing, 'Name>, value: string) : LoadBalancerState<Present, 'Name> =
            state.assignments.Add(fun config -> config.LoadBalancerType <- value)
            ({ assignments = state.assignments } : LoadBalancerState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#name-1">LoadBalancer#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LoadBalancerState<'LoadBalancerType, Missing>, value: string) : LoadBalancerState<'LoadBalancerType, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LoadBalancerState<'LoadBalancerType, Present>)

        /// <summary>
        /// algorithm block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#algorithm-1">LoadBalancer#algorithm</a>
        /// </summary>
        [<CustomOperation "algorithm">]
        member _.Algorithm(state: LoadBalancerState<'LoadBalancerType, 'Name>, value: hcloud.LoadBalancer.LoadBalancerAlgorithm) : LoadBalancerState<'LoadBalancerType, 'Name> =
            state.assignments.Add(fun config -> config.Algorithm <- value)
            state : LoadBalancerState<'LoadBalancerType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#delete_protection-1">LoadBalancer#delete_protection</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: LoadBalancerState<'LoadBalancerType, 'Name>, value: bool) : LoadBalancerState<'LoadBalancerType, 'Name> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : LoadBalancerState<'LoadBalancerType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#delete_protection-1">LoadBalancer#delete_protection</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "delete_protection">]
        member _.DeleteProtection(state: LoadBalancerState<'LoadBalancerType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LoadBalancerState<'LoadBalancerType, 'Name> =
            state.assignments.Add(fun config -> config.DeleteProtection <- value)
            state : LoadBalancerState<'LoadBalancerType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#id-1">LoadBalancer#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LoadBalancerState<'LoadBalancerType, 'Name>, value: string) : LoadBalancerState<'LoadBalancerType, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LoadBalancerState<'LoadBalancerType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#labels-1">LoadBalancer#labels</a>.
        /// </summary>
        [<CustomOperation "labels">]
        member _.Labels(state: LoadBalancerState<'LoadBalancerType, 'Name>, value: seq<string * string>) : LoadBalancerState<'LoadBalancerType, 'Name> =
            state.assignments.Add(fun config -> config.Labels <- dict value)
            state : LoadBalancerState<'LoadBalancerType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#location-1">LoadBalancer#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: LoadBalancerState<'LoadBalancerType, 'Name>, value: string) : LoadBalancerState<'LoadBalancerType, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            state : LoadBalancerState<'LoadBalancerType, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#network_zone-1">LoadBalancer#network_zone</a>.
        /// </summary>
        [<CustomOperation "network_zone">]
        member _.NetworkZone(state: LoadBalancerState<'LoadBalancerType, 'Name>, value: string) : LoadBalancerState<'LoadBalancerType, 'Name> =
            state.assignments.Add(fun config -> config.NetworkZone <- value)
            state : LoadBalancerState<'LoadBalancerType, 'Name>

        /// <summary>
        /// target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer#target-1">LoadBalancer#target</a> Accepts: hcloud.IResolvable | hcloud.LoadBalancer.LoadBalancerTarget[]
        /// </summary>
        [<CustomOperation "target">]
        member _.Target(state: LoadBalancerState<'LoadBalancerType, 'Name>, value: HashiCorp.Cdktf.IResolvable) : LoadBalancerState<'LoadBalancerType, 'Name> =
            state.assignments.Add(fun config -> config.Target <- value)
            state : LoadBalancerState<'LoadBalancerType, 'Name>

        member _.Run(state: LoadBalancerState<Present, Present>) : hcloud.LoadBalancer.LoadBalancer =
            let config = hcloud.LoadBalancer.LoadBalancerConfig()
            for setter in state.assignments do
                setter config
            hcloud.LoadBalancer.LoadBalancer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.loadBalancer: missing required arguments. Must call: load_balancer_type, name.", 9999, IsError = true)>]
        member _.Run(_: LoadBalancerState<_, _>) : hcloud.LoadBalancer.LoadBalancer =
            Unchecked.defaultof<hcloud.LoadBalancer.LoadBalancer>
