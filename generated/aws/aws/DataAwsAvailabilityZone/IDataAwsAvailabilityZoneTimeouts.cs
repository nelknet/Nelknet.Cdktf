using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAvailabilityZone
{
    [JsiiInterface(nativeType: typeof(IDataAwsAvailabilityZoneTimeouts), fullyQualifiedName: "aws.dataAwsAvailabilityZone.DataAwsAvailabilityZoneTimeouts")]
    public interface IDataAwsAvailabilityZoneTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zone#read DataAwsAvailabilityZone#read}.</summary>
        [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Read
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IDataAwsAvailabilityZoneTimeouts), fullyQualifiedName: "aws.dataAwsAvailabilityZone.DataAwsAvailabilityZoneTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.DataAwsAvailabilityZone.IDataAwsAvailabilityZoneTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/availability_zone#read DataAwsAvailabilityZone#read}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "read", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Read
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
