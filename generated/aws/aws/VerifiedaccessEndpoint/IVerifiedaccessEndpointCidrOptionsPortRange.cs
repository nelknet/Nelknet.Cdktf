using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VerifiedaccessEndpoint
{
    [JsiiInterface(nativeType: typeof(IVerifiedaccessEndpointCidrOptionsPortRange), fullyQualifiedName: "aws.verifiedaccessEndpoint.VerifiedaccessEndpointCidrOptionsPortRange")]
    public interface IVerifiedaccessEndpointCidrOptionsPortRange
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#from_port VerifiedaccessEndpoint#from_port}.</summary>
        [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}")]
        double FromPort
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#to_port VerifiedaccessEndpoint#to_port}.</summary>
        [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}")]
        double ToPort
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IVerifiedaccessEndpointCidrOptionsPortRange), fullyQualifiedName: "aws.verifiedaccessEndpoint.VerifiedaccessEndpointCidrOptionsPortRange")]
        internal sealed class _Proxy : DeputyBase, aws.VerifiedaccessEndpoint.IVerifiedaccessEndpointCidrOptionsPortRange
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#from_port VerifiedaccessEndpoint#from_port}.</summary>
            [JsiiProperty(name: "fromPort", typeJson: "{\"primitive\":\"number\"}")]
            public double FromPort
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/verifiedaccess_endpoint#to_port VerifiedaccessEndpoint#to_port}.</summary>
            [JsiiProperty(name: "toPort", typeJson: "{\"primitive\":\"number\"}")]
            public double ToPort
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
