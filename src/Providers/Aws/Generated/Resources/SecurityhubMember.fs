namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubMemberState<'AccountId> = { assignments: ResizeArray<aws.SecurityhubMember.SecurityhubMemberConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_member">aws_securityhub_member</a>.
    /// </summary>
    type SecurityhubMemberBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubMemberState<Missing> =
            ({ assignments = ResizeArray() } : SecurityhubMemberState<Missing>)

        member _.Zero(()) : SecurityhubMemberState<Missing> =
            ({ assignments = ResizeArray() } : SecurityhubMemberState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_member#account_id-1">SecurityhubMember#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: SecurityhubMemberState<Missing>, value: string) : SecurityhubMemberState<Present> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : SecurityhubMemberState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_member#email-1">SecurityhubMember#email</a>.
        /// </summary>
        [<CustomOperation "email">]
        member _.Email(state: SecurityhubMemberState<'AccountId>, value: string) : SecurityhubMemberState<'AccountId> =
            state.assignments.Add(fun config -> config.Email <- value)
            state : SecurityhubMemberState<'AccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_member#id-1">SecurityhubMember#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityhubMemberState<'AccountId>, value: string) : SecurityhubMemberState<'AccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityhubMemberState<'AccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_member#invite-1">SecurityhubMember#invite</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "invite">]
        member _.Invite(state: SecurityhubMemberState<'AccountId>, value: bool) : SecurityhubMemberState<'AccountId> =
            state.assignments.Add(fun config -> config.Invite <- value)
            state : SecurityhubMemberState<'AccountId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_member#invite-1">SecurityhubMember#invite</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "invite">]
        member _.Invite(state: SecurityhubMemberState<'AccountId>, value: HashiCorp.Cdktf.IResolvable) : SecurityhubMemberState<'AccountId> =
            state.assignments.Add(fun config -> config.Invite <- value)
            state : SecurityhubMemberState<'AccountId>

        member _.Run(state: SecurityhubMemberState<Present>) : aws.SecurityhubMember.SecurityhubMember =
            let config = aws.SecurityhubMember.SecurityhubMemberConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubMember.SecurityhubMember(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityhubMember: missing required arguments. Must call: account_id.", 9999, IsError = true)>]
        member _.Run(_: SecurityhubMemberState<_>) : aws.SecurityhubMember.SecurityhubMember =
            Unchecked.defaultof<aws.SecurityhubMember.SecurityhubMember>
