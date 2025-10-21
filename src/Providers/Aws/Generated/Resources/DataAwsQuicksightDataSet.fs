namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsQuicksightDataSetState<'DataSetId> = { assignments: ResizeArray<aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_data_set">aws_quicksight_data_set</a>.
    /// </summary>
    type DataAwsQuicksightDataSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsQuicksightDataSetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsQuicksightDataSetState<Missing>)

        member _.Zero(()) : DataAwsQuicksightDataSetState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsQuicksightDataSetState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_data_set#data_set_id-1">DataAwsQuicksightDataSet#data_set_id</a>.
        /// </summary>
        [<CustomOperation "data_set_id">]
        member _.DataSetId(state: DataAwsQuicksightDataSetState<Missing>, value: string) : DataAwsQuicksightDataSetState<Present> =
            state.assignments.Add(fun config -> config.DataSetId <- value)
            ({ assignments = state.assignments } : DataAwsQuicksightDataSetState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_data_set#aws_account_id-1">DataAwsQuicksightDataSet#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: DataAwsQuicksightDataSetState<'DataSetId>, value: string) : DataAwsQuicksightDataSetState<'DataSetId> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : DataAwsQuicksightDataSetState<'DataSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_data_set#id-1">DataAwsQuicksightDataSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsQuicksightDataSetState<'DataSetId>, value: string) : DataAwsQuicksightDataSetState<'DataSetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsQuicksightDataSetState<'DataSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_data_set#tags-1">DataAwsQuicksightDataSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsQuicksightDataSetState<'DataSetId>, value: seq<string * string>) : DataAwsQuicksightDataSetState<'DataSetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsQuicksightDataSetState<'DataSetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/quicksight_data_set#tags_all-1">DataAwsQuicksightDataSet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DataAwsQuicksightDataSetState<'DataSetId>, value: seq<string * string>) : DataAwsQuicksightDataSetState<'DataSetId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DataAwsQuicksightDataSetState<'DataSetId>

        member _.Run(state: DataAwsQuicksightDataSetState<Present>) : aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSet =
            let config = aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsQuicksightDataSet: missing required arguments. Must call: data_set_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsQuicksightDataSetState<_>) : aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSet =
            Unchecked.defaultof<aws.DataAwsQuicksightDataSet.DataAwsQuicksightDataSet>
