namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, 'ServiceNamespace> = { assignments: ResizeArray<aws.AppautoscalingPolicy.AppautoscalingPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_policy">aws_appautoscaling_policy</a>.
    /// </summary>
    type AppautoscalingPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppautoscalingPolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppautoscalingPolicyState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppautoscalingPolicyState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppautoscalingPolicyState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_policy#name-1">AppautoscalingPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppautoscalingPolicyState<Missing, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>, value: string) : AppautoscalingPolicyState<Present, 'ResourceId, 'ScalableDimension, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppautoscalingPolicyState<Present, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_policy#resource_id-1">AppautoscalingPolicy#resource_id</a>.
        /// </summary>
        [<CustomOperation "resource_id">]
        member _.ResourceId(state: AppautoscalingPolicyState<'Name, Missing, 'ScalableDimension, 'ServiceNamespace>, value: string) : AppautoscalingPolicyState<'Name, Present, 'ScalableDimension, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.ResourceId <- value)
            ({ assignments = state.assignments } : AppautoscalingPolicyState<'Name, Present, 'ScalableDimension, 'ServiceNamespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_policy#scalable_dimension-1">AppautoscalingPolicy#scalable_dimension</a>.
        /// </summary>
        [<CustomOperation "scalable_dimension">]
        member _.ScalableDimension(state: AppautoscalingPolicyState<'Name, 'ResourceId, Missing, 'ServiceNamespace>, value: string) : AppautoscalingPolicyState<'Name, 'ResourceId, Present, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.ScalableDimension <- value)
            ({ assignments = state.assignments } : AppautoscalingPolicyState<'Name, 'ResourceId, Present, 'ServiceNamespace>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_policy#service_namespace-1">AppautoscalingPolicy#service_namespace</a>.
        /// </summary>
        [<CustomOperation "service_namespace">]
        member _.ServiceNamespace(state: AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, Missing>, value: string) : AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, Present> =
            state.assignments.Add(fun config -> config.ServiceNamespace <- value)
            ({ assignments = state.assignments } : AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_policy#id-1">AppautoscalingPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>, value: string) : AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_policy#policy_type-1">AppautoscalingPolicy#policy_type</a>.
        /// </summary>
        [<CustomOperation "policy_type">]
        member _.PolicyType(state: AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>, value: string) : AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.PolicyType <- value)
            state : AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>

        /// <summary>
        /// step_scaling_policy_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_policy#step_scaling_policy_configuration-1">AppautoscalingPolicy#step_scaling_policy_configuration</a>
        /// </summary>
        [<CustomOperation "step_scaling_policy_configuration">]
        member _.StepScalingPolicyConfiguration(state: AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>, value: aws.AppautoscalingPolicy.AppautoscalingPolicyStepScalingPolicyConfiguration) : AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.StepScalingPolicyConfiguration <- value)
            state : AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>

        /// <summary>
        /// target_tracking_scaling_policy_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appautoscaling_policy#target_tracking_scaling_policy_configuration-1">AppautoscalingPolicy#target_tracking_scaling_policy_configuration</a>
        /// </summary>
        [<CustomOperation "target_tracking_scaling_policy_configuration">]
        member _.TargetTrackingScalingPolicyConfiguration(state: AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>, value: aws.AppautoscalingPolicy.AppautoscalingPolicyTargetTrackingScalingPolicyConfiguration) : AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, 'ServiceNamespace> =
            state.assignments.Add(fun config -> config.TargetTrackingScalingPolicyConfiguration <- value)
            state : AppautoscalingPolicyState<'Name, 'ResourceId, 'ScalableDimension, 'ServiceNamespace>

        member _.Run(state: AppautoscalingPolicyState<Present, Present, Present, Present>) : aws.AppautoscalingPolicy.AppautoscalingPolicy =
            let config = aws.AppautoscalingPolicy.AppautoscalingPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.AppautoscalingPolicy.AppautoscalingPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.appautoscalingPolicy: missing required arguments. Must call: name, resource_id, scalable_dimension, service_namespace.", 9999, IsError = true)>]
        member _.Run(_: AppautoscalingPolicyState<_, _, _, _>) : aws.AppautoscalingPolicy.AppautoscalingPolicy =
            Unchecked.defaultof<aws.AppautoscalingPolicy.AppautoscalingPolicy>
