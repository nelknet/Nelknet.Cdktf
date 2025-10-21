namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CleanroomsMembershipState<'CollaborationId, 'QueryLogStatus> = { assignments: ResizeArray<aws.CleanroomsMembership.CleanroomsMembershipConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership">aws_cleanrooms_membership</a>.
    /// </summary>
    type CleanroomsMembershipBuilder(logicalId: string) =
        member _.Yield(_: unit) : CleanroomsMembershipState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CleanroomsMembershipState<Missing, Missing>)

        member _.Zero(()) : CleanroomsMembershipState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CleanroomsMembershipState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#collaboration_id-1">CleanroomsMembership#collaboration_id</a>.
        /// </summary>
        [<CustomOperation "collaboration_id">]
        member _.CollaborationId(state: CleanroomsMembershipState<Missing, 'QueryLogStatus>, value: string) : CleanroomsMembershipState<Present, 'QueryLogStatus> =
            state.assignments.Add(fun config -> config.CollaborationId <- value)
            ({ assignments = state.assignments } : CleanroomsMembershipState<Present, 'QueryLogStatus>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#query_log_status-1">CleanroomsMembership#query_log_status</a>.
        /// </summary>
        [<CustomOperation "query_log_status">]
        member _.QueryLogStatus(state: CleanroomsMembershipState<'CollaborationId, Missing>, value: string) : CleanroomsMembershipState<'CollaborationId, Present> =
            state.assignments.Add(fun config -> config.QueryLogStatus <- value)
            ({ assignments = state.assignments } : CleanroomsMembershipState<'CollaborationId, Present>)

        /// <summary>
        /// default_result_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#default_result_configuration-1">CleanroomsMembership#default_result_configuration</a> Accepts: aws.IResolvable | aws.CleanroomsMembership.CleanroomsMembershipDefaultResultConfiguration[]
        /// </summary>
        [<CustomOperation "default_result_configuration">]
        member _.DefaultResultConfiguration(state: CleanroomsMembershipState<'CollaborationId, 'QueryLogStatus>, value: HashiCorp.Cdktf.IResolvable) : CleanroomsMembershipState<'CollaborationId, 'QueryLogStatus> =
            state.assignments.Add(fun config -> config.DefaultResultConfiguration <- value)
            state : CleanroomsMembershipState<'CollaborationId, 'QueryLogStatus>

        /// <summary>
        /// payment_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#payment_configuration-1">CleanroomsMembership#payment_configuration</a> Accepts: aws.IResolvable | aws.CleanroomsMembership.CleanroomsMembershipPaymentConfiguration[]
        /// </summary>
        [<CustomOperation "payment_configuration">]
        member _.PaymentConfiguration(state: CleanroomsMembershipState<'CollaborationId, 'QueryLogStatus>, value: HashiCorp.Cdktf.IResolvable) : CleanroomsMembershipState<'CollaborationId, 'QueryLogStatus> =
            state.assignments.Add(fun config -> config.PaymentConfiguration <- value)
            state : CleanroomsMembershipState<'CollaborationId, 'QueryLogStatus>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#tags-1">CleanroomsMembership#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CleanroomsMembershipState<'CollaborationId, 'QueryLogStatus>, value: seq<string * string>) : CleanroomsMembershipState<'CollaborationId, 'QueryLogStatus> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CleanroomsMembershipState<'CollaborationId, 'QueryLogStatus>

        member _.Run(state: CleanroomsMembershipState<Present, Present>) : aws.CleanroomsMembership.CleanroomsMembership =
            let config = aws.CleanroomsMembership.CleanroomsMembershipConfig()
            for setter in state.assignments do
                setter config
            aws.CleanroomsMembership.CleanroomsMembership(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cleanroomsMembership: missing required arguments. Must call: collaboration_id, query_log_status.", 9999, IsError = true)>]
        member _.Run(_: CleanroomsMembershipState<_, _>) : aws.CleanroomsMembership.CleanroomsMembership =
            Unchecked.defaultof<aws.CleanroomsMembership.CleanroomsMembership>
