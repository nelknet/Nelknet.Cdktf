using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.GlobalacceleratorListener
{
    [JsiiByValue(fqn: "aws.globalacceleratorListener.GlobalacceleratorListenerPortRange")]
    public class GlobalacceleratorListenerPortRange : aws.GlobalacceleratorListener.IGlobalacceleratorListenerPortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_listener#from_port GlobalacceleratorListener#from_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? FromPort
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/globalaccelerator_listener#to_port GlobalacceleratorListener#to_port}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ToPort
        {
            get;
            set;
        }
    }
}
