namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GlueTriggerState<'Actions, 'Name, 'Type> = { assignments: ResizeArray<aws.GlueTrigger.GlueTriggerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger">aws_glue_trigger</a>.
    /// </summary>
    type GlueTriggerBuilder(logicalId: string) =
        member _.Yield(_: unit) : GlueTriggerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueTriggerState<Missing, Missing, Missing>)

        member _.Zero(()) : GlueTriggerState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GlueTriggerState<Missing, Missing, Missing>)

        /// <summary>
        /// actions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#actions-1">GlueTrigger#actions</a> Accepts: aws.IResolvable | aws.GlueTrigger.GlueTriggerActions[]
        /// </summary>
        [<CustomOperation "actions">]
        member _.Actions(state: GlueTriggerState<Missing, 'Name, 'Type>, value: HashiCorp.Cdktf.IResolvable) : GlueTriggerState<Present, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Actions <- value)
            ({ assignments = state.assignments } : GlueTriggerState<Present, 'Name, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#name-1">GlueTrigger#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GlueTriggerState<'Actions, Missing, 'Type>, value: string) : GlueTriggerState<'Actions, Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GlueTriggerState<'Actions, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#type-1">GlueTrigger#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: GlueTriggerState<'Actions, 'Name, Missing>, value: string) : GlueTriggerState<'Actions, 'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : GlueTriggerState<'Actions, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#description-1">GlueTrigger#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GlueTriggerState<'Actions, 'Name, 'Type>, value: string) : GlueTriggerState<'Actions, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GlueTriggerState<'Actions, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#enabled-1">GlueTrigger#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: GlueTriggerState<'Actions, 'Name, 'Type>, value: bool) : GlueTriggerState<'Actions, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : GlueTriggerState<'Actions, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#enabled-1">GlueTrigger#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: GlueTriggerState<'Actions, 'Name, 'Type>, value: HashiCorp.Cdktf.IResolvable) : GlueTriggerState<'Actions, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : GlueTriggerState<'Actions, 'Name, 'Type>

        /// <summary>
        /// event_batching_condition block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#event_batching_condition-1">GlueTrigger#event_batching_condition</a> Accepts: aws.IResolvable | aws.GlueTrigger.GlueTriggerEventBatchingCondition[]
        /// </summary>
        [<CustomOperation "event_batching_condition">]
        member _.EventBatchingCondition(state: GlueTriggerState<'Actions, 'Name, 'Type>, value: HashiCorp.Cdktf.IResolvable) : GlueTriggerState<'Actions, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.EventBatchingCondition <- value)
            state : GlueTriggerState<'Actions, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#id-1">GlueTrigger#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GlueTriggerState<'Actions, 'Name, 'Type>, value: string) : GlueTriggerState<'Actions, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GlueTriggerState<'Actions, 'Name, 'Type>

        /// <summary>
        /// predicate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#predicate-1">GlueTrigger#predicate</a>
        /// </summary>
        [<CustomOperation "predicate">]
        member _.Predicate(state: GlueTriggerState<'Actions, 'Name, 'Type>, value: aws.GlueTrigger.GlueTriggerPredicate) : GlueTriggerState<'Actions, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Predicate <- value)
            state : GlueTriggerState<'Actions, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#schedule-1">GlueTrigger#schedule</a>.
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: GlueTriggerState<'Actions, 'Name, 'Type>, value: string) : GlueTriggerState<'Actions, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            state : GlueTriggerState<'Actions, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#start_on_creation-1">GlueTrigger#start_on_creation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_on_creation">]
        member _.StartOnCreation(state: GlueTriggerState<'Actions, 'Name, 'Type>, value: bool) : GlueTriggerState<'Actions, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.StartOnCreation <- value)
            state : GlueTriggerState<'Actions, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#start_on_creation-1">GlueTrigger#start_on_creation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_on_creation">]
        member _.StartOnCreation(state: GlueTriggerState<'Actions, 'Name, 'Type>, value: HashiCorp.Cdktf.IResolvable) : GlueTriggerState<'Actions, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.StartOnCreation <- value)
            state : GlueTriggerState<'Actions, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#tags-1">GlueTrigger#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GlueTriggerState<'Actions, 'Name, 'Type>, value: seq<string * string>) : GlueTriggerState<'Actions, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GlueTriggerState<'Actions, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#tags_all-1">GlueTrigger#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GlueTriggerState<'Actions, 'Name, 'Type>, value: seq<string * string>) : GlueTriggerState<'Actions, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GlueTriggerState<'Actions, 'Name, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#timeouts-1">GlueTrigger#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GlueTriggerState<'Actions, 'Name, 'Type>, value: aws.GlueTrigger.GlueTriggerTimeouts) : GlueTriggerState<'Actions, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GlueTriggerState<'Actions, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/glue_trigger#workflow_name-1">GlueTrigger#workflow_name</a>.
        /// </summary>
        [<CustomOperation "workflow_name">]
        member _.WorkflowName(state: GlueTriggerState<'Actions, 'Name, 'Type>, value: string) : GlueTriggerState<'Actions, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.WorkflowName <- value)
            state : GlueTriggerState<'Actions, 'Name, 'Type>

        member _.Run(state: GlueTriggerState<Present, Present, Present>) : aws.GlueTrigger.GlueTrigger =
            let config = aws.GlueTrigger.GlueTriggerConfig()
            for setter in state.assignments do
                setter config
            aws.GlueTrigger.GlueTrigger(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.glueTrigger: missing required arguments. Must call: actions, name, type.", 9999, IsError = true)>]
        member _.Run(_: GlueTriggerState<_, _, _>) : aws.GlueTrigger.GlueTrigger =
            Unchecked.defaultof<aws.GlueTrigger.GlueTrigger>
