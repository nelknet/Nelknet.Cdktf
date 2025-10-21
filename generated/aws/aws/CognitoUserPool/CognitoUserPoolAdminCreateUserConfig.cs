using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfig")]
    public class CognitoUserPoolAdminCreateUserConfig : aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfig
    {
        private object? _allowAdminCreateUserOnly;

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#allow_admin_create_user_only CognitoUserPool#allow_admin_create_user_only}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowAdminCreateUserOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public object? AllowAdminCreateUserOnly
        {
            get => _allowAdminCreateUserOnly;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _allowAdminCreateUserOnly = value;
            }
        }

        /// <summary>invite_message_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#invite_message_template CognitoUserPool#invite_message_template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "inviteMessageTemplate", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate? InviteMessageTemplate
        {
            get;
            set;
        }
    }
}
