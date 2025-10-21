namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OamSinkPolicyState<'Policy, 'SinkIdentifier> = { assignments: ResizeArray<aws.OamSinkPolicy.OamSinkPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_sink_policy">aws_oam_sink_policy</a>.
    /// </summary>
    type OamSinkPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : OamSinkPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OamSinkPolicyState<Missing, Missing>)

        member _.Zero(()) : OamSinkPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : OamSinkPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_sink_policy#policy-1">OamSinkPolicy#policy</a>.
        /// </summary>
        [<CustomOperation "policy">]
        member _.Policy(state: OamSinkPolicyState<Missing, 'SinkIdentifier>, value: string) : OamSinkPolicyState<Present, 'SinkIdentifier> =
            state.assignments.Add(fun config -> config.Policy <- value)
            ({ assignments = state.assignments } : OamSinkPolicyState<Present, 'SinkIdentifier>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_sink_policy#sink_identifier-1">OamSinkPolicy#sink_identifier</a>.
        /// </summary>
        [<CustomOperation "sink_identifier">]
        member _.SinkIdentifier(state: OamSinkPolicyState<'Policy, Missing>, value: string) : OamSinkPolicyState<'Policy, Present> =
            state.assignments.Add(fun config -> config.SinkIdentifier <- value)
            ({ assignments = state.assignments } : OamSinkPolicyState<'Policy, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_sink_policy#id-1">OamSinkPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OamSinkPolicyState<'Policy, 'SinkIdentifier>, value: string) : OamSinkPolicyState<'Policy, 'SinkIdentifier> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OamSinkPolicyState<'Policy, 'SinkIdentifier>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_sink_policy#timeouts-1">OamSinkPolicy#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OamSinkPolicyState<'Policy, 'SinkIdentifier>, value: aws.OamSinkPolicy.OamSinkPolicyTimeouts) : OamSinkPolicyState<'Policy, 'SinkIdentifier> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OamSinkPolicyState<'Policy, 'SinkIdentifier>

        member _.Run(state: OamSinkPolicyState<Present, Present>) : aws.OamSinkPolicy.OamSinkPolicy =
            let config = aws.OamSinkPolicy.OamSinkPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.OamSinkPolicy.OamSinkPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.oamSinkPolicy: missing required arguments. Must call: policy, sink_identifier.", 9999, IsError = true)>]
        member _.Run(_: OamSinkPolicyState<_, _>) : aws.OamSinkPolicy.OamSinkPolicy =
            Unchecked.defaultof<aws.OamSinkPolicy.OamSinkPolicy>
