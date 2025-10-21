namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerHumanTaskUiState<'HumanTaskUiName, 'UiTemplate> = { assignments: ResizeArray<aws.SagemakerHumanTaskUi.SagemakerHumanTaskUiConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_human_task_ui">aws_sagemaker_human_task_ui</a>.
    /// </summary>
    type SagemakerHumanTaskUiBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerHumanTaskUiState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerHumanTaskUiState<Missing, Missing>)

        member _.Zero(()) : SagemakerHumanTaskUiState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerHumanTaskUiState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_human_task_ui#human_task_ui_name-1">SagemakerHumanTaskUi#human_task_ui_name</a>.
        /// </summary>
        [<CustomOperation "human_task_ui_name">]
        member _.HumanTaskUiName(state: SagemakerHumanTaskUiState<Missing, 'UiTemplate>, value: string) : SagemakerHumanTaskUiState<Present, 'UiTemplate> =
            state.assignments.Add(fun config -> config.HumanTaskUiName <- value)
            ({ assignments = state.assignments } : SagemakerHumanTaskUiState<Present, 'UiTemplate>)

        /// <summary>
        /// ui_template block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_human_task_ui#ui_template-1">SagemakerHumanTaskUi#ui_template</a>
        /// </summary>
        [<CustomOperation "ui_template">]
        member _.UiTemplate(state: SagemakerHumanTaskUiState<'HumanTaskUiName, Missing>, value: aws.SagemakerHumanTaskUi.SagemakerHumanTaskUiUiTemplate) : SagemakerHumanTaskUiState<'HumanTaskUiName, Present> =
            state.assignments.Add(fun config -> config.UiTemplate <- value)
            ({ assignments = state.assignments } : SagemakerHumanTaskUiState<'HumanTaskUiName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_human_task_ui#id-1">SagemakerHumanTaskUi#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerHumanTaskUiState<'HumanTaskUiName, 'UiTemplate>, value: string) : SagemakerHumanTaskUiState<'HumanTaskUiName, 'UiTemplate> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerHumanTaskUiState<'HumanTaskUiName, 'UiTemplate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_human_task_ui#tags-1">SagemakerHumanTaskUi#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerHumanTaskUiState<'HumanTaskUiName, 'UiTemplate>, value: seq<string * string>) : SagemakerHumanTaskUiState<'HumanTaskUiName, 'UiTemplate> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerHumanTaskUiState<'HumanTaskUiName, 'UiTemplate>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_human_task_ui#tags_all-1">SagemakerHumanTaskUi#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerHumanTaskUiState<'HumanTaskUiName, 'UiTemplate>, value: seq<string * string>) : SagemakerHumanTaskUiState<'HumanTaskUiName, 'UiTemplate> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerHumanTaskUiState<'HumanTaskUiName, 'UiTemplate>

        member _.Run(state: SagemakerHumanTaskUiState<Present, Present>) : aws.SagemakerHumanTaskUi.SagemakerHumanTaskUi =
            let config = aws.SagemakerHumanTaskUi.SagemakerHumanTaskUiConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerHumanTaskUi.SagemakerHumanTaskUi(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerHumanTaskUi: missing required arguments. Must call: human_task_ui_name, ui_template.", 9999, IsError = true)>]
        member _.Run(_: SagemakerHumanTaskUiState<_, _>) : aws.SagemakerHumanTaskUi.SagemakerHumanTaskUi =
            Unchecked.defaultof<aws.SagemakerHumanTaskUi.SagemakerHumanTaskUi>
