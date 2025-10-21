using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ec2ImageBlockPublicAccess
{
    [JsiiInterface(nativeType: typeof(IEc2ImageBlockPublicAccessTimeouts), fullyQualifiedName: "aws.ec2ImageBlockPublicAccess.Ec2ImageBlockPublicAccessTimeouts")]
    public interface IEc2ImageBlockPublicAccessTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_image_block_public_access#update Ec2ImageBlockPublicAccess#update}.</summary>
        [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Update
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IEc2ImageBlockPublicAccessTimeouts), fullyQualifiedName: "aws.ec2ImageBlockPublicAccess.Ec2ImageBlockPublicAccessTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Ec2ImageBlockPublicAccess.IEc2ImageBlockPublicAccessTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ec2_image_block_public_access#update Ec2ImageBlockPublicAccess#update}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "update", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Update
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
