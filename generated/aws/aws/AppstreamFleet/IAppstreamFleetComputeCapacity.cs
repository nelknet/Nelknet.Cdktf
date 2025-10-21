using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamFleet
{
    [JsiiInterface(nativeType: typeof(IAppstreamFleetComputeCapacity), fullyQualifiedName: "aws.appstreamFleet.AppstreamFleetComputeCapacity")]
    public interface IAppstreamFleetComputeCapacity
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#desired_instances AppstreamFleet#desired_instances}.</summary>
        [JsiiProperty(name: "desiredInstances", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DesiredInstances
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#desired_sessions AppstreamFleet#desired_sessions}.</summary>
        [JsiiProperty(name: "desiredSessions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DesiredSessions
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppstreamFleetComputeCapacity), fullyQualifiedName: "aws.appstreamFleet.AppstreamFleetComputeCapacity")]
        internal sealed class _Proxy : DeputyBase, aws.AppstreamFleet.IAppstreamFleetComputeCapacity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#desired_instances AppstreamFleet#desired_instances}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "desiredInstances", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DesiredInstances
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_fleet#desired_sessions AppstreamFleet#desired_sessions}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "desiredSessions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DesiredSessions
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
