namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudGatewayState<'Name, 'SpringCloudServiceId> = { assignments: ResizeArray<azurerm.SpringCloudGateway.SpringCloudGatewayConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway">azurerm_spring_cloud_gateway</a>.
    /// </summary>
    type SpringCloudGatewayBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudGatewayState<Missing, Missing>)

        member _.Zero(()) : SpringCloudGatewayState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudGatewayState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#name-1">SpringCloudGateway#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudGatewayState<Missing, 'SpringCloudServiceId>, value: string) : SpringCloudGatewayState<Present, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudGatewayState<Present, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#spring_cloud_service_id-1">SpringCloudGateway#spring_cloud_service_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_service_id">]
        member _.SpringCloudServiceId(state: SpringCloudGatewayState<'Name, Missing>, value: string) : SpringCloudGatewayState<'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudServiceId <- value)
            ({ assignments = state.assignments } : SpringCloudGatewayState<'Name, Present>)

        /// <summary>
        /// api_metadata block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#api_metadata-1">SpringCloudGateway#api_metadata</a>
        /// </summary>
        [<CustomOperation "api_metadata">]
        member _.ApiMetadata(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudGateway.SpringCloudGatewayApiMetadata) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ApiMetadata <- value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#application_performance_monitoring_ids-1">SpringCloudGateway#application_performance_monitoring_ids</a>.
        /// </summary>
        [<CustomOperation "application_performance_monitoring_ids">]
        member _.ApplicationPerformanceMonitoringIds(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: seq<string>) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ApplicationPerformanceMonitoringIds <- (value |> Seq.toArray))
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#application_performance_monitoring_types-1">SpringCloudGateway#application_performance_monitoring_types</a>.
        /// </summary>
        [<CustomOperation "application_performance_monitoring_types">]
        member _.ApplicationPerformanceMonitoringTypes(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: seq<string>) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ApplicationPerformanceMonitoringTypes <- (value |> Seq.toArray))
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// client_authorization block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#client_authorization-1">SpringCloudGateway#client_authorization</a>
        /// </summary>
        [<CustomOperation "client_authorization">]
        member _.ClientAuthorization(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudGateway.SpringCloudGatewayClientAuthorization) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.ClientAuthorization <- value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// cors block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#cors-1">SpringCloudGateway#cors</a>
        /// </summary>
        [<CustomOperation "cors">]
        member _.Cors(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudGateway.SpringCloudGatewayCors) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Cors <- value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#environment_variables-1">SpringCloudGateway#environment_variables</a>.
        /// </summary>
        [<CustomOperation "environment_variables">]
        member _.EnvironmentVariables(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: seq<string * string>) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.EnvironmentVariables <- dict value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#https_only-1">SpringCloudGateway#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#https_only-1">SpringCloudGateway#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#id-1">SpringCloudGateway#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: string) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#instance_count-1">SpringCloudGateway#instance_count</a>.
        /// </summary>
        [<CustomOperation "instance_count">]
        member _.InstanceCount(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: double) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.InstanceCount <- value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// local_response_cache_per_instance block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#local_response_cache_per_instance-1">SpringCloudGateway#local_response_cache_per_instance</a>
        /// </summary>
        [<CustomOperation "local_response_cache_per_instance">]
        member _.LocalResponseCachePerInstance(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudGateway.SpringCloudGatewayLocalResponseCachePerInstance) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.LocalResponseCachePerInstance <- value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// local_response_cache_per_route block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#local_response_cache_per_route-1">SpringCloudGateway#local_response_cache_per_route</a>
        /// </summary>
        [<CustomOperation "local_response_cache_per_route">]
        member _.LocalResponseCachePerRoute(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudGateway.SpringCloudGatewayLocalResponseCachePerRoute) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.LocalResponseCachePerRoute <- value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#public_network_access_enabled-1">SpringCloudGateway#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: bool) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#public_network_access_enabled-1">SpringCloudGateway#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// quota block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#quota-1">SpringCloudGateway#quota</a>
        /// </summary>
        [<CustomOperation "quota">]
        member _.Quota(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudGateway.SpringCloudGatewayQuota) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Quota <- value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#sensitive_environment_variables-1">SpringCloudGateway#sensitive_environment_variables</a>.
        /// </summary>
        [<CustomOperation "sensitive_environment_variables">]
        member _.SensitiveEnvironmentVariables(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: seq<string * string>) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.SensitiveEnvironmentVariables <- dict value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// sso block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#sso-1">SpringCloudGateway#sso</a>
        /// </summary>
        [<CustomOperation "sso">]
        member _.Sso(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudGateway.SpringCloudGatewaySso) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Sso <- value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_gateway#timeouts-1">SpringCloudGateway#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudGatewayState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudGateway.SpringCloudGatewayTimeouts) : SpringCloudGatewayState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudGatewayState<'Name, 'SpringCloudServiceId>

        member _.Run(state: SpringCloudGatewayState<Present, Present>) : azurerm.SpringCloudGateway.SpringCloudGateway =
            let config = azurerm.SpringCloudGateway.SpringCloudGatewayConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudGateway.SpringCloudGateway(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudGateway: missing required arguments. Must call: name, spring_cloud_service_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudGatewayState<_, _>) : azurerm.SpringCloudGateway.SpringCloudGateway =
            Unchecked.defaultof<azurerm.SpringCloudGateway.SpringCloudGateway>
