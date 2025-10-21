namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.StorageAccount.StorageAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account">azurerm_storage_account</a>.
    /// </summary>
    type StorageAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : StorageAccountState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageAccountState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : StorageAccountState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : StorageAccountState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#account_replication_type-1">StorageAccount#account_replication_type</a>.
        /// </summary>
        [<CustomOperation "account_replication_type">]
        member _.AccountReplicationType(state: StorageAccountState<Missing, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: string) : StorageAccountState<Present, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountReplicationType <- value)
            ({ assignments = state.assignments } : StorageAccountState<Present, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#account_tier-1">StorageAccount#account_tier</a>.
        /// </summary>
        [<CustomOperation "account_tier">]
        member _.AccountTier(state: StorageAccountState<'AccountReplicationType, Missing, 'Location, 'Name, 'ResourceGroupName>, value: string) : StorageAccountState<'AccountReplicationType, Present, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountTier <- value)
            ({ assignments = state.assignments } : StorageAccountState<'AccountReplicationType, Present, 'Location, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#location-1">StorageAccount#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: StorageAccountState<'AccountReplicationType, 'AccountTier, Missing, 'Name, 'ResourceGroupName>, value: string) : StorageAccountState<'AccountReplicationType, 'AccountTier, Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : StorageAccountState<'AccountReplicationType, 'AccountTier, Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#name-1">StorageAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, Missing, 'ResourceGroupName>, value: string) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#resource_group_name-1">StorageAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, Missing>, value: string) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#access_tier-1">StorageAccount#access_tier</a>.
        /// </summary>
        [<CustomOperation "access_tier">]
        member _.AccessTier(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: string) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccessTier <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#account_kind-1">StorageAccount#account_kind</a>.
        /// </summary>
        [<CustomOperation "account_kind">]
        member _.AccountKind(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: string) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccountKind <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#allowed_copy_scope-1">StorageAccount#allowed_copy_scope</a>.
        /// </summary>
        [<CustomOperation "allowed_copy_scope">]
        member _.AllowedCopyScope(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: string) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllowedCopyScope <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#allow_nested_items_to_be_public-1">StorageAccount#allow_nested_items_to_be_public</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_nested_items_to_be_public">]
        member _.AllowNestedItemsToBePublic(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: bool) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllowNestedItemsToBePublic <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#allow_nested_items_to_be_public-1">StorageAccount#allow_nested_items_to_be_public</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "allow_nested_items_to_be_public">]
        member _.AllowNestedItemsToBePublic(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AllowNestedItemsToBePublic <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// azure_files_authentication block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#azure_files_authentication-1">StorageAccount#azure_files_authentication</a>
        /// </summary>
        [<CustomOperation "azure_files_authentication">]
        member _.AzureFilesAuthentication(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageAccount.StorageAccountAzureFilesAuthentication) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AzureFilesAuthentication <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// blob_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#blob_properties-1">StorageAccount#blob_properties</a>
        /// </summary>
        [<CustomOperation "blob_properties">]
        member _.BlobProperties(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageAccount.StorageAccountBlobProperties) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BlobProperties <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#cross_tenant_replication_enabled-1">StorageAccount#cross_tenant_replication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "cross_tenant_replication_enabled">]
        member _.CrossTenantReplicationEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: bool) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CrossTenantReplicationEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#cross_tenant_replication_enabled-1">StorageAccount#cross_tenant_replication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "cross_tenant_replication_enabled">]
        member _.CrossTenantReplicationEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CrossTenantReplicationEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// custom_domain block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#custom_domain-1">StorageAccount#custom_domain</a>
        /// </summary>
        [<CustomOperation "custom_domain">]
        member _.CustomDomain(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageAccount.StorageAccountCustomDomain) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CustomDomain <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// customer_managed_key block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#customer_managed_key-1">StorageAccount#customer_managed_key</a>
        /// </summary>
        [<CustomOperation "customer_managed_key">]
        member _.CustomerManagedKey(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageAccount.StorageAccountCustomerManagedKey) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CustomerManagedKey <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#default_to_oauth_authentication-1">StorageAccount#default_to_oauth_authentication</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "default_to_oauth_authentication">]
        member _.DefaultToOauthAuthentication(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: bool) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DefaultToOauthAuthentication <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#default_to_oauth_authentication-1">StorageAccount#default_to_oauth_authentication</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "default_to_oauth_authentication">]
        member _.DefaultToOauthAuthentication(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DefaultToOauthAuthentication <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#dns_endpoint_type-1">StorageAccount#dns_endpoint_type</a>.
        /// </summary>
        [<CustomOperation "dns_endpoint_type">]
        member _.DnsEndpointType(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: string) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DnsEndpointType <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#edge_zone-1">StorageAccount#edge_zone</a>.
        /// </summary>
        [<CustomOperation "edge_zone">]
        member _.EdgeZone(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: string) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.EdgeZone <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#https_traffic_only_enabled-1">StorageAccount#https_traffic_only_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_traffic_only_enabled">]
        member _.HttpsTrafficOnlyEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: bool) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HttpsTrafficOnlyEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#https_traffic_only_enabled-1">StorageAccount#https_traffic_only_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_traffic_only_enabled">]
        member _.HttpsTrafficOnlyEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.HttpsTrafficOnlyEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#id-1">StorageAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: string) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#identity-1">StorageAccount#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageAccount.StorageAccountIdentity) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// immutability_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#immutability_policy-1">StorageAccount#immutability_policy</a>
        /// </summary>
        [<CustomOperation "immutability_policy">]
        member _.ImmutabilityPolicy(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageAccount.StorageAccountImmutabilityPolicy) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ImmutabilityPolicy <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#infrastructure_encryption_enabled-1">StorageAccount#infrastructure_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "infrastructure_encryption_enabled">]
        member _.InfrastructureEncryptionEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: bool) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InfrastructureEncryptionEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#infrastructure_encryption_enabled-1">StorageAccount#infrastructure_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "infrastructure_encryption_enabled">]
        member _.InfrastructureEncryptionEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InfrastructureEncryptionEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#is_hns_enabled-1">StorageAccount#is_hns_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_hns_enabled">]
        member _.IsHnsEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: bool) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsHnsEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#is_hns_enabled-1">StorageAccount#is_hns_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_hns_enabled">]
        member _.IsHnsEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsHnsEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#large_file_share_enabled-1">StorageAccount#large_file_share_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "large_file_share_enabled">]
        member _.LargeFileShareEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: bool) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LargeFileShareEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#large_file_share_enabled-1">StorageAccount#large_file_share_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "large_file_share_enabled">]
        member _.LargeFileShareEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LargeFileShareEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#local_user_enabled-1">StorageAccount#local_user_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_user_enabled">]
        member _.LocalUserEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: bool) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalUserEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#local_user_enabled-1">StorageAccount#local_user_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_user_enabled">]
        member _.LocalUserEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalUserEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#min_tls_version-1">StorageAccount#min_tls_version</a>.
        /// </summary>
        [<CustomOperation "min_tls_version">]
        member _.MinTlsVersion(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: string) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MinTlsVersion <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// network_rules block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#network_rules-1">StorageAccount#network_rules</a>
        /// </summary>
        [<CustomOperation "network_rules">]
        member _.NetworkRules(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageAccount.StorageAccountNetworkRules) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NetworkRules <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#nfsv3_enabled-1">StorageAccount#nfsv3_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "nfsv3_enabled">]
        member _.Nfsv3Enabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: bool) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Nfsv3Enabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#nfsv3_enabled-1">StorageAccount#nfsv3_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "nfsv3_enabled">]
        member _.Nfsv3Enabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Nfsv3Enabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#public_network_access_enabled-1">StorageAccount#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: bool) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#public_network_access_enabled-1">StorageAccount#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#queue_encryption_key_type-1">StorageAccount#queue_encryption_key_type</a>.
        /// </summary>
        [<CustomOperation "queue_encryption_key_type">]
        member _.QueueEncryptionKeyType(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: string) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.QueueEncryptionKeyType <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// queue_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#queue_properties-1">StorageAccount#queue_properties</a>
        /// </summary>
        [<CustomOperation "queue_properties">]
        member _.QueueProperties(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageAccount.StorageAccountQueueProperties) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.QueueProperties <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// routing block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#routing-1">StorageAccount#routing</a>
        /// </summary>
        [<CustomOperation "routing">]
        member _.Routing(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageAccount.StorageAccountRouting) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Routing <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// sas_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#sas_policy-1">StorageAccount#sas_policy</a>
        /// </summary>
        [<CustomOperation "sas_policy">]
        member _.SasPolicy(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageAccount.StorageAccountSasPolicy) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SasPolicy <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#sftp_enabled-1">StorageAccount#sftp_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sftp_enabled">]
        member _.SftpEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: bool) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SftpEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#sftp_enabled-1">StorageAccount#sftp_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "sftp_enabled">]
        member _.SftpEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SftpEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#shared_access_key_enabled-1">StorageAccount#shared_access_key_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "shared_access_key_enabled">]
        member _.SharedAccessKeyEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: bool) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SharedAccessKeyEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#shared_access_key_enabled-1">StorageAccount#shared_access_key_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "shared_access_key_enabled">]
        member _.SharedAccessKeyEnabled(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SharedAccessKeyEnabled <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// share_properties block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#share_properties-1">StorageAccount#share_properties</a>
        /// </summary>
        [<CustomOperation "share_properties">]
        member _.ShareProperties(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageAccount.StorageAccountShareProperties) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ShareProperties <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// static_website block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#static_website-1">StorageAccount#static_website</a>
        /// </summary>
        [<CustomOperation "static_website">]
        member _.StaticWebsite(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageAccount.StorageAccountStaticWebsite) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.StaticWebsite <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#table_encryption_key_type-1">StorageAccount#table_encryption_key_type</a>.
        /// </summary>
        [<CustomOperation "table_encryption_key_type">]
        member _.TableEncryptionKeyType(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: string) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.TableEncryptionKeyType <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#tags-1">StorageAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/storage_account#timeouts-1">StorageAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>, value: azurerm.StorageAccount.StorageAccountTimeouts) : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : StorageAccountState<'AccountReplicationType, 'AccountTier, 'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: StorageAccountState<Present, Present, Present, Present, Present>) : azurerm.StorageAccount.StorageAccount =
            let config = azurerm.StorageAccount.StorageAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.StorageAccount.StorageAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.storageAccount: missing required arguments. Must call: account_replication_type, account_tier, location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: StorageAccountState<_, _, _, _, _>) : azurerm.StorageAccount.StorageAccount =
            Unchecked.defaultof<azurerm.StorageAccount.StorageAccount>
