using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2SpotPrice
{
    [JsiiInterface(nativeType: typeof(IDataAwsEc2SpotPriceTimeouts), fullyQualifiedName: "aws.dataAwsEc2SpotPrice.DataAwsEc2SpotPriceTimeouts")]
    public interface IDataAwsEc2SpotPriceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_spot_price#read DataAwsEc2SpotPrice#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsEc2SpotPriceTimeouts), fullyQualifiedName: "aws.dataAwsEc2SpotPrice.DataAwsEc2SpotPriceTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsEc2SpotPrice.IDataAwsEc2SpotPriceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/ec2_spot_price#read DataAwsEc2SpotPrice#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
