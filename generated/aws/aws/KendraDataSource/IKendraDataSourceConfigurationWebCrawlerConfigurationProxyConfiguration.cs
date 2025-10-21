using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiInterface(nativeType: typeof(IKendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration")]
    public interface IKendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#host KendraDataSource#host}.</summary>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
        string Host
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#port KendraDataSource#port}.</summary>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        double Port
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#credentials KendraDataSource#credentials}.</summary>
        [JsiiProperty(name: "credentials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Credentials
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.KendraDataSource.IKendraDataSourceConfigurationWebCrawlerConfigurationProxyConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#host KendraDataSource#host}.</summary>
            [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}")]
            public string Host
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#port KendraDataSource#port}.</summary>
            [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
            public double Port
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#credentials KendraDataSource#credentials}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "credentials", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Credentials
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
