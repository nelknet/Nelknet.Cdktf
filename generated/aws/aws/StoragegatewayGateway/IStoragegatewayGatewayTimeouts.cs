using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.StoragegatewayGateway
{
    [JsiiInterface(nativeType: typeof(IStoragegatewayGatewayTimeouts), fullyQualifiedName: "aws.storagegatewayGateway.StoragegatewayGatewayTimeouts")]
    public interface IStoragegatewayGatewayTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#create StoragegatewayGateway#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IStoragegatewayGatewayTimeouts), fullyQualifiedName: "aws.storagegatewayGateway.StoragegatewayGatewayTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.StoragegatewayGateway.IStoragegatewayGatewayTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/storagegateway_gateway#create StoragegatewayGateway#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
