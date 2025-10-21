using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsRotation
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmcontactsRotation.SsmcontactsRotationRecurrenceShiftCoveragesCoverageTimesStart")]
    public class SsmcontactsRotationRecurrenceShiftCoveragesCoverageTimesStart : aws.SsmcontactsRotation.ISsmcontactsRotationRecurrenceShiftCoveragesCoverageTimesStart
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#hour_of_day SsmcontactsRotation#hour_of_day}.</summary>
        [JsiiProperty(name: "hourOfDay", typeJson: "{\"primitive\":\"number\"}")]
        public double HourOfDay
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_rotation#minute_of_hour SsmcontactsRotation#minute_of_hour}.</summary>
        [JsiiProperty(name: "minuteOfHour", typeJson: "{\"primitive\":\"number\"}")]
        public double MinuteOfHour
        {
            get;
            set;
        }
    }
}
