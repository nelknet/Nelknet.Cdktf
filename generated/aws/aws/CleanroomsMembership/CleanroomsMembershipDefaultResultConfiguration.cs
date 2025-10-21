using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CleanroomsMembership
{
    [JsiiByValue(fqn: "aws.cleanroomsMembership.CleanroomsMembershipDefaultResultConfiguration")]
    public class CleanroomsMembershipDefaultResultConfiguration : aws.CleanroomsMembership.ICleanroomsMembershipDefaultResultConfiguration
    {
        private object? _outputConfiguration;

        /// <summary>output_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#output_configuration CleanroomsMembership#output_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "outputConfiguration", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cleanroomsMembership.CleanroomsMembershipDefaultResultConfigurationOutputConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? OutputConfiguration
        {
            get => _outputConfiguration;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CleanroomsMembership.ICleanroomsMembershipDefaultResultConfigurationOutputConfiguration[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CleanroomsMembership.ICleanroomsMembershipDefaultResultConfigurationOutputConfiguration).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _outputConfiguration = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#role_arn CleanroomsMembership#role_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? RoleArn
        {
            get;
            set;
        }
    }
}
