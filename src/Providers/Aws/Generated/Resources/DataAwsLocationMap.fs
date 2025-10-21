namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsLocationMapState<'MapName> = { assignments: ResizeArray<aws.DataAwsLocationMap.DataAwsLocationMapConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_map">aws_location_map</a>.
    /// </summary>
    type DataAwsLocationMapBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsLocationMapState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLocationMapState<Missing>)

        member _.Zero(()) : DataAwsLocationMapState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsLocationMapState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_map#map_name-1">DataAwsLocationMap#map_name</a>.
        /// </summary>
        [<CustomOperation "map_name">]
        member _.MapName(state: DataAwsLocationMapState<Missing>, value: string) : DataAwsLocationMapState<Present> =
            state.assignments.Add(fun config -> config.MapName <- value)
            ({ assignments = state.assignments } : DataAwsLocationMapState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_map#id-1">DataAwsLocationMap#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsLocationMapState<'MapName>, value: string) : DataAwsLocationMapState<'MapName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsLocationMapState<'MapName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/location_map#tags-1">DataAwsLocationMap#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataAwsLocationMapState<'MapName>, value: seq<string * string>) : DataAwsLocationMapState<'MapName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataAwsLocationMapState<'MapName>

        member _.Run(state: DataAwsLocationMapState<Present>) : aws.DataAwsLocationMap.DataAwsLocationMap =
            let config = aws.DataAwsLocationMap.DataAwsLocationMapConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsLocationMap.DataAwsLocationMap(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsLocationMap: missing required arguments. Must call: map_name.", 9999, IsError = true)>]
        member _.Run(_: DataAwsLocationMapState<_>) : aws.DataAwsLocationMap.DataAwsLocationMap =
            Unchecked.defaultof<aws.DataAwsLocationMap.DataAwsLocationMap>
