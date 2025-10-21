namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2InstanceStateState<'InstanceId, 'State> = { assignments: ResizeArray<aws.Ec2InstanceState.Ec2InstanceStateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_state">aws_ec2_instance_state</a>.
    /// </summary>
    type Ec2InstanceStateBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2InstanceStateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2InstanceStateState<Missing, Missing>)

        member _.Zero(()) : Ec2InstanceStateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2InstanceStateState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_state#instance_id-1">Ec2InstanceState#instance_id</a>.
        /// </summary>
        [<CustomOperation "instance_id">]
        member _.InstanceId(state: Ec2InstanceStateState<Missing, 'State>, value: string) : Ec2InstanceStateState<Present, 'State> =
            state.assignments.Add(fun config -> config.InstanceId <- value)
            ({ assignments = state.assignments } : Ec2InstanceStateState<Present, 'State>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_state#state-1">Ec2InstanceState#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: Ec2InstanceStateState<'InstanceId, Missing>, value: string) : Ec2InstanceStateState<'InstanceId, Present> =
            state.assignments.Add(fun config -> config.State <- value)
            ({ assignments = state.assignments } : Ec2InstanceStateState<'InstanceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_state#force-1">Ec2InstanceState#force</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force">]
        member _.Force(state: Ec2InstanceStateState<'InstanceId, 'State>, value: bool) : Ec2InstanceStateState<'InstanceId, 'State> =
            state.assignments.Add(fun config -> config.Force <- value)
            state : Ec2InstanceStateState<'InstanceId, 'State>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_state#force-1">Ec2InstanceState#force</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force">]
        member _.Force(state: Ec2InstanceStateState<'InstanceId, 'State>, value: HashiCorp.Cdktf.IResolvable) : Ec2InstanceStateState<'InstanceId, 'State> =
            state.assignments.Add(fun config -> config.Force <- value)
            state : Ec2InstanceStateState<'InstanceId, 'State>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_state#id-1">Ec2InstanceState#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2InstanceStateState<'InstanceId, 'State>, value: string) : Ec2InstanceStateState<'InstanceId, 'State> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2InstanceStateState<'InstanceId, 'State>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_instance_state#timeouts-1">Ec2InstanceState#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2InstanceStateState<'InstanceId, 'State>, value: aws.Ec2InstanceState.Ec2InstanceStateTimeouts) : Ec2InstanceStateState<'InstanceId, 'State> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2InstanceStateState<'InstanceId, 'State>

        member _.Run(state: Ec2InstanceStateState<Present, Present>) : aws.Ec2InstanceState.Ec2InstanceState =
            let config = aws.Ec2InstanceState.Ec2InstanceStateConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2InstanceState.Ec2InstanceState(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2InstanceState: missing required arguments. Must call: instance_id, state.", 9999, IsError = true)>]
        member _.Run(_: Ec2InstanceStateState<_, _>) : aws.Ec2InstanceState.Ec2InstanceState =
            Unchecked.defaultof<aws.Ec2InstanceState.Ec2InstanceState>
