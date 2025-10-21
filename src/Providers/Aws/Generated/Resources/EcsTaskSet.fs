namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> = { assignments: ResizeArray<aws.EcsTaskSet.EcsTaskSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set">aws_ecs_task_set</a>.
    /// </summary>
    type EcsTaskSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcsTaskSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EcsTaskSetState<Missing, Missing, Missing>)

        member _.Zero(()) : EcsTaskSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EcsTaskSetState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#cluster-1">EcsTaskSet#cluster</a>.
        /// </summary>
        [<CustomOperation "cluster">]
        member _.Cluster(state: EcsTaskSetState<Missing, 'Service, 'TaskDefinition>, value: string) : EcsTaskSetState<Present, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.Cluster <- value)
            ({ assignments = state.assignments } : EcsTaskSetState<Present, 'Service, 'TaskDefinition>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#service-1">EcsTaskSet#service</a>.
        /// </summary>
        [<CustomOperation "service">]
        member _.Service(state: EcsTaskSetState<'Cluster, Missing, 'TaskDefinition>, value: string) : EcsTaskSetState<'Cluster, Present, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.Service <- value)
            ({ assignments = state.assignments } : EcsTaskSetState<'Cluster, Present, 'TaskDefinition>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#task_definition-1">EcsTaskSet#task_definition</a>.
        /// </summary>
        [<CustomOperation "task_definition">]
        member _.TaskDefinition(state: EcsTaskSetState<'Cluster, 'Service, Missing>, value: string) : EcsTaskSetState<'Cluster, 'Service, Present> =
            state.assignments.Add(fun config -> config.TaskDefinition <- value)
            ({ assignments = state.assignments } : EcsTaskSetState<'Cluster, 'Service, Present>)

        /// <summary>
        /// capacity_provider_strategy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#capacity_provider_strategy-1">EcsTaskSet#capacity_provider_strategy</a> Accepts: aws.IResolvable | aws.EcsTaskSet.EcsTaskSetCapacityProviderStrategy[]
        /// </summary>
        [<CustomOperation "capacity_provider_strategy">]
        member _.CapacityProviderStrategy(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: HashiCorp.Cdktf.IResolvable) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.CapacityProviderStrategy <- value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#external_id-1">EcsTaskSet#external_id</a>.
        /// </summary>
        [<CustomOperation "external_id">]
        member _.ExternalId(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: string) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.ExternalId <- value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#force_delete-1">EcsTaskSet#force_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete">]
        member _.ForceDelete(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: bool) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.ForceDelete <- value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#force_delete-1">EcsTaskSet#force_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete">]
        member _.ForceDelete(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: HashiCorp.Cdktf.IResolvable) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.ForceDelete <- value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#id-1">EcsTaskSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: string) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#launch_type-1">EcsTaskSet#launch_type</a>.
        /// </summary>
        [<CustomOperation "launch_type">]
        member _.LaunchType(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: string) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.LaunchType <- value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// load_balancer block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#load_balancer-1">EcsTaskSet#load_balancer</a> Accepts: aws.IResolvable | aws.EcsTaskSet.EcsTaskSetLoadBalancer[]
        /// </summary>
        [<CustomOperation "load_balancer">]
        member _.LoadBalancer(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: HashiCorp.Cdktf.IResolvable) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.LoadBalancer <- value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// network_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#network_configuration-1">EcsTaskSet#network_configuration</a>
        /// </summary>
        [<CustomOperation "network_configuration">]
        member _.NetworkConfiguration(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: aws.EcsTaskSet.EcsTaskSetNetworkConfiguration) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.NetworkConfiguration <- value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#platform_version-1">EcsTaskSet#platform_version</a>.
        /// </summary>
        [<CustomOperation "platform_version">]
        member _.PlatformVersion(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: string) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.PlatformVersion <- value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// scale block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#scale-1">EcsTaskSet#scale</a>
        /// </summary>
        [<CustomOperation "scale">]
        member _.Scale(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: aws.EcsTaskSet.EcsTaskSetScale) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.Scale <- value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// service_registries block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#service_registries-1">EcsTaskSet#service_registries</a>
        /// </summary>
        [<CustomOperation "service_registries">]
        member _.ServiceRegistries(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: aws.EcsTaskSet.EcsTaskSetServiceRegistries) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.ServiceRegistries <- value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#tags-1">EcsTaskSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: seq<string * string>) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#tags_all-1">EcsTaskSet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: seq<string * string>) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#wait_until_stable-1">EcsTaskSet#wait_until_stable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_until_stable">]
        member _.WaitUntilStable(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: bool) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.WaitUntilStable <- value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#wait_until_stable-1">EcsTaskSet#wait_until_stable</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "wait_until_stable">]
        member _.WaitUntilStable(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: HashiCorp.Cdktf.IResolvable) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.WaitUntilStable <- value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_set#wait_until_stable_timeout-1">EcsTaskSet#wait_until_stable_timeout</a>.
        /// </summary>
        [<CustomOperation "wait_until_stable_timeout">]
        member _.WaitUntilStableTimeout(state: EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>, value: string) : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.WaitUntilStableTimeout <- value)
            state : EcsTaskSetState<'Cluster, 'Service, 'TaskDefinition>

        member _.Run(state: EcsTaskSetState<Present, Present, Present>) : aws.EcsTaskSet.EcsTaskSet =
            let config = aws.EcsTaskSet.EcsTaskSetConfig()
            for setter in state.assignments do
                setter config
            aws.EcsTaskSet.EcsTaskSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecsTaskSet: missing required arguments. Must call: cluster, service, task_definition.", 9999, IsError = true)>]
        member _.Run(_: EcsTaskSetState<_, _, _>) : aws.EcsTaskSet.EcsTaskSet =
            Unchecked.defaultof<aws.EcsTaskSet.EcsTaskSet>
