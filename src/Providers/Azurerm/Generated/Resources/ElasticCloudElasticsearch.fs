namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.ElasticCloudElasticsearch.ElasticCloudElasticsearchConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch">azurerm_elastic_cloud_elasticsearch</a>.
    /// </summary>
    type ElasticCloudElasticsearchBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticCloudElasticsearchState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticCloudElasticsearchState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ElasticCloudElasticsearchState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticCloudElasticsearchState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#elastic_cloud_email_address-1">ElasticCloudElasticsearch#elastic_cloud_email_address</a>.
        /// </summary>
        [<CustomOperation "elastic_cloud_email_address">]
        member _.ElasticCloudEmailAddress(state: ElasticCloudElasticsearchState<Missing, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : ElasticCloudElasticsearchState<Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.ElasticCloudEmailAddress <- value)
            ({ assignments = state.assignments } : ElasticCloudElasticsearchState<Present, 'Location, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#location-1">ElasticCloudElasticsearch#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, Missing, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, Present, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, Present, 'Name, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#name-1">ElasticCloudElasticsearch#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, Missing, 'ResourceGroupName, 'SkuName>, value: string) : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#resource_group_name-1">ElasticCloudElasticsearch#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, Missing, 'SkuName>, value: string) : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#sku_name-1">ElasticCloudElasticsearch#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#id-1">ElasticCloudElasticsearch#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: string) : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#logs-1">ElasticCloudElasticsearch#logs</a>
        /// </summary>
        [<CustomOperation "logs">]
        member _.Logs(state: ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.ElasticCloudElasticsearch.ElasticCloudElasticsearchLogs) : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Logs <- value)
            state : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#monitoring_enabled-1">ElasticCloudElasticsearch#monitoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "monitoring_enabled">]
        member _.MonitoringEnabled(state: ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: bool) : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.MonitoringEnabled <- value)
            state : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#monitoring_enabled-1">ElasticCloudElasticsearch#monitoring_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "monitoring_enabled">]
        member _.MonitoringEnabled(state: ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.MonitoringEnabled <- value)
            state : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#tags-1">ElasticCloudElasticsearch#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/elastic_cloud_elasticsearch#timeouts-1">ElasticCloudElasticsearch#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName>, value: azurerm.ElasticCloudElasticsearch.ElasticCloudElasticsearchTimeouts) : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElasticCloudElasticsearchState<'ElasticCloudEmailAddress, 'Location, 'Name, 'ResourceGroupName, 'SkuName>

        member _.Run(state: ElasticCloudElasticsearchState<Present, Present, Present, Present, Present>) : azurerm.ElasticCloudElasticsearch.ElasticCloudElasticsearch =
            let config = azurerm.ElasticCloudElasticsearch.ElasticCloudElasticsearchConfig()
            for setter in state.assignments do
                setter config
            azurerm.ElasticCloudElasticsearch.ElasticCloudElasticsearch(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.elasticCloudElasticsearch: missing required arguments. Must call: elastic_cloud_email_address, location, name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: ElasticCloudElasticsearchState<_, _, _, _, _>) : azurerm.ElasticCloudElasticsearch.ElasticCloudElasticsearch =
            Unchecked.defaultof<azurerm.ElasticCloudElasticsearch.ElasticCloudElasticsearch>
