using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkInterface
{
    [JsiiInterface(nativeType: typeof(IDataAwsNetworkInterfaceTimeouts), fullyQualifiedName: "aws.dataAwsNetworkInterface.DataAwsNetworkInterfaceTimeouts")]
    public interface IDataAwsNetworkInterfaceTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interface#read DataAwsNetworkInterface#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsNetworkInterfaceTimeouts), fullyQualifiedName: "aws.dataAwsNetworkInterface.DataAwsNetworkInterfaceTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsNetworkInterface.IDataAwsNetworkInterfaceTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interface#read DataAwsNetworkInterface#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
