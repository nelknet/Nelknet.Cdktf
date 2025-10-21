namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutoscalingPolicyState<'AutoscalingGroupName, 'Name> = { assignments: ResizeArray<aws.AutoscalingPolicy.AutoscalingPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy">aws_autoscaling_policy</a>.
    /// </summary>
    type AutoscalingPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutoscalingPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AutoscalingPolicyState<Missing, Missing>)

        member _.Zero(()) : AutoscalingPolicyState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AutoscalingPolicyState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#autoscaling_group_name-1">AutoscalingPolicy#autoscaling_group_name</a>.
        /// </summary>
        [<CustomOperation "autoscaling_group_name">]
        member _.AutoscalingGroupName(state: AutoscalingPolicyState<Missing, 'Name>, value: string) : AutoscalingPolicyState<Present, 'Name> =
            state.assignments.Add(fun config -> config.AutoscalingGroupName <- value)
            ({ assignments = state.assignments } : AutoscalingPolicyState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#name-1">AutoscalingPolicy#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutoscalingPolicyState<'AutoscalingGroupName, Missing>, value: string) : AutoscalingPolicyState<'AutoscalingGroupName, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutoscalingPolicyState<'AutoscalingGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#adjustment_type-1">AutoscalingPolicy#adjustment_type</a>.
        /// </summary>
        [<CustomOperation "adjustment_type">]
        member _.AdjustmentType(state: AutoscalingPolicyState<'AutoscalingGroupName, 'Name>, value: string) : AutoscalingPolicyState<'AutoscalingGroupName, 'Name> =
            state.assignments.Add(fun config -> config.AdjustmentType <- value)
            state : AutoscalingPolicyState<'AutoscalingGroupName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#cooldown-1">AutoscalingPolicy#cooldown</a>.
        /// </summary>
        [<CustomOperation "cooldown">]
        member _.Cooldown(state: AutoscalingPolicyState<'AutoscalingGroupName, 'Name>, value: double) : AutoscalingPolicyState<'AutoscalingGroupName, 'Name> =
            state.assignments.Add(fun config -> config.Cooldown <- value)
            state : AutoscalingPolicyState<'AutoscalingGroupName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#enabled-1">AutoscalingPolicy#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AutoscalingPolicyState<'AutoscalingGroupName, 'Name>, value: bool) : AutoscalingPolicyState<'AutoscalingGroupName, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : AutoscalingPolicyState<'AutoscalingGroupName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#enabled-1">AutoscalingPolicy#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: AutoscalingPolicyState<'AutoscalingGroupName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AutoscalingPolicyState<'AutoscalingGroupName, 'Name> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : AutoscalingPolicyState<'AutoscalingGroupName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#estimated_instance_warmup-1">AutoscalingPolicy#estimated_instance_warmup</a>.
        /// </summary>
        [<CustomOperation "estimated_instance_warmup">]
        member _.EstimatedInstanceWarmup(state: AutoscalingPolicyState<'AutoscalingGroupName, 'Name>, value: double) : AutoscalingPolicyState<'AutoscalingGroupName, 'Name> =
            state.assignments.Add(fun config -> config.EstimatedInstanceWarmup <- value)
            state : AutoscalingPolicyState<'AutoscalingGroupName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#id-1">AutoscalingPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutoscalingPolicyState<'AutoscalingGroupName, 'Name>, value: string) : AutoscalingPolicyState<'AutoscalingGroupName, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutoscalingPolicyState<'AutoscalingGroupName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#metric_aggregation_type-1">AutoscalingPolicy#metric_aggregation_type</a>.
        /// </summary>
        [<CustomOperation "metric_aggregation_type">]
        member _.MetricAggregationType(state: AutoscalingPolicyState<'AutoscalingGroupName, 'Name>, value: string) : AutoscalingPolicyState<'AutoscalingGroupName, 'Name> =
            state.assignments.Add(fun config -> config.MetricAggregationType <- value)
            state : AutoscalingPolicyState<'AutoscalingGroupName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#min_adjustment_magnitude-1">AutoscalingPolicy#min_adjustment_magnitude</a>.
        /// </summary>
        [<CustomOperation "min_adjustment_magnitude">]
        member _.MinAdjustmentMagnitude(state: AutoscalingPolicyState<'AutoscalingGroupName, 'Name>, value: double) : AutoscalingPolicyState<'AutoscalingGroupName, 'Name> =
            state.assignments.Add(fun config -> config.MinAdjustmentMagnitude <- value)
            state : AutoscalingPolicyState<'AutoscalingGroupName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#policy_type-1">AutoscalingPolicy#policy_type</a>.
        /// </summary>
        [<CustomOperation "policy_type">]
        member _.PolicyType(state: AutoscalingPolicyState<'AutoscalingGroupName, 'Name>, value: string) : AutoscalingPolicyState<'AutoscalingGroupName, 'Name> =
            state.assignments.Add(fun config -> config.PolicyType <- value)
            state : AutoscalingPolicyState<'AutoscalingGroupName, 'Name>

        /// <summary>
        /// predictive_scaling_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#predictive_scaling_configuration-1">AutoscalingPolicy#predictive_scaling_configuration</a>
        /// </summary>
        [<CustomOperation "predictive_scaling_configuration">]
        member _.PredictiveScalingConfiguration(state: AutoscalingPolicyState<'AutoscalingGroupName, 'Name>, value: aws.AutoscalingPolicy.AutoscalingPolicyPredictiveScalingConfiguration) : AutoscalingPolicyState<'AutoscalingGroupName, 'Name> =
            state.assignments.Add(fun config -> config.PredictiveScalingConfiguration <- value)
            state : AutoscalingPolicyState<'AutoscalingGroupName, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#scaling_adjustment-1">AutoscalingPolicy#scaling_adjustment</a>.
        /// </summary>
        [<CustomOperation "scaling_adjustment">]
        member _.ScalingAdjustment(state: AutoscalingPolicyState<'AutoscalingGroupName, 'Name>, value: double) : AutoscalingPolicyState<'AutoscalingGroupName, 'Name> =
            state.assignments.Add(fun config -> config.ScalingAdjustment <- value)
            state : AutoscalingPolicyState<'AutoscalingGroupName, 'Name>

        /// <summary>
        /// step_adjustment block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#step_adjustment-1">AutoscalingPolicy#step_adjustment</a> Accepts: aws.IResolvable | aws.AutoscalingPolicy.AutoscalingPolicyStepAdjustment[]
        /// </summary>
        [<CustomOperation "step_adjustment">]
        member _.StepAdjustment(state: AutoscalingPolicyState<'AutoscalingGroupName, 'Name>, value: HashiCorp.Cdktf.IResolvable) : AutoscalingPolicyState<'AutoscalingGroupName, 'Name> =
            state.assignments.Add(fun config -> config.StepAdjustment <- value)
            state : AutoscalingPolicyState<'AutoscalingGroupName, 'Name>

        /// <summary>
        /// target_tracking_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_policy#target_tracking_configuration-1">AutoscalingPolicy#target_tracking_configuration</a>
        /// </summary>
        [<CustomOperation "target_tracking_configuration">]
        member _.TargetTrackingConfiguration(state: AutoscalingPolicyState<'AutoscalingGroupName, 'Name>, value: aws.AutoscalingPolicy.AutoscalingPolicyTargetTrackingConfiguration) : AutoscalingPolicyState<'AutoscalingGroupName, 'Name> =
            state.assignments.Add(fun config -> config.TargetTrackingConfiguration <- value)
            state : AutoscalingPolicyState<'AutoscalingGroupName, 'Name>

        member _.Run(state: AutoscalingPolicyState<Present, Present>) : aws.AutoscalingPolicy.AutoscalingPolicy =
            let config = aws.AutoscalingPolicy.AutoscalingPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.AutoscalingPolicy.AutoscalingPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.autoscalingPolicy: missing required arguments. Must call: autoscaling_group_name, name.", 9999, IsError = true)>]
        member _.Run(_: AutoscalingPolicyState<_, _>) : aws.AutoscalingPolicy.AutoscalingPolicy =
            Unchecked.defaultof<aws.AutoscalingPolicy.AutoscalingPolicy>
