using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    [JsiiInterface(nativeType: typeof(IAppsyncDatasourceEventBridgeConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceEventBridgeConfig")]
    public interface IAppsyncDatasourceEventBridgeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#event_bus_arn AppsyncDatasource#event_bus_arn}.</summary>
        [JsiiProperty(name: "eventBusArn", typeJson: "{\"primitive\":\"string\"}")]
        string EventBusArn
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncDatasourceEventBridgeConfig), fullyQualifiedName: "aws.appsyncDatasource.AppsyncDatasourceEventBridgeConfig")]
        internal sealed class _Proxy : DeputyBase, aws.AppsyncDatasource.IAppsyncDatasourceEventBridgeConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#event_bus_arn AppsyncDatasource#event_bus_arn}.</summary>
            [JsiiProperty(name: "eventBusArn", typeJson: "{\"primitive\":\"string\"}")]
            public string EventBusArn
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
