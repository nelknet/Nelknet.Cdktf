namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path> = { assignments: ResizeArray<aws.KendraQuerySuggestionsBlockList.KendraQuerySuggestionsBlockListConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list">aws_kendra_query_suggestions_block_list</a>.
    /// </summary>
    type KendraQuerySuggestionsBlockListBuilder(logicalId: string) =
        member _.Yield(_: unit) : KendraQuerySuggestionsBlockListState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KendraQuerySuggestionsBlockListState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KendraQuerySuggestionsBlockListState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KendraQuerySuggestionsBlockListState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#index_id-1">KendraQuerySuggestionsBlockList#index_id</a>.
        /// </summary>
        [<CustomOperation "index_id">]
        member _.IndexId(state: KendraQuerySuggestionsBlockListState<Missing, 'Name, 'RoleArn, 'SourceS3Path>, value: string) : KendraQuerySuggestionsBlockListState<Present, 'Name, 'RoleArn, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.IndexId <- value)
            ({ assignments = state.assignments } : KendraQuerySuggestionsBlockListState<Present, 'Name, 'RoleArn, 'SourceS3Path>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#name-1">KendraQuerySuggestionsBlockList#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KendraQuerySuggestionsBlockListState<'IndexId, Missing, 'RoleArn, 'SourceS3Path>, value: string) : KendraQuerySuggestionsBlockListState<'IndexId, Present, 'RoleArn, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KendraQuerySuggestionsBlockListState<'IndexId, Present, 'RoleArn, 'SourceS3Path>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#role_arn-1">KendraQuerySuggestionsBlockList#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: KendraQuerySuggestionsBlockListState<'IndexId, 'Name, Missing, 'SourceS3Path>, value: string) : KendraQuerySuggestionsBlockListState<'IndexId, 'Name, Present, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : KendraQuerySuggestionsBlockListState<'IndexId, 'Name, Present, 'SourceS3Path>)

        /// <summary>
        /// source_s3_path block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#source_s3_path-1">KendraQuerySuggestionsBlockList#source_s3_path</a>
        /// </summary>
        [<CustomOperation "source_s3_path">]
        member _.SourceS3Path(state: KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, Missing>, value: aws.KendraQuerySuggestionsBlockList.KendraQuerySuggestionsBlockListSourceS3Path) : KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, Present> =
            state.assignments.Add(fun config -> config.SourceS3Path <- value)
            ({ assignments = state.assignments } : KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#description-1">KendraQuerySuggestionsBlockList#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>, value: string) : KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#id-1">KendraQuerySuggestionsBlockList#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>, value: string) : KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#tags-1">KendraQuerySuggestionsBlockList#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>, value: seq<string * string>) : KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#tags_all-1">KendraQuerySuggestionsBlockList#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>, value: seq<string * string>) : KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_query_suggestions_block_list#timeouts-1">KendraQuerySuggestionsBlockList#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>, value: aws.KendraQuerySuggestionsBlockList.KendraQuerySuggestionsBlockListTimeouts) : KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KendraQuerySuggestionsBlockListState<'IndexId, 'Name, 'RoleArn, 'SourceS3Path>

        member _.Run(state: KendraQuerySuggestionsBlockListState<Present, Present, Present, Present>) : aws.KendraQuerySuggestionsBlockList.KendraQuerySuggestionsBlockList =
            let config = aws.KendraQuerySuggestionsBlockList.KendraQuerySuggestionsBlockListConfig()
            for setter in state.assignments do
                setter config
            aws.KendraQuerySuggestionsBlockList.KendraQuerySuggestionsBlockList(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kendraQuerySuggestionsBlockList: missing required arguments. Must call: index_id, name, role_arn, source_s3_path.", 9999, IsError = true)>]
        member _.Run(_: KendraQuerySuggestionsBlockListState<_, _, _, _>) : aws.KendraQuerySuggestionsBlockList.KendraQuerySuggestionsBlockList =
            Unchecked.defaultof<aws.KendraQuerySuggestionsBlockList.KendraQuerySuggestionsBlockList>
