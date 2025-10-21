namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlobalacceleratorCustomRoutingListenerState<'AcceleratorArn, 'PortRange> = { assignments: ResizeArray<aws.GlobalacceleratorCustomRoutingListener.GlobalacceleratorCustomRoutingListenerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_listener">aws_globalaccelerator_custom_routing_listener</a>.
    /// </summary>
    type GlobalacceleratorCustomRoutingListenerBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlobalacceleratorCustomRoutingListenerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GlobalacceleratorCustomRoutingListenerState<Missing, Missing>)

        member _.Zero(()) : GlobalacceleratorCustomRoutingListenerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GlobalacceleratorCustomRoutingListenerState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_listener#accelerator_arn-1">GlobalacceleratorCustomRoutingListener#accelerator_arn</a>.
        /// </summary>
        [<CustomOperation "accelerator_arn">]
        member _.AcceleratorArn(state: GlobalacceleratorCustomRoutingListenerState<Missing, 'PortRange>, value: string) : GlobalacceleratorCustomRoutingListenerState<Present, 'PortRange> =
            state.assignments.Add(fun config -> config.AcceleratorArn <- value)
            ({ assignments = state.assignments } : GlobalacceleratorCustomRoutingListenerState<Present, 'PortRange>)

        /// <summary>
        /// port_range block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_listener#port_range-1">GlobalacceleratorCustomRoutingListener#port_range</a> Accepts: aws.IResolvable | aws.GlobalacceleratorCustomRoutingListener.GlobalacceleratorCustomRoutingListenerPortRange[]
        /// </summary>
        [<CustomOperation "port_range">]
        member _.PortRange(state: GlobalacceleratorCustomRoutingListenerState<'AcceleratorArn, Missing>, value: HashiCorp.Cdktf.IResolvable) : GlobalacceleratorCustomRoutingListenerState<'AcceleratorArn, Present> =
            state.assignments.Add(fun config -> config.PortRange <- value)
            ({ assignments = state.assignments } : GlobalacceleratorCustomRoutingListenerState<'AcceleratorArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_listener#id-1">GlobalacceleratorCustomRoutingListener#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlobalacceleratorCustomRoutingListenerState<'AcceleratorArn, 'PortRange>, value: string) : GlobalacceleratorCustomRoutingListenerState<'AcceleratorArn, 'PortRange> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlobalacceleratorCustomRoutingListenerState<'AcceleratorArn, 'PortRange>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_custom_routing_listener#timeouts-1">GlobalacceleratorCustomRoutingListener#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GlobalacceleratorCustomRoutingListenerState<'AcceleratorArn, 'PortRange>, value: aws.GlobalacceleratorCustomRoutingListener.GlobalacceleratorCustomRoutingListenerTimeouts) : GlobalacceleratorCustomRoutingListenerState<'AcceleratorArn, 'PortRange> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GlobalacceleratorCustomRoutingListenerState<'AcceleratorArn, 'PortRange>

        member _.Run(state: GlobalacceleratorCustomRoutingListenerState<Present, Present>) : aws.GlobalacceleratorCustomRoutingListener.GlobalacceleratorCustomRoutingListener =
            let config = aws.GlobalacceleratorCustomRoutingListener.GlobalacceleratorCustomRoutingListenerConfig()
            for setter in state.assignments do
                setter config
            aws.GlobalacceleratorCustomRoutingListener.GlobalacceleratorCustomRoutingListener(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.globalacceleratorCustomRoutingListener: missing required arguments. Must call: accelerator_arn, port_range.", 9999, IsError = true)>]
        member _.Run(_: GlobalacceleratorCustomRoutingListenerState<_, _>) : aws.GlobalacceleratorCustomRoutingListener.GlobalacceleratorCustomRoutingListener =
            Unchecked.defaultof<aws.GlobalacceleratorCustomRoutingListener.GlobalacceleratorCustomRoutingListener>
