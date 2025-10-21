namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace> = { assignments: ResizeArray<aws.AppautoscalingTarget.AppautoscalingTargetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_target">aws_appautoscaling_target</a>.
    /// </summary>
    type AppautoscalingTargetBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppautoscalingTargetState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppautoscalingTargetState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppautoscalingTargetState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppautoscalingTargetState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_target#max_capacity-1">AppautoscalingTarget#max_capacity</a>.
        /// </summary>
        [<CustomOperation "max_capacity">]
        member _.MaxCapacity(state: AppautoscalingTargetState<Missing, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>, value: double) : AppautoscalingTargetState<Present, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.MaxCapacity <- value)
            ({ assignments = state.assignments } : AppautoscalingTargetState<Present, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_target#min_capacity-1">AppautoscalingTarget#min_capacity</a>.
        /// </summary>
        [<CustomOperation "min_capacity">]
        member _.MinCapacity(state: AppautoscalingTargetState<'MaxCapacity, Missing, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>, value: double) : AppautoscalingTargetState<'MaxCapacity, Present, 'ResourceId, 'ScalableDimension, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.MinCapacity <- value)
            ({ assignments = state.assignments } : AppautoscalingTargetState<'MaxCapacity, Present, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_target#resource_id-1">AppautoscalingTarget#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, Missing, 'ScalableDimension, 'ServiceNamespace>, value: string) : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, Present, 'ScalableDimension, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, Present, 'ScalableDimension, 'ServiceNamespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_target#scalable_dimension-1">AppautoscalingTarget#scalable_dimension</a>.
        /// </summary>
        [<CustomOperation "scalable_dimension">]
        member _.ScalableDimension(state: AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, Missing, 'ServiceNamespace>, value: string) : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, Present, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.ScalableDimension <- value)
            ({ assignments = state.assignments } : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, Present, 'ServiceNamespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_target#service_namespace-1">AppautoscalingTarget#service_namespace</a>.
        /// </summary>
        [<CustomOperation "service_namespace">]
        member _.ServiceNamespace(state: AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, Missing>, value: string) : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, Present> =
            state.assignments.Add(fun config -> config.ServiceNamespace <- value)
            ({ assignments = state.assignments } : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_target#id-1">AppautoscalingTarget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>, value: string) : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_target#role_arn-1">AppautoscalingTarget#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>, value: string) : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>

        /// <summary>
        /// suspended_state block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_target#suspended_state-1">AppautoscalingTarget#suspended_state</a>
        /// </summary>
        [<CustomOperation "suspended_state">]
        member _.SuspendedState(state: AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>, value: aws.AppautoscalingTarget.AppautoscalingTargetSuspendedState) : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.SuspendedState <- value)
            state : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_target#tags-1">AppautoscalingTarget#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>, value: seq<string * string>) : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_target#tags_all-1">AppautoscalingTarget#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>, value: seq<string * string>) : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : AppautoscalingTargetState<'MaxCapacity, 'MinCapacity, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>

        member _.Run(state: AppautoscalingTargetState<Present, Present, Present, Present, Present>) : aws.AppautoscalingTarget.AppautoscalingTarget =
            let config = aws.AppautoscalingTarget.AppautoscalingTargetConfig()
            for setter in state.assignments do
                setter config
            aws.AppautoscalingTarget.AppautoscalingTarget(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appautoscalingTarget: missing required arguments. Must call: max_capacity, min_capacity, resource_id, scalable_dimension, service_namespace.", 9999, IsError = true)>]
        member _.Run(_: AppautoscalingTargetState<_, _, _, _, _>) : aws.AppautoscalingTarget.AppautoscalingTarget =
            Unchecked.defaultof<aws.AppautoscalingTarget.AppautoscalingTarget>
