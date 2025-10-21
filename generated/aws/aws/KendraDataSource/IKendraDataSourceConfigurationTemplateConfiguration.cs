using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    [JsiiInterface(nativeType: typeof(IKendraDataSourceConfigurationTemplateConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfigurationTemplateConfiguration")]
    public interface IKendraDataSourceConfigurationTemplateConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#template KendraDataSource#template}.</summary>
        [JsiiProperty(name: "template", typeJson: "{\"primitive\":\"string\"}")]
        string Template
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IKendraDataSourceConfigurationTemplateConfiguration), fullyQualifiedName: "aws.kendraDataSource.KendraDataSourceConfigurationTemplateConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.KendraDataSource.IKendraDataSourceConfigurationTemplateConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#template KendraDataSource#template}.</summary>
            [JsiiProperty(name: "template", typeJson: "{\"primitive\":\"string\"}")]
            public string Template
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
