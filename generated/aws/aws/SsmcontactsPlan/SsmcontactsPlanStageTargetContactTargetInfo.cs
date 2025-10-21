using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SsmcontactsPlan
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.ssmcontactsPlan.SsmcontactsPlanStageTargetContactTargetInfo")]
    public class SsmcontactsPlanStageTargetContactTargetInfo : aws.SsmcontactsPlan.ISsmcontactsPlanStageTargetContactTargetInfo
    {
        private object _isEssential;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#is_essential SsmcontactsPlan#is_essential}.</summary>
        [JsiiProperty(name: "isEssential", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object IsEssential
        {
            get => _isEssential;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _isEssential = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssmcontacts_plan#contact_id SsmcontactsPlan#contact_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "contactId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContactId
        {
            get;
            set;
        }
    }
}
