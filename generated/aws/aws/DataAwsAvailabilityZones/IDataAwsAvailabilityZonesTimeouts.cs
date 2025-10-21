using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAvailabilityZones
{
    [JsiiInterface(nativeType: typeof(IDataAwsAvailabilityZonesTimeouts), fullyQualifiedName: "aws.dataAwsAvailabilityZones.DataAwsAvailabilityZonesTimeouts")]
    public interface IDataAwsAvailabilityZonesTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zones#read DataAwsAvailabilityZones#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsAvailabilityZonesTimeouts), fullyQualifiedName: "aws.dataAwsAvailabilityZones.DataAwsAvailabilityZonesTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsAvailabilityZones.IDataAwsAvailabilityZonesTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zones#read DataAwsAvailabilityZones#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
