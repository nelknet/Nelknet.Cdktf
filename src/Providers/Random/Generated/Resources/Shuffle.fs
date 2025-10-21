namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ShuffleState<'Input> = { assignments: ResizeArray<random.Shuffle.ShuffleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/shuffle">random_shuffle</a>.
    /// </summary>
    type ShuffleBuilder(logicalId: string) =
        member _.Yield(_: unit) : ShuffleState<Missing> =
            ({ assignments = ResizeArray() } : ShuffleState<Missing>)

        member _.Zero(()) : ShuffleState<Missing> =
            ({ assignments = ResizeArray() } : ShuffleState<Missing>)

        /// <summary>
        /// The list of strings to shuffle. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/shuffle#input-1">Shuffle#input</a>
        /// </summary>
        [<CustomOperation "input">]
        member _.Input(state: ShuffleState<Missing>, value: seq<string>) : ShuffleState<Present> =
            state.assignments.Add(fun config -> config.Input <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : ShuffleState<Present>)

        /// <summary>
        /// Arbitrary map of values that, when changed, will trigger recreation of resource. See [the main provider documentation](../index.html) for more information. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/shuffle#keepers-1">Shuffle#keepers</a>
        /// </summary>
        [<CustomOperation "keepers">]
        member _.Keepers(state: ShuffleState<'Input>, value: seq<string * string>) : ShuffleState<'Input> =
            state.assignments.Add(fun config -> config.Keepers <- dict value)
            state : ShuffleState<'Input>

        /// <summary>
        /// The number of results to return. Defaults to the number of items in the `input` list. If fewer items are requested, some elements will be excluded from the result. If more items are requested, items will be repeated in the result but not more frequently than the number of items in the input list. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/shuffle#result_count-1">Shuffle#result_count</a>
        /// </summary>
        [<CustomOperation "result_count">]
        member _.ResultCount(state: ShuffleState<'Input>, value: double) : ShuffleState<'Input> =
            state.assignments.Add(fun config -> config.ResultCount <- value)
            state : ShuffleState<'Input>

        /// <summary>
        /// Arbitrary string with which to seed the random number generator, in order to produce less-volatile permutations of the list. **Important:** Even with an identical seed, it is not guaranteed that the same permutation will be produced across different versions of Terraform. This argument causes the result to be *less volatile*, but not fixed for all time. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/shuffle#seed-1">Shuffle#seed</a>
        /// </summary>
        [<CustomOperation "seed">]
        member _.Seed(state: ShuffleState<'Input>, value: string) : ShuffleState<'Input> =
            state.assignments.Add(fun config -> config.Seed <- value)
            state : ShuffleState<'Input>

        member _.Run(state: ShuffleState<Present>) : random.Shuffle.Shuffle =
            let config = random.Shuffle.ShuffleConfig()
            for setter in state.assignments do
                setter config
            random.Shuffle.Shuffle(StackContext.get (), logicalId, config)

        [<CompilerMessage("Random.shuffle: missing required arguments. Must call: input.", 9999, IsError = true)>]
        member _.Run(_: ShuffleState<_>) : random.Shuffle.Shuffle =
            Unchecked.defaultof<random.Shuffle.Shuffle>
