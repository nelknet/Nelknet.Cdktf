using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.StoragegatewayGateway
{
    [JsiiInterface(nativeType: typeof(IStoragegatewayGatewayMaintenanceStartTime), fullyQualifiedName: "aws.storagegatewayGateway.StoragegatewayGatewayMaintenanceStartTime")]
    public interface IStoragegatewayGatewayMaintenanceStartTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#hour_of_day StoragegatewayGateway#hour_of_day}.</summary>
        [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}")]
        double HourOfDay
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#day_of_month StoragegatewayGateway#day_of_month}.</summary>
        [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DayOfMonth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#day_of_week StoragegatewayGateway#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DayOfWeek
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#minute_of_hour StoragegatewayGateway#minute_of_hour}.</summary>
        [JsiiProperty(name: "minuteOfHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinuteOfHour
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStoragegatewayGatewayMaintenanceStartTime), fullyQualifiedName: "aws.storagegatewayGateway.StoragegatewayGatewayMaintenanceStartTime")]
        internal sealed class _Proxy : DeputyBase, aws.StoragegatewayGateway.IStoragegatewayGatewayMaintenanceStartTime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#hour_of_day StoragegatewayGateway#hour_of_day}.</summary>
            [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}")]
            public double HourOfDay
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#day_of_month StoragegatewayGateway#day_of_month}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dayOfMonth", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DayOfMonth
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#day_of_week StoragegatewayGateway#day_of_week}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DayOfWeek
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#minute_of_hour StoragegatewayGateway#minute_of_hour}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "minuteOfHour", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinuteOfHour
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
