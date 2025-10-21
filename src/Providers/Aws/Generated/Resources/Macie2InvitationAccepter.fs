namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Macie2InvitationAccepterState<'AdministratorAccountId> = { assignments: ResizeArray<aws.Macie2InvitationAccepter.Macie2InvitationAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_invitation_accepter">aws_macie2_invitation_accepter</a>.
    /// </summary>
    type Macie2InvitationAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : Macie2InvitationAccepterState<Missing> =
            ({ assignments = ResizeArray() } : Macie2InvitationAccepterState<Missing>)

        member _.Zero(()) : Macie2InvitationAccepterState<Missing> =
            ({ assignments = ResizeArray() } : Macie2InvitationAccepterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_invitation_accepter#administrator_account_id-1">Macie2InvitationAccepter#administrator_account_id</a>.
        /// </summary>
        [<CustomOperation "administrator_account_id">]
        member _.AdministratorAccountId(state: Macie2InvitationAccepterState<Missing>, value: string) : Macie2InvitationAccepterState<Present> =
            state.assignments.Add(fun config -> config.AdministratorAccountId <- value)
            ({ assignments = state.assignments } : Macie2InvitationAccepterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_invitation_accepter#id-1">Macie2InvitationAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Macie2InvitationAccepterState<'AdministratorAccountId>, value: string) : Macie2InvitationAccepterState<'AdministratorAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Macie2InvitationAccepterState<'AdministratorAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_invitation_accepter#timeouts-1">Macie2InvitationAccepter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Macie2InvitationAccepterState<'AdministratorAccountId>, value: aws.Macie2InvitationAccepter.Macie2InvitationAccepterTimeouts) : Macie2InvitationAccepterState<'AdministratorAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Macie2InvitationAccepterState<'AdministratorAccountId>

        member _.Run(state: Macie2InvitationAccepterState<Present>) : aws.Macie2InvitationAccepter.Macie2InvitationAccepter =
            let config = aws.Macie2InvitationAccepter.Macie2InvitationAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.Macie2InvitationAccepter.Macie2InvitationAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.macie2InvitationAccepter: missing required arguments. Must call: administrator_account_id.", 9999, IsError = true)>]
        member _.Run(_: Macie2InvitationAccepterState<_>) : aws.Macie2InvitationAccepter.Macie2InvitationAccepter =
            Unchecked.defaultof<aws.Macie2InvitationAccepter.Macie2InvitationAccepter>
