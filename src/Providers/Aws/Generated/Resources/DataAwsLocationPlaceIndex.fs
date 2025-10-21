namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLocationPlaceIndexState<'IndexName> = { assignments: ResizeArray<aws.DataAwsLocationPlaceIndex.DataAwsLocationPlaceIndexConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_place_index">aws_location_place_index</a>.
    /// </summary>
    type DataAwsLocationPlaceIndexBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLocationPlaceIndexState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLocationPlaceIndexState<Missing>)

        member _.Zero(()) : DataAwsLocationPlaceIndexState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLocationPlaceIndexState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_place_index#index_name-1">DataAwsLocationPlaceIndex#index_name</a>.
        /// </summary>
        [<CustomOperation "index_name">]
        member _.IndexName(state: DataAwsLocationPlaceIndexState<Missing>, value: string) : DataAwsLocationPlaceIndexState<Present> =
            state.assignments.Add(fun config -> config.IndexName <- value)
            ({ assignments = state.assignments } : DataAwsLocationPlaceIndexState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_place_index#id-1">DataAwsLocationPlaceIndex#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLocationPlaceIndexState<'IndexName>, value: string) : DataAwsLocationPlaceIndexState<'IndexName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLocationPlaceIndexState<'IndexName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_place_index#tags-1">DataAwsLocationPlaceIndex#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsLocationPlaceIndexState<'IndexName>, value: seq<string * string>) : DataAwsLocationPlaceIndexState<'IndexName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsLocationPlaceIndexState<'IndexName>

        member _.Run(state: DataAwsLocationPlaceIndexState<Present>) : aws.DataAwsLocationPlaceIndex.DataAwsLocationPlaceIndex =
            let config = aws.DataAwsLocationPlaceIndex.DataAwsLocationPlaceIndexConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLocationPlaceIndex.DataAwsLocationPlaceIndex(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLocationPlaceIndex: missing required arguments. Must call: index_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLocationPlaceIndexState<_>) : aws.DataAwsLocationPlaceIndex.DataAwsLocationPlaceIndex =
            Unchecked.defaultof<aws.DataAwsLocationPlaceIndex.DataAwsLocationPlaceIndex>
