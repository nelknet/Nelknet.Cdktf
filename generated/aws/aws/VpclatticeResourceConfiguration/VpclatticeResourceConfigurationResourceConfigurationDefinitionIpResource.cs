using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpclatticeResourceConfiguration
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.vpclatticeResourceConfiguration.VpclatticeResourceConfigurationResourceConfigurationDefinitionIpResource")]
    public class VpclatticeResourceConfigurationResourceConfigurationDefinitionIpResource : aws.VpclatticeResourceConfiguration.IVpclatticeResourceConfigurationResourceConfigurationDefinitionIpResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/vpclattice_resource_configuration#ip_address VpclatticeResourceConfiguration#ip_address}.</summary>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string IpAddress
        {
            get;
            set;
        }
    }
}
