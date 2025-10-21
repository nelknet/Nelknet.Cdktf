namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LoadBalancerServiceState<'LoadBalancerId, 'Protocol> = { assignments: ResizeArray<hcloud.LoadBalancerService.LoadBalancerServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service">hcloud_load_balancer_service</a>.
    /// </summary>
    type LoadBalancerServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : LoadBalancerServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LoadBalancerServiceState<Missing, Missing>)

        member _.Zero(()) : LoadBalancerServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LoadBalancerServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#load_balancer_id-1">LoadBalancerService#load_balancer_id</a>.
        /// </summary>
        [<CustomOperation "load_balancer_id">]
        member _.LoadBalancerId(state: LoadBalancerServiceState<Missing, 'Protocol>, value: string) : LoadBalancerServiceState<Present, 'Protocol> =
            state.assignments.Add(fun config -> config.LoadBalancerId <- value)
            ({ assignments = state.assignments } : LoadBalancerServiceState<Present, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#protocol-1">LoadBalancerService#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: LoadBalancerServiceState<'LoadBalancerId, Missing>, value: string) : LoadBalancerServiceState<'LoadBalancerId, Present> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : LoadBalancerServiceState<'LoadBalancerId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#destination_port-1">LoadBalancerService#destination_port</a>.
        /// </summary>
        [<CustomOperation "destination_port">]
        member _.DestinationPort(state: LoadBalancerServiceState<'LoadBalancerId, 'Protocol>, value: double) : LoadBalancerServiceState<'LoadBalancerId, 'Protocol> =
            state.assignments.Add(fun config -> config.DestinationPort <- value)
            state : LoadBalancerServiceState<'LoadBalancerId, 'Protocol>

        /// <summary>
        /// health_check block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#health_check-1">LoadBalancerService#health_check</a>
        /// </summary>
        [<CustomOperation "health_check">]
        member _.HealthCheck(state: LoadBalancerServiceState<'LoadBalancerId, 'Protocol>, value: hcloud.LoadBalancerService.LoadBalancerServiceHealthCheck) : LoadBalancerServiceState<'LoadBalancerId, 'Protocol> =
            state.assignments.Add(fun config -> config.HealthCheck <- value)
            state : LoadBalancerServiceState<'LoadBalancerId, 'Protocol>

        /// <summary>
        /// http block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#http-1">LoadBalancerService#http</a>
        /// </summary>
        [<CustomOperation "http">]
        member _.Http(state: LoadBalancerServiceState<'LoadBalancerId, 'Protocol>, value: hcloud.LoadBalancerService.LoadBalancerServiceHttp) : LoadBalancerServiceState<'LoadBalancerId, 'Protocol> =
            state.assignments.Add(fun config -> config.Http <- value)
            state : LoadBalancerServiceState<'LoadBalancerId, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#id-1">LoadBalancerService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LoadBalancerServiceState<'LoadBalancerId, 'Protocol>, value: string) : LoadBalancerServiceState<'LoadBalancerId, 'Protocol> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LoadBalancerServiceState<'LoadBalancerId, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#listen_port-1">LoadBalancerService#listen_port</a>.
        /// </summary>
        [<CustomOperation "listen_port">]
        member _.ListenPort(state: LoadBalancerServiceState<'LoadBalancerId, 'Protocol>, value: double) : LoadBalancerServiceState<'LoadBalancerId, 'Protocol> =
            state.assignments.Add(fun config -> config.ListenPort <- value)
            state : LoadBalancerServiceState<'LoadBalancerId, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#proxyprotocol-1">LoadBalancerService#proxyprotocol</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "proxyprotocol">]
        member _.Proxyprotocol(state: LoadBalancerServiceState<'LoadBalancerId, 'Protocol>, value: bool) : LoadBalancerServiceState<'LoadBalancerId, 'Protocol> =
            state.assignments.Add(fun config -> config.Proxyprotocol <- value)
            state : LoadBalancerServiceState<'LoadBalancerId, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hetznercloud/hcloud/1.54.0/docs/resources/load_balancer_service#proxyprotocol-1">LoadBalancerService#proxyprotocol</a>. Accepts: boolean | hcloud.IResolvable
        /// </summary>
        [<CustomOperation "proxyprotocol">]
        member _.Proxyprotocol(state: LoadBalancerServiceState<'LoadBalancerId, 'Protocol>, value: HashiCorp.Cdktf.IResolvable) : LoadBalancerServiceState<'LoadBalancerId, 'Protocol> =
            state.assignments.Add(fun config -> config.Proxyprotocol <- value)
            state : LoadBalancerServiceState<'LoadBalancerId, 'Protocol>

        member _.Run(state: LoadBalancerServiceState<Present, Present>) : hcloud.LoadBalancerService.LoadBalancerService =
            let config = hcloud.LoadBalancerService.LoadBalancerServiceConfig()
            for setter in state.assignments do
                setter config
            hcloud.LoadBalancerService.LoadBalancerService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Hcloud.loadBalancerService: missing required arguments. Must call: load_balancer_id, protocol.", 9999, IsError = true)>]
        member _.Run(_: LoadBalancerServiceState<_, _>) : hcloud.LoadBalancerService.LoadBalancerService =
            Unchecked.defaultof<hcloud.LoadBalancerService.LoadBalancerService>
