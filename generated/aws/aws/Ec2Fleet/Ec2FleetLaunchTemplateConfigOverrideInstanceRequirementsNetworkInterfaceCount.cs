using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2Fleet
{
    [JsiiByValue(fqn: "aws.ec2Fleet.Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount")]
    public class Ec2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount : aws.Ec2Fleet.IEc2FleetLaunchTemplateConfigOverrideInstanceRequirementsNetworkInterfaceCount
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#max Ec2Fleet#max}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "max", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Max
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_fleet#min Ec2Fleet#min}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "min", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Min
        {
            get;
            set;
        }
    }
}
