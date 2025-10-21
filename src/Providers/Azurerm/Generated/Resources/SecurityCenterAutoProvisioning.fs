namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SecurityCenterAutoProvisioningState<'AutoProvision> = { assignments: ResizeArray<azurerm.SecurityCenterAutoProvisioning.SecurityCenterAutoProvisioningConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_auto_provisioning">azurerm_security_center_auto_provisioning</a>.
    /// </summary>
    type SecurityCenterAutoProvisioningBuilder(logicalId: string) =
        member _.Yield(_: unit) : SecurityCenterAutoProvisioningState<Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterAutoProvisioningState<Missing>)

        member _.Zero(()) : SecurityCenterAutoProvisioningState<Missing> =
            ({ assignments = ResizeArray() } : SecurityCenterAutoProvisioningState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_auto_provisioning#auto_provision-1">SecurityCenterAutoProvisioning#auto_provision</a>.
        /// </summary>
        [<CustomOperation "auto_provision">]
        member _.AutoProvision(state: SecurityCenterAutoProvisioningState<Missing>, value: string) : SecurityCenterAutoProvisioningState<Present> =
            state.assignments.Add(fun config -> config.AutoProvision <- value)
            ({ assignments = state.assignments } : SecurityCenterAutoProvisioningState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_auto_provisioning#id-1">SecurityCenterAutoProvisioning#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SecurityCenterAutoProvisioningState<'AutoProvision>, value: string) : SecurityCenterAutoProvisioningState<'AutoProvision> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SecurityCenterAutoProvisioningState<'AutoProvision>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/security_center_auto_provisioning#timeouts-1">SecurityCenterAutoProvisioning#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SecurityCenterAutoProvisioningState<'AutoProvision>, value: azurerm.SecurityCenterAutoProvisioning.SecurityCenterAutoProvisioningTimeouts) : SecurityCenterAutoProvisioningState<'AutoProvision> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SecurityCenterAutoProvisioningState<'AutoProvision>

        member _.Run(state: SecurityCenterAutoProvisioningState<Present>) : azurerm.SecurityCenterAutoProvisioning.SecurityCenterAutoProvisioning =
            let config = azurerm.SecurityCenterAutoProvisioning.SecurityCenterAutoProvisioningConfig()
            for setter in state.assignments do
                setter config
            azurerm.SecurityCenterAutoProvisioning.SecurityCenterAutoProvisioning(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.securityCenterAutoProvisioning: missing required arguments. Must call: auto_provision.", 9999, IsError = true)>]
        member _.Run(_: SecurityCenterAutoProvisioningState<_>) : azurerm.SecurityCenterAutoProvisioning.SecurityCenterAutoProvisioning =
            Unchecked.defaultof<azurerm.SecurityCenterAutoProvisioning.SecurityCenterAutoProvisioning>
