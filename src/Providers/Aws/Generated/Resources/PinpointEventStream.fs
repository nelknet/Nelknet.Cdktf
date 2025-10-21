namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PinpointEventStreamState<'ApplicationId, 'DestinationStreamArn, 'RoleArn> = { assignments: ResizeArray<aws.PinpointEventStream.PinpointEventStreamConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_event_stream">aws_pinpoint_event_stream</a>.
    /// </summary>
    type PinpointEventStreamBuilder(logicalId: string) =
        member _.Yield(_: unit) : PinpointEventStreamState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PinpointEventStreamState<Missing, Missing, Missing>)

        member _.Zero(()) : PinpointEventStreamState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PinpointEventStreamState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_event_stream#application_id-1">PinpointEventStream#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: PinpointEventStreamState<Missing, 'DestinationStreamArn, 'RoleArn>, value: string) : PinpointEventStreamState<Present, 'DestinationStreamArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : PinpointEventStreamState<Present, 'DestinationStreamArn, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_event_stream#destination_stream_arn-1">PinpointEventStream#destination_stream_arn</a>.
        /// </summary>
        [<CustomOperation "destination_stream_arn">]
        member _.DestinationStreamArn(state: PinpointEventStreamState<'ApplicationId, Missing, 'RoleArn>, value: string) : PinpointEventStreamState<'ApplicationId, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.DestinationStreamArn <- value)
            ({ assignments = state.assignments } : PinpointEventStreamState<'ApplicationId, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_event_stream#role_arn-1">PinpointEventStream#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: PinpointEventStreamState<'ApplicationId, 'DestinationStreamArn, Missing>, value: string) : PinpointEventStreamState<'ApplicationId, 'DestinationStreamArn, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : PinpointEventStreamState<'ApplicationId, 'DestinationStreamArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_event_stream#id-1">PinpointEventStream#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PinpointEventStreamState<'ApplicationId, 'DestinationStreamArn, 'RoleArn>, value: string) : PinpointEventStreamState<'ApplicationId, 'DestinationStreamArn, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PinpointEventStreamState<'ApplicationId, 'DestinationStreamArn, 'RoleArn>

        member _.Run(state: PinpointEventStreamState<Present, Present, Present>) : aws.PinpointEventStream.PinpointEventStream =
            let config = aws.PinpointEventStream.PinpointEventStreamConfig()
            for setter in state.assignments do
                setter config
            aws.PinpointEventStream.PinpointEventStream(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pinpointEventStream: missing required arguments. Must call: application_id, destination_stream_arn, role_arn.", 9999, IsError = true)>]
        member _.Run(_: PinpointEventStreamState<_, _, _>) : aws.PinpointEventStream.PinpointEventStream =
            Unchecked.defaultof<aws.PinpointEventStream.PinpointEventStream>
