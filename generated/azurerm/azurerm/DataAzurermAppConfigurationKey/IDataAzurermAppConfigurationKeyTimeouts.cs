using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAppConfigurationKey
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAppConfigurationKeyTimeouts), fullyQualifiedName: "azurerm.dataAzurermAppConfigurationKey.DataAzurermAppConfigurationKeyTimeouts")]
    public interface IDataAzurermAppConfigurationKeyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_key#read DataAzurermAppConfigurationKey#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAppConfigurationKeyTimeouts), fullyQualifiedName: "azurerm.dataAzurermAppConfigurationKey.DataAzurermAppConfigurationKeyTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAppConfigurationKey.IDataAzurermAppConfigurationKeyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_configuration_key#read DataAzurermAppConfigurationKey#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
