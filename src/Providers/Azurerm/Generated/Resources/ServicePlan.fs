namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.ServicePlan.ServicePlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan">azurerm_service_plan</a>.
    /// </summary>
    type ServicePlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : ServicePlanState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicePlanState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ServicePlanState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ServicePlanState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#location-1">ServicePlan#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ServicePlanState<Missing, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>, value: string) : ServicePlanState<Present, 'Name, 'OsType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ServicePlanState<Present, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#name-1">ServicePlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ServicePlanState<'Location, Missing, 'OsType, 'ResourceGroupName, 'SkuName>, value: string) : ServicePlanState<'Location, Present, 'OsType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ServicePlanState<'Location, Present, 'OsType, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#os_type-1">ServicePlan#os_type</a>.
        /// </summary>
        [<CustomOperation "os_type">]
        member _.OsType(state: ServicePlanState<'Location, 'Name, Missing, 'ResourceGroupName, 'SkuName>, value: string) : ServicePlanState<'Location, 'Name, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.OsType <- value)
            ({ assignments = state.assignments } : ServicePlanState<'Location, 'Name, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#resource_group_name-1">ServicePlan#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ServicePlanState<'Location, 'Name, 'OsType, Missing, 'SkuName>, value: string) : ServicePlanState<'Location, 'Name, 'OsType, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ServicePlanState<'Location, 'Name, 'OsType, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#sku_name-1">ServicePlan#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, Missing>, value: string) : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#app_service_environment_id-1">ServicePlan#app_service_environment_id</a>.
        /// </summary>
        [<CustomOperation "app_service_environment_id">]
        member _.AppServiceEnvironmentId(state: ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>, value: string) : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.AppServiceEnvironmentId <- value)
            state : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#id-1">ServicePlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>, value: string) : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#maximum_elastic_worker_count-1">ServicePlan#maximum_elastic_worker_count</a>.
        /// </summary>
        [<CustomOperation "maximum_elastic_worker_count">]
        member _.MaximumElasticWorkerCount(state: ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>, value: double) : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.MaximumElasticWorkerCount <- value)
            state : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#per_site_scaling_enabled-1">ServicePlan#per_site_scaling_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "per_site_scaling_enabled">]
        member _.PerSiteScalingEnabled(state: ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>, value: bool) : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PerSiteScalingEnabled <- value)
            state : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#per_site_scaling_enabled-1">ServicePlan#per_site_scaling_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "per_site_scaling_enabled">]
        member _.PerSiteScalingEnabled(state: ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PerSiteScalingEnabled <- value)
            state : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#tags-1">ServicePlan#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#timeouts-1">ServicePlan#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>, value: azurerm.ServicePlan.ServicePlanTimeouts) : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#worker_count-1">ServicePlan#worker_count</a>.
        /// </summary>
        [<CustomOperation "worker_count">]
        member _.WorkerCount(state: ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>, value: double) : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.WorkerCount <- value)
            state : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#zone_balancing_enabled-1">ServicePlan#zone_balancing_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_balancing_enabled">]
        member _.ZoneBalancingEnabled(state: ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>, value: bool) : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.ZoneBalancingEnabled <- value)
            state : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/service_plan#zone_balancing_enabled-1">ServicePlan#zone_balancing_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_balancing_enabled">]
        member _.ZoneBalancingEnabled(state: ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.ZoneBalancingEnabled <- value)
            state : ServicePlanState<'Location, 'Name, 'OsType, 'ResourceGroupName, 'SkuName>

        member _.Run(state: ServicePlanState<Present, Present, Present, Present, Present>) : azurerm.ServicePlan.ServicePlan =
            let config = azurerm.ServicePlan.ServicePlanConfig()
            for setter in state.assignments do
                setter config
            azurerm.ServicePlan.ServicePlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.servicePlan: missing required arguments. Must call: location, name, os_type, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: ServicePlanState<_, _, _, _, _>) : azurerm.ServicePlan.ServicePlan =
            Unchecked.defaultof<azurerm.ServicePlan.ServicePlan>
