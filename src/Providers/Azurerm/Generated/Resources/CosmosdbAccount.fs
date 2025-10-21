namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.CosmosdbAccount.CosmosdbAccountConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account">azurerm_cosmosdb_account</a>.
    /// </summary>
    type CosmosdbAccountBuilder(logicalId: string) =
        member _.Yield(_: unit) : CosmosdbAccountState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbAccountState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : CosmosdbAccountState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : CosmosdbAccountState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// consistency_policy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#consistency_policy-1">CosmosdbAccount#consistency_policy</a>
        /// </summary>
        [<CustomOperation "consistency_policy">]
        member _.ConsistencyPolicy(state: CosmosdbAccountState<Missing, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: azurerm.CosmosdbAccount.CosmosdbAccountConsistencyPolicy) : CosmosdbAccountState<Present, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConsistencyPolicy <- value)
            ({ assignments = state.assignments } : CosmosdbAccountState<Present, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>)

        /// <summary>
        /// geo_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#geo_location-1">CosmosdbAccount#geo_location</a> Accepts: azurerm.IResolvable | azurerm.CosmosdbAccount.CosmosdbAccountGeoLocation[]
        /// </summary>
        [<CustomOperation "geo_location">]
        member _.GeoLocation(state: CosmosdbAccountState<'ConsistencyPolicy, Missing, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbAccountState<'ConsistencyPolicy, Present, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GeoLocation <- value)
            ({ assignments = state.assignments } : CosmosdbAccountState<'ConsistencyPolicy, Present, 'Location, 'Name, 'OfferType, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#location-1">CosmosdbAccount#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, Missing, 'Name, 'OfferType, 'ResourceGroupName>, value: string) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, Present, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, Present, 'Name, 'OfferType, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#name-1">CosmosdbAccount#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, Missing, 'OfferType, 'ResourceGroupName>, value: string) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, Present, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, Present, 'OfferType, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#offer_type-1">CosmosdbAccount#offer_type</a>.
        /// </summary>
        [<CustomOperation "offer_type">]
        member _.OfferType(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, Missing, 'ResourceGroupName>, value: string) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.OfferType <- value)
            ({ assignments = state.assignments } : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#resource_group_name-1">CosmosdbAccount#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, Missing>, value: string) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#access_key_metadata_writes_enabled-1">CosmosdbAccount#access_key_metadata_writes_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "access_key_metadata_writes_enabled">]
        member _.AccessKeyMetadataWritesEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: bool) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccessKeyMetadataWritesEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#access_key_metadata_writes_enabled-1">CosmosdbAccount#access_key_metadata_writes_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "access_key_metadata_writes_enabled">]
        member _.AccessKeyMetadataWritesEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AccessKeyMetadataWritesEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// analytical_storage block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#analytical_storage-1">CosmosdbAccount#analytical_storage</a>
        /// </summary>
        [<CustomOperation "analytical_storage">]
        member _.AnalyticalStorage(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: azurerm.CosmosdbAccount.CosmosdbAccountAnalyticalStorage) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AnalyticalStorage <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#analytical_storage_enabled-1">CosmosdbAccount#analytical_storage_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "analytical_storage_enabled">]
        member _.AnalyticalStorageEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: bool) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AnalyticalStorageEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#analytical_storage_enabled-1">CosmosdbAccount#analytical_storage_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "analytical_storage_enabled">]
        member _.AnalyticalStorageEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AnalyticalStorageEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#automatic_failover_enabled-1">CosmosdbAccount#automatic_failover_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatic_failover_enabled">]
        member _.AutomaticFailoverEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: bool) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomaticFailoverEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#automatic_failover_enabled-1">CosmosdbAccount#automatic_failover_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "automatic_failover_enabled">]
        member _.AutomaticFailoverEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.AutomaticFailoverEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// backup block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#backup-1">CosmosdbAccount#backup</a>
        /// </summary>
        [<CustomOperation "backup">]
        member _.Backup(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: azurerm.CosmosdbAccount.CosmosdbAccountBackup) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Backup <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#burst_capacity_enabled-1">CosmosdbAccount#burst_capacity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "burst_capacity_enabled">]
        member _.BurstCapacityEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: bool) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BurstCapacityEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#burst_capacity_enabled-1">CosmosdbAccount#burst_capacity_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "burst_capacity_enabled">]
        member _.BurstCapacityEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BurstCapacityEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// capabilities block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#capabilities-1">CosmosdbAccount#capabilities</a> Accepts: azurerm.IResolvable | azurerm.CosmosdbAccount.CosmosdbAccountCapabilities[]
        /// </summary>
        [<CustomOperation "capabilities">]
        member _.Capabilities(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Capabilities <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// capacity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#capacity-1">CosmosdbAccount#capacity</a>
        /// </summary>
        [<CustomOperation "capacity">]
        member _.Capacity(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: azurerm.CosmosdbAccount.CosmosdbAccountCapacity) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Capacity <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// cors_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#cors_rule-1">CosmosdbAccount#cors_rule</a>
        /// </summary>
        [<CustomOperation "cors_rule">]
        member _.CorsRule(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: azurerm.CosmosdbAccount.CosmosdbAccountCorsRule) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CorsRule <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#create_mode-1">CosmosdbAccount#create_mode</a>.
        /// </summary>
        [<CustomOperation "create_mode">]
        member _.CreateMode(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: string) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CreateMode <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#default_identity_type-1">CosmosdbAccount#default_identity_type</a>.
        /// </summary>
        [<CustomOperation "default_identity_type">]
        member _.DefaultIdentityType(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: string) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DefaultIdentityType <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#free_tier_enabled-1">CosmosdbAccount#free_tier_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "free_tier_enabled">]
        member _.FreeTierEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: bool) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FreeTierEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#free_tier_enabled-1">CosmosdbAccount#free_tier_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "free_tier_enabled">]
        member _.FreeTierEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.FreeTierEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#id-1">CosmosdbAccount#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: string) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#identity-1">CosmosdbAccount#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: azurerm.CosmosdbAccount.CosmosdbAccountIdentity) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#ip_range_filter-1">CosmosdbAccount#ip_range_filter</a>.
        /// </summary>
        [<CustomOperation "ip_range_filter">]
        member _.IpRangeFilter(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: seq<string>) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IpRangeFilter <- (value |> Seq.toArray))
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#is_virtual_network_filter_enabled-1">CosmosdbAccount#is_virtual_network_filter_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_virtual_network_filter_enabled">]
        member _.IsVirtualNetworkFilterEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: bool) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsVirtualNetworkFilterEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#is_virtual_network_filter_enabled-1">CosmosdbAccount#is_virtual_network_filter_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_virtual_network_filter_enabled">]
        member _.IsVirtualNetworkFilterEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.IsVirtualNetworkFilterEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#key_vault_key_id-1">CosmosdbAccount#key_vault_key_id</a>.
        /// </summary>
        [<CustomOperation "key_vault_key_id">]
        member _.KeyVaultKeyId(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: string) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.KeyVaultKeyId <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#kind-1">CosmosdbAccount#kind</a>.
        /// </summary>
        [<CustomOperation "kind">]
        member _.Kind(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: string) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Kind <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#local_authentication_disabled-1">CosmosdbAccount#local_authentication_disabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_disabled">]
        member _.LocalAuthenticationDisabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: bool) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalAuthenticationDisabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#local_authentication_disabled-1">CosmosdbAccount#local_authentication_disabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "local_authentication_disabled">]
        member _.LocalAuthenticationDisabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LocalAuthenticationDisabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#minimal_tls_version-1">CosmosdbAccount#minimal_tls_version</a>.
        /// </summary>
        [<CustomOperation "minimal_tls_version">]
        member _.MinimalTlsVersion(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: string) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MinimalTlsVersion <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#mongo_server_version-1">CosmosdbAccount#mongo_server_version</a>.
        /// </summary>
        [<CustomOperation "mongo_server_version">]
        member _.MongoServerVersion(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: string) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MongoServerVersion <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#multiple_write_locations_enabled-1">CosmosdbAccount#multiple_write_locations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "multiple_write_locations_enabled">]
        member _.MultipleWriteLocationsEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: bool) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MultipleWriteLocationsEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#multiple_write_locations_enabled-1">CosmosdbAccount#multiple_write_locations_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "multiple_write_locations_enabled">]
        member _.MultipleWriteLocationsEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MultipleWriteLocationsEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#network_acl_bypass_for_azure_services-1">CosmosdbAccount#network_acl_bypass_for_azure_services</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "network_acl_bypass_for_azure_services">]
        member _.NetworkAclBypassForAzureServices(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: bool) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NetworkAclBypassForAzureServices <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#network_acl_bypass_for_azure_services-1">CosmosdbAccount#network_acl_bypass_for_azure_services</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "network_acl_bypass_for_azure_services">]
        member _.NetworkAclBypassForAzureServices(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NetworkAclBypassForAzureServices <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#network_acl_bypass_ids-1">CosmosdbAccount#network_acl_bypass_ids</a>.
        /// </summary>
        [<CustomOperation "network_acl_bypass_ids">]
        member _.NetworkAclBypassIds(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: seq<string>) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.NetworkAclBypassIds <- (value |> Seq.toArray))
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#partition_merge_enabled-1">CosmosdbAccount#partition_merge_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "partition_merge_enabled">]
        member _.PartitionMergeEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: bool) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PartitionMergeEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#partition_merge_enabled-1">CosmosdbAccount#partition_merge_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "partition_merge_enabled">]
        member _.PartitionMergeEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PartitionMergeEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#public_network_access_enabled-1">CosmosdbAccount#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: bool) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#public_network_access_enabled-1">CosmosdbAccount#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// restore block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#restore-1">CosmosdbAccount#restore</a>
        /// </summary>
        [<CustomOperation "restore">]
        member _.Restore(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: azurerm.CosmosdbAccount.CosmosdbAccountRestore) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Restore <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#tags-1">CosmosdbAccount#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: seq<string * string>) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#timeouts-1">CosmosdbAccount#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: azurerm.CosmosdbAccount.CosmosdbAccountTimeouts) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        /// <summary>
        /// virtual_network_rule block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/cosmosdb_account#virtual_network_rule-1">CosmosdbAccount#virtual_network_rule</a> Accepts: azurerm.IResolvable | azurerm.CosmosdbAccount.CosmosdbAccountVirtualNetworkRule[]
        /// </summary>
        [<CustomOperation "virtual_network_rule">]
        member _.VirtualNetworkRule(state: CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.VirtualNetworkRule <- value)
            state : CosmosdbAccountState<'ConsistencyPolicy, 'GeoLocation, 'Location, 'Name, 'OfferType, 'ResourceGroupName>

        member _.Run(state: CosmosdbAccountState<Present, Present, Present, Present, Present, Present>) : azurerm.CosmosdbAccount.CosmosdbAccount =
            let config = azurerm.CosmosdbAccount.CosmosdbAccountConfig()
            for setter in state.assignments do
                setter config
            azurerm.CosmosdbAccount.CosmosdbAccount(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.cosmosdbAccount: missing required arguments. Must call: consistency_policy, geo_location, location, name, offer_type, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: CosmosdbAccountState<_, _, _, _, _, _>) : azurerm.CosmosdbAccount.CosmosdbAccount =
            Unchecked.defaultof<azurerm.CosmosdbAccount.CosmosdbAccount>
