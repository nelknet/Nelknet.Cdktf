using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolSmsConfiguration")]
    public class CognitoUserPoolSmsConfiguration : aws.CognitoUserPool.ICognitoUserPoolSmsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#external_id CognitoUserPool#external_id}.</summary>
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}")]
        public string ExternalId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sns_caller_arn CognitoUserPool#sns_caller_arn}.</summary>
        [JsiiProperty(name: "snsCallerArn", typeJson: "{\"primitive\":\"string\"}")]
        public string SnsCallerArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sns_region CognitoUserPool#sns_region}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "snsRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SnsRegion
        {
            get;
            set;
        }
    }
}
