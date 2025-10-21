using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceParametersJira), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersJira")]
    public interface IQuicksightDataSourceParametersJira
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#site_base_url QuicksightDataSource#site_base_url}.</summary>
        [JsiiProperty(name: "siteBaseUrl", typeJson: "{\"primitive\":\"string\"}")]
        string SiteBaseUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceParametersJira), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersJira")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSource.IQuicksightDataSourceParametersJira
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#site_base_url QuicksightDataSource#site_base_url}.</summary>
            [JsiiProperty(name: "siteBaseUrl", typeJson: "{\"primitive\":\"string\"}")]
            public string SiteBaseUrl
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
