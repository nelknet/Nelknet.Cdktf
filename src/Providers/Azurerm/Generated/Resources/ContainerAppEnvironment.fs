namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ContainerAppEnvironment.ContainerAppEnvironmentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment">azurerm_container_app_environment</a>.
    /// </summary>
    type ContainerAppEnvironmentBuilder(logicalId: string) =
        member _.Yield(_: unit) : ContainerAppEnvironmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppEnvironmentState<Missing, Missing, Missing>)

        member _.Zero(()) : ContainerAppEnvironmentState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ContainerAppEnvironmentState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#location-1">ContainerAppEnvironment#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ContainerAppEnvironmentState<Missing, 'Name, 'ResourceGroupName>, value: string) : ContainerAppEnvironmentState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// The name of the Container Apps Managed Environment. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#name-1">ContainerAppEnvironment#name</a>
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ContainerAppEnvironmentState<'Location, Missing, 'ResourceGroupName>, value: string) : ContainerAppEnvironmentState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#resource_group_name-1">ContainerAppEnvironment#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ContainerAppEnvironmentState<'Location, 'Name, Missing>, value: string) : ContainerAppEnvironmentState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ContainerAppEnvironmentState<'Location, 'Name, Present>)

        /// <summary>
        /// Application Insights connection string used by Dapr to export Service to Service communication telemetry. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#dapr_application_insights_connection_string-1">ContainerAppEnvironment#dapr_application_insights_connection_string</a>
        /// </summary>
        [<CustomOperation "dapr_application_insights_connection_string">]
        member _.DaprApplicationInsightsConnectionString(state: ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>, value: string) : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DaprApplicationInsightsConnectionString <- value)
            state : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#id-1">ContainerAppEnvironment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>, value: string) : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Name of the platform-managed resource group created for the Managed Environment to host infrastructure resources. **Note:** Only valid if a `workload_profile` is specified. If `infrastructure_subnet_id` is specified, this resource group will be created in the same subscription as `infrastructure_subnet_id`. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#infrastructure_resource_group_name-1">ContainerAppEnvironment#infrastructure_resource_group_name</a>
        /// </summary>
        [<CustomOperation "infrastructure_resource_group_name">]
        member _.InfrastructureResourceGroupName(state: ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>, value: string) : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InfrastructureResourceGroupName <- value)
            state : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// The existing Subnet to use for the Container Apps Control Plane. **NOTE:** The Subnet must have a `/21` or larger address space. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#infrastructure_subnet_id-1">ContainerAppEnvironment#infrastructure_subnet_id</a>
        /// </summary>
        [<CustomOperation "infrastructure_subnet_id">]
        member _.InfrastructureSubnetId(state: ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>, value: string) : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InfrastructureSubnetId <- value)
            state : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#internal_load_balancer_enabled-1">ContainerAppEnvironment#internal_load_balancer_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internal_load_balancer_enabled">]
        member _.InternalLoadBalancerEnabled(state: ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>, value: bool) : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InternalLoadBalancerEnabled <- value)
            state : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Should the Container Environment operate in Internal Load Balancing Mode? Defaults to `false`. **Note:** can only be set to `true` if `infrastructure_subnet_id` is specified. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#internal_load_balancer_enabled-1">ContainerAppEnvironment#internal_load_balancer_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "internal_load_balancer_enabled">]
        member _.InternalLoadBalancerEnabled(state: ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.InternalLoadBalancerEnabled <- value)
            state : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// The ID for the Log Analytics Workspace to link this Container Apps Managed Environment to. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#log_analytics_workspace_id-1">ContainerAppEnvironment#log_analytics_workspace_id</a>
        /// </summary>
        [<CustomOperation "log_analytics_workspace_id">]
        member _.LogAnalyticsWorkspaceId(state: ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>, value: string) : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.LogAnalyticsWorkspaceId <- value)
            state : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#mutual_tls_enabled-1">ContainerAppEnvironment#mutual_tls_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "mutual_tls_enabled">]
        member _.MutualTlsEnabled(state: ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>, value: bool) : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MutualTlsEnabled <- value)
            state : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Should mutual transport layer security (mTLS) be enabled? Defaults to `false`. **Note:** This feature is in public preview. Enabling mTLS for your applications may increase response latency and reduce maximum throughput in high-load scenarios. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#mutual_tls_enabled-1">ContainerAppEnvironment#mutual_tls_enabled</a> Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "mutual_tls_enabled">]
        member _.MutualTlsEnabled(state: ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.MutualTlsEnabled <- value)
            state : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#tags-1">ContainerAppEnvironment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#timeouts-1">ContainerAppEnvironment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.ContainerAppEnvironment.ContainerAppEnvironmentTimeouts) : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// workload_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#workload_profile-1">ContainerAppEnvironment#workload_profile</a> Accepts: azurerm.IResolvable | azurerm.ContainerAppEnvironment.ContainerAppEnvironmentWorkloadProfile[]
        /// </summary>
        [<CustomOperation "workload_profile">]
        member _.WorkloadProfile(state: ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.WorkloadProfile <- value)
            state : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#zone_redundancy_enabled-1">ContainerAppEnvironment#zone_redundancy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundancy_enabled">]
        member _.ZoneRedundancyEnabled(state: ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>, value: bool) : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ZoneRedundancyEnabled <- value)
            state : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/container_app_environment#zone_redundancy_enabled-1">ContainerAppEnvironment#zone_redundancy_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundancy_enabled">]
        member _.ZoneRedundancyEnabled(state: ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ZoneRedundancyEnabled <- value)
            state : ContainerAppEnvironmentState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ContainerAppEnvironmentState<Present, Present, Present>) : azurerm.ContainerAppEnvironment.ContainerAppEnvironment =
            let config = azurerm.ContainerAppEnvironment.ContainerAppEnvironmentConfig()
            for setter in state.assignments do
                setter config
            azurerm.ContainerAppEnvironment.ContainerAppEnvironment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.containerAppEnvironment: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ContainerAppEnvironmentState<_, _, _>) : azurerm.ContainerAppEnvironment.ContainerAppEnvironment =
            Unchecked.defaultof<azurerm.ContainerAppEnvironment.ContainerAppEnvironment>
