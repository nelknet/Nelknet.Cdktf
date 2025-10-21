using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsVpcEndpoint
{
    [JsiiInterface(nativeType: typeof(IDataAwsVpcEndpointTimeouts), fullyQualifiedName: "aws.dataAwsVpcEndpoint.DataAwsVpcEndpointTimeouts")]
    public interface IDataAwsVpcEndpointTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint#read DataAwsVpcEndpoint#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsVpcEndpointTimeouts), fullyQualifiedName: "aws.dataAwsVpcEndpoint.DataAwsVpcEndpointTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsVpcEndpoint.IDataAwsVpcEndpointTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/vpc_endpoint#read DataAwsVpcEndpoint#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
