namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GameliftAliasState<'Name, 'RoutingStrategy> = { assignments: ResizeArray<aws.GameliftAlias.GameliftAliasConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_alias">aws_gamelift_alias</a>.
    /// </summary>
    type GameliftAliasBuilder(logicalId: string) =
        member _.Yield(_: unit) : GameliftAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GameliftAliasState<Missing, Missing>)

        member _.Zero(()) : GameliftAliasState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GameliftAliasState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_alias#name-1">GameliftAlias#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GameliftAliasState<Missing, 'RoutingStrategy>, value: string) : GameliftAliasState<Present, 'RoutingStrategy> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GameliftAliasState<Present, 'RoutingStrategy>)

        /// <summary>
        /// routing_strategy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_alias#routing_strategy-1">GameliftAlias#routing_strategy</a>
        /// </summary>
        [<CustomOperation "routing_strategy">]
        member _.RoutingStrategy(state: GameliftAliasState<'Name, Missing>, value: aws.GameliftAlias.GameliftAliasRoutingStrategy) : GameliftAliasState<'Name, Present> =
            state.assignments.Add(fun config -> config.RoutingStrategy <- value)
            ({ assignments = state.assignments } : GameliftAliasState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_alias#description-1">GameliftAlias#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: GameliftAliasState<'Name, 'RoutingStrategy>, value: string) : GameliftAliasState<'Name, 'RoutingStrategy> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : GameliftAliasState<'Name, 'RoutingStrategy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_alias#id-1">GameliftAlias#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GameliftAliasState<'Name, 'RoutingStrategy>, value: string) : GameliftAliasState<'Name, 'RoutingStrategy> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GameliftAliasState<'Name, 'RoutingStrategy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_alias#tags-1">GameliftAlias#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GameliftAliasState<'Name, 'RoutingStrategy>, value: seq<string * string>) : GameliftAliasState<'Name, 'RoutingStrategy> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GameliftAliasState<'Name, 'RoutingStrategy>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_alias#tags_all-1">GameliftAlias#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GameliftAliasState<'Name, 'RoutingStrategy>, value: seq<string * string>) : GameliftAliasState<'Name, 'RoutingStrategy> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GameliftAliasState<'Name, 'RoutingStrategy>

        member _.Run(state: GameliftAliasState<Present, Present>) : aws.GameliftAlias.GameliftAlias =
            let config = aws.GameliftAlias.GameliftAliasConfig()
            for setter in state.assignments do
                setter config
            aws.GameliftAlias.GameliftAlias(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.gameliftAlias: missing required arguments. Must call: name, routing_strategy.", 9999, IsError = true)>]
        member _.Run(_: GameliftAliasState<_, _>) : aws.GameliftAlias.GameliftAlias =
            Unchecked.defaultof<aws.GameliftAlias.GameliftAlias>
