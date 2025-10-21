namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GuarddutyMemberState<'AccountId, 'DetectorId, 'Email> = { assignments: ResizeArray<aws.GuarddutyMember.GuarddutyMemberConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member">aws_guardduty_member</a>.
    /// </summary>
    type GuarddutyMemberBuilder(logicalId: string) =
        member _.Yield(_: unit) : GuarddutyMemberState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyMemberState<Missing, Missing, Missing>)

        member _.Zero(()) : GuarddutyMemberState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyMemberState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member#account_id-1">GuarddutyMember#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: GuarddutyMemberState<Missing, 'DetectorId, 'Email>, value: string) : GuarddutyMemberState<Present, 'DetectorId, 'Email> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : GuarddutyMemberState<Present, 'DetectorId, 'Email>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member#detector_id-1">GuarddutyMember#detector_id</a>.
        /// </summary>
        [<CustomOperation "detector_id">]
        member _.DetectorId(state: GuarddutyMemberState<'AccountId, Missing, 'Email>, value: string) : GuarddutyMemberState<'AccountId, Present, 'Email> =
            state.assignments.Add(fun config -> config.DetectorId <- value)
            ({ assignments = state.assignments } : GuarddutyMemberState<'AccountId, Present, 'Email>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member#email-1">GuarddutyMember#email</a>.
        /// </summary>
        [<CustomOperation "email">]
        member _.Email(state: GuarddutyMemberState<'AccountId, 'DetectorId, Missing>, value: string) : GuarddutyMemberState<'AccountId, 'DetectorId, Present> =
            state.assignments.Add(fun config -> config.Email <- value)
            ({ assignments = state.assignments } : GuarddutyMemberState<'AccountId, 'DetectorId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member#disable_email_notification-1">GuarddutyMember#disable_email_notification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_email_notification">]
        member _.DisableEmailNotification(state: GuarddutyMemberState<'AccountId, 'DetectorId, 'Email>, value: bool) : GuarddutyMemberState<'AccountId, 'DetectorId, 'Email> =
            state.assignments.Add(fun config -> config.DisableEmailNotification <- value)
            state : GuarddutyMemberState<'AccountId, 'DetectorId, 'Email>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member#disable_email_notification-1">GuarddutyMember#disable_email_notification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_email_notification">]
        member _.DisableEmailNotification(state: GuarddutyMemberState<'AccountId, 'DetectorId, 'Email>, value: HashiCorp.Cdktf.IResolvable) : GuarddutyMemberState<'AccountId, 'DetectorId, 'Email> =
            state.assignments.Add(fun config -> config.DisableEmailNotification <- value)
            state : GuarddutyMemberState<'AccountId, 'DetectorId, 'Email>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member#id-1">GuarddutyMember#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GuarddutyMemberState<'AccountId, 'DetectorId, 'Email>, value: string) : GuarddutyMemberState<'AccountId, 'DetectorId, 'Email> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GuarddutyMemberState<'AccountId, 'DetectorId, 'Email>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member#invitation_message-1">GuarddutyMember#invitation_message</a>.
        /// </summary>
        [<CustomOperation "invitation_message">]
        member _.InvitationMessage(state: GuarddutyMemberState<'AccountId, 'DetectorId, 'Email>, value: string) : GuarddutyMemberState<'AccountId, 'DetectorId, 'Email> =
            state.assignments.Add(fun config -> config.InvitationMessage <- value)
            state : GuarddutyMemberState<'AccountId, 'DetectorId, 'Email>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member#invite-1">GuarddutyMember#invite</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "invite">]
        member _.Invite(state: GuarddutyMemberState<'AccountId, 'DetectorId, 'Email>, value: bool) : GuarddutyMemberState<'AccountId, 'DetectorId, 'Email> =
            state.assignments.Add(fun config -> config.Invite <- value)
            state : GuarddutyMemberState<'AccountId, 'DetectorId, 'Email>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member#invite-1">GuarddutyMember#invite</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "invite">]
        member _.Invite(state: GuarddutyMemberState<'AccountId, 'DetectorId, 'Email>, value: HashiCorp.Cdktf.IResolvable) : GuarddutyMemberState<'AccountId, 'DetectorId, 'Email> =
            state.assignments.Add(fun config -> config.Invite <- value)
            state : GuarddutyMemberState<'AccountId, 'DetectorId, 'Email>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_member#timeouts-1">GuarddutyMember#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GuarddutyMemberState<'AccountId, 'DetectorId, 'Email>, value: aws.GuarddutyMember.GuarddutyMemberTimeouts) : GuarddutyMemberState<'AccountId, 'DetectorId, 'Email> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GuarddutyMemberState<'AccountId, 'DetectorId, 'Email>

        member _.Run(state: GuarddutyMemberState<Present, Present, Present>) : aws.GuarddutyMember.GuarddutyMember =
            let config = aws.GuarddutyMember.GuarddutyMemberConfig()
            for setter in state.assignments do
                setter config
            aws.GuarddutyMember.GuarddutyMember(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.guarddutyMember: missing required arguments. Must call: account_id, detector_id, email.", 9999, IsError = true)>]
        member _.Run(_: GuarddutyMemberState<_, _, _>) : aws.GuarddutyMember.GuarddutyMember =
            Unchecked.defaultof<aws.GuarddutyMember.GuarddutyMember>
