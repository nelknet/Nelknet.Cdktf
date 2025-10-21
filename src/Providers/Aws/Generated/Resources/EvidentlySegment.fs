namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EvidentlySegmentState<'Name, 'Pattern> = { assignments: ResizeArray<aws.EvidentlySegment.EvidentlySegmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_segment">aws_evidently_segment</a>.
    /// </summary>
    type EvidentlySegmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : EvidentlySegmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EvidentlySegmentState<Missing, Missing>)

        member _.Zero(()) : EvidentlySegmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : EvidentlySegmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_segment#name-1">EvidentlySegment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EvidentlySegmentState<Missing, 'Pattern>, value: string) : EvidentlySegmentState<Present, 'Pattern> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EvidentlySegmentState<Present, 'Pattern>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_segment#pattern-1">EvidentlySegment#pattern</a>.
        /// </summary>
        [<CustomOperation "pattern">]
        member _.Pattern(state: EvidentlySegmentState<'Name, Missing>, value: string) : EvidentlySegmentState<'Name, Present> =
            state.assignments.Add(fun config -> config.Pattern <- value)
            ({ assignments = state.assignments } : EvidentlySegmentState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_segment#description-1">EvidentlySegment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: EvidentlySegmentState<'Name, 'Pattern>, value: string) : EvidentlySegmentState<'Name, 'Pattern> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : EvidentlySegmentState<'Name, 'Pattern>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_segment#id-1">EvidentlySegment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EvidentlySegmentState<'Name, 'Pattern>, value: string) : EvidentlySegmentState<'Name, 'Pattern> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EvidentlySegmentState<'Name, 'Pattern>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_segment#tags-1">EvidentlySegment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EvidentlySegmentState<'Name, 'Pattern>, value: seq<string * string>) : EvidentlySegmentState<'Name, 'Pattern> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EvidentlySegmentState<'Name, 'Pattern>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/evidently_segment#tags_all-1">EvidentlySegment#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EvidentlySegmentState<'Name, 'Pattern>, value: seq<string * string>) : EvidentlySegmentState<'Name, 'Pattern> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EvidentlySegmentState<'Name, 'Pattern>

        member _.Run(state: EvidentlySegmentState<Present, Present>) : aws.EvidentlySegment.EvidentlySegment =
            let config = aws.EvidentlySegment.EvidentlySegmentConfig()
            for setter in state.assignments do
                setter config
            aws.EvidentlySegment.EvidentlySegment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.evidentlySegment: missing required arguments. Must call: name, pattern.", 9999, IsError = true)>]
        member _.Run(_: EvidentlySegmentState<_, _>) : aws.EvidentlySegment.EvidentlySegment =
            Unchecked.defaultof<aws.EvidentlySegment.EvidentlySegment>
