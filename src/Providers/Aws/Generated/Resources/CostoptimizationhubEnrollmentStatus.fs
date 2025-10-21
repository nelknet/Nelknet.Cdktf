namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CostoptimizationhubEnrollmentStatusState = { assignments: ResizeArray<aws.CostoptimizationhubEnrollmentStatus.CostoptimizationhubEnrollmentStatusConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/costoptimizationhub_enrollment_status">aws_costoptimizationhub_enrollment_status</a>.
    /// </summary>
    type CostoptimizationhubEnrollmentStatusBuilder(logicalId: string) =
        member _.Yield(_: unit) : CostoptimizationhubEnrollmentStatusState =
            { assignments = ResizeArray() }

        member _.Zero(()) : CostoptimizationhubEnrollmentStatusState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/costoptimizationhub_enrollment_status#include_member_accounts-1">CostoptimizationhubEnrollmentStatus#include_member_accounts</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_member_accounts">]
        member _.IncludeMemberAccounts(state: CostoptimizationhubEnrollmentStatusState, value: bool) : CostoptimizationhubEnrollmentStatusState =
            state.assignments.Add(fun config -> config.IncludeMemberAccounts <- value)
            state : CostoptimizationhubEnrollmentStatusState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/costoptimizationhub_enrollment_status#include_member_accounts-1">CostoptimizationhubEnrollmentStatus#include_member_accounts</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "include_member_accounts">]
        member _.IncludeMemberAccounts(state: CostoptimizationhubEnrollmentStatusState, value: HashiCorp.Cdktf.IResolvable) : CostoptimizationhubEnrollmentStatusState =
            state.assignments.Add(fun config -> config.IncludeMemberAccounts <- value)
            state : CostoptimizationhubEnrollmentStatusState

        member _.Run(state: CostoptimizationhubEnrollmentStatusState) : aws.CostoptimizationhubEnrollmentStatus.CostoptimizationhubEnrollmentStatus =
            let config = aws.CostoptimizationhubEnrollmentStatus.CostoptimizationhubEnrollmentStatusConfig()
            for setter in state.assignments do
                setter config
            aws.CostoptimizationhubEnrollmentStatus.CostoptimizationhubEnrollmentStatus(StackContext.get (), logicalId, config)
