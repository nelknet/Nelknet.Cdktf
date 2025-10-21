namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOrganizationsPolicyState<'PolicyId> = { assignments: ResizeArray<aws.DataAwsOrganizationsPolicy.DataAwsOrganizationsPolicyConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_policy">aws_organizations_policy</a>.
    /// </summary>
    type DataAwsOrganizationsPolicyBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOrganizationsPolicyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsPolicyState<Missing>)

        member _.Zero(()) : DataAwsOrganizationsPolicyState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsPolicyState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_policy#policy_id-1">DataAwsOrganizationsPolicy#policy_id</a>.
        /// </summary>
        [<CustomOperation "policy_id">]
        member _.PolicyId(state: DataAwsOrganizationsPolicyState<Missing>, value: string) : DataAwsOrganizationsPolicyState<Present> =
            state.assignments.Add(fun config -> config.PolicyId <- value)
            ({ assignments = state.assignments } : DataAwsOrganizationsPolicyState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_policy#id-1">DataAwsOrganizationsPolicy#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOrganizationsPolicyState<'PolicyId>, value: string) : DataAwsOrganizationsPolicyState<'PolicyId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOrganizationsPolicyState<'PolicyId>

        member _.Run(state: DataAwsOrganizationsPolicyState<Present>) : aws.DataAwsOrganizationsPolicy.DataAwsOrganizationsPolicy =
            let config = aws.DataAwsOrganizationsPolicy.DataAwsOrganizationsPolicyConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOrganizationsPolicy.DataAwsOrganizationsPolicy(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOrganizationsPolicy: missing required arguments. Must call: policy_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOrganizationsPolicyState<_>) : aws.DataAwsOrganizationsPolicy.DataAwsOrganizationsPolicy =
            Unchecked.defaultof<aws.DataAwsOrganizationsPolicy.DataAwsOrganizationsPolicy>
