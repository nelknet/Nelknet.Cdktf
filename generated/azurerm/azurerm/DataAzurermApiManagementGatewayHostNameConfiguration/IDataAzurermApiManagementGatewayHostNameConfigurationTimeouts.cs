using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermApiManagementGatewayHostNameConfiguration
{
    [JsiiInterface(nativeType: typeof(IDataAzurermApiManagementGatewayHostNameConfigurationTimeouts), fullyQualifiedName: "azurerm.dataAzurermApiManagementGatewayHostNameConfiguration.DataAzurermApiManagementGatewayHostNameConfigurationTimeouts")]
    public interface IDataAzurermApiManagementGatewayHostNameConfigurationTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_gateway_host_name_configuration#read DataAzurermApiManagementGatewayHostNameConfiguration#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermApiManagementGatewayHostNameConfigurationTimeouts), fullyQualifiedName: "azurerm.dataAzurermApiManagementGatewayHostNameConfiguration.DataAzurermApiManagementGatewayHostNameConfigurationTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermApiManagementGatewayHostNameConfiguration.IDataAzurermApiManagementGatewayHostNameConfigurationTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/api_management_gateway_host_name_configuration#read DataAzurermApiManagementGatewayHostNameConfiguration#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
