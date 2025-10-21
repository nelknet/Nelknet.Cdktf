using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmcontactsPlan.SsmcontactsPlanStage")]
    public class SsmcontactsPlanStage : aws.SsmcontactsPlan.ISsmcontactsPlanStage
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#duration_in_minutes SsmcontactsPlan#duration_in_minutes}.</summary>
        [JsiiProperty(name: "durationInMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public double DurationInMinutes
        {
            get;
            set;
        }

        private object? _target;

        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#target SsmcontactsPlan#target}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ssmcontactsPlan.SsmcontactsPlanStageTarget\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Target
        {
            get => _target;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.SsmcontactsPlan.ISsmcontactsPlanStageTarget[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SsmcontactsPlan.ISsmcontactsPlanStageTarget).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _target = value;
            }
        }
    }
}
