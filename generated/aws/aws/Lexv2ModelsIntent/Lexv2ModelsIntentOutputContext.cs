using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lexv2ModelsIntent
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lexv2ModelsIntent.Lexv2ModelsIntentOutputContext")]
    public class Lexv2ModelsIntentOutputContext : aws.Lexv2ModelsIntent.ILexv2ModelsIntentOutputContext
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#name Lexv2ModelsIntent#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#time_to_live_in_seconds Lexv2ModelsIntent#time_to_live_in_seconds}.</summary>
        [JsiiProperty(name: "timeToLiveInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public double TimeToLiveInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lexv2models_intent#turns_to_live Lexv2ModelsIntent#turns_to_live}.</summary>
        [JsiiProperty(name: "turnsToLive", typeJson: "{\"primitive\":\"number\"}")]
        public double TurnsToLive
        {
            get;
            set;
        }
    }
}
