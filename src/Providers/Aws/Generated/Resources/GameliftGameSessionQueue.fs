namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GameliftGameSessionQueueState<'Name> = { assignments: ResizeArray<aws.GameliftGameSessionQueue.GameliftGameSessionQueueConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_session_queue">aws_gamelift_game_session_queue</a>.
    /// </summary>
    type GameliftGameSessionQueueBuilder(logicalId: string) =
        member _.Yield(_: unit) : GameliftGameSessionQueueState<Missing> =
            ({ assignments = ResizeArray() } : GameliftGameSessionQueueState<Missing>)

        member _.Zero(()) : GameliftGameSessionQueueState<Missing> =
            ({ assignments = ResizeArray() } : GameliftGameSessionQueueState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_session_queue#name-1">GameliftGameSessionQueue#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: GameliftGameSessionQueueState<Missing>, value: string) : GameliftGameSessionQueueState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : GameliftGameSessionQueueState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_session_queue#custom_event_data-1">GameliftGameSessionQueue#custom_event_data</a>.
        /// </summary>
        [<CustomOperation "custom_event_data">]
        member _.CustomEventData(state: GameliftGameSessionQueueState<'Name>, value: string) : GameliftGameSessionQueueState<'Name> =
            state.assignments.Add(fun config -> config.CustomEventData <- value)
            state : GameliftGameSessionQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_session_queue#destinations-1">GameliftGameSessionQueue#destinations</a>.
        /// </summary>
        [<CustomOperation "destinations">]
        member _.Destinations(state: GameliftGameSessionQueueState<'Name>, value: seq<string>) : GameliftGameSessionQueueState<'Name> =
            state.assignments.Add(fun config -> config.Destinations <- (value |> Seq.toArray))
            state : GameliftGameSessionQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_session_queue#id-1">GameliftGameSessionQueue#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GameliftGameSessionQueueState<'Name>, value: string) : GameliftGameSessionQueueState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GameliftGameSessionQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_session_queue#notification_target-1">GameliftGameSessionQueue#notification_target</a>.
        /// </summary>
        [<CustomOperation "notification_target">]
        member _.NotificationTarget(state: GameliftGameSessionQueueState<'Name>, value: string) : GameliftGameSessionQueueState<'Name> =
            state.assignments.Add(fun config -> config.NotificationTarget <- value)
            state : GameliftGameSessionQueueState<'Name>

        /// <summary>
        /// player_latency_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_session_queue#player_latency_policy-1">GameliftGameSessionQueue#player_latency_policy</a> Accepts: aws.IResolvable | aws.GameliftGameSessionQueue.GameliftGameSessionQueuePlayerLatencyPolicy[]
        /// </summary>
        [<CustomOperation "player_latency_policy">]
        member _.PlayerLatencyPolicy(state: GameliftGameSessionQueueState<'Name>, value: HashiCorp.Cdktf.IResolvable) : GameliftGameSessionQueueState<'Name> =
            state.assignments.Add(fun config -> config.PlayerLatencyPolicy <- value)
            state : GameliftGameSessionQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_session_queue#tags-1">GameliftGameSessionQueue#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: GameliftGameSessionQueueState<'Name>, value: seq<string * string>) : GameliftGameSessionQueueState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : GameliftGameSessionQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_session_queue#tags_all-1">GameliftGameSessionQueue#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: GameliftGameSessionQueueState<'Name>, value: seq<string * string>) : GameliftGameSessionQueueState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : GameliftGameSessionQueueState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/gamelift_game_session_queue#timeout_in_seconds-1">GameliftGameSessionQueue#timeout_in_seconds</a>.
        /// </summary>
        [<CustomOperation "timeout_in_seconds">]
        member _.TimeoutInSeconds(state: GameliftGameSessionQueueState<'Name>, value: double) : GameliftGameSessionQueueState<'Name> =
            state.assignments.Add(fun config -> config.TimeoutInSeconds <- value)
            state : GameliftGameSessionQueueState<'Name>

        member _.Run(state: GameliftGameSessionQueueState<Present>) : aws.GameliftGameSessionQueue.GameliftGameSessionQueue =
            let config = aws.GameliftGameSessionQueue.GameliftGameSessionQueueConfig()
            for setter in state.assignments do
                setter config
            aws.GameliftGameSessionQueue.GameliftGameSessionQueue(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.gameliftGameSessionQueue: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: GameliftGameSessionQueueState<_>) : aws.GameliftGameSessionQueue.GameliftGameSessionQueue =
            Unchecked.defaultof<aws.GameliftGameSessionQueue.GameliftGameSessionQueue>
