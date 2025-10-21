namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LocationPlaceIndexState<'DataSource, 'IndexName> = { assignments: ResizeArray<aws.LocationPlaceIndex.LocationPlaceIndexConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_place_index">aws_location_place_index</a>.
    /// </summary>
    type LocationPlaceIndexBuilder(logicalId: string) =
        member _.Yield(_: unit) : LocationPlaceIndexState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LocationPlaceIndexState<Missing, Missing>)

        member _.Zero(()) : LocationPlaceIndexState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LocationPlaceIndexState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_place_index#data_source-1">LocationPlaceIndex#data_source</a>.
        /// </summary>
        [<CustomOperation "data_source">]
        member _.DataSource(state: LocationPlaceIndexState<Missing, 'IndexName>, value: string) : LocationPlaceIndexState<Present, 'IndexName> =
            state.assignments.Add(fun config -> config.DataSource <- value)
            ({ assignments = state.assignments } : LocationPlaceIndexState<Present, 'IndexName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_place_index#index_name-1">LocationPlaceIndex#index_name</a>.
        /// </summary>
        [<CustomOperation "index_name">]
        member _.IndexName(state: LocationPlaceIndexState<'DataSource, Missing>, value: string) : LocationPlaceIndexState<'DataSource, Present> =
            state.assignments.Add(fun config -> config.IndexName <- value)
            ({ assignments = state.assignments } : LocationPlaceIndexState<'DataSource, Present>)

        /// <summary>
        /// data_source_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_place_index#data_source_configuration-1">LocationPlaceIndex#data_source_configuration</a>
        /// </summary>
        [<CustomOperation "data_source_configuration">]
        member _.DataSourceConfiguration(state: LocationPlaceIndexState<'DataSource, 'IndexName>, value: aws.LocationPlaceIndex.LocationPlaceIndexDataSourceConfiguration) : LocationPlaceIndexState<'DataSource, 'IndexName> =
            state.assignments.Add(fun config -> config.DataSourceConfiguration <- value)
            state : LocationPlaceIndexState<'DataSource, 'IndexName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_place_index#description-1">LocationPlaceIndex#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LocationPlaceIndexState<'DataSource, 'IndexName>, value: string) : LocationPlaceIndexState<'DataSource, 'IndexName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LocationPlaceIndexState<'DataSource, 'IndexName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_place_index#id-1">LocationPlaceIndex#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LocationPlaceIndexState<'DataSource, 'IndexName>, value: string) : LocationPlaceIndexState<'DataSource, 'IndexName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LocationPlaceIndexState<'DataSource, 'IndexName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_place_index#tags-1">LocationPlaceIndex#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LocationPlaceIndexState<'DataSource, 'IndexName>, value: seq<string * string>) : LocationPlaceIndexState<'DataSource, 'IndexName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LocationPlaceIndexState<'DataSource, 'IndexName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_place_index#tags_all-1">LocationPlaceIndex#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LocationPlaceIndexState<'DataSource, 'IndexName>, value: seq<string * string>) : LocationPlaceIndexState<'DataSource, 'IndexName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LocationPlaceIndexState<'DataSource, 'IndexName>

        member _.Run(state: LocationPlaceIndexState<Present, Present>) : aws.LocationPlaceIndex.LocationPlaceIndex =
            let config = aws.LocationPlaceIndex.LocationPlaceIndexConfig()
            for setter in state.assignments do
                setter config
            aws.LocationPlaceIndex.LocationPlaceIndex(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.locationPlaceIndex: missing required arguments. Must call: data_source, index_name.", 9999, IsError = true)>]
        member _.Run(_: LocationPlaceIndexState<_, _>) : aws.LocationPlaceIndex.LocationPlaceIndex =
            Unchecked.defaultof<aws.LocationPlaceIndex.LocationPlaceIndex>
