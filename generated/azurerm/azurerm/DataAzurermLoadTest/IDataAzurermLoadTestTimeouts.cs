using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermLoadTest
{
    [JsiiInterface(nativeType: typeof(IDataAzurermLoadTestTimeouts), fullyQualifiedName: "azurerm.dataAzurermLoadTest.DataAzurermLoadTestTimeouts")]
    public interface IDataAzurermLoadTestTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/load_test#read DataAzurermLoadTest#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermLoadTestTimeouts), fullyQualifiedName: "azurerm.dataAzurermLoadTest.DataAzurermLoadTestTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermLoadTest.IDataAzurermLoadTestTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/load_test#read DataAzurermLoadTest#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
