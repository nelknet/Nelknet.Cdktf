using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.StoragegatewayGateway
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.storagegatewayGateway.StoragegatewayGatewayMaintenanceStartTime")]
    public class StoragegatewayGatewayMaintenanceStartTime : aws.StoragegatewayGateway.IStoragegatewayGatewayMaintenanceStartTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#hour_of_day StoragegatewayGateway#hour_of_day}.</summary>
        [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}")]
        public double HourOfDay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#day_of_month StoragegatewayGateway#day_of_month}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DayOfMonth
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#day_of_week StoragegatewayGateway#day_of_week}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#minute_of_hour StoragegatewayGateway#minute_of_hour}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "minuteOfHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinuteOfHour
        {
            get;
            set;
        }
    }
}
