namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsDevopsguruNotificationChannelState<'Id> = { assignments: ResizeArray<aws.DataAwsDevopsguruNotificationChannel.DataAwsDevopsguruNotificationChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/devopsguru_notification_channel">aws_devopsguru_notification_channel</a>.
    /// </summary>
    type DataAwsDevopsguruNotificationChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsDevopsguruNotificationChannelState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDevopsguruNotificationChannelState<Missing>)

        member _.Zero(()) : DataAwsDevopsguruNotificationChannelState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsDevopsguruNotificationChannelState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/devopsguru_notification_channel#id-1">DataAwsDevopsguruNotificationChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsDevopsguruNotificationChannelState<Missing>, value: string) : DataAwsDevopsguruNotificationChannelState<Present> =
            state.assignments.Add(fun config -> config.Id <- value)
            ({ assignments = state.assignments } : DataAwsDevopsguruNotificationChannelState<Present>)

        /// <summary>
        /// filters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/devopsguru_notification_channel#filters-1">DataAwsDevopsguruNotificationChannel#filters</a> Accepts: aws.IResolvable | aws.DataAwsDevopsguruNotificationChannel.DataAwsDevopsguruNotificationChannelFilters[]
        /// </summary>
        [<CustomOperation "filters">]
        member _.Filters(state: DataAwsDevopsguruNotificationChannelState<'Id>, value: HashiCorp.Cdktf.IResolvable) : DataAwsDevopsguruNotificationChannelState<'Id> =
            state.assignments.Add(fun config -> config.Filters <- value)
            state : DataAwsDevopsguruNotificationChannelState<'Id>

        /// <summary>
        /// sns block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/devopsguru_notification_channel#sns-1">DataAwsDevopsguruNotificationChannel#sns</a> Accepts: aws.IResolvable | aws.DataAwsDevopsguruNotificationChannel.DataAwsDevopsguruNotificationChannelSns[]
        /// </summary>
        [<CustomOperation "sns">]
        member _.Sns(state: DataAwsDevopsguruNotificationChannelState<'Id>, value: HashiCorp.Cdktf.IResolvable) : DataAwsDevopsguruNotificationChannelState<'Id> =
            state.assignments.Add(fun config -> config.Sns <- value)
            state : DataAwsDevopsguruNotificationChannelState<'Id>

        member _.Run(state: DataAwsDevopsguruNotificationChannelState<Present>) : aws.DataAwsDevopsguruNotificationChannel.DataAwsDevopsguruNotificationChannel =
            let config = aws.DataAwsDevopsguruNotificationChannel.DataAwsDevopsguruNotificationChannelConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsDevopsguruNotificationChannel.DataAwsDevopsguruNotificationChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsDevopsguruNotificationChannel: missing required arguments. Must call: id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsDevopsguruNotificationChannelState<_>) : aws.DataAwsDevopsguruNotificationChannel.DataAwsDevopsguruNotificationChannel =
            Unchecked.defaultof<aws.DataAwsDevopsguruNotificationChannel.DataAwsDevopsguruNotificationChannel>
