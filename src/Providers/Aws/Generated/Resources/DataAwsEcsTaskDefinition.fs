namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsEcsTaskDefinitionState<'TaskDefinition> = { assignments: ResizeArray<aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_definition">aws_ecs_task_definition</a>.
    /// </summary>
    type DataAwsEcsTaskDefinitionBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsEcsTaskDefinitionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcsTaskDefinitionState<Missing>)

        member _.Zero(()) : DataAwsEcsTaskDefinitionState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsEcsTaskDefinitionState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_definition#task_definition-1">DataAwsEcsTaskDefinition#task_definition</a>.
        /// </summary>
        [<CustomOperation "task_definition">]
        member _.TaskDefinition(state: DataAwsEcsTaskDefinitionState<Missing>, value: string) : DataAwsEcsTaskDefinitionState<Present> =
            state.assignments.Add(fun config -> config.TaskDefinition <- value)
            ({ assignments = state.assignments } : DataAwsEcsTaskDefinitionState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ecs_task_definition#id-1">DataAwsEcsTaskDefinition#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsEcsTaskDefinitionState<'TaskDefinition>, value: string) : DataAwsEcsTaskDefinitionState<'TaskDefinition> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsEcsTaskDefinitionState<'TaskDefinition>

        member _.Run(state: DataAwsEcsTaskDefinitionState<Present>) : aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinition =
            let config = aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinitionConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinition(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsEcsTaskDefinition: missing required arguments. Must call: task_definition.", 9999, IsError = true)>]
        member _.Run(_: DataAwsEcsTaskDefinitionState<_>) : aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinition =
            Unchecked.defaultof<aws.DataAwsEcsTaskDefinition.DataAwsEcsTaskDefinition>
