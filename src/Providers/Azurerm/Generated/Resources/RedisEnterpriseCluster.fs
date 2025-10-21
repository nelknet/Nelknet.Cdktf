namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.RedisEnterpriseCluster.RedisEnterpriseClusterConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_cluster">azurerm_redis_enterprise_cluster</a>.
    /// </summary>
    type RedisEnterpriseClusterBuilder(logicalId: string) =
        member _.Yield(_: unit) : RedisEnterpriseClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedisEnterpriseClusterState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : RedisEnterpriseClusterState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : RedisEnterpriseClusterState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_cluster#location-1">RedisEnterpriseCluster#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: RedisEnterpriseClusterState<Missing, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : RedisEnterpriseClusterState<Present, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : RedisEnterpriseClusterState<Present, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_cluster#name-1">RedisEnterpriseCluster#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: RedisEnterpriseClusterState<'Location, Missing, 'ResourceGroupName, 'SkuName>, value: string) : RedisEnterpriseClusterState<'Location, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : RedisEnterpriseClusterState<'Location, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_cluster#resource_group_name-1">RedisEnterpriseCluster#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: RedisEnterpriseClusterState<'Location, 'Name, Missing, 'SkuName>, value: string) : RedisEnterpriseClusterState<'Location, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : RedisEnterpriseClusterState<'Location, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_cluster#sku_name-1">RedisEnterpriseCluster#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_cluster#id-1">RedisEnterpriseCluster#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_cluster#minimum_tls_version-1">RedisEnterpriseCluster#minimum_tls_version</a>.
        /// </summary>
        [<CustomOperation "minimum_tls_version">]
        member _.MinimumTlsVersion(state: RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.MinimumTlsVersion <- value)
            state : RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_cluster#tags-1">RedisEnterpriseCluster#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_cluster#timeouts-1">RedisEnterpriseCluster#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.RedisEnterpriseCluster.RedisEnterpriseClusterTimeouts) : RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_cluster#zones-1">RedisEnterpriseCluster#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string>) : RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : RedisEnterpriseClusterState<'Location, 'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: RedisEnterpriseClusterState<Present, Present, Present, Present>) : azurerm.RedisEnterpriseCluster.RedisEnterpriseCluster =
            let config = azurerm.RedisEnterpriseCluster.RedisEnterpriseClusterConfig()
            for setter in state.assignments do
                setter config
            azurerm.RedisEnterpriseCluster.RedisEnterpriseCluster(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.redisEnterpriseCluster: missing required arguments. Must call: location, name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: RedisEnterpriseClusterState<_, _, _, _>) : azurerm.RedisEnterpriseCluster.RedisEnterpriseCluster =
            Unchecked.defaultof<azurerm.RedisEnterpriseCluster.RedisEnterpriseCluster>
