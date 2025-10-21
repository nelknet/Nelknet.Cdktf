using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedisEnterpriseDatabase
{
    [JsiiInterface(nativeType: typeof(IRedisEnterpriseDatabaseModule), fullyQualifiedName: "azurerm.redisEnterpriseDatabase.RedisEnterpriseDatabaseModule")]
    public interface IRedisEnterpriseDatabaseModule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#name RedisEnterpriseDatabase#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#args RedisEnterpriseDatabase#args}.</summary>
        [JsiiProperty(name: "args", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Args
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedisEnterpriseDatabaseModule), fullyQualifiedName: "azurerm.redisEnterpriseDatabase.RedisEnterpriseDatabaseModule")]
        internal sealed class _Proxy : DeputyBase, azurerm.RedisEnterpriseDatabase.IRedisEnterpriseDatabaseModule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#name RedisEnterpriseDatabase#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_enterprise_database#args RedisEnterpriseDatabase#args}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "args", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Args
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
