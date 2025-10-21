using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CleanroomsMembership
{
    [JsiiInterface(nativeType: typeof(ICleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3), fullyQualifiedName: "aws.cleanroomsMembership.CleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3")]
    public interface ICleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#bucket CleanroomsMembership#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#result_format CleanroomsMembership#result_format}.</summary>
        [JsiiProperty(name: "resultFormat", typeJson: "{\"primitive\":\"string\"}")]
        string ResultFormat
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#key_prefix CleanroomsMembership#key_prefix}.</summary>
        [JsiiProperty(name: "keyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KeyPrefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3), fullyQualifiedName: "aws.cleanroomsMembership.CleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3")]
        internal sealed class _Proxy : DeputyBase, aws.CleanroomsMembership.ICleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#bucket CleanroomsMembership#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#result_format CleanroomsMembership#result_format}.</summary>
            [JsiiProperty(name: "resultFormat", typeJson: "{\"primitive\":\"string\"}")]
            public string ResultFormat
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#key_prefix CleanroomsMembership#key_prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "keyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KeyPrefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
