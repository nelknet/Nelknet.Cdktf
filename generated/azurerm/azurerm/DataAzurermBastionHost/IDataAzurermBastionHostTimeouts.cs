using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermBastionHost
{
    [JsiiInterface(nativeType: typeof(IDataAzurermBastionHostTimeouts), fullyQualifiedName: "azurerm.dataAzurermBastionHost.DataAzurermBastionHostTimeouts")]
    public interface IDataAzurermBastionHostTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/bastion_host#read DataAzurermBastionHost#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermBastionHostTimeouts), fullyQualifiedName: "azurerm.dataAzurermBastionHost.DataAzurermBastionHostTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermBastionHost.IDataAzurermBastionHostTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/bastion_host#read DataAzurermBastionHost#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
