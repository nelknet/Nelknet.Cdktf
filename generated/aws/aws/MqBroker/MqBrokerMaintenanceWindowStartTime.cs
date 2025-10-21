using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MqBroker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.mqBroker.MqBrokerMaintenanceWindowStartTime")]
    public class MqBrokerMaintenanceWindowStartTime : aws.MqBroker.IMqBrokerMaintenanceWindowStartTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#day_of_week MqBroker#day_of_week}.</summary>
        [JsiiProperty(name: "dayOfWeek", typeJson: "{\"primitive\":\"string\"}")]
        public string DayOfWeek
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#time_of_day MqBroker#time_of_day}.</summary>
        [JsiiProperty(name: "timeOfDay", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeOfDay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/mq_broker#time_zone MqBroker#time_zone}.</summary>
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}")]
        public string TimeZone
        {
            get;
            set;
        }
    }
}
