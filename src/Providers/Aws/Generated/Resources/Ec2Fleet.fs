namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> = { assignments: ResizeArray<aws.Ec2Fleet.Ec2FleetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet">aws_ec2_fleet</a>.
    /// </summary>
    type Ec2FleetBuilder(logicalId: string) =
        member _.Yield(_: unit) : Ec2FleetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2FleetState<Missing, Missing>)

        member _.Zero(()) : Ec2FleetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Ec2FleetState<Missing, Missing>)

        /// <summary>
        /// launch_template_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#launch_template_config-1">Ec2Fleet#launch_template_config</a> Accepts: aws.IResolvable | aws.Ec2Fleet.Ec2FleetLaunchTemplateConfig[]
        /// </summary>
        [<CustomOperation "launch_template_config">]
        member _.LaunchTemplateConfig(state: Ec2FleetState<Missing, 'TargetCapacitySpecification>, value: HashiCorp.Cdktf.IResolvable) : Ec2FleetState<Present, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.LaunchTemplateConfig <- value)
            ({ assignments = state.assignments } : Ec2FleetState<Present, 'TargetCapacitySpecification>)

        /// <summary>
        /// target_capacity_specification block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#target_capacity_specification-1">Ec2Fleet#target_capacity_specification</a>
        /// </summary>
        [<CustomOperation "target_capacity_specification">]
        member _.TargetCapacitySpecification(state: Ec2FleetState<'LaunchTemplateConfig, Missing>, value: aws.Ec2Fleet.Ec2FleetTargetCapacitySpecification) : Ec2FleetState<'LaunchTemplateConfig, Present> =
            state.assignments.Add(fun config -> config.TargetCapacitySpecification <- value)
            ({ assignments = state.assignments } : Ec2FleetState<'LaunchTemplateConfig, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#context-1">Ec2Fleet#context</a>.
        /// </summary>
        [<CustomOperation "context">]
        member _.Context(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: string) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.Context <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#excess_capacity_termination_policy-1">Ec2Fleet#excess_capacity_termination_policy</a>.
        /// </summary>
        [<CustomOperation "excess_capacity_termination_policy">]
        member _.ExcessCapacityTerminationPolicy(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: string) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.ExcessCapacityTerminationPolicy <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// fleet_instance_set block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#fleet_instance_set-1">Ec2Fleet#fleet_instance_set</a> Accepts: aws.IResolvable | aws.Ec2Fleet.Ec2FleetFleetInstanceSet[]
        /// </summary>
        [<CustomOperation "fleet_instance_set">]
        member _.FleetInstanceSet(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: HashiCorp.Cdktf.IResolvable) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.FleetInstanceSet <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#fleet_state-1">Ec2Fleet#fleet_state</a>.
        /// </summary>
        [<CustomOperation "fleet_state">]
        member _.FleetState(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: string) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.FleetState <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#fulfilled_capacity-1">Ec2Fleet#fulfilled_capacity</a>.
        /// </summary>
        [<CustomOperation "fulfilled_capacity">]
        member _.FulfilledCapacity(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: double) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.FulfilledCapacity <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#fulfilled_on_demand_capacity-1">Ec2Fleet#fulfilled_on_demand_capacity</a>.
        /// </summary>
        [<CustomOperation "fulfilled_on_demand_capacity">]
        member _.FulfilledOnDemandCapacity(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: double) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.FulfilledOnDemandCapacity <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#id-1">Ec2Fleet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: string) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// on_demand_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#on_demand_options-1">Ec2Fleet#on_demand_options</a>
        /// </summary>
        [<CustomOperation "on_demand_options">]
        member _.OnDemandOptions(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: aws.Ec2Fleet.Ec2FleetOnDemandOptions) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.OnDemandOptions <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#replace_unhealthy_instances-1">Ec2Fleet#replace_unhealthy_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "replace_unhealthy_instances">]
        member _.ReplaceUnhealthyInstances(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: bool) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.ReplaceUnhealthyInstances <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#replace_unhealthy_instances-1">Ec2Fleet#replace_unhealthy_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "replace_unhealthy_instances">]
        member _.ReplaceUnhealthyInstances(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: HashiCorp.Cdktf.IResolvable) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.ReplaceUnhealthyInstances <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// spot_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#spot_options-1">Ec2Fleet#spot_options</a>
        /// </summary>
        [<CustomOperation "spot_options">]
        member _.SpotOptions(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: aws.Ec2Fleet.Ec2FleetSpotOptions) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.SpotOptions <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#tags-1">Ec2Fleet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: seq<string * string>) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#tags_all-1">Ec2Fleet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: seq<string * string>) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#terminate_instances-1">Ec2Fleet#terminate_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "terminate_instances">]
        member _.TerminateInstances(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: bool) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.TerminateInstances <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#terminate_instances-1">Ec2Fleet#terminate_instances</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "terminate_instances">]
        member _.TerminateInstances(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: HashiCorp.Cdktf.IResolvable) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.TerminateInstances <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#terminate_instances_with_expiration-1">Ec2Fleet#terminate_instances_with_expiration</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "terminate_instances_with_expiration">]
        member _.TerminateInstancesWithExpiration(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: bool) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.TerminateInstancesWithExpiration <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#terminate_instances_with_expiration-1">Ec2Fleet#terminate_instances_with_expiration</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "terminate_instances_with_expiration">]
        member _.TerminateInstancesWithExpiration(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: HashiCorp.Cdktf.IResolvable) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.TerminateInstancesWithExpiration <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#timeouts-1">Ec2Fleet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: aws.Ec2Fleet.Ec2FleetTimeouts) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#type-1">Ec2Fleet#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: string) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#valid_from-1">Ec2Fleet#valid_from</a>.
        /// </summary>
        [<CustomOperation "valid_from">]
        member _.ValidFrom(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: string) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.ValidFrom <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#valid_until-1">Ec2Fleet#valid_until</a>.
        /// </summary>
        [<CustomOperation "valid_until">]
        member _.ValidUntil(state: Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>, value: string) : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification> =
            state.assignments.Add(fun config -> config.ValidUntil <- value)
            state : Ec2FleetState<'LaunchTemplateConfig, 'TargetCapacitySpecification>

        member _.Run(state: Ec2FleetState<Present, Present>) : aws.Ec2Fleet.Ec2Fleet =
            let config = aws.Ec2Fleet.Ec2FleetConfig()
            for setter in state.assignments do
                setter config
            aws.Ec2Fleet.Ec2Fleet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ec2Fleet: missing required arguments. Must call: launch_template_config, target_capacity_specification.", 9999, IsError = true)>]
        member _.Run(_: Ec2FleetState<_, _>) : aws.Ec2Fleet.Ec2Fleet =
            Unchecked.defaultof<aws.Ec2Fleet.Ec2Fleet>
