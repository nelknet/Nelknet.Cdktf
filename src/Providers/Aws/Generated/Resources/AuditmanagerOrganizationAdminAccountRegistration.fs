namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AuditmanagerOrganizationAdminAccountRegistrationState<'AdminAccountId> = { assignments: ResizeArray<aws.AuditmanagerOrganizationAdminAccountRegistration.AuditmanagerOrganizationAdminAccountRegistrationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_organization_admin_account_registration">aws_auditmanager_organization_admin_account_registration</a>.
    /// </summary>
    type AuditmanagerOrganizationAdminAccountRegistrationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AuditmanagerOrganizationAdminAccountRegistrationState<Missing> =
            ({ assignments = ResizeArray() } : AuditmanagerOrganizationAdminAccountRegistrationState<Missing>)

        member _.Zero(()) : AuditmanagerOrganizationAdminAccountRegistrationState<Missing> =
            ({ assignments = ResizeArray() } : AuditmanagerOrganizationAdminAccountRegistrationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_organization_admin_account_registration#admin_account_id-1">AuditmanagerOrganizationAdminAccountRegistration#admin_account_id</a>.
        /// </summary>
        [<CustomOperation "admin_account_id">]
        member _.AdminAccountId(state: AuditmanagerOrganizationAdminAccountRegistrationState<Missing>, value: string) : AuditmanagerOrganizationAdminAccountRegistrationState<Present> =
            state.assignments.Add(fun config -> config.AdminAccountId <- value)
            ({ assignments = state.assignments } : AuditmanagerOrganizationAdminAccountRegistrationState<Present>)

        member _.Run(state: AuditmanagerOrganizationAdminAccountRegistrationState<Present>) : aws.AuditmanagerOrganizationAdminAccountRegistration.AuditmanagerOrganizationAdminAccountRegistration =
            let config = aws.AuditmanagerOrganizationAdminAccountRegistration.AuditmanagerOrganizationAdminAccountRegistrationConfig()
            for setter in state.assignments do
                setter config
            aws.AuditmanagerOrganizationAdminAccountRegistration.AuditmanagerOrganizationAdminAccountRegistration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.auditmanagerOrganizationAdminAccountRegistration: missing required arguments. Must call: admin_account_id.", 9999, IsError = true)>]
        member _.Run(_: AuditmanagerOrganizationAdminAccountRegistrationState<_>) : aws.AuditmanagerOrganizationAdminAccountRegistration.AuditmanagerOrganizationAdminAccountRegistration =
            Unchecked.defaultof<aws.AuditmanagerOrganizationAdminAccountRegistration.AuditmanagerOrganizationAdminAccountRegistration>
