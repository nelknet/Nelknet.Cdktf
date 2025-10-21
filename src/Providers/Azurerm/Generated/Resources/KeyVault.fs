namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> = { assignments: ResizeArray<azurerm.KeyVault.KeyVaultConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault">azurerm_key_vault</a>.
    /// </summary>
    type KeyVaultBuilder(logicalId: string) =
        member _.Yield(_: unit) : KeyVaultState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KeyVaultState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KeyVaultState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#location-1">KeyVault#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: KeyVaultState<Missing, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: string) : KeyVaultState<Present, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : KeyVaultState<Present, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#name-1">KeyVault#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KeyVaultState<'Location, Missing, 'ResourceGroupName, 'SkuName, 'TenantId>, value: string) : KeyVaultState<'Location, Present, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KeyVaultState<'Location, Present, 'ResourceGroupName, 'SkuName, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#resource_group_name-1">KeyVault#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: KeyVaultState<'Location, 'Name, Missing, 'SkuName, 'TenantId>, value: string) : KeyVaultState<'Location, 'Name, Present, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : KeyVaultState<'Location, 'Name, Present, 'SkuName, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#sku_name-1">KeyVault#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, Missing, 'TenantId>, value: string) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, Present, 'TenantId> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : KeyVaultState<'Location, 'Name, 'ResourceGroupName, Present, 'TenantId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#tenant_id-1">KeyVault#tenant_id</a>.
        /// </summary>
        [<CustomOperation "tenant_id">]
        member _.TenantId(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Missing>, value: string) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Present> =
            state.assignments.Add(fun config -> config.TenantId <- value)
            ({ assignments = state.assignments } : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#access_policy-1">KeyVault#access_policy</a>. Accepts: azurerm.IResolvable | azurerm.KeyVault.KeyVaultAccessPolicy[]
        /// </summary>
        [<CustomOperation "access_policy">]
        member _.AccessPolicy(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: HashiCorp.Cdktf.IResolvable) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.AccessPolicy <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// contact block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#contact-1">KeyVault#contact</a> Accepts: azurerm.IResolvable | azurerm.KeyVault.KeyVaultContact[]
        /// </summary>
        [<CustomOperation "contact">]
        member _.Contact(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: HashiCorp.Cdktf.IResolvable) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.Contact <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#enabled_for_deployment-1">KeyVault#enabled_for_deployment</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled_for_deployment">]
        member _.EnabledForDeployment(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: bool) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.EnabledForDeployment <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#enabled_for_deployment-1">KeyVault#enabled_for_deployment</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled_for_deployment">]
        member _.EnabledForDeployment(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: HashiCorp.Cdktf.IResolvable) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.EnabledForDeployment <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#enabled_for_disk_encryption-1">KeyVault#enabled_for_disk_encryption</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled_for_disk_encryption">]
        member _.EnabledForDiskEncryption(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: bool) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.EnabledForDiskEncryption <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#enabled_for_disk_encryption-1">KeyVault#enabled_for_disk_encryption</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled_for_disk_encryption">]
        member _.EnabledForDiskEncryption(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: HashiCorp.Cdktf.IResolvable) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.EnabledForDiskEncryption <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#enabled_for_template_deployment-1">KeyVault#enabled_for_template_deployment</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled_for_template_deployment">]
        member _.EnabledForTemplateDeployment(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: bool) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.EnabledForTemplateDeployment <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#enabled_for_template_deployment-1">KeyVault#enabled_for_template_deployment</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enabled_for_template_deployment">]
        member _.EnabledForTemplateDeployment(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: HashiCorp.Cdktf.IResolvable) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.EnabledForTemplateDeployment <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#enable_rbac_authorization-1">KeyVault#enable_rbac_authorization</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_rbac_authorization">]
        member _.EnableRbacAuthorization(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: bool) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.EnableRbacAuthorization <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#enable_rbac_authorization-1">KeyVault#enable_rbac_authorization</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "enable_rbac_authorization">]
        member _.EnableRbacAuthorization(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: HashiCorp.Cdktf.IResolvable) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.EnableRbacAuthorization <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#id-1">KeyVault#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: string) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// network_acls block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#network_acls-1">KeyVault#network_acls</a>
        /// </summary>
        [<CustomOperation "network_acls">]
        member _.NetworkAcls(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: azurerm.KeyVault.KeyVaultNetworkAcls) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.NetworkAcls <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#public_network_access_enabled-1">KeyVault#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: bool) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#public_network_access_enabled-1">KeyVault#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: HashiCorp.Cdktf.IResolvable) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#purge_protection_enabled-1">KeyVault#purge_protection_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "purge_protection_enabled">]
        member _.PurgeProtectionEnabled(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: bool) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.PurgeProtectionEnabled <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#purge_protection_enabled-1">KeyVault#purge_protection_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "purge_protection_enabled">]
        member _.PurgeProtectionEnabled(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: HashiCorp.Cdktf.IResolvable) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.PurgeProtectionEnabled <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#soft_delete_retention_days-1">KeyVault#soft_delete_retention_days</a>.
        /// </summary>
        [<CustomOperation "soft_delete_retention_days">]
        member _.SoftDeleteRetentionDays(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: double) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.SoftDeleteRetentionDays <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#tags-1">KeyVault#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: seq<string * string>) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/key_vault#timeouts-1">KeyVault#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>, value: azurerm.KeyVault.KeyVaultTimeouts) : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KeyVaultState<'Location, 'Name, 'ResourceGroupName, 'SkuName, 'TenantId>

        member _.Run(state: KeyVaultState<Present, Present, Present, Present, Present>) : azurerm.KeyVault.KeyVault =
            let config = azurerm.KeyVault.KeyVaultConfig()
            for setter in state.assignments do
                setter config
            azurerm.KeyVault.KeyVault(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.keyVault: missing required arguments. Must call: location, name, resource_group_name, sku_name, tenant_id.", 9999, IsError = true)>]
        member _.Run(_: KeyVaultState<_, _, _, _, _>) : azurerm.KeyVault.KeyVault =
            Unchecked.defaultof<azurerm.KeyVault.KeyVault>
