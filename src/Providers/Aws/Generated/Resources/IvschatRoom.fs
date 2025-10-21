namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IvschatRoomState = { assignments: ResizeArray<aws.IvschatRoom.IvschatRoomConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room">aws_ivschat_room</a>.
    /// </summary>
    type IvschatRoomBuilder(logicalId: string) =
        member _.Yield(_: unit) : IvschatRoomState =
            { assignments = ResizeArray() }

        member _.Zero(()) : IvschatRoomState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#id-1">IvschatRoom#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: IvschatRoomState, value: string) : IvschatRoomState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : IvschatRoomState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#logging_configuration_identifiers-1">IvschatRoom#logging_configuration_identifiers</a>.
        /// </summary>
        [<CustomOperation "logging_configuration_identifiers">]
        member _.LoggingConfigurationIdentifiers(state: IvschatRoomState, value: seq<string>) : IvschatRoomState =
            state.assignments.Add(fun config -> config.LoggingConfigurationIdentifiers <- (value |> Seq.toArray))
            state : IvschatRoomState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#maximum_message_length-1">IvschatRoom#maximum_message_length</a>.
        /// </summary>
        [<CustomOperation "maximum_message_length">]
        member _.MaximumMessageLength(state: IvschatRoomState, value: double) : IvschatRoomState =
            state.assignments.Add(fun config -> config.MaximumMessageLength <- value)
            state : IvschatRoomState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#maximum_message_rate_per_second-1">IvschatRoom#maximum_message_rate_per_second</a>.
        /// </summary>
        [<CustomOperation "maximum_message_rate_per_second">]
        member _.MaximumMessageRatePerSecond(state: IvschatRoomState, value: double) : IvschatRoomState =
            state.assignments.Add(fun config -> config.MaximumMessageRatePerSecond <- value)
            state : IvschatRoomState

        /// <summary>
        /// message_review_handler block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#message_review_handler-1">IvschatRoom#message_review_handler</a>
        /// </summary>
        [<CustomOperation "message_review_handler">]
        member _.MessageReviewHandler(state: IvschatRoomState, value: aws.IvschatRoom.IvschatRoomMessageReviewHandler) : IvschatRoomState =
            state.assignments.Add(fun config -> config.MessageReviewHandler <- value)
            state : IvschatRoomState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#name-1">IvschatRoom#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: IvschatRoomState, value: string) : IvschatRoomState =
            state.assignments.Add(fun config -> config.Name <- value)
            state : IvschatRoomState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#tags-1">IvschatRoom#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: IvschatRoomState, value: seq<string * string>) : IvschatRoomState =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : IvschatRoomState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#tags_all-1">IvschatRoom#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: IvschatRoomState, value: seq<string * string>) : IvschatRoomState =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : IvschatRoomState

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ivschat_room#timeouts-1">IvschatRoom#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: IvschatRoomState, value: aws.IvschatRoom.IvschatRoomTimeouts) : IvschatRoomState =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : IvschatRoomState

        member _.Run(state: IvschatRoomState) : aws.IvschatRoom.IvschatRoom =
            let config = aws.IvschatRoom.IvschatRoomConfig()
            for setter in state.assignments do
                setter config
            aws.IvschatRoom.IvschatRoom(StackContext.get (), logicalId, config)
