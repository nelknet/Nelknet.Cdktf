namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AutoscalingGroupState<'MaxSize, 'MinSize> = { assignments: ResizeArray<aws.AutoscalingGroup.AutoscalingGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group">aws_autoscaling_group</a>.
    /// </summary>
    type AutoscalingGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : AutoscalingGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AutoscalingGroupState<Missing, Missing>)

        member _.Zero(()) : AutoscalingGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AutoscalingGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#max_size-1">AutoscalingGroup#max_size</a>.
        /// </summary>
        [<CustomOperation "max_size">]
        member _.MaxSize(state: AutoscalingGroupState<Missing, 'MinSize>, value: double) : AutoscalingGroupState<Present, 'MinSize> =
            state.assignments.Add(fun config -> config.MaxSize <- value)
            ({ assignments = state.assignments } : AutoscalingGroupState<Present, 'MinSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#min_size-1">AutoscalingGroup#min_size</a>.
        /// </summary>
        [<CustomOperation "min_size">]
        member _.MinSize(state: AutoscalingGroupState<'MaxSize, Missing>, value: double) : AutoscalingGroupState<'MaxSize, Present> =
            state.assignments.Add(fun config -> config.MinSize <- value)
            ({ assignments = state.assignments } : AutoscalingGroupState<'MaxSize, Present>)

        /// <summary>
        /// availability_zone_distribution block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#availability_zone_distribution-1">AutoscalingGroup#availability_zone_distribution</a>
        /// </summary>
        [<CustomOperation "availability_zone_distribution">]
        member _.AvailabilityZoneDistribution(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: aws.AutoscalingGroup.AutoscalingGroupAvailabilityZoneDistribution) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.AvailabilityZoneDistribution <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#availability_zones-1">AutoscalingGroup#availability_zones</a>.
        /// </summary>
        [<CustomOperation "availability_zones">]
        member _.AvailabilityZones(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: seq<string>) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.AvailabilityZones <- (value |> Seq.toArray))
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_rebalance-1">AutoscalingGroup#capacity_rebalance</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "capacity_rebalance">]
        member _.CapacityRebalance(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: bool) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.CapacityRebalance <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_rebalance-1">AutoscalingGroup#capacity_rebalance</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "capacity_rebalance">]
        member _.CapacityRebalance(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: HashiCorp.Cdktf.IResolvable) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.CapacityRebalance <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// capacity_reservation_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#capacity_reservation_specification-1">AutoscalingGroup#capacity_reservation_specification</a>
        /// </summary>
        [<CustomOperation "capacity_reservation_specification">]
        member _.CapacityReservationSpecification(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: aws.AutoscalingGroup.AutoscalingGroupCapacityReservationSpecification) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.CapacityReservationSpecification <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#context-1">AutoscalingGroup#context</a>.
        /// </summary>
        [<CustomOperation "context">]
        member _.Context(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: string) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.Context <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#default_cooldown-1">AutoscalingGroup#default_cooldown</a>.
        /// </summary>
        [<CustomOperation "default_cooldown">]
        member _.DefaultCooldown(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: double) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.DefaultCooldown <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#default_instance_warmup-1">AutoscalingGroup#default_instance_warmup</a>.
        /// </summary>
        [<CustomOperation "default_instance_warmup">]
        member _.DefaultInstanceWarmup(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: double) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.DefaultInstanceWarmup <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#desired_capacity-1">AutoscalingGroup#desired_capacity</a>.
        /// </summary>
        [<CustomOperation "desired_capacity">]
        member _.DesiredCapacity(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: double) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.DesiredCapacity <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#desired_capacity_type-1">AutoscalingGroup#desired_capacity_type</a>.
        /// </summary>
        [<CustomOperation "desired_capacity_type">]
        member _.DesiredCapacityType(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: string) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.DesiredCapacityType <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#enabled_metrics-1">AutoscalingGroup#enabled_metrics</a>.
        /// </summary>
        [<CustomOperation "enabled_metrics">]
        member _.EnabledMetrics(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: seq<string>) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.EnabledMetrics <- (value |> Seq.toArray))
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#force_delete-1">AutoscalingGroup#force_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete">]
        member _.ForceDelete(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: bool) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.ForceDelete <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#force_delete-1">AutoscalingGroup#force_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete">]
        member _.ForceDelete(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: HashiCorp.Cdktf.IResolvable) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.ForceDelete <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#force_delete_warm_pool-1">AutoscalingGroup#force_delete_warm_pool</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete_warm_pool">]
        member _.ForceDeleteWarmPool(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: bool) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.ForceDeleteWarmPool <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#force_delete_warm_pool-1">AutoscalingGroup#force_delete_warm_pool</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete_warm_pool">]
        member _.ForceDeleteWarmPool(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: HashiCorp.Cdktf.IResolvable) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.ForceDeleteWarmPool <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#health_check_grace_period-1">AutoscalingGroup#health_check_grace_period</a>.
        /// </summary>
        [<CustomOperation "health_check_grace_period">]
        member _.HealthCheckGracePeriod(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: double) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.HealthCheckGracePeriod <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#health_check_type-1">AutoscalingGroup#health_check_type</a>.
        /// </summary>
        [<CustomOperation "health_check_type">]
        member _.HealthCheckType(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: string) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.HealthCheckType <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#id-1">AutoscalingGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: string) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#ignore_failed_scaling_activities-1">AutoscalingGroup#ignore_failed_scaling_activities</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ignore_failed_scaling_activities">]
        member _.IgnoreFailedScalingActivities(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: bool) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.IgnoreFailedScalingActivities <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#ignore_failed_scaling_activities-1">AutoscalingGroup#ignore_failed_scaling_activities</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "ignore_failed_scaling_activities">]
        member _.IgnoreFailedScalingActivities(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: HashiCorp.Cdktf.IResolvable) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.IgnoreFailedScalingActivities <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// initial_lifecycle_hook block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#initial_lifecycle_hook-1">AutoscalingGroup#initial_lifecycle_hook</a> Accepts: aws.IResolvable | aws.AutoscalingGroup.AutoscalingGroupInitialLifecycleHook[]
        /// </summary>
        [<CustomOperation "initial_lifecycle_hook">]
        member _.InitialLifecycleHook(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: HashiCorp.Cdktf.IResolvable) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.InitialLifecycleHook <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// instance_maintenance_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#instance_maintenance_policy-1">AutoscalingGroup#instance_maintenance_policy</a>
        /// </summary>
        [<CustomOperation "instance_maintenance_policy">]
        member _.InstanceMaintenancePolicy(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: aws.AutoscalingGroup.AutoscalingGroupInstanceMaintenancePolicy) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.InstanceMaintenancePolicy <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// instance_refresh block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#instance_refresh-1">AutoscalingGroup#instance_refresh</a>
        /// </summary>
        [<CustomOperation "instance_refresh">]
        member _.InstanceRefresh(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: aws.AutoscalingGroup.AutoscalingGroupInstanceRefresh) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.InstanceRefresh <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#launch_configuration-1">AutoscalingGroup#launch_configuration</a>.
        /// </summary>
        [<CustomOperation "launch_configuration">]
        member _.LaunchConfiguration(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: string) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.LaunchConfiguration <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// launch_template block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#launch_template-1">AutoscalingGroup#launch_template</a>
        /// </summary>
        [<CustomOperation "launch_template">]
        member _.LaunchTemplate(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: aws.AutoscalingGroup.AutoscalingGroupLaunchTemplate) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.LaunchTemplate <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#load_balancers-1">AutoscalingGroup#load_balancers</a>.
        /// </summary>
        [<CustomOperation "load_balancers">]
        member _.LoadBalancers(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: seq<string>) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.LoadBalancers <- (value |> Seq.toArray))
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#max_instance_lifetime-1">AutoscalingGroup#max_instance_lifetime</a>.
        /// </summary>
        [<CustomOperation "max_instance_lifetime">]
        member _.MaxInstanceLifetime(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: double) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.MaxInstanceLifetime <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#metrics_granularity-1">AutoscalingGroup#metrics_granularity</a>.
        /// </summary>
        [<CustomOperation "metrics_granularity">]
        member _.MetricsGranularity(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: string) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.MetricsGranularity <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#min_elb_capacity-1">AutoscalingGroup#min_elb_capacity</a>.
        /// </summary>
        [<CustomOperation "min_elb_capacity">]
        member _.MinElbCapacity(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: double) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.MinElbCapacity <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// mixed_instances_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#mixed_instances_policy-1">AutoscalingGroup#mixed_instances_policy</a>
        /// </summary>
        [<CustomOperation "mixed_instances_policy">]
        member _.MixedInstancesPolicy(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: aws.AutoscalingGroup.AutoscalingGroupMixedInstancesPolicy) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.MixedInstancesPolicy <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#name-1">AutoscalingGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: string) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#name_prefix-1">AutoscalingGroup#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: string) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#placement_group-1">AutoscalingGroup#placement_group</a>.
        /// </summary>
        [<CustomOperation "placement_group">]
        member _.PlacementGroup(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: string) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.PlacementGroup <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#protect_from_scale_in-1">AutoscalingGroup#protect_from_scale_in</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "protect_from_scale_in">]
        member _.ProtectFromScaleIn(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: bool) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.ProtectFromScaleIn <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#protect_from_scale_in-1">AutoscalingGroup#protect_from_scale_in</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "protect_from_scale_in">]
        member _.ProtectFromScaleIn(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: HashiCorp.Cdktf.IResolvable) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.ProtectFromScaleIn <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#service_linked_role_arn-1">AutoscalingGroup#service_linked_role_arn</a>.
        /// </summary>
        [<CustomOperation "service_linked_role_arn">]
        member _.ServiceLinkedRoleArn(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: string) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.ServiceLinkedRoleArn <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#suspended_processes-1">AutoscalingGroup#suspended_processes</a>.
        /// </summary>
        [<CustomOperation "suspended_processes">]
        member _.SuspendedProcesses(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: seq<string>) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.SuspendedProcesses <- (value |> Seq.toArray))
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// tag block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#tag-1">AutoscalingGroup#tag</a> Accepts: aws.IResolvable | aws.AutoscalingGroup.AutoscalingGroupTag[]
        /// </summary>
        [<CustomOperation "tag">]
        member _.Tag(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: HashiCorp.Cdktf.IResolvable) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.Tag <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#target_group_arns-1">AutoscalingGroup#target_group_arns</a>.
        /// </summary>
        [<CustomOperation "target_group_arns">]
        member _.TargetGroupArns(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: seq<string>) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.TargetGroupArns <- (value |> Seq.toArray))
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#termination_policies-1">AutoscalingGroup#termination_policies</a>.
        /// </summary>
        [<CustomOperation "termination_policies">]
        member _.TerminationPolicies(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: seq<string>) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.TerminationPolicies <- (value |> Seq.toArray))
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#timeouts-1">AutoscalingGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: aws.AutoscalingGroup.AutoscalingGroupTimeouts) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// traffic_source block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#traffic_source-1">AutoscalingGroup#traffic_source</a> Accepts: aws.IResolvable | aws.AutoscalingGroup.AutoscalingGroupTrafficSource[]
        /// </summary>
        [<CustomOperation "traffic_source">]
        member _.TrafficSource(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: HashiCorp.Cdktf.IResolvable) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.TrafficSource <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#vpc_zone_identifier-1">AutoscalingGroup#vpc_zone_identifier</a>.
        /// </summary>
        [<CustomOperation "vpc_zone_identifier">]
        member _.VpcZoneIdentifier(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: seq<string>) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.VpcZoneIdentifier <- (value |> Seq.toArray))
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#wait_for_capacity_timeout-1">AutoscalingGroup#wait_for_capacity_timeout</a>.
        /// </summary>
        [<CustomOperation "wait_for_capacity_timeout">]
        member _.WaitForCapacityTimeout(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: string) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.WaitForCapacityTimeout <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#wait_for_elb_capacity-1">AutoscalingGroup#wait_for_elb_capacity</a>.
        /// </summary>
        [<CustomOperation "wait_for_elb_capacity">]
        member _.WaitForElbCapacity(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: double) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.WaitForElbCapacity <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        /// <summary>
        /// warm_pool block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/autoscaling_group#warm_pool-1">AutoscalingGroup#warm_pool</a>
        /// </summary>
        [<CustomOperation "warm_pool">]
        member _.WarmPool(state: AutoscalingGroupState<'MaxSize, 'MinSize>, value: aws.AutoscalingGroup.AutoscalingGroupWarmPool) : AutoscalingGroupState<'MaxSize, 'MinSize> =
            state.assignments.Add(fun config -> config.WarmPool <- value)
            state : AutoscalingGroupState<'MaxSize, 'MinSize>

        member _.Run(state: AutoscalingGroupState<Present, Present>) : aws.AutoscalingGroup.AutoscalingGroup =
            let config = aws.AutoscalingGroup.AutoscalingGroupConfig()
            for setter in state.assignments do
                setter config
            aws.AutoscalingGroup.AutoscalingGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.autoscalingGroup: missing required arguments. Must call: max_size, min_size.", 9999, IsError = true)>]
        member _.Run(_: AutoscalingGroupState<_, _>) : aws.AutoscalingGroup.AutoscalingGroup =
            Unchecked.defaultof<aws.AutoscalingGroup.AutoscalingGroup>
