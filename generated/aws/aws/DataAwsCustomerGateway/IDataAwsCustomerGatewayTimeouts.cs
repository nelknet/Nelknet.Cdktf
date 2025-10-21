using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCustomerGateway
{
    [JsiiInterface(nativeType: typeof(IDataAwsCustomerGatewayTimeouts), fullyQualifiedName: "aws.dataAwsCustomerGateway.DataAwsCustomerGatewayTimeouts")]
    public interface IDataAwsCustomerGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/customer_gateway#read DataAwsCustomerGateway#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsCustomerGatewayTimeouts), fullyQualifiedName: "aws.dataAwsCustomerGateway.DataAwsCustomerGatewayTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsCustomerGateway.IDataAwsCustomerGatewayTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/customer_gateway#read DataAwsCustomerGateway#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
