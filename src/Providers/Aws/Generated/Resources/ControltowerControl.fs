namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ControltowerControlState<'ControlIdentifier, 'TargetIdentifier> = { assignments: ResizeArray<aws.ControltowerControl.ControltowerControlConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/controltower_control">aws_controltower_control</a>.
    /// </summary>
    type ControltowerControlBuilder(logicalId: string) =
        member _.Yield(_: unit) : ControltowerControlState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ControltowerControlState<Missing, Missing>)

        member _.Zero(()) : ControltowerControlState<Missing, Missing> =
            ({ assignments = ResizeArray() } : ControltowerControlState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/controltower_control#control_identifier-1">ControltowerControl#control_identifier</a>.
        /// </summary>
        [<CustomOperation "control_identifier">]
        member _.ControlIdentifier(state: ControltowerControlState<Missing, 'TargetIdentifier>, value: string) : ControltowerControlState<Present, 'TargetIdentifier> =
            state.assignments.Add(fun config -> config.ControlIdentifier <- value)
            ({ assignments = state.assignments } : ControltowerControlState<Present, 'TargetIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/controltower_control#target_identifier-1">ControltowerControl#target_identifier</a>.
        /// </summary>
        [<CustomOperation "target_identifier">]
        member _.TargetIdentifier(state: ControltowerControlState<'ControlIdentifier, Missing>, value: string) : ControltowerControlState<'ControlIdentifier, Present> =
            state.assignments.Add(fun config -> config.TargetIdentifier <- value)
            ({ assignments = state.assignments } : ControltowerControlState<'ControlIdentifier, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/controltower_control#id-1">ControltowerControl#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ControltowerControlState<'ControlIdentifier, 'TargetIdentifier>, value: string) : ControltowerControlState<'ControlIdentifier, 'TargetIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ControltowerControlState<'ControlIdentifier, 'TargetIdentifier>

        /// <summary>
        /// parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/controltower_control#parameters-1">ControltowerControl#parameters</a> Accepts: aws.IResolvable | aws.ControltowerControl.ControltowerControlParameters[]
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: ControltowerControlState<'ControlIdentifier, 'TargetIdentifier>, value: HashiCorp.Cdktf.IResolvable) : ControltowerControlState<'ControlIdentifier, 'TargetIdentifier> =
            state.assignments.Add(fun config -> config.Parameters <- value)
            state : ControltowerControlState<'ControlIdentifier, 'TargetIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/controltower_control#timeouts-1">ControltowerControl#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ControltowerControlState<'ControlIdentifier, 'TargetIdentifier>, value: aws.ControltowerControl.ControltowerControlTimeouts) : ControltowerControlState<'ControlIdentifier, 'TargetIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ControltowerControlState<'ControlIdentifier, 'TargetIdentifier>

        member _.Run(state: ControltowerControlState<Present, Present>) : aws.ControltowerControl.ControltowerControl =
            let config = aws.ControltowerControl.ControltowerControlConfig()
            for setter in state.assignments do
                setter config
            aws.ControltowerControl.ControltowerControl(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.controltowerControl: missing required arguments. Must call: control_identifier, target_identifier.", 9999, IsError = true)>]
        member _.Run(_: ControltowerControlState<_, _>) : aws.ControltowerControl.ControltowerControl =
            Unchecked.defaultof<aws.ControltowerControl.ControltowerControl>
