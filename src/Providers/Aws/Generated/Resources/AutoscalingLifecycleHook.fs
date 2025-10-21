namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name> = { assignments: ResizeArray<aws.AutoscalingLifecycleHook.AutoscalingLifecycleHookConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_lifecycle_hook">aws_autoscaling_lifecycle_hook</a>.
    /// </summary>
    type AutoscalingLifecycleHookBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutoscalingLifecycleHookState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutoscalingLifecycleHookState<Missing, Missing, Missing>)

        member _.Zero(()) : AutoscalingLifecycleHookState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AutoscalingLifecycleHookState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_lifecycle_hook#autoscaling_group_name-1">AutoscalingLifecycleHook#autoscaling_group_name</a>.
        /// </summary>
        [<CustomOperation "autoscaling_group_name">]
        member _.AutoscalingGroupName(state: AutoscalingLifecycleHookState<Missing, 'LifecycleTransition, 'Name>, value: string) : AutoscalingLifecycleHookState<Present, 'LifecycleTransition, 'Name> =
            state.assignments.Add(fun config -> config.AutoscalingGroupName <- value)
            ({ assignments = state.assignments } : AutoscalingLifecycleHookState<Present, 'LifecycleTransition, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_lifecycle_hook#lifecycle_transition-1">AutoscalingLifecycleHook#lifecycle_transition</a>.
        /// </summary>
        [<CustomOperation "lifecycle_transition">]
        member _.LifecycleTransition(state: AutoscalingLifecycleHookState<'AutoscalingGroupName, Missing, 'Name>, value: string) : AutoscalingLifecycleHookState<'AutoscalingGroupName, Present, 'Name> =
            state.assignments.Add(fun config -> config.LifecycleTransition <- value)
            ({ assignments = state.assignments } : AutoscalingLifecycleHookState<'AutoscalingGroupName, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_lifecycle_hook#name-1">AutoscalingLifecycleHook#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, Missing>, value: string) : AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_lifecycle_hook#default_result-1">AutoscalingLifecycleHook#default_result</a>.
        /// </summary>
        [<CustomOperation "default_result">]
        member _.DefaultResult(state: AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name>, value: string) : AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name> =
            state.assignments.Add(fun config -> config.DefaultResult <- value)
            state : AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_lifecycle_hook#heartbeat_timeout-1">AutoscalingLifecycleHook#heartbeat_timeout</a>.
        /// </summary>
        [<CustomOperation "heartbeat_timeout">]
        member _.HeartbeatTimeout(state: AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name>, value: double) : AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name> =
            state.assignments.Add(fun config -> config.HeartbeatTimeout <- value)
            state : AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_lifecycle_hook#id-1">AutoscalingLifecycleHook#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name>, value: string) : AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_lifecycle_hook#notification_metadata-1">AutoscalingLifecycleHook#notification_metadata</a>.
        /// </summary>
        [<CustomOperation "notification_metadata">]
        member _.NotificationMetadata(state: AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name>, value: string) : AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name> =
            state.assignments.Add(fun config -> config.NotificationMetadata <- value)
            state : AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_lifecycle_hook#notification_target_arn-1">AutoscalingLifecycleHook#notification_target_arn</a>.
        /// </summary>
        [<CustomOperation "notification_target_arn">]
        member _.NotificationTargetArn(state: AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name>, value: string) : AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name> =
            state.assignments.Add(fun config -> config.NotificationTargetArn <- value)
            state : AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_lifecycle_hook#role_arn-1">AutoscalingLifecycleHook#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name>, value: string) : AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : AutoscalingLifecycleHookState<'AutoscalingGroupName, 'LifecycleTransition, 'Name>

        member _.Run(state: AutoscalingLifecycleHookState<Present, Present, Present>) : aws.AutoscalingLifecycleHook.AutoscalingLifecycleHook =
            let config = aws.AutoscalingLifecycleHook.AutoscalingLifecycleHookConfig()
            for setter in state.assignments do
                setter config
            aws.AutoscalingLifecycleHook.AutoscalingLifecycleHook(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.autoscalingLifecycleHook: missing required arguments. Must call: autoscaling_group_name, lifecycle_transition, name.", 9999, IsError = true)>]
        member _.Run(_: AutoscalingLifecycleHookState<_, _, _>) : aws.AutoscalingLifecycleHook.AutoscalingLifecycleHook =
            Unchecked.defaultof<aws.AutoscalingLifecycleHook.AutoscalingLifecycleHook>
