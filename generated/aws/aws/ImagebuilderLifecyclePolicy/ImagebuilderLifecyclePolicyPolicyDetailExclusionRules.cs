using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderLifecyclePolicy
{
    [JsiiByValue(fqn: "aws.imagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyPolicyDetailExclusionRules")]
    public class ImagebuilderLifecyclePolicyPolicyDetailExclusionRules : aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyPolicyDetailExclusionRules
    {
        private object? _amis;

        /// <summary>amis block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#amis ImagebuilderLifecyclePolicy#amis}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "amis", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyPolicyDetailExclusionRulesAmis\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Amis
        {
            get => _amis;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyPolicyDetailExclusionRulesAmis[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyPolicyDetailExclusionRulesAmis).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _amis = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#tag_map ImagebuilderLifecyclePolicy#tag_map}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagMap", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TagMap
        {
            get;
            set;
        }
    }
}
