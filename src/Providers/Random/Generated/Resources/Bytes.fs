namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type BytesState<'Length> = { assignments: ResizeArray<random.Bytes.BytesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/bytes">random_bytes</a>.
    /// </summary>
    type BytesBuilder(logicalId: string) =
        member _.Yield(_: unit) : BytesState<Missing> =
            ({ assignments = ResizeArray() } : BytesState<Missing>)

        member _.Zero(()) : BytesState<Missing> =
            ({ assignments = ResizeArray() } : BytesState<Missing>)

        /// <summary>
        /// The number of bytes requested. The minimum value for length is 1. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/bytes#length-1">Bytes#length</a>
        /// </summary>
        [<CustomOperation "length">]
        member _.Length(state: BytesState<Missing>, value: double) : BytesState<Present> =
            state.assignments.Add(fun config -> config.Length <- value)
            ({ assignments = state.assignments } : BytesState<Present>)

        /// <summary>
        /// Arbitrary map of values that, when changed, will trigger recreation of resource. See [the main provider documentation](../index.html) for more information. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/bytes#keepers-1">Bytes#keepers</a>
        /// </summary>
        [<CustomOperation "keepers">]
        member _.Keepers(state: BytesState<'Length>, value: seq<string * string>) : BytesState<'Length> =
            state.assignments.Add(fun config -> config.Keepers <- dict value)
            state : BytesState<'Length>

        member _.Run(state: BytesState<Present>) : random.Bytes.Bytes =
            let config = random.Bytes.BytesConfig()
            for setter in state.assignments do
                setter config
            random.Bytes.Bytes(StackContext.get (), logicalId, config)

        [<CompilerMessage("Random.bytes: missing required arguments. Must call: length.", 9999, IsError = true)>]
        member _.Run(_: BytesState<_>) : random.Bytes.Bytes =
            Unchecked.defaultof<random.Bytes.Bytes>
