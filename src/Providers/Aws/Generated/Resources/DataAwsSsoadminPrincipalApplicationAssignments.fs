namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsoadminPrincipalApplicationAssignmentsState<'InstanceArn, 'PrincipalId, 'PrincipalType> = { assignments: ResizeArray<aws.DataAwsSsoadminPrincipalApplicationAssignments.DataAwsSsoadminPrincipalApplicationAssignmentsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_principal_application_assignments">aws_ssoadmin_principal_application_assignments</a>.
    /// </summary>
    type DataAwsSsoadminPrincipalApplicationAssignmentsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsoadminPrincipalApplicationAssignmentsState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsoadminPrincipalApplicationAssignmentsState<Missing, Missing, Missing>)

        member _.Zero(()) : DataAwsSsoadminPrincipalApplicationAssignmentsState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsoadminPrincipalApplicationAssignmentsState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_principal_application_assignments#instance_arn-1">DataAwsSsoadminPrincipalApplicationAssignments#instance_arn</a>.
        /// </summary>
        [<CustomOperation "instance_arn">]
        member _.InstanceArn(state: DataAwsSsoadminPrincipalApplicationAssignmentsState<Missing, 'PrincipalId, 'PrincipalType>, value: string) : DataAwsSsoadminPrincipalApplicationAssignmentsState<Present, 'PrincipalId, 'PrincipalType> =
            state.assignments.Add(fun config -> config.InstanceArn <- value)
            ({ assignments = state.assignments } : DataAwsSsoadminPrincipalApplicationAssignmentsState<Present, 'PrincipalId, 'PrincipalType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_principal_application_assignments#principal_id-1">DataAwsSsoadminPrincipalApplicationAssignments#principal_id</a>.
        /// </summary>
        [<CustomOperation "principal_id">]
        member _.PrincipalId(state: DataAwsSsoadminPrincipalApplicationAssignmentsState<'InstanceArn, Missing, 'PrincipalType>, value: string) : DataAwsSsoadminPrincipalApplicationAssignmentsState<'InstanceArn, Present, 'PrincipalType> =
            state.assignments.Add(fun config -> config.PrincipalId <- value)
            ({ assignments = state.assignments } : DataAwsSsoadminPrincipalApplicationAssignmentsState<'InstanceArn, Present, 'PrincipalType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_principal_application_assignments#principal_type-1">DataAwsSsoadminPrincipalApplicationAssignments#principal_type</a>.
        /// </summary>
        [<CustomOperation "principal_type">]
        member _.PrincipalType(state: DataAwsSsoadminPrincipalApplicationAssignmentsState<'InstanceArn, 'PrincipalId, Missing>, value: string) : DataAwsSsoadminPrincipalApplicationAssignmentsState<'InstanceArn, 'PrincipalId, Present> =
            state.assignments.Add(fun config -> config.PrincipalType <- value)
            ({ assignments = state.assignments } : DataAwsSsoadminPrincipalApplicationAssignmentsState<'InstanceArn, 'PrincipalId, Present>)

        /// <summary>
        /// application_assignments block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_principal_application_assignments#application_assignments-1">DataAwsSsoadminPrincipalApplicationAssignments#application_assignments</a> Accepts: aws.IResolvable | aws.DataAwsSsoadminPrincipalApplicationAssignments.DataAwsSsoadminPrincipalApplicationAssignmentsApplicationAssignments[]
        /// </summary>
        [<CustomOperation "application_assignments">]
        member _.ApplicationAssignments(state: DataAwsSsoadminPrincipalApplicationAssignmentsState<'InstanceArn, 'PrincipalId, 'PrincipalType>, value: HashiCorp.Cdktf.IResolvable) : DataAwsSsoadminPrincipalApplicationAssignmentsState<'InstanceArn, 'PrincipalId, 'PrincipalType> =
            state.assignments.Add(fun config -> config.ApplicationAssignments <- value)
            state : DataAwsSsoadminPrincipalApplicationAssignmentsState<'InstanceArn, 'PrincipalId, 'PrincipalType>

        member _.Run(state: DataAwsSsoadminPrincipalApplicationAssignmentsState<Present, Present, Present>) : aws.DataAwsSsoadminPrincipalApplicationAssignments.DataAwsSsoadminPrincipalApplicationAssignments =
            let config = aws.DataAwsSsoadminPrincipalApplicationAssignments.DataAwsSsoadminPrincipalApplicationAssignmentsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsoadminPrincipalApplicationAssignments.DataAwsSsoadminPrincipalApplicationAssignments(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSsoadminPrincipalApplicationAssignments: missing required arguments. Must call: instance_arn, principal_id, principal_type.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSsoadminPrincipalApplicationAssignmentsState<_, _, _>) : aws.DataAwsSsoadminPrincipalApplicationAssignments.DataAwsSsoadminPrincipalApplicationAssignments =
            Unchecked.defaultof<aws.DataAwsSsoadminPrincipalApplicationAssignments.DataAwsSsoadminPrincipalApplicationAssignments>
