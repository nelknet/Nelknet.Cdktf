using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3AccessPoint
{
    [JsiiInterface(nativeType: typeof(IS3AccessPointVpcConfiguration), fullyQualifiedName: "aws.s3AccessPoint.S3AccessPointVpcConfiguration")]
    public interface IS3AccessPointVpcConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_access_point#vpc_id S3AccessPoint#vpc_id}.</summary>
        [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
        string VpcId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3AccessPointVpcConfiguration), fullyQualifiedName: "aws.s3AccessPoint.S3AccessPointVpcConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3AccessPoint.IS3AccessPointVpcConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/s3_access_point#vpc_id S3AccessPoint#vpc_id}.</summary>
            [JsiiProperty(name: "vpcId", typeJson: "{\"primitive\":\"string\"}")]
            public string VpcId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
