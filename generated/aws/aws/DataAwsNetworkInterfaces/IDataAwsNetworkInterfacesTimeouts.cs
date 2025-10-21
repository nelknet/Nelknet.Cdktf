using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsNetworkInterfaces
{
    [JsiiInterface(nativeType: typeof(IDataAwsNetworkInterfacesTimeouts), fullyQualifiedName: "aws.dataAwsNetworkInterfaces.DataAwsNetworkInterfacesTimeouts")]
    public interface IDataAwsNetworkInterfacesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interfaces#read DataAwsNetworkInterfaces#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsNetworkInterfacesTimeouts), fullyQualifiedName: "aws.dataAwsNetworkInterfaces.DataAwsNetworkInterfacesTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsNetworkInterfaces.IDataAwsNetworkInterfacesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/network_interfaces#read DataAwsNetworkInterfaces#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
