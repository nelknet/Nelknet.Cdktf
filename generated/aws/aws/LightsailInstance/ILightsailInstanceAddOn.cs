using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LightsailInstance
{
    [JsiiInterface(nativeType: typeof(ILightsailInstanceAddOn), fullyQualifiedName: "aws.lightsailInstance.LightsailInstanceAddOn")]
    public interface ILightsailInstanceAddOn
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#snapshot_time LightsailInstance#snapshot_time}.</summary>
        [JsiiProperty(name: "snapshotTime", typeJson: "{\"primitive\":\"string\"}")]
        string SnapshotTime
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#status LightsailInstance#status}.</summary>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#type LightsailInstance#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ILightsailInstanceAddOn), fullyQualifiedName: "aws.lightsailInstance.LightsailInstanceAddOn")]
        internal sealed class _Proxy : DeputyBase, aws.LightsailInstance.ILightsailInstanceAddOn
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#snapshot_time LightsailInstance#snapshot_time}.</summary>
            [JsiiProperty(name: "snapshotTime", typeJson: "{\"primitive\":\"string\"}")]
            public string SnapshotTime
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#status LightsailInstance#status}.</summary>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#type LightsailInstance#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
