namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ComputeoptimizerEnrollmentStatusState<'Status> = { assignments: ResizeArray<aws.ComputeoptimizerEnrollmentStatus.ComputeoptimizerEnrollmentStatusConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_enrollment_status">aws_computeoptimizer_enrollment_status</a>.
    /// </summary>
    type ComputeoptimizerEnrollmentStatusBuilder(logicalId: string) =
        member _.Yield(_: unit) : ComputeoptimizerEnrollmentStatusState<Missing> =
            ({ assignments = ResizeArray() } : ComputeoptimizerEnrollmentStatusState<Missing>)

        member _.Zero(()) : ComputeoptimizerEnrollmentStatusState<Missing> =
            ({ assignments = ResizeArray() } : ComputeoptimizerEnrollmentStatusState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_enrollment_status#status-1">ComputeoptimizerEnrollmentStatus#status</a>.
        /// </summary>
        [<CustomOperation "status">]
        member _.Status(state: ComputeoptimizerEnrollmentStatusState<Missing>, value: string) : ComputeoptimizerEnrollmentStatusState<Present> =
            state.assignments.Add(fun config -> config.Status <- value)
            ({ assignments = state.assignments } : ComputeoptimizerEnrollmentStatusState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_enrollment_status#include_member_accounts-1">ComputeoptimizerEnrollmentStatus#include_member_accounts</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_member_accounts">]
        member _.IncludeMemberAccounts(state: ComputeoptimizerEnrollmentStatusState<'Status>, value: bool) : ComputeoptimizerEnrollmentStatusState<'Status> =
            state.assignments.Add(fun config -> config.IncludeMemberAccounts <- value)
            state : ComputeoptimizerEnrollmentStatusState<'Status>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_enrollment_status#include_member_accounts-1">ComputeoptimizerEnrollmentStatus#include_member_accounts</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_member_accounts">]
        member _.IncludeMemberAccounts(state: ComputeoptimizerEnrollmentStatusState<'Status>, value: HashiCorp.Cdktf.IResolvable) : ComputeoptimizerEnrollmentStatusState<'Status> =
            state.assignments.Add(fun config -> config.IncludeMemberAccounts <- value)
            state : ComputeoptimizerEnrollmentStatusState<'Status>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/computeoptimizer_enrollment_status#timeouts-1">ComputeoptimizerEnrollmentStatus#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ComputeoptimizerEnrollmentStatusState<'Status>, value: aws.ComputeoptimizerEnrollmentStatus.ComputeoptimizerEnrollmentStatusTimeouts) : ComputeoptimizerEnrollmentStatusState<'Status> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ComputeoptimizerEnrollmentStatusState<'Status>

        member _.Run(state: ComputeoptimizerEnrollmentStatusState<Present>) : aws.ComputeoptimizerEnrollmentStatus.ComputeoptimizerEnrollmentStatus =
            let config = aws.ComputeoptimizerEnrollmentStatus.ComputeoptimizerEnrollmentStatusConfig()
            for setter in state.assignments do
                setter config
            aws.ComputeoptimizerEnrollmentStatus.ComputeoptimizerEnrollmentStatus(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.computeoptimizerEnrollmentStatus: missing required arguments. Must call: status.", 9999, IsError = true)>]
        member _.Run(_: ComputeoptimizerEnrollmentStatusState<_>) : aws.ComputeoptimizerEnrollmentStatus.ComputeoptimizerEnrollmentStatus =
            Unchecked.defaultof<aws.ComputeoptimizerEnrollmentStatus.ComputeoptimizerEnrollmentStatus>
