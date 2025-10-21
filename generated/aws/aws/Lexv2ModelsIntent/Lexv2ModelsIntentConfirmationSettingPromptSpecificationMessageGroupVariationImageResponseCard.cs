using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingPromptSpecificationMessageGroupVariationImageResponseCard")]
    public class Lexv2ModelsIntentConfirmationSettingPromptSpecificationMessageGroupVariationImageResponseCard : aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingPromptSpecificationMessageGroupVariationImageResponseCard
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#title Lexv2ModelsIntent#title}.</summary>
        [JsiiProperty(name: "title", typeJson: "{\"primitive\":\"string\"}")]
        public string Title
        {
            get;
            set;
        }

        private object? _button;

        /// <summary>button block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#button Lexv2ModelsIntent#button}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "button", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingPromptSpecificationMessageGroupVariationImageResponseCardButton\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Button
        {
            get => _button;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingPromptSpecificationMessageGroupVariationImageResponseCardButton[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingPromptSpecificationMessageGroupVariationImageResponseCardButton).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _button = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#image_url Lexv2ModelsIntent#image_url}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "imageUrl", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ImageUrl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#subtitle Lexv2ModelsIntent#subtitle}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "subtitle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Subtitle
        {
            get;
            set;
        }
    }
}
