using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermAppServiceEnvironmentV3
{
    [JsiiInterface(nativeType: typeof(IDataAzurermAppServiceEnvironmentV3Timeouts), fullyQualifiedName: "azurerm.dataAzurermAppServiceEnvironmentV3.DataAzurermAppServiceEnvironmentV3Timeouts")]
    public interface IDataAzurermAppServiceEnvironmentV3Timeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_environment_v3#read DataAzurermAppServiceEnvironmentV3#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermAppServiceEnvironmentV3Timeouts), fullyQualifiedName: "azurerm.dataAzurermAppServiceEnvironmentV3.DataAzurermAppServiceEnvironmentV3Timeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermAppServiceEnvironmentV3.IDataAzurermAppServiceEnvironmentV3Timeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/app_service_environment_v3#read DataAzurermAppServiceEnvironmentV3#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
