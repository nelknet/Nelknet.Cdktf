namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsCeTagsState<'TimePeriod> = { assignments: ResizeArray<aws.DataAwsCeTags.DataAwsCeTagsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags">aws_ce_tags</a>.
    /// </summary>
    type DataAwsCeTagsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsCeTagsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCeTagsState<Missing>)

        member _.Zero(()) : DataAwsCeTagsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsCeTagsState<Missing>)

        /// <summary>
        /// time_period block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#time_period-1">DataAwsCeTags#time_period</a>
        /// </summary>
        [<CustomOperation "time_period">]
        member _.TimePeriod(state: DataAwsCeTagsState<Missing>, value: aws.DataAwsCeTags.DataAwsCeTagsTimePeriod) : DataAwsCeTagsState<Present> =
            state.assignments.Add(fun config -> config.TimePeriod <- value)
            ({ assignments = state.assignments } : DataAwsCeTagsState<Present>)

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#filter-1">DataAwsCeTags#filter</a>
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsCeTagsState<'TimePeriod>, value: aws.DataAwsCeTags.DataAwsCeTagsFilter) : DataAwsCeTagsState<'TimePeriod> =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsCeTagsState<'TimePeriod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#id-1">DataAwsCeTags#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsCeTagsState<'TimePeriod>, value: string) : DataAwsCeTagsState<'TimePeriod> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsCeTagsState<'TimePeriod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#search_string-1">DataAwsCeTags#search_string</a>.
        /// </summary>
        [<CustomOperation "search_string">]
        member _.SearchString(state: DataAwsCeTagsState<'TimePeriod>, value: string) : DataAwsCeTagsState<'TimePeriod> =
            state.assignments.Add(fun config -> config.SearchString <- value)
            state : DataAwsCeTagsState<'TimePeriod>

        /// <summary>
        /// sort_by block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#sort_by-1">DataAwsCeTags#sort_by</a> Accepts: aws.IResolvable | aws.DataAwsCeTags.DataAwsCeTagsSortBy[]
        /// </summary>
        [<CustomOperation "sort_by">]
        member _.SortBy(state: DataAwsCeTagsState<'TimePeriod>, value: HashiCorp.Cdktf.IResolvable) : DataAwsCeTagsState<'TimePeriod> =
            state.assignments.Add(fun config -> config.SortBy <- value)
            state : DataAwsCeTagsState<'TimePeriod>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ce_tags#tag_key-1">DataAwsCeTags#tag_key</a>.
        /// </summary>
        [<CustomOperation "tag_key">]
        member _.TagKey(state: DataAwsCeTagsState<'TimePeriod>, value: string) : DataAwsCeTagsState<'TimePeriod> =
            state.assignments.Add(fun config -> config.TagKey <- value)
            state : DataAwsCeTagsState<'TimePeriod>

        member _.Run(state: DataAwsCeTagsState<Present>) : aws.DataAwsCeTags.DataAwsCeTags =
            let config = aws.DataAwsCeTags.DataAwsCeTagsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsCeTags.DataAwsCeTags(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsCeTags: missing required arguments. Must call: time_period.", 9999, IsError = true)>]
        member _.Run(_: DataAwsCeTagsState<_>) : aws.DataAwsCeTags.DataAwsCeTags =
            Unchecked.defaultof<aws.DataAwsCeTags.DataAwsCeTags>
