namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DetectiveOrganizationAdminAccountState<'AccountId> = { assignments: ResizeArray<aws.DetectiveOrganizationAdminAccount.DetectiveOrganizationAdminAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_organization_admin_account">aws_detective_organization_admin_account</a>.
    /// </summary>
    type DetectiveOrganizationAdminAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : DetectiveOrganizationAdminAccountState<Missing> =
            ({ assignments = ResizeArray() } : DetectiveOrganizationAdminAccountState<Missing>)

        member _.Zero(()) : DetectiveOrganizationAdminAccountState<Missing> =
            ({ assignments = ResizeArray() } : DetectiveOrganizationAdminAccountState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_organization_admin_account#account_id-1">DetectiveOrganizationAdminAccount#account_id</a>.
        /// </summary>
        [<CustomOperation "account_id">]
        member _.AccountId(state: DetectiveOrganizationAdminAccountState<Missing>, value: string) : DetectiveOrganizationAdminAccountState<Present> =
            state.assignments.Add(fun config -> config.AccountId <- value)
            ({ assignments = state.assignments } : DetectiveOrganizationAdminAccountState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/detective_organization_admin_account#id-1">DetectiveOrganizationAdminAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DetectiveOrganizationAdminAccountState<'AccountId>, value: string) : DetectiveOrganizationAdminAccountState<'AccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DetectiveOrganizationAdminAccountState<'AccountId>

        member _.Run(state: DetectiveOrganizationAdminAccountState<Present>) : aws.DetectiveOrganizationAdminAccount.DetectiveOrganizationAdminAccount =
            let config = aws.DetectiveOrganizationAdminAccount.DetectiveOrganizationAdminAccountConfig()
            for setter in state.assignments do
                setter config
            aws.DetectiveOrganizationAdminAccount.DetectiveOrganizationAdminAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.detectiveOrganizationAdminAccount: missing required arguments. Must call: account_id.", 9999, IsError = true)>]
        member _.Run(_: DetectiveOrganizationAdminAccountState<_>) : aws.DetectiveOrganizationAdminAccount.DetectiveOrganizationAdminAccount =
            Unchecked.defaultof<aws.DetectiveOrganizationAdminAccount.DetectiveOrganizationAdminAccount>
