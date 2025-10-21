using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.NetworkmanagerDevice
{
    [JsiiInterface(nativeType: typeof(INetworkmanagerDeviceAwsLocation), fullyQualifiedName: "aws.networkmanagerDevice.NetworkmanagerDeviceAwsLocation")]
    public interface INetworkmanagerDeviceAwsLocation
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#subnet_arn NetworkmanagerDevice#subnet_arn}.</summary>
        [JsiiProperty(name: "subnetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubnetArn
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#zone NetworkmanagerDevice#zone}.</summary>
        [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Zone
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(INetworkmanagerDeviceAwsLocation), fullyQualifiedName: "aws.networkmanagerDevice.NetworkmanagerDeviceAwsLocation")]
        internal sealed class _Proxy : DeputyBase, aws.NetworkmanagerDevice.INetworkmanagerDeviceAwsLocation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#subnet_arn NetworkmanagerDevice#subnet_arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "subnetArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubnetArn
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/networkmanager_device#zone NetworkmanagerDevice#zone}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "zone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Zone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
