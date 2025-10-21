namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PinpointApnsVoipSandboxChannelState<'ApplicationId> = { assignments: ResizeArray<aws.PinpointApnsVoipSandboxChannel.PinpointApnsVoipSandboxChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_sandbox_channel">aws_pinpoint_apns_voip_sandbox_channel</a>.
    /// </summary>
    type PinpointApnsVoipSandboxChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : PinpointApnsVoipSandboxChannelState<Missing> =
            ({ assignments = ResizeArray() } : PinpointApnsVoipSandboxChannelState<Missing>)

        member _.Zero(()) : PinpointApnsVoipSandboxChannelState<Missing> =
            ({ assignments = ResizeArray() } : PinpointApnsVoipSandboxChannelState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_sandbox_channel#application_id-1">PinpointApnsVoipSandboxChannel#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: PinpointApnsVoipSandboxChannelState<Missing>, value: string) : PinpointApnsVoipSandboxChannelState<Present> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : PinpointApnsVoipSandboxChannelState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_sandbox_channel#bundle_id-1">PinpointApnsVoipSandboxChannel#bundle_id</a>.
        /// </summary>
        [<CustomOperation "bundle_id">]
        member _.BundleId(state: PinpointApnsVoipSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsVoipSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.BundleId <- value)
            state : PinpointApnsVoipSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_sandbox_channel#certificate-1">PinpointApnsVoipSandboxChannel#certificate</a>.
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: PinpointApnsVoipSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsVoipSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Certificate <- value)
            state : PinpointApnsVoipSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_sandbox_channel#default_authentication_method-1">PinpointApnsVoipSandboxChannel#default_authentication_method</a>.
        /// </summary>
        [<CustomOperation "default_authentication_method">]
        member _.DefaultAuthenticationMethod(state: PinpointApnsVoipSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsVoipSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.DefaultAuthenticationMethod <- value)
            state : PinpointApnsVoipSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_sandbox_channel#enabled-1">PinpointApnsVoipSandboxChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointApnsVoipSandboxChannelState<'ApplicationId>, value: bool) : PinpointApnsVoipSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointApnsVoipSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_sandbox_channel#enabled-1">PinpointApnsVoipSandboxChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointApnsVoipSandboxChannelState<'ApplicationId>, value: HashiCorp.Cdktf.IResolvable) : PinpointApnsVoipSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointApnsVoipSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_sandbox_channel#id-1">PinpointApnsVoipSandboxChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PinpointApnsVoipSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsVoipSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PinpointApnsVoipSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_sandbox_channel#private_key-1">PinpointApnsVoipSandboxChannel#private_key</a>.
        /// </summary>
        [<CustomOperation "private_key">]
        member _.PrivateKey(state: PinpointApnsVoipSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsVoipSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.PrivateKey <- value)
            state : PinpointApnsVoipSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_sandbox_channel#team_id-1">PinpointApnsVoipSandboxChannel#team_id</a>.
        /// </summary>
        [<CustomOperation "team_id">]
        member _.TeamId(state: PinpointApnsVoipSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsVoipSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.TeamId <- value)
            state : PinpointApnsVoipSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_sandbox_channel#token_key-1">PinpointApnsVoipSandboxChannel#token_key</a>.
        /// </summary>
        [<CustomOperation "token_key">]
        member _.TokenKey(state: PinpointApnsVoipSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsVoipSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.TokenKey <- value)
            state : PinpointApnsVoipSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_voip_sandbox_channel#token_key_id-1">PinpointApnsVoipSandboxChannel#token_key_id</a>.
        /// </summary>
        [<CustomOperation "token_key_id">]
        member _.TokenKeyId(state: PinpointApnsVoipSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsVoipSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.TokenKeyId <- value)
            state : PinpointApnsVoipSandboxChannelState<'ApplicationId>

        member _.Run(state: PinpointApnsVoipSandboxChannelState<Present>) : aws.PinpointApnsVoipSandboxChannel.PinpointApnsVoipSandboxChannel =
            let config = aws.PinpointApnsVoipSandboxChannel.PinpointApnsVoipSandboxChannelConfig()
            for setter in state.assignments do
                setter config
            aws.PinpointApnsVoipSandboxChannel.PinpointApnsVoipSandboxChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pinpointApnsVoipSandboxChannel: missing required arguments. Must call: application_id.", 9999, IsError = true)>]
        member _.Run(_: PinpointApnsVoipSandboxChannelState<_>) : aws.PinpointApnsVoipSandboxChannel.PinpointApnsVoipSandboxChannel =
            Unchecked.defaultof<aws.PinpointApnsVoipSandboxChannel.PinpointApnsVoipSandboxChannel>
