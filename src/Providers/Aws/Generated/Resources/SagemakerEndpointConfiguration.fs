namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerEndpointConfigurationState<'ProductionVariants> = { assignments: ResizeArray<aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration">aws_sagemaker_endpoint_configuration</a>.
    /// </summary>
    type SagemakerEndpointConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerEndpointConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerEndpointConfigurationState<Missing>)

        member _.Zero(()) : SagemakerEndpointConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerEndpointConfigurationState<Missing>)

        /// <summary>
        /// production_variants block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#production_variants-1">SagemakerEndpointConfiguration#production_variants</a> Accepts: aws.IResolvable | aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationProductionVariants[]
        /// </summary>
        [<CustomOperation "production_variants">]
        member _.ProductionVariants(state: SagemakerEndpointConfigurationState<Missing>, value: HashiCorp.Cdktf.IResolvable) : SagemakerEndpointConfigurationState<Present> =
            state.assignments.Add(fun config -> config.ProductionVariants <- value)
            ({ assignments = state.assignments } : SagemakerEndpointConfigurationState<Present>)

        /// <summary>
        /// async_inference_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#async_inference_config-1">SagemakerEndpointConfiguration#async_inference_config</a>
        /// </summary>
        [<CustomOperation "async_inference_config">]
        member _.AsyncInferenceConfig(state: SagemakerEndpointConfigurationState<'ProductionVariants>, value: aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationAsyncInferenceConfig) : SagemakerEndpointConfigurationState<'ProductionVariants> =
            state.assignments.Add(fun config -> config.AsyncInferenceConfig <- value)
            state : SagemakerEndpointConfigurationState<'ProductionVariants>

        /// <summary>
        /// data_capture_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#data_capture_config-1">SagemakerEndpointConfiguration#data_capture_config</a>
        /// </summary>
        [<CustomOperation "data_capture_config">]
        member _.DataCaptureConfig(state: SagemakerEndpointConfigurationState<'ProductionVariants>, value: aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationDataCaptureConfig) : SagemakerEndpointConfigurationState<'ProductionVariants> =
            state.assignments.Add(fun config -> config.DataCaptureConfig <- value)
            state : SagemakerEndpointConfigurationState<'ProductionVariants>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#id-1">SagemakerEndpointConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerEndpointConfigurationState<'ProductionVariants>, value: string) : SagemakerEndpointConfigurationState<'ProductionVariants> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerEndpointConfigurationState<'ProductionVariants>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#kms_key_arn-1">SagemakerEndpointConfiguration#kms_key_arn</a>.
        /// </summary>
        [<CustomOperation "kms_key_arn">]
        member _.KmsKeyArn(state: SagemakerEndpointConfigurationState<'ProductionVariants>, value: string) : SagemakerEndpointConfigurationState<'ProductionVariants> =
            state.assignments.Add(fun config -> config.KmsKeyArn <- value)
            state : SagemakerEndpointConfigurationState<'ProductionVariants>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#name-1">SagemakerEndpointConfiguration#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SagemakerEndpointConfigurationState<'ProductionVariants>, value: string) : SagemakerEndpointConfigurationState<'ProductionVariants> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SagemakerEndpointConfigurationState<'ProductionVariants>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#name_prefix-1">SagemakerEndpointConfiguration#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: SagemakerEndpointConfigurationState<'ProductionVariants>, value: string) : SagemakerEndpointConfigurationState<'ProductionVariants> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : SagemakerEndpointConfigurationState<'ProductionVariants>

        /// <summary>
        /// shadow_production_variants block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#shadow_production_variants-1">SagemakerEndpointConfiguration#shadow_production_variants</a> Accepts: aws.IResolvable | aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationShadowProductionVariants[]
        /// </summary>
        [<CustomOperation "shadow_production_variants">]
        member _.ShadowProductionVariants(state: SagemakerEndpointConfigurationState<'ProductionVariants>, value: HashiCorp.Cdktf.IResolvable) : SagemakerEndpointConfigurationState<'ProductionVariants> =
            state.assignments.Add(fun config -> config.ShadowProductionVariants <- value)
            state : SagemakerEndpointConfigurationState<'ProductionVariants>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#tags-1">SagemakerEndpointConfiguration#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerEndpointConfigurationState<'ProductionVariants>, value: seq<string * string>) : SagemakerEndpointConfigurationState<'ProductionVariants> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerEndpointConfigurationState<'ProductionVariants>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_endpoint_configuration#tags_all-1">SagemakerEndpointConfiguration#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerEndpointConfigurationState<'ProductionVariants>, value: seq<string * string>) : SagemakerEndpointConfigurationState<'ProductionVariants> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerEndpointConfigurationState<'ProductionVariants>

        member _.Run(state: SagemakerEndpointConfigurationState<Present>) : aws.SagemakerEndpointConfiguration.SagemakerEndpointConfiguration =
            let config = aws.SagemakerEndpointConfiguration.SagemakerEndpointConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerEndpointConfiguration.SagemakerEndpointConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerEndpointConfiguration: missing required arguments. Must call: production_variants.", 9999, IsError = true)>]
        member _.Run(_: SagemakerEndpointConfigurationState<_>) : aws.SagemakerEndpointConfiguration.SagemakerEndpointConfiguration =
            Unchecked.defaultof<aws.SagemakerEndpointConfiguration.SagemakerEndpointConfiguration>
