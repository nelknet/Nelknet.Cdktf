namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsResourceexplorer2SearchState<'QueryString> = { assignments: ResizeArray<aws.DataAwsResourceexplorer2Search.DataAwsResourceexplorer2SearchConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourceexplorer2_search">aws_resourceexplorer2_search</a>.
    /// </summary>
    type DataAwsResourceexplorer2SearchBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsResourceexplorer2SearchState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsResourceexplorer2SearchState<Missing>)

        member _.Zero(()) : DataAwsResourceexplorer2SearchState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsResourceexplorer2SearchState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourceexplorer2_search#query_string-1">DataAwsResourceexplorer2Search#query_string</a>.
        /// </summary>
        [<CustomOperation "query_string">]
        member _.QueryString(state: DataAwsResourceexplorer2SearchState<Missing>, value: string) : DataAwsResourceexplorer2SearchState<Present> =
            state.assignments.Add(fun config -> config.QueryString <- value)
            ({ assignments = state.assignments } : DataAwsResourceexplorer2SearchState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/resourceexplorer2_search#view_arn-1">DataAwsResourceexplorer2Search#view_arn</a>.
        /// </summary>
        [<CustomOperation "view_arn">]
        member _.ViewArn(state: DataAwsResourceexplorer2SearchState<'QueryString>, value: string) : DataAwsResourceexplorer2SearchState<'QueryString> =
            state.assignments.Add(fun config -> config.ViewArn <- value)
            state : DataAwsResourceexplorer2SearchState<'QueryString>

        member _.Run(state: DataAwsResourceexplorer2SearchState<Present>) : aws.DataAwsResourceexplorer2Search.DataAwsResourceexplorer2Search =
            let config = aws.DataAwsResourceexplorer2Search.DataAwsResourceexplorer2SearchConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsResourceexplorer2Search.DataAwsResourceexplorer2Search(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsResourceexplorer2Search: missing required arguments. Must call: query_string.", 9999, IsError = true)>]
        member _.Run(_: DataAwsResourceexplorer2SearchState<_>) : aws.DataAwsResourceexplorer2Search.DataAwsResourceexplorer2Search =
            Unchecked.defaultof<aws.DataAwsResourceexplorer2Search.DataAwsResourceexplorer2Search>
