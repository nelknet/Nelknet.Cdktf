using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermTrafficManagerProfile
{
    [JsiiInterface(nativeType: typeof(IDataAzurermTrafficManagerProfileTimeouts), fullyQualifiedName: "azurerm.dataAzurermTrafficManagerProfile.DataAzurermTrafficManagerProfileTimeouts")]
    public interface IDataAzurermTrafficManagerProfileTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/traffic_manager_profile#read DataAzurermTrafficManagerProfile#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermTrafficManagerProfileTimeouts), fullyQualifiedName: "azurerm.dataAzurermTrafficManagerProfile.DataAzurermTrafficManagerProfileTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermTrafficManagerProfile.IDataAzurermTrafficManagerProfileTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/traffic_manager_profile#read DataAzurermTrafficManagerProfile#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
