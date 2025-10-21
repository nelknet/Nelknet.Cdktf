namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> = { assignments: ResizeArray<azurerm.KeyVaultManagedHardwareSecurityModule.KeyVaultManagedHardwareSecurityModuleConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module">azurerm_key_vault_managed_hardware_security_module</a>.
    /// </summary>
    type KeyVaultManagedHardwareSecurityModuleBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyVaultManagedHardwareSecurityModuleState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultManagedHardwareSecurityModuleState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KeyVaultManagedHardwareSecurityModuleState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultManagedHardwareSecurityModuleState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#admin_object_ids-1">KeyVaultManagedHardwareSecurityModule#admin_object_ids</a>.
        /// </summary>
        [<CustomOperation "admin_object_ids">]
        member _.AdminObjectIds(state: KeyVaultManagedHardwareSecurityModuleState<Missing, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: seq<string>) : KeyVaultManagedHardwareSecurityModuleState<Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.AdminObjectIds <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleState<Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#location-1">KeyVaultManagedHardwareSecurityModule#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, Missing, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: string) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, Present, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, Present, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#name-1">KeyVaultManagedHardwareSecurityModule#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, Missing, 'ResourceGroupName, 'SkuName, 'TenantId>, value: string) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, Present, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, Present, 'ResourceGroupName, 'SkuName, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#resource_group_name-1">KeyVaultManagedHardwareSecurityModule#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, Missing, 'SkuName, 'TenantId>, value: string) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, Present, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, Present, 'SkuName, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#sku_name-1">KeyVaultManagedHardwareSecurityModule#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, Missing, 'TenantId>, value: string) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#tenant_id-1">KeyVaultManagedHardwareSecurityModule#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, Missing>, value: string) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#id-1">KeyVaultManagedHardwareSecurityModule#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: string) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// network_acls block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#network_acls-1">KeyVaultManagedHardwareSecurityModule#network_acls</a>
        /// </summary>
        [<CustomOperation "network_acls">]
        member _.NetworkAcls(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: azurerm.KeyVaultManagedHardwareSecurityModule.KeyVaultManagedHardwareSecurityModuleNetworkAcls) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.NetworkAcls <- value)
            state : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#public_network_access_enabled-1">KeyVaultManagedHardwareSecurityModule#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: bool) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#public_network_access_enabled-1">KeyVaultManagedHardwareSecurityModule#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: HashiCorp.Cdktf.IResolvable) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#purge_protection_enabled-1">KeyVaultManagedHardwareSecurityModule#purge_protection_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "purge_protection_enabled">]
        member _.PurgeProtectionEnabled(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: bool) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.PurgeProtectionEnabled <- value)
            state : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#purge_protection_enabled-1">KeyVaultManagedHardwareSecurityModule#purge_protection_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "purge_protection_enabled">]
        member _.PurgeProtectionEnabled(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: HashiCorp.Cdktf.IResolvable) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.PurgeProtectionEnabled <- value)
            state : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#security_domain_key_vault_certificate_ids-1">KeyVaultManagedHardwareSecurityModule#security_domain_key_vault_certificate_ids</a>.
        /// </summary>
        [<CustomOperation "security_domain_key_vault_certificate_ids">]
        member _.SecurityDomainKeyVaultCertificateIds(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: seq<string>) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.SecurityDomainKeyVaultCertificateIds <- (value |> Seq.toArray))
            state : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#security_domain_quorum-1">KeyVaultManagedHardwareSecurityModule#security_domain_quorum</a>.
        /// </summary>
        [<CustomOperation "security_domain_quorum">]
        member _.SecurityDomainQuorum(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: double) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.SecurityDomainQuorum <- value)
            state : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#soft_delete_retention_days-1">KeyVaultManagedHardwareSecurityModule#soft_delete_retention_days</a>.
        /// </summary>
        [<CustomOperation "soft_delete_retention_days">]
        member _.SoftDeleteRetentionDays(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: double) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.SoftDeleteRetentionDays <- value)
            state : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#tags-1">KeyVaultManagedHardwareSecurityModule#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: seq<string * string>) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault_managed_hardware_security_module#timeouts-1">KeyVaultManagedHardwareSecurityModule#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: azurerm.KeyVaultManagedHardwareSecurityModule.KeyVaultManagedHardwareSecurityModuleTimeouts) : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyVaultManagedHardwareSecurityModuleState<'AdminObjectIds, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        member _.Run(state: KeyVaultManagedHardwareSecurityModuleState<Present, Present, Present, Present, Present, Present>) : azurerm.KeyVaultManagedHardwareSecurityModule.KeyVaultManagedHardwareSecurityModule =
            let config = azurerm.KeyVaultManagedHardwareSecurityModule.KeyVaultManagedHardwareSecurityModuleConfig()
            for setter in state.assignments do
                setter config
            azurerm.KeyVaultManagedHardwareSecurityModule.KeyVaultManagedHardwareSecurityModule(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.keyVaultManagedHardwareSecurityModule: missing required arguments. Must call: admin_object_ids, location, name, resource_group_name, sku_name, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: KeyVaultManagedHardwareSecurityModuleState<_, _, _, _, _, _>) : azurerm.KeyVaultManagedHardwareSecurityModule.KeyVaultManagedHardwareSecurityModule =
            Unchecked.defaultof<azurerm.KeyVaultManagedHardwareSecurityModule.KeyVaultManagedHardwareSecurityModule>
