namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.AppServicePlan.AppServicePlanConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan">azurerm_app_service_plan</a>.
    /// </summary>
    type AppServicePlanBuilder(logicalId: string) =
        member _.Yield(_: unit) : AppServicePlanState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServicePlanState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : AppServicePlanState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : AppServicePlanState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#location-1">AppServicePlan#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: AppServicePlanState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : AppServicePlanState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : AppServicePlanState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#name-1">AppServicePlan#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: AppServicePlanState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : AppServicePlanState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : AppServicePlanState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#resource_group_name-1">AppServicePlan#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: AppServicePlanState<'Location, 'Name, Missing, 'Sku>, value: string) : AppServicePlanState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : AppServicePlanState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// sku block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#sku-1">AppServicePlan#sku</a>
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, Missing>, value: azurerm.AppServicePlan.AppServicePlanSku) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#app_service_environment_id-1">AppServicePlan#app_service_environment_id</a>.
        /// </summary>
        [<CustomOperation "app_service_environment_id">]
        member _.AppServiceEnvironmentId(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AppServiceEnvironmentId <- value)
            state : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#id-1">AppServicePlan#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#is_xenon-1">AppServicePlan#is_xenon</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_xenon">]
        member _.IsXenon(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.IsXenon <- value)
            state : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#is_xenon-1">AppServicePlan#is_xenon</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_xenon">]
        member _.IsXenon(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.IsXenon <- value)
            state : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#kind-1">AppServicePlan#kind</a>.
        /// </summary>
        [<CustomOperation "kind">]
        member _.Kind(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Kind <- value)
            state : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#maximum_elastic_worker_count-1">AppServicePlan#maximum_elastic_worker_count</a>.
        /// </summary>
        [<CustomOperation "maximum_elastic_worker_count">]
        member _.MaximumElasticWorkerCount(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.MaximumElasticWorkerCount <- value)
            state : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#per_site_scaling-1">AppServicePlan#per_site_scaling</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "per_site_scaling">]
        member _.PerSiteScaling(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PerSiteScaling <- value)
            state : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#per_site_scaling-1">AppServicePlan#per_site_scaling</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "per_site_scaling">]
        member _.PerSiteScaling(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.PerSiteScaling <- value)
            state : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#reserved-1">AppServicePlan#reserved</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "reserved">]
        member _.Reserved(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Reserved <- value)
            state : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#reserved-1">AppServicePlan#reserved</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "reserved">]
        member _.Reserved(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Reserved <- value)
            state : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#tags-1">AppServicePlan#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#timeouts-1">AppServicePlan#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.AppServicePlan.AppServicePlanTimeouts) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#zone_redundant-1">AppServicePlan#zone_redundant</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundant">]
        member _.ZoneRedundant(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ZoneRedundant <- value)
            state : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/app_service_plan#zone_redundant-1">AppServicePlan#zone_redundant</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "zone_redundant">]
        member _.ZoneRedundant(state: AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ZoneRedundant <- value)
            state : AppServicePlanState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: AppServicePlanState<Present, Present, Present, Present>) : azurerm.AppServicePlan.AppServicePlan =
            let config = azurerm.AppServicePlan.AppServicePlanConfig()
            for setter in state.assignments do
                setter config
            azurerm.AppServicePlan.AppServicePlan(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.appServicePlan: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: AppServicePlanState<_, _, _, _>) : azurerm.AppServicePlan.AppServicePlan =
            Unchecked.defaultof<azurerm.AppServicePlan.AppServicePlan>
