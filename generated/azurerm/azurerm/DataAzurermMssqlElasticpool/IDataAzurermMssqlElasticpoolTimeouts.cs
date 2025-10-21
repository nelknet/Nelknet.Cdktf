using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermMssqlElasticpool
{
    [JsiiInterface(nativeType: typeof(IDataAzurermMssqlElasticpoolTimeouts), fullyQualifiedName: "azurerm.dataAzurermMssqlElasticpool.DataAzurermMssqlElasticpoolTimeouts")]
    public interface IDataAzurermMssqlElasticpoolTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_elasticpool#read DataAzurermMssqlElasticpool#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAzurermMssqlElasticpoolTimeouts), fullyQualifiedName: "azurerm.dataAzurermMssqlElasticpool.DataAzurermMssqlElasticpoolTimeouts")]
        internal sealed class _Proxy : DeputyBase, azurerm.DataAzurermMssqlElasticpool.IDataAzurermMssqlElasticpoolTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/mssql_elasticpool#read DataAzurermMssqlElasticpool#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
