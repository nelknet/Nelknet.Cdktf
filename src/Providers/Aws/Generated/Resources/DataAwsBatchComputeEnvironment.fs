namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsBatchComputeEnvironmentState<'ComputeEnvironmentName> = { assignments: ResizeArray<aws.DataAwsBatchComputeEnvironment.DataAwsBatchComputeEnvironmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_compute_environment">aws_batch_compute_environment</a>.
    /// </summary>
    type DataAwsBatchComputeEnvironmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsBatchComputeEnvironmentState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBatchComputeEnvironmentState<Missing>)

        member _.Zero(()) : DataAwsBatchComputeEnvironmentState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsBatchComputeEnvironmentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_compute_environment#compute_environment_name-1">DataAwsBatchComputeEnvironment#compute_environment_name</a>.
        /// </summary>
        [<CustomOperation "compute_environment_name">]
        member _.ComputeEnvironmentName(state: DataAwsBatchComputeEnvironmentState<Missing>, value: string) : DataAwsBatchComputeEnvironmentState<Present> =
            state.assignments.Add(fun config -> config.ComputeEnvironmentName <- value)
            ({ assignments = state.assignments } : DataAwsBatchComputeEnvironmentState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_compute_environment#id-1">DataAwsBatchComputeEnvironment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsBatchComputeEnvironmentState<'ComputeEnvironmentName>, value: string) : DataAwsBatchComputeEnvironmentState<'ComputeEnvironmentName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsBatchComputeEnvironmentState<'ComputeEnvironmentName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/batch_compute_environment#tags-1">DataAwsBatchComputeEnvironment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsBatchComputeEnvironmentState<'ComputeEnvironmentName>, value: seq<string * string>) : DataAwsBatchComputeEnvironmentState<'ComputeEnvironmentName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsBatchComputeEnvironmentState<'ComputeEnvironmentName>

        member _.Run(state: DataAwsBatchComputeEnvironmentState<Present>) : aws.DataAwsBatchComputeEnvironment.DataAwsBatchComputeEnvironment =
            let config = aws.DataAwsBatchComputeEnvironment.DataAwsBatchComputeEnvironmentConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsBatchComputeEnvironment.DataAwsBatchComputeEnvironment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsBatchComputeEnvironment: missing required arguments. Must call: compute_environment_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsBatchComputeEnvironmentState<_>) : aws.DataAwsBatchComputeEnvironment.DataAwsBatchComputeEnvironment =
            Unchecked.defaultof<aws.DataAwsBatchComputeEnvironment.DataAwsBatchComputeEnvironment>
