using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontVpcOrigin
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfrontVpcOrigin.CloudfrontVpcOriginVpcOriginEndpointConfigOriginSslProtocols")]
    public class CloudfrontVpcOriginVpcOriginEndpointConfigOriginSslProtocols : aws.CloudfrontVpcOrigin.ICloudfrontVpcOriginVpcOriginEndpointConfigOriginSslProtocols
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_vpc_origin#items CloudfrontVpcOrigin#items}.</summary>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Items
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_vpc_origin#quantity CloudfrontVpcOrigin#quantity}.</summary>
        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}")]
        public double Quantity
        {
            get;
            set;
        }
    }
}
