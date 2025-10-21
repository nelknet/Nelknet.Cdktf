namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> = { assignments: ResizeArray<aws.SpotFleetRequest.SpotFleetRequestConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request">aws_spot_fleet_request</a>.
    /// </summary>
    type SpotFleetRequestBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpotFleetRequestState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpotFleetRequestState<Missing, Missing>)

        member _.Zero(()) : SpotFleetRequestState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpotFleetRequestState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#iam_fleet_role-1">SpotFleetRequest#iam_fleet_role</a>.
        /// </summary>
        [<CustomOperation "iam_fleet_role">]
        member _.IamFleetRole(state: SpotFleetRequestState<Missing, 'TargetCapacity>, value: string) : SpotFleetRequestState<Present, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.IamFleetRole <- value)
            ({ assignments = state.assignments } : SpotFleetRequestState<Present, 'TargetCapacity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#target_capacity-1">SpotFleetRequest#target_capacity</a>.
        /// </summary>
        [<CustomOperation "target_capacity">]
        member _.TargetCapacity(state: SpotFleetRequestState<'IamFleetRole, Missing>, value: double) : SpotFleetRequestState<'IamFleetRole, Present> =
            state.assignments.Add(fun config -> config.TargetCapacity <- value)
            ({ assignments = state.assignments } : SpotFleetRequestState<'IamFleetRole, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#allocation_strategy-1">SpotFleetRequest#allocation_strategy</a>.
        /// </summary>
        [<CustomOperation "allocation_strategy">]
        member _.AllocationStrategy(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: string) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.AllocationStrategy <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#context-1">SpotFleetRequest#context</a>.
        /// </summary>
        [<CustomOperation "context">]
        member _.Context(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: string) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.Context <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#excess_capacity_termination_policy-1">SpotFleetRequest#excess_capacity_termination_policy</a>.
        /// </summary>
        [<CustomOperation "excess_capacity_termination_policy">]
        member _.ExcessCapacityTerminationPolicy(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: string) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.ExcessCapacityTerminationPolicy <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#fleet_type-1">SpotFleetRequest#fleet_type</a>.
        /// </summary>
        [<CustomOperation "fleet_type">]
        member _.FleetType(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: string) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.FleetType <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#id-1">SpotFleetRequest#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: string) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#instance_interruption_behaviour-1">SpotFleetRequest#instance_interruption_behaviour</a>.
        /// </summary>
        [<CustomOperation "instance_interruption_behaviour">]
        member _.InstanceInterruptionBehaviour(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: string) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.InstanceInterruptionBehaviour <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#instance_pools_to_use_count-1">SpotFleetRequest#instance_pools_to_use_count</a>.
        /// </summary>
        [<CustomOperation "instance_pools_to_use_count">]
        member _.InstancePoolsToUseCount(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: double) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.InstancePoolsToUseCount <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// launch_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#launch_specification-1">SpotFleetRequest#launch_specification</a> Accepts: aws.IResolvable | aws.SpotFleetRequest.SpotFleetRequestLaunchSpecification[]
        /// </summary>
        [<CustomOperation "launch_specification">]
        member _.LaunchSpecification(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: HashiCorp.Cdktf.IResolvable) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.LaunchSpecification <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// launch_template_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#launch_template_config-1">SpotFleetRequest#launch_template_config</a> Accepts: aws.IResolvable | aws.SpotFleetRequest.SpotFleetRequestLaunchTemplateConfig[]
        /// </summary>
        [<CustomOperation "launch_template_config">]
        member _.LaunchTemplateConfig(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: HashiCorp.Cdktf.IResolvable) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.LaunchTemplateConfig <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#load_balancers-1">SpotFleetRequest#load_balancers</a>.
        /// </summary>
        [<CustomOperation "load_balancers">]
        member _.LoadBalancers(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: seq<string>) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.LoadBalancers <- (value |> Seq.toArray))
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#on_demand_allocation_strategy-1">SpotFleetRequest#on_demand_allocation_strategy</a>.
        /// </summary>
        [<CustomOperation "on_demand_allocation_strategy">]
        member _.OnDemandAllocationStrategy(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: string) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.OnDemandAllocationStrategy <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#on_demand_max_total_price-1">SpotFleetRequest#on_demand_max_total_price</a>.
        /// </summary>
        [<CustomOperation "on_demand_max_total_price">]
        member _.OnDemandMaxTotalPrice(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: string) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.OnDemandMaxTotalPrice <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#on_demand_target_capacity-1">SpotFleetRequest#on_demand_target_capacity</a>.
        /// </summary>
        [<CustomOperation "on_demand_target_capacity">]
        member _.OnDemandTargetCapacity(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: double) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.OnDemandTargetCapacity <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#replace_unhealthy_instances-1">SpotFleetRequest#replace_unhealthy_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "replace_unhealthy_instances">]
        member _.ReplaceUnhealthyInstances(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: bool) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.ReplaceUnhealthyInstances <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#replace_unhealthy_instances-1">SpotFleetRequest#replace_unhealthy_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "replace_unhealthy_instances">]
        member _.ReplaceUnhealthyInstances(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: HashiCorp.Cdktf.IResolvable) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.ReplaceUnhealthyInstances <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// spot_maintenance_strategies block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#spot_maintenance_strategies-1">SpotFleetRequest#spot_maintenance_strategies</a>
        /// </summary>
        [<CustomOperation "spot_maintenance_strategies">]
        member _.SpotMaintenanceStrategies(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: aws.SpotFleetRequest.SpotFleetRequestSpotMaintenanceStrategies) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.SpotMaintenanceStrategies <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#spot_price-1">SpotFleetRequest#spot_price</a>.
        /// </summary>
        [<CustomOperation "spot_price">]
        member _.SpotPrice(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: string) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.SpotPrice <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#tags-1">SpotFleetRequest#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: seq<string * string>) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#tags_all-1">SpotFleetRequest#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: seq<string * string>) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#target_capacity_unit_type-1">SpotFleetRequest#target_capacity_unit_type</a>.
        /// </summary>
        [<CustomOperation "target_capacity_unit_type">]
        member _.TargetCapacityUnitType(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: string) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.TargetCapacityUnitType <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#target_group_arns-1">SpotFleetRequest#target_group_arns</a>.
        /// </summary>
        [<CustomOperation "target_group_arns">]
        member _.TargetGroupArns(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: seq<string>) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.TargetGroupArns <- (value |> Seq.toArray))
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#terminate_instances_on_delete-1">SpotFleetRequest#terminate_instances_on_delete</a>.
        /// </summary>
        [<CustomOperation "terminate_instances_on_delete">]
        member _.TerminateInstancesOnDelete(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: string) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.TerminateInstancesOnDelete <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#terminate_instances_with_expiration-1">SpotFleetRequest#terminate_instances_with_expiration</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "terminate_instances_with_expiration">]
        member _.TerminateInstancesWithExpiration(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: bool) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.TerminateInstancesWithExpiration <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#terminate_instances_with_expiration-1">SpotFleetRequest#terminate_instances_with_expiration</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "terminate_instances_with_expiration">]
        member _.TerminateInstancesWithExpiration(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: HashiCorp.Cdktf.IResolvable) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.TerminateInstancesWithExpiration <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#timeouts-1">SpotFleetRequest#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: aws.SpotFleetRequest.SpotFleetRequestTimeouts) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#valid_from-1">SpotFleetRequest#valid_from</a>.
        /// </summary>
        [<CustomOperation "valid_from">]
        member _.ValidFrom(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: string) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.ValidFrom <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#valid_until-1">SpotFleetRequest#valid_until</a>.
        /// </summary>
        [<CustomOperation "valid_until">]
        member _.ValidUntil(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: string) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.ValidUntil <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#wait_for_fulfillment-1">SpotFleetRequest#wait_for_fulfillment</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_fulfillment">]
        member _.WaitForFulfillment(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: bool) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.WaitForFulfillment <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/spot_fleet_request#wait_for_fulfillment-1">SpotFleetRequest#wait_for_fulfillment</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_fulfillment">]
        member _.WaitForFulfillment(state: SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>, value: HashiCorp.Cdktf.IResolvable) : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity> =
            state.assignments.Add(fun config -> config.WaitForFulfillment <- value)
            state : SpotFleetRequestState<'IamFleetRole, 'TargetCapacity>

        member _.Run(state: SpotFleetRequestState<Present, Present>) : aws.SpotFleetRequest.SpotFleetRequest =
            let config = aws.SpotFleetRequest.SpotFleetRequestConfig()
            for setter in state.assignments do
                setter config
            aws.SpotFleetRequest.SpotFleetRequest(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.spotFleetRequest: missing required arguments. Must call: iam_fleet_role, target_capacity.", 9999, IsError = true)>]
        member _.Run(_: SpotFleetRequestState<_, _>) : aws.SpotFleetRequest.SpotFleetRequest =
            Unchecked.defaultof<aws.SpotFleetRequest.SpotFleetRequest>
