namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AuditmanagerAccountRegistrationState = { assignments: ResizeArray<aws.AuditmanagerAccountRegistration.AuditmanagerAccountRegistrationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_account_registration">aws_auditmanager_account_registration</a>.
    /// </summary>
    type AuditmanagerAccountRegistrationBuilder(logicalId: string) =
        member _.Yield(_: unit) : AuditmanagerAccountRegistrationState =
            { assignments = ResizeArray() }

        member _.Zero(()) : AuditmanagerAccountRegistrationState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_account_registration#delegated_admin_account-1">AuditmanagerAccountRegistration#delegated_admin_account</a>.
        /// </summary>
        [<CustomOperation "delegated_admin_account">]
        member _.DelegatedAdminAccount(state: AuditmanagerAccountRegistrationState, value: string) : AuditmanagerAccountRegistrationState =
            state.assignments.Add(fun config -> config.DelegatedAdminAccount <- value)
            state : AuditmanagerAccountRegistrationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_account_registration#deregister_on_destroy-1">AuditmanagerAccountRegistration#deregister_on_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deregister_on_destroy">]
        member _.DeregisterOnDestroy(state: AuditmanagerAccountRegistrationState, value: bool) : AuditmanagerAccountRegistrationState =
            state.assignments.Add(fun config -> config.DeregisterOnDestroy <- value)
            state : AuditmanagerAccountRegistrationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_account_registration#deregister_on_destroy-1">AuditmanagerAccountRegistration#deregister_on_destroy</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "deregister_on_destroy">]
        member _.DeregisterOnDestroy(state: AuditmanagerAccountRegistrationState, value: HashiCorp.Cdktf.IResolvable) : AuditmanagerAccountRegistrationState =
            state.assignments.Add(fun config -> config.DeregisterOnDestroy <- value)
            state : AuditmanagerAccountRegistrationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/auditmanager_account_registration#kms_key-1">AuditmanagerAccountRegistration#kms_key</a>.
        /// </summary>
        [<CustomOperation "kms_key">]
        member _.KmsKey(state: AuditmanagerAccountRegistrationState, value: string) : AuditmanagerAccountRegistrationState =
            state.assignments.Add(fun config -> config.KmsKey <- value)
            state : AuditmanagerAccountRegistrationState

        member _.Run(state: AuditmanagerAccountRegistrationState) : aws.AuditmanagerAccountRegistration.AuditmanagerAccountRegistration =
            let config = aws.AuditmanagerAccountRegistration.AuditmanagerAccountRegistrationConfig()
            for setter in state.assignments do
                setter config
            aws.AuditmanagerAccountRegistration.AuditmanagerAccountRegistration(StackContext.get (), logicalId, config)
