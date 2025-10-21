using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.QuicksightDataSource
{
    [JsiiInterface(nativeType: typeof(IQuicksightDataSourceParametersServiceNow), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersServiceNow")]
    public interface IQuicksightDataSourceParametersServiceNow
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/quicksight_data_source#site_base_url QuicksightDataSource#site_base_url}.</summary>
        [JsiiProperty(name: "siteBaseUrl", typeJson: "{\"primitive\":\"string\"}")]
        string SiteBaseUrl
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IQuicksightDataSourceParametersServiceNow), fullyQualifiedName: "aws.quicksightDataSource.QuicksightDataSourceParametersServiceNow")]
        internal sealed class _Proxy : DeputyBase, aws.QuicksightDataSource.IQuicksightDataSourceParametersServiceNow
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
