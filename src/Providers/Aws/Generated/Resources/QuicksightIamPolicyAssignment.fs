namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type QuicksightIamPolicyAssignmentState<'AssignmentName, 'AssignmentStatus> = { assignments: ResizeArray<aws.QuicksightIamPolicyAssignment.QuicksightIamPolicyAssignmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_iam_policy_assignment">aws_quicksight_iam_policy_assignment</a>.
    /// </summary>
    type QuicksightIamPolicyAssignmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : QuicksightIamPolicyAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightIamPolicyAssignmentState<Missing, Missing>)

        member _.Zero(()) : QuicksightIamPolicyAssignmentState<Missing, Missing> =
            ({ assignments = ResizeArray() } : QuicksightIamPolicyAssignmentState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_iam_policy_assignment#assignment_name-1">QuicksightIamPolicyAssignment#assignment_name</a>.
        /// </summary>
        [<CustomOperation "assignment_name">]
        member _.AssignmentName(state: QuicksightIamPolicyAssignmentState<Missing, 'AssignmentStatus>, value: string) : QuicksightIamPolicyAssignmentState<Present, 'AssignmentStatus> =
            state.assignments.Add(fun config -> config.AssignmentName <- value)
            ({ assignments = state.assignments } : QuicksightIamPolicyAssignmentState<Present, 'AssignmentStatus>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_iam_policy_assignment#assignment_status-1">QuicksightIamPolicyAssignment#assignment_status</a>.
        /// </summary>
        [<CustomOperation "assignment_status">]
        member _.AssignmentStatus(state: QuicksightIamPolicyAssignmentState<'AssignmentName, Missing>, value: string) : QuicksightIamPolicyAssignmentState<'AssignmentName, Present> =
            state.assignments.Add(fun config -> config.AssignmentStatus <- value)
            ({ assignments = state.assignments } : QuicksightIamPolicyAssignmentState<'AssignmentName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_iam_policy_assignment#aws_account_id-1">QuicksightIamPolicyAssignment#aws_account_id</a>.
        /// </summary>
        [<CustomOperation "aws_account_id">]
        member _.AwsAccountId(state: QuicksightIamPolicyAssignmentState<'AssignmentName, 'AssignmentStatus>, value: string) : QuicksightIamPolicyAssignmentState<'AssignmentName, 'AssignmentStatus> =
            state.assignments.Add(fun config -> config.AwsAccountId <- value)
            state : QuicksightIamPolicyAssignmentState<'AssignmentName, 'AssignmentStatus>

        /// <summary>
        /// identities block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_iam_policy_assignment#identities-1">QuicksightIamPolicyAssignment#identities</a> Accepts: aws.IResolvable | aws.QuicksightIamPolicyAssignment.QuicksightIamPolicyAssignmentIdentities[]
        /// </summary>
        [<CustomOperation "identities">]
        member _.Identities(state: QuicksightIamPolicyAssignmentState<'AssignmentName, 'AssignmentStatus>, value: HashiCorp.Cdktf.IResolvable) : QuicksightIamPolicyAssignmentState<'AssignmentName, 'AssignmentStatus> =
            state.assignments.Add(fun config -> config.Identities <- value)
            state : QuicksightIamPolicyAssignmentState<'AssignmentName, 'AssignmentStatus>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_iam_policy_assignment#namespace-1">QuicksightIamPolicyAssignment#namespace</a>.
        /// </summary>
        [<CustomOperation "namespace">]
        member _.Namespace(state: QuicksightIamPolicyAssignmentState<'AssignmentName, 'AssignmentStatus>, value: string) : QuicksightIamPolicyAssignmentState<'AssignmentName, 'AssignmentStatus> =
            state.assignments.Add(fun config -> config.Namespace <- value)
            state : QuicksightIamPolicyAssignmentState<'AssignmentName, 'AssignmentStatus>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_iam_policy_assignment#policy_arn-1">QuicksightIamPolicyAssignment#policy_arn</a>.
        /// </summary>
        [<CustomOperation "policy_arn">]
        member _.PolicyArn(state: QuicksightIamPolicyAssignmentState<'AssignmentName, 'AssignmentStatus>, value: string) : QuicksightIamPolicyAssignmentState<'AssignmentName, 'AssignmentStatus> =
            state.assignments.Add(fun config -> config.PolicyArn <- value)
            state : QuicksightIamPolicyAssignmentState<'AssignmentName, 'AssignmentStatus>

        member _.Run(state: QuicksightIamPolicyAssignmentState<Present, Present>) : aws.QuicksightIamPolicyAssignment.QuicksightIamPolicyAssignment =
            let config = aws.QuicksightIamPolicyAssignment.QuicksightIamPolicyAssignmentConfig()
            for setter in state.assignments do
                setter config
            aws.QuicksightIamPolicyAssignment.QuicksightIamPolicyAssignment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.quicksightIamPolicyAssignment: missing required arguments. Must call: assignment_name, assignment_status.", 9999, IsError = true)>]
        member _.Run(_: QuicksightIamPolicyAssignmentState<_, _>) : aws.QuicksightIamPolicyAssignment.QuicksightIamPolicyAssignment =
            Unchecked.defaultof<aws.QuicksightIamPolicyAssignment.QuicksightIamPolicyAssignment>
