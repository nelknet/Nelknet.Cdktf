namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AuditmanagerAssessmentReportState<'AssessmentId, 'Name> = { assignments: ResizeArray<aws.AuditmanagerAssessmentReport.AuditmanagerAssessmentReportConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment_report">aws_auditmanager_assessment_report</a>.
    /// </summary>
    type AuditmanagerAssessmentReportBuilder(logicalId: string) =
        member _.Yield(_: unit) : AuditmanagerAssessmentReportState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AuditmanagerAssessmentReportState<Missing, Missing>)

        member _.Zero(()) : AuditmanagerAssessmentReportState<Missing, Missing> =
            ({ assignments = ResizeArray() } : AuditmanagerAssessmentReportState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment_report#assessment_id-1">AuditmanagerAssessmentReport#assessment_id</a>.
        /// </summary>
        [<CustomOperation "assessment_id">]
        member _.AssessmentId(state: AuditmanagerAssessmentReportState<Missing, 'Name>, value: string) : AuditmanagerAssessmentReportState<Present, 'Name> =
            state.assignments.Add(fun config -> config.AssessmentId <- value)
            ({ assignments = state.assignments } : AuditmanagerAssessmentReportState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment_report#name-1">AuditmanagerAssessmentReport#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AuditmanagerAssessmentReportState<'AssessmentId, Missing>, value: string) : AuditmanagerAssessmentReportState<'AssessmentId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AuditmanagerAssessmentReportState<'AssessmentId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment_report#description-1">AuditmanagerAssessmentReport#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AuditmanagerAssessmentReportState<'AssessmentId, 'Name>, value: string) : AuditmanagerAssessmentReportState<'AssessmentId, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AuditmanagerAssessmentReportState<'AssessmentId, 'Name>

        member _.Run(state: AuditmanagerAssessmentReportState<Present, Present>) : aws.AuditmanagerAssessmentReport.AuditmanagerAssessmentReport =
            let config = aws.AuditmanagerAssessmentReport.AuditmanagerAssessmentReportConfig()
            for setter in state.assignments do
                setter config
            aws.AuditmanagerAssessmentReport.AuditmanagerAssessmentReport(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.auditmanagerAssessmentReport: missing required arguments. Must call: assessment_id, name.", 9999, IsError = true)>]
        member _.Run(_: AuditmanagerAssessmentReportState<_, _>) : aws.AuditmanagerAssessmentReport.AuditmanagerAssessmentReport =
            Unchecked.defaultof<aws.AuditmanagerAssessmentReport.AuditmanagerAssessmentReport>
