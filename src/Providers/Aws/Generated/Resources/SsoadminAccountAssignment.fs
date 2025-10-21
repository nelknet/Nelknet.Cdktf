namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, 'TargetId> = { assignments: ResizeArray<aws.SsoadminAccountAssignment.SsoadminAccountAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_account_assignment">aws_ssoadmin_account_assignment</a>.
    /// </summary>
    type SsoadminAccountAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsoadminAccountAssignmentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminAccountAssignmentState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SsoadminAccountAssignmentState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminAccountAssignmentState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_account_assignment#instance_arn-1">SsoadminAccountAssignment#instance_arn</a>.
        /// </summary>
        [<CustomOperation "instance_arn">]
        member _.InstanceArn(state: SsoadminAccountAssignmentState<Missing, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, 'TargetId>, value: string) : SsoadminAccountAssignmentState<Present, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, 'TargetId> =
            state.assignments.Add(fun config -> config.InstanceArn <- value)
            ({ assignments = state.assignments } : SsoadminAccountAssignmentState<Present, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, 'TargetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_account_assignment#permission_set_arn-1">SsoadminAccountAssignment#permission_set_arn</a>.
        /// </summary>
        [<CustomOperation "permission_set_arn">]
        member _.PermissionSetArn(state: SsoadminAccountAssignmentState<'InstanceArn, Missing, 'PrincipalId, 'PrincipalType, 'TargetId>, value: string) : SsoadminAccountAssignmentState<'InstanceArn, Present, 'PrincipalId, 'PrincipalType, 'TargetId> =
            state.assignments.Add(fun config -> config.PermissionSetArn <- value)
            ({ assignments = state.assignments } : SsoadminAccountAssignmentState<'InstanceArn, Present, 'PrincipalId, 'PrincipalType, 'TargetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_account_assignment#principal_id-1">SsoadminAccountAssignment#principal_id</a>.
        /// </summary>
        [<CustomOperation "principal_id">]
        member _.PrincipalId(state: SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, Missing, 'PrincipalType, 'TargetId>, value: string) : SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, Present, 'PrincipalType, 'TargetId> =
            state.assignments.Add(fun config -> config.PrincipalId <- value)
            ({ assignments = state.assignments } : SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, Present, 'PrincipalType, 'TargetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_account_assignment#principal_type-1">SsoadminAccountAssignment#principal_type</a>.
        /// </summary>
        [<CustomOperation "principal_type">]
        member _.PrincipalType(state: SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, Missing, 'TargetId>, value: string) : SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, Present, 'TargetId> =
            state.assignments.Add(fun config -> config.PrincipalType <- value)
            ({ assignments = state.assignments } : SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, Present, 'TargetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_account_assignment#target_id-1">SsoadminAccountAssignment#target_id</a>.
        /// </summary>
        [<CustomOperation "target_id">]
        member _.TargetId(state: SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, Missing>, value: string) : SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, Present> =
            state.assignments.Add(fun config -> config.TargetId <- value)
            ({ assignments = state.assignments } : SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_account_assignment#id-1">SsoadminAccountAssignment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, 'TargetId>, value: string) : SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, 'TargetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, 'TargetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_account_assignment#target_type-1">SsoadminAccountAssignment#target_type</a>.
        /// </summary>
        [<CustomOperation "target_type">]
        member _.TargetType(state: SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, 'TargetId>, value: string) : SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, 'TargetId> =
            state.assignments.Add(fun config -> config.TargetType <- value)
            state : SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, 'TargetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_account_assignment#timeouts-1">SsoadminAccountAssignment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, 'TargetId>, value: aws.SsoadminAccountAssignment.SsoadminAccountAssignmentTimeouts) : SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, 'TargetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SsoadminAccountAssignmentState<'InstanceArn, 'PermissionSetArn, 'PrincipalId, 'PrincipalType, 'TargetId>

        member _.Run(state: SsoadminAccountAssignmentState<Present, Present, Present, Present, Present>) : aws.SsoadminAccountAssignment.SsoadminAccountAssignment =
            let config = aws.SsoadminAccountAssignment.SsoadminAccountAssignmentConfig()
            for setter in state.assignments do
                setter config
            aws.SsoadminAccountAssignment.SsoadminAccountAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssoadminAccountAssignment: missing required arguments. Must call: instance_arn, permission_set_arn, principal_id, principal_type, target_id.", 9999, IsError = true)>]
        member _.Run(_: SsoadminAccountAssignmentState<_, _, _, _, _>) : aws.SsoadminAccountAssignment.SsoadminAccountAssignment =
            Unchecked.defaultof<aws.SsoadminAccountAssignment.SsoadminAccountAssignment>
