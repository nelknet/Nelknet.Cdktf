namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PinpointAdmChannelState<'ApplicationId, 'ClientId, 'ClientSecret> = { assignments: ResizeArray<aws.PinpointAdmChannel.PinpointAdmChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_adm_channel">aws_pinpoint_adm_channel</a>.
    /// </summary>
    type PinpointAdmChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : PinpointAdmChannelState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PinpointAdmChannelState<Missing, Missing, Missing>)

        member _.Zero(()) : PinpointAdmChannelState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PinpointAdmChannelState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_adm_channel#application_id-1">PinpointAdmChannel#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: PinpointAdmChannelState<Missing, 'ClientId, 'ClientSecret>, value: string) : PinpointAdmChannelState<Present, 'ClientId, 'ClientSecret> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : PinpointAdmChannelState<Present, 'ClientId, 'ClientSecret>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_adm_channel#client_id-1">PinpointAdmChannel#client_id</a>.
        /// </summary>
        [<CustomOperation "client_id">]
        member _.ClientId(state: PinpointAdmChannelState<'ApplicationId, Missing, 'ClientSecret>, value: string) : PinpointAdmChannelState<'ApplicationId, Present, 'ClientSecret> =
            state.assignments.Add(fun config -> config.ClientId <- value)
            ({ assignments = state.assignments } : PinpointAdmChannelState<'ApplicationId, Present, 'ClientSecret>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_adm_channel#client_secret-1">PinpointAdmChannel#client_secret</a>.
        /// </summary>
        [<CustomOperation "client_secret">]
        member _.ClientSecret(state: PinpointAdmChannelState<'ApplicationId, 'ClientId, Missing>, value: string) : PinpointAdmChannelState<'ApplicationId, 'ClientId, Present> =
            state.assignments.Add(fun config -> config.ClientSecret <- value)
            ({ assignments = state.assignments } : PinpointAdmChannelState<'ApplicationId, 'ClientId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_adm_channel#enabled-1">PinpointAdmChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointAdmChannelState<'ApplicationId, 'ClientId, 'ClientSecret>, value: bool) : PinpointAdmChannelState<'ApplicationId, 'ClientId, 'ClientSecret> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointAdmChannelState<'ApplicationId, 'ClientId, 'ClientSecret>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_adm_channel#enabled-1">PinpointAdmChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointAdmChannelState<'ApplicationId, 'ClientId, 'ClientSecret>, value: HashiCorp.Cdktf.IResolvable) : PinpointAdmChannelState<'ApplicationId, 'ClientId, 'ClientSecret> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointAdmChannelState<'ApplicationId, 'ClientId, 'ClientSecret>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_adm_channel#id-1">PinpointAdmChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PinpointAdmChannelState<'ApplicationId, 'ClientId, 'ClientSecret>, value: string) : PinpointAdmChannelState<'ApplicationId, 'ClientId, 'ClientSecret> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PinpointAdmChannelState<'ApplicationId, 'ClientId, 'ClientSecret>

        member _.Run(state: PinpointAdmChannelState<Present, Present, Present>) : aws.PinpointAdmChannel.PinpointAdmChannel =
            let config = aws.PinpointAdmChannel.PinpointAdmChannelConfig()
            for setter in state.assignments do
                setter config
            aws.PinpointAdmChannel.PinpointAdmChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pinpointAdmChannel: missing required arguments. Must call: application_id, client_id, client_secret.", 9999, IsError = true)>]
        member _.Run(_: PinpointAdmChannelState<_, _, _>) : aws.PinpointAdmChannel.PinpointAdmChannel =
            Unchecked.defaultof<aws.PinpointAdmChannel.PinpointAdmChannel>
