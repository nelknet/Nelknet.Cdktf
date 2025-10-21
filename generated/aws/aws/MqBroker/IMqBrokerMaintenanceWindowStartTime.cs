using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MqBroker
{
    [JsiiInterface(nativeType: typeof(IMqBrokerMaintenanceWindowStartTime), fullyQualifiedName: "aws.mqBroker.MqBrokerMaintenanceWindowStartTime")]
    public interface IMqBrokerMaintenanceWindowStartTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#day_of_week MqBroker#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        string DayOfWeek
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#time_of_day MqBroker#time_of_day}.</summary>
        [JsiiProperty(name: "timeOfDay", typeJson: "{\"primitive\":\"string\"}")]
        string TimeOfDay
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#time_zone MqBroker#time_zone}.</summary>
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        string TimeZone
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMqBrokerMaintenanceWindowStartTime), fullyQualifiedName: "aws.mqBroker.MqBrokerMaintenanceWindowStartTime")]
        internal sealed class _Proxy : DeputyBase, aws.MqBroker.IMqBrokerMaintenanceWindowStartTime
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#day_of_week MqBroker#day_of_week}.</summary>
            [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
            public string DayOfWeek
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#time_of_day MqBroker#time_of_day}.</summary>
            [JsiiProperty(name: "timeOfDay", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeOfDay
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#time_zone MqBroker#time_zone}.</summary>
            [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
            public string TimeZone
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
