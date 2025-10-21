namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutoscalingGroupTagAState<'AutoscalingGroupName, 'Tag> = { assignments: ResizeArray<aws.AutoscalingGroupTag.AutoscalingGroupTagAConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group_tag">aws_autoscaling_group_tag</a>.
    /// </summary>
    type AutoscalingGroupTagABuilder(logicalId: string) =
        member _.Yield(_: unit) : AutoscalingGroupTagAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AutoscalingGroupTagAState<Missing, Missing>)

        member _.Zero(()) : AutoscalingGroupTagAState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AutoscalingGroupTagAState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group_tag#autoscaling_group_name-1">AutoscalingGroupTagA#autoscaling_group_name</a>.
        /// </summary>
        [<CustomOperation "autoscaling_group_name">]
        member _.AutoscalingGroupName(state: AutoscalingGroupTagAState<Missing, 'Tag>, value: string) : AutoscalingGroupTagAState<Present, 'Tag> =
            state.assignments.Add(fun config -> config.AutoscalingGroupName <- value)
            ({ assignments = state.assignments } : AutoscalingGroupTagAState<Present, 'Tag>)

        /// <summary>
        /// tag block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group_tag#tag-1">AutoscalingGroupTagA#tag</a>
        /// </summary>
        [<CustomOperation "tag">]
        member _.Tag(state: AutoscalingGroupTagAState<'AutoscalingGroupName, Missing>, value: aws.AutoscalingGroupTag.AutoscalingGroupTagTag) : AutoscalingGroupTagAState<'AutoscalingGroupName, Present> =
            state.assignments.Add(fun config -> config.Tag <- value)
            ({ assignments = state.assignments } : AutoscalingGroupTagAState<'AutoscalingGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group_tag#id-1">AutoscalingGroupTagA#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutoscalingGroupTagAState<'AutoscalingGroupName, 'Tag>, value: string) : AutoscalingGroupTagAState<'AutoscalingGroupName, 'Tag> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutoscalingGroupTagAState<'AutoscalingGroupName, 'Tag>

        member _.Run(state: AutoscalingGroupTagAState<Present, Present>) : aws.AutoscalingGroupTag.AutoscalingGroupTagA =
            let config = aws.AutoscalingGroupTag.AutoscalingGroupTagAConfig()
            for setter in state.assignments do
                setter config
            aws.AutoscalingGroupTag.AutoscalingGroupTagA(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.autoscalingGroupTagA: missing required arguments. Must call: autoscaling_group_name, tag.", 9999, IsError = true)>]
        member _.Run(_: AutoscalingGroupTagAState<_, _>) : aws.AutoscalingGroupTag.AutoscalingGroupTagA =
            Unchecked.defaultof<aws.AutoscalingGroupTag.AutoscalingGroupTagA>
