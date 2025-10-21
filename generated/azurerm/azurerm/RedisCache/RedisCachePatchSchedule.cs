using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.RedisCache
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "azurerm.redisCache.RedisCachePatchSchedule")]
    public class RedisCachePatchSchedule : azurerm.RedisCache.IRedisCachePatchSchedule
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#day_of_week RedisCache#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        public string DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#maintenance_window RedisCache#maintenance_window}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maintenanceWindow", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MaintenanceWindow
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/redis_cache#start_hour_utc RedisCache#start_hour_utc}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "startHourUtc", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? StartHourUtc
        {
            get;
            set;
        }
    }
}
