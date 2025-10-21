namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType> = { assignments: ResizeArray<aws.Pinpointsmsvoicev2PhoneNumber.Pinpointsmsvoicev2PhoneNumberConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number">aws_pinpointsmsvoicev2_phone_number</a>.
    /// </summary>
    type Pinpointsmsvoicev2PhoneNumberBuilder(logicalId: string) =
        member _.Yield(_: unit) : Pinpointsmsvoicev2PhoneNumberState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Pinpointsmsvoicev2PhoneNumberState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : Pinpointsmsvoicev2PhoneNumberState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Pinpointsmsvoicev2PhoneNumberState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#iso_country_code-1">Pinpointsmsvoicev2PhoneNumber#iso_country_code</a>.
        /// </summary>
        [<CustomOperation "iso_country_code">]
        member _.IsoCountryCode(state: Pinpointsmsvoicev2PhoneNumberState<Missing, 'MessageType, 'NumberCapabilities, 'NumberType>, value: string) : Pinpointsmsvoicev2PhoneNumberState<Present, 'MessageType, 'NumberCapabilities, 'NumberType> =
            state.assignments.Add(fun config -> config.IsoCountryCode <- value)
            ({ assignments = state.assignments } : Pinpointsmsvoicev2PhoneNumberState<Present, 'MessageType, 'NumberCapabilities, 'NumberType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#message_type-1">Pinpointsmsvoicev2PhoneNumber#message_type</a>.
        /// </summary>
        [<CustomOperation "message_type">]
        member _.MessageType(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, Missing, 'NumberCapabilities, 'NumberType>, value: string) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, Present, 'NumberCapabilities, 'NumberType> =
            state.assignments.Add(fun config -> config.MessageType <- value)
            ({ assignments = state.assignments } : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, Present, 'NumberCapabilities, 'NumberType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#number_capabilities-1">Pinpointsmsvoicev2PhoneNumber#number_capabilities</a>.
        /// </summary>
        [<CustomOperation "number_capabilities">]
        member _.NumberCapabilities(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, Missing, 'NumberType>, value: seq<string>) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, Present, 'NumberType> =
            state.assignments.Add(fun config -> config.NumberCapabilities <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, Present, 'NumberType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#number_type-1">Pinpointsmsvoicev2PhoneNumber#number_type</a>.
        /// </summary>
        [<CustomOperation "number_type">]
        member _.NumberType(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, Missing>, value: string) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, Present> =
            state.assignments.Add(fun config -> config.NumberType <- value)
            ({ assignments = state.assignments } : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#deletion_protection_enabled-1">Pinpointsmsvoicev2PhoneNumber#deletion_protection_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection_enabled">]
        member _.DeletionProtectionEnabled(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>, value: bool) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType> =
            state.assignments.Add(fun config -> config.DeletionProtectionEnabled <- value)
            state : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#deletion_protection_enabled-1">Pinpointsmsvoicev2PhoneNumber#deletion_protection_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deletion_protection_enabled">]
        member _.DeletionProtectionEnabled(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>, value: HashiCorp.Cdktf.IResolvable) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType> =
            state.assignments.Add(fun config -> config.DeletionProtectionEnabled <- value)
            state : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#opt_out_list_name-1">Pinpointsmsvoicev2PhoneNumber#opt_out_list_name</a>.
        /// </summary>
        [<CustomOperation "opt_out_list_name">]
        member _.OptOutListName(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>, value: string) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType> =
            state.assignments.Add(fun config -> config.OptOutListName <- value)
            state : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#registration_id-1">Pinpointsmsvoicev2PhoneNumber#registration_id</a>.
        /// </summary>
        [<CustomOperation "registration_id">]
        member _.RegistrationId(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>, value: string) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType> =
            state.assignments.Add(fun config -> config.RegistrationId <- value)
            state : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#self_managed_opt_outs_enabled-1">Pinpointsmsvoicev2PhoneNumber#self_managed_opt_outs_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "self_managed_opt_outs_enabled">]
        member _.SelfManagedOptOutsEnabled(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>, value: bool) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType> =
            state.assignments.Add(fun config -> config.SelfManagedOptOutsEnabled <- value)
            state : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#self_managed_opt_outs_enabled-1">Pinpointsmsvoicev2PhoneNumber#self_managed_opt_outs_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "self_managed_opt_outs_enabled">]
        member _.SelfManagedOptOutsEnabled(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>, value: HashiCorp.Cdktf.IResolvable) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType> =
            state.assignments.Add(fun config -> config.SelfManagedOptOutsEnabled <- value)
            state : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#tags-1">Pinpointsmsvoicev2PhoneNumber#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>, value: seq<string * string>) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#timeouts-1">Pinpointsmsvoicev2PhoneNumber#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>, value: aws.Pinpointsmsvoicev2PhoneNumber.Pinpointsmsvoicev2PhoneNumberTimeouts) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#two_way_channel_arn-1">Pinpointsmsvoicev2PhoneNumber#two_way_channel_arn</a>.
        /// </summary>
        [<CustomOperation "two_way_channel_arn">]
        member _.TwoWayChannelArn(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>, value: string) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType> =
            state.assignments.Add(fun config -> config.TwoWayChannelArn <- value)
            state : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#two_way_channel_enabled-1">Pinpointsmsvoicev2PhoneNumber#two_way_channel_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "two_way_channel_enabled">]
        member _.TwoWayChannelEnabled(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>, value: bool) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType> =
            state.assignments.Add(fun config -> config.TwoWayChannelEnabled <- value)
            state : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#two_way_channel_enabled-1">Pinpointsmsvoicev2PhoneNumber#two_way_channel_enabled</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "two_way_channel_enabled">]
        member _.TwoWayChannelEnabled(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>, value: HashiCorp.Cdktf.IResolvable) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType> =
            state.assignments.Add(fun config -> config.TwoWayChannelEnabled <- value)
            state : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/pinpointsmsvoicev2_phone_number#two_way_channel_role-1">Pinpointsmsvoicev2PhoneNumber#two_way_channel_role</a>.
        /// </summary>
        [<CustomOperation "two_way_channel_role">]
        member _.TwoWayChannelRole(state: Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>, value: string) : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType> =
            state.assignments.Add(fun config -> config.TwoWayChannelRole <- value)
            state : Pinpointsmsvoicev2PhoneNumberState<'IsoCountryCode, 'MessageType, 'NumberCapabilities, 'NumberType>

        member _.Run(state: Pinpointsmsvoicev2PhoneNumberState<Present, Present, Present, Present>) : aws.Pinpointsmsvoicev2PhoneNumber.Pinpointsmsvoicev2PhoneNumber =
            let config = aws.Pinpointsmsvoicev2PhoneNumber.Pinpointsmsvoicev2PhoneNumberConfig()
            for setter in state.assignments do
                setter config
            aws.Pinpointsmsvoicev2PhoneNumber.Pinpointsmsvoicev2PhoneNumber(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.pinpointsmsvoicev2PhoneNumber: missing required arguments. Must call: iso_country_code, message_type, number_capabilities, number_type.", 9999, IsError = true)>]
        member _.Run(_: Pinpointsmsvoicev2PhoneNumberState<_, _, _, _>) : aws.Pinpointsmsvoicev2PhoneNumber.Pinpointsmsvoicev2PhoneNumber =
            Unchecked.defaultof<aws.Pinpointsmsvoicev2PhoneNumber.Pinpointsmsvoicev2PhoneNumber>
