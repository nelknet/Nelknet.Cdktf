using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncGraphqlApi
{
    [JsiiClass(nativeType: typeof(aws.AppsyncGraphqlApi.AppsyncGraphqlApiEnhancedMetricsConfigOutputReference), fullyQualifiedName: "aws.appsyncGraphqlApi.AppsyncGraphqlApiEnhancedMetricsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppsyncGraphqlApiEnhancedMetricsConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppsyncGraphqlApiEnhancedMetricsConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncGraphqlApiEnhancedMetricsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncGraphqlApiEnhancedMetricsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataSourceLevelMetricsBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DataSourceLevelMetricsBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "operationLevelMetricsConfigInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? OperationLevelMetricsConfigInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "resolverLevelMetricsBehaviorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ResolverLevelMetricsBehaviorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "dataSourceLevelMetricsBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DataSourceLevelMetricsBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "operationLevelMetricsConfig", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string OperationLevelMetricsConfig
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "resolverLevelMetricsBehavior", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ResolverLevelMetricsBehavior
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appsyncGraphqlApi.AppsyncGraphqlApiEnhancedMetricsConfig\"}", isOptional: true)]
        public virtual aws.AppsyncGraphqlApi.IAppsyncGraphqlApiEnhancedMetricsConfig? InternalValue
        {
            get => GetInstanceProperty<aws.AppsyncGraphqlApi.IAppsyncGraphqlApiEnhancedMetricsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
