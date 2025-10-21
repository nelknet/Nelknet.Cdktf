namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.RedisCache.RedisCacheConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache">azurerm_redis_cache</a>.
    /// </summary>
    type RedisCacheBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedisCacheState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedisCacheState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RedisCacheState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedisCacheState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#capacity-1">RedisCache#capacity</a>.
        /// </summary>
        [<CustomOperation "capacity">]
        member _.Capacity(state: RedisCacheState<Missing, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: double) : RedisCacheState<Present, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Capacity <- value)
            ({ assignments = state.assignments } : RedisCacheState<Present, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#family-1">RedisCache#family</a>.
        /// </summary>
        [<CustomOperation "family">]
        member _.Family(state: RedisCacheState<'Capacity, Missing, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : RedisCacheState<'Capacity, Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Family <- value)
            ({ assignments = state.assignments } : RedisCacheState<'Capacity, Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#location-1">RedisCache#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: RedisCacheState<'Capacity, 'Family, Missing, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : RedisCacheState<'Capacity, 'Family, Present, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : RedisCacheState<'Capacity, 'Family, Present, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#name-1">RedisCache#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RedisCacheState<'Capacity, 'Family, 'Location, Missing, 'ResourceGroupName, 'SkuName>, value: string) : RedisCacheState<'Capacity, 'Family, 'Location, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RedisCacheState<'Capacity, 'Family, 'Location, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#resource_group_name-1">RedisCache#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, Missing, 'SkuName>, value: string) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#sku_name-1">RedisCache#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#access_keys_authentication_enabled-1">RedisCache#access_keys_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "access_keys_authentication_enabled">]
        member _.AccessKeysAuthenticationEnabled(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.AccessKeysAuthenticationEnabled <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#access_keys_authentication_enabled-1">RedisCache#access_keys_authentication_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "access_keys_authentication_enabled">]
        member _.AccessKeysAuthenticationEnabled(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.AccessKeysAuthenticationEnabled <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#id-1">RedisCache#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#identity-1">RedisCache#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.RedisCache.RedisCacheIdentity) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#minimum_tls_version-1">RedisCache#minimum_tls_version</a>.
        /// </summary>
        [<CustomOperation "minimum_tls_version">]
        member _.MinimumTlsVersion(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.MinimumTlsVersion <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#non_ssl_port_enabled-1">RedisCache#non_ssl_port_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "non_ssl_port_enabled">]
        member _.NonSslPortEnabled(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.NonSslPortEnabled <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#non_ssl_port_enabled-1">RedisCache#non_ssl_port_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "non_ssl_port_enabled">]
        member _.NonSslPortEnabled(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.NonSslPortEnabled <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// patch_schedule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#patch_schedule-1">RedisCache#patch_schedule</a> Accepts: azurerm.IResolvable | azurerm.RedisCache.RedisCachePatchSchedule[]
        /// </summary>
        [<CustomOperation "patch_schedule">]
        member _.PatchSchedule(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PatchSchedule <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#private_static_ip_address-1">RedisCache#private_static_ip_address</a>.
        /// </summary>
        [<CustomOperation "private_static_ip_address">]
        member _.PrivateStaticIpAddress(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PrivateStaticIpAddress <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#public_network_access_enabled-1">RedisCache#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#public_network_access_enabled-1">RedisCache#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// redis_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#redis_configuration-1">RedisCache#redis_configuration</a>
        /// </summary>
        [<CustomOperation "redis_configuration">]
        member _.RedisConfiguration(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.RedisCache.RedisCacheRedisConfiguration) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.RedisConfiguration <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#redis_version-1">RedisCache#redis_version</a>.
        /// </summary>
        [<CustomOperation "redis_version">]
        member _.RedisVersion(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.RedisVersion <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#replicas_per_master-1">RedisCache#replicas_per_master</a>.
        /// </summary>
        [<CustomOperation "replicas_per_master">]
        member _.ReplicasPerMaster(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: double) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.ReplicasPerMaster <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#replicas_per_primary-1">RedisCache#replicas_per_primary</a>.
        /// </summary>
        [<CustomOperation "replicas_per_primary">]
        member _.ReplicasPerPrimary(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: double) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.ReplicasPerPrimary <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#shard_count-1">RedisCache#shard_count</a>.
        /// </summary>
        [<CustomOperation "shard_count">]
        member _.ShardCount(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: double) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.ShardCount <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#subnet_id-1">RedisCache#subnet_id</a>.
        /// </summary>
        [<CustomOperation "subnet_id">]
        member _.SubnetId(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.SubnetId <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#tags-1">RedisCache#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#tenant_settings-1">RedisCache#tenant_settings</a>.
        /// </summary>
        [<CustomOperation "tenant_settings">]
        member _.TenantSettings(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.TenantSettings <- dict value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#timeouts-1">RedisCache#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.RedisCache.RedisCacheTimeouts) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#zones-1">RedisCache#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string>) : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : RedisCacheState<'Capacity, 'Family, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: RedisCacheState<Present, Present, Present, Present, Present, Present>) : azurerm.RedisCache.RedisCache =
            let config = azurerm.RedisCache.RedisCacheConfig()
            for setter in state.assignments do
                setter config
            azurerm.RedisCache.RedisCache(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.redisCache: missing required arguments. Must call: capacity, family, location, name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: RedisCacheState<_, _, _, _, _, _>) : azurerm.RedisCache.RedisCache =
            Unchecked.defaultof<azurerm.RedisCache.RedisCache>
