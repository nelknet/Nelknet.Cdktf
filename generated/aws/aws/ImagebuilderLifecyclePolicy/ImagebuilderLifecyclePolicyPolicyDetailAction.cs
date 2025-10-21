using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ImagebuilderLifecyclePolicy
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.imagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyPolicyDetailAction")]
    public class ImagebuilderLifecyclePolicyPolicyDetailAction : aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyPolicyDetailAction
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#type ImagebuilderLifecyclePolicy#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        private object? _includeResources;

        /// <summary>include_resources block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/imagebuilder_lifecycle_policy#include_resources ImagebuilderLifecyclePolicy#include_resources}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "includeResources", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.imagebuilderLifecyclePolicy.ImagebuilderLifecyclePolicyPolicyDetailActionIncludeResources\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? IncludeResources
        {
            get => _includeResources;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyPolicyDetailActionIncludeResources[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ImagebuilderLifecyclePolicy.IImagebuilderLifecyclePolicyPolicyDetailActionIncludeResources).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _includeResources = value;
            }
        }
    }
}
