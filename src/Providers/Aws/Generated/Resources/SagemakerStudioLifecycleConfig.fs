namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, 'StudioLifecycleConfigContent, 'StudioLifecycleConfigName> = { assignments: ResizeArray<aws.SagemakerStudioLifecycleConfig.SagemakerStudioLifecycleConfigConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_studio_lifecycle_config">aws_sagemaker_studio_lifecycle_config</a>.
    /// </summary>
    type SagemakerStudioLifecycleConfigBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerStudioLifecycleConfigState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerStudioLifecycleConfigState<Missing, Missing, Missing>)

        member _.Zero(()) : SagemakerStudioLifecycleConfigState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerStudioLifecycleConfigState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_studio_lifecycle_config#studio_lifecycle_config_app_type-1">SagemakerStudioLifecycleConfig#studio_lifecycle_config_app_type</a>.
        /// </summary>
        [<CustomOperation "studio_lifecycle_config_app_type">]
        member _.StudioLifecycleConfigAppType(state: SagemakerStudioLifecycleConfigState<Missing, 'StudioLifecycleConfigContent, 'StudioLifecycleConfigName>, value: string) : SagemakerStudioLifecycleConfigState<Present, 'StudioLifecycleConfigContent, 'StudioLifecycleConfigName> =
            state.assignments.Add(fun config -> config.StudioLifecycleConfigAppType <- value)
            ({ assignments = state.assignments } : SagemakerStudioLifecycleConfigState<Present, 'StudioLifecycleConfigContent, 'StudioLifecycleConfigName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_studio_lifecycle_config#studio_lifecycle_config_content-1">SagemakerStudioLifecycleConfig#studio_lifecycle_config_content</a>.
        /// </summary>
        [<CustomOperation "studio_lifecycle_config_content">]
        member _.StudioLifecycleConfigContent(state: SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, Missing, 'StudioLifecycleConfigName>, value: string) : SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, Present, 'StudioLifecycleConfigName> =
            state.assignments.Add(fun config -> config.StudioLifecycleConfigContent <- value)
            ({ assignments = state.assignments } : SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, Present, 'StudioLifecycleConfigName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_studio_lifecycle_config#studio_lifecycle_config_name-1">SagemakerStudioLifecycleConfig#studio_lifecycle_config_name</a>.
        /// </summary>
        [<CustomOperation "studio_lifecycle_config_name">]
        member _.StudioLifecycleConfigName(state: SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, 'StudioLifecycleConfigContent, Missing>, value: string) : SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, 'StudioLifecycleConfigContent, Present> =
            state.assignments.Add(fun config -> config.StudioLifecycleConfigName <- value)
            ({ assignments = state.assignments } : SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, 'StudioLifecycleConfigContent, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_studio_lifecycle_config#id-1">SagemakerStudioLifecycleConfig#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, 'StudioLifecycleConfigContent, 'StudioLifecycleConfigName>, value: string) : SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, 'StudioLifecycleConfigContent, 'StudioLifecycleConfigName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, 'StudioLifecycleConfigContent, 'StudioLifecycleConfigName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_studio_lifecycle_config#tags-1">SagemakerStudioLifecycleConfig#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, 'StudioLifecycleConfigContent, 'StudioLifecycleConfigName>, value: seq<string * string>) : SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, 'StudioLifecycleConfigContent, 'StudioLifecycleConfigName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, 'StudioLifecycleConfigContent, 'StudioLifecycleConfigName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_studio_lifecycle_config#tags_all-1">SagemakerStudioLifecycleConfig#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, 'StudioLifecycleConfigContent, 'StudioLifecycleConfigName>, value: seq<string * string>) : SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, 'StudioLifecycleConfigContent, 'StudioLifecycleConfigName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerStudioLifecycleConfigState<'StudioLifecycleConfigAppType, 'StudioLifecycleConfigContent, 'StudioLifecycleConfigName>

        member _.Run(state: SagemakerStudioLifecycleConfigState<Present, Present, Present>) : aws.SagemakerStudioLifecycleConfig.SagemakerStudioLifecycleConfig =
            let config = aws.SagemakerStudioLifecycleConfig.SagemakerStudioLifecycleConfigConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerStudioLifecycleConfig.SagemakerStudioLifecycleConfig(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerStudioLifecycleConfig: missing required arguments. Must call: studio_lifecycle_config_app_type, studio_lifecycle_config_content, studio_lifecycle_config_name.", 9999, IsError = true)>]
        member _.Run(_: SagemakerStudioLifecycleConfigState<_, _, _>) : aws.SagemakerStudioLifecycleConfig.SagemakerStudioLifecycleConfig =
            Unchecked.defaultof<aws.SagemakerStudioLifecycleConfig.SagemakerStudioLifecycleConfig>
