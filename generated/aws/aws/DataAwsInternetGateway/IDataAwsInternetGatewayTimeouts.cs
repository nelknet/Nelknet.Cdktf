using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsInternetGateway
{
    [JsiiInterface(nativeType: typeof(IDataAwsInternetGatewayTimeouts), fullyQualifiedName: "aws.dataAwsInternetGateway.DataAwsInternetGatewayTimeouts")]
    public interface IDataAwsInternetGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/internet_gateway#read DataAwsInternetGateway#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsInternetGatewayTimeouts), fullyQualifiedName: "aws.dataAwsInternetGateway.DataAwsInternetGatewayTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsInternetGateway.IDataAwsInternetGatewayTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/internet_gateway#read DataAwsInternetGateway#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
