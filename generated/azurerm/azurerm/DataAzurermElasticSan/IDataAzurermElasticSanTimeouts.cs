using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermElasticSan
{
    [JsiiInterface(nativeType: typeof(IDataAzurermElasticSanTimeouts), fullyQualifiedName: "azurerm.dataAzurermElasticSan.DataAzurermElasticSanTimeouts")]
    public interface IDataAzurermElasticSanTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san#read DataAzurermElasticSan#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermElasticSanTimeouts), fullyQualifiedName: "azurerm.dataAzurermElasticSan.DataAzurermElasticSanTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermElasticSan.IDataAzurermElasticSanTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/elastic_san#read DataAzurermElasticSan#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
