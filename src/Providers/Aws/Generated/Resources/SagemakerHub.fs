namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SagemakerHubState<'HubDescription, 'HubName> = { assignments: ResizeArray<aws.SagemakerHub.SagemakerHubConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_hub">aws_sagemaker_hub</a>.
    /// </summary>
    type SagemakerHubBuilder(logicalId: string) =
        member _.Yield(_: unit) : SagemakerHubState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerHubState<Missing, Missing>)

        member _.Zero(()) : SagemakerHubState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SagemakerHubState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_hub#hub_description-1">SagemakerHub#hub_description</a>.
        /// </summary>
        [<CustomOperation "hub_description">]
        member _.HubDescription(state: SagemakerHubState<Missing, 'HubName>, value: string) : SagemakerHubState<Present, 'HubName> =
            state.assignments.Add(fun config -> config.HubDescription <- value)
            ({ assignments = state.assignments } : SagemakerHubState<Present, 'HubName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_hub#hub_name-1">SagemakerHub#hub_name</a>.
        /// </summary>
        [<CustomOperation "hub_name">]
        member _.HubName(state: SagemakerHubState<'HubDescription, Missing>, value: string) : SagemakerHubState<'HubDescription, Present> =
            state.assignments.Add(fun config -> config.HubName <- value)
            ({ assignments = state.assignments } : SagemakerHubState<'HubDescription, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_hub#hub_display_name-1">SagemakerHub#hub_display_name</a>.
        /// </summary>
        [<CustomOperation "hub_display_name">]
        member _.HubDisplayName(state: SagemakerHubState<'HubDescription, 'HubName>, value: string) : SagemakerHubState<'HubDescription, 'HubName> =
            state.assignments.Add(fun config -> config.HubDisplayName <- value)
            state : SagemakerHubState<'HubDescription, 'HubName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_hub#hub_search_keywords-1">SagemakerHub#hub_search_keywords</a>.
        /// </summary>
        [<CustomOperation "hub_search_keywords">]
        member _.HubSearchKeywords(state: SagemakerHubState<'HubDescription, 'HubName>, value: seq<string>) : SagemakerHubState<'HubDescription, 'HubName> =
            state.assignments.Add(fun config -> config.HubSearchKeywords <- (value |> Seq.toArray))
            state : SagemakerHubState<'HubDescription, 'HubName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_hub#id-1">SagemakerHub#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SagemakerHubState<'HubDescription, 'HubName>, value: string) : SagemakerHubState<'HubDescription, 'HubName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SagemakerHubState<'HubDescription, 'HubName>

        /// <summary>
        /// s3_storage_config block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_hub#s3_storage_config-1">SagemakerHub#s3_storage_config</a>
        /// </summary>
        [<CustomOperation "s3_storage_config">]
        member _.S3StorageConfig(state: SagemakerHubState<'HubDescription, 'HubName>, value: aws.SagemakerHub.SagemakerHubS3StorageConfig) : SagemakerHubState<'HubDescription, 'HubName> =
            state.assignments.Add(fun config -> config.S3StorageConfig <- value)
            state : SagemakerHubState<'HubDescription, 'HubName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_hub#tags-1">SagemakerHub#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SagemakerHubState<'HubDescription, 'HubName>, value: seq<string * string>) : SagemakerHubState<'HubDescription, 'HubName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SagemakerHubState<'HubDescription, 'HubName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sagemaker_hub#tags_all-1">SagemakerHub#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SagemakerHubState<'HubDescription, 'HubName>, value: seq<string * string>) : SagemakerHubState<'HubDescription, 'HubName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SagemakerHubState<'HubDescription, 'HubName>

        member _.Run(state: SagemakerHubState<Present, Present>) : aws.SagemakerHub.SagemakerHub =
            let config = aws.SagemakerHub.SagemakerHubConfig()
            for setter in state.assignments do
                setter config
            aws.SagemakerHub.SagemakerHub(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sagemakerHub: missing required arguments. Must call: hub_description, hub_name.", 9999, IsError = true)>]
        member _.Run(_: SagemakerHubState<_, _>) : aws.SagemakerHub.SagemakerHub =
            Unchecked.defaultof<aws.SagemakerHub.SagemakerHub>
