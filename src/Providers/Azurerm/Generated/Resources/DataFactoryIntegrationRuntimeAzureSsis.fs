namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> = { assignments: ResizeArray<azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis">azurerm_data_factory_integration_runtime_azure_ssis</a>.
    /// </summary>
    type DataFactoryIntegrationRuntimeAzureSsisBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryIntegrationRuntimeAzureSsisState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryIntegrationRuntimeAzureSsisState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryIntegrationRuntimeAzureSsisState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryIntegrationRuntimeAzureSsisState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#data_factory_id-1">DataFactoryIntegrationRuntimeAzureSsis#data_factory_id</a>.
        /// </summary>
        [<CustomOperation "data_factory_id">]
        member _.DataFactoryId(state: DataFactoryIntegrationRuntimeAzureSsisState<Missing, 'Location, 'Name, 'NodeSize>, value: string) : DataFactoryIntegrationRuntimeAzureSsisState<Present, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.DataFactoryId <- value)
            ({ assignments = state.assignments } : DataFactoryIntegrationRuntimeAzureSsisState<Present, 'Location, 'Name, 'NodeSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#location-1">DataFactoryIntegrationRuntimeAzureSsis#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, Missing, 'Name, 'NodeSize>, value: string) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, Present, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, Present, 'Name, 'NodeSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#name-1">DataFactoryIntegrationRuntimeAzureSsis#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, Missing, 'NodeSize>, value: string) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, Present, 'NodeSize> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, Present, 'NodeSize>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#node_size-1">DataFactoryIntegrationRuntimeAzureSsis#node_size</a>.
        /// </summary>
        [<CustomOperation "node_size">]
        member _.NodeSize(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, Missing>, value: string) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.NodeSize <- value)
            ({ assignments = state.assignments } : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, Present>)

        /// <summary>
        /// catalog_info block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#catalog_info-1">DataFactoryIntegrationRuntimeAzureSsis#catalog_info</a>
        /// </summary>
        [<CustomOperation "catalog_info">]
        member _.CatalogInfo(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisCatalogInfo) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.CatalogInfo <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// copy_compute_scale block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#copy_compute_scale-1">DataFactoryIntegrationRuntimeAzureSsis#copy_compute_scale</a>
        /// </summary>
        [<CustomOperation "copy_compute_scale">]
        member _.CopyComputeScale(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisCopyComputeScale) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.CopyComputeScale <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#credential_name-1">DataFactoryIntegrationRuntimeAzureSsis#credential_name</a>.
        /// </summary>
        [<CustomOperation "credential_name">]
        member _.CredentialName(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: string) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.CredentialName <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// custom_setup_script block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#custom_setup_script-1">DataFactoryIntegrationRuntimeAzureSsis#custom_setup_script</a>
        /// </summary>
        [<CustomOperation "custom_setup_script">]
        member _.CustomSetupScript(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisCustomSetupScript) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.CustomSetupScript <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#description-1">DataFactoryIntegrationRuntimeAzureSsis#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: string) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#edition-1">DataFactoryIntegrationRuntimeAzureSsis#edition</a>.
        /// </summary>
        [<CustomOperation "edition">]
        member _.Edition(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: string) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.Edition <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// express_custom_setup block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#express_custom_setup-1">DataFactoryIntegrationRuntimeAzureSsis#express_custom_setup</a>
        /// </summary>
        [<CustomOperation "express_custom_setup">]
        member _.ExpressCustomSetup(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisExpressCustomSetup) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.ExpressCustomSetup <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// express_vnet_integration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#express_vnet_integration-1">DataFactoryIntegrationRuntimeAzureSsis#express_vnet_integration</a>
        /// </summary>
        [<CustomOperation "express_vnet_integration">]
        member _.ExpressVnetIntegration(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisExpressVnetIntegration) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.ExpressVnetIntegration <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#id-1">DataFactoryIntegrationRuntimeAzureSsis#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: string) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#license_type-1">DataFactoryIntegrationRuntimeAzureSsis#license_type</a>.
        /// </summary>
        [<CustomOperation "license_type">]
        member _.LicenseType(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: string) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.LicenseType <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#max_parallel_executions_per_node-1">DataFactoryIntegrationRuntimeAzureSsis#max_parallel_executions_per_node</a>.
        /// </summary>
        [<CustomOperation "max_parallel_executions_per_node">]
        member _.MaxParallelExecutionsPerNode(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: double) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.MaxParallelExecutionsPerNode <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#number_of_nodes-1">DataFactoryIntegrationRuntimeAzureSsis#number_of_nodes</a>.
        /// </summary>
        [<CustomOperation "number_of_nodes">]
        member _.NumberOfNodes(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: double) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.NumberOfNodes <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// package_store block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#package_store-1">DataFactoryIntegrationRuntimeAzureSsis#package_store</a> Accepts: azurerm.IResolvable | azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisPackageStore[]
        /// </summary>
        [<CustomOperation "package_store">]
        member _.PackageStore(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.PackageStore <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// pipeline_external_compute_scale block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#pipeline_external_compute_scale-1">DataFactoryIntegrationRuntimeAzureSsis#pipeline_external_compute_scale</a>
        /// </summary>
        [<CustomOperation "pipeline_external_compute_scale">]
        member _.PipelineExternalComputeScale(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisPipelineExternalComputeScale) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.PipelineExternalComputeScale <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// proxy block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#proxy-1">DataFactoryIntegrationRuntimeAzureSsis#proxy</a>
        /// </summary>
        [<CustomOperation "proxy">]
        member _.Proxy(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisProxy) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.Proxy <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#timeouts-1">DataFactoryIntegrationRuntimeAzureSsis#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisTimeouts) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        /// <summary>
        /// vnet_integration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory_integration_runtime_azure_ssis#vnet_integration-1">DataFactoryIntegrationRuntimeAzureSsis#vnet_integration</a>
        /// </summary>
        [<CustomOperation "vnet_integration">]
        member _.VnetIntegration(state: DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>, value: azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisVnetIntegration) : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize> =
            state.assignments.Add(fun config -> config.VnetIntegration <- value)
            state : DataFactoryIntegrationRuntimeAzureSsisState<'DataFactoryId, 'Location, 'Name, 'NodeSize>

        member _.Run(state: DataFactoryIntegrationRuntimeAzureSsisState<Present, Present, Present, Present>) : azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsis =
            let config = azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsisConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsis(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactoryIntegrationRuntimeAzureSsis: missing required arguments. Must call: data_factory_id, location, name, node_size.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryIntegrationRuntimeAzureSsisState<_, _, _, _>) : azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsis =
            Unchecked.defaultof<azurerm.DataFactoryIntegrationRuntimeAzureSsis.DataFactoryIntegrationRuntimeAzureSsis>
