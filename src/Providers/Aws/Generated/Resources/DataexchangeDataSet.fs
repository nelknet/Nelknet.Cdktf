namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataexchangeDataSetState<'AssetType, 'Description, 'Name> = { assignments: ResizeArray<aws.DataexchangeDataSet.DataexchangeDataSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_data_set">aws_dataexchange_data_set</a>.
    /// </summary>
    type DataexchangeDataSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataexchangeDataSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataexchangeDataSetState<Missing, Missing, Missing>)

        member _.Zero(()) : DataexchangeDataSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataexchangeDataSetState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_data_set#asset_type-1">DataexchangeDataSet#asset_type</a>.
        /// </summary>
        [<CustomOperation "asset_type">]
        member _.AssetType(state: DataexchangeDataSetState<Missing, 'Description, 'Name>, value: string) : DataexchangeDataSetState<Present, 'Description, 'Name> =
            state.assignments.Add(fun config -> config.AssetType <- value)
            ({ assignments = state.assignments } : DataexchangeDataSetState<Present, 'Description, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_data_set#description-1">DataexchangeDataSet#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataexchangeDataSetState<'AssetType, Missing, 'Name>, value: string) : DataexchangeDataSetState<'AssetType, Present, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            ({ assignments = state.assignments } : DataexchangeDataSetState<'AssetType, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_data_set#name-1">DataexchangeDataSet#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataexchangeDataSetState<'AssetType, 'Description, Missing>, value: string) : DataexchangeDataSetState<'AssetType, 'Description, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataexchangeDataSetState<'AssetType, 'Description, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_data_set#id-1">DataexchangeDataSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataexchangeDataSetState<'AssetType, 'Description, 'Name>, value: string) : DataexchangeDataSetState<'AssetType, 'Description, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataexchangeDataSetState<'AssetType, 'Description, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_data_set#tags-1">DataexchangeDataSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataexchangeDataSetState<'AssetType, 'Description, 'Name>, value: seq<string * string>) : DataexchangeDataSetState<'AssetType, 'Description, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataexchangeDataSetState<'AssetType, 'Description, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/dataexchange_data_set#tags_all-1">DataexchangeDataSet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DataexchangeDataSetState<'AssetType, 'Description, 'Name>, value: seq<string * string>) : DataexchangeDataSetState<'AssetType, 'Description, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DataexchangeDataSetState<'AssetType, 'Description, 'Name>

        member _.Run(state: DataexchangeDataSetState<Present, Present, Present>) : aws.DataexchangeDataSet.DataexchangeDataSet =
            let config = aws.DataexchangeDataSet.DataexchangeDataSetConfig()
            for setter in state.assignments do
                setter config
            aws.DataexchangeDataSet.DataexchangeDataSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataexchangeDataSet: missing required arguments. Must call: asset_type, description, name.", 9999, IsError = true)>]
        member _.Run(_: DataexchangeDataSetState<_, _, _>) : aws.DataexchangeDataSet.DataexchangeDataSet =
            Unchecked.defaultof<aws.DataexchangeDataSet.DataexchangeDataSet>
