namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type UuidState = { assignments: ResizeArray<random.Uuid.UuidConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/uuid">random_uuid</a>.
    /// </summary>
    type UuidBuilder(logicalId: string) =
        member _.Yield(_: unit) : UuidState =
            { assignments = ResizeArray() }

        member _.Zero(()) : UuidState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Arbitrary map of values that, when changed, will trigger recreation of resource. See [the main provider documentation](../index.html) for more information. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/uuid#keepers-1">Uuid#keepers</a>
        /// </summary>
        [<CustomOperation "keepers">]
        member _.Keepers(state: UuidState, value: seq<string * string>) : UuidState =
            state.assignments.Add(fun config -> config.Keepers <- dict value)
            state : UuidState

        member _.Run(state: UuidState) : random.Uuid.Uuid =
            let config = random.Uuid.UuidConfig()
            for setter in state.assignments do
                setter config
            random.Uuid.Uuid(StackContext.get (), logicalId, config)
