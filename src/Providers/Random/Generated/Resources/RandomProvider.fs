namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RandomProviderState = { assignments: ResizeArray<random.Provider.RandomProviderConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs">random</a>.
    /// </summary>
    type RandomProviderBuilder(logicalId: string) =
        member _.Yield(_: unit) : RandomProviderState =
            { assignments = ResizeArray() }

        member _.Zero(()) : RandomProviderState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Alias name. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/random/3.6.0/docs#alias-1">RandomProvider#alias</a>
        /// </summary>
        [<CustomOperation "alias">]
        member _.Alias(state: RandomProviderState, value: string) : RandomProviderState =
            state.assignments.Add(fun config -> config.Alias <- value)
            state : RandomProviderState

        member _.Run(state: RandomProviderState) : random.Provider.RandomProvider =
            let config = random.Provider.RandomProviderConfig()
            for setter in state.assignments do
                setter config
            random.Provider.RandomProvider(StackContext.get (), logicalId, config)
