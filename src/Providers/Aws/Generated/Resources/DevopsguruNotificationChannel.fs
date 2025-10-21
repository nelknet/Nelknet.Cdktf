namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevopsguruNotificationChannelState = { assignments: ResizeArray<aws.DevopsguruNotificationChannel.DevopsguruNotificationChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_notification_channel">aws_devopsguru_notification_channel</a>.
    /// </summary>
    type DevopsguruNotificationChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevopsguruNotificationChannelState =
            { assignments = ResizeArray() }

        member _.Zero(()) : DevopsguruNotificationChannelState =
            { assignments = ResizeArray() }

        /// <summary>
        /// filters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_notification_channel#filters-1">DevopsguruNotificationChannel#filters</a> Accepts: aws.IResolvable | aws.DevopsguruNotificationChannel.DevopsguruNotificationChannelFilters[]
        /// </summary>
        [<CustomOperation "filters">]
        member _.Filters(state: DevopsguruNotificationChannelState, value: HashiCorp.Cdktf.IResolvable) : DevopsguruNotificationChannelState =
            state.assignments.Add(fun config -> config.Filters <- value)
            state : DevopsguruNotificationChannelState

        /// <summary>
        /// sns block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/devopsguru_notification_channel#sns-1">DevopsguruNotificationChannel#sns</a> Accepts: aws.IResolvable | aws.DevopsguruNotificationChannel.DevopsguruNotificationChannelSns[]
        /// </summary>
        [<CustomOperation "sns">]
        member _.Sns(state: DevopsguruNotificationChannelState, value: HashiCorp.Cdktf.IResolvable) : DevopsguruNotificationChannelState =
            state.assignments.Add(fun config -> config.Sns <- value)
            state : DevopsguruNotificationChannelState

        member _.Run(state: DevopsguruNotificationChannelState) : aws.DevopsguruNotificationChannel.DevopsguruNotificationChannel =
            let config = aws.DevopsguruNotificationChannel.DevopsguruNotificationChannelConfig()
            for setter in state.assignments do
                setter config
            aws.DevopsguruNotificationChannel.DevopsguruNotificationChannel(StackContext.get (), logicalId, config)
