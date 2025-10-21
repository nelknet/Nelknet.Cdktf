namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOrganizationsOrganizationalUnitDescendantAccountsState<'ParentId> = { assignments: ResizeArray<aws.DataAwsOrganizationsOrganizationalUnitDescendantAccounts.DataAwsOrganizationsOrganizationalUnitDescendantAccountsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_unit_descendant_accounts">aws_organizations_organizational_unit_descendant_accounts</a>.
    /// </summary>
    type DataAwsOrganizationsOrganizationalUnitDescendantAccountsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOrganizationsOrganizationalUnitDescendantAccountsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsOrganizationalUnitDescendantAccountsState<Missing>)

        member _.Zero(()) : DataAwsOrganizationsOrganizationalUnitDescendantAccountsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsOrganizationalUnitDescendantAccountsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_unit_descendant_accounts#parent_id-1">DataAwsOrganizationsOrganizationalUnitDescendantAccounts#parent_id</a>.
        /// </summary>
        [<CustomOperation "parent_id">]
        member _.ParentId(state: DataAwsOrganizationsOrganizationalUnitDescendantAccountsState<Missing>, value: string) : DataAwsOrganizationsOrganizationalUnitDescendantAccountsState<Present> =
            state.assignments.Add(fun config -> config.ParentId <- value)
            ({ assignments = state.assignments } : DataAwsOrganizationsOrganizationalUnitDescendantAccountsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_unit_descendant_accounts#id-1">DataAwsOrganizationsOrganizationalUnitDescendantAccounts#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOrganizationsOrganizationalUnitDescendantAccountsState<'ParentId>, value: string) : DataAwsOrganizationsOrganizationalUnitDescendantAccountsState<'ParentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOrganizationsOrganizationalUnitDescendantAccountsState<'ParentId>

        member _.Run(state: DataAwsOrganizationsOrganizationalUnitDescendantAccountsState<Present>) : aws.DataAwsOrganizationsOrganizationalUnitDescendantAccounts.DataAwsOrganizationsOrganizationalUnitDescendantAccounts =
            let config = aws.DataAwsOrganizationsOrganizationalUnitDescendantAccounts.DataAwsOrganizationsOrganizationalUnitDescendantAccountsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOrganizationsOrganizationalUnitDescendantAccounts.DataAwsOrganizationsOrganizationalUnitDescendantAccounts(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOrganizationsOrganizationalUnitDescendantAccounts: missing required arguments. Must call: parent_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOrganizationsOrganizationalUnitDescendantAccountsState<_>) : aws.DataAwsOrganizationsOrganizationalUnitDescendantAccounts.DataAwsOrganizationsOrganizationalUnitDescendantAccounts =
            Unchecked.defaultof<aws.DataAwsOrganizationsOrganizationalUnitDescendantAccounts.DataAwsOrganizationsOrganizationalUnitDescendantAccounts>
