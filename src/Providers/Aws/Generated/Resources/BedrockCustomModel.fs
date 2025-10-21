namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn> = { assignments: ResizeArray<aws.BedrockCustomModel.BedrockCustomModelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model">aws_bedrock_custom_model</a>.
    /// </summary>
    type BedrockCustomModelBuilder(logicalId: string) =
        member _.Yield(_: unit) : BedrockCustomModelState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockCustomModelState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : BedrockCustomModelState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockCustomModelState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#base_model_identifier-1">BedrockCustomModel#base_model_identifier</a>.
        /// </summary>
        [<CustomOperation "base_model_identifier">]
        member _.BaseModelIdentifier(state: BedrockCustomModelState<Missing, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>, value: string) : BedrockCustomModelState<Present, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn> =
            state.assignments.Add(fun config -> config.BaseModelIdentifier <- value)
            ({ assignments = state.assignments } : BedrockCustomModelState<Present, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#custom_model_name-1">BedrockCustomModel#custom_model_name</a>.
        /// </summary>
        [<CustomOperation "custom_model_name">]
        member _.CustomModelName(state: BedrockCustomModelState<'BaseModelIdentifier, Missing, 'Hyperparameters, 'JobName, 'RoleArn>, value: string) : BedrockCustomModelState<'BaseModelIdentifier, Present, 'Hyperparameters, 'JobName, 'RoleArn> =
            state.assignments.Add(fun config -> config.CustomModelName <- value)
            ({ assignments = state.assignments } : BedrockCustomModelState<'BaseModelIdentifier, Present, 'Hyperparameters, 'JobName, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#hyperparameters-1">BedrockCustomModel#hyperparameters</a>.
        /// </summary>
        [<CustomOperation "hyperparameters">]
        member _.Hyperparameters(state: BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, Missing, 'JobName, 'RoleArn>, value: seq<string * string>) : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, Present, 'JobName, 'RoleArn> =
            state.assignments.Add(fun config -> config.Hyperparameters <- dict value)
            ({ assignments = state.assignments } : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, Present, 'JobName, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#job_name-1">BedrockCustomModel#job_name</a>.
        /// </summary>
        [<CustomOperation "job_name">]
        member _.JobName(state: BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, Missing, 'RoleArn>, value: string) : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.JobName <- value)
            ({ assignments = state.assignments } : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#role_arn-1">BedrockCustomModel#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, Missing>, value: string) : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#customization_type-1">BedrockCustomModel#customization_type</a>.
        /// </summary>
        [<CustomOperation "customization_type">]
        member _.CustomizationType(state: BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>, value: string) : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn> =
            state.assignments.Add(fun config -> config.CustomizationType <- value)
            state : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#custom_model_kms_key_id-1">BedrockCustomModel#custom_model_kms_key_id</a>.
        /// </summary>
        [<CustomOperation "custom_model_kms_key_id">]
        member _.CustomModelKmsKeyId(state: BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>, value: string) : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn> =
            state.assignments.Add(fun config -> config.CustomModelKmsKeyId <- value)
            state : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>

        /// <summary>
        /// output_data_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#output_data_config-1">BedrockCustomModel#output_data_config</a> Accepts: aws.IResolvable | aws.BedrockCustomModel.BedrockCustomModelOutputDataConfig[]
        /// </summary>
        [<CustomOperation "output_data_config">]
        member _.OutputDataConfig(state: BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn> =
            state.assignments.Add(fun config -> config.OutputDataConfig <- value)
            state : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#tags-1">BedrockCustomModel#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>, value: seq<string * string>) : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#timeouts-1">BedrockCustomModel#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>, value: aws.BedrockCustomModel.BedrockCustomModelTimeouts) : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>

        /// <summary>
        /// training_data_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#training_data_config-1">BedrockCustomModel#training_data_config</a> Accepts: aws.IResolvable | aws.BedrockCustomModel.BedrockCustomModelTrainingDataConfig[]
        /// </summary>
        [<CustomOperation "training_data_config">]
        member _.TrainingDataConfig(state: BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn> =
            state.assignments.Add(fun config -> config.TrainingDataConfig <- value)
            state : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>

        /// <summary>
        /// validation_data_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#validation_data_config-1">BedrockCustomModel#validation_data_config</a> Accepts: aws.IResolvable | aws.BedrockCustomModel.BedrockCustomModelValidationDataConfig[]
        /// </summary>
        [<CustomOperation "validation_data_config">]
        member _.ValidationDataConfig(state: BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn> =
            state.assignments.Add(fun config -> config.ValidationDataConfig <- value)
            state : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>

        /// <summary>
        /// vpc_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#vpc_config-1">BedrockCustomModel#vpc_config</a> Accepts: aws.IResolvable | aws.BedrockCustomModel.BedrockCustomModelVpcConfig[]
        /// </summary>
        [<CustomOperation "vpc_config">]
        member _.VpcConfig(state: BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn> =
            state.assignments.Add(fun config -> config.VpcConfig <- value)
            state : BedrockCustomModelState<'BaseModelIdentifier, 'CustomModelName, 'Hyperparameters, 'JobName, 'RoleArn>

        member _.Run(state: BedrockCustomModelState<Present, Present, Present, Present, Present>) : aws.BedrockCustomModel.BedrockCustomModel =
            let config = aws.BedrockCustomModel.BedrockCustomModelConfig()
            for setter in state.assignments do
                setter config
            aws.BedrockCustomModel.BedrockCustomModel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.bedrockCustomModel: missing required arguments. Must call: base_model_identifier, custom_model_name, hyperparameters, job_name, role_arn.", 9999, IsError = true)>]
        member _.Run(_: BedrockCustomModelState<_, _, _, _, _>) : aws.BedrockCustomModel.BedrockCustomModel =
            Unchecked.defaultof<aws.BedrockCustomModel.BedrockCustomModel>
