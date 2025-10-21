namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Macie2ClassificationJobState<'JobType, 'S3JobDefinition> = { assignments: ResizeArray<aws.Macie2ClassificationJob.Macie2ClassificationJobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job">aws_macie2_classification_job</a>.
    /// </summary>
    type Macie2ClassificationJobBuilder(logicalId: string) =
        member _.Yield(_: unit) : Macie2ClassificationJobState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Macie2ClassificationJobState<Missing, Missing>)

        member _.Zero(()) : Macie2ClassificationJobState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Macie2ClassificationJobState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#job_type-1">Macie2ClassificationJob#job_type</a>.
        /// </summary>
        [<CustomOperation "job_type">]
        member _.JobType(state: Macie2ClassificationJobState<Missing, 'S3JobDefinition>, value: string) : Macie2ClassificationJobState<Present, 'S3JobDefinition> =
            state.assignments.Add(fun config -> config.JobType <- value)
            ({ assignments = state.assignments } : Macie2ClassificationJobState<Present, 'S3JobDefinition>)

        /// <summary>
        /// s3_job_definition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#s3_job_definition-1">Macie2ClassificationJob#s3_job_definition</a>
        /// </summary>
        [<CustomOperation "s3_job_definition">]
        member _.S3JobDefinition(state: Macie2ClassificationJobState<'JobType, Missing>, value: aws.Macie2ClassificationJob.Macie2ClassificationJobS3JobDefinition) : Macie2ClassificationJobState<'JobType, Present> =
            state.assignments.Add(fun config -> config.S3JobDefinition <- value)
            ({ assignments = state.assignments } : Macie2ClassificationJobState<'JobType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#custom_data_identifier_ids-1">Macie2ClassificationJob#custom_data_identifier_ids</a>.
        /// </summary>
        [<CustomOperation "custom_data_identifier_ids">]
        member _.CustomDataIdentifierIds(state: Macie2ClassificationJobState<'JobType, 'S3JobDefinition>, value: seq<string>) : Macie2ClassificationJobState<'JobType, 'S3JobDefinition> =
            state.assignments.Add(fun config -> config.CustomDataIdentifierIds <- (value |> Seq.toArray))
            state : Macie2ClassificationJobState<'JobType, 'S3JobDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#description-1">Macie2ClassificationJob#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Macie2ClassificationJobState<'JobType, 'S3JobDefinition>, value: string) : Macie2ClassificationJobState<'JobType, 'S3JobDefinition> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Macie2ClassificationJobState<'JobType, 'S3JobDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#id-1">Macie2ClassificationJob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Macie2ClassificationJobState<'JobType, 'S3JobDefinition>, value: string) : Macie2ClassificationJobState<'JobType, 'S3JobDefinition> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Macie2ClassificationJobState<'JobType, 'S3JobDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#initial_run-1">Macie2ClassificationJob#initial_run</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "initial_run">]
        member _.InitialRun(state: Macie2ClassificationJobState<'JobType, 'S3JobDefinition>, value: bool) : Macie2ClassificationJobState<'JobType, 'S3JobDefinition> =
            state.assignments.Add(fun config -> config.InitialRun <- value)
            state : Macie2ClassificationJobState<'JobType, 'S3JobDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#initial_run-1">Macie2ClassificationJob#initial_run</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "initial_run">]
        member _.InitialRun(state: Macie2ClassificationJobState<'JobType, 'S3JobDefinition>, value: HashiCorp.Cdktf.IResolvable) : Macie2ClassificationJobState<'JobType, 'S3JobDefinition> =
            state.assignments.Add(fun config -> config.InitialRun <- value)
            state : Macie2ClassificationJobState<'JobType, 'S3JobDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#job_status-1">Macie2ClassificationJob#job_status</a>.
        /// </summary>
        [<CustomOperation "job_status">]
        member _.JobStatus(state: Macie2ClassificationJobState<'JobType, 'S3JobDefinition>, value: string) : Macie2ClassificationJobState<'JobType, 'S3JobDefinition> =
            state.assignments.Add(fun config -> config.JobStatus <- value)
            state : Macie2ClassificationJobState<'JobType, 'S3JobDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#name-1">Macie2ClassificationJob#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Macie2ClassificationJobState<'JobType, 'S3JobDefinition>, value: string) : Macie2ClassificationJobState<'JobType, 'S3JobDefinition> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : Macie2ClassificationJobState<'JobType, 'S3JobDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#name_prefix-1">Macie2ClassificationJob#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: Macie2ClassificationJobState<'JobType, 'S3JobDefinition>, value: string) : Macie2ClassificationJobState<'JobType, 'S3JobDefinition> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : Macie2ClassificationJobState<'JobType, 'S3JobDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#sampling_percentage-1">Macie2ClassificationJob#sampling_percentage</a>.
        /// </summary>
        [<CustomOperation "sampling_percentage">]
        member _.SamplingPercentage(state: Macie2ClassificationJobState<'JobType, 'S3JobDefinition>, value: double) : Macie2ClassificationJobState<'JobType, 'S3JobDefinition> =
            state.assignments.Add(fun config -> config.SamplingPercentage <- value)
            state : Macie2ClassificationJobState<'JobType, 'S3JobDefinition>

        /// <summary>
        /// schedule_frequency block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#schedule_frequency-1">Macie2ClassificationJob#schedule_frequency</a>
        /// </summary>
        [<CustomOperation "schedule_frequency">]
        member _.ScheduleFrequency(state: Macie2ClassificationJobState<'JobType, 'S3JobDefinition>, value: aws.Macie2ClassificationJob.Macie2ClassificationJobScheduleFrequency) : Macie2ClassificationJobState<'JobType, 'S3JobDefinition> =
            state.assignments.Add(fun config -> config.ScheduleFrequency <- value)
            state : Macie2ClassificationJobState<'JobType, 'S3JobDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#tags-1">Macie2ClassificationJob#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Macie2ClassificationJobState<'JobType, 'S3JobDefinition>, value: seq<string * string>) : Macie2ClassificationJobState<'JobType, 'S3JobDefinition> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Macie2ClassificationJobState<'JobType, 'S3JobDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#tags_all-1">Macie2ClassificationJob#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Macie2ClassificationJobState<'JobType, 'S3JobDefinition>, value: seq<string * string>) : Macie2ClassificationJobState<'JobType, 'S3JobDefinition> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Macie2ClassificationJobState<'JobType, 'S3JobDefinition>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_classification_job#timeouts-1">Macie2ClassificationJob#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Macie2ClassificationJobState<'JobType, 'S3JobDefinition>, value: aws.Macie2ClassificationJob.Macie2ClassificationJobTimeouts) : Macie2ClassificationJobState<'JobType, 'S3JobDefinition> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Macie2ClassificationJobState<'JobType, 'S3JobDefinition>

        member _.Run(state: Macie2ClassificationJobState<Present, Present>) : aws.Macie2ClassificationJob.Macie2ClassificationJob =
            let config = aws.Macie2ClassificationJob.Macie2ClassificationJobConfig()
            for setter in state.assignments do
                setter config
            aws.Macie2ClassificationJob.Macie2ClassificationJob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.macie2ClassificationJob: missing required arguments. Must call: job_type, s3_job_definition.", 9999, IsError = true)>]
        member _.Run(_: Macie2ClassificationJobState<_, _>) : aws.Macie2ClassificationJob.Macie2ClassificationJob =
            Unchecked.defaultof<aws.Macie2ClassificationJob.Macie2ClassificationJob>
