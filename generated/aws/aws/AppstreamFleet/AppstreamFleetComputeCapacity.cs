using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamFleet
{
    [JsiiByValue(fqn: "aws.appstreamFleet.AppstreamFleetComputeCapacity")]
    public class AppstreamFleetComputeCapacity : aws.AppstreamFleet.IAppstreamFleetComputeCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#desired_instances AppstreamFleet#desired_instances}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "desiredInstances", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DesiredInstances
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#desired_sessions AppstreamFleet#desired_sessions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "desiredSessions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DesiredSessions
        {
            get;
            set;
        }
    }
}
