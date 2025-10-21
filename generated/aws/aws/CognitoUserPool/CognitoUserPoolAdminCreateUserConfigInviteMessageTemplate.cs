using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate")]
    public class CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate : aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_message CognitoUserPool#email_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailMessage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_subject CognitoUserPool#email_subject}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailSubject
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sms_message CognitoUserPool#sms_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "smsMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SmsMessage
        {
            get;
            set;
        }
    }
}
