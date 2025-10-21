using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.BatchAccount
{
    [JsiiInterface(nativeType: typeof(IBatchAccountNetworkProfileNodeManagementAccessIpRule), fullyQualifiedName: "azurerm.batchAccount.BatchAccountNetworkProfileNodeManagementAccessIpRule")]
    public interface IBatchAccountNetworkProfileNodeManagementAccessIpRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#ip_range BatchAccount#ip_range}.</summary>
        [JsiiProperty(name: "ipRange", typeJson: "{\"primitive\":\"string\"}")]
        string IpRange
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#action BatchAccount#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBatchAccountNetworkProfileNodeManagementAccessIpRule), fullyQualifiedName: "azurerm.batchAccount.BatchAccountNetworkProfileNodeManagementAccessIpRule")]
        internal sealed class _Proxy : DeputyBase, azurerm.BatchAccount.IBatchAccountNetworkProfileNodeManagementAccessIpRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#ip_range BatchAccount#ip_range}.</summary>
            [JsiiProperty(name: "ipRange", typeJson: "{\"primitive\":\"string\"}")]
            public string IpRange
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/batch_account#action BatchAccount#action}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Action
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
