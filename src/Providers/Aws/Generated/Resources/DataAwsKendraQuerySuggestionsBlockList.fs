namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKendraQuerySuggestionsBlockListState<'IndexId, 'QuerySuggestionsBlockListId> = { assignments: ResizeArray<aws.DataAwsKendraQuerySuggestionsBlockList.DataAwsKendraQuerySuggestionsBlockListConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_query_suggestions_block_list">aws_kendra_query_suggestions_block_list</a>.
    /// </summary>
    type DataAwsKendraQuerySuggestionsBlockListBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKendraQuerySuggestionsBlockListState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsKendraQuerySuggestionsBlockListState<Missing, Missing>)

        member _.Zero(()) : DataAwsKendraQuerySuggestionsBlockListState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsKendraQuerySuggestionsBlockListState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_query_suggestions_block_list#index_id-1">DataAwsKendraQuerySuggestionsBlockList#index_id</a>.
        /// </summary>
        [<CustomOperation "index_id">]
        member _.IndexId(state: DataAwsKendraQuerySuggestionsBlockListState<Missing, 'QuerySuggestionsBlockListId>, value: string) : DataAwsKendraQuerySuggestionsBlockListState<Present, 'QuerySuggestionsBlockListId> =
            state.assignments.Add(fun config -> config.IndexId <- value)
            ({ assignments = state.assignments } : DataAwsKendraQuerySuggestionsBlockListState<Present, 'QuerySuggestionsBlockListId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_query_suggestions_block_list#query_suggestions_block_list_id-1">DataAwsKendraQuerySuggestionsBlockList#query_suggestions_block_list_id</a>.
        /// </summary>
        [<CustomOperation "query_suggestions_block_list_id">]
        member _.QuerySuggestionsBlockListId(state: DataAwsKendraQuerySuggestionsBlockListState<'IndexId, Missing>, value: string) : DataAwsKendraQuerySuggestionsBlockListState<'IndexId, Present> =
            state.assignments.Add(fun config -> config.QuerySuggestionsBlockListId <- value)
            ({ assignments = state.assignments } : DataAwsKendraQuerySuggestionsBlockListState<'IndexId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_query_suggestions_block_list#id-1">DataAwsKendraQuerySuggestionsBlockList#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKendraQuerySuggestionsBlockListState<'IndexId, 'QuerySuggestionsBlockListId>, value: string) : DataAwsKendraQuerySuggestionsBlockListState<'IndexId, 'QuerySuggestionsBlockListId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKendraQuerySuggestionsBlockListState<'IndexId, 'QuerySuggestionsBlockListId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_query_suggestions_block_list#tags-1">DataAwsKendraQuerySuggestionsBlockList#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsKendraQuerySuggestionsBlockListState<'IndexId, 'QuerySuggestionsBlockListId>, value: seq<string * string>) : DataAwsKendraQuerySuggestionsBlockListState<'IndexId, 'QuerySuggestionsBlockListId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsKendraQuerySuggestionsBlockListState<'IndexId, 'QuerySuggestionsBlockListId>

        member _.Run(state: DataAwsKendraQuerySuggestionsBlockListState<Present, Present>) : aws.DataAwsKendraQuerySuggestionsBlockList.DataAwsKendraQuerySuggestionsBlockList =
            let config = aws.DataAwsKendraQuerySuggestionsBlockList.DataAwsKendraQuerySuggestionsBlockListConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKendraQuerySuggestionsBlockList.DataAwsKendraQuerySuggestionsBlockList(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsKendraQuerySuggestionsBlockList: missing required arguments. Must call: index_id, query_suggestions_block_list_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsKendraQuerySuggestionsBlockListState<_, _>) : aws.DataAwsKendraQuerySuggestionsBlockList.DataAwsKendraQuerySuggestionsBlockList =
            Unchecked.defaultof<aws.DataAwsKendraQuerySuggestionsBlockList.DataAwsKendraQuerySuggestionsBlockList>
