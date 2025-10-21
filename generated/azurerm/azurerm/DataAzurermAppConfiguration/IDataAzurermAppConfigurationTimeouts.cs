using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAppConfiguration
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAppConfigurationTimeouts), fullyQualifiedName: "azurerm.dataAzurermAppConfiguration.DataAzurermAppConfigurationTimeouts")]
    public interface IDataAzurermAppConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration#read DataAzurermAppConfiguration#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAppConfigurationTimeouts), fullyQualifiedName: "azurerm.dataAzurermAppConfiguration.DataAzurermAppConfigurationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAppConfiguration.IDataAzurermAppConfigurationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration#read DataAzurermAppConfiguration#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
