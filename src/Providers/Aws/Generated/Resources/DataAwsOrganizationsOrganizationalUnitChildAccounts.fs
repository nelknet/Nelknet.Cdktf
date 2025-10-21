namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsOrganizationsOrganizationalUnitChildAccountsState<'ParentId> = { assignments: ResizeArray<aws.DataAwsOrganizationsOrganizationalUnitChildAccounts.DataAwsOrganizationsOrganizationalUnitChildAccountsConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_unit_child_accounts">aws_organizations_organizational_unit_child_accounts</a>.
    /// </summary>
    type DataAwsOrganizationsOrganizationalUnitChildAccountsBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsOrganizationsOrganizationalUnitChildAccountsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsOrganizationalUnitChildAccountsState<Missing>)

        member _.Zero(()) : DataAwsOrganizationsOrganizationalUnitChildAccountsState<Missing> =
            ({ assignments = ResizeArray() } : DataAwsOrganizationsOrganizationalUnitChildAccountsState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_unit_child_accounts#parent_id-1">DataAwsOrganizationsOrganizationalUnitChildAccounts#parent_id</a>.
        /// </summary>
        [<CustomOperation "parent_id">]
        member _.ParentId(state: DataAwsOrganizationsOrganizationalUnitChildAccountsState<Missing>, value: string) : DataAwsOrganizationsOrganizationalUnitChildAccountsState<Present> =
            state.assignments.Add(fun config -> config.ParentId <- value)
            ({ assignments = state.assignments } : DataAwsOrganizationsOrganizationalUnitChildAccountsState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/organizations_organizational_unit_child_accounts#id-1">DataAwsOrganizationsOrganizationalUnitChildAccounts#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsOrganizationsOrganizationalUnitChildAccountsState<'ParentId>, value: string) : DataAwsOrganizationsOrganizationalUnitChildAccountsState<'ParentId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsOrganizationsOrganizationalUnitChildAccountsState<'ParentId>

        member _.Run(state: DataAwsOrganizationsOrganizationalUnitChildAccountsState<Present>) : aws.DataAwsOrganizationsOrganizationalUnitChildAccounts.DataAwsOrganizationsOrganizationalUnitChildAccounts =
            let config = aws.DataAwsOrganizationsOrganizationalUnitChildAccounts.DataAwsOrganizationsOrganizationalUnitChildAccountsConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsOrganizationsOrganizationalUnitChildAccounts.DataAwsOrganizationsOrganizationalUnitChildAccounts(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsOrganizationsOrganizationalUnitChildAccounts: missing required arguments. Must call: parent_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsOrganizationsOrganizationalUnitChildAccountsState<_>) : aws.DataAwsOrganizationsOrganizationalUnitChildAccounts.DataAwsOrganizationsOrganizationalUnitChildAccounts =
            Unchecked.defaultof<aws.DataAwsOrganizationsOrganizationalUnitChildAccounts.DataAwsOrganizationsOrganizationalUnitChildAccounts>
