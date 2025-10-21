namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlobalacceleratorListenerState<'AcceleratorArn, 'PortRange, 'Protocol> = { assignments: ResizeArray<aws.GlobalacceleratorListener.GlobalacceleratorListenerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_listener">aws_globalaccelerator_listener</a>.
    /// </summary>
    type GlobalacceleratorListenerBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlobalacceleratorListenerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlobalacceleratorListenerState<Missing, Missing, Missing>)

        member _.Zero(()) : GlobalacceleratorListenerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlobalacceleratorListenerState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_listener#accelerator_arn-1">GlobalacceleratorListener#accelerator_arn</a>.
        /// </summary>
        [<CustomOperation "accelerator_arn">]
        member _.AcceleratorArn(state: GlobalacceleratorListenerState<Missing, 'PortRange, 'Protocol>, value: string) : GlobalacceleratorListenerState<Present, 'PortRange, 'Protocol> =
            state.assignments.Add(fun config -> config.AcceleratorArn <- value)
            ({ assignments = state.assignments } : GlobalacceleratorListenerState<Present, 'PortRange, 'Protocol>)

        /// <summary>
        /// port_range block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_listener#port_range-1">GlobalacceleratorListener#port_range</a> Accepts: aws.IResolvable | aws.GlobalacceleratorListener.GlobalacceleratorListenerPortRange[]
        /// </summary>
        [<CustomOperation "port_range">]
        member _.PortRange(state: GlobalacceleratorListenerState<'AcceleratorArn, Missing, 'Protocol>, value: HashiCorp.Cdktf.IResolvable) : GlobalacceleratorListenerState<'AcceleratorArn, Present, 'Protocol> =
            state.assignments.Add(fun config -> config.PortRange <- value)
            ({ assignments = state.assignments } : GlobalacceleratorListenerState<'AcceleratorArn, Present, 'Protocol>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_listener#protocol-1">GlobalacceleratorListener#protocol</a>.
        /// </summary>
        [<CustomOperation "protocol">]
        member _.Protocol(state: GlobalacceleratorListenerState<'AcceleratorArn, 'PortRange, Missing>, value: string) : GlobalacceleratorListenerState<'AcceleratorArn, 'PortRange, Present> =
            state.assignments.Add(fun config -> config.Protocol <- value)
            ({ assignments = state.assignments } : GlobalacceleratorListenerState<'AcceleratorArn, 'PortRange, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_listener#client_affinity-1">GlobalacceleratorListener#client_affinity</a>.
        /// </summary>
        [<CustomOperation "client_affinity">]
        member _.ClientAffinity(state: GlobalacceleratorListenerState<'AcceleratorArn, 'PortRange, 'Protocol>, value: string) : GlobalacceleratorListenerState<'AcceleratorArn, 'PortRange, 'Protocol> =
            state.assignments.Add(fun config -> config.ClientAffinity <- value)
            state : GlobalacceleratorListenerState<'AcceleratorArn, 'PortRange, 'Protocol>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_listener#id-1">GlobalacceleratorListener#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlobalacceleratorListenerState<'AcceleratorArn, 'PortRange, 'Protocol>, value: string) : GlobalacceleratorListenerState<'AcceleratorArn, 'PortRange, 'Protocol> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlobalacceleratorListenerState<'AcceleratorArn, 'PortRange, 'Protocol>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_listener#timeouts-1">GlobalacceleratorListener#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GlobalacceleratorListenerState<'AcceleratorArn, 'PortRange, 'Protocol>, value: aws.GlobalacceleratorListener.GlobalacceleratorListenerTimeouts) : GlobalacceleratorListenerState<'AcceleratorArn, 'PortRange, 'Protocol> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GlobalacceleratorListenerState<'AcceleratorArn, 'PortRange, 'Protocol>

        member _.Run(state: GlobalacceleratorListenerState<Present, Present, Present>) : aws.GlobalacceleratorListener.GlobalacceleratorListener =
            let config = aws.GlobalacceleratorListener.GlobalacceleratorListenerConfig()
            for setter in state.assignments do
                setter config
            aws.GlobalacceleratorListener.GlobalacceleratorListener(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.globalacceleratorListener: missing required arguments. Must call: accelerator_arn, port_range, protocol.", 9999, IsError = true)>]
        member _.Run(_: GlobalacceleratorListenerState<_, _, _>) : aws.GlobalacceleratorListener.GlobalacceleratorListener =
            Unchecked.defaultof<aws.GlobalacceleratorListener.GlobalacceleratorListener>
