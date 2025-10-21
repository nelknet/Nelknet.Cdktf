using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentConfirmationSettingPromptSpecificationMessageGroupVariationImageResponseCardButton")]
    public class Lexv2ModelsIntentConfirmationSettingPromptSpecificationMessageGroupVariationImageResponseCardButton : aws.Lexv2ModelsIntent.ILexv2ModelsIntentConfirmationSettingPromptSpecificationMessageGroupVariationImageResponseCardButton
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#text Lexv2ModelsIntent#text}.</summary>
        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
        public string Text
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#value Lexv2ModelsIntent#value}.</summary>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
