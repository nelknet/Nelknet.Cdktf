using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolAccountRecoverySettingRecoveryMechanism")]
    public class CognitoUserPoolAccountRecoverySettingRecoveryMechanism : aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySettingRecoveryMechanism
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#name CognitoUserPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#priority CognitoUserPool#priority}.</summary>
        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public double Priority
        {
            get;
            set;
        }
    }
}
