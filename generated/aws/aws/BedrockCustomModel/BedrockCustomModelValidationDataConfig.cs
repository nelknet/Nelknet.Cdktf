using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.BedrockCustomModel
{
    [JsiiByValue(fqn: "aws.bedrockCustomModel.BedrockCustomModelValidationDataConfig")]
    public class BedrockCustomModelValidationDataConfig : aws.BedrockCustomModel.IBedrockCustomModelValidationDataConfig
    {
        private object? _validator;

        /// <summary>validator block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/bedrock_custom_model#validator BedrockCustomModel#validator}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validator", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.bedrockCustomModel.BedrockCustomModelValidationDataConfigValidator\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Validator
        {
            get => _validator;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.BedrockCustomModel.IBedrockCustomModelValidationDataConfigValidator[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.BedrockCustomModel.IBedrockCustomModelValidationDataConfigValidator).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _validator = value;
            }
        }
    }
}
