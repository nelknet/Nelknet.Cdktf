namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Resourceexplorer2IndexState<'Type> = { assignments: ResizeArray<aws.Resourceexplorer2Index.Resourceexplorer2IndexConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_index">aws_resourceexplorer2_index</a>.
    /// </summary>
    type Resourceexplorer2IndexBuilder(logicalId: string) =
        member _.Yield(_: unit) : Resourceexplorer2IndexState<Missing> =
            ({ assignments = ResizeArray() } : Resourceexplorer2IndexState<Missing>)

        member _.Zero(()) : Resourceexplorer2IndexState<Missing> =
            ({ assignments = ResizeArray() } : Resourceexplorer2IndexState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_index#type-1">Resourceexplorer2Index#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: Resourceexplorer2IndexState<Missing>, value: string) : Resourceexplorer2IndexState<Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : Resourceexplorer2IndexState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_index#tags-1">Resourceexplorer2Index#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Resourceexplorer2IndexState<'Type>, value: seq<string * string>) : Resourceexplorer2IndexState<'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Resourceexplorer2IndexState<'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/resourceexplorer2_index#timeouts-1">Resourceexplorer2Index#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Resourceexplorer2IndexState<'Type>, value: aws.Resourceexplorer2Index.Resourceexplorer2IndexTimeouts) : Resourceexplorer2IndexState<'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Resourceexplorer2IndexState<'Type>

        member _.Run(state: Resourceexplorer2IndexState<Present>) : aws.Resourceexplorer2Index.Resourceexplorer2Index =
            let config = aws.Resourceexplorer2Index.Resourceexplorer2IndexConfig()
            for setter in state.assignments do
                setter config
            aws.Resourceexplorer2Index.Resourceexplorer2Index(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.resourceexplorer2Index: missing required arguments. Must call: type.", 9999, IsError = true)>]
        member _.Run(_: Resourceexplorer2IndexState<_>) : aws.Resourceexplorer2Index.Resourceexplorer2Index =
            Unchecked.defaultof<aws.Resourceexplorer2Index.Resourceexplorer2Index>
