namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type InspectorAssessmentTargetState<'Name> = { assignments: ResizeArray<aws.InspectorAssessmentTarget.InspectorAssessmentTargetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_target">aws_inspector_assessment_target</a>.
    /// </summary>
    type InspectorAssessmentTargetBuilder(logicalId: string) =
        member _.Yield(_: unit) : InspectorAssessmentTargetState<Missing> =
            ({ assignments = ResizeArray() } : InspectorAssessmentTargetState<Missing>)

        member _.Zero(()) : InspectorAssessmentTargetState<Missing> =
            ({ assignments = ResizeArray() } : InspectorAssessmentTargetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_target#name-1">InspectorAssessmentTarget#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: InspectorAssessmentTargetState<Missing>, value: string) : InspectorAssessmentTargetState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : InspectorAssessmentTargetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_target#id-1">InspectorAssessmentTarget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: InspectorAssessmentTargetState<'Name>, value: string) : InspectorAssessmentTargetState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : InspectorAssessmentTargetState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_target#resource_group_arn-1">InspectorAssessmentTarget#resource_group_arn</a>.
        /// </summary>
        [<CustomOperation "resource_group_arn">]
        member _.ResourceGroupArn(state: InspectorAssessmentTargetState<'Name>, value: string) : InspectorAssessmentTargetState<'Name> =
            state.assignments.Add(fun config -> config.ResourceGroupArn <- value)
            state : InspectorAssessmentTargetState<'Name>

        member _.Run(state: InspectorAssessmentTargetState<Present>) : aws.InspectorAssessmentTarget.InspectorAssessmentTarget =
            let config = aws.InspectorAssessmentTarget.InspectorAssessmentTargetConfig()
            for setter in state.assignments do
                setter config
            aws.InspectorAssessmentTarget.InspectorAssessmentTarget(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.inspectorAssessmentTarget: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: InspectorAssessmentTargetState<_>) : aws.InspectorAssessmentTarget.InspectorAssessmentTarget =
            Unchecked.defaultof<aws.InspectorAssessmentTarget.InspectorAssessmentTarget>
