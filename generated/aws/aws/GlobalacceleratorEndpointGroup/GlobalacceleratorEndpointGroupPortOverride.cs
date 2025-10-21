using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlobalacceleratorEndpointGroup
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.globalacceleratorEndpointGroup.GlobalacceleratorEndpointGroupPortOverride")]
    public class GlobalacceleratorEndpointGroupPortOverride : aws.GlobalacceleratorEndpointGroup.IGlobalacceleratorEndpointGroupPortOverride
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group#endpoint_port GlobalacceleratorEndpointGroup#endpoint_port}.</summary>
        [JsiiProperty(name: "endpointPort", typeJson: "{\"primitive\":\"number\"}")]
        public double EndpointPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_endpoint_group#listener_port GlobalacceleratorEndpointGroup#listener_port}.</summary>
        [JsiiProperty(name: "listenerPort", typeJson: "{\"primitive\":\"number\"}")]
        public double ListenerPort
        {
            get;
            set;
        }
    }
}
