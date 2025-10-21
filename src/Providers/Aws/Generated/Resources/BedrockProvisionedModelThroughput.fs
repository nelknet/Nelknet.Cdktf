namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BedrockProvisionedModelThroughputState<'ModelArn, 'ModelUnits, 'ProvisionedModelName> = { assignments: ResizeArray<aws.BedrockProvisionedModelThroughput.BedrockProvisionedModelThroughputConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_provisioned_model_throughput">aws_bedrock_provisioned_model_throughput</a>.
    /// </summary>
    type BedrockProvisionedModelThroughputBuilder(logicalId: string) =
        member _.Yield(_: unit) : BedrockProvisionedModelThroughputState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockProvisionedModelThroughputState<Missing, Missing, Missing>)

        member _.Zero(()) : BedrockProvisionedModelThroughputState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : BedrockProvisionedModelThroughputState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_provisioned_model_throughput#model_arn-1">BedrockProvisionedModelThroughput#model_arn</a>.
        /// </summary>
        [<CustomOperation "model_arn">]
        member _.ModelArn(state: BedrockProvisionedModelThroughputState<Missing, 'ModelUnits, 'ProvisionedModelName>, value: string) : BedrockProvisionedModelThroughputState<Present, 'ModelUnits, 'ProvisionedModelName> =
            state.assignments.Add(fun config -> config.ModelArn <- value)
            ({ assignments = state.assignments } : BedrockProvisionedModelThroughputState<Present, 'ModelUnits, 'ProvisionedModelName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_provisioned_model_throughput#model_units-1">BedrockProvisionedModelThroughput#model_units</a>.
        /// </summary>
        [<CustomOperation "model_units">]
        member _.ModelUnits(state: BedrockProvisionedModelThroughputState<'ModelArn, Missing, 'ProvisionedModelName>, value: double) : BedrockProvisionedModelThroughputState<'ModelArn, Present, 'ProvisionedModelName> =
            state.assignments.Add(fun config -> config.ModelUnits <- value)
            ({ assignments = state.assignments } : BedrockProvisionedModelThroughputState<'ModelArn, Present, 'ProvisionedModelName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_provisioned_model_throughput#provisioned_model_name-1">BedrockProvisionedModelThroughput#provisioned_model_name</a>.
        /// </summary>
        [<CustomOperation "provisioned_model_name">]
        member _.ProvisionedModelName(state: BedrockProvisionedModelThroughputState<'ModelArn, 'ModelUnits, Missing>, value: string) : BedrockProvisionedModelThroughputState<'ModelArn, 'ModelUnits, Present> =
            state.assignments.Add(fun config -> config.ProvisionedModelName <- value)
            ({ assignments = state.assignments } : BedrockProvisionedModelThroughputState<'ModelArn, 'ModelUnits, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_provisioned_model_throughput#commitment_duration-1">BedrockProvisionedModelThroughput#commitment_duration</a>.
        /// </summary>
        [<CustomOperation "commitment_duration">]
        member _.CommitmentDuration(state: BedrockProvisionedModelThroughputState<'ModelArn, 'ModelUnits, 'ProvisionedModelName>, value: string) : BedrockProvisionedModelThroughputState<'ModelArn, 'ModelUnits, 'ProvisionedModelName> =
            state.assignments.Add(fun config -> config.CommitmentDuration <- value)
            state : BedrockProvisionedModelThroughputState<'ModelArn, 'ModelUnits, 'ProvisionedModelName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_provisioned_model_throughput#tags-1">BedrockProvisionedModelThroughput#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: BedrockProvisionedModelThroughputState<'ModelArn, 'ModelUnits, 'ProvisionedModelName>, value: seq<string * string>) : BedrockProvisionedModelThroughputState<'ModelArn, 'ModelUnits, 'ProvisionedModelName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : BedrockProvisionedModelThroughputState<'ModelArn, 'ModelUnits, 'ProvisionedModelName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_provisioned_model_throughput#timeouts-1">BedrockProvisionedModelThroughput#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: BedrockProvisionedModelThroughputState<'ModelArn, 'ModelUnits, 'ProvisionedModelName>, value: aws.BedrockProvisionedModelThroughput.BedrockProvisionedModelThroughputTimeouts) : BedrockProvisionedModelThroughputState<'ModelArn, 'ModelUnits, 'ProvisionedModelName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : BedrockProvisionedModelThroughputState<'ModelArn, 'ModelUnits, 'ProvisionedModelName>

        member _.Run(state: BedrockProvisionedModelThroughputState<Present, Present, Present>) : aws.BedrockProvisionedModelThroughput.BedrockProvisionedModelThroughput =
            let config = aws.BedrockProvisionedModelThroughput.BedrockProvisionedModelThroughputConfig()
            for setter in state.assignments do
                setter config
            aws.BedrockProvisionedModelThroughput.BedrockProvisionedModelThroughput(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.bedrockProvisionedModelThroughput: missing required arguments. Must call: model_arn, model_units, provisioned_model_name.", 9999, IsError = true)>]
        member _.Run(_: BedrockProvisionedModelThroughputState<_, _, _>) : aws.BedrockProvisionedModelThroughput.BedrockProvisionedModelThroughput =
            Unchecked.defaultof<aws.BedrockProvisionedModelThroughput.BedrockProvisionedModelThroughput>
