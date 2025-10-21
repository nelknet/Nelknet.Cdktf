using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ChimesdkvoiceSipMediaApplication
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.chimesdkvoiceSipMediaApplication.ChimesdkvoiceSipMediaApplicationEndpoints")]
    public class ChimesdkvoiceSipMediaApplicationEndpoints : aws.ChimesdkvoiceSipMediaApplication.IChimesdkvoiceSipMediaApplicationEndpoints
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/chimesdkvoice_sip_media_application#lambda_arn ChimesdkvoiceSipMediaApplication#lambda_arn}.</summary>
        [JsiiProperty(name: "lambdaArn", typeJson: "{\"primitive\":\"string\"}")]
        public string LambdaArn
        {
            get;
            set;
        }
    }
}
