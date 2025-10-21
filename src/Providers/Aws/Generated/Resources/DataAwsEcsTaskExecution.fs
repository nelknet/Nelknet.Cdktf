namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> = { assignments: ResizeArray<aws.DataAwsEcsTaskExecution.DataAwsEcsTaskExecutionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution">aws_ecs_task_execution</a>.
    /// </summary>
    type DataAwsEcsTaskExecutionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEcsTaskExecutionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcsTaskExecutionState<Missing, Missing>)

        member _.Zero(()) : DataAwsEcsTaskExecutionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcsTaskExecutionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#cluster-1">DataAwsEcsTaskExecution#cluster</a>.
        /// </summary>
        [<CustomOperation "cluster">]
        member _.Cluster(state: DataAwsEcsTaskExecutionState<Missing, 'TaskDefinition>, value: string) : DataAwsEcsTaskExecutionState<Present, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.Cluster <- value)
            ({ assignments = state.assignments } : DataAwsEcsTaskExecutionState<Present, 'TaskDefinition>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#task_definition-1">DataAwsEcsTaskExecution#task_definition</a>.
        /// </summary>
        [<CustomOperation "task_definition">]
        member _.TaskDefinition(state: DataAwsEcsTaskExecutionState<'Cluster, Missing>, value: string) : DataAwsEcsTaskExecutionState<'Cluster, Present> =
            state.assignments.Add(fun config -> config.TaskDefinition <- value)
            ({ assignments = state.assignments } : DataAwsEcsTaskExecutionState<'Cluster, Present>)

        /// <summary>
        /// capacity_provider_strategy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#capacity_provider_strategy-1">DataAwsEcsTaskExecution#capacity_provider_strategy</a> Accepts: aws.IResolvable | aws.DataAwsEcsTaskExecution.DataAwsEcsTaskExecutionCapacityProviderStrategy[]
        /// </summary>
        [<CustomOperation "capacity_provider_strategy">]
        member _.CapacityProviderStrategy(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: HashiCorp.Cdktf.IResolvable) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.CapacityProviderStrategy <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#client_token-1">DataAwsEcsTaskExecution#client_token</a>.
        /// </summary>
        [<CustomOperation "client_token">]
        member _.ClientToken(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: string) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.ClientToken <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#desired_count-1">DataAwsEcsTaskExecution#desired_count</a>.
        /// </summary>
        [<CustomOperation "desired_count">]
        member _.DesiredCount(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: double) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.DesiredCount <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#enable_ecs_managed_tags-1">DataAwsEcsTaskExecution#enable_ecs_managed_tags</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_ecs_managed_tags">]
        member _.EnableEcsManagedTags(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: bool) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.EnableEcsManagedTags <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#enable_ecs_managed_tags-1">DataAwsEcsTaskExecution#enable_ecs_managed_tags</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_ecs_managed_tags">]
        member _.EnableEcsManagedTags(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: HashiCorp.Cdktf.IResolvable) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.EnableEcsManagedTags <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#enable_execute_command-1">DataAwsEcsTaskExecution#enable_execute_command</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_execute_command">]
        member _.EnableExecuteCommand(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: bool) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.EnableExecuteCommand <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#enable_execute_command-1">DataAwsEcsTaskExecution#enable_execute_command</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_execute_command">]
        member _.EnableExecuteCommand(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: HashiCorp.Cdktf.IResolvable) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.EnableExecuteCommand <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#group-1">DataAwsEcsTaskExecution#group</a>.
        /// </summary>
        [<CustomOperation "group">]
        member _.Group(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: string) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.Group <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#id-1">DataAwsEcsTaskExecution#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: string) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#launch_type-1">DataAwsEcsTaskExecution#launch_type</a>.
        /// </summary>
        [<CustomOperation "launch_type">]
        member _.LaunchType(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: string) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.LaunchType <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// network_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#network_configuration-1">DataAwsEcsTaskExecution#network_configuration</a>
        /// </summary>
        [<CustomOperation "network_configuration">]
        member _.NetworkConfiguration(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: aws.DataAwsEcsTaskExecution.DataAwsEcsTaskExecutionNetworkConfiguration) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.NetworkConfiguration <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// overrides block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#overrides-1">DataAwsEcsTaskExecution#overrides</a>
        /// </summary>
        [<CustomOperation "overrides">]
        member _.Overrides(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: aws.DataAwsEcsTaskExecution.DataAwsEcsTaskExecutionOverrides) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.Overrides <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// placement_constraints block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#placement_constraints-1">DataAwsEcsTaskExecution#placement_constraints</a> Accepts: aws.IResolvable | aws.DataAwsEcsTaskExecution.DataAwsEcsTaskExecutionPlacementConstraints[]
        /// </summary>
        [<CustomOperation "placement_constraints">]
        member _.PlacementConstraints(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: HashiCorp.Cdktf.IResolvable) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.PlacementConstraints <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// placement_strategy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#placement_strategy-1">DataAwsEcsTaskExecution#placement_strategy</a> Accepts: aws.IResolvable | aws.DataAwsEcsTaskExecution.DataAwsEcsTaskExecutionPlacementStrategy[]
        /// </summary>
        [<CustomOperation "placement_strategy">]
        member _.PlacementStrategy(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: HashiCorp.Cdktf.IResolvable) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.PlacementStrategy <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#platform_version-1">DataAwsEcsTaskExecution#platform_version</a>.
        /// </summary>
        [<CustomOperation "platform_version">]
        member _.PlatformVersion(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: string) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.PlatformVersion <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#propagate_tags-1">DataAwsEcsTaskExecution#propagate_tags</a>.
        /// </summary>
        [<CustomOperation "propagate_tags">]
        member _.PropagateTags(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: string) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.PropagateTags <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#reference_id-1">DataAwsEcsTaskExecution#reference_id</a>.
        /// </summary>
        [<CustomOperation "reference_id">]
        member _.ReferenceId(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: string) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.ReferenceId <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#started_by-1">DataAwsEcsTaskExecution#started_by</a>.
        /// </summary>
        [<CustomOperation "started_by">]
        member _.StartedBy(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: string) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.StartedBy <- value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_execution#tags-1">DataAwsEcsTaskExecution#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>, value: seq<string * string>) : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsEcsTaskExecutionState<'Cluster, 'TaskDefinition>

        member _.Run(state: DataAwsEcsTaskExecutionState<Present, Present>) : aws.DataAwsEcsTaskExecution.DataAwsEcsTaskExecution =
            let config = aws.DataAwsEcsTaskExecution.DataAwsEcsTaskExecutionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEcsTaskExecution.DataAwsEcsTaskExecution(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEcsTaskExecution: missing required arguments. Must call: cluster, task_definition.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEcsTaskExecutionState<_, _>) : aws.DataAwsEcsTaskExecution.DataAwsEcsTaskExecution =
            Unchecked.defaultof<aws.DataAwsEcsTaskExecution.DataAwsEcsTaskExecution>
