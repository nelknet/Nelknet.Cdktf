namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type VpcIpamOrganizationAdminAccountState<'DelegatedAdminAccountId> = { assignments: ResizeArray<aws.VpcIpamOrganizationAdminAccount.VpcIpamOrganizationAdminAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_organization_admin_account">aws_vpc_ipam_organization_admin_account</a>.
    /// </summary>
    type VpcIpamOrganizationAdminAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : VpcIpamOrganizationAdminAccountState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpamOrganizationAdminAccountState<Missing>)

        member _.Zero(()) : VpcIpamOrganizationAdminAccountState<Missing> =
            ({ assignments = ResizeArray() } : VpcIpamOrganizationAdminAccountState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_organization_admin_account#delegated_admin_account_id-1">VpcIpamOrganizationAdminAccount#delegated_admin_account_id</a>.
        /// </summary>
        [<CustomOperation "delegated_admin_account_id">]
        member _.DelegatedAdminAccountId(state: VpcIpamOrganizationAdminAccountState<Missing>, value: string) : VpcIpamOrganizationAdminAccountState<Present> =
            state.assignments.Add(fun config -> config.DelegatedAdminAccountId <- value)
            ({ assignments = state.assignments } : VpcIpamOrganizationAdminAccountState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpc_ipam_organization_admin_account#id-1">VpcIpamOrganizationAdminAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: VpcIpamOrganizationAdminAccountState<'DelegatedAdminAccountId>, value: string) : VpcIpamOrganizationAdminAccountState<'DelegatedAdminAccountId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : VpcIpamOrganizationAdminAccountState<'DelegatedAdminAccountId>

        member _.Run(state: VpcIpamOrganizationAdminAccountState<Present>) : aws.VpcIpamOrganizationAdminAccount.VpcIpamOrganizationAdminAccount =
            let config = aws.VpcIpamOrganizationAdminAccount.VpcIpamOrganizationAdminAccountConfig()
            for setter in state.assignments do
                setter config
            aws.VpcIpamOrganizationAdminAccount.VpcIpamOrganizationAdminAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.vpcIpamOrganizationAdminAccount: missing required arguments. Must call: delegated_admin_account_id.", 9999, IsError = true)>]
        member _.Run(_: VpcIpamOrganizationAdminAccountState<_>) : aws.VpcIpamOrganizationAdminAccount.VpcIpamOrganizationAdminAccount =
            Unchecked.defaultof<aws.VpcIpamOrganizationAdminAccount.VpcIpamOrganizationAdminAccount>
