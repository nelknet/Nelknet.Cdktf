namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DetectiveMemberState<'AccountId, 'EmailAddress, 'GraphArn> = { assignments: ResizeArray<aws.DetectiveMember.DetectiveMemberConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_member">aws_detective_member</a>.
    /// </summary>
    type DetectiveMemberBuilder(logicalId: string) =
        member _.Yield(_: unit) : DetectiveMemberState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DetectiveMemberState<Missing, Missing, Missing>)

        member _.Zero(()) : DetectiveMemberState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DetectiveMemberState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_member#account_id-1">DetectiveMember#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: DetectiveMemberState<Missing, 'EmailAddress, 'GraphArn>, value: string) : DetectiveMemberState<Present, 'EmailAddress, 'GraphArn> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : DetectiveMemberState<Present, 'EmailAddress, 'GraphArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_member#email_address-1">DetectiveMember#email_address</a>.
        /// </summary>
        [<CustomOperation "email_address">]
        member _.EmailAddress(state: DetectiveMemberState<'AccountId, Missing, 'GraphArn>, value: string) : DetectiveMemberState<'AccountId, Present, 'GraphArn> =
            state.assignments.Add(fun config -> config.EmailAddress <- value)
            ({ assignments = state.assignments } : DetectiveMemberState<'AccountId, Present, 'GraphArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_member#graph_arn-1">DetectiveMember#graph_arn</a>.
        /// </summary>
        [<CustomOperation "graph_arn">]
        member _.GraphArn(state: DetectiveMemberState<'AccountId, 'EmailAddress, Missing>, value: string) : DetectiveMemberState<'AccountId, 'EmailAddress, Present> =
            state.assignments.Add(fun config -> config.GraphArn <- value)
            ({ assignments = state.assignments } : DetectiveMemberState<'AccountId, 'EmailAddress, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_member#disable_email_notification-1">DetectiveMember#disable_email_notification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_email_notification">]
        member _.DisableEmailNotification(state: DetectiveMemberState<'AccountId, 'EmailAddress, 'GraphArn>, value: bool) : DetectiveMemberState<'AccountId, 'EmailAddress, 'GraphArn> =
            state.assignments.Add(fun config -> config.DisableEmailNotification <- value)
            state : DetectiveMemberState<'AccountId, 'EmailAddress, 'GraphArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_member#disable_email_notification-1">DetectiveMember#disable_email_notification</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "disable_email_notification">]
        member _.DisableEmailNotification(state: DetectiveMemberState<'AccountId, 'EmailAddress, 'GraphArn>, value: HashiCorp.Cdktf.IResolvable) : DetectiveMemberState<'AccountId, 'EmailAddress, 'GraphArn> =
            state.assignments.Add(fun config -> config.DisableEmailNotification <- value)
            state : DetectiveMemberState<'AccountId, 'EmailAddress, 'GraphArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_member#id-1">DetectiveMember#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DetectiveMemberState<'AccountId, 'EmailAddress, 'GraphArn>, value: string) : DetectiveMemberState<'AccountId, 'EmailAddress, 'GraphArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DetectiveMemberState<'AccountId, 'EmailAddress, 'GraphArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_member#message-1">DetectiveMember#message</a>.
        /// </summary>
        [<CustomOperation "message">]
        member _.Message(state: DetectiveMemberState<'AccountId, 'EmailAddress, 'GraphArn>, value: string) : DetectiveMemberState<'AccountId, 'EmailAddress, 'GraphArn> =
            state.assignments.Add(fun config -> config.Message <- value)
            state : DetectiveMemberState<'AccountId, 'EmailAddress, 'GraphArn>

        member _.Run(state: DetectiveMemberState<Present, Present, Present>) : aws.DetectiveMember.DetectiveMember =
            let config = aws.DetectiveMember.DetectiveMemberConfig()
            for setter in state.assignments do
                setter config
            aws.DetectiveMember.DetectiveMember(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.detectiveMember: missing required arguments. Must call: account_id, email_address, graph_arn.", 9999, IsError = true)>]
        member _.Run(_: DetectiveMemberState<_, _, _>) : aws.DetectiveMember.DetectiveMember =
            Unchecked.defaultof<aws.DetectiveMember.DetectiveMember>
