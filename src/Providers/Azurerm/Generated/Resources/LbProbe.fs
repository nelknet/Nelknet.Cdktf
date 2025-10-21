namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LbProbeState<'LoadbalancerId, 'Name, 'Port> = { assignments: ResizeArray<azurerm.LbProbe.LbProbeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_probe">azurerm_lb_probe</a>.
    /// </summary>
    type LbProbeBuilder(logicalId: string) =
        member _.Yield(_: unit) : LbProbeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbProbeState<Missing, Missing, Missing>)

        member _.Zero(()) : LbProbeState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LbProbeState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_probe#loadbalancer_id-1">LbProbe#loadbalancer_id</a>.
        /// </summary>
        [<CustomOperation "loadbalancer_id">]
        member _.LoadbalancerId(state: LbProbeState<Missing, 'Name, 'Port>, value: string) : LbProbeState<Present, 'Name, 'Port> =
            state.assignments.Add(fun config -> config.LoadbalancerId <- value)
            ({ assignments = state.assignments } : LbProbeState<Present, 'Name, 'Port>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_probe#name-1">LbProbe#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LbProbeState<'LoadbalancerId, Missing, 'Port>, value: string) : LbProbeState<'LoadbalancerId, Present, 'Port> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LbProbeState<'LoadbalancerId, Present, 'Port>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_probe#port-1">LbProbe#port</a>.
        /// </summary>
        [<CustomOperation "port">]
        member _.Port(state: LbProbeState<'LoadbalancerId, 'Name, Missing>, value: double) : LbProbeState<'LoadbalancerId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Port <- value)
            ({ assignments = state.assignments } : LbProbeState<'LoadbalancerId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_probe#id-1">LbProbe#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LbProbeState<'LoadbalancerId, 'Name, 'Port>, value: string) : LbProbeState<'LoadbalancerId, 'Name, 'Port> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LbProbeState<'LoadbalancerId, 'Name, 'Port>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_probe#interval_in_seconds-1">LbProbe#interval_in_seconds</a>.
        /// </summary>
        [<CustomOperation "interval_in_seconds">]
        member _.IntervalInSeconds(state: LbProbeState<'LoadbalancerId, 'Name, 'Port>, value: double) : LbProbeState<'LoadbalancerId, 'Name, 'Port> =
            state.assignments.Add(fun config -> config.IntervalInSeconds <- value)
            state : LbProbeState<'LoadbalancerId, 'Name, 'Port>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_probe#number_of_probes-1">LbProbe#number_of_probes</a>.
        /// </summary>
        [<CustomOperation "number_of_probes">]
        member _.NumberOfProbes(state: LbProbeState<'LoadbalancerId, 'Name, 'Port>, value: double) : LbProbeState<'LoadbalancerId, 'Name, 'Port> =
            state.assignments.Add(fun config -> config.NumberOfProbes <- value)
            state : LbProbeState<'LoadbalancerId, 'Name, 'Port>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_probe#probe_threshold-1">LbProbe#probe_threshold</a>.
        /// </summary>
        [<CustomOperation "probe_threshold">]
        member _.ProbeThreshold(state: LbProbeState<'LoadbalancerId, 'Name, 'Port>, value: double) : LbProbeState<'LoadbalancerId, 'Name, 'Port> =
            state.assignments.Add(fun config -> config.ProbeThreshold <- value)
            state : LbProbeState<'LoadbalancerId, 'Name, 'Port>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_probe#protocol-1">LbProbe#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: LbProbeState<'LoadbalancerId, 'Name, 'Port>, value: string) : LbProbeState<'LoadbalancerId, 'Name, 'Port> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            state : LbProbeState<'LoadbalancerId, 'Name, 'Port>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_probe#request_path-1">LbProbe#request_path</a>.
        /// </summary>
        [<CustomOperation "request_path">]
        member _.RequestPath(state: LbProbeState<'LoadbalancerId, 'Name, 'Port>, value: string) : LbProbeState<'LoadbalancerId, 'Name, 'Port> =
            state.assignments.Add(fun config -> config.RequestPath <- value)
            state : LbProbeState<'LoadbalancerId, 'Name, 'Port>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/lb_probe#timeouts-1">LbProbe#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: LbProbeState<'LoadbalancerId, 'Name, 'Port>, value: azurerm.LbProbe.LbProbeTimeouts) : LbProbeState<'LoadbalancerId, 'Name, 'Port> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : LbProbeState<'LoadbalancerId, 'Name, 'Port>

        member _.Run(state: LbProbeState<Present, Present, Present>) : azurerm.LbProbe.LbProbe =
            let config = azurerm.LbProbe.LbProbeConfig()
            for setter in state.assignments do
                setter config
            azurerm.LbProbe.LbProbe(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.lbProbe: missing required arguments. Must call: loadbalancer_id, name, port.", 9999, IsError = true)>]
        member _.Run(_: LbProbeState<_, _, _>) : azurerm.LbProbe.LbProbe =
            Unchecked.defaultof<azurerm.LbProbe.LbProbe>
