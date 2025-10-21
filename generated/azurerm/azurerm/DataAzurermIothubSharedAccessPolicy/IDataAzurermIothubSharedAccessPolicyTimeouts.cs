using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermIothubSharedAccessPolicy
{
    [JsiiInterface(nativeType: typeof(IDataAzurermIothubSharedAccessPolicyTimeouts), fullyQualifiedName: "azurerm.dataAzurermIothubSharedAccessPolicy.DataAzurermIothubSharedAccessPolicyTimeouts")]
    public interface IDataAzurermIothubSharedAccessPolicyTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_shared_access_policy#read DataAzurermIothubSharedAccessPolicy#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermIothubSharedAccessPolicyTimeouts), fullyQualifiedName: "azurerm.dataAzurermIothubSharedAccessPolicy.DataAzurermIothubSharedAccessPolicyTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermIothubSharedAccessPolicy.IDataAzurermIothubSharedAccessPolicyTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/iothub_shared_access_policy#read DataAzurermIothubSharedAccessPolicy#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
