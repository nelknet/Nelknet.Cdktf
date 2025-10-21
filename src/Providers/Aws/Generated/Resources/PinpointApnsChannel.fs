namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PinpointApnsChannelState<'ApplicationId> = { assignments: ResizeArray<aws.PinpointApnsChannel.PinpointApnsChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_channel">aws_pinpoint_apns_channel</a>.
    /// </summary>
    type PinpointApnsChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : PinpointApnsChannelState<Missing> =
            ({ assignments = ResizeArray() } : PinpointApnsChannelState<Missing>)

        member _.Zero(()) : PinpointApnsChannelState<Missing> =
            ({ assignments = ResizeArray() } : PinpointApnsChannelState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_channel#application_id-1">PinpointApnsChannel#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: PinpointApnsChannelState<Missing>, value: string) : PinpointApnsChannelState<Present> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : PinpointApnsChannelState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_channel#bundle_id-1">PinpointApnsChannel#bundle_id</a>.
        /// </summary>
        [<CustomOperation "bundle_id">]
        member _.BundleId(state: PinpointApnsChannelState<'ApplicationId>, value: string) : PinpointApnsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.BundleId <- value)
            state : PinpointApnsChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_channel#certificate-1">PinpointApnsChannel#certificate</a>.
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: PinpointApnsChannelState<'ApplicationId>, value: string) : PinpointApnsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Certificate <- value)
            state : PinpointApnsChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_channel#default_authentication_method-1">PinpointApnsChannel#default_authentication_method</a>.
        /// </summary>
        [<CustomOperation "default_authentication_method">]
        member _.DefaultAuthenticationMethod(state: PinpointApnsChannelState<'ApplicationId>, value: string) : PinpointApnsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.DefaultAuthenticationMethod <- value)
            state : PinpointApnsChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_channel#enabled-1">PinpointApnsChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointApnsChannelState<'ApplicationId>, value: bool) : PinpointApnsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointApnsChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_channel#enabled-1">PinpointApnsChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointApnsChannelState<'ApplicationId>, value: HashiCorp.Cdktf.IResolvable) : PinpointApnsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointApnsChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_channel#id-1">PinpointApnsChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PinpointApnsChannelState<'ApplicationId>, value: string) : PinpointApnsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PinpointApnsChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_channel#private_key-1">PinpointApnsChannel#private_key</a>.
        /// </summary>
        [<CustomOperation "private_key">]
        member _.PrivateKey(state: PinpointApnsChannelState<'ApplicationId>, value: string) : PinpointApnsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.PrivateKey <- value)
            state : PinpointApnsChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_channel#team_id-1">PinpointApnsChannel#team_id</a>.
        /// </summary>
        [<CustomOperation "team_id">]
        member _.TeamId(state: PinpointApnsChannelState<'ApplicationId>, value: string) : PinpointApnsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.TeamId <- value)
            state : PinpointApnsChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_channel#token_key-1">PinpointApnsChannel#token_key</a>.
        /// </summary>
        [<CustomOperation "token_key">]
        member _.TokenKey(state: PinpointApnsChannelState<'ApplicationId>, value: string) : PinpointApnsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.TokenKey <- value)
            state : PinpointApnsChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_apns_channel#token_key_id-1">PinpointApnsChannel#token_key_id</a>.
        /// </summary>
        [<CustomOperation "token_key_id">]
        member _.TokenKeyId(state: PinpointApnsChannelState<'ApplicationId>, value: string) : PinpointApnsChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.TokenKeyId <- value)
            state : PinpointApnsChannelState<'ApplicationId>

        member _.Run(state: PinpointApnsChannelState<Present>) : aws.PinpointApnsChannel.PinpointApnsChannel =
            let config = aws.PinpointApnsChannel.PinpointApnsChannelConfig()
            for setter in state.assignments do
                setter config
            aws.PinpointApnsChannel.PinpointApnsChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pinpointApnsChannel: missing required arguments. Must call: application_id.", 9999, IsError = true)>]
        member _.Run(_: PinpointApnsChannelState<_>) : aws.PinpointApnsChannel.PinpointApnsChannel =
            Unchecked.defaultof<aws.PinpointApnsChannel.PinpointApnsChannel>
