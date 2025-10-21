namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOrganizationsPoliciesState<'Filter> = { assignments: ResizeArray<aws.DataAwsOrganizationsPolicies.DataAwsOrganizationsPoliciesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_policies">aws_organizations_policies</a>.
    /// </summary>
    type DataAwsOrganizationsPoliciesBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOrganizationsPoliciesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsPoliciesState<Missing>)

        member _.Zero(()) : DataAwsOrganizationsPoliciesState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsPoliciesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_policies#filter-1">DataAwsOrganizationsPolicies#filter</a>.
        /// </summary>
        [<CustomOperation "filter">]
        member _.Filter(state: DataAwsOrganizationsPoliciesState<Missing>, value: string) : DataAwsOrganizationsPoliciesState<Present> =
            state.assignments.Add(fun config -> config.Filter <- value)
            ({ assignments = state.assignments } : DataAwsOrganizationsPoliciesState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_policies#id-1">DataAwsOrganizationsPolicies#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOrganizationsPoliciesState<'Filter>, value: string) : DataAwsOrganizationsPoliciesState<'Filter> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOrganizationsPoliciesState<'Filter>

        member _.Run(state: DataAwsOrganizationsPoliciesState<Present>) : aws.DataAwsOrganizationsPolicies.DataAwsOrganizationsPolicies =
            let config = aws.DataAwsOrganizationsPolicies.DataAwsOrganizationsPoliciesConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOrganizationsPolicies.DataAwsOrganizationsPolicies(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOrganizationsPolicies: missing required arguments. Must call: filter.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOrganizationsPoliciesState<_>) : aws.DataAwsOrganizationsPolicies.DataAwsOrganizationsPolicies =
            Unchecked.defaultof<aws.DataAwsOrganizationsPolicies.DataAwsOrganizationsPolicies>
