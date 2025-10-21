using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermSpringCloudService
{
    [JsiiInterface(nativeType: typeof(IDataAzurermSpringCloudServiceTimeouts), fullyQualifiedName: "azurerm.dataAzurermSpringCloudService.DataAzurermSpringCloudServiceTimeouts")]
    public interface IDataAzurermSpringCloudServiceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spring_cloud_service#read DataAzurermSpringCloudService#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermSpringCloudServiceTimeouts), fullyQualifiedName: "azurerm.dataAzurermSpringCloudService.DataAzurermSpringCloudServiceTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermSpringCloudService.IDataAzurermSpringCloudServiceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/spring_cloud_service#read DataAzurermSpringCloudService#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
