namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type GuarddutyOrganizationAdminAccountState<'AdminAccountId> = { assignments: ResizeArray<aws.GuarddutyOrganizationAdminAccount.GuarddutyOrganizationAdminAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_admin_account">aws_guardduty_organization_admin_account</a>.
    /// </summary>
    type GuarddutyOrganizationAdminAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : GuarddutyOrganizationAdminAccountState<Missing> =
            ({ assignments = ResizeArray() } : GuarddutyOrganizationAdminAccountState<Missing>)

        member _.Zero(()) : GuarddutyOrganizationAdminAccountState<Missing> =
            ({ assignments = ResizeArray() } : GuarddutyOrganizationAdminAccountState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_admin_account#admin_account_id-1">GuarddutyOrganizationAdminAccount#admin_account_id</a>.
        /// </summary>
        [<CustomOperation "admin_account_id">]
        member _.AdminAccountId(state: GuarddutyOrganizationAdminAccountState<Missing>, value: string) : GuarddutyOrganizationAdminAccountState<Present> =
            state.assignments.Add(fun config -> config.AdminAccountId <- value)
            ({ assignments = state.assignments } : GuarddutyOrganizationAdminAccountState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/guardduty_organization_admin_account#id-1">GuarddutyOrganizationAdminAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: GuarddutyOrganizationAdminAccountState<'AdminAccountId>, value: string) : GuarddutyOrganizationAdminAccountState<'AdminAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : GuarddutyOrganizationAdminAccountState<'AdminAccountId>

        member _.Run(state: GuarddutyOrganizationAdminAccountState<Present>) : aws.GuarddutyOrganizationAdminAccount.GuarddutyOrganizationAdminAccount =
            let config = aws.GuarddutyOrganizationAdminAccount.GuarddutyOrganizationAdminAccountConfig()
            for setter in state.assignments do
                setter config
            aws.GuarddutyOrganizationAdminAccount.GuarddutyOrganizationAdminAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.guarddutyOrganizationAdminAccount: missing required arguments. Must call: admin_account_id.", 9999, IsError = true)>]
        member _.Run(_: GuarddutyOrganizationAdminAccountState<_>) : aws.GuarddutyOrganizationAdminAccount.GuarddutyOrganizationAdminAccount =
            Unchecked.defaultof<aws.GuarddutyOrganizationAdminAccount.GuarddutyOrganizationAdminAccount>
