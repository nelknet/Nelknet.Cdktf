namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.DatabricksWorkspace.DatabricksWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace">azurerm_databricks_workspace</a>.
    /// </summary>
    type DatabricksWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DatabricksWorkspaceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatabricksWorkspaceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DatabricksWorkspaceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DatabricksWorkspaceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#location-1">DatabricksWorkspace#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DatabricksWorkspaceState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : DatabricksWorkspaceState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DatabricksWorkspaceState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#name-1">DatabricksWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DatabricksWorkspaceState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : DatabricksWorkspaceState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DatabricksWorkspaceState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#resource_group_name-1">DatabricksWorkspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DatabricksWorkspaceState<'Location, 'Name, Missing, 'Sku>, value: string) : DatabricksWorkspaceState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DatabricksWorkspaceState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#sku-1">DatabricksWorkspace#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#access_connector_id-1">DatabricksWorkspace#access_connector_id</a>.
        /// </summary>
        [<CustomOperation "access_connector_id">]
        member _.AccessConnectorId(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AccessConnectorId <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#customer_managed_key_enabled-1">DatabricksWorkspace#customer_managed_key_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "customer_managed_key_enabled">]
        member _.CustomerManagedKeyEnabled(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CustomerManagedKeyEnabled <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#customer_managed_key_enabled-1">DatabricksWorkspace#customer_managed_key_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "customer_managed_key_enabled">]
        member _.CustomerManagedKeyEnabled(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CustomerManagedKeyEnabled <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// custom_parameters block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#custom_parameters-1">DatabricksWorkspace#custom_parameters</a>
        /// </summary>
        [<CustomOperation "custom_parameters">]
        member _.CustomParameters(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.DatabricksWorkspace.DatabricksWorkspaceCustomParameters) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.CustomParameters <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#default_storage_firewall_enabled-1">DatabricksWorkspace#default_storage_firewall_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "default_storage_firewall_enabled">]
        member _.DefaultStorageFirewallEnabled(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DefaultStorageFirewallEnabled <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#default_storage_firewall_enabled-1">DatabricksWorkspace#default_storage_firewall_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "default_storage_firewall_enabled">]
        member _.DefaultStorageFirewallEnabled(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DefaultStorageFirewallEnabled <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#id-1">DatabricksWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#infrastructure_encryption_enabled-1">DatabricksWorkspace#infrastructure_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "infrastructure_encryption_enabled">]
        member _.InfrastructureEncryptionEnabled(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.InfrastructureEncryptionEnabled <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#infrastructure_encryption_enabled-1">DatabricksWorkspace#infrastructure_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "infrastructure_encryption_enabled">]
        member _.InfrastructureEncryptionEnabled(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.InfrastructureEncryptionEnabled <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#load_balancer_backend_address_pool_id-1">DatabricksWorkspace#load_balancer_backend_address_pool_id</a>.
        /// </summary>
        [<CustomOperation "load_balancer_backend_address_pool_id">]
        member _.LoadBalancerBackendAddressPoolId(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LoadBalancerBackendAddressPoolId <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#managed_disk_cmk_key_vault_id-1">DatabricksWorkspace#managed_disk_cmk_key_vault_id</a>.
        /// </summary>
        [<CustomOperation "managed_disk_cmk_key_vault_id">]
        member _.ManagedDiskCmkKeyVaultId(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ManagedDiskCmkKeyVaultId <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#managed_disk_cmk_key_vault_key_id-1">DatabricksWorkspace#managed_disk_cmk_key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "managed_disk_cmk_key_vault_key_id">]
        member _.ManagedDiskCmkKeyVaultKeyId(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ManagedDiskCmkKeyVaultKeyId <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#managed_disk_cmk_rotation_to_latest_version_enabled-1">DatabricksWorkspace#managed_disk_cmk_rotation_to_latest_version_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "managed_disk_cmk_rotation_to_latest_version_enabled">]
        member _.ManagedDiskCmkRotationToLatestVersionEnabled(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ManagedDiskCmkRotationToLatestVersionEnabled <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#managed_disk_cmk_rotation_to_latest_version_enabled-1">DatabricksWorkspace#managed_disk_cmk_rotation_to_latest_version_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "managed_disk_cmk_rotation_to_latest_version_enabled">]
        member _.ManagedDiskCmkRotationToLatestVersionEnabled(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ManagedDiskCmkRotationToLatestVersionEnabled <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#managed_resource_group_name-1">DatabricksWorkspace#managed_resource_group_name</a>.
        /// </summary>
        [<CustomOperation "managed_resource_group_name">]
        member _.ManagedResourceGroupName(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ManagedResourceGroupName <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#managed_services_cmk_key_vault_id-1">DatabricksWorkspace#managed_services_cmk_key_vault_id</a>.
        /// </summary>
        [<CustomOperation "managed_services_cmk_key_vault_id">]
        member _.ManagedServicesCmkKeyVaultId(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ManagedServicesCmkKeyVaultId <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#managed_services_cmk_key_vault_key_id-1">DatabricksWorkspace#managed_services_cmk_key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "managed_services_cmk_key_vault_key_id">]
        member _.ManagedServicesCmkKeyVaultKeyId(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ManagedServicesCmkKeyVaultKeyId <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#network_security_group_rules_required-1">DatabricksWorkspace#network_security_group_rules_required</a>.
        /// </summary>
        [<CustomOperation "network_security_group_rules_required">]
        member _.NetworkSecurityGroupRulesRequired(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.NetworkSecurityGroupRulesRequired <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#public_network_access_enabled-1">DatabricksWorkspace#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#public_network_access_enabled-1">DatabricksWorkspace#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#tags-1">DatabricksWorkspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/databricks_workspace#timeouts-1">DatabricksWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.DatabricksWorkspace.DatabricksWorkspaceTimeouts) : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DatabricksWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: DatabricksWorkspaceState<Present, Present, Present, Present>) : azurerm.DatabricksWorkspace.DatabricksWorkspace =
            let config = azurerm.DatabricksWorkspace.DatabricksWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.DatabricksWorkspace.DatabricksWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.databricksWorkspace: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: DatabricksWorkspaceState<_, _, _, _>) : azurerm.DatabricksWorkspace.DatabricksWorkspace =
            Unchecked.defaultof<azurerm.DatabricksWorkspace.DatabricksWorkspace>
