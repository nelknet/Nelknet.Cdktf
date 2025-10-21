using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectHoursOfOperation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connectHoursOfOperation.ConnectHoursOfOperationConfigEndTime")]
    public class ConnectHoursOfOperationConfigEndTime : aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigEndTime
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#hours ConnectHoursOfOperation#hours}.</summary>
        [JsiiProperty(name: "hours", typeJson: "{\"primitive\":\"number\"}")]
        public double Hours
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#minutes ConnectHoursOfOperation#minutes}.</summary>
        [JsiiProperty(name: "minutes", typeJson: "{\"primitive\":\"number\"}")]
        public double Minutes
        {
            get;
            set;
        }
    }
}
