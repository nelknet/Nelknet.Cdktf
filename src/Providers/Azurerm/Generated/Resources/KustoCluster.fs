namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.KustoCluster.KustoClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster">azurerm_kusto_cluster</a>.
    /// </summary>
    type KustoClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : KustoClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoClusterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : KustoClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KustoClusterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#location-1">KustoCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: KustoClusterState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : KustoClusterState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : KustoClusterState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#name-1">KustoCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KustoClusterState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : KustoClusterState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KustoClusterState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#resource_group_name-1">KustoCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: KustoClusterState<'Location, 'Name, Missing, 'Sku>, value: string) : KustoClusterState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : KustoClusterState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// sku block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#sku-1">KustoCluster#sku</a>
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, Missing>, value: azurerm.KustoCluster.KustoClusterSku) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : KustoClusterState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#allowed_fqdns-1">KustoCluster#allowed_fqdns</a>.
        /// </summary>
        [<CustomOperation "allowed_fqdns">]
        member _.AllowedFqdns(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string>) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AllowedFqdns <- (value |> Seq.toArray))
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#allowed_ip_ranges-1">KustoCluster#allowed_ip_ranges</a>.
        /// </summary>
        [<CustomOperation "allowed_ip_ranges">]
        member _.AllowedIpRanges(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string>) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AllowedIpRanges <- (value |> Seq.toArray))
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#auto_stop_enabled-1">KustoCluster#auto_stop_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_stop_enabled">]
        member _.AutoStopEnabled(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AutoStopEnabled <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#auto_stop_enabled-1">KustoCluster#auto_stop_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "auto_stop_enabled">]
        member _.AutoStopEnabled(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AutoStopEnabled <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#disk_encryption_enabled-1">KustoCluster#disk_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disk_encryption_enabled">]
        member _.DiskEncryptionEnabled(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DiskEncryptionEnabled <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#disk_encryption_enabled-1">KustoCluster#disk_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "disk_encryption_enabled">]
        member _.DiskEncryptionEnabled(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DiskEncryptionEnabled <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#double_encryption_enabled-1">KustoCluster#double_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "double_encryption_enabled">]
        member _.DoubleEncryptionEnabled(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DoubleEncryptionEnabled <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#double_encryption_enabled-1">KustoCluster#double_encryption_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "double_encryption_enabled">]
        member _.DoubleEncryptionEnabled(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DoubleEncryptionEnabled <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#id-1">KustoCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#identity-1">KustoCluster#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.KustoCluster.KustoClusterIdentity) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// language_extensions block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#language_extensions-1">KustoCluster#language_extensions</a> Accepts: azurerm.IResolvable | azurerm.KustoCluster.KustoClusterLanguageExtensions[]
        /// </summary>
        [<CustomOperation "language_extensions">]
        member _.LanguageExtensions(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LanguageExtensions <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// optimized_auto_scale block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#optimized_auto_scale-1">KustoCluster#optimized_auto_scale</a>
        /// </summary>
        [<CustomOperation "optimized_auto_scale">]
        member _.OptimizedAutoScale(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.KustoCluster.KustoClusterOptimizedAutoScale) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.OptimizedAutoScale <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#outbound_network_access_restricted-1">KustoCluster#outbound_network_access_restricted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "outbound_network_access_restricted">]
        member _.OutboundNetworkAccessRestricted(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.OutboundNetworkAccessRestricted <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#outbound_network_access_restricted-1">KustoCluster#outbound_network_access_restricted</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "outbound_network_access_restricted">]
        member _.OutboundNetworkAccessRestricted(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.OutboundNetworkAccessRestricted <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#public_ip_type-1">KustoCluster#public_ip_type</a>.
        /// </summary>
        [<CustomOperation "public_ip_type">]
        member _.PublicIpType(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicIpType <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#public_network_access_enabled-1">KustoCluster#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#public_network_access_enabled-1">KustoCluster#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#purge_enabled-1">KustoCluster#purge_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "purge_enabled">]
        member _.PurgeEnabled(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PurgeEnabled <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#purge_enabled-1">KustoCluster#purge_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "purge_enabled">]
        member _.PurgeEnabled(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PurgeEnabled <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#streaming_ingestion_enabled-1">KustoCluster#streaming_ingestion_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "streaming_ingestion_enabled">]
        member _.StreamingIngestionEnabled(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.StreamingIngestionEnabled <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#streaming_ingestion_enabled-1">KustoCluster#streaming_ingestion_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "streaming_ingestion_enabled">]
        member _.StreamingIngestionEnabled(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.StreamingIngestionEnabled <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#tags-1">KustoCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#timeouts-1">KustoCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.KustoCluster.KustoClusterTimeouts) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#trusted_external_tenants-1">KustoCluster#trusted_external_tenants</a>.
        /// </summary>
        [<CustomOperation "trusted_external_tenants">]
        member _.TrustedExternalTenants(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string>) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.TrustedExternalTenants <- (value |> Seq.toArray))
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// virtual_network_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#virtual_network_configuration-1">KustoCluster#virtual_network_configuration</a>
        /// </summary>
        [<CustomOperation "virtual_network_configuration">]
        member _.VirtualNetworkConfiguration(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.KustoCluster.KustoClusterVirtualNetworkConfiguration) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.VirtualNetworkConfiguration <- value)
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/kusto_cluster#zones-1">KustoCluster#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string>) : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : KustoClusterState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: KustoClusterState<Present, Present, Present, Present>) : azurerm.KustoCluster.KustoCluster =
            let config = azurerm.KustoCluster.KustoClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.KustoCluster.KustoCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.kustoCluster: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: KustoClusterState<_, _, _, _>) : azurerm.KustoCluster.KustoCluster =
            Unchecked.defaultof<azurerm.KustoCluster.KustoCluster>
