namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PinpointSmsChannelState<'ApplicationId> = { assignments: ResizeArray<aws.PinpointSmsChannel.PinpointSmsChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_sms_channel">aws_pinpoint_sms_channel</a>.
    /// </summary>
    type PinpointSmsChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : PinpointSmsChannelState<Missing> =
            ({ assignments = ResizeArray() } : PinpointSmsChannelState<Missing>)

        member _.Zero(()) : PinpointSmsChannelState<Missing> =
            ({ assignments = ResizeArray() } : PinpointSmsChannelState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_sms_channel#application_id-1">PinpointSmsChannel#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: PinpointSmsChannelState<Missing>, value: string) : PinpointSmsChannelState<Present> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : PinpointSmsChannelState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_sms_channel#enabled-1">PinpointSmsChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointSmsChannelState<'ApplicationId>, value: bool) : PinpointSmsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointSmsChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_sms_channel#enabled-1">PinpointSmsChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointSmsChannelState<'ApplicationId>, value: HashiCorp.Cdktf.IResolvable) : PinpointSmsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointSmsChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_sms_channel#id-1">PinpointSmsChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PinpointSmsChannelState<'ApplicationId>, value: string) : PinpointSmsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PinpointSmsChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_sms_channel#sender_id-1">PinpointSmsChannel#sender_id</a>.
        /// </summary>
        [<CustomOperation "sender_id">]
        member _.SenderId(state: PinpointSmsChannelState<'ApplicationId>, value: string) : PinpointSmsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.SenderId <- value)
            state : PinpointSmsChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_sms_channel#short_code-1">PinpointSmsChannel#short_code</a>.
        /// </summary>
        [<CustomOperation "short_code">]
        member _.ShortCode(state: PinpointSmsChannelState<'ApplicationId>, value: string) : PinpointSmsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.ShortCode <- value)
            state : PinpointSmsChannelState<'ApplicationId>

        member _.Run(state: PinpointSmsChannelState<Present>) : aws.PinpointSmsChannel.PinpointSmsChannel =
            let config = aws.PinpointSmsChannel.PinpointSmsChannelConfig()
            for setter in state.assignments do
                setter config
            aws.PinpointSmsChannel.PinpointSmsChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pinpointSmsChannel: missing required arguments. Must call: application_id.", 9999, IsError = true)>]
        member _.Run(_: PinpointSmsChannelState<_>) : aws.PinpointSmsChannel.PinpointSmsChannel =
            Unchecked.defaultof<aws.PinpointSmsChannel.PinpointSmsChannel>
