namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, 'TargetArn> = { assignments: ResizeArray<aws.InspectorAssessmentTemplate.InspectorAssessmentTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template">aws_inspector_assessment_template</a>.
    /// </summary>
    type InspectorAssessmentTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : InspectorAssessmentTemplateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : InspectorAssessmentTemplateState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : InspectorAssessmentTemplateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : InspectorAssessmentTemplateState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template#duration-1">InspectorAssessmentTemplate#duration</a>.
        /// </summary>
        [<CustomOperation "duration">]
        member _.Duration(state: InspectorAssessmentTemplateState<Missing, 'Name, 'RulesPackageArns, 'TargetArn>, value: double) : InspectorAssessmentTemplateState<Present, 'Name, 'RulesPackageArns, 'TargetArn> =
            state.assignments.Add(fun config -> config.Duration <- value)
            ({ assignments = state.assignments } : InspectorAssessmentTemplateState<Present, 'Name, 'RulesPackageArns, 'TargetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template#name-1">InspectorAssessmentTemplate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: InspectorAssessmentTemplateState<'Duration, Missing, 'RulesPackageArns, 'TargetArn>, value: string) : InspectorAssessmentTemplateState<'Duration, Present, 'RulesPackageArns, 'TargetArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : InspectorAssessmentTemplateState<'Duration, Present, 'RulesPackageArns, 'TargetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template#rules_package_arns-1">InspectorAssessmentTemplate#rules_package_arns</a>.
        /// </summary>
        [<CustomOperation "rules_package_arns">]
        member _.RulesPackageArns(state: InspectorAssessmentTemplateState<'Duration, 'Name, Missing, 'TargetArn>, value: seq<string>) : InspectorAssessmentTemplateState<'Duration, 'Name, Present, 'TargetArn> =
            state.assignments.Add(fun config -> config.RulesPackageArns <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : InspectorAssessmentTemplateState<'Duration, 'Name, Present, 'TargetArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template#target_arn-1">InspectorAssessmentTemplate#target_arn</a>.
        /// </summary>
        [<CustomOperation "target_arn">]
        member _.TargetArn(state: InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, Missing>, value: string) : InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, Present> =
            state.assignments.Add(fun config -> config.TargetArn <- value)
            ({ assignments = state.assignments } : InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, Present>)

        /// <summary>
        /// event_subscription block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template#event_subscription-1">InspectorAssessmentTemplate#event_subscription</a> Accepts: aws.IResolvable | aws.InspectorAssessmentTemplate.InspectorAssessmentTemplateEventSubscription[]
        /// </summary>
        [<CustomOperation "event_subscription">]
        member _.EventSubscription(state: InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, 'TargetArn>, value: HashiCorp.Cdktf.IResolvable) : InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, 'TargetArn> =
            state.assignments.Add(fun config -> config.EventSubscription <- value)
            state : InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, 'TargetArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template#id-1">InspectorAssessmentTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, 'TargetArn>, value: string) : InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, 'TargetArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, 'TargetArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template#tags-1">InspectorAssessmentTemplate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, 'TargetArn>, value: seq<string * string>) : InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, 'TargetArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, 'TargetArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/inspector_assessment_template#tags_all-1">InspectorAssessmentTemplate#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, 'TargetArn>, value: seq<string * string>) : InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, 'TargetArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : InspectorAssessmentTemplateState<'Duration, 'Name, 'RulesPackageArns, 'TargetArn>

        member _.Run(state: InspectorAssessmentTemplateState<Present, Present, Present, Present>) : aws.InspectorAssessmentTemplate.InspectorAssessmentTemplate =
            let config = aws.InspectorAssessmentTemplate.InspectorAssessmentTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.InspectorAssessmentTemplate.InspectorAssessmentTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.inspectorAssessmentTemplate: missing required arguments. Must call: duration, name, rules_package_arns, target_arn.", 9999, IsError = true)>]
        member _.Run(_: InspectorAssessmentTemplateState<_, _, _, _>) : aws.InspectorAssessmentTemplate.InspectorAssessmentTemplate =
            Unchecked.defaultof<aws.InspectorAssessmentTemplate.InspectorAssessmentTemplate>
