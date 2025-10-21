namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EmrcontainersJobTemplateState<'JobTemplateData, 'Name> = { assignments: ResizeArray<aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template">aws_emrcontainers_job_template</a>.
    /// </summary>
    type EmrcontainersJobTemplateBuilder(logicalId: string) =
        member _.Yield(_: unit) : EmrcontainersJobTemplateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrcontainersJobTemplateState<Missing, Missing>)

        member _.Zero(()) : EmrcontainersJobTemplateState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrcontainersJobTemplateState<Missing, Missing>)

        /// <summary>
        /// job_template_data block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#job_template_data-1">EmrcontainersJobTemplate#job_template_data</a>
        /// </summary>
        [<CustomOperation "job_template_data">]
        member _.JobTemplateData(state: EmrcontainersJobTemplateState<Missing, 'Name>, value: aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateData) : EmrcontainersJobTemplateState<Present, 'Name> =
            state.assignments.Add(fun config -> config.JobTemplateData <- value)
            ({ assignments = state.assignments } : EmrcontainersJobTemplateState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#name-1">EmrcontainersJobTemplate#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EmrcontainersJobTemplateState<'JobTemplateData, Missing>, value: string) : EmrcontainersJobTemplateState<'JobTemplateData, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EmrcontainersJobTemplateState<'JobTemplateData, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#id-1">EmrcontainersJobTemplate#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EmrcontainersJobTemplateState<'JobTemplateData, 'Name>, value: string) : EmrcontainersJobTemplateState<'JobTemplateData, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EmrcontainersJobTemplateState<'JobTemplateData, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#kms_key_arn-1">EmrcontainersJobTemplate#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: EmrcontainersJobTemplateState<'JobTemplateData, 'Name>, value: string) : EmrcontainersJobTemplateState<'JobTemplateData, 'Name> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : EmrcontainersJobTemplateState<'JobTemplateData, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#tags-1">EmrcontainersJobTemplate#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EmrcontainersJobTemplateState<'JobTemplateData, 'Name>, value: seq<string * string>) : EmrcontainersJobTemplateState<'JobTemplateData, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EmrcontainersJobTemplateState<'JobTemplateData, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#tags_all-1">EmrcontainersJobTemplate#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EmrcontainersJobTemplateState<'JobTemplateData, 'Name>, value: seq<string * string>) : EmrcontainersJobTemplateState<'JobTemplateData, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EmrcontainersJobTemplateState<'JobTemplateData, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrcontainers_job_template#timeouts-1">EmrcontainersJobTemplate#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EmrcontainersJobTemplateState<'JobTemplateData, 'Name>, value: aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateTimeouts) : EmrcontainersJobTemplateState<'JobTemplateData, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EmrcontainersJobTemplateState<'JobTemplateData, 'Name>

        member _.Run(state: EmrcontainersJobTemplateState<Present, Present>) : aws.EmrcontainersJobTemplate.EmrcontainersJobTemplate =
            let config = aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateConfig()
            for setter in state.assignments do
                setter config
            aws.EmrcontainersJobTemplate.EmrcontainersJobTemplate(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.emrcontainersJobTemplate: missing required arguments. Must call: job_template_data, name.", 9999, IsError = true)>]
        member _.Run(_: EmrcontainersJobTemplateState<_, _>) : aws.EmrcontainersJobTemplate.EmrcontainersJobTemplate =
            Unchecked.defaultof<aws.EmrcontainersJobTemplate.EmrcontainersJobTemplate>
