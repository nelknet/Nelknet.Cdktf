using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncGraphqlApi
{
    [JsiiInterface(nativeType: typeof(IAppsyncGraphqlApiEnhancedMetricsConfig), fullyQualifiedName: "aws.appsyncGraphqlApi.AppsyncGraphqlApiEnhancedMetricsConfig")]
    public interface IAppsyncGraphqlApiEnhancedMetricsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#data_source_level_metrics_behavior AppsyncGraphqlApi#data_source_level_metrics_behavior}.</summary>
        [JsiiProperty(name: "dataSourceLevelMetricsBehavior", typeJson: "{\"primitive\":\"string\"}")]
        string DataSourceLevelMetricsBehavior
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#operation_level_metrics_config AppsyncGraphqlApi#operation_level_metrics_config}.</summary>
        [JsiiProperty(name: "operationLevelMetricsConfig", typeJson: "{\"primitive\":\"string\"}")]
        string OperationLevelMetricsConfig
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#resolver_level_metrics_behavior AppsyncGraphqlApi#resolver_level_metrics_behavior}.</summary>
        [JsiiProperty(name: "resolverLevelMetricsBehavior", typeJson: "{\"primitive\":\"string\"}")]
        string ResolverLevelMetricsBehavior
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncGraphqlApiEnhancedMetricsConfig), fullyQualifiedName: "aws.appsyncGraphqlApi.AppsyncGraphqlApiEnhancedMetricsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncGraphqlApi.IAppsyncGraphqlApiEnhancedMetricsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#data_source_level_metrics_behavior AppsyncGraphqlApi#data_source_level_metrics_behavior}.</summary>
            [JsiiProperty(name: "dataSourceLevelMetricsBehavior", typeJson: "{\"primitive\":\"string\"}")]
            public string DataSourceLevelMetricsBehavior
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#operation_level_metrics_config AppsyncGraphqlApi#operation_level_metrics_config}.</summary>
            [JsiiProperty(name: "operationLevelMetricsConfig", typeJson: "{\"primitive\":\"string\"}")]
            public string OperationLevelMetricsConfig
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_graphql_api#resolver_level_metrics_behavior AppsyncGraphqlApi#resolver_level_metrics_behavior}.</summary>
            [JsiiProperty(name: "resolverLevelMetricsBehavior", typeJson: "{\"primitive\":\"string\"}")]
            public string ResolverLevelMetricsBehavior
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
