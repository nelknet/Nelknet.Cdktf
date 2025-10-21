namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition> = { assignments: ResizeArray<aws.FisExperimentTemplate.FisExperimentTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template">aws_fis_experiment_template</a>.
    /// </summary>
    type FisExperimentTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : FisExperimentTemplateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FisExperimentTemplateState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FisExperimentTemplateState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FisExperimentTemplateState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#action-1">FisExperimentTemplate#action</a> Accepts: aws.IResolvable | aws.FisExperimentTemplate.FisExperimentTemplateAction[]
        /// </summary>
        [<CustomOperation "action">]
        member _.Action(state: FisExperimentTemplateState<Missing, 'Description, 'RoleArn, 'StopCondition>, value: HashiCorp.Cdktf.IResolvable) : FisExperimentTemplateState<Present, 'Description, 'RoleArn, 'StopCondition> =
            state.assignments.Add(fun config -> config.Action <- value)
            ({ assignments = state.assignments } : FisExperimentTemplateState<Present, 'Description, 'RoleArn, 'StopCondition>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#description-1">FisExperimentTemplate#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: FisExperimentTemplateState<'Action, Missing, 'RoleArn, 'StopCondition>, value: string) : FisExperimentTemplateState<'Action, Present, 'RoleArn, 'StopCondition> =
            state.assignments.Add(fun config -> config.Description <- value)
            ({ assignments = state.assignments } : FisExperimentTemplateState<'Action, Present, 'RoleArn, 'StopCondition>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#role_arn-1">FisExperimentTemplate#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: FisExperimentTemplateState<'Action, 'Description, Missing, 'StopCondition>, value: string) : FisExperimentTemplateState<'Action, 'Description, Present, 'StopCondition> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : FisExperimentTemplateState<'Action, 'Description, Present, 'StopCondition>)

        /// <summary>
        /// stop_condition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#stop_condition-1">FisExperimentTemplate#stop_condition</a> Accepts: aws.IResolvable | aws.FisExperimentTemplate.FisExperimentTemplateStopCondition[]
        /// </summary>
        [<CustomOperation "stop_condition">]
        member _.StopCondition(state: FisExperimentTemplateState<'Action, 'Description, 'RoleArn, Missing>, value: HashiCorp.Cdktf.IResolvable) : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, Present> =
            state.assignments.Add(fun config -> config.StopCondition <- value)
            ({ assignments = state.assignments } : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, Present>)

        /// <summary>
        /// experiment_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#experiment_options-1">FisExperimentTemplate#experiment_options</a>
        /// </summary>
        [<CustomOperation "experiment_options">]
        member _.ExperimentOptions(state: FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>, value: aws.FisExperimentTemplate.FisExperimentTemplateExperimentOptions) : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition> =
            state.assignments.Add(fun config -> config.ExperimentOptions <- value)
            state : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>

        /// <summary>
        /// experiment_report_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#experiment_report_configuration-1">FisExperimentTemplate#experiment_report_configuration</a>
        /// </summary>
        [<CustomOperation "experiment_report_configuration">]
        member _.ExperimentReportConfiguration(state: FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>, value: aws.FisExperimentTemplate.FisExperimentTemplateExperimentReportConfiguration) : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition> =
            state.assignments.Add(fun config -> config.ExperimentReportConfiguration <- value)
            state : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#id-1">FisExperimentTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>, value: string) : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>

        /// <summary>
        /// log_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#log_configuration-1">FisExperimentTemplate#log_configuration</a>
        /// </summary>
        [<CustomOperation "log_configuration">]
        member _.LogConfiguration(state: FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>, value: aws.FisExperimentTemplate.FisExperimentTemplateLogConfiguration) : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition> =
            state.assignments.Add(fun config -> config.LogConfiguration <- value)
            state : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#tags-1">FisExperimentTemplate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>, value: seq<string * string>) : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#tags_all-1">FisExperimentTemplate#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>, value: seq<string * string>) : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>

        /// <summary>
        /// target block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#target-1">FisExperimentTemplate#target</a> Accepts: aws.IResolvable | aws.FisExperimentTemplate.FisExperimentTemplateTarget[]
        /// </summary>
        [<CustomOperation "target">]
        member _.Target(state: FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>, value: HashiCorp.Cdktf.IResolvable) : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition> =
            state.assignments.Add(fun config -> config.Target <- value)
            state : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/fis_experiment_template#timeouts-1">FisExperimentTemplate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>, value: aws.FisExperimentTemplate.FisExperimentTemplateTimeouts) : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FisExperimentTemplateState<'Action, 'Description, 'RoleArn, 'StopCondition>

        member _.Run(state: FisExperimentTemplateState<Present, Present, Present, Present>) : aws.FisExperimentTemplate.FisExperimentTemplate =
            let config = aws.FisExperimentTemplate.FisExperimentTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.FisExperimentTemplate.FisExperimentTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.fisExperimentTemplate: missing required arguments. Must call: action, description, role_arn, stop_condition.", 9999, IsError = true)>]
        member _.Run(_: FisExperimentTemplateState<_, _, _, _>) : aws.FisExperimentTemplate.FisExperimentTemplate =
            Unchecked.defaultof<aws.FisExperimentTemplate.FisExperimentTemplate>
