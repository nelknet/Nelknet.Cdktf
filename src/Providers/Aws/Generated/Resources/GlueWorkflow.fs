namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueWorkflowState = { assignments: ResizeArray<aws.GlueWorkflow.GlueWorkflowConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_workflow">aws_glue_workflow</a>.
    /// </summary>
    type GlueWorkflowBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueWorkflowState =
            { assignments = ResizeArray() }

        member _.Zero(()) : GlueWorkflowState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_workflow#default_run_properties-1">GlueWorkflow#default_run_properties</a>.
        /// </summary>
        [<CustomOperation "default_run_properties">]
        member _.DefaultRunProperties(state: GlueWorkflowState, value: seq<string * string>) : GlueWorkflowState =
            state.assignments.Add(fun config -> config.DefaultRunProperties <- dict value)
            state : GlueWorkflowState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_workflow#description-1">GlueWorkflow#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GlueWorkflowState, value: string) : GlueWorkflowState =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GlueWorkflowState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_workflow#id-1">GlueWorkflow#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueWorkflowState, value: string) : GlueWorkflowState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueWorkflowState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_workflow#max_concurrent_runs-1">GlueWorkflow#max_concurrent_runs</a>.
        /// </summary>
        [<CustomOperation "max_concurrent_runs">]
        member _.MaxConcurrentRuns(state: GlueWorkflowState, value: double) : GlueWorkflowState =
            state.assignments.Add(fun config -> config.MaxConcurrentRuns <- value)
            state : GlueWorkflowState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_workflow#name-1">GlueWorkflow#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlueWorkflowState, value: string) : GlueWorkflowState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : GlueWorkflowState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_workflow#tags-1">GlueWorkflow#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlueWorkflowState, value: seq<string * string>) : GlueWorkflowState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlueWorkflowState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_workflow#tags_all-1">GlueWorkflow#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GlueWorkflowState, value: seq<string * string>) : GlueWorkflowState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GlueWorkflowState

        member _.Run(state: GlueWorkflowState) : aws.GlueWorkflow.GlueWorkflow =
            let config = aws.GlueWorkflow.GlueWorkflowConfig()
            for setter in state.assignments do
                setter config
            aws.GlueWorkflow.GlueWorkflow(StackContext.get (), logicalId, config)
