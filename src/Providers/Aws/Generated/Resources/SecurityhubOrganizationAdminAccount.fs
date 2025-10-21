namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityhubOrganizationAdminAccountState<'AdminAccountId> = { assignments: ResizeArray<aws.SecurityhubOrganizationAdminAccount.SecurityhubOrganizationAdminAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_organization_admin_account">aws_securityhub_organization_admin_account</a>.
    /// </summary>
    type SecurityhubOrganizationAdminAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityhubOrganizationAdminAccountState<Missing> =
            ({ assignments = ResizeArray() } : SecurityhubOrganizationAdminAccountState<Missing>)

        member _.Zero(()) : SecurityhubOrganizationAdminAccountState<Missing> =
            ({ assignments = ResizeArray() } : SecurityhubOrganizationAdminAccountState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_organization_admin_account#admin_account_id-1">SecurityhubOrganizationAdminAccount#admin_account_id</a>.
        /// </summary>
        [<CustomOperation "admin_account_id">]
        member _.AdminAccountId(state: SecurityhubOrganizationAdminAccountState<Missing>, value: string) : SecurityhubOrganizationAdminAccountState<Present> =
            state.assignments.Add(fun config -> config.AdminAccountId <- value)
            ({ assignments = state.assignments } : SecurityhubOrganizationAdminAccountState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/securityhub_organization_admin_account#id-1">SecurityhubOrganizationAdminAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityhubOrganizationAdminAccountState<'AdminAccountId>, value: string) : SecurityhubOrganizationAdminAccountState<'AdminAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityhubOrganizationAdminAccountState<'AdminAccountId>

        member _.Run(state: SecurityhubOrganizationAdminAccountState<Present>) : aws.SecurityhubOrganizationAdminAccount.SecurityhubOrganizationAdminAccount =
            let config = aws.SecurityhubOrganizationAdminAccount.SecurityhubOrganizationAdminAccountConfig()
            for setter in state.assignments do
                setter config
            aws.SecurityhubOrganizationAdminAccount.SecurityhubOrganizationAdminAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.securityhubOrganizationAdminAccount: missing required arguments. Must call: admin_account_id.", 9999, IsError = true)>]
        member _.Run(_: SecurityhubOrganizationAdminAccountState<_>) : aws.SecurityhubOrganizationAdminAccount.SecurityhubOrganizationAdminAccount =
            Unchecked.defaultof<aws.SecurityhubOrganizationAdminAccount.SecurityhubOrganizationAdminAccount>
