namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOrganizationsPoliciesForTargetState<'Filter, 'TargetId> = { assignments: ResizeArray<aws.DataAwsOrganizationsPoliciesForTarget.DataAwsOrganizationsPoliciesForTargetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_policies_for_target">aws_organizations_policies_for_target</a>.
    /// </summary>
    type DataAwsOrganizationsPoliciesForTargetBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOrganizationsPoliciesForTargetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsPoliciesForTargetState<Missing, Missing>)

        member _.Zero(()) : DataAwsOrganizationsPoliciesForTargetState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsPoliciesForTargetState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_policies_for_target#filter-1">DataAwsOrganizationsPoliciesForTarget#filter</a>.
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsOrganizationsPoliciesForTargetState<Missing, 'TargetId>, value: string) : DataAwsOrganizationsPoliciesForTargetState<Present, 'TargetId> =
            state.assignments.Add(fun config -> config.Filter <- value)
            ({ assignments = state.assignments } : DataAwsOrganizationsPoliciesForTargetState<Present, 'TargetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_policies_for_target#target_id-1">DataAwsOrganizationsPoliciesForTarget#target_id</a>.
        /// </summary>
        [<CustomOperation "target_id">]
        member _.TargetId(state: DataAwsOrganizationsPoliciesForTargetState<'Filter, Missing>, value: string) : DataAwsOrganizationsPoliciesForTargetState<'Filter, Present> =
            state.assignments.Add(fun config -> config.TargetId <- value)
            ({ assignments = state.assignments } : DataAwsOrganizationsPoliciesForTargetState<'Filter, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_policies_for_target#id-1">DataAwsOrganizationsPoliciesForTarget#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOrganizationsPoliciesForTargetState<'Filter, 'TargetId>, value: string) : DataAwsOrganizationsPoliciesForTargetState<'Filter, 'TargetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOrganizationsPoliciesForTargetState<'Filter, 'TargetId>

        member _.Run(state: DataAwsOrganizationsPoliciesForTargetState<Present, Present>) : aws.DataAwsOrganizationsPoliciesForTarget.DataAwsOrganizationsPoliciesForTarget =
            let config = aws.DataAwsOrganizationsPoliciesForTarget.DataAwsOrganizationsPoliciesForTargetConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOrganizationsPoliciesForTarget.DataAwsOrganizationsPoliciesForTarget(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOrganizationsPoliciesForTarget: missing required arguments. Must call: filter, target_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOrganizationsPoliciesForTargetState<_, _>) : aws.DataAwsOrganizationsPoliciesForTarget.DataAwsOrganizationsPoliciesForTarget =
            Unchecked.defaultof<aws.DataAwsOrganizationsPoliciesForTarget.DataAwsOrganizationsPoliciesForTarget>
