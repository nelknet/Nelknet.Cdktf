namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DetectiveGraphState = { assignments: ResizeArray<aws.DetectiveGraph.DetectiveGraphConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_graph">aws_detective_graph</a>.
    /// </summary>
    type DetectiveGraphBuilder(logicalId: string) =
        member _.Yield(_: unit) : DetectiveGraphState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DetectiveGraphState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_graph#id-1">DetectiveGraph#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DetectiveGraphState, value: string) : DetectiveGraphState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DetectiveGraphState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_graph#tags-1">DetectiveGraph#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DetectiveGraphState, value: seq<string * string>) : DetectiveGraphState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DetectiveGraphState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_graph#tags_all-1">DetectiveGraph#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: DetectiveGraphState, value: seq<string * string>) : DetectiveGraphState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : DetectiveGraphState

        member _.Run(state: DetectiveGraphState) : aws.DetectiveGraph.DetectiveGraph =
            let config = aws.DetectiveGraph.DetectiveGraphConfig()
            for setter in state.assignments do
                setter config
            aws.DetectiveGraph.DetectiveGraph(StackContext.get (), logicalId, config)
