namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermElasticCloudElasticsearchState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_cloud_elasticsearch">azurerm_elastic_cloud_elasticsearch</a>.
    /// </summary>
    type DataAzurermElasticCloudElasticsearchBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermElasticCloudElasticsearchState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermElasticCloudElasticsearchState<Missing, Missing>)

        member _.Zero(()) : DataAzurermElasticCloudElasticsearchState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermElasticCloudElasticsearchState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_cloud_elasticsearch#name-1">DataAzurermElasticCloudElasticsearch#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermElasticCloudElasticsearchState<Missing, 'ResourceGroupName>, value: string) : DataAzurermElasticCloudElasticsearchState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermElasticCloudElasticsearchState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_cloud_elasticsearch#resource_group_name-1">DataAzurermElasticCloudElasticsearch#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermElasticCloudElasticsearchState<'Name, Missing>, value: string) : DataAzurermElasticCloudElasticsearchState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermElasticCloudElasticsearchState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_cloud_elasticsearch#id-1">DataAzurermElasticCloudElasticsearch#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermElasticCloudElasticsearchState<'Name, 'ResourceGroupName>, value: string) : DataAzurermElasticCloudElasticsearchState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermElasticCloudElasticsearchState<'Name, 'ResourceGroupName>

        /// <summary>
        /// logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_cloud_elasticsearch#logs-1">DataAzurermElasticCloudElasticsearch#logs</a> Accepts: azurerm.IResolvable | azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchLogs[]
        /// </summary>
        [<CustomOperation "logs">]
        member _.Logs(state: DataAzurermElasticCloudElasticsearchState<'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DataAzurermElasticCloudElasticsearchState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Logs <- value)
            state : DataAzurermElasticCloudElasticsearchState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_cloud_elasticsearch#timeouts-1">DataAzurermElasticCloudElasticsearch#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermElasticCloudElasticsearchState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchTimeouts) : DataAzurermElasticCloudElasticsearchState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermElasticCloudElasticsearchState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermElasticCloudElasticsearchState<Present, Present>) : azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearch =
            let config = azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearchConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearch(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermElasticCloudElasticsearch: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermElasticCloudElasticsearchState<_, _>) : azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearch =
            Unchecked.defaultof<azurerm.DataAzurermElasticCloudElasticsearch.DataAzurermElasticCloudElasticsearch>
