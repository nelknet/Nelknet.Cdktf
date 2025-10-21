using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiInterface(nativeType: typeof(IKendraDataSourceConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration")]
    public interface IKendraDataSourceConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#site_maps KendraDataSource#site_maps}.</summary>
        [JsiiProperty(name: "siteMaps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] SiteMaps
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraDataSourceConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationUrlsSiteMapsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#site_maps KendraDataSource#site_maps}.</summary>
            [JsiiProperty(name: "siteMaps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] SiteMaps
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
