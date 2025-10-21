using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiInterface(nativeType: typeof(IKendraDataSourceConfigurationS3ConfigurationAccessControlListConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfigurationS3ConfigurationAccessControlListConfiguration")]
    public interface IKendraDataSourceConfigurationS3ConfigurationAccessControlListConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#key_path KendraDataSource#key_path}.</summary>
        [JsiiProperty(name: "keyPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyPath
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraDataSourceConfigurationS3ConfigurationAccessControlListConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfigurationS3ConfigurationAccessControlListConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.KendraDataSource.IKendraDataSourceConfigurationS3ConfigurationAccessControlListConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#key_path KendraDataSource#key_path}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyPath
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
