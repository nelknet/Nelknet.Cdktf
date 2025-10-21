namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsSsoadminApplicationAssignmentsState<'ApplicationArn> = { assignments: ResizeArray<aws.DataAwsSsoadminApplicationAssignments.DataAwsSsoadminApplicationAssignmentsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_application_assignments">aws_ssoadmin_application_assignments</a>.
    /// </summary>
    type DataAwsSsoadminApplicationAssignmentsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsSsoadminApplicationAssignmentsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsoadminApplicationAssignmentsState<Missing>)

        member _.Zero(()) : DataAwsSsoadminApplicationAssignmentsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsSsoadminApplicationAssignmentsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_application_assignments#application_arn-1">DataAwsSsoadminApplicationAssignments#application_arn</a>.
        /// </summary>
        [<CustomOperation "application_arn">]
        member _.ApplicationArn(state: DataAwsSsoadminApplicationAssignmentsState<Missing>, value: string) : DataAwsSsoadminApplicationAssignmentsState<Present> =
            state.assignments.Add(fun config -> config.ApplicationArn <- value)
            ({ assignments = state.assignments } : DataAwsSsoadminApplicationAssignmentsState<Present>)

        /// <summary>
        /// application_assignments block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ssoadmin_application_assignments#application_assignments-1">DataAwsSsoadminApplicationAssignments#application_assignments</a> Accepts: aws.IResolvable | aws.DataAwsSsoadminApplicationAssignments.DataAwsSsoadminApplicationAssignmentsApplicationAssignments[]
        /// </summary>
        [<CustomOperation "application_assignments">]
        member _.ApplicationAssignments(state: DataAwsSsoadminApplicationAssignmentsState<'ApplicationArn>, value: HashiCorp.Cdktf.IResolvable) : DataAwsSsoadminApplicationAssignmentsState<'ApplicationArn> =
            state.assignments.Add(fun config -> config.ApplicationAssignments <- value)
            state : DataAwsSsoadminApplicationAssignmentsState<'ApplicationArn>

        member _.Run(state: DataAwsSsoadminApplicationAssignmentsState<Present>) : aws.DataAwsSsoadminApplicationAssignments.DataAwsSsoadminApplicationAssignments =
            let config = aws.DataAwsSsoadminApplicationAssignments.DataAwsSsoadminApplicationAssignmentsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsSsoadminApplicationAssignments.DataAwsSsoadminApplicationAssignments(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsSsoadminApplicationAssignments: missing required arguments. Must call: application_arn.", 9999, IsError = true)>]
        member _.Run(_: DataAwsSsoadminApplicationAssignmentsState<_>) : aws.DataAwsSsoadminApplicationAssignments.DataAwsSsoadminApplicationAssignments =
            Unchecked.defaultof<aws.DataAwsSsoadminApplicationAssignments.DataAwsSsoadminApplicationAssignments>
