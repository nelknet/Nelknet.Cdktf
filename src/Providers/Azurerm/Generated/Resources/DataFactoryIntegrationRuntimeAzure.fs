namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name> = { assignments: ResizeArray<azurerm.DataFactoryIntegrationRuntimeAzure.DataFactoryIntegrationRuntimeAzureConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure">azurerm_data_factory_integration_runtime_azure</a>.
    /// </summary>
    type DataFactoryIntegrationRuntimeAzureBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryIntegrationRuntimeAzureState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryIntegrationRuntimeAzureState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryIntegrationRuntimeAzureState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryIntegrationRuntimeAzureState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure#data_factory_id-1">DataFactoryIntegrationRuntimeAzure#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryIntegrationRuntimeAzureState<Missing, 'Location, 'Name>, value: string) : DataFactoryIntegrationRuntimeAzureState<Present, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryIntegrationRuntimeAzureState<Present, 'Location, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure#location-1">DataFactoryIntegrationRuntimeAzure#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, Missing, 'Name>, value: string) : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, Present, 'Name> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure#name-1">DataFactoryIntegrationRuntimeAzure#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, Missing>, value: string) : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure#cleanup_enabled-1">DataFactoryIntegrationRuntimeAzure#cleanup_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "cleanup_enabled">]
        member _.CleanupEnabled(state: DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>, value: bool) : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.CleanupEnabled <- value)
            state : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure#cleanup_enabled-1">DataFactoryIntegrationRuntimeAzure#cleanup_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "cleanup_enabled">]
        member _.CleanupEnabled(state: DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.CleanupEnabled <- value)
            state : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure#compute_type-1">DataFactoryIntegrationRuntimeAzure#compute_type</a>.
        /// </summary>
        [<CustomOperation "compute_type">]
        member _.ComputeType(state: DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>, value: string) : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.ComputeType <- value)
            state : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure#core_count-1">DataFactoryIntegrationRuntimeAzure#core_count</a>.
        /// </summary>
        [<CustomOperation "core_count">]
        member _.CoreCount(state: DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>, value: double) : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.CoreCount <- value)
            state : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure#description-1">DataFactoryIntegrationRuntimeAzure#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>, value: string) : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure#id-1">DataFactoryIntegrationRuntimeAzure#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>, value: string) : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure#timeouts-1">DataFactoryIntegrationRuntimeAzure#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>, value: azurerm.DataFactoryIntegrationRuntimeAzure.DataFactoryIntegrationRuntimeAzureTimeouts) : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure#time_to_live_min-1">DataFactoryIntegrationRuntimeAzure#time_to_live_min</a>.
        /// </summary>
        [<CustomOperation "time_to_live_min">]
        member _.TimeToLiveMin(state: DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>, value: double) : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.TimeToLiveMin <- value)
            state : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure#virtual_network_enabled-1">DataFactoryIntegrationRuntimeAzure#virtual_network_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "virtual_network_enabled">]
        member _.VirtualNetworkEnabled(state: DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>, value: bool) : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.VirtualNetworkEnabled <- value)
            state : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure#virtual_network_enabled-1">DataFactoryIntegrationRuntimeAzure#virtual_network_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "virtual_network_enabled">]
        member _.VirtualNetworkEnabled(state: DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name> =
            state.assignments.Add(fun config -> config.VirtualNetworkEnabled <- value)
            state : DataFactoryIntegrationRuntimeAzureState<'DataFactoryId, 'Location, 'Name>

        member _.Run(state: DataFactoryIntegrationRuntimeAzureState<Present, Present, Present>) : azurerm.DataFactoryIntegrationRuntimeAzure.DataFactoryIntegrationRuntimeAzure =
            let config = azurerm.DataFactoryIntegrationRuntimeAzure.DataFactoryIntegrationRuntimeAzureConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryIntegrationRuntimeAzure.DataFactoryIntegrationRuntimeAzure(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryIntegrationRuntimeAzure: missing required arguments. Must call: data_factory_id, location, name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryIntegrationRuntimeAzureState<_, _, _>) : azurerm.DataFactoryIntegrationRuntimeAzure.DataFactoryIntegrationRuntimeAzure =
            Unchecked.defaultof<azurerm.DataFactoryIntegrationRuntimeAzure.DataFactoryIntegrationRuntimeAzure>
