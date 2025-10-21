using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.DataAzurermRedisEnterpriseDatabase
{
    [JsiiByValue(fqn: "azurerm.dataAzurermRedisEnterpriseDatabase.DataAzurermRedisEnterpriseDatabaseTimeouts")]
    public class DataAzurermRedisEnterpriseDatabaseTimeouts : azurerm.DataAzurermRedisEnterpriseDatabase.IDataAzurermRedisEnterpriseDatabaseTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/redis_enterprise_database#read DataAzurermRedisEnterpriseDatabase#read}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Read
        {
            get;
            set;
        }
    }
}
