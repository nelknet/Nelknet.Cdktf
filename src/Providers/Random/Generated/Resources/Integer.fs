namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IntegerState<'Max, 'Min> = { assignments: ResizeArray<random.Integer.IntegerConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/integer">random_integer</a>.
    /// </summary>
    type IntegerBuilder(logicalId: string) =
        member _.Yield(_: unit) : IntegerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IntegerState<Missing, Missing>)

        member _.Zero(()) : IntegerState<Missing, Missing> =
            ({ assignments = ResizeArray() } : IntegerState<Missing, Missing>)

        /// <summary>
        /// The maximum inclusive value of the range. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/integer#max-1">Integer#max</a>
        /// </summary>
        [<CustomOperation "max">]
        member _.Max(state: IntegerState<Missing, 'Min>, value: double) : IntegerState<Present, 'Min> =
            state.assignments.Add(fun config -> config.Max <- value)
            ({ assignments = state.assignments } : IntegerState<Present, 'Min>)

        /// <summary>
        /// The minimum inclusive value of the range. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/integer#min-1">Integer#min</a>
        /// </summary>
        [<CustomOperation "min">]
        member _.Min(state: IntegerState<'Max, Missing>, value: double) : IntegerState<'Max, Present> =
            state.assignments.Add(fun config -> config.Min <- value)
            ({ assignments = state.assignments } : IntegerState<'Max, Present>)

        /// <summary>
        /// Arbitrary map of values that, when changed, will trigger recreation of resource. See [the main provider documentation](../index.html) for more information. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/integer#keepers-1">Integer#keepers</a>
        /// </summary>
        [<CustomOperation "keepers">]
        member _.Keepers(state: IntegerState<'Max, 'Min>, value: seq<string * string>) : IntegerState<'Max, 'Min> =
            state.assignments.Add(fun config -> config.Keepers <- dict value)
            state : IntegerState<'Max, 'Min>

        /// <summary>
        /// A custom seed to always produce the same value. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/integer#seed-1">Integer#seed</a>
        /// </summary>
        [<CustomOperation "seed">]
        member _.Seed(state: IntegerState<'Max, 'Min>, value: string) : IntegerState<'Max, 'Min> =
            state.assignments.Add(fun config -> config.Seed <- value)
            state : IntegerState<'Max, 'Min>

        member _.Run(state: IntegerState<Present, Present>) : random.Integer.Integer =
            let config = random.Integer.IntegerConfig()
            for setter in state.assignments do
                setter config
            random.Integer.Integer(StackContext.get (), logicalId, config)

        [<CompilerMessage("Random.integer: missing required arguments. Must call: max, min.", 9999, IsError = true)>]
        member _.Run(_: IntegerState<_, _>) : random.Integer.Integer =
            Unchecked.defaultof<random.Integer.Integer>
