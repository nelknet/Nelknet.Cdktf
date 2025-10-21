using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CleanroomsMembership
{
    [JsiiByValue(fqn: "aws.cleanroomsMembership.CleanroomsMembershipDefaultResultConfigurationOutputConfiguration")]
    public class CleanroomsMembershipDefaultResultConfigurationOutputConfiguration : aws.CleanroomsMembership.ICleanroomsMembershipDefaultResultConfigurationOutputConfiguration
    {
        private object? _s3;

        /// <summary>s3 block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#s3 CleanroomsMembership#s3}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cleanroomsMembership.CleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? S3
        {
            get => _s3;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CleanroomsMembership.ICleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CleanroomsMembership.ICleanroomsMembershipDefaultResultConfigurationOutputConfigurationS3).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _s3 = value;
            }
        }
    }
}
