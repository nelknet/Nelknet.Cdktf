namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsPrefixListState = { assignments: ResizeArray<aws.DataAwsPrefixList.DataAwsPrefixListConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prefix_list">aws_prefix_list</a>.
    /// </summary>
    type DataAwsPrefixListBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsPrefixListState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DataAwsPrefixListState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prefix_list#filter-1">DataAwsPrefixList#filter</a> Accepts: aws.IResolvable | aws.DataAwsPrefixList.DataAwsPrefixListFilter[]
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsPrefixListState, value: HashiCorp.Cdktf.IResolvable) : DataAwsPrefixListState =
            state.assignments.Add(fun config -> config.Filter <- value)
            state : DataAwsPrefixListState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prefix_list#id-1">DataAwsPrefixList#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsPrefixListState, value: string) : DataAwsPrefixListState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsPrefixListState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prefix_list#name-1">DataAwsPrefixList#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAwsPrefixListState, value: string) : DataAwsPrefixListState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : DataAwsPrefixListState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prefix_list#prefix_list_id-1">DataAwsPrefixList#prefix_list_id</a>.
        /// </summary>
        [<CustomOperation "prefix_list_id">]
        member _.PrefixListId(state: DataAwsPrefixListState, value: string) : DataAwsPrefixListState =
            state.assignments.Add(fun config -> config.PrefixListId <- value)
            state : DataAwsPrefixListState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/prefix_list#timeouts-1">DataAwsPrefixList#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAwsPrefixListState, value: aws.DataAwsPrefixList.DataAwsPrefixListTimeouts) : DataAwsPrefixListState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAwsPrefixListState

        member _.Run(state: DataAwsPrefixListState) : aws.DataAwsPrefixList.DataAwsPrefixList =
            let config = aws.DataAwsPrefixList.DataAwsPrefixListConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsPrefixList.DataAwsPrefixList(StackContext.get (), logicalId, config)
