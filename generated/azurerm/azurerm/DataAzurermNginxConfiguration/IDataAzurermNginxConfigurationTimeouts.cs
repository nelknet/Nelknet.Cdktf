using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermNginxConfiguration
{
    [JsiiInterface(nativeType: typeof(IDataAzurermNginxConfigurationTimeouts), fullyQualifiedName: "azurerm.dataAzurermNginxConfiguration.DataAzurermNginxConfigurationTimeouts")]
    public interface IDataAzurermNginxConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_configuration#read DataAzurermNginxConfiguration#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermNginxConfigurationTimeouts), fullyQualifiedName: "azurerm.dataAzurermNginxConfiguration.DataAzurermNginxConfigurationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermNginxConfiguration.IDataAzurermNginxConfigurationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/nginx_configuration#read DataAzurermNginxConfiguration#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
