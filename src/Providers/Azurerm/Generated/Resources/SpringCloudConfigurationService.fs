namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId> = { assignments: ResizeArray<azurerm.SpringCloudConfigurationService.SpringCloudConfigurationServiceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_configuration_service">azurerm_spring_cloud_configuration_service</a>.
    /// </summary>
    type SpringCloudConfigurationServiceBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudConfigurationServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudConfigurationServiceState<Missing, Missing>)

        member _.Zero(()) : SpringCloudConfigurationServiceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudConfigurationServiceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_configuration_service#name-1">SpringCloudConfigurationService#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudConfigurationServiceState<Missing, 'SpringCloudServiceId>, value: string) : SpringCloudConfigurationServiceState<Present, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudConfigurationServiceState<Present, 'SpringCloudServiceId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_configuration_service#spring_cloud_service_id-1">SpringCloudConfigurationService#spring_cloud_service_id</a>.
        /// </summary>
        [<CustomOperation "spring_cloud_service_id">]
        member _.SpringCloudServiceId(state: SpringCloudConfigurationServiceState<'Name, Missing>, value: string) : SpringCloudConfigurationServiceState<'Name, Present> =
            state.assignments.Add(fun config -> config.SpringCloudServiceId <- value)
            ({ assignments = state.assignments } : SpringCloudConfigurationServiceState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_configuration_service#generation-1">SpringCloudConfigurationService#generation</a>.
        /// </summary>
        [<CustomOperation "generation">]
        member _.Generation(state: SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId>, value: string) : SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Generation <- value)
            state : SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_configuration_service#id-1">SpringCloudConfigurationService#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId>, value: string) : SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_configuration_service#refresh_interval_in_seconds-1">SpringCloudConfigurationService#refresh_interval_in_seconds</a>.
        /// </summary>
        [<CustomOperation "refresh_interval_in_seconds">]
        member _.RefreshIntervalInSeconds(state: SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId>, value: double) : SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.RefreshIntervalInSeconds <- value)
            state : SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// repository block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_configuration_service#repository-1">SpringCloudConfigurationService#repository</a> Accepts: azurerm.IResolvable | azurerm.SpringCloudConfigurationService.SpringCloudConfigurationServiceRepository[]
        /// </summary>
        [<CustomOperation "repository">]
        member _.Repository(state: SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Repository <- value)
            state : SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_configuration_service#timeouts-1">SpringCloudConfigurationService#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId>, value: azurerm.SpringCloudConfigurationService.SpringCloudConfigurationServiceTimeouts) : SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudConfigurationServiceState<'Name, 'SpringCloudServiceId>

        member _.Run(state: SpringCloudConfigurationServiceState<Present, Present>) : azurerm.SpringCloudConfigurationService.SpringCloudConfigurationService =
            let config = azurerm.SpringCloudConfigurationService.SpringCloudConfigurationServiceConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudConfigurationService.SpringCloudConfigurationService(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudConfigurationService: missing required arguments. Must call: name, spring_cloud_service_id.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudConfigurationServiceState<_, _>) : azurerm.SpringCloudConfigurationService.SpringCloudConfigurationService =
            Unchecked.defaultof<azurerm.SpringCloudConfigurationService.SpringCloudConfigurationService>
