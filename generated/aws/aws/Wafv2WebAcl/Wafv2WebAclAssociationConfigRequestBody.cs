using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiByValue(fqn: "aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBody")]
    public class Wafv2WebAclAssociationConfigRequestBody : aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBody
    {
        /// <summary>api_gateway block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#api_gateway Wafv2WebAcl#api_gateway}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiGateway", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyApiGateway\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyApiGateway? ApiGateway
        {
            get;
            set;
        }

        /// <summary>app_runner_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#app_runner_service Wafv2WebAcl#app_runner_service}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "appRunnerService", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyAppRunnerService\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyAppRunnerService? AppRunnerService
        {
            get;
            set;
        }

        /// <summary>cloudfront block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#cloudfront Wafv2WebAcl#cloudfront}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cloudfront", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCloudfront\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCloudfront? Cloudfront
        {
            get;
            set;
        }

        /// <summary>cognito_user_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#cognito_user_pool Wafv2WebAcl#cognito_user_pool}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cognitoUserPool", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCognitoUserPool\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCognitoUserPool? CognitoUserPool
        {
            get;
            set;
        }

        /// <summary>verified_access_instance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#verified_access_instance Wafv2WebAcl#verified_access_instance}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verifiedAccessInstance", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance\"}", isOptional: true)]
        public aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance? VerifiedAccessInstance
        {
            get;
            set;
        }
    }
}
