namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> = { assignments: ResizeArray<azurerm.SynapseWorkspace.SynapseWorkspaceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace">azurerm_synapse_workspace</a>.
    /// </summary>
    type SynapseWorkspaceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SynapseWorkspaceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseWorkspaceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : SynapseWorkspaceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SynapseWorkspaceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#location-1">SynapseWorkspace#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SynapseWorkspaceState<Missing, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: string) : SynapseWorkspaceState<Present, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceState<Present, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#name-1">SynapseWorkspace#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SynapseWorkspaceState<'Location, Missing, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: string) : SynapseWorkspaceState<'Location, Present, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceState<'Location, Present, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#resource_group_name-1">SynapseWorkspace#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SynapseWorkspaceState<'Location, 'Name, Missing, 'StorageDataLakeGen2FilesystemId>, value: string) : SynapseWorkspaceState<'Location, 'Name, Present, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceState<'Location, 'Name, Present, 'StorageDataLakeGen2FilesystemId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#storage_data_lake_gen2_filesystem_id-1">SynapseWorkspace#storage_data_lake_gen2_filesystem_id</a>.
        /// </summary>
        [<CustomOperation "storage_data_lake_gen2_filesystem_id">]
        member _.StorageDataLakeGen2FilesystemId(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.StorageDataLakeGen2FilesystemId <- value)
            ({ assignments = state.assignments } : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#azuread_authentication_only-1">SynapseWorkspace#azuread_authentication_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "azuread_authentication_only">]
        member _.AzureadAuthenticationOnly(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: bool) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.AzureadAuthenticationOnly <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#azuread_authentication_only-1">SynapseWorkspace#azuread_authentication_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "azuread_authentication_only">]
        member _.AzureadAuthenticationOnly(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: HashiCorp.Cdktf.IResolvable) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.AzureadAuthenticationOnly <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// azure_devops_repo block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#azure_devops_repo-1">SynapseWorkspace#azure_devops_repo</a>
        /// </summary>
        [<CustomOperation "azure_devops_repo">]
        member _.AzureDevopsRepo(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: azurerm.SynapseWorkspace.SynapseWorkspaceAzureDevopsRepo) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.AzureDevopsRepo <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#compute_subnet_id-1">SynapseWorkspace#compute_subnet_id</a>.
        /// </summary>
        [<CustomOperation "compute_subnet_id">]
        member _.ComputeSubnetId(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: string) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.ComputeSubnetId <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// customer_managed_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#customer_managed_key-1">SynapseWorkspace#customer_managed_key</a>
        /// </summary>
        [<CustomOperation "customer_managed_key">]
        member _.CustomerManagedKey(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: azurerm.SynapseWorkspace.SynapseWorkspaceCustomerManagedKey) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.CustomerManagedKey <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#data_exfiltration_protection_enabled-1">SynapseWorkspace#data_exfiltration_protection_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "data_exfiltration_protection_enabled">]
        member _.DataExfiltrationProtectionEnabled(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: bool) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.DataExfiltrationProtectionEnabled <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#data_exfiltration_protection_enabled-1">SynapseWorkspace#data_exfiltration_protection_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "data_exfiltration_protection_enabled">]
        member _.DataExfiltrationProtectionEnabled(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: HashiCorp.Cdktf.IResolvable) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.DataExfiltrationProtectionEnabled <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// github_repo block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#github_repo-1">SynapseWorkspace#github_repo</a>
        /// </summary>
        [<CustomOperation "github_repo">]
        member _.GithubRepo(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: azurerm.SynapseWorkspace.SynapseWorkspaceGithubRepo) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.GithubRepo <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#id-1">SynapseWorkspace#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: string) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#identity-1">SynapseWorkspace#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: azurerm.SynapseWorkspace.SynapseWorkspaceIdentity) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#linking_allowed_for_aad_tenant_ids-1">SynapseWorkspace#linking_allowed_for_aad_tenant_ids</a>.
        /// </summary>
        [<CustomOperation "linking_allowed_for_aad_tenant_ids">]
        member _.LinkingAllowedForAadTenantIds(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: seq<string>) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.LinkingAllowedForAadTenantIds <- (value |> Seq.toArray))
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#managed_resource_group_name-1">SynapseWorkspace#managed_resource_group_name</a>.
        /// </summary>
        [<CustomOperation "managed_resource_group_name">]
        member _.ManagedResourceGroupName(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: string) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.ManagedResourceGroupName <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#managed_virtual_network_enabled-1">SynapseWorkspace#managed_virtual_network_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "managed_virtual_network_enabled">]
        member _.ManagedVirtualNetworkEnabled(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: bool) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.ManagedVirtualNetworkEnabled <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#managed_virtual_network_enabled-1">SynapseWorkspace#managed_virtual_network_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "managed_virtual_network_enabled">]
        member _.ManagedVirtualNetworkEnabled(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: HashiCorp.Cdktf.IResolvable) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.ManagedVirtualNetworkEnabled <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#public_network_access_enabled-1">SynapseWorkspace#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: bool) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#public_network_access_enabled-1">SynapseWorkspace#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: HashiCorp.Cdktf.IResolvable) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#purview_id-1">SynapseWorkspace#purview_id</a>.
        /// </summary>
        [<CustomOperation "purview_id">]
        member _.PurviewId(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: string) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.PurviewId <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#sql_administrator_login-1">SynapseWorkspace#sql_administrator_login</a>.
        /// </summary>
        [<CustomOperation "sql_administrator_login">]
        member _.SqlAdministratorLogin(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: string) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.SqlAdministratorLogin <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#sql_administrator_login_password-1">SynapseWorkspace#sql_administrator_login_password</a>.
        /// </summary>
        [<CustomOperation "sql_administrator_login_password">]
        member _.SqlAdministratorLoginPassword(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: string) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.SqlAdministratorLoginPassword <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#sql_identity_control_enabled-1">SynapseWorkspace#sql_identity_control_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sql_identity_control_enabled">]
        member _.SqlIdentityControlEnabled(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: bool) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.SqlIdentityControlEnabled <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#sql_identity_control_enabled-1">SynapseWorkspace#sql_identity_control_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sql_identity_control_enabled">]
        member _.SqlIdentityControlEnabled(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: HashiCorp.Cdktf.IResolvable) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.SqlIdentityControlEnabled <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#tags-1">SynapseWorkspace#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: seq<string * string>) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/synapse_workspace#timeouts-1">SynapseWorkspace#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>, value: azurerm.SynapseWorkspace.SynapseWorkspaceTimeouts) : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SynapseWorkspaceState<'Location, 'Name, 'ResourceGroupName, 'StorageDataLakeGen2FilesystemId>

        member _.Run(state: SynapseWorkspaceState<Present, Present, Present, Present>) : azurerm.SynapseWorkspace.SynapseWorkspace =
            let config = azurerm.SynapseWorkspace.SynapseWorkspaceConfig()
            for setter in state.assignments do
                setter config
            azurerm.SynapseWorkspace.SynapseWorkspace(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.synapseWorkspace: missing required arguments. Must call: location, name, resource_group_name, storage_data_lake_gen2_filesystem_id.", 9999, IsError = true)>]
        member _.Run(_: SynapseWorkspaceState<_, _, _, _>) : azurerm.SynapseWorkspace.SynapseWorkspace =
            Unchecked.defaultof<azurerm.SynapseWorkspace.SynapseWorkspace>
