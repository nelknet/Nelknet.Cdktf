using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    [JsiiInterface(nativeType: typeof(ICognitoUserPoolConfig), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolConfig")]
    public interface ICognitoUserPoolConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#name CognitoUserPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>account_recovery_setting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#account_recovery_setting CognitoUserPool#account_recovery_setting}
        /// </remarks>
        [JsiiProperty(name: "accountRecoverySetting", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAccountRecoverySetting\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySetting? AccountRecoverySetting
        {
            get
            {
                return null;
            }
        }

        /// <summary>admin_create_user_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#admin_create_user_config CognitoUserPool#admin_create_user_config}
        /// </remarks>
        [JsiiProperty(name: "adminCreateUserConfig", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfig? AdminCreateUserConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#alias_attributes CognitoUserPool#alias_attributes}.</summary>
        [JsiiProperty(name: "aliasAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AliasAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#auto_verified_attributes CognitoUserPool#auto_verified_attributes}.</summary>
        [JsiiProperty(name: "autoVerifiedAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AutoVerifiedAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#deletion_protection CognitoUserPool#deletion_protection}.</summary>
        [JsiiProperty(name: "deletionProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeletionProtection
        {
            get
            {
                return null;
            }
        }

        /// <summary>device_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#device_configuration CognitoUserPool#device_configuration}
        /// </remarks>
        [JsiiProperty(name: "deviceConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolDeviceConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolDeviceConfiguration? DeviceConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>email_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_configuration CognitoUserPool#email_configuration}
        /// </remarks>
        [JsiiProperty(name: "emailConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolEmailConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolEmailConfiguration? EmailConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>email_mfa_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_mfa_configuration CognitoUserPool#email_mfa_configuration}
        /// </remarks>
        [JsiiProperty(name: "emailMfaConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolEmailMfaConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolEmailMfaConfiguration? EmailMfaConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_verification_message CognitoUserPool#email_verification_message}.</summary>
        [JsiiProperty(name: "emailVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailVerificationMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_verification_subject CognitoUserPool#email_verification_subject}.</summary>
        [JsiiProperty(name: "emailVerificationSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? EmailVerificationSubject
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#id CognitoUserPool#id}.</summary>
        /// <remarks>
        /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
        /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Id
        {
            get
            {
                return null;
            }
        }

        /// <summary>lambda_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#lambda_config CognitoUserPool#lambda_config}
        /// </remarks>
        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolLambdaConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolLambdaConfig? LambdaConfig
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#mfa_configuration CognitoUserPool#mfa_configuration}.</summary>
        [JsiiProperty(name: "mfaConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MfaConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>password_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#password_policy CognitoUserPool#password_policy}
        /// </remarks>
        [JsiiProperty(name: "passwordPolicy", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolPasswordPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolPasswordPolicy? PasswordPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#schema CognitoUserPool#schema}
        /// </remarks>
        [JsiiProperty(name: "schema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Schema
        {
            get
            {
                return null;
            }
        }

        /// <summary>sign_in_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sign_in_policy CognitoUserPool#sign_in_policy}
        /// </remarks>
        [JsiiProperty(name: "signInPolicy", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSignInPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolSignInPolicy? SignInPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sms_authentication_message CognitoUserPool#sms_authentication_message}.</summary>
        [JsiiProperty(name: "smsAuthenticationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SmsAuthenticationMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>sms_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sms_configuration CognitoUserPool#sms_configuration}
        /// </remarks>
        [JsiiProperty(name: "smsConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSmsConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolSmsConfiguration? SmsConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sms_verification_message CognitoUserPool#sms_verification_message}.</summary>
        [JsiiProperty(name: "smsVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SmsVerificationMessage
        {
            get
            {
                return null;
            }
        }

        /// <summary>software_token_mfa_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#software_token_mfa_configuration CognitoUserPool#software_token_mfa_configuration}
        /// </remarks>
        [JsiiProperty(name: "softwareTokenMfaConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSoftwareTokenMfaConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolSoftwareTokenMfaConfiguration? SoftwareTokenMfaConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#tags CognitoUserPool#tags}.</summary>
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#tags_all CognitoUserPool#tags_all}.</summary>
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_attribute_update_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_attribute_update_settings CognitoUserPool#user_attribute_update_settings}
        /// </remarks>
        [JsiiProperty(name: "userAttributeUpdateSettings", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserAttributeUpdateSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolUserAttributeUpdateSettings? UserAttributeUpdateSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#username_attributes CognitoUserPool#username_attributes}.</summary>
        [JsiiProperty(name: "usernameAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? UsernameAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>username_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#username_configuration CognitoUserPool#username_configuration}
        /// </remarks>
        [JsiiProperty(name: "usernameConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUsernameConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolUsernameConfiguration? UsernameConfiguration
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_pool_add_ons block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_pool_add_ons CognitoUserPool#user_pool_add_ons}
        /// </remarks>
        [JsiiProperty(name: "userPoolAddOns", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserPoolAddOns\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOns? UserPoolAddOns
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_pool_tier CognitoUserPool#user_pool_tier}.</summary>
        [JsiiProperty(name: "userPoolTier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? UserPoolTier
        {
            get
            {
                return null;
            }
        }

        /// <summary>verification_message_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#verification_message_template CognitoUserPool#verification_message_template}
        /// </remarks>
        [JsiiProperty(name: "verificationMessageTemplate", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolVerificationMessageTemplate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolVerificationMessageTemplate? VerificationMessageTemplate
        {
            get
            {
                return null;
            }
        }

        /// <summary>web_authn_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#web_authn_configuration CognitoUserPool#web_authn_configuration}
        /// </remarks>
        [JsiiProperty(name: "webAuthnConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolWebAuthnConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.CognitoUserPool.ICognitoUserPoolWebAuthnConfiguration? WebAuthnConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoUserPoolConfig), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPoolConfig")]
        internal sealed class _Proxy : DeputyBase, aws.CognitoUserPool.ICognitoUserPoolConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#name CognitoUserPool#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>account_recovery_setting block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#account_recovery_setting CognitoUserPool#account_recovery_setting}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accountRecoverySetting", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAccountRecoverySetting\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySetting? AccountRecoverySetting
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySetting?>();
            }

            /// <summary>admin_create_user_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#admin_create_user_config CognitoUserPool#admin_create_user_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "adminCreateUserConfig", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfig\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfig? AdminCreateUserConfig
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#alias_attributes CognitoUserPool#alias_attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "aliasAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AliasAttributes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#auto_verified_attributes CognitoUserPool#auto_verified_attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "autoVerifiedAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AutoVerifiedAttributes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#deletion_protection CognitoUserPool#deletion_protection}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "deletionProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeletionProtection
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>device_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#device_configuration CognitoUserPool#device_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deviceConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolDeviceConfiguration\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolDeviceConfiguration? DeviceConfiguration
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolDeviceConfiguration?>();
            }

            /// <summary>email_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_configuration CognitoUserPool#email_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emailConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolEmailConfiguration\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolEmailConfiguration? EmailConfiguration
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolEmailConfiguration?>();
            }

            /// <summary>email_mfa_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_mfa_configuration CognitoUserPool#email_mfa_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emailMfaConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolEmailMfaConfiguration\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolEmailMfaConfiguration? EmailMfaConfiguration
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolEmailMfaConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_verification_message CognitoUserPool#email_verification_message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailVerificationMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_verification_subject CognitoUserPool#email_verification_subject}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "emailVerificationSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? EmailVerificationSubject
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#id CognitoUserPool#id}.</summary>
            /// <remarks>
            /// Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2.
            /// If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Id
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>lambda_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#lambda_config CognitoUserPool#lambda_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolLambdaConfig\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolLambdaConfig? LambdaConfig
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolLambdaConfig?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#mfa_configuration CognitoUserPool#mfa_configuration}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mfaConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MfaConfiguration
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>password_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#password_policy CognitoUserPool#password_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "passwordPolicy", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolPasswordPolicy\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolPasswordPolicy? PasswordPolicy
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolPasswordPolicy?>();
            }

            /// <summary>schema block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#schema CognitoUserPool#schema}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "schema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
            public object? Schema
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>sign_in_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sign_in_policy CognitoUserPool#sign_in_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "signInPolicy", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSignInPolicy\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolSignInPolicy? SignInPolicy
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolSignInPolicy?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sms_authentication_message CognitoUserPool#sms_authentication_message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "smsAuthenticationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SmsAuthenticationMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>sms_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sms_configuration CognitoUserPool#sms_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "smsConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSmsConfiguration\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolSmsConfiguration? SmsConfiguration
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolSmsConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sms_verification_message CognitoUserPool#sms_verification_message}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "smsVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SmsVerificationMessage
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>software_token_mfa_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#software_token_mfa_configuration CognitoUserPool#software_token_mfa_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "softwareTokenMfaConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSoftwareTokenMfaConfiguration\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolSoftwareTokenMfaConfiguration? SoftwareTokenMfaConfiguration
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolSoftwareTokenMfaConfiguration?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#tags CognitoUserPool#tags}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Tags
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#tags_all CognitoUserPool#tags_all}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? TagsAll
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>user_attribute_update_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_attribute_update_settings CognitoUserPool#user_attribute_update_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userAttributeUpdateSettings", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserAttributeUpdateSettings\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolUserAttributeUpdateSettings? UserAttributeUpdateSettings
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolUserAttributeUpdateSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#username_attributes CognitoUserPool#username_attributes}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "usernameAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? UsernameAttributes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>username_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#username_configuration CognitoUserPool#username_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usernameConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUsernameConfiguration\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolUsernameConfiguration? UsernameConfiguration
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolUsernameConfiguration?>();
            }

            /// <summary>user_pool_add_ons block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_pool_add_ons CognitoUserPool#user_pool_add_ons}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userPoolAddOns", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserPoolAddOns\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOns? UserPoolAddOns
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOns?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_pool_tier CognitoUserPool#user_pool_tier}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "userPoolTier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? UserPoolTier
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>verification_message_template block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#verification_message_template CognitoUserPool#verification_message_template}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "verificationMessageTemplate", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolVerificationMessageTemplate\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolVerificationMessageTemplate? VerificationMessageTemplate
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolVerificationMessageTemplate?>();
            }

            /// <summary>web_authn_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#web_authn_configuration CognitoUserPool#web_authn_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "webAuthnConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolWebAuthnConfiguration\"}", isOptional: true)]
            public aws.CognitoUserPool.ICognitoUserPoolWebAuthnConfiguration? WebAuthnConfiguration
            {
                get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolWebAuthnConfiguration?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
            public object? Connection
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformIterator? ForEach
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformIterator?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
            public object[]? Provisioners
            {
                get => GetInstanceProperty<object[]?>();
            }
        }
    }
}
