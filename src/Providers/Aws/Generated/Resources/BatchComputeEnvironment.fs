namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BatchComputeEnvironmentState<'Type> = { assignments: ResizeArray<aws.BatchComputeEnvironment.BatchComputeEnvironmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment">aws_batch_compute_environment</a>.
    /// </summary>
    type BatchComputeEnvironmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : BatchComputeEnvironmentState<Missing> =
            ({ assignments = ResizeArray() } : BatchComputeEnvironmentState<Missing>)

        member _.Zero(()) : BatchComputeEnvironmentState<Missing> =
            ({ assignments = ResizeArray() } : BatchComputeEnvironmentState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#type-1">BatchComputeEnvironment#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: BatchComputeEnvironmentState<Missing>, value: string) : BatchComputeEnvironmentState<Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : BatchComputeEnvironmentState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#compute_environment_name-1">BatchComputeEnvironment#compute_environment_name</a>.
        /// </summary>
        [<CustomOperation "compute_environment_name">]
        member _.ComputeEnvironmentName(state: BatchComputeEnvironmentState<'Type>, value: string) : BatchComputeEnvironmentState<'Type> =
            state.assignments.Add(fun config -> config.ComputeEnvironmentName <- value)
            state : BatchComputeEnvironmentState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#compute_environment_name_prefix-1">BatchComputeEnvironment#compute_environment_name_prefix</a>.
        /// </summary>
        [<CustomOperation "compute_environment_name_prefix">]
        member _.ComputeEnvironmentNamePrefix(state: BatchComputeEnvironmentState<'Type>, value: string) : BatchComputeEnvironmentState<'Type> =
            state.assignments.Add(fun config -> config.ComputeEnvironmentNamePrefix <- value)
            state : BatchComputeEnvironmentState<'Type>

        /// <summary>
        /// compute_resources block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#compute_resources-1">BatchComputeEnvironment#compute_resources</a>
        /// </summary>
        [<CustomOperation "compute_resources">]
        member _.ComputeResources(state: BatchComputeEnvironmentState<'Type>, value: aws.BatchComputeEnvironment.BatchComputeEnvironmentComputeResources) : BatchComputeEnvironmentState<'Type> =
            state.assignments.Add(fun config -> config.ComputeResources <- value)
            state : BatchComputeEnvironmentState<'Type>

        /// <summary>
        /// eks_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#eks_configuration-1">BatchComputeEnvironment#eks_configuration</a>
        /// </summary>
        [<CustomOperation "eks_configuration">]
        member _.EksConfiguration(state: BatchComputeEnvironmentState<'Type>, value: aws.BatchComputeEnvironment.BatchComputeEnvironmentEksConfiguration) : BatchComputeEnvironmentState<'Type> =
            state.assignments.Add(fun config -> config.EksConfiguration <- value)
            state : BatchComputeEnvironmentState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#id-1">BatchComputeEnvironment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: BatchComputeEnvironmentState<'Type>, value: string) : BatchComputeEnvironmentState<'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : BatchComputeEnvironmentState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#service_role-1">BatchComputeEnvironment#service_role</a>.
        /// </summary>
        [<CustomOperation "service_role">]
        member _.ServiceRole(state: BatchComputeEnvironmentState<'Type>, value: string) : BatchComputeEnvironmentState<'Type> =
            state.assignments.Add(fun config -> config.ServiceRole <- value)
            state : BatchComputeEnvironmentState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#state-1">BatchComputeEnvironment#state</a>.
        /// </summary>
        [<CustomOperation "state">]
        member _.State(state: BatchComputeEnvironmentState<'Type>, value: string) : BatchComputeEnvironmentState<'Type> =
            state.assignments.Add(fun config -> config.State <- value)
            state : BatchComputeEnvironmentState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#tags-1">BatchComputeEnvironment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BatchComputeEnvironmentState<'Type>, value: seq<string * string>) : BatchComputeEnvironmentState<'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BatchComputeEnvironmentState<'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#tags_all-1">BatchComputeEnvironment#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: BatchComputeEnvironmentState<'Type>, value: seq<string * string>) : BatchComputeEnvironmentState<'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : BatchComputeEnvironmentState<'Type>

        /// <summary>
        /// update_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/batch_compute_environment#update_policy-1">BatchComputeEnvironment#update_policy</a>
        /// </summary>
        [<CustomOperation "update_policy">]
        member _.UpdatePolicy(state: BatchComputeEnvironmentState<'Type>, value: aws.BatchComputeEnvironment.BatchComputeEnvironmentUpdatePolicy) : BatchComputeEnvironmentState<'Type> =
            state.assignments.Add(fun config -> config.UpdatePolicy <- value)
            state : BatchComputeEnvironmentState<'Type>

        member _.Run(state: BatchComputeEnvironmentState<Present>) : aws.BatchComputeEnvironment.BatchComputeEnvironment =
            let config = aws.BatchComputeEnvironment.BatchComputeEnvironmentConfig()
            for setter in state.assignments do
                setter config
            aws.BatchComputeEnvironment.BatchComputeEnvironment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.batchComputeEnvironment: missing required arguments. Must call: type.", 9999, IsError = true)>]
        member _.Run(_: BatchComputeEnvironmentState<_>) : aws.BatchComputeEnvironment.BatchComputeEnvironment =
            Unchecked.defaultof<aws.BatchComputeEnvironment.BatchComputeEnvironment>
