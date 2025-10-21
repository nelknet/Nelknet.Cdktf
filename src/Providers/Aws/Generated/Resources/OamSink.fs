namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OamSinkState<'Name> = { assignments: ResizeArray<aws.OamSink.OamSinkConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_sink">aws_oam_sink</a>.
    /// </summary>
    type OamSinkBuilder(logicalId: string) =
        member _.Yield(_: unit) : OamSinkState<Missing> =
            ({ assignments = ResizeArray() } : OamSinkState<Missing>)

        member _.Zero(()) : OamSinkState<Missing> =
            ({ assignments = ResizeArray() } : OamSinkState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_sink#name-1">OamSink#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: OamSinkState<Missing>, value: string) : OamSinkState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : OamSinkState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_sink#id-1">OamSink#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OamSinkState<'Name>, value: string) : OamSinkState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OamSinkState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_sink#tags-1">OamSink#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: OamSinkState<'Name>, value: seq<string * string>) : OamSinkState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : OamSinkState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_sink#tags_all-1">OamSink#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: OamSinkState<'Name>, value: seq<string * string>) : OamSinkState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : OamSinkState<'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/oam_sink#timeouts-1">OamSink#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: OamSinkState<'Name>, value: aws.OamSink.OamSinkTimeouts) : OamSinkState<'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : OamSinkState<'Name>

        member _.Run(state: OamSinkState<Present>) : aws.OamSink.OamSink =
            let config = aws.OamSink.OamSinkConfig()
            for setter in state.assignments do
                setter config
            aws.OamSink.OamSink(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.oamSink: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: OamSinkState<_>) : aws.OamSink.OamSink =
            Unchecked.defaultof<aws.OamSink.OamSink>
