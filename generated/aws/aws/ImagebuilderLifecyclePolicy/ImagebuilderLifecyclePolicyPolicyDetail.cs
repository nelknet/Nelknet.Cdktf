using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderLifecyclePolicy
{
    [JsiiByValue(fqn: "aws.imagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyPolicyDetail")]
    public class ImagebuilderLifecyclePolicyPolicyDetail : aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyPolicyDetail
    {
        private object? _action;

        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#action ImagebuilderLifecyclePolicy#action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyPolicyDetailAction\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Action
        {
            get => _action;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyPolicyDetailAction[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyPolicyDetailAction).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _action = value;
            }
        }

        private object? _exclusionRules;

        /// <summary>exclusion_rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#exclusion_rules ImagebuilderLifecyclePolicy#exclusion_rules}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "exclusionRules", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyPolicyDetailExclusionRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? ExclusionRules
        {
            get => _exclusionRules;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyPolicyDetailExclusionRules[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyPolicyDetailExclusionRules).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _exclusionRules = value;
            }
        }

        private object? _filter;

        /// <summary>filter block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#filter ImagebuilderLifecyclePolicy#filter}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filter", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyPolicyDetailFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Filter
        {
            get => _filter;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyPolicyDetailFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyPolicyDetailFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _filter = value;
            }
        }
    }
}
