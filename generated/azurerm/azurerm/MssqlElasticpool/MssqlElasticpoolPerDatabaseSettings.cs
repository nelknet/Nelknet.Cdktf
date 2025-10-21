using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MssqlElasticpool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.mssqlElasticpool.MssqlElasticpoolPerDatabaseSettings")]
    public class MssqlElasticpoolPerDatabaseSettings : azurerm.MssqlElasticpool.IMssqlElasticpoolPerDatabaseSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#max_capacity MssqlElasticpool#max_capacity}.</summary>
        [JsiiProperty(name: "maxCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public double MaxCapacity
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_elasticpool#min_capacity MssqlElasticpool#min_capacity}.</summary>
        [JsiiProperty(name: "minCapacity", typeJson: "{\"primitive\":\"number\"}")]
        public double MinCapacity
        {
            get;
            set;
        }
    }
}
