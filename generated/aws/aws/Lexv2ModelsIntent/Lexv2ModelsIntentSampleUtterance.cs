using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentSampleUtterance")]
    public class Lexv2ModelsIntentSampleUtterance : aws.Lexv2ModelsIntent.ILexv2ModelsIntentSampleUtterance
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#utterance Lexv2ModelsIntent#utterance}.</summary>
        [JsiiProperty(name: "utterance", typeJson: "{\"primitive\":\"string\"}")]
        public string Utterance
        {
            get;
            set;
        }
    }
}
