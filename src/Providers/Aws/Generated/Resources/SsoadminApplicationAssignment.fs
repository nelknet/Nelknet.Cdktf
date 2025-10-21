namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsoadminApplicationAssignmentState<'ApplicationArn, 'PrincipalId, 'PrincipalType> = { assignments: ResizeArray<aws.SsoadminApplicationAssignment.SsoadminApplicationAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application_assignment">aws_ssoadmin_application_assignment</a>.
    /// </summary>
    type SsoadminApplicationAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsoadminApplicationAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminApplicationAssignmentState<Missing, Missing, Missing>)

        member _.Zero(()) : SsoadminApplicationAssignmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminApplicationAssignmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application_assignment#application_arn-1">SsoadminApplicationAssignment#application_arn</a>.
        /// </summary>
        [<CustomOperation "application_arn">]
        member _.ApplicationArn(state: SsoadminApplicationAssignmentState<Missing, 'PrincipalId, 'PrincipalType>, value: string) : SsoadminApplicationAssignmentState<Present, 'PrincipalId, 'PrincipalType> =
            state.assignments.Add(fun config -> config.ApplicationArn <- value)
            ({ assignments = state.assignments } : SsoadminApplicationAssignmentState<Present, 'PrincipalId, 'PrincipalType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application_assignment#principal_id-1">SsoadminApplicationAssignment#principal_id</a>.
        /// </summary>
        [<CustomOperation "principal_id">]
        member _.PrincipalId(state: SsoadminApplicationAssignmentState<'ApplicationArn, Missing, 'PrincipalType>, value: string) : SsoadminApplicationAssignmentState<'ApplicationArn, Present, 'PrincipalType> =
            state.assignments.Add(fun config -> config.PrincipalId <- value)
            ({ assignments = state.assignments } : SsoadminApplicationAssignmentState<'ApplicationArn, Present, 'PrincipalType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application_assignment#principal_type-1">SsoadminApplicationAssignment#principal_type</a>.
        /// </summary>
        [<CustomOperation "principal_type">]
        member _.PrincipalType(state: SsoadminApplicationAssignmentState<'ApplicationArn, 'PrincipalId, Missing>, value: string) : SsoadminApplicationAssignmentState<'ApplicationArn, 'PrincipalId, Present> =
            state.assignments.Add(fun config -> config.PrincipalType <- value)
            ({ assignments = state.assignments } : SsoadminApplicationAssignmentState<'ApplicationArn, 'PrincipalId, Present>)

        member _.Run(state: SsoadminApplicationAssignmentState<Present, Present, Present>) : aws.SsoadminApplicationAssignment.SsoadminApplicationAssignment =
            let config = aws.SsoadminApplicationAssignment.SsoadminApplicationAssignmentConfig()
            for setter in state.assignments do
                setter config
            aws.SsoadminApplicationAssignment.SsoadminApplicationAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssoadminApplicationAssignment: missing required arguments. Must call: application_arn, principal_id, principal_type.", 9999, IsError = true)>]
        member _.Run(_: SsoadminApplicationAssignmentState<_, _, _>) : aws.SsoadminApplicationAssignment.SsoadminApplicationAssignment =
            Unchecked.defaultof<aws.SsoadminApplicationAssignment.SsoadminApplicationAssignment>
