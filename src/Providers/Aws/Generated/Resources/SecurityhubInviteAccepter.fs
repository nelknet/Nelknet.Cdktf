namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubInviteAccepterState<'MasterId> = { assignments: ResizeArray<aws.SecurityhubInviteAccepter.SecurityhubInviteAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_invite_accepter">aws_securityhub_invite_accepter</a>.
    /// </summary>
    type SecurityhubInviteAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubInviteAccepterState<Missing> =
            ({ assignments = ResizeArray() } : SecurityhubInviteAccepterState<Missing>)

        member _.Zero(()) : SecurityhubInviteAccepterState<Missing> =
            ({ assignments = ResizeArray() } : SecurityhubInviteAccepterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_invite_accepter#master_id-1">SecurityhubInviteAccepter#master_id</a>.
        /// </summary>
        [<CustomOperation "master_id">]
        member _.MasterId(state: SecurityhubInviteAccepterState<Missing>, value: string) : SecurityhubInviteAccepterState<Present> =
            state.assignments.Add(fun config -> config.MasterId <- value)
            ({ assignments = state.assignments } : SecurityhubInviteAccepterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_invite_accepter#id-1">SecurityhubInviteAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityhubInviteAccepterState<'MasterId>, value: string) : SecurityhubInviteAccepterState<'MasterId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityhubInviteAccepterState<'MasterId>

        member _.Run(state: SecurityhubInviteAccepterState<Present>) : aws.SecurityhubInviteAccepter.SecurityhubInviteAccepter =
            let config = aws.SecurityhubInviteAccepter.SecurityhubInviteAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubInviteAccepter.SecurityhubInviteAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityhubInviteAccepter: missing required arguments. Must call: master_id.", 9999, IsError = true)>]
        member _.Run(_: SecurityhubInviteAccepterState<_>) : aws.SecurityhubInviteAccepter.SecurityhubInviteAccepter =
            Unchecked.defaultof<aws.SecurityhubInviteAccepter.SecurityhubInviteAccepter>
