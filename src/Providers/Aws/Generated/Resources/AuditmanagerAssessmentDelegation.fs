namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AuditmanagerAssessmentDelegationState<'AssessmentId, 'ControlSetId, 'RoleArn, 'RoleType> = { assignments: ResizeArray<aws.AuditmanagerAssessmentDelegation.AuditmanagerAssessmentDelegationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment_delegation">aws_auditmanager_assessment_delegation</a>.
    /// </summary>
    type AuditmanagerAssessmentDelegationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AuditmanagerAssessmentDelegationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AuditmanagerAssessmentDelegationState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AuditmanagerAssessmentDelegationState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AuditmanagerAssessmentDelegationState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment_delegation#assessment_id-1">AuditmanagerAssessmentDelegation#assessment_id</a>.
        /// </summary>
        [<CustomOperation "assessment_id">]
        member _.AssessmentId(state: AuditmanagerAssessmentDelegationState<Missing, 'ControlSetId, 'RoleArn, 'RoleType>, value: string) : AuditmanagerAssessmentDelegationState<Present, 'ControlSetId, 'RoleArn, 'RoleType> =
            state.assignments.Add(fun config -> config.AssessmentId <- value)
            ({ assignments = state.assignments } : AuditmanagerAssessmentDelegationState<Present, 'ControlSetId, 'RoleArn, 'RoleType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment_delegation#control_set_id-1">AuditmanagerAssessmentDelegation#control_set_id</a>.
        /// </summary>
        [<CustomOperation "control_set_id">]
        member _.ControlSetId(state: AuditmanagerAssessmentDelegationState<'AssessmentId, Missing, 'RoleArn, 'RoleType>, value: string) : AuditmanagerAssessmentDelegationState<'AssessmentId, Present, 'RoleArn, 'RoleType> =
            state.assignments.Add(fun config -> config.ControlSetId <- value)
            ({ assignments = state.assignments } : AuditmanagerAssessmentDelegationState<'AssessmentId, Present, 'RoleArn, 'RoleType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment_delegation#role_arn-1">AuditmanagerAssessmentDelegation#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: AuditmanagerAssessmentDelegationState<'AssessmentId, 'ControlSetId, Missing, 'RoleType>, value: string) : AuditmanagerAssessmentDelegationState<'AssessmentId, 'ControlSetId, Present, 'RoleType> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : AuditmanagerAssessmentDelegationState<'AssessmentId, 'ControlSetId, Present, 'RoleType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment_delegation#role_type-1">AuditmanagerAssessmentDelegation#role_type</a>.
        /// </summary>
        [<CustomOperation "role_type">]
        member _.RoleType(state: AuditmanagerAssessmentDelegationState<'AssessmentId, 'ControlSetId, 'RoleArn, Missing>, value: string) : AuditmanagerAssessmentDelegationState<'AssessmentId, 'ControlSetId, 'RoleArn, Present> =
            state.assignments.Add(fun config -> config.RoleType <- value)
            ({ assignments = state.assignments } : AuditmanagerAssessmentDelegationState<'AssessmentId, 'ControlSetId, 'RoleArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_assessment_delegation#comment-1">AuditmanagerAssessmentDelegation#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: AuditmanagerAssessmentDelegationState<'AssessmentId, 'ControlSetId, 'RoleArn, 'RoleType>, value: string) : AuditmanagerAssessmentDelegationState<'AssessmentId, 'ControlSetId, 'RoleArn, 'RoleType> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : AuditmanagerAssessmentDelegationState<'AssessmentId, 'ControlSetId, 'RoleArn, 'RoleType>

        member _.Run(state: AuditmanagerAssessmentDelegationState<Present, Present, Present, Present>) : aws.AuditmanagerAssessmentDelegation.AuditmanagerAssessmentDelegation =
            let config = aws.AuditmanagerAssessmentDelegation.AuditmanagerAssessmentDelegationConfig()
            for setter in state.assignments do
                setter config
            aws.AuditmanagerAssessmentDelegation.AuditmanagerAssessmentDelegation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.auditmanagerAssessmentDelegation: missing required arguments. Must call: assessment_id, control_set_id, role_arn, role_type.", 9999, IsError = true)>]
        member _.Run(_: AuditmanagerAssessmentDelegationState<_, _, _, _>) : aws.AuditmanagerAssessmentDelegation.AuditmanagerAssessmentDelegation =
            Unchecked.defaultof<aws.AuditmanagerAssessmentDelegation.AuditmanagerAssessmentDelegation>
