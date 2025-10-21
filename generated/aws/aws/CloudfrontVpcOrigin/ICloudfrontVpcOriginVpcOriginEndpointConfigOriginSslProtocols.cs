using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CloudfrontVpcOrigin
{
    [JsiiInterface(nativeType: typeof(ICloudfrontVpcOriginVpcOriginEndpointConfigOriginSslProtocols), fullyQualifiedName: "aws.cloudfrontVpcOrigin.CloudfrontVpcOriginVpcOriginEndpointConfigOriginSslProtocols")]
    public interface ICloudfrontVpcOriginVpcOriginEndpointConfigOriginSslProtocols
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_vpc_origin#items CloudfrontVpcOrigin#items}.</summary>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Items
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_vpc_origin#quantity CloudfrontVpcOrigin#quantity}.</summary>
        [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}")]
        double Quantity
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontVpcOriginVpcOriginEndpointConfigOriginSslProtocols), fullyQualifiedName: "aws.cloudfrontVpcOrigin.CloudfrontVpcOriginVpcOriginEndpointConfigOriginSslProtocols")]
        internal sealed class _Proxy : DeputyBase, aws.CloudfrontVpcOrigin.ICloudfrontVpcOriginVpcOriginEndpointConfigOriginSslProtocols
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_vpc_origin#items CloudfrontVpcOrigin#items}.</summary>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Items
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_vpc_origin#quantity CloudfrontVpcOrigin#quantity}.</summary>
            [JsiiProperty(name: "quantity", typeJson: "{\"primitive\":\"number\"}")]
            public double Quantity
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
