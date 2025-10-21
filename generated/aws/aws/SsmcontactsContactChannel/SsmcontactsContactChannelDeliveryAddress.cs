using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsContactChannel
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmcontactsContactChannel.SsmcontactsContactChannelDeliveryAddress")]
    public class SsmcontactsContactChannelDeliveryAddress : aws.SsmcontactsContactChannel.ISsmcontactsContactChannelDeliveryAddress
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_contact_channel#simple_address SsmcontactsContactChannel#simple_address}.</summary>
        [JsiiProperty(name: "simpleAddress", typeJson: "{\"primitive\":\"string\"}")]
        public string SimpleAddress
        {
            get;
            set;
        }
    }
}
