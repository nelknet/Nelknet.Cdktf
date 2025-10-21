using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2WebAcl
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclAssociationConfigRequestBody), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBody")]
    public interface IWafv2WebAclAssociationConfigRequestBody
    {
        /// <summary>api_gateway block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#api_gateway Wafv2WebAcl#api_gateway}
        /// </remarks>
        [JsiiProperty(name: "apiGateway", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyApiGateway\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyApiGateway? ApiGateway
        {
            get
            {
                return null;
            }
        }

        /// <summary>app_runner_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#app_runner_service Wafv2WebAcl#app_runner_service}
        /// </remarks>
        [JsiiProperty(name: "appRunnerService", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyAppRunnerService\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyAppRunnerService? AppRunnerService
        {
            get
            {
                return null;
            }
        }

        /// <summary>cloudfront block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#cloudfront Wafv2WebAcl#cloudfront}
        /// </remarks>
        [JsiiProperty(name: "cloudfront", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCloudfront\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCloudfront? Cloudfront
        {
            get
            {
                return null;
            }
        }

        /// <summary>cognito_user_pool block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#cognito_user_pool Wafv2WebAcl#cognito_user_pool}
        /// </remarks>
        [JsiiProperty(name: "cognitoUserPool", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCognitoUserPool\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCognitoUserPool? CognitoUserPool
        {
            get
            {
                return null;
            }
        }

        /// <summary>verified_access_instance block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#verified_access_instance Wafv2WebAcl#verified_access_instance}
        /// </remarks>
        [JsiiProperty(name: "verifiedAccessInstance", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance? VerifiedAccessInstance
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclAssociationConfigRequestBody), fullyQualifiedName: "aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBody")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBody
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>api_gateway block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#api_gateway Wafv2WebAcl#api_gateway}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiGateway", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyApiGateway\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyApiGateway? ApiGateway
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyApiGateway?>();
            }

            /// <summary>app_runner_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#app_runner_service Wafv2WebAcl#app_runner_service}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "appRunnerService", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyAppRunnerService\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyAppRunnerService? AppRunnerService
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyAppRunnerService?>();
            }

            /// <summary>cloudfront block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#cloudfront Wafv2WebAcl#cloudfront}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cloudfront", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCloudfront\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCloudfront? Cloudfront
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCloudfront?>();
            }

            /// <summary>cognito_user_pool block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#cognito_user_pool Wafv2WebAcl#cognito_user_pool}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cognitoUserPool", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyCognitoUserPool\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCognitoUserPool? CognitoUserPool
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyCognitoUserPool?>();
            }

            /// <summary>verified_access_instance block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/wafv2_web_acl#verified_access_instance Wafv2WebAcl#verified_access_instance}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "verifiedAccessInstance", typeJson: "{\"fqn\":\"aws.wafv2WebAcl.Wafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance\"}", isOptional: true)]
            public aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance? VerifiedAccessInstance
            {
                get => GetInstanceProperty<aws.Wafv2WebAcl.IWafv2WebAclAssociationConfigRequestBodyVerifiedAccessInstance?>();
            }
        }
    }
}
