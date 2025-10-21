namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PetState = { assignments: ResizeArray<random.Pet.PetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/pet">random_pet</a>.
    /// </summary>
    type PetBuilder(logicalId: string) =
        member _.Yield(_: unit) : PetState =
            { assignments = ResizeArray() }

        member _.Zero(()) : PetState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Arbitrary map of values that, when changed, will trigger recreation of resource. See [the main provider documentation](../index.html) for more information. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/pet#keepers-1">Pet#keepers</a>
        /// </summary>
        [<CustomOperation "keepers">]
        member _.Keepers(state: PetState, value: seq<string * string>) : PetState =
            state.assignments.Add(fun config -> config.Keepers <- dict value)
            state : PetState

        /// <summary>
        /// The length (in words) of the pet name. Defaults to 2. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/pet#length-1">Pet#length</a>
        /// </summary>
        [<CustomOperation "length">]
        member _.Length(state: PetState, value: double) : PetState =
            state.assignments.Add(fun config -> config.Length <- value)
            state : PetState

        /// <summary>
        /// A string to prefix the name with. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/pet#prefix-1">Pet#prefix</a>
        /// </summary>
        [<CustomOperation "prefix">]
        member _.Prefix(state: PetState, value: string) : PetState =
            state.assignments.Add(fun config -> config.Prefix <- value)
            state : PetState

        /// <summary>
        /// The character to separate words in the pet name. Defaults to "-". Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs/resources/pet#separator-1">Pet#separator</a>
        /// </summary>
        [<CustomOperation "separator">]
        member _.Separator(state: PetState, value: string) : PetState =
            state.assignments.Add(fun config -> config.Separator <- value)
            state : PetState

        member _.Run(state: PetState) : random.Pet.Pet =
            let config = random.Pet.PetConfig()
            for setter in state.assignments do
                setter config
            random.Pet.Pet(StackContext.get (), logicalId, config)
