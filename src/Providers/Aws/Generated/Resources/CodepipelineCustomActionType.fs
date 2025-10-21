namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version> = { assignments: ResizeArray<aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type">aws_codepipeline_custom_action_type</a>.
    /// </summary>
    type CodepipelineCustomActionTypeBuilder(logicalId: string) =
        member _.Yield(_: unit) : CodepipelineCustomActionTypeState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodepipelineCustomActionTypeState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CodepipelineCustomActionTypeState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CodepipelineCustomActionTypeState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#category-1">CodepipelineCustomActionType#category</a>.
        /// </summary>
        [<CustomOperation "category">]
        member _.Category(state: CodepipelineCustomActionTypeState<Missing, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version>, value: string) : CodepipelineCustomActionTypeState<Present, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version> =
            state.assignments.Add(fun config -> config.Category <- value)
            ({ assignments = state.assignments } : CodepipelineCustomActionTypeState<Present, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version>)

        /// <summary>
        /// input_artifact_details block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#input_artifact_details-1">CodepipelineCustomActionType#input_artifact_details</a>
        /// </summary>
        [<CustomOperation "input_artifact_details">]
        member _.InputArtifactDetails(state: CodepipelineCustomActionTypeState<'Category, Missing, 'OutputArtifactDetails, 'ProviderName, 'Version>, value: aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeInputArtifactDetails) : CodepipelineCustomActionTypeState<'Category, Present, 'OutputArtifactDetails, 'ProviderName, 'Version> =
            state.assignments.Add(fun config -> config.InputArtifactDetails <- value)
            ({ assignments = state.assignments } : CodepipelineCustomActionTypeState<'Category, Present, 'OutputArtifactDetails, 'ProviderName, 'Version>)

        /// <summary>
        /// output_artifact_details block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#output_artifact_details-1">CodepipelineCustomActionType#output_artifact_details</a>
        /// </summary>
        [<CustomOperation "output_artifact_details">]
        member _.OutputArtifactDetails(state: CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, Missing, 'ProviderName, 'Version>, value: aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeOutputArtifactDetails) : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, Present, 'ProviderName, 'Version> =
            state.assignments.Add(fun config -> config.OutputArtifactDetails <- value)
            ({ assignments = state.assignments } : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, Present, 'ProviderName, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#provider_name-1">CodepipelineCustomActionType#provider_name</a>.
        /// </summary>
        [<CustomOperation "provider_name">]
        member _.ProviderName(state: CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, Missing, 'Version>, value: string) : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, Present, 'Version> =
            state.assignments.Add(fun config -> config.ProviderName <- value)
            ({ assignments = state.assignments } : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, Present, 'Version>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#version-1">CodepipelineCustomActionType#version</a>.
        /// </summary>
        [<CustomOperation "version">]
        member _.Version(state: CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, Missing>, value: string) : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, Present> =
            state.assignments.Add(fun config -> config.Version <- value)
            ({ assignments = state.assignments } : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, Present>)

        /// <summary>
        /// configuration_property block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#configuration_property-1">CodepipelineCustomActionType#configuration_property</a> Accepts: aws.IResolvable | aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeConfigurationProperty[]
        /// </summary>
        [<CustomOperation "configuration_property">]
        member _.ConfigurationProperty(state: CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version>, value: HashiCorp.Cdktf.IResolvable) : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version> =
            state.assignments.Add(fun config -> config.ConfigurationProperty <- value)
            state : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#id-1">CodepipelineCustomActionType#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version>, value: string) : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version>

        /// <summary>
        /// settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#settings-1">CodepipelineCustomActionType#settings</a>
        /// </summary>
        [<CustomOperation "settings">]
        member _.Settings(state: CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version>, value: aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeSettings) : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version> =
            state.assignments.Add(fun config -> config.Settings <- value)
            state : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#tags-1">CodepipelineCustomActionType#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version>, value: seq<string * string>) : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/codepipeline_custom_action_type#tags_all-1">CodepipelineCustomActionType#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version>, value: seq<string * string>) : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : CodepipelineCustomActionTypeState<'Category, 'InputArtifactDetails, 'OutputArtifactDetails, 'ProviderName, 'Version>

        member _.Run(state: CodepipelineCustomActionTypeState<Present, Present, Present, Present, Present>) : aws.CodepipelineCustomActionType.CodepipelineCustomActionType =
            let config = aws.CodepipelineCustomActionType.CodepipelineCustomActionTypeConfig()
            for setter in state.assignments do
                setter config
            aws.CodepipelineCustomActionType.CodepipelineCustomActionType(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.codepipelineCustomActionType: missing required arguments. Must call: category, input_artifact_details, output_artifact_details, provider_name, version.", 9999, IsError = true)>]
        member _.Run(_: CodepipelineCustomActionTypeState<_, _, _, _, _>) : aws.CodepipelineCustomActionType.CodepipelineCustomActionType =
            Unchecked.defaultof<aws.CodepipelineCustomActionType.CodepipelineCustomActionType>
