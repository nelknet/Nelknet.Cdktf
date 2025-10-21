namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEcsContainerDefinitionState<'ContainerName, 'TaskDefinition> = { assignments: ResizeArray<aws.DataAwsEcsContainerDefinition.DataAwsEcsContainerDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_container_definition">aws_ecs_container_definition</a>.
    /// </summary>
    type DataAwsEcsContainerDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEcsContainerDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcsContainerDefinitionState<Missing, Missing>)

        member _.Zero(()) : DataAwsEcsContainerDefinitionState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcsContainerDefinitionState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_container_definition#container_name-1">DataAwsEcsContainerDefinition#container_name</a>.
        /// </summary>
        [<CustomOperation "container_name">]
        member _.ContainerName(state: DataAwsEcsContainerDefinitionState<Missing, 'TaskDefinition>, value: string) : DataAwsEcsContainerDefinitionState<Present, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.ContainerName <- value)
            ({ assignments = state.assignments } : DataAwsEcsContainerDefinitionState<Present, 'TaskDefinition>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_container_definition#task_definition-1">DataAwsEcsContainerDefinition#task_definition</a>.
        /// </summary>
        [<CustomOperation "task_definition">]
        member _.TaskDefinition(state: DataAwsEcsContainerDefinitionState<'ContainerName, Missing>, value: string) : DataAwsEcsContainerDefinitionState<'ContainerName, Present> =
            state.assignments.Add(fun config -> config.TaskDefinition <- value)
            ({ assignments = state.assignments } : DataAwsEcsContainerDefinitionState<'ContainerName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_container_definition#id-1">DataAwsEcsContainerDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEcsContainerDefinitionState<'ContainerName, 'TaskDefinition>, value: string) : DataAwsEcsContainerDefinitionState<'ContainerName, 'TaskDefinition> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEcsContainerDefinitionState<'ContainerName, 'TaskDefinition>

        member _.Run(state: DataAwsEcsContainerDefinitionState<Present, Present>) : aws.DataAwsEcsContainerDefinition.DataAwsEcsContainerDefinition =
            let config = aws.DataAwsEcsContainerDefinition.DataAwsEcsContainerDefinitionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEcsContainerDefinition.DataAwsEcsContainerDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEcsContainerDefinition: missing required arguments. Must call: container_name, task_definition.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEcsContainerDefinitionState<_, _>) : aws.DataAwsEcsContainerDefinition.DataAwsEcsContainerDefinition =
            Unchecked.defaultof<aws.DataAwsEcsContainerDefinition.DataAwsEcsContainerDefinition>
