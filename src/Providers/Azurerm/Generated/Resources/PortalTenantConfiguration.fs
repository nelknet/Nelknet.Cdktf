namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type PortalTenantConfigurationState<'PrivateMarkdownStorageEnforced> = { assignments: ResizeArray<azurerm.PortalTenantConfiguration.PortalTenantConfigurationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/portal_tenant_configuration">azurerm_portal_tenant_configuration</a>.
    /// </summary>
    type PortalTenantConfigurationBuilder(logicalId: string) =
        member _.Yield(_: unit) : PortalTenantConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : PortalTenantConfigurationState<Missing>)

        member _.Zero(()) : PortalTenantConfigurationState<Missing> =
            ({ assignments = ResizeArray() } : PortalTenantConfigurationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/portal_tenant_configuration#private_markdown_storage_enforced-1">PortalTenantConfiguration#private_markdown_storage_enforced</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "private_markdown_storage_enforced">]
        member _.PrivateMarkdownStorageEnforced(state: PortalTenantConfigurationState<Missing>, value: bool) : PortalTenantConfigurationState<Present> =
            state.assignments.Add(fun config -> config.PrivateMarkdownStorageEnforced <- value)
            ({ assignments = state.assignments } : PortalTenantConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/portal_tenant_configuration#private_markdown_storage_enforced-1">PortalTenantConfiguration#private_markdown_storage_enforced</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "private_markdown_storage_enforced">]
        member _.PrivateMarkdownStorageEnforced(state: PortalTenantConfigurationState<Missing>, value: HashiCorp.Cdktf.IResolvable) : PortalTenantConfigurationState<Present> =
            state.assignments.Add(fun config -> config.PrivateMarkdownStorageEnforced <- value)
            ({ assignments = state.assignments } : PortalTenantConfigurationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/portal_tenant_configuration#id-1">PortalTenantConfiguration#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: PortalTenantConfigurationState<'PrivateMarkdownStorageEnforced>, value: string) : PortalTenantConfigurationState<'PrivateMarkdownStorageEnforced> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : PortalTenantConfigurationState<'PrivateMarkdownStorageEnforced>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/portal_tenant_configuration#timeouts-1">PortalTenantConfiguration#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: PortalTenantConfigurationState<'PrivateMarkdownStorageEnforced>, value: azurerm.PortalTenantConfiguration.PortalTenantConfigurationTimeouts) : PortalTenantConfigurationState<'PrivateMarkdownStorageEnforced> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : PortalTenantConfigurationState<'PrivateMarkdownStorageEnforced>

        member _.Run(state: PortalTenantConfigurationState<Present>) : azurerm.PortalTenantConfiguration.PortalTenantConfiguration =
            let config = azurerm.PortalTenantConfiguration.PortalTenantConfigurationConfig()
            for setter in state.assignments do
                setter config
            azurerm.PortalTenantConfiguration.PortalTenantConfiguration(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.portalTenantConfiguration: missing required arguments. Must call: private_markdown_storage_enforced.", 9999, IsError = true)>]
        member _.Run(_: PortalTenantConfigurationState<_>) : azurerm.PortalTenantConfiguration.PortalTenantConfiguration =
            Unchecked.defaultof<azurerm.PortalTenantConfiguration.PortalTenantConfiguration>
