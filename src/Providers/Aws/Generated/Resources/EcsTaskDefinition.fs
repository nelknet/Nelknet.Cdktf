namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EcsTaskDefinitionState<'ContainerDefinitions, 'Family> = { assignments: ResizeArray<aws.EcsTaskDefinition.EcsTaskDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition">aws_ecs_task_definition</a>.
    /// </summary>
    type EcsTaskDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : EcsTaskDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcsTaskDefinitionState<Missing, Missing>)

        member _.Zero(()) : EcsTaskDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EcsTaskDefinitionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#container_definitions-1">EcsTaskDefinition#container_definitions</a>.
        /// </summary>
        [<CustomOperation "container_definitions">]
        member _.ContainerDefinitions(state: EcsTaskDefinitionState<Missing, 'Family>, value: string) : EcsTaskDefinitionState<Present, 'Family> =
            state.assignments.Add(fun config -> config.ContainerDefinitions <- value)
            ({ assignments = state.assignments } : EcsTaskDefinitionState<Present, 'Family>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#family-1">EcsTaskDefinition#family</a>.
        /// </summary>
        [<CustomOperation "family">]
        member _.Family(state: EcsTaskDefinitionState<'ContainerDefinitions, Missing>, value: string) : EcsTaskDefinitionState<'ContainerDefinitions, Present> =
            state.assignments.Add(fun config -> config.Family <- value)
            ({ assignments = state.assignments } : EcsTaskDefinitionState<'ContainerDefinitions, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#cpu-1">EcsTaskDefinition#cpu</a>.
        /// </summary>
        [<CustomOperation "cpu">]
        member _.Cpu(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: string) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.Cpu <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#enable_fault_injection-1">EcsTaskDefinition#enable_fault_injection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_fault_injection">]
        member _.EnableFaultInjection(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: bool) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.EnableFaultInjection <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#enable_fault_injection-1">EcsTaskDefinition#enable_fault_injection</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_fault_injection">]
        member _.EnableFaultInjection(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: HashiCorp.Cdktf.IResolvable) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.EnableFaultInjection <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// ephemeral_storage block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#ephemeral_storage-1">EcsTaskDefinition#ephemeral_storage</a>
        /// </summary>
        [<CustomOperation "ephemeral_storage">]
        member _.EphemeralStorage(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: aws.EcsTaskDefinition.EcsTaskDefinitionEphemeralStorage) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.EphemeralStorage <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#execution_role_arn-1">EcsTaskDefinition#execution_role_arn</a>.
        /// </summary>
        [<CustomOperation "execution_role_arn">]
        member _.ExecutionRoleArn(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: string) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.ExecutionRoleArn <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#id-1">EcsTaskDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: string) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// inference_accelerator block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#inference_accelerator-1">EcsTaskDefinition#inference_accelerator</a> Accepts: aws.IResolvable | aws.EcsTaskDefinition.EcsTaskDefinitionInferenceAccelerator[]
        /// </summary>
        [<CustomOperation "inference_accelerator">]
        member _.InferenceAccelerator(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: HashiCorp.Cdktf.IResolvable) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.InferenceAccelerator <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#ipc_mode-1">EcsTaskDefinition#ipc_mode</a>.
        /// </summary>
        [<CustomOperation "ipc_mode">]
        member _.IpcMode(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: string) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.IpcMode <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#memory-1">EcsTaskDefinition#memory</a>.
        /// </summary>
        [<CustomOperation "memory">]
        member _.Memory(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: string) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.Memory <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#network_mode-1">EcsTaskDefinition#network_mode</a>.
        /// </summary>
        [<CustomOperation "network_mode">]
        member _.NetworkMode(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: string) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.NetworkMode <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#pid_mode-1">EcsTaskDefinition#pid_mode</a>.
        /// </summary>
        [<CustomOperation "pid_mode">]
        member _.PidMode(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: string) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.PidMode <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// placement_constraints block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#placement_constraints-1">EcsTaskDefinition#placement_constraints</a> Accepts: aws.IResolvable | aws.EcsTaskDefinition.EcsTaskDefinitionPlacementConstraints[]
        /// </summary>
        [<CustomOperation "placement_constraints">]
        member _.PlacementConstraints(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: HashiCorp.Cdktf.IResolvable) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.PlacementConstraints <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// proxy_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#proxy_configuration-1">EcsTaskDefinition#proxy_configuration</a>
        /// </summary>
        [<CustomOperation "proxy_configuration">]
        member _.ProxyConfiguration(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: aws.EcsTaskDefinition.EcsTaskDefinitionProxyConfiguration) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.ProxyConfiguration <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#requires_compatibilities-1">EcsTaskDefinition#requires_compatibilities</a>.
        /// </summary>
        [<CustomOperation "requires_compatibilities">]
        member _.RequiresCompatibilities(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: seq<string>) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.RequiresCompatibilities <- (value |> Seq.toArray))
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// runtime_platform block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#runtime_platform-1">EcsTaskDefinition#runtime_platform</a>
        /// </summary>
        [<CustomOperation "runtime_platform">]
        member _.RuntimePlatform(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: aws.EcsTaskDefinition.EcsTaskDefinitionRuntimePlatform) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.RuntimePlatform <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#skip_destroy-1">EcsTaskDefinition#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: bool) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#skip_destroy-1">EcsTaskDefinition#skip_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "skip_destroy">]
        member _.SkipDestroy(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: HashiCorp.Cdktf.IResolvable) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.SkipDestroy <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#tags-1">EcsTaskDefinition#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: seq<string * string>) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#tags_all-1">EcsTaskDefinition#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: seq<string * string>) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#task_role_arn-1">EcsTaskDefinition#task_role_arn</a>.
        /// </summary>
        [<CustomOperation "task_role_arn">]
        member _.TaskRoleArn(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: string) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.TaskRoleArn <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#track_latest-1">EcsTaskDefinition#track_latest</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "track_latest">]
        member _.TrackLatest(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: bool) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.TrackLatest <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#track_latest-1">EcsTaskDefinition#track_latest</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "track_latest">]
        member _.TrackLatest(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: HashiCorp.Cdktf.IResolvable) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.TrackLatest <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        /// <summary>
        /// volume block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ecs_task_definition#volume-1">EcsTaskDefinition#volume</a> Accepts: aws.IResolvable | aws.EcsTaskDefinition.EcsTaskDefinitionVolume[]
        /// </summary>
        [<CustomOperation "volume">]
        member _.Volume(state: EcsTaskDefinitionState<'ContainerDefinitions, 'Family>, value: HashiCorp.Cdktf.IResolvable) : EcsTaskDefinitionState<'ContainerDefinitions, 'Family> =
            state.assignments.Add(fun config -> config.Volume <- value)
            state : EcsTaskDefinitionState<'ContainerDefinitions, 'Family>

        member _.Run(state: EcsTaskDefinitionState<Present, Present>) : aws.EcsTaskDefinition.EcsTaskDefinition =
            let config = aws.EcsTaskDefinition.EcsTaskDefinitionConfig()
            for setter in state.assignments do
                setter config
            aws.EcsTaskDefinition.EcsTaskDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ecsTaskDefinition: missing required arguments. Must call: container_definitions, family.", 9999, IsError = true)>]
        member _.Run(_: EcsTaskDefinitionState<_, _>) : aws.EcsTaskDefinition.EcsTaskDefinition =
            Unchecked.defaultof<aws.EcsTaskDefinition.EcsTaskDefinition>
