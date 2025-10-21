namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsoadminApplicationAssignmentConfigurationState<'ApplicationArn, 'AssignmentRequired> = { assignments: ResizeArray<aws.SsoadminApplicationAssignmentConfiguration.SsoadminApplicationAssignmentConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application_assignment_configuration">aws_ssoadmin_application_assignment_configuration</a>.
    /// </summary>
    type SsoadminApplicationAssignmentConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsoadminApplicationAssignmentConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminApplicationAssignmentConfigurationState<Missing, Missing>)

        member _.Zero(()) : SsoadminApplicationAssignmentConfigurationState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SsoadminApplicationAssignmentConfigurationState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application_assignment_configuration#application_arn-1">SsoadminApplicationAssignmentConfiguration#application_arn</a>.
        /// </summary>
        [<CustomOperation "application_arn">]
        member _.ApplicationArn(state: SsoadminApplicationAssignmentConfigurationState<Missing, 'AssignmentRequired>, value: string) : SsoadminApplicationAssignmentConfigurationState<Present, 'AssignmentRequired> =
            state.assignments.Add(fun config -> config.ApplicationArn <- value)
            ({ assignments = state.assignments } : SsoadminApplicationAssignmentConfigurationState<Present, 'AssignmentRequired>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application_assignment_configuration#assignment_required-1">SsoadminApplicationAssignmentConfiguration#assignment_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "assignment_required">]
        member _.AssignmentRequired(state: SsoadminApplicationAssignmentConfigurationState<'ApplicationArn, Missing>, value: bool) : SsoadminApplicationAssignmentConfigurationState<'ApplicationArn, Present> =
            state.assignments.Add(fun config -> config.AssignmentRequired <- value)
            ({ assignments = state.assignments } : SsoadminApplicationAssignmentConfigurationState<'ApplicationArn, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssoadmin_application_assignment_configuration#assignment_required-1">SsoadminApplicationAssignmentConfiguration#assignment_required</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "assignment_required">]
        member _.AssignmentRequired(state: SsoadminApplicationAssignmentConfigurationState<'ApplicationArn, Missing>, value: HashiCorp.Cdktf.IResolvable) : SsoadminApplicationAssignmentConfigurationState<'ApplicationArn, Present> =
            state.assignments.Add(fun config -> config.AssignmentRequired <- value)
            ({ assignments = state.assignments } : SsoadminApplicationAssignmentConfigurationState<'ApplicationArn, Present>)

        member _.Run(state: SsoadminApplicationAssignmentConfigurationState<Present, Present>) : aws.SsoadminApplicationAssignmentConfiguration.SsoadminApplicationAssignmentConfiguration =
            let config = aws.SsoadminApplicationAssignmentConfiguration.SsoadminApplicationAssignmentConfigurationConfig()
            for setter in state.assignments do
                setter config
            aws.SsoadminApplicationAssignmentConfiguration.SsoadminApplicationAssignmentConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssoadminApplicationAssignmentConfiguration: missing required arguments. Must call: application_arn, assignment_required.", 9999, IsError = true)>]
        member _.Run(_: SsoadminApplicationAssignmentConfigurationState<_, _>) : aws.SsoadminApplicationAssignmentConfiguration.SsoadminApplicationAssignmentConfiguration =
            Unchecked.defaultof<aws.SsoadminApplicationAssignmentConfiguration.SsoadminApplicationAssignmentConfiguration>
