namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GuarddutyInviteAccepterState<'DetectorId, 'MasterAccountId> = { assignments: ResizeArray<aws.GuarddutyInviteAccepter.GuarddutyInviteAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_invite_accepter">aws_guardduty_invite_accepter</a>.
    /// </summary>
    type GuarddutyInviteAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : GuarddutyInviteAccepterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyInviteAccepterState<Missing, Missing>)

        member _.Zero(()) : GuarddutyInviteAccepterState<Missing, Missing> =
            ({ assignments = ResizeArray() } : GuarddutyInviteAccepterState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_invite_accepter#detector_id-1">GuarddutyInviteAccepter#detector_id</a>.
        /// </summary>
        [<CustomOperation "detector_id">]
        member _.DetectorId(state: GuarddutyInviteAccepterState<Missing, 'MasterAccountId>, value: string) : GuarddutyInviteAccepterState<Present, 'MasterAccountId> =
            state.assignments.Add(fun config -> config.DetectorId <- value)
            ({ assignments = state.assignments } : GuarddutyInviteAccepterState<Present, 'MasterAccountId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_invite_accepter#master_account_id-1">GuarddutyInviteAccepter#master_account_id</a>.
        /// </summary>
        [<CustomOperation "master_account_id">]
        member _.MasterAccountId(state: GuarddutyInviteAccepterState<'DetectorId, Missing>, value: string) : GuarddutyInviteAccepterState<'DetectorId, Present> =
            state.assignments.Add(fun config -> config.MasterAccountId <- value)
            ({ assignments = state.assignments } : GuarddutyInviteAccepterState<'DetectorId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_invite_accepter#id-1">GuarddutyInviteAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GuarddutyInviteAccepterState<'DetectorId, 'MasterAccountId>, value: string) : GuarddutyInviteAccepterState<'DetectorId, 'MasterAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GuarddutyInviteAccepterState<'DetectorId, 'MasterAccountId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_invite_accepter#timeouts-1">GuarddutyInviteAccepter#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: GuarddutyInviteAccepterState<'DetectorId, 'MasterAccountId>, value: aws.GuarddutyInviteAccepter.GuarddutyInviteAccepterTimeouts) : GuarddutyInviteAccepterState<'DetectorId, 'MasterAccountId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : GuarddutyInviteAccepterState<'DetectorId, 'MasterAccountId>

        member _.Run(state: GuarddutyInviteAccepterState<Present, Present>) : aws.GuarddutyInviteAccepter.GuarddutyInviteAccepter =
            let config = aws.GuarddutyInviteAccepter.GuarddutyInviteAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.GuarddutyInviteAccepter.GuarddutyInviteAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.guarddutyInviteAccepter: missing required arguments. Must call: detector_id, master_account_id.", 9999, IsError = true)>]
        member _.Run(_: GuarddutyInviteAccepterState<_, _>) : aws.GuarddutyInviteAccepter.GuarddutyInviteAccepter =
            Unchecked.defaultof<aws.GuarddutyInviteAccepter.GuarddutyInviteAccepter>
