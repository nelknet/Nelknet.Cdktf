namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AuditmanagerAssessmentState<'FrameworkId, 'Name, 'Roles> = { assignments: ResizeArray<aws.AuditmanagerAssessment.AuditmanagerAssessmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment">aws_auditmanager_assessment</a>.
    /// </summary>
    type AuditmanagerAssessmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : AuditmanagerAssessmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AuditmanagerAssessmentState<Missing, Missing, Missing>)

        member _.Zero(()) : AuditmanagerAssessmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AuditmanagerAssessmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#framework_id-1">AuditmanagerAssessment#framework_id</a>.
        /// </summary>
        [<CustomOperation "framework_id">]
        member _.FrameworkId(state: AuditmanagerAssessmentState<Missing, 'Name, 'Roles>, value: string) : AuditmanagerAssessmentState<Present, 'Name, 'Roles> =
            state.assignments.Add(fun config -> config.FrameworkId <- value)
            ({ assignments = state.assignments } : AuditmanagerAssessmentState<Present, 'Name, 'Roles>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#name-1">AuditmanagerAssessment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AuditmanagerAssessmentState<'FrameworkId, Missing, 'Roles>, value: string) : AuditmanagerAssessmentState<'FrameworkId, Present, 'Roles> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AuditmanagerAssessmentState<'FrameworkId, Present, 'Roles>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#roles-1">AuditmanagerAssessment#roles</a>. Accepts: aws.IResolvable | aws.AuditmanagerAssessment.AuditmanagerAssessmentRoles[]
        /// </summary>
        [<CustomOperation "roles">]
        member _.Roles(state: AuditmanagerAssessmentState<'FrameworkId, 'Name, Missing>, value: HashiCorp.Cdktf.IResolvable) : AuditmanagerAssessmentState<'FrameworkId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Roles <- value)
            ({ assignments = state.assignments } : AuditmanagerAssessmentState<'FrameworkId, 'Name, Present>)

        /// <summary>
        /// assessment_reports_destination block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#assessment_reports_destination-1">AuditmanagerAssessment#assessment_reports_destination</a> Accepts: aws.IResolvable | aws.AuditmanagerAssessment.AuditmanagerAssessmentAssessmentReportsDestination[]
        /// </summary>
        [<CustomOperation "assessment_reports_destination">]
        member _.AssessmentReportsDestination(state: AuditmanagerAssessmentState<'FrameworkId, 'Name, 'Roles>, value: HashiCorp.Cdktf.IResolvable) : AuditmanagerAssessmentState<'FrameworkId, 'Name, 'Roles> =
            state.assignments.Add(fun config -> config.AssessmentReportsDestination <- value)
            state : AuditmanagerAssessmentState<'FrameworkId, 'Name, 'Roles>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#description-1">AuditmanagerAssessment#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: AuditmanagerAssessmentState<'FrameworkId, 'Name, 'Roles>, value: string) : AuditmanagerAssessmentState<'FrameworkId, 'Name, 'Roles> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : AuditmanagerAssessmentState<'FrameworkId, 'Name, 'Roles>

        /// <summary>
        /// scope block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#scope-1">AuditmanagerAssessment#scope</a> Accepts: aws.IResolvable | aws.AuditmanagerAssessment.AuditmanagerAssessmentScope[]
        /// </summary>
        [<CustomOperation "scope">]
        member _.Scope(state: AuditmanagerAssessmentState<'FrameworkId, 'Name, 'Roles>, value: HashiCorp.Cdktf.IResolvable) : AuditmanagerAssessmentState<'FrameworkId, 'Name, 'Roles> =
            state.assignments.Add(fun config -> config.Scope <- value)
            state : AuditmanagerAssessmentState<'FrameworkId, 'Name, 'Roles>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment#tags-1">AuditmanagerAssessment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AuditmanagerAssessmentState<'FrameworkId, 'Name, 'Roles>, value: seq<string * string>) : AuditmanagerAssessmentState<'FrameworkId, 'Name, 'Roles> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AuditmanagerAssessmentState<'FrameworkId, 'Name, 'Roles>

        member _.Run(state: AuditmanagerAssessmentState<Present, Present, Present>) : aws.AuditmanagerAssessment.AuditmanagerAssessment =
            let config = aws.AuditmanagerAssessment.AuditmanagerAssessmentConfig()
            for setter in state.assignments do
                setter config
            aws.AuditmanagerAssessment.AuditmanagerAssessment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.auditmanagerAssessment: missing required arguments. Must call: framework_id, name, roles.", 9999, IsError = true)>]
        member _.Run(_: AuditmanagerAssessmentState<_, _, _>) : aws.AuditmanagerAssessment.AuditmanagerAssessment =
            Unchecked.defaultof<aws.AuditmanagerAssessment.AuditmanagerAssessment>
