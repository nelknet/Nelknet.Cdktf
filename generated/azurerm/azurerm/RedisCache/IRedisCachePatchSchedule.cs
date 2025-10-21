using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedisCache
{
    [JsiiInterface(nativeType: typeof(IRedisCachePatchSchedule), fullyQualifiedName: "azurerm.redisCache.RedisCachePatchSchedule")]
    public interface IRedisCachePatchSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#day_of_week RedisCache#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        string DayOfWeek
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maintenance_window RedisCache#maintenance_window}.</summary>
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MaintenanceWindow
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#start_hour_utc RedisCache#start_hour_utc}.</summary>
        [JsiiProperty(name: "startHourUtc", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartHourUtc
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRedisCachePatchSchedule), fullyQualifiedName: "azurerm.redisCache.RedisCachePatchSchedule")]
        internal sealed class _Proxy : DeputyBase, azurerm.RedisCache.IRedisCachePatchSchedule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#day_of_week RedisCache#day_of_week}.</summary>
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
            public string DayOfWeek
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maintenance_window RedisCache#maintenance_window}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MaintenanceWindow
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#start_hour_utc RedisCache#start_hour_utc}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "startHourUtc", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartHourUtc
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
