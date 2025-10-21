namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DetectiveInvitationAccepterState<'GraphArn> = { assignments: ResizeArray<aws.DetectiveInvitationAccepter.DetectiveInvitationAccepterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_invitation_accepter">aws_detective_invitation_accepter</a>.
    /// </summary>
    type DetectiveInvitationAccepterBuilder(logicalId: string) =
        member _.Yield(_: unit) : DetectiveInvitationAccepterState<Missing> =
            ({ assignments = ResizeArray() } : DetectiveInvitationAccepterState<Missing>)

        member _.Zero(()) : DetectiveInvitationAccepterState<Missing> =
            ({ assignments = ResizeArray() } : DetectiveInvitationAccepterState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_invitation_accepter#graph_arn-1">DetectiveInvitationAccepter#graph_arn</a>.
        /// </summary>
        [<CustomOperation "graph_arn">]
        member _.GraphArn(state: DetectiveInvitationAccepterState<Missing>, value: string) : DetectiveInvitationAccepterState<Present> =
            state.assignments.Add(fun config -> config.GraphArn <- value)
            ({ assignments = state.assignments } : DetectiveInvitationAccepterState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_invitation_accepter#id-1">DetectiveInvitationAccepter#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DetectiveInvitationAccepterState<'GraphArn>, value: string) : DetectiveInvitationAccepterState<'GraphArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DetectiveInvitationAccepterState<'GraphArn>

        member _.Run(state: DetectiveInvitationAccepterState<Present>) : aws.DetectiveInvitationAccepter.DetectiveInvitationAccepter =
            let config = aws.DetectiveInvitationAccepter.DetectiveInvitationAccepterConfig()
            for setter in state.assignments do
                setter config
            aws.DetectiveInvitationAccepter.DetectiveInvitationAccepter(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.detectiveInvitationAccepter: missing required arguments. Must call: graph_arn.", 9999, IsError = true)>]
        member _.Run(_: DetectiveInvitationAccepterState<_>) : aws.DetectiveInvitationAccepter.DetectiveInvitationAccepter =
            Unchecked.defaultof<aws.DetectiveInvitationAccepter.DetectiveInvitationAccepter>
