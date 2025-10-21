using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncGraphqlApi
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncGraphqlApi.AppsyncGraphqlApiEnhancedMetricsConfig")]
    public class AppsyncGraphqlApiEnhancedMetricsConfig : aws.AppsyncGraphqlApi.IAppsyncGraphqlApiEnhancedMetricsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#data_source_level_metrics_behavior AppsyncGraphqlApi#data_source_level_metrics_behavior}.</summary>
        [JsiiProperty(name: "dataSourceLevelMetricsBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public string DataSourceLevelMetricsBehavior
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#operation_level_metrics_config AppsyncGraphqlApi#operation_level_metrics_config}.</summary>
        [JsiiProperty(name: "operationLevelMetricsConfig", typeJson: "{\"primitive\":\"string\"}")]
        public string OperationLevelMetricsConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#resolver_level_metrics_behavior AppsyncGraphqlApi#resolver_level_metrics_behavior}.</summary>
        [JsiiProperty(name: "resolverLevelMetricsBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public string ResolverLevelMetricsBehavior
        {
            get;
            set;
        }
    }
}
