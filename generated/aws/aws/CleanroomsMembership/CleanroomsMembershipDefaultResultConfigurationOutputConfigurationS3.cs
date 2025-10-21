using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CleanroomsMembership
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cleanroomsMembership.CleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3")]
    public class CleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3 : aws.CleanroomsMembership.ICleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#bucket CleanroomsMembership#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        public string Bucket
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#result_format CleanroomsMembership#result_format}.</summary>
        [JsiiProperty(name: "resultFormat", typeJson: "{\"primitive\":\"string\"}")]
        public string ResultFormat
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#key_prefix CleanroomsMembership#key_prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "keyPrefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? KeyPrefix
        {
            get;
            set;
        }
    }
}
