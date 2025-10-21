namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> = { assignments: ResizeArray<azurerm.HpcCache.HpcCacheConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache">azurerm_hpc_cache</a>.
    /// </summary>
    type HpcCacheBuilder(logicalId: string) =
        member _.Yield(_: unit) : HpcCacheState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HpcCacheState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : HpcCacheState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : HpcCacheState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#cache_size_in_gb-1">HpcCache#cache_size_in_gb</a>.
        /// </summary>
        [<CustomOperation "cache_size_in_gb">]
        member _.CacheSizeInGb(state: HpcCacheState<Missing, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: double) : HpcCacheState<Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.CacheSizeInGb <- value)
            ({ assignments = state.assignments } : HpcCacheState<Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#location-1">HpcCache#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: HpcCacheState<'CacheSizeInGb, Missing, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: string) : HpcCacheState<'CacheSizeInGb, Present, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : HpcCacheState<'CacheSizeInGb, Present, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#name-1">HpcCache#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: HpcCacheState<'CacheSizeInGb, 'Location, Missing, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: string) : HpcCacheState<'CacheSizeInGb, 'Location, Present, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : HpcCacheState<'CacheSizeInGb, 'Location, Present, 'ResourceGroupName, 'SkuName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#resource_group_name-1">HpcCache#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, Missing, 'SkuName, 'SubnetId>, value: string) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, Present, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, Present, 'SkuName, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#sku_name-1">HpcCache#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, Missing, 'SubnetId>, value: string) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, Present, 'SubnetId> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, Present, 'SubnetId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#subnet_id-1">HpcCache#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, Missing>, value: string) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, Present> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            ({ assignments = state.assignments } : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#automatically_rotate_key_to_latest_enabled-1">HpcCache#automatically_rotate_key_to_latest_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatically_rotate_key_to_latest_enabled">]
        member _.AutomaticallyRotateKeyToLatestEnabled(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: bool) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.AutomaticallyRotateKeyToLatestEnabled <- value)
            state : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#automatically_rotate_key_to_latest_enabled-1">HpcCache#automatically_rotate_key_to_latest_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatically_rotate_key_to_latest_enabled">]
        member _.AutomaticallyRotateKeyToLatestEnabled(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: HashiCorp.Cdktf.IResolvable) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.AutomaticallyRotateKeyToLatestEnabled <- value)
            state : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// default_access_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#default_access_policy-1">HpcCache#default_access_policy</a>
        /// </summary>
        [<CustomOperation "default_access_policy">]
        member _.DefaultAccessPolicy(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: azurerm.HpcCache.HpcCacheDefaultAccessPolicy) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.DefaultAccessPolicy <- value)
            state : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// directory_active_directory block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#directory_active_directory-1">HpcCache#directory_active_directory</a>
        /// </summary>
        [<CustomOperation "directory_active_directory">]
        member _.DirectoryActiveDirectory(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: azurerm.HpcCache.HpcCacheDirectoryActiveDirectory) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.DirectoryActiveDirectory <- value)
            state : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// directory_flat_file block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#directory_flat_file-1">HpcCache#directory_flat_file</a>
        /// </summary>
        [<CustomOperation "directory_flat_file">]
        member _.DirectoryFlatFile(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: azurerm.HpcCache.HpcCacheDirectoryFlatFile) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.DirectoryFlatFile <- value)
            state : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// directory_ldap block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#directory_ldap-1">HpcCache#directory_ldap</a>
        /// </summary>
        [<CustomOperation "directory_ldap">]
        member _.DirectoryLdap(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: azurerm.HpcCache.HpcCacheDirectoryLdap) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.DirectoryLdap <- value)
            state : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// dns block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#dns-1">HpcCache#dns</a>
        /// </summary>
        [<CustomOperation "dns">]
        member _.Dns(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: azurerm.HpcCache.HpcCacheDns) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Dns <- value)
            state : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#id-1">HpcCache#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: string) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#identity-1">HpcCache#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: azurerm.HpcCache.HpcCacheIdentity) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#key_vault_key_id-1">HpcCache#key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_key_id">]
        member _.KeyVaultKeyId(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: string) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.KeyVaultKeyId <- value)
            state : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#mtu-1">HpcCache#mtu</a>.
        /// </summary>
        [<CustomOperation "mtu">]
        member _.Mtu(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: double) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Mtu <- value)
            state : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#ntp_server-1">HpcCache#ntp_server</a>.
        /// </summary>
        [<CustomOperation "ntp_server">]
        member _.NtpServer(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: string) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.NtpServer <- value)
            state : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#tags-1">HpcCache#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: seq<string * string>) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/hpc_cache#timeouts-1">HpcCache#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>, value: azurerm.HpcCache.HpcCacheTimeouts) : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : HpcCacheState<'CacheSizeInGb, 'Location, 'Name, 'ResourceGroupName, 'SkuName, 'SubnetId>

        member _.Run(state: HpcCacheState<Present, Present, Present, Present, Present, Present>) : azurerm.HpcCache.HpcCache =
            let config = azurerm.HpcCache.HpcCacheConfig()
            for setter in state.assignments do
                setter config
            azurerm.HpcCache.HpcCache(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.hpcCache: missing required arguments. Must call: cache_size_in_gb, location, name, resource_group_name, sku_name, subnet_id.", 9999, IsError = true)>]
        member _.Run(_: HpcCacheState<_, _, _, _, _, _>) : azurerm.HpcCache.HpcCache =
            Unchecked.defaultof<azurerm.HpcCache.HpcCache>
