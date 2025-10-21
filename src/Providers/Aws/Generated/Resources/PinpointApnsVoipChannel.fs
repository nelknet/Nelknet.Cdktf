namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PinpointApnsVoipChannelState<'ApplicationId> = { assignments: ResizeArray<aws.PinpointApnsVoipChannel.PinpointApnsVoipChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_channel">aws_pinpoint_apns_voip_channel</a>.
    /// </summary>
    type PinpointApnsVoipChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : PinpointApnsVoipChannelState<Missing> =
            ({ assignments = ResizeArray() } : PinpointApnsVoipChannelState<Missing>)

        member _.Zero(()) : PinpointApnsVoipChannelState<Missing> =
            ({ assignments = ResizeArray() } : PinpointApnsVoipChannelState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_channel#application_id-1">PinpointApnsVoipChannel#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: PinpointApnsVoipChannelState<Missing>, value: string) : PinpointApnsVoipChannelState<Present> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : PinpointApnsVoipChannelState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_channel#bundle_id-1">PinpointApnsVoipChannel#bundle_id</a>.
        /// </summary>
        [<CustomOperation "bundle_id">]
        member _.BundleId(state: PinpointApnsVoipChannelState<'ApplicationId>, value: string) : PinpointApnsVoipChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.BundleId <- value)
            state : PinpointApnsVoipChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_channel#certificate-1">PinpointApnsVoipChannel#certificate</a>.
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: PinpointApnsVoipChannelState<'ApplicationId>, value: string) : PinpointApnsVoipChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Certificate <- value)
            state : PinpointApnsVoipChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_channel#default_authentication_method-1">PinpointApnsVoipChannel#default_authentication_method</a>.
        /// </summary>
        [<CustomOperation "default_authentication_method">]
        member _.DefaultAuthenticationMethod(state: PinpointApnsVoipChannelState<'ApplicationId>, value: string) : PinpointApnsVoipChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.DefaultAuthenticationMethod <- value)
            state : PinpointApnsVoipChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_channel#enabled-1">PinpointApnsVoipChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointApnsVoipChannelState<'ApplicationId>, value: bool) : PinpointApnsVoipChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointApnsVoipChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_channel#enabled-1">PinpointApnsVoipChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointApnsVoipChannelState<'ApplicationId>, value: HashiCorp.Cdktf.IResolvable) : PinpointApnsVoipChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointApnsVoipChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_channel#id-1">PinpointApnsVoipChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PinpointApnsVoipChannelState<'ApplicationId>, value: string) : PinpointApnsVoipChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PinpointApnsVoipChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_channel#private_key-1">PinpointApnsVoipChannel#private_key</a>.
        /// </summary>
        [<CustomOperation "private_key">]
        member _.PrivateKey(state: PinpointApnsVoipChannelState<'ApplicationId>, value: string) : PinpointApnsVoipChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.PrivateKey <- value)
            state : PinpointApnsVoipChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_channel#team_id-1">PinpointApnsVoipChannel#team_id</a>.
        /// </summary>
        [<CustomOperation "team_id">]
        member _.TeamId(state: PinpointApnsVoipChannelState<'ApplicationId>, value: string) : PinpointApnsVoipChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.TeamId <- value)
            state : PinpointApnsVoipChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_channel#token_key-1">PinpointApnsVoipChannel#token_key</a>.
        /// </summary>
        [<CustomOperation "token_key">]
        member _.TokenKey(state: PinpointApnsVoipChannelState<'ApplicationId>, value: string) : PinpointApnsVoipChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.TokenKey <- value)
            state : PinpointApnsVoipChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_channel#token_key_id-1">PinpointApnsVoipChannel#token_key_id</a>.
        /// </summary>
        [<CustomOperation "token_key_id">]
        member _.TokenKeyId(state: PinpointApnsVoipChannelState<'ApplicationId>, value: string) : PinpointApnsVoipChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.TokenKeyId <- value)
            state : PinpointApnsVoipChannelState<'ApplicationId>

        member _.Run(state: PinpointApnsVoipChannelState<Present>) : aws.PinpointApnsVoipChannel.PinpointApnsVoipChannel =
            let config = aws.PinpointApnsVoipChannel.PinpointApnsVoipChannelConfig()
            for setter in state.assignments do
                setter config
            aws.PinpointApnsVoipChannel.PinpointApnsVoipChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pinpointApnsVoipChannel: missing required arguments. Must call: application_id.", 9999, IsError = true)>]
        member _.Run(_: PinpointApnsVoipChannelState<_>) : aws.PinpointApnsVoipChannel.PinpointApnsVoipChannel =
            Unchecked.defaultof<aws.PinpointApnsVoipChannel.PinpointApnsVoipChannel>
