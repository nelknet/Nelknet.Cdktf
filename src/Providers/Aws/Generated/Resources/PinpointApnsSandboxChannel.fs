namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PinpointApnsSandboxChannelState<'ApplicationId> = { assignments: ResizeArray<aws.PinpointApnsSandboxChannel.PinpointApnsSandboxChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_sandbox_channel">aws_pinpoint_apns_sandbox_channel</a>.
    /// </summary>
    type PinpointApnsSandboxChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : PinpointApnsSandboxChannelState<Missing> =
            ({ assignments = ResizeArray() } : PinpointApnsSandboxChannelState<Missing>)

        member _.Zero(()) : PinpointApnsSandboxChannelState<Missing> =
            ({ assignments = ResizeArray() } : PinpointApnsSandboxChannelState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_sandbox_channel#application_id-1">PinpointApnsSandboxChannel#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: PinpointApnsSandboxChannelState<Missing>, value: string) : PinpointApnsSandboxChannelState<Present> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : PinpointApnsSandboxChannelState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_sandbox_channel#bundle_id-1">PinpointApnsSandboxChannel#bundle_id</a>.
        /// </summary>
        [<CustomOperation "bundle_id">]
        member _.BundleId(state: PinpointApnsSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.BundleId <- value)
            state : PinpointApnsSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_sandbox_channel#certificate-1">PinpointApnsSandboxChannel#certificate</a>.
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: PinpointApnsSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Certificate <- value)
            state : PinpointApnsSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_sandbox_channel#default_authentication_method-1">PinpointApnsSandboxChannel#default_authentication_method</a>.
        /// </summary>
        [<CustomOperation "default_authentication_method">]
        member _.DefaultAuthenticationMethod(state: PinpointApnsSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.DefaultAuthenticationMethod <- value)
            state : PinpointApnsSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_sandbox_channel#enabled-1">PinpointApnsSandboxChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointApnsSandboxChannelState<'ApplicationId>, value: bool) : PinpointApnsSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointApnsSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_sandbox_channel#enabled-1">PinpointApnsSandboxChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointApnsSandboxChannelState<'ApplicationId>, value: HashiCorp.Cdktf.IResolvable) : PinpointApnsSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointApnsSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_sandbox_channel#id-1">PinpointApnsSandboxChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PinpointApnsSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PinpointApnsSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_sandbox_channel#private_key-1">PinpointApnsSandboxChannel#private_key</a>.
        /// </summary>
        [<CustomOperation "private_key">]
        member _.PrivateKey(state: PinpointApnsSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.PrivateKey <- value)
            state : PinpointApnsSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_sandbox_channel#team_id-1">PinpointApnsSandboxChannel#team_id</a>.
        /// </summary>
        [<CustomOperation "team_id">]
        member _.TeamId(state: PinpointApnsSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.TeamId <- value)
            state : PinpointApnsSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_sandbox_channel#token_key-1">PinpointApnsSandboxChannel#token_key</a>.
        /// </summary>
        [<CustomOperation "token_key">]
        member _.TokenKey(state: PinpointApnsSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.TokenKey <- value)
            state : PinpointApnsSandboxChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_sandbox_channel#token_key_id-1">PinpointApnsSandboxChannel#token_key_id</a>.
        /// </summary>
        [<CustomOperation "token_key_id">]
        member _.TokenKeyId(state: PinpointApnsSandboxChannelState<'ApplicationId>, value: string) : PinpointApnsSandboxChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.TokenKeyId <- value)
            state : PinpointApnsSandboxChannelState<'ApplicationId>

        member _.Run(state: PinpointApnsSandboxChannelState<Present>) : aws.PinpointApnsSandboxChannel.PinpointApnsSandboxChannel =
            let config = aws.PinpointApnsSandboxChannel.PinpointApnsSandboxChannelConfig()
            for setter in state.assignments do
                setter config
            aws.PinpointApnsSandboxChannel.PinpointApnsSandboxChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pinpointApnsSandboxChannel: missing required arguments. Must call: application_id.", 9999, IsError = true)>]
        member _.Run(_: PinpointApnsSandboxChannelState<_>) : aws.PinpointApnsSandboxChannel.PinpointApnsSandboxChannel =
            Unchecked.defaultof<aws.PinpointApnsSandboxChannel.PinpointApnsSandboxChannel>
