namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LocationMapState<'Configuration, 'MapName> = { assignments: ResizeArray<aws.LocationMap.LocationMapConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_map">aws_location_map</a>.
    /// </summary>
    type LocationMapBuilder(logicalId: string) =
        member _.Yield(_: unit) : LocationMapState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LocationMapState<Missing, Missing>)

        member _.Zero(()) : LocationMapState<Missing, Missing> =
            ({ assignments = ResizeArray() } : LocationMapState<Missing, Missing>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_map#configuration-1">LocationMap#configuration</a>
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: LocationMapState<Missing, 'MapName>, value: aws.LocationMap.LocationMapConfiguration) : LocationMapState<Present, 'MapName> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            ({ assignments = state.assignments } : LocationMapState<Present, 'MapName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_map#map_name-1">LocationMap#map_name</a>.
        /// </summary>
        [<CustomOperation "map_name">]
        member _.MapName(state: LocationMapState<'Configuration, Missing>, value: string) : LocationMapState<'Configuration, Present> =
            state.assignments.Add(fun config -> config.MapName <- value)
            ({ assignments = state.assignments } : LocationMapState<'Configuration, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_map#description-1">LocationMap#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: LocationMapState<'Configuration, 'MapName>, value: string) : LocationMapState<'Configuration, 'MapName> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : LocationMapState<'Configuration, 'MapName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_map#id-1">LocationMap#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LocationMapState<'Configuration, 'MapName>, value: string) : LocationMapState<'Configuration, 'MapName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LocationMapState<'Configuration, 'MapName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_map#tags-1">LocationMap#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LocationMapState<'Configuration, 'MapName>, value: seq<string * string>) : LocationMapState<'Configuration, 'MapName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LocationMapState<'Configuration, 'MapName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/location_map#tags_all-1">LocationMap#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LocationMapState<'Configuration, 'MapName>, value: seq<string * string>) : LocationMapState<'Configuration, 'MapName> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LocationMapState<'Configuration, 'MapName>

        member _.Run(state: LocationMapState<Present, Present>) : aws.LocationMap.LocationMap =
            let config = aws.LocationMap.LocationMapConfig()
            for setter in state.assignments do
                setter config
            aws.LocationMap.LocationMap(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.locationMap: missing required arguments. Must call: configuration, map_name.", 9999, IsError = true)>]
        member _.Run(_: LocationMapState<_, _>) : aws.LocationMap.LocationMap =
            Unchecked.defaultof<aws.LocationMap.LocationMap>
