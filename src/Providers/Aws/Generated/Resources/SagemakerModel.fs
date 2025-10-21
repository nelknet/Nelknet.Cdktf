namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerModelState<'ExecutionRoleArn> = { assignments: ResizeArray<aws.SagemakerModel.SagemakerModelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model">aws_sagemaker_model</a>.
    /// </summary>
    type SagemakerModelBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerModelState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerModelState<Missing>)

        member _.Zero(()) : SagemakerModelState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerModelState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#execution_role_arn-1">SagemakerModel#execution_role_arn</a>.
        /// </summary>
        [<CustomOperation "execution_role_arn">]
        member _.ExecutionRoleArn(state: SagemakerModelState<Missing>, value: string) : SagemakerModelState<Present> =
            state.assignments.Add(fun config -> config.ExecutionRoleArn <- value)
            ({ assignments = state.assignments } : SagemakerModelState<Present>)

        /// <summary>
        /// container block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#container-1">SagemakerModel#container</a> Accepts: aws.IResolvable | aws.SagemakerModel.SagemakerModelContainer[]
        /// </summary>
        [<CustomOperation "container">]
        member _.Container(state: SagemakerModelState<'ExecutionRoleArn>, value: HashiCorp.Cdktf.IResolvable) : SagemakerModelState<'ExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Container <- value)
            state : SagemakerModelState<'ExecutionRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#enable_network_isolation-1">SagemakerModel#enable_network_isolation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_network_isolation">]
        member _.EnableNetworkIsolation(state: SagemakerModelState<'ExecutionRoleArn>, value: bool) : SagemakerModelState<'ExecutionRoleArn> =
            state.assignments.Add(fun config -> config.EnableNetworkIsolation <- value)
            state : SagemakerModelState<'ExecutionRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#enable_network_isolation-1">SagemakerModel#enable_network_isolation</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enable_network_isolation">]
        member _.EnableNetworkIsolation(state: SagemakerModelState<'ExecutionRoleArn>, value: HashiCorp.Cdktf.IResolvable) : SagemakerModelState<'ExecutionRoleArn> =
            state.assignments.Add(fun config -> config.EnableNetworkIsolation <- value)
            state : SagemakerModelState<'ExecutionRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#id-1">SagemakerModel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerModelState<'ExecutionRoleArn>, value: string) : SagemakerModelState<'ExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerModelState<'ExecutionRoleArn>

        /// <summary>
        /// inference_execution_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#inference_execution_config-1">SagemakerModel#inference_execution_config</a>
        /// </summary>
        [<CustomOperation "inference_execution_config">]
        member _.InferenceExecutionConfig(state: SagemakerModelState<'ExecutionRoleArn>, value: aws.SagemakerModel.SagemakerModelInferenceExecutionConfig) : SagemakerModelState<'ExecutionRoleArn> =
            state.assignments.Add(fun config -> config.InferenceExecutionConfig <- value)
            state : SagemakerModelState<'ExecutionRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#name-1">SagemakerModel#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SagemakerModelState<'ExecutionRoleArn>, value: string) : SagemakerModelState<'ExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SagemakerModelState<'ExecutionRoleArn>

        /// <summary>
        /// primary_container block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#primary_container-1">SagemakerModel#primary_container</a>
        /// </summary>
        [<CustomOperation "primary_container">]
        member _.PrimaryContainer(state: SagemakerModelState<'ExecutionRoleArn>, value: aws.SagemakerModel.SagemakerModelPrimaryContainer) : SagemakerModelState<'ExecutionRoleArn> =
            state.assignments.Add(fun config -> config.PrimaryContainer <- value)
            state : SagemakerModelState<'ExecutionRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#tags-1">SagemakerModel#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerModelState<'ExecutionRoleArn>, value: seq<string * string>) : SagemakerModelState<'ExecutionRoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerModelState<'ExecutionRoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#tags_all-1">SagemakerModel#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerModelState<'ExecutionRoleArn>, value: seq<string * string>) : SagemakerModelState<'ExecutionRoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerModelState<'ExecutionRoleArn>

        /// <summary>
        /// vpc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_model#vpc_config-1">SagemakerModel#vpc_config</a>
        /// </summary>
        [<CustomOperation "vpc_config">]
        member _.VpcConfig(state: SagemakerModelState<'ExecutionRoleArn>, value: aws.SagemakerModel.SagemakerModelVpcConfig) : SagemakerModelState<'ExecutionRoleArn> =
            state.assignments.Add(fun config -> config.VpcConfig <- value)
            state : SagemakerModelState<'ExecutionRoleArn>

        member _.Run(state: SagemakerModelState<Present>) : aws.SagemakerModel.SagemakerModel =
            let config = aws.SagemakerModel.SagemakerModelConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerModel.SagemakerModel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerModel: missing required arguments. Must call: execution_role_arn.", 9999, IsError = true)>]
        member _.Run(_: SagemakerModelState<_>) : aws.SagemakerModel.SagemakerModel =
            Unchecked.defaultof<aws.SagemakerModel.SagemakerModel>
