namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueJobState<'Command, 'Name, 'RoleArn> = { assignments: ResizeArray<aws.GlueJob.GlueJobConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job">aws_glue_job</a>.
    /// </summary>
    type GlueJobBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueJobState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueJobState<Missing, Missing, Missing>)

        member _.Zero(()) : GlueJobState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueJobState<Missing, Missing, Missing>)

        /// <summary>
        /// command block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#command-1">GlueJob#command</a>
        /// </summary>
        [<CustomOperation "command">]
        member _.Command(state: GlueJobState<Missing, 'Name, 'RoleArn>, value: aws.GlueJob.GlueJobCommand) : GlueJobState<Present, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Command <- value)
            ({ assignments = state.assignments } : GlueJobState<Present, 'Name, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#name-1">GlueJob#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlueJobState<'Command, Missing, 'RoleArn>, value: string) : GlueJobState<'Command, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlueJobState<'Command, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#role_arn-1">GlueJob#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: GlueJobState<'Command, 'Name, Missing>, value: string) : GlueJobState<'Command, 'Name, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : GlueJobState<'Command, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#connections-1">GlueJob#connections</a>.
        /// </summary>
        [<CustomOperation "connections">]
        member _.Connections(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: seq<string>) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Connections <- (value |> Seq.toArray))
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#default_arguments-1">GlueJob#default_arguments</a>.
        /// </summary>
        [<CustomOperation "default_arguments">]
        member _.DefaultArguments(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: seq<string * string>) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.DefaultArguments <- dict value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#description-1">GlueJob#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: string) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#execution_class-1">GlueJob#execution_class</a>.
        /// </summary>
        [<CustomOperation "execution_class">]
        member _.ExecutionClass(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: string) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.ExecutionClass <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// execution_property block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#execution_property-1">GlueJob#execution_property</a>
        /// </summary>
        [<CustomOperation "execution_property">]
        member _.ExecutionProperty(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: aws.GlueJob.GlueJobExecutionProperty) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.ExecutionProperty <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#glue_version-1">GlueJob#glue_version</a>.
        /// </summary>
        [<CustomOperation "glue_version">]
        member _.GlueVersion(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: string) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.GlueVersion <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#id-1">GlueJob#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: string) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#job_run_queuing_enabled-1">GlueJob#job_run_queuing_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "job_run_queuing_enabled">]
        member _.JobRunQueuingEnabled(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: bool) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.JobRunQueuingEnabled <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#job_run_queuing_enabled-1">GlueJob#job_run_queuing_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "job_run_queuing_enabled">]
        member _.JobRunQueuingEnabled(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.JobRunQueuingEnabled <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#maintenance_window-1">GlueJob#maintenance_window</a>.
        /// </summary>
        [<CustomOperation "maintenance_window">]
        member _.MaintenanceWindow(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: string) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.MaintenanceWindow <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#max_capacity-1">GlueJob#max_capacity</a>.
        /// </summary>
        [<CustomOperation "max_capacity">]
        member _.MaxCapacity(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: double) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.MaxCapacity <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#max_retries-1">GlueJob#max_retries</a>.
        /// </summary>
        [<CustomOperation "max_retries">]
        member _.MaxRetries(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: double) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.MaxRetries <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#non_overridable_arguments-1">GlueJob#non_overridable_arguments</a>.
        /// </summary>
        [<CustomOperation "non_overridable_arguments">]
        member _.NonOverridableArguments(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: seq<string * string>) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.NonOverridableArguments <- dict value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// notification_property block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#notification_property-1">GlueJob#notification_property</a>
        /// </summary>
        [<CustomOperation "notification_property">]
        member _.NotificationProperty(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: aws.GlueJob.GlueJobNotificationProperty) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.NotificationProperty <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#number_of_workers-1">GlueJob#number_of_workers</a>.
        /// </summary>
        [<CustomOperation "number_of_workers">]
        member _.NumberOfWorkers(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: double) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.NumberOfWorkers <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#security_configuration-1">GlueJob#security_configuration</a>.
        /// </summary>
        [<CustomOperation "security_configuration">]
        member _.SecurityConfiguration(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: string) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.SecurityConfiguration <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// source_control_details block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#source_control_details-1">GlueJob#source_control_details</a>
        /// </summary>
        [<CustomOperation "source_control_details">]
        member _.SourceControlDetails(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: aws.GlueJob.GlueJobSourceControlDetails) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.SourceControlDetails <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#tags-1">GlueJob#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: seq<string * string>) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#tags_all-1">GlueJob#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: seq<string * string>) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#timeout-1">GlueJob#timeout</a>.
        /// </summary>
        [<CustomOperation "timeout">]
        member _.Timeout(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: double) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeout <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_job#worker_type-1">GlueJob#worker_type</a>.
        /// </summary>
        [<CustomOperation "worker_type">]
        member _.WorkerType(state: GlueJobState<'Command, 'Name, 'RoleArn>, value: string) : GlueJobState<'Command, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.WorkerType <- value)
            state : GlueJobState<'Command, 'Name, 'RoleArn>

        member _.Run(state: GlueJobState<Present, Present, Present>) : aws.GlueJob.GlueJob =
            let config = aws.GlueJob.GlueJobConfig()
            for setter in state.assignments do
                setter config
            aws.GlueJob.GlueJob(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueJob: missing required arguments. Must call: command, name, role_arn.", 9999, IsError = true)>]
        member _.Run(_: GlueJobState<_, _, _>) : aws.GlueJob.GlueJob =
            Unchecked.defaultof<aws.GlueJob.GlueJob>
