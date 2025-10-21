namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubStandardsControlAssociationState<'AssociationStatus, 'SecurityControlId, 'StandardsArn> = { assignments: ResizeArray<aws.SecurityhubStandardsControlAssociation.SecurityhubStandardsControlAssociationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_standards_control_association">aws_securityhub_standards_control_association</a>.
    /// </summary>
    type SecurityhubStandardsControlAssociationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubStandardsControlAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityhubStandardsControlAssociationState<Missing, Missing, Missing>)

        member _.Zero(()) : SecurityhubStandardsControlAssociationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SecurityhubStandardsControlAssociationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_standards_control_association#association_status-1">SecurityhubStandardsControlAssociation#association_status</a>.
        /// </summary>
        [<CustomOperation "association_status">]
        member _.AssociationStatus(state: SecurityhubStandardsControlAssociationState<Missing, 'SecurityControlId, 'StandardsArn>, value: string) : SecurityhubStandardsControlAssociationState<Present, 'SecurityControlId, 'StandardsArn> =
            state.assignments.Add(fun config -> config.AssociationStatus <- value)
            ({ assignments = state.assignments } : SecurityhubStandardsControlAssociationState<Present, 'SecurityControlId, 'StandardsArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_standards_control_association#security_control_id-1">SecurityhubStandardsControlAssociation#security_control_id</a>.
        /// </summary>
        [<CustomOperation "security_control_id">]
        member _.SecurityControlId(state: SecurityhubStandardsControlAssociationState<'AssociationStatus, Missing, 'StandardsArn>, value: string) : SecurityhubStandardsControlAssociationState<'AssociationStatus, Present, 'StandardsArn> =
            state.assignments.Add(fun config -> config.SecurityControlId <- value)
            ({ assignments = state.assignments } : SecurityhubStandardsControlAssociationState<'AssociationStatus, Present, 'StandardsArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_standards_control_association#standards_arn-1">SecurityhubStandardsControlAssociation#standards_arn</a>.
        /// </summary>
        [<CustomOperation "standards_arn">]
        member _.StandardsArn(state: SecurityhubStandardsControlAssociationState<'AssociationStatus, 'SecurityControlId, Missing>, value: string) : SecurityhubStandardsControlAssociationState<'AssociationStatus, 'SecurityControlId, Present> =
            state.assignments.Add(fun config -> config.StandardsArn <- value)
            ({ assignments = state.assignments } : SecurityhubStandardsControlAssociationState<'AssociationStatus, 'SecurityControlId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_standards_control_association#updated_reason-1">SecurityhubStandardsControlAssociation#updated_reason</a>.
        /// </summary>
        [<CustomOperation "updated_reason">]
        member _.UpdatedReason(state: SecurityhubStandardsControlAssociationState<'AssociationStatus, 'SecurityControlId, 'StandardsArn>, value: string) : SecurityhubStandardsControlAssociationState<'AssociationStatus, 'SecurityControlId, 'StandardsArn> =
            state.assignments.Add(fun config -> config.UpdatedReason <- value)
            state : SecurityhubStandardsControlAssociationState<'AssociationStatus, 'SecurityControlId, 'StandardsArn>

        member _.Run(state: SecurityhubStandardsControlAssociationState<Present, Present, Present>) : aws.SecurityhubStandardsControlAssociation.SecurityhubStandardsControlAssociation =
            let config = aws.SecurityhubStandardsControlAssociation.SecurityhubStandardsControlAssociationConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubStandardsControlAssociation.SecurityhubStandardsControlAssociation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityhubStandardsControlAssociation: missing required arguments. Must call: association_status, security_control_id, standards_arn.", 9999, IsError = true)>]
        member _.Run(_: SecurityhubStandardsControlAssociationState<_, _, _>) : aws.SecurityhubStandardsControlAssociation.SecurityhubStandardsControlAssociation =
            Unchecked.defaultof<aws.SecurityhubStandardsControlAssociation.SecurityhubStandardsControlAssociation>
