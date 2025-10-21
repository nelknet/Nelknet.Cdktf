using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CleanroomsMembership
{
    [JsiiByValue(fqn: "aws.cleanroomsMembership.CleanroomsMembershipPaymentConfiguration")]
    public class CleanroomsMembershipPaymentConfiguration : aws.CleanroomsMembership.ICleanroomsMembershipPaymentConfiguration
    {
        private object? _queryCompute;

        /// <summary>query_compute block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cleanrooms_membership#query_compute CleanroomsMembership#query_compute}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryCompute", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cleanroomsMembership.CleanroomsMembershipPaymentConfigurationQueryCompute\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? QueryCompute
        {
            get => _queryCompute;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CleanroomsMembership.ICleanroomsMembershipPaymentConfigurationQueryCompute[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CleanroomsMembership.ICleanroomsMembershipPaymentConfigurationQueryCompute).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _queryCompute = value;
            }
        }
    }
}
