namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerAppImageConfigState<'AppImageConfigName> = { assignments: ResizeArray<aws.SagemakerAppImageConfig.SagemakerAppImageConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config">aws_sagemaker_app_image_config</a>.
    /// </summary>
    type SagemakerAppImageConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerAppImageConfigState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerAppImageConfigState<Missing>)

        member _.Zero(()) : SagemakerAppImageConfigState<Missing> =
            ({ assignments = ResizeArray() } : SagemakerAppImageConfigState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#app_image_config_name-1">SagemakerAppImageConfig#app_image_config_name</a>.
        /// </summary>
        [<CustomOperation "app_image_config_name">]
        member _.AppImageConfigName(state: SagemakerAppImageConfigState<Missing>, value: string) : SagemakerAppImageConfigState<Present> =
            state.assignments.Add(fun config -> config.AppImageConfigName <- value)
            ({ assignments = state.assignments } : SagemakerAppImageConfigState<Present>)

        /// <summary>
        /// code_editor_app_image_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#code_editor_app_image_config-1">SagemakerAppImageConfig#code_editor_app_image_config</a>
        /// </summary>
        [<CustomOperation "code_editor_app_image_config">]
        member _.CodeEditorAppImageConfig(state: SagemakerAppImageConfigState<'AppImageConfigName>, value: aws.SagemakerAppImageConfig.SagemakerAppImageConfigCodeEditorAppImageConfig) : SagemakerAppImageConfigState<'AppImageConfigName> =
            state.assignments.Add(fun config -> config.CodeEditorAppImageConfig <- value)
            state : SagemakerAppImageConfigState<'AppImageConfigName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#id-1">SagemakerAppImageConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerAppImageConfigState<'AppImageConfigName>, value: string) : SagemakerAppImageConfigState<'AppImageConfigName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerAppImageConfigState<'AppImageConfigName>

        /// <summary>
        /// jupyter_lab_image_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#jupyter_lab_image_config-1">SagemakerAppImageConfig#jupyter_lab_image_config</a>
        /// </summary>
        [<CustomOperation "jupyter_lab_image_config">]
        member _.JupyterLabImageConfig(state: SagemakerAppImageConfigState<'AppImageConfigName>, value: aws.SagemakerAppImageConfig.SagemakerAppImageConfigJupyterLabImageConfig) : SagemakerAppImageConfigState<'AppImageConfigName> =
            state.assignments.Add(fun config -> config.JupyterLabImageConfig <- value)
            state : SagemakerAppImageConfigState<'AppImageConfigName>

        /// <summary>
        /// kernel_gateway_image_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#kernel_gateway_image_config-1">SagemakerAppImageConfig#kernel_gateway_image_config</a>
        /// </summary>
        [<CustomOperation "kernel_gateway_image_config">]
        member _.KernelGatewayImageConfig(state: SagemakerAppImageConfigState<'AppImageConfigName>, value: aws.SagemakerAppImageConfig.SagemakerAppImageConfigKernelGatewayImageConfig) : SagemakerAppImageConfigState<'AppImageConfigName> =
            state.assignments.Add(fun config -> config.KernelGatewayImageConfig <- value)
            state : SagemakerAppImageConfigState<'AppImageConfigName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#tags-1">SagemakerAppImageConfig#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerAppImageConfigState<'AppImageConfigName>, value: seq<string * string>) : SagemakerAppImageConfigState<'AppImageConfigName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerAppImageConfigState<'AppImageConfigName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_app_image_config#tags_all-1">SagemakerAppImageConfig#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerAppImageConfigState<'AppImageConfigName>, value: seq<string * string>) : SagemakerAppImageConfigState<'AppImageConfigName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerAppImageConfigState<'AppImageConfigName>

        member _.Run(state: SagemakerAppImageConfigState<Present>) : aws.SagemakerAppImageConfig.SagemakerAppImageConfig =
            let config = aws.SagemakerAppImageConfig.SagemakerAppImageConfigConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerAppImageConfig.SagemakerAppImageConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerAppImageConfig: missing required arguments. Must call: app_image_config_name.", 9999, IsError = true)>]
        member _.Run(_: SagemakerAppImageConfigState<_>) : aws.SagemakerAppImageConfig.SagemakerAppImageConfig =
            Unchecked.defaultof<aws.SagemakerAppImageConfig.SagemakerAppImageConfig>
