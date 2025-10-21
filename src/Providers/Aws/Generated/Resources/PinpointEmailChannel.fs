namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity> = { assignments: ResizeArray<aws.PinpointEmailChannel.PinpointEmailChannelConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_channel">aws_pinpoint_email_channel</a>.
    /// </summary>
    type PinpointEmailChannelBuilder(logicalId: string) =
        member _.Yield(_: unit) : PinpointEmailChannelState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PinpointEmailChannelState<Missing, Missing, Missing>)

        member _.Zero(()) : PinpointEmailChannelState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : PinpointEmailChannelState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_channel#application_id-1">PinpointEmailChannel#application_id</a>.
        /// </summary>
        [<CustomOperation "application_id">]
        member _.ApplicationId(state: PinpointEmailChannelState<Missing, 'FromAddress, 'Identity>, value: string) : PinpointEmailChannelState<Present, 'FromAddress, 'Identity> =
            state.assignments.Add(fun config -> config.ApplicationId <- value)
            ({ assignments = state.assignments } : PinpointEmailChannelState<Present, 'FromAddress, 'Identity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_channel#from_address-1">PinpointEmailChannel#from_address</a>.
        /// </summary>
        [<CustomOperation "from_address">]
        member _.FromAddress(state: PinpointEmailChannelState<'ApplicationId, Missing, 'Identity>, value: string) : PinpointEmailChannelState<'ApplicationId, Present, 'Identity> =
            state.assignments.Add(fun config -> config.FromAddress <- value)
            ({ assignments = state.assignments } : PinpointEmailChannelState<'ApplicationId, Present, 'Identity>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_channel#identity-1">PinpointEmailChannel#identity</a>.
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: PinpointEmailChannelState<'ApplicationId, 'FromAddress, Missing>, value: string) : PinpointEmailChannelState<'ApplicationId, 'FromAddress, Present> =
            state.assignments.Add(fun config -> config.Identity <- value)
            ({ assignments = state.assignments } : PinpointEmailChannelState<'ApplicationId, 'FromAddress, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_channel#configuration_set-1">PinpointEmailChannel#configuration_set</a>.
        /// </summary>
        [<CustomOperation "configuration_set">]
        member _.ConfigurationSet(state: PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity>, value: string) : PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity> =
            state.assignments.Add(fun config -> config.ConfigurationSet <- value)
            state : PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_channel#enabled-1">PinpointEmailChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity>, value: bool) : PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_channel#enabled-1">PinpointEmailChannel#enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "enabled">]
        member _.Enabled(state: PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity>, value: HashiCorp.Cdktf.IResolvable) : PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity> =
            state.assignments.Add(fun config -> config.Enabled <- value)
            state : PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_channel#id-1">PinpointEmailChannel#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity>, value: string) : PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_channel#orchestration_sending_role_arn-1">PinpointEmailChannel#orchestration_sending_role_arn</a>.
        /// </summary>
        [<CustomOperation "orchestration_sending_role_arn">]
        member _.OrchestrationSendingRoleArn(state: PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity>, value: string) : PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity> =
            state.assignments.Add(fun config -> config.OrchestrationSendingRoleArn <- value)
            state : PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpoint_email_channel#role_arn-1">PinpointEmailChannel#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity>, value: string) : PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            state : PinpointEmailChannelState<'ApplicationId, 'FromAddress, 'Identity>

        member _.Run(state: PinpointEmailChannelState<Present, Present, Present>) : aws.PinpointEmailChannel.PinpointEmailChannel =
            let config = aws.PinpointEmailChannel.PinpointEmailChannelConfig()
            for setter in state.assignments do
                setter config
            aws.PinpointEmailChannel.PinpointEmailChannel(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pinpointEmailChannel: missing required arguments. Must call: application_id, from_address, identity.", 9999, IsError = true)>]
        member _.Run(_: PinpointEmailChannelState<_, _, _>) : aws.PinpointEmailChannel.PinpointEmailChannel =
            Unchecked.defaultof<aws.PinpointEmailChannel.PinpointEmailChannel>
