using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2Fleet
{
    [JsiiInterface(nativeType: typeof(IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps")]
    public interface IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#max Ec2Fleet#max}.</summary>
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Max
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#min Ec2Fleet#min}.</summary>
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Min
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps), fullyQualifiedName: "aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkBandwidthGbps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#max Ec2Fleet#max}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Max
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#min Ec2Fleet#min}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Min
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
