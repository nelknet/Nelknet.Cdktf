namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IdState<'ByteLength> = { assignments: ResizeArray<random.Id.IdConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/id">random_id</a>.
    /// </summary>
    type IdBuilder(logicalId: string) =
        member _.Yield(_: unit) : IdState<Missing> =
            ({ assignments = ResizeArray() } : IdState<Missing>)

        member _.Zero(()) : IdState<Missing> =
            ({ assignments = ResizeArray() } : IdState<Missing>)

        /// <summary>
        /// The number of random bytes to produce. The minimum value is 1, which produces eight bits of randomness. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/id#byte_length-1">Id#byte_length</a>
        /// </summary>
        [<CustomOperation "byte_length">]
        member _.ByteLength(state: IdState<Missing>, value: double) : IdState<Present> =
            state.assignments.Add(fun config -> config.ByteLength <- value)
            ({ assignments = state.assignments } : IdState<Present>)

        /// <summary>
        /// Arbitrary map of values that, when changed, will trigger recreation of resource. See [the main provider documentation](../index.html) for more information. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/id#keepers-1">Id#keepers</a>
        /// </summary>
        [<CustomOperation "keepers">]
        member _.Keepers(state: IdState<'ByteLength>, value: seq<string * string>) : IdState<'ByteLength> =
            state.assignments.Add(fun config -> config.Keepers <- dict value)
            state : IdState<'ByteLength>

        /// <summary>
        /// Arbitrary string to prefix the output value with. This string is supplied as-is, meaning it is not guaranteed to be URL-safe or base64 encoded. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/id#prefix-1">Id#prefix</a>
        /// </summary>
        [<CustomOperation "prefix">]
        member _.Prefix(state: IdState<'ByteLength>, value: string) : IdState<'ByteLength> =
            state.assignments.Add(fun config -> config.Prefix <- value)
            state : IdState<'ByteLength>

        member _.Run(state: IdState<Present>) : random.Id.Id_ =
            let config = random.Id.IdConfig()
            for setter in state.assignments do
                setter config
            random.Id.Id_(StackContext.get (), logicalId, config)

        [<CompilerMessage("Random.id: missing required arguments. Must call: byte_length.", 9999, IsError = true)>]
        member _.Run(_: IdState<_>) : random.Id.Id_ =
            Unchecked.defaultof<random.Id.Id_>
