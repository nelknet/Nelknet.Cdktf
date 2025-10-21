namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcsServiceState<'Name> = { assignments: ResizeArray<aws.EcsService.EcsServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service">aws_ecs_service</a>.
    /// </summary>
    type EcsServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcsServiceState<Missing> =
            ({ assignments = ResizeArray() } : EcsServiceState<Missing>)

        member _.Zero(()) : EcsServiceState<Missing> =
            ({ assignments = ResizeArray() } : EcsServiceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#name-1">EcsService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EcsServiceState<Missing>, value: string) : EcsServiceState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EcsServiceState<Present>)

        /// <summary>
        /// alarms block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#alarms-1">EcsService#alarms</a>
        /// </summary>
        [<CustomOperation "alarms">]
        member _.Alarms(state: EcsServiceState<'Name>, value: aws.EcsService.EcsServiceAlarms) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.Alarms <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#availability_zone_rebalancing-1">EcsService#availability_zone_rebalancing</a>.
        /// </summary>
        [<CustomOperation "availability_zone_rebalancing">]
        member _.AvailabilityZoneRebalancing(state: EcsServiceState<'Name>, value: string) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.AvailabilityZoneRebalancing <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// capacity_provider_strategy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#capacity_provider_strategy-1">EcsService#capacity_provider_strategy</a> Accepts: aws.IResolvable | aws.EcsService.EcsServiceCapacityProviderStrategy[]
        /// </summary>
        [<CustomOperation "capacity_provider_strategy">]
        member _.CapacityProviderStrategy(state: EcsServiceState<'Name>, value: HashiCorp.Cdktf.IResolvable) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.CapacityProviderStrategy <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#cluster-1">EcsService#cluster</a>.
        /// </summary>
        [<CustomOperation "cluster">]
        member _.Cluster(state: EcsServiceState<'Name>, value: string) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.Cluster <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// deployment_circuit_breaker block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#deployment_circuit_breaker-1">EcsService#deployment_circuit_breaker</a>
        /// </summary>
        [<CustomOperation "deployment_circuit_breaker">]
        member _.DeploymentCircuitBreaker(state: EcsServiceState<'Name>, value: aws.EcsService.EcsServiceDeploymentCircuitBreaker) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.DeploymentCircuitBreaker <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// deployment_controller block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#deployment_controller-1">EcsService#deployment_controller</a>
        /// </summary>
        [<CustomOperation "deployment_controller">]
        member _.DeploymentController(state: EcsServiceState<'Name>, value: aws.EcsService.EcsServiceDeploymentController) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.DeploymentController <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#deployment_maximum_percent-1">EcsService#deployment_maximum_percent</a>.
        /// </summary>
        [<CustomOperation "deployment_maximum_percent">]
        member _.DeploymentMaximumPercent(state: EcsServiceState<'Name>, value: double) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.DeploymentMaximumPercent <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#deployment_minimum_healthy_percent-1">EcsService#deployment_minimum_healthy_percent</a>.
        /// </summary>
        [<CustomOperation "deployment_minimum_healthy_percent">]
        member _.DeploymentMinimumHealthyPercent(state: EcsServiceState<'Name>, value: double) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.DeploymentMinimumHealthyPercent <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#desired_count-1">EcsService#desired_count</a>.
        /// </summary>
        [<CustomOperation "desired_count">]
        member _.DesiredCount(state: EcsServiceState<'Name>, value: double) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.DesiredCount <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#enable_ecs_managed_tags-1">EcsService#enable_ecs_managed_tags</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_ecs_managed_tags">]
        member _.EnableEcsManagedTags(state: EcsServiceState<'Name>, value: bool) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.EnableEcsManagedTags <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#enable_ecs_managed_tags-1">EcsService#enable_ecs_managed_tags</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_ecs_managed_tags">]
        member _.EnableEcsManagedTags(state: EcsServiceState<'Name>, value: HashiCorp.Cdktf.IResolvable) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.EnableEcsManagedTags <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#enable_execute_command-1">EcsService#enable_execute_command</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_execute_command">]
        member _.EnableExecuteCommand(state: EcsServiceState<'Name>, value: bool) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.EnableExecuteCommand <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#enable_execute_command-1">EcsService#enable_execute_command</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_execute_command">]
        member _.EnableExecuteCommand(state: EcsServiceState<'Name>, value: HashiCorp.Cdktf.IResolvable) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.EnableExecuteCommand <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#force_delete-1">EcsService#force_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete">]
        member _.ForceDelete(state: EcsServiceState<'Name>, value: bool) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.ForceDelete <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#force_delete-1">EcsService#force_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete">]
        member _.ForceDelete(state: EcsServiceState<'Name>, value: HashiCorp.Cdktf.IResolvable) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.ForceDelete <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#force_new_deployment-1">EcsService#force_new_deployment</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_new_deployment">]
        member _.ForceNewDeployment(state: EcsServiceState<'Name>, value: bool) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.ForceNewDeployment <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#force_new_deployment-1">EcsService#force_new_deployment</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_new_deployment">]
        member _.ForceNewDeployment(state: EcsServiceState<'Name>, value: HashiCorp.Cdktf.IResolvable) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.ForceNewDeployment <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#health_check_grace_period_seconds-1">EcsService#health_check_grace_period_seconds</a>.
        /// </summary>
        [<CustomOperation "health_check_grace_period_seconds">]
        member _.HealthCheckGracePeriodSeconds(state: EcsServiceState<'Name>, value: double) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.HealthCheckGracePeriodSeconds <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#iam_role-1">EcsService#iam_role</a>.
        /// </summary>
        [<CustomOperation "iam_role">]
        member _.IamRole(state: EcsServiceState<'Name>, value: string) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.IamRole <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#id-1">EcsService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcsServiceState<'Name>, value: string) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#launch_type-1">EcsService#launch_type</a>.
        /// </summary>
        [<CustomOperation "launch_type">]
        member _.LaunchType(state: EcsServiceState<'Name>, value: string) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.LaunchType <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// load_balancer block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#load_balancer-1">EcsService#load_balancer</a> Accepts: aws.IResolvable | aws.EcsService.EcsServiceLoadBalancer[]
        /// </summary>
        [<CustomOperation "load_balancer">]
        member _.LoadBalancer(state: EcsServiceState<'Name>, value: HashiCorp.Cdktf.IResolvable) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.LoadBalancer <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// network_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#network_configuration-1">EcsService#network_configuration</a>
        /// </summary>
        [<CustomOperation "network_configuration">]
        member _.NetworkConfiguration(state: EcsServiceState<'Name>, value: aws.EcsService.EcsServiceNetworkConfiguration) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.NetworkConfiguration <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// ordered_placement_strategy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#ordered_placement_strategy-1">EcsService#ordered_placement_strategy</a> Accepts: aws.IResolvable | aws.EcsService.EcsServiceOrderedPlacementStrategy[]
        /// </summary>
        [<CustomOperation "ordered_placement_strategy">]
        member _.OrderedPlacementStrategy(state: EcsServiceState<'Name>, value: HashiCorp.Cdktf.IResolvable) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.OrderedPlacementStrategy <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// placement_constraints block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#placement_constraints-1">EcsService#placement_constraints</a> Accepts: aws.IResolvable | aws.EcsService.EcsServicePlacementConstraints[]
        /// </summary>
        [<CustomOperation "placement_constraints">]
        member _.PlacementConstraints(state: EcsServiceState<'Name>, value: HashiCorp.Cdktf.IResolvable) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.PlacementConstraints <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#platform_version-1">EcsService#platform_version</a>.
        /// </summary>
        [<CustomOperation "platform_version">]
        member _.PlatformVersion(state: EcsServiceState<'Name>, value: string) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.PlatformVersion <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#propagate_tags-1">EcsService#propagate_tags</a>.
        /// </summary>
        [<CustomOperation "propagate_tags">]
        member _.PropagateTags(state: EcsServiceState<'Name>, value: string) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.PropagateTags <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#scheduling_strategy-1">EcsService#scheduling_strategy</a>.
        /// </summary>
        [<CustomOperation "scheduling_strategy">]
        member _.SchedulingStrategy(state: EcsServiceState<'Name>, value: string) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.SchedulingStrategy <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// service_connect_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#service_connect_configuration-1">EcsService#service_connect_configuration</a>
        /// </summary>
        [<CustomOperation "service_connect_configuration">]
        member _.ServiceConnectConfiguration(state: EcsServiceState<'Name>, value: aws.EcsService.EcsServiceServiceConnectConfiguration) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.ServiceConnectConfiguration <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// service_registries block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#service_registries-1">EcsService#service_registries</a>
        /// </summary>
        [<CustomOperation "service_registries">]
        member _.ServiceRegistries(state: EcsServiceState<'Name>, value: aws.EcsService.EcsServiceServiceRegistries) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.ServiceRegistries <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#tags-1">EcsService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EcsServiceState<'Name>, value: seq<string * string>) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#tags_all-1">EcsService#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EcsServiceState<'Name>, value: seq<string * string>) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#task_definition-1">EcsService#task_definition</a>.
        /// </summary>
        [<CustomOperation "task_definition">]
        member _.TaskDefinition(state: EcsServiceState<'Name>, value: string) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.TaskDefinition <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#timeouts-1">EcsService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: EcsServiceState<'Name>, value: aws.EcsService.EcsServiceTimeouts) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#triggers-1">EcsService#triggers</a>.
        /// </summary>
        [<CustomOperation "triggers">]
        member _.Triggers(state: EcsServiceState<'Name>, value: seq<string * string>) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.Triggers <- dict value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// volume_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#volume_configuration-1">EcsService#volume_configuration</a>
        /// </summary>
        [<CustomOperation "volume_configuration">]
        member _.VolumeConfiguration(state: EcsServiceState<'Name>, value: aws.EcsService.EcsServiceVolumeConfiguration) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.VolumeConfiguration <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// vpc_lattice_configurations block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#vpc_lattice_configurations-1">EcsService#vpc_lattice_configurations</a> Accepts: aws.IResolvable | aws.EcsService.EcsServiceVpcLatticeConfigurations[]
        /// </summary>
        [<CustomOperation "vpc_lattice_configurations">]
        member _.VpcLatticeConfigurations(state: EcsServiceState<'Name>, value: HashiCorp.Cdktf.IResolvable) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.VpcLatticeConfigurations <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#wait_for_steady_state-1">EcsService#wait_for_steady_state</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_steady_state">]
        member _.WaitForSteadyState(state: EcsServiceState<'Name>, value: bool) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.WaitForSteadyState <- value)
            state : EcsServiceState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_service#wait_for_steady_state-1">EcsService#wait_for_steady_state</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_for_steady_state">]
        member _.WaitForSteadyState(state: EcsServiceState<'Name>, value: HashiCorp.Cdktf.IResolvable) : EcsServiceState<'Name> =
            state.assignments.Add(fun config -> config.WaitForSteadyState <- value)
            state : EcsServiceState<'Name>

        member _.Run(state: EcsServiceState<Present>) : aws.EcsService.EcsService =
            let config = aws.EcsService.EcsServiceConfig()
            for setter in state.assignments do
                setter config
            aws.EcsService.EcsService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecsService: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: EcsServiceState<_>) : aws.EcsService.EcsService =
            Unchecked.defaultof<aws.EcsService.EcsService>
