using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlElasticpool
{
    [JsiiInterface(nativeType: typeof(IMssqlElasticpoolPerDatabaseSettings), fullyQualifiedName: "azurerm.mssqlElasticpool.MssqlElasticpoolPerDatabaseSettings")]
    public interface IMssqlElasticpoolPerDatabaseSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#max_capacity MssqlElasticpool#max_capacity}.</summary>
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double MaxCapacity
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#min_capacity MssqlElasticpool#min_capacity}.</summary>
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}")]
        double MinCapacity
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMssqlElasticpoolPerDatabaseSettings), fullyQualifiedName: "azurerm.mssqlElasticpool.MssqlElasticpoolPerDatabaseSettings")]
        internal sealed class _Proxy : DeputyBase, azurerm.MssqlElasticpool.IMssqlElasticpoolPerDatabaseSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#max_capacity MssqlElasticpool#max_capacity}.</summary>
            [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxCapacity
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#min_capacity MssqlElasticpool#min_capacity}.</summary>
            [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}")]
            public double MinCapacity
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
