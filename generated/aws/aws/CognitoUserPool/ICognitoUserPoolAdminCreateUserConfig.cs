using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolAdminCreateUserConfig), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfig")]
    public interface ICognitoUserPoolAdminCreateUserConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#allow_admin_create_user_only CognitoUserPool#allow_admin_create_user_only}.</summary>
        [JsiiProperty(name: "allowAdminCreateUserOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AllowAdminCreateUserOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>invite_message_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#invite_message_template CognitoUserPool#invite_message_template}
        /// </remarks>
        [JsiiProperty(name: "inviteMessageTemplate", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate? InviteMessageTemplate
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolAdminCreateUserConfig), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#allow_admin_create_user_only CognitoUserPool#allow_admin_create_user_only}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowAdminCreateUserOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AllowAdminCreateUserOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>invite_message_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#invite_message_template CognitoUserPool#invite_message_template}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inviteMessageTemplate", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate? InviteMessageTemplate
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate?>();
            }
        }
    }
}
