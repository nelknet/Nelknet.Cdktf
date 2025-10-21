using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppsyncDatasource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsyncDatasource.AppsyncDatasourceEventBridgeConfig")]
    public class AppsyncDatasourceEventBridgeConfig : aws.AppsyncDatasource.IAppsyncDatasourceEventBridgeConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appsync_datasource#event_bus_arn AppsyncDatasource#event_bus_arn}.</summary>
        [JsiiProperty(name: "eventBusArn", typeJson: "{\"primitive\":\"string\"}")]
        public string EventBusArn
        {
            get;
            set;
        }
    }
}
