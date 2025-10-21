namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Macie2MemberState<'AccountId, 'Email> = { assignments: ResizeArray<aws.Macie2Member.Macie2MemberConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_member">aws_macie2_member</a>.
    /// </summary>
    type Macie2MemberBuilder(logicalId: string) =
        member _.Yield(_: unit) : Macie2MemberState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Macie2MemberState<Missing, Missing>)

        member _.Zero(()) : Macie2MemberState<Missing, Missing> =
            ({ assignments = ResizeArray() } : Macie2MemberState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_member#account_id-1">Macie2Member#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: Macie2MemberState<Missing, 'Email>, value: string) : Macie2MemberState<Present, 'Email> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : Macie2MemberState<Present, 'Email>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_member#email-1">Macie2Member#email</a>.
        /// </summary>
        [<CustomOperation "email">]
        member _.Email(state: Macie2MemberState<'AccountId, Missing>, value: string) : Macie2MemberState<'AccountId, Present> =
            state.assignments.Add(fun config -> config.Email <- value)
            ({ assignments = state.assignments } : Macie2MemberState<'AccountId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_member#id-1">Macie2Member#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Macie2MemberState<'AccountId, 'Email>, value: string) : Macie2MemberState<'AccountId, 'Email> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Macie2MemberState<'AccountId, 'Email>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_member#invitation_disable_email_notification-1">Macie2Member#invitation_disable_email_notification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "invitation_disable_email_notification">]
        member _.InvitationDisableEmailNotification(state: Macie2MemberState<'AccountId, 'Email>, value: bool) : Macie2MemberState<'AccountId, 'Email> =
            state.assignments.Add(fun config -> config.InvitationDisableEmailNotification <- value)
            state : Macie2MemberState<'AccountId, 'Email>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_member#invitation_disable_email_notification-1">Macie2Member#invitation_disable_email_notification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "invitation_disable_email_notification">]
        member _.InvitationDisableEmailNotification(state: Macie2MemberState<'AccountId, 'Email>, value: HashiCorp.Cdktf.IResolvable) : Macie2MemberState<'AccountId, 'Email> =
            state.assignments.Add(fun config -> config.InvitationDisableEmailNotification <- value)
            state : Macie2MemberState<'AccountId, 'Email>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_member#invitation_message-1">Macie2Member#invitation_message</a>.
        /// </summary>
        [<CustomOperation "invitation_message">]
        member _.InvitationMessage(state: Macie2MemberState<'AccountId, 'Email>, value: string) : Macie2MemberState<'AccountId, 'Email> =
            state.assignments.Add(fun config -> config.InvitationMessage <- value)
            state : Macie2MemberState<'AccountId, 'Email>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_member#invite-1">Macie2Member#invite</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "invite">]
        member _.Invite(state: Macie2MemberState<'AccountId, 'Email>, value: bool) : Macie2MemberState<'AccountId, 'Email> =
            state.assignments.Add(fun config -> config.Invite <- value)
            state : Macie2MemberState<'AccountId, 'Email>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_member#invite-1">Macie2Member#invite</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "invite">]
        member _.Invite(state: Macie2MemberState<'AccountId, 'Email>, value: HashiCorp.Cdktf.IResolvable) : Macie2MemberState<'AccountId, 'Email> =
            state.assignments.Add(fun config -> config.Invite <- value)
            state : Macie2MemberState<'AccountId, 'Email>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_member#status-1">Macie2Member#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: Macie2MemberState<'AccountId, 'Email>, value: string) : Macie2MemberState<'AccountId, 'Email> =
            state.assignments.Add(fun config -> config.Status <- value)
            state : Macie2MemberState<'AccountId, 'Email>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_member#tags-1">Macie2Member#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Macie2MemberState<'AccountId, 'Email>, value: seq<string * string>) : Macie2MemberState<'AccountId, 'Email> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Macie2MemberState<'AccountId, 'Email>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_member#tags_all-1">Macie2Member#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Macie2MemberState<'AccountId, 'Email>, value: seq<string * string>) : Macie2MemberState<'AccountId, 'Email> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Macie2MemberState<'AccountId, 'Email>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_member#timeouts-1">Macie2Member#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Macie2MemberState<'AccountId, 'Email>, value: aws.Macie2Member.Macie2MemberTimeouts) : Macie2MemberState<'AccountId, 'Email> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Macie2MemberState<'AccountId, 'Email>

        member _.Run(state: Macie2MemberState<Present, Present>) : aws.Macie2Member.Macie2Member =
            let config = aws.Macie2Member.Macie2MemberConfig()
            for setter in state.assignments do
                setter config
            aws.Macie2Member.Macie2Member(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.macie2Member: missing required arguments. Must call: account_id, email.", 9999, IsError = true)>]
        member _.Run(_: Macie2MemberState<_, _>) : aws.Macie2Member.Macie2Member =
            Unchecked.defaultof<aws.Macie2Member.Macie2Member>
