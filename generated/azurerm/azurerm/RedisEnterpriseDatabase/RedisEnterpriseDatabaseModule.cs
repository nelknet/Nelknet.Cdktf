using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedisEnterpriseDatabase
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.redisEnterpriseDatabase.RedisEnterpriseDatabaseModule")]
    public class RedisEnterpriseDatabaseModule : azurerm.RedisEnterpriseDatabase.IRedisEnterpriseDatabaseModule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#name RedisEnterpriseDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#args RedisEnterpriseDatabase#args}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "args", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Args
        {
            get;
            set;
        }
    }
}
