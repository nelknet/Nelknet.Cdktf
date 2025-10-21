using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ConnectHoursOfOperation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.connectHoursOfOperation.ConnectHoursOfOperationConfigA")]
    public class ConnectHoursOfOperationConfigA : aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigA
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#day ConnectHoursOfOperation#day}.</summary>
        [JsiiProperty(name: "day", typeJson: "{\"primitive\":\"string\"}")]
        public string Day
        {
            get;
            set;
        }

        /// <summary>end_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#end_time ConnectHoursOfOperation#end_time}
        /// </remarks>
        [JsiiProperty(name: "endTime", typeJson: "{\"fqn\":\"aws.connectHoursOfOperation.ConnectHoursOfOperationConfigEndTime\"}")]
        public aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigEndTime EndTime
        {
            get;
            set;
        }

        /// <summary>start_time block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/connect_hours_of_operation#start_time ConnectHoursOfOperation#start_time}
        /// </remarks>
        [JsiiProperty(name: "startTime", typeJson: "{\"fqn\":\"aws.connectHoursOfOperation.ConnectHoursOfOperationConfigStartTime\"}")]
        public aws.ConnectHoursOfOperation.IConnectHoursOfOperationConfigStartTime StartTime
        {
            get;
            set;
        }
    }
}
