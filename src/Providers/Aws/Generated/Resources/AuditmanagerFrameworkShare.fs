namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AuditmanagerFrameworkShareState<'DestinationAccount, 'DestinationRegion, 'FrameworkId> = { assignments: ResizeArray<aws.AuditmanagerFrameworkShare.AuditmanagerFrameworkShareConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework_share">aws_auditmanager_framework_share</a>.
    /// </summary>
    type AuditmanagerFrameworkShareBuilder(logicalId: string) =
        member _.Yield(_: unit) : AuditmanagerFrameworkShareState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AuditmanagerFrameworkShareState<Missing, Missing, Missing>)

        member _.Zero(()) : AuditmanagerFrameworkShareState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AuditmanagerFrameworkShareState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework_share#destination_account-1">AuditmanagerFrameworkShare#destination_account</a>.
        /// </summary>
        [<CustomOperation "destination_account">]
        member _.DestinationAccount(state: AuditmanagerFrameworkShareState<Missing, 'DestinationRegion, 'FrameworkId>, value: string) : AuditmanagerFrameworkShareState<Present, 'DestinationRegion, 'FrameworkId> =
            state.assignments.Add(fun config -> config.DestinationAccount <- value)
            ({ assignments = state.assignments } : AuditmanagerFrameworkShareState<Present, 'DestinationRegion, 'FrameworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework_share#destination_region-1">AuditmanagerFrameworkShare#destination_region</a>.
        /// </summary>
        [<CustomOperation "destination_region">]
        member _.DestinationRegion(state: AuditmanagerFrameworkShareState<'DestinationAccount, Missing, 'FrameworkId>, value: string) : AuditmanagerFrameworkShareState<'DestinationAccount, Present, 'FrameworkId> =
            state.assignments.Add(fun config -> config.DestinationRegion <- value)
            ({ assignments = state.assignments } : AuditmanagerFrameworkShareState<'DestinationAccount, Present, 'FrameworkId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework_share#framework_id-1">AuditmanagerFrameworkShare#framework_id</a>.
        /// </summary>
        [<CustomOperation "framework_id">]
        member _.FrameworkId(state: AuditmanagerFrameworkShareState<'DestinationAccount, 'DestinationRegion, Missing>, value: string) : AuditmanagerFrameworkShareState<'DestinationAccount, 'DestinationRegion, Present> =
            state.assignments.Add(fun config -> config.FrameworkId <- value)
            ({ assignments = state.assignments } : AuditmanagerFrameworkShareState<'DestinationAccount, 'DestinationRegion, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_framework_share#comment-1">AuditmanagerFrameworkShare#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: AuditmanagerFrameworkShareState<'DestinationAccount, 'DestinationRegion, 'FrameworkId>, value: string) : AuditmanagerFrameworkShareState<'DestinationAccount, 'DestinationRegion, 'FrameworkId> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : AuditmanagerFrameworkShareState<'DestinationAccount, 'DestinationRegion, 'FrameworkId>

        member _.Run(state: AuditmanagerFrameworkShareState<Present, Present, Present>) : aws.AuditmanagerFrameworkShare.AuditmanagerFrameworkShare =
            let config = aws.AuditmanagerFrameworkShare.AuditmanagerFrameworkShareConfig()
            for setter in state.assignments do
                setter config
            aws.AuditmanagerFrameworkShare.AuditmanagerFrameworkShare(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.auditmanagerFrameworkShare: missing required arguments. Must call: destination_account, destination_region, framework_id.", 9999, IsError = true)>]
        member _.Run(_: AuditmanagerFrameworkShareState<_, _, _>) : aws.AuditmanagerFrameworkShare.AuditmanagerFrameworkShare =
            Unchecked.defaultof<aws.AuditmanagerFrameworkShare.AuditmanagerFrameworkShare>
