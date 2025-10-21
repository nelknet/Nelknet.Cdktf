namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace> = { assignments: ResizeArray<aws.AppautoscalingScheduledAction.AppautoscalingScheduledActionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_scheduled_action">aws_appautoscaling_scheduled_action</a>.
    /// </summary>
    type AppautoscalingScheduledActionBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppautoscalingScheduledActionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppautoscalingScheduledActionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppautoscalingScheduledActionState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppautoscalingScheduledActionState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_scheduled_action#name-1">AppautoscalingScheduledAction#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppautoscalingScheduledActionState<Missing, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace>, value: string) : AppautoscalingScheduledActionState<Present, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppautoscalingScheduledActionState<Present, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_scheduled_action#resource_id-1">AppautoscalingScheduledAction#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: AppautoscalingScheduledActionState<'Name, Missing, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace>, value: string) : AppautoscalingScheduledActionState<'Name, Present, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : AppautoscalingScheduledActionState<'Name, Present, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_scheduled_action#scalable_dimension-1">AppautoscalingScheduledAction#scalable_dimension</a>.
        /// </summary>
        [<CustomOperation "scalable_dimension">]
        member _.ScalableDimension(state: AppautoscalingScheduledActionState<'Name, 'ResourceId, Missing, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace>, value: string) : AppautoscalingScheduledActionState<'Name, 'ResourceId, Present, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.ScalableDimension <- value)
            ({ assignments = state.assignments } : AppautoscalingScheduledActionState<'Name, 'ResourceId, Present, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace>)

        /// <summary>
        /// scalable_target_action block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_scheduled_action#scalable_target_action-1">AppautoscalingScheduledAction#scalable_target_action</a>
        /// </summary>
        [<CustomOperation "scalable_target_action">]
        member _.ScalableTargetAction(state: AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, Missing, 'Schedule, 'ServiceNamespace>, value: aws.AppautoscalingScheduledAction.AppautoscalingScheduledActionScalableTargetAction) : AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, Present, 'Schedule, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.ScalableTargetAction <- value)
            ({ assignments = state.assignments } : AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, Present, 'Schedule, 'ServiceNamespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_scheduled_action#schedule-1">AppautoscalingScheduledAction#schedule</a>.
        /// </summary>
        [<CustomOperation "schedule">]
        member _.Schedule(state: AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, Missing, 'ServiceNamespace>, value: string) : AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, Present, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.Schedule <- value)
            ({ assignments = state.assignments } : AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, Present, 'ServiceNamespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_scheduled_action#service_namespace-1">AppautoscalingScheduledAction#service_namespace</a>.
        /// </summary>
        [<CustomOperation "service_namespace">]
        member _.ServiceNamespace(state: AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, Missing>, value: string) : AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, Present> =
            state.assignments.Add(fun config -> config.ServiceNamespace <- value)
            ({ assignments = state.assignments } : AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_scheduled_action#end_time-1">AppautoscalingScheduledAction#end_time</a>.
        /// </summary>
        [<CustomOperation "end_time">]
        member _.EndTime(state: AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace>, value: string) : AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.EndTime <- value)
            state : AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_scheduled_action#id-1">AppautoscalingScheduledAction#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace>, value: string) : AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_scheduled_action#start_time-1">AppautoscalingScheduledAction#start_time</a>.
        /// </summary>
        [<CustomOperation "start_time">]
        member _.StartTime(state: AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace>, value: string) : AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.StartTime <- value)
            state : AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_scheduled_action#timezone-1">AppautoscalingScheduledAction#timezone</a>.
        /// </summary>
        [<CustomOperation "timezone">]
        member _.Timezone(state: AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace>, value: string) : AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.Timezone <- value)
            state : AppautoscalingScheduledActionState<'Name, 'ResourceId, 'ScalableDimension, 'ScalableTargetAction, 'Schedule, 'ServiceNamespace>

        member _.Run(state: AppautoscalingScheduledActionState<Present, Present, Present, Present, Present, Present>) : aws.AppautoscalingScheduledAction.AppautoscalingScheduledAction =
            let config = aws.AppautoscalingScheduledAction.AppautoscalingScheduledActionConfig()
            for setter in state.assignments do
                setter config
            aws.AppautoscalingScheduledAction.AppautoscalingScheduledAction(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appautoscalingScheduledAction: missing required arguments. Must call: name, resource_id, scalable_dimension, scalable_target_action, schedule, service_namespace.", 9999, IsError = true)>]
        member _.Run(_: AppautoscalingScheduledActionState<_, _, _, _, _, _>) : aws.AppautoscalingScheduledAction.AppautoscalingScheduledAction =
            Unchecked.defaultof<aws.AppautoscalingScheduledAction.AppautoscalingScheduledAction>
