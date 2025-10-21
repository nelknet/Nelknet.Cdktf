namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcEndpointConnectionNotificationState<'ConnectionEvents, 'ConnectionNotificationArn> = { assignments: ResizeArray<aws.VpcEndpointConnectionNotification.VpcEndpointConnectionNotificationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_connection_notification">aws_vpc_endpoint_connection_notification</a>.
    /// </summary>
    type VpcEndpointConnectionNotificationBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcEndpointConnectionNotificationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointConnectionNotificationState<Missing, Missing>)

        member _.Zero(()) : VpcEndpointConnectionNotificationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : VpcEndpointConnectionNotificationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_connection_notification#connection_events-1">VpcEndpointConnectionNotification#connection_events</a>.
        /// </summary>
        [<CustomOperation "connection_events">]
        member _.ConnectionEvents(state: VpcEndpointConnectionNotificationState<Missing, 'ConnectionNotificationArn>, value: seq<string>) : VpcEndpointConnectionNotificationState<Present, 'ConnectionNotificationArn> =
            state.assignments.Add(fun config -> config.ConnectionEvents <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : VpcEndpointConnectionNotificationState<Present, 'ConnectionNotificationArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_connection_notification#connection_notification_arn-1">VpcEndpointConnectionNotification#connection_notification_arn</a>.
        /// </summary>
        [<CustomOperation "connection_notification_arn">]
        member _.ConnectionNotificationArn(state: VpcEndpointConnectionNotificationState<'ConnectionEvents, Missing>, value: string) : VpcEndpointConnectionNotificationState<'ConnectionEvents, Present> =
            state.assignments.Add(fun config -> config.ConnectionNotificationArn <- value)
            ({ assignments = state.assignments } : VpcEndpointConnectionNotificationState<'ConnectionEvents, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_connection_notification#id-1">VpcEndpointConnectionNotification#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcEndpointConnectionNotificationState<'ConnectionEvents, 'ConnectionNotificationArn>, value: string) : VpcEndpointConnectionNotificationState<'ConnectionEvents, 'ConnectionNotificationArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcEndpointConnectionNotificationState<'ConnectionEvents, 'ConnectionNotificationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_connection_notification#vpc_endpoint_id-1">VpcEndpointConnectionNotification#vpc_endpoint_id</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_id">]
        member _.VpcEndpointId(state: VpcEndpointConnectionNotificationState<'ConnectionEvents, 'ConnectionNotificationArn>, value: string) : VpcEndpointConnectionNotificationState<'ConnectionEvents, 'ConnectionNotificationArn> =
            state.assignments.Add(fun config -> config.VpcEndpointId <- value)
            state : VpcEndpointConnectionNotificationState<'ConnectionEvents, 'ConnectionNotificationArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_endpoint_connection_notification#vpc_endpoint_service_id-1">VpcEndpointConnectionNotification#vpc_endpoint_service_id</a>.
        /// </summary>
        [<CustomOperation "vpc_endpoint_service_id">]
        member _.VpcEndpointServiceId(state: VpcEndpointConnectionNotificationState<'ConnectionEvents, 'ConnectionNotificationArn>, value: string) : VpcEndpointConnectionNotificationState<'ConnectionEvents, 'ConnectionNotificationArn> =
            state.assignments.Add(fun config -> config.VpcEndpointServiceId <- value)
            state : VpcEndpointConnectionNotificationState<'ConnectionEvents, 'ConnectionNotificationArn>

        member _.Run(state: VpcEndpointConnectionNotificationState<Present, Present>) : aws.VpcEndpointConnectionNotification.VpcEndpointConnectionNotification =
            let config = aws.VpcEndpointConnectionNotification.VpcEndpointConnectionNotificationConfig()
            for setter in state.assignments do
                setter config
            aws.VpcEndpointConnectionNotification.VpcEndpointConnectionNotification(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcEndpointConnectionNotification: missing required arguments. Must call: connection_events, connection_notification_arn.", 9999, IsError = true)>]
        member _.Run(_: VpcEndpointConnectionNotificationState<_, _>) : aws.VpcEndpointConnectionNotification.VpcEndpointConnectionNotification =
            Unchecked.defaultof<aws.VpcEndpointConnectionNotification.VpcEndpointConnectionNotification>
