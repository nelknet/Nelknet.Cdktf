namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PinpointGcmChannelState<'ApplicationId> = { assignments: ResizeArray<aws.PinpointGcmChannel.PinpointGcmChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_gcm_channel">aws_pinpoint_gcm_channel</a>.
    /// </summary>
    type PinpointGcmChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : PinpointGcmChannelState<Missing> =
            ({ assignments = ResizeArray() } : PinpointGcmChannelState<Missing>)

        member _.Zero(()) : PinpointGcmChannelState<Missing> =
            ({ assignments = ResizeArray() } : PinpointGcmChannelState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_gcm_channel#application_id-1">PinpointGcmChannel#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: PinpointGcmChannelState<Missing>, value: string) : PinpointGcmChannelState<Present> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : PinpointGcmChannelState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_gcm_channel#api_key-1">PinpointGcmChannel#api_key</a>.
        /// </summary>
        [<CustomOperation "api_key">]
        member _.ApiKey(state: PinpointGcmChannelState<'ApplicationId>, value: string) : PinpointGcmChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.ApiKey <- value)
            state : PinpointGcmChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_gcm_channel#default_authentication_method-1">PinpointGcmChannel#default_authentication_method</a>.
        /// </summary>
        [<CustomOperation "default_authentication_method">]
        member _.DefaultAuthenticationMethod(state: PinpointGcmChannelState<'ApplicationId>, value: string) : PinpointGcmChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.DefaultAuthenticationMethod <- value)
            state : PinpointGcmChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_gcm_channel#enabled-1">PinpointGcmChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointGcmChannelState<'ApplicationId>, value: bool) : PinpointGcmChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointGcmChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_gcm_channel#enabled-1">PinpointGcmChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointGcmChannelState<'ApplicationId>, value: HashiCorp.Cdktf.IResolvable) : PinpointGcmChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointGcmChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_gcm_channel#id-1">PinpointGcmChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PinpointGcmChannelState<'ApplicationId>, value: string) : PinpointGcmChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PinpointGcmChannelState<'ApplicationId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_gcm_channel#service_json-1">PinpointGcmChannel#service_json</a>.
        /// </summary>
        [<CustomOperation "service_json">]
        member _.ServiceJson(state: PinpointGcmChannelState<'ApplicationId>, value: string) : PinpointGcmChannelState<'ApplicationId> =
            state.assignments.Add(fun config -> config.ServiceJson <- value)
            state : PinpointGcmChannelState<'ApplicationId>

        member _.Run(state: PinpointGcmChannelState<Present>) : aws.PinpointGcmChannel.PinpointGcmChannel =
            let config = aws.PinpointGcmChannel.PinpointGcmChannelConfig()
            for setter in state.assignments do
                setter config
            aws.PinpointGcmChannel.PinpointGcmChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pinpointGcmChannel: missing required arguments. Must call: application_id.", 9999, IsError = true)>]
        member _.Run(_: PinpointGcmChannelState<_>) : aws.PinpointGcmChannel.PinpointGcmChannel =
            Unchecked.defaultof<aws.PinpointGcmChannel.PinpointGcmChannel>
