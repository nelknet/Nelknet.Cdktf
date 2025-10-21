namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MedialiveMultiplexState<'AvailabilityZones, 'Name> = { assignments: ResizeArray<aws.MedialiveMultiplex.MedialiveMultiplexConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex">aws_medialive_multiplex</a>.
    /// </summary>
    type MedialiveMultiplexBuilder(logicalId: string) =
        member _.Yield(_: unit) : MedialiveMultiplexState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MedialiveMultiplexState<Missing, Missing>)

        member _.Zero(()) : MedialiveMultiplexState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MedialiveMultiplexState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#availability_zones-1">MedialiveMultiplex#availability_zones</a>.
        /// </summary>
        [<CustomOperation "availability_zones">]
        member _.AvailabilityZones(state: MedialiveMultiplexState<Missing, 'Name>, value: seq<string>) : MedialiveMultiplexState<Present, 'Name> =
            state.assignments.Add(fun config -> config.AvailabilityZones <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : MedialiveMultiplexState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#name-1">MedialiveMultiplex#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MedialiveMultiplexState<'AvailabilityZones, Missing>, value: string) : MedialiveMultiplexState<'AvailabilityZones, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MedialiveMultiplexState<'AvailabilityZones, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#id-1">MedialiveMultiplex#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MedialiveMultiplexState<'AvailabilityZones, 'Name>, value: string) : MedialiveMultiplexState<'AvailabilityZones, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MedialiveMultiplexState<'AvailabilityZones, 'Name>

        /// <summary>
        /// multiplex_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#multiplex_settings-1">MedialiveMultiplex#multiplex_settings</a>
        /// </summary>
        [<CustomOperation "multiplex_settings">]
        member _.MultiplexSettings(state: MedialiveMultiplexState<'AvailabilityZones, 'Name>, value: aws.MedialiveMultiplex.MedialiveMultiplexMultiplexSettings) : MedialiveMultiplexState<'AvailabilityZones, 'Name> =
            state.assignments.Add(fun config -> config.MultiplexSettings <- value)
            state : MedialiveMultiplexState<'AvailabilityZones, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#start_multiplex-1">MedialiveMultiplex#start_multiplex</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_multiplex">]
        member _.StartMultiplex(state: MedialiveMultiplexState<'AvailabilityZones, 'Name>, value: bool) : MedialiveMultiplexState<'AvailabilityZones, 'Name> =
            state.assignments.Add(fun config -> config.StartMultiplex <- value)
            state : MedialiveMultiplexState<'AvailabilityZones, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#start_multiplex-1">MedialiveMultiplex#start_multiplex</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_multiplex">]
        member _.StartMultiplex(state: MedialiveMultiplexState<'AvailabilityZones, 'Name>, value: HashiCorp.Cdktf.IResolvable) : MedialiveMultiplexState<'AvailabilityZones, 'Name> =
            state.assignments.Add(fun config -> config.StartMultiplex <- value)
            state : MedialiveMultiplexState<'AvailabilityZones, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#tags-1">MedialiveMultiplex#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MedialiveMultiplexState<'AvailabilityZones, 'Name>, value: seq<string * string>) : MedialiveMultiplexState<'AvailabilityZones, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MedialiveMultiplexState<'AvailabilityZones, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#tags_all-1">MedialiveMultiplex#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: MedialiveMultiplexState<'AvailabilityZones, 'Name>, value: seq<string * string>) : MedialiveMultiplexState<'AvailabilityZones, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : MedialiveMultiplexState<'AvailabilityZones, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex#timeouts-1">MedialiveMultiplex#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MedialiveMultiplexState<'AvailabilityZones, 'Name>, value: aws.MedialiveMultiplex.MedialiveMultiplexTimeouts) : MedialiveMultiplexState<'AvailabilityZones, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MedialiveMultiplexState<'AvailabilityZones, 'Name>

        member _.Run(state: MedialiveMultiplexState<Present, Present>) : aws.MedialiveMultiplex.MedialiveMultiplex =
            let config = aws.MedialiveMultiplex.MedialiveMultiplexConfig()
            for setter in state.assignments do
                setter config
            aws.MedialiveMultiplex.MedialiveMultiplex(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.medialiveMultiplex: missing required arguments. Must call: availability_zones, name.", 9999, IsError = true)>]
        member _.Run(_: MedialiveMultiplexState<_, _>) : aws.MedialiveMultiplex.MedialiveMultiplex =
            Unchecked.defaultof<aws.MedialiveMultiplex.MedialiveMultiplex>
