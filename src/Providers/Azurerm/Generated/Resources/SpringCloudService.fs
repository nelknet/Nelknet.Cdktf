namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.SpringCloudService.SpringCloudServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service">azurerm_spring_cloud_service</a>.
    /// </summary>
    type SpringCloudServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudServiceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudServiceState<Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudServiceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudServiceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#location-1">SpringCloudService#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: SpringCloudServiceState<Missing, 'Name, 'ResourceGroupName>, value: string) : SpringCloudServiceState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : SpringCloudServiceState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#name-1">SpringCloudService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudServiceState<'Location, Missing, 'ResourceGroupName>, value: string) : SpringCloudServiceState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudServiceState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#resource_group_name-1">SpringCloudService#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SpringCloudServiceState<'Location, 'Name, Missing>, value: string) : SpringCloudServiceState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SpringCloudServiceState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#build_agent_pool_size-1">SpringCloudService#build_agent_pool_size</a>.
        /// </summary>
        [<CustomOperation "build_agent_pool_size">]
        member _.BuildAgentPoolSize(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: string) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.BuildAgentPoolSize <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// config_server_git_setting block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#config_server_git_setting-1">SpringCloudService#config_server_git_setting</a>
        /// </summary>
        [<CustomOperation "config_server_git_setting">]
        member _.ConfigServerGitSetting(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSetting) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ConfigServerGitSetting <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// container_registry block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#container_registry-1">SpringCloudService#container_registry</a> Accepts: azurerm.IResolvable | azurerm.SpringCloudService.SpringCloudServiceContainerRegistry[]
        /// </summary>
        [<CustomOperation "container_registry">]
        member _.ContainerRegistry(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ContainerRegistry <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// default_build_service block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#default_build_service-1">SpringCloudService#default_build_service</a>
        /// </summary>
        [<CustomOperation "default_build_service">]
        member _.DefaultBuildService(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.SpringCloudService.SpringCloudServiceDefaultBuildService) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DefaultBuildService <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#id-1">SpringCloudService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: string) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#log_stream_public_endpoint_enabled-1">SpringCloudService#log_stream_public_endpoint_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_stream_public_endpoint_enabled">]
        member _.LogStreamPublicEndpointEnabled(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: bool) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogStreamPublicEndpointEnabled <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#log_stream_public_endpoint_enabled-1">SpringCloudService#log_stream_public_endpoint_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "log_stream_public_endpoint_enabled">]
        member _.LogStreamPublicEndpointEnabled(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogStreamPublicEndpointEnabled <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#managed_environment_id-1">SpringCloudService#managed_environment_id</a>.
        /// </summary>
        [<CustomOperation "managed_environment_id">]
        member _.ManagedEnvironmentId(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: string) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ManagedEnvironmentId <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// marketplace block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#marketplace-1">SpringCloudService#marketplace</a>
        /// </summary>
        [<CustomOperation "marketplace">]
        member _.Marketplace(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.SpringCloudService.SpringCloudServiceMarketplace) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Marketplace <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// network block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#network-1">SpringCloudService#network</a>
        /// </summary>
        [<CustomOperation "network">]
        member _.Network(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.SpringCloudService.SpringCloudServiceNetwork) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Network <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#service_registry_enabled-1">SpringCloudService#service_registry_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "service_registry_enabled">]
        member _.ServiceRegistryEnabled(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: bool) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ServiceRegistryEnabled <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#service_registry_enabled-1">SpringCloudService#service_registry_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "service_registry_enabled">]
        member _.ServiceRegistryEnabled(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ServiceRegistryEnabled <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#sku_name-1">SpringCloudService#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: string) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#sku_tier-1">SpringCloudService#sku_tier</a>.
        /// </summary>
        [<CustomOperation "sku_tier">]
        member _.SkuTier(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: string) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.SkuTier <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#tags-1">SpringCloudService#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#timeouts-1">SpringCloudService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.SpringCloudService.SpringCloudServiceTimeouts) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// trace block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#trace-1">SpringCloudService#trace</a>
        /// </summary>
        [<CustomOperation "trace">]
        member _.Trace(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.SpringCloudService.SpringCloudServiceTrace) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Trace <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#zone_redundant-1">SpringCloudService#zone_redundant</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundant">]
        member _.ZoneRedundant(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: bool) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ZoneRedundant <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_service#zone_redundant-1">SpringCloudService#zone_redundant</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundant">]
        member _.ZoneRedundant(state: SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ZoneRedundant <- value)
            state : SpringCloudServiceState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: SpringCloudServiceState<Present, Present, Present>) : azurerm.SpringCloudService.SpringCloudService =
            let config = azurerm.SpringCloudService.SpringCloudServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudService.SpringCloudService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudService: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudServiceState<_, _, _>) : azurerm.SpringCloudService.SpringCloudService =
            Unchecked.defaultof<azurerm.SpringCloudService.SpringCloudService>
