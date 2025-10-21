namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Macie2OrganizationAdminAccountState<'AdminAccountId> = { assignments: ResizeArray<aws.Macie2OrganizationAdminAccount.Macie2OrganizationAdminAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_organization_admin_account">aws_macie2_organization_admin_account</a>.
    /// </summary>
    type Macie2OrganizationAdminAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : Macie2OrganizationAdminAccountState<Missing> =
            ({ assignments = ResizeArray() } : Macie2OrganizationAdminAccountState<Missing>)

        member _.Zero(()) : Macie2OrganizationAdminAccountState<Missing> =
            ({ assignments = ResizeArray() } : Macie2OrganizationAdminAccountState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_organization_admin_account#admin_account_id-1">Macie2OrganizationAdminAccount#admin_account_id</a>.
        /// </summary>
        [<CustomOperation "admin_account_id">]
        member _.AdminAccountId(state: Macie2OrganizationAdminAccountState<Missing>, value: string) : Macie2OrganizationAdminAccountState<Present> =
            state.assignments.Add(fun config -> config.AdminAccountId <- value)
            ({ assignments = state.assignments } : Macie2OrganizationAdminAccountState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/macie2_organization_admin_account#id-1">Macie2OrganizationAdminAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Macie2OrganizationAdminAccountState<'AdminAccountId>, value: string) : Macie2OrganizationAdminAccountState<'AdminAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Macie2OrganizationAdminAccountState<'AdminAccountId>

        member _.Run(state: Macie2OrganizationAdminAccountState<Present>) : aws.Macie2OrganizationAdminAccount.Macie2OrganizationAdminAccount =
            let config = aws.Macie2OrganizationAdminAccount.Macie2OrganizationAdminAccountConfig()
            for setter in state.assignments do
                setter config
            aws.Macie2OrganizationAdminAccount.Macie2OrganizationAdminAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.macie2OrganizationAdminAccount: missing required arguments. Must call: admin_account_id.", 9999, IsError = true)>]
        member _.Run(_: Macie2OrganizationAdminAccountState<_>) : aws.Macie2OrganizationAdminAccount.Macie2OrganizationAdminAccount =
            Unchecked.defaultof<aws.Macie2OrganizationAdminAccount.Macie2OrganizationAdminAccount>
