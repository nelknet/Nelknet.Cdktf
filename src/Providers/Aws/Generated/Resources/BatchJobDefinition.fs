namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BatchJobDefinitionState<'Name, 'Type> = { assignments: ResizeArray<aws.BatchJobDefinition.BatchJobDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition">aws_batch_job_definition</a>.
    /// </summary>
    type BatchJobDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : BatchJobDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BatchJobDefinitionState<Missing, Missing>)

        member _.Zero(()) : BatchJobDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : BatchJobDefinitionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#name-1">BatchJobDefinition#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: BatchJobDefinitionState<Missing, 'Type>, value: string) : BatchJobDefinitionState<Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : BatchJobDefinitionState<Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#type-1">BatchJobDefinition#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: BatchJobDefinitionState<'Name, Missing>, value: string) : BatchJobDefinitionState<'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : BatchJobDefinitionState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#container_properties-1">BatchJobDefinition#container_properties</a>.
        /// </summary>
        [<CustomOperation "container_properties">]
        member _.ContainerProperties(state: BatchJobDefinitionState<'Name, 'Type>, value: string) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.ContainerProperties <- value)
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#deregister_on_new_revision-1">BatchJobDefinition#deregister_on_new_revision</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deregister_on_new_revision">]
        member _.DeregisterOnNewRevision(state: BatchJobDefinitionState<'Name, 'Type>, value: bool) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.DeregisterOnNewRevision <- value)
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#deregister_on_new_revision-1">BatchJobDefinition#deregister_on_new_revision</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deregister_on_new_revision">]
        member _.DeregisterOnNewRevision(state: BatchJobDefinitionState<'Name, 'Type>, value: HashiCorp.Cdktf.IResolvable) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.DeregisterOnNewRevision <- value)
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#ecs_properties-1">BatchJobDefinition#ecs_properties</a>.
        /// </summary>
        [<CustomOperation "ecs_properties">]
        member _.EcsProperties(state: BatchJobDefinitionState<'Name, 'Type>, value: string) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.EcsProperties <- value)
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// eks_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#eks_properties-1">BatchJobDefinition#eks_properties</a>
        /// </summary>
        [<CustomOperation "eks_properties">]
        member _.EksProperties(state: BatchJobDefinitionState<'Name, 'Type>, value: aws.BatchJobDefinition.BatchJobDefinitionEksProperties) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.EksProperties <- value)
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#id-1">BatchJobDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BatchJobDefinitionState<'Name, 'Type>, value: string) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#node_properties-1">BatchJobDefinition#node_properties</a>.
        /// </summary>
        [<CustomOperation "node_properties">]
        member _.NodeProperties(state: BatchJobDefinitionState<'Name, 'Type>, value: string) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.NodeProperties <- value)
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#parameters-1">BatchJobDefinition#parameters</a>.
        /// </summary>
        [<CustomOperation "parameters">]
        member _.Parameters(state: BatchJobDefinitionState<'Name, 'Type>, value: seq<string * string>) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Parameters <- dict value)
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#platform_capabilities-1">BatchJobDefinition#platform_capabilities</a>.
        /// </summary>
        [<CustomOperation "platform_capabilities">]
        member _.PlatformCapabilities(state: BatchJobDefinitionState<'Name, 'Type>, value: seq<string>) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.PlatformCapabilities <- (value |> Seq.toArray))
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#propagate_tags-1">BatchJobDefinition#propagate_tags</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "propagate_tags">]
        member _.PropagateTags(state: BatchJobDefinitionState<'Name, 'Type>, value: bool) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.PropagateTags <- value)
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#propagate_tags-1">BatchJobDefinition#propagate_tags</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "propagate_tags">]
        member _.PropagateTags(state: BatchJobDefinitionState<'Name, 'Type>, value: HashiCorp.Cdktf.IResolvable) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.PropagateTags <- value)
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// retry_strategy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#retry_strategy-1">BatchJobDefinition#retry_strategy</a>
        /// </summary>
        [<CustomOperation "retry_strategy">]
        member _.RetryStrategy(state: BatchJobDefinitionState<'Name, 'Type>, value: aws.BatchJobDefinition.BatchJobDefinitionRetryStrategy) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.RetryStrategy <- value)
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#scheduling_priority-1">BatchJobDefinition#scheduling_priority</a>.
        /// </summary>
        [<CustomOperation "scheduling_priority">]
        member _.SchedulingPriority(state: BatchJobDefinitionState<'Name, 'Type>, value: double) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.SchedulingPriority <- value)
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#tags-1">BatchJobDefinition#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BatchJobDefinitionState<'Name, 'Type>, value: seq<string * string>) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#tags_all-1">BatchJobDefinition#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: BatchJobDefinitionState<'Name, 'Type>, value: seq<string * string>) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : BatchJobDefinitionState<'Name, 'Type>

        /// <summary>
        /// timeout block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_job_definition#timeout-1">BatchJobDefinition#timeout</a>
        /// </summary>
        [<CustomOperation "timeout">]
        member _.Timeout(state: BatchJobDefinitionState<'Name, 'Type>, value: aws.BatchJobDefinition.BatchJobDefinitionTimeout) : BatchJobDefinitionState<'Name, 'Type> =
            state.assignments.Add(fun config -> config.Timeout <- value)
            state : BatchJobDefinitionState<'Name, 'Type>

        member _.Run(state: BatchJobDefinitionState<Present, Present>) : aws.BatchJobDefinition.BatchJobDefinition =
            let config = aws.BatchJobDefinition.BatchJobDefinitionConfig()
            for setter in state.assignments do
                setter config
            aws.BatchJobDefinition.BatchJobDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.batchJobDefinition: missing required arguments. Must call: name, type.", 9999, IsError = true)>]
        member _.Run(_: BatchJobDefinitionState<_, _>) : aws.BatchJobDefinition.BatchJobDefinition =
            Unchecked.defaultof<aws.BatchJobDefinition.BatchJobDefinition>
