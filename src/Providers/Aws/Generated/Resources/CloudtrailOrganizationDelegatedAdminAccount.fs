namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudtrailOrganizationDelegatedAdminAccountState<'AccountId> = { assignments: ResizeArray<aws.CloudtrailOrganizationDelegatedAdminAccount.CloudtrailOrganizationDelegatedAdminAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_organization_delegated_admin_account">aws_cloudtrail_organization_delegated_admin_account</a>.
    /// </summary>
    type CloudtrailOrganizationDelegatedAdminAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudtrailOrganizationDelegatedAdminAccountState<Missing> =
            ({ assignments = ResizeArray() } : CloudtrailOrganizationDelegatedAdminAccountState<Missing>)

        member _.Zero(()) : CloudtrailOrganizationDelegatedAdminAccountState<Missing> =
            ({ assignments = ResizeArray() } : CloudtrailOrganizationDelegatedAdminAccountState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudtrail_organization_delegated_admin_account#account_id-1">CloudtrailOrganizationDelegatedAdminAccount#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: CloudtrailOrganizationDelegatedAdminAccountState<Missing>, value: string) : CloudtrailOrganizationDelegatedAdminAccountState<Present> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : CloudtrailOrganizationDelegatedAdminAccountState<Present>)

        member _.Run(state: CloudtrailOrganizationDelegatedAdminAccountState<Present>) : aws.CloudtrailOrganizationDelegatedAdminAccount.CloudtrailOrganizationDelegatedAdminAccount =
            let config = aws.CloudtrailOrganizationDelegatedAdminAccount.CloudtrailOrganizationDelegatedAdminAccountConfig()
            for setter in state.assignments do
                setter config
            aws.CloudtrailOrganizationDelegatedAdminAccount.CloudtrailOrganizationDelegatedAdminAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudtrailOrganizationDelegatedAdminAccount: missing required arguments. Must call: account_id.", 9999, IsError = true)>]
        member _.Run(_: CloudtrailOrganizationDelegatedAdminAccountState<_>) : aws.CloudtrailOrganizationDelegatedAdminAccount.CloudtrailOrganizationDelegatedAdminAccount =
            Unchecked.defaultof<aws.CloudtrailOrganizationDelegatedAdminAccount.CloudtrailOrganizationDelegatedAdminAccount>
