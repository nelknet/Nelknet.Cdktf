using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cognitoUserPool.CognitoUserPoolConfig")]
    public class CognitoUserPoolConfig : aws.CognitoUserPool.ICognitoUserPoolConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#name CognitoUserPool#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>account_recovery_setting block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#account_recovery_setting CognitoUserPool#account_recovery_setting}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accountRecoverySetting", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAccountRecoverySetting\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySetting? AccountRecoverySetting
        {
            get;
            set;
        }

        /// <summary>admin_create_user_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#admin_create_user_config CognitoUserPool#admin_create_user_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "adminCreateUserConfig", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfig\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfig? AdminCreateUserConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#alias_attributes CognitoUserPool#alias_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "aliasAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AliasAttributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#auto_verified_attributes CognitoUserPool#auto_verified_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "autoVerifiedAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? AutoVerifiedAttributes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#deletion_protection CognitoUserPool#deletion_protection}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deletionProtection", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeletionProtection
        {
            get;
            set;
        }

        /// <summary>device_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#device_configuration CognitoUserPool#device_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deviceConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolDeviceConfiguration\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolDeviceConfiguration? DeviceConfiguration
        {
            get;
            set;
        }

        /// <summary>email_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_configuration CognitoUserPool#email_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emailConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolEmailConfiguration\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolEmailConfiguration? EmailConfiguration
        {
            get;
            set;
        }

        /// <summary>email_mfa_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_mfa_configuration CognitoUserPool#email_mfa_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "emailMfaConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolEmailMfaConfiguration\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolEmailMfaConfiguration? EmailMfaConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_verification_message CognitoUserPool#email_verification_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailVerificationMessage
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#email_verification_subject CognitoUserPool#email_verification_subject}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "emailVerificationSubject", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? EmailVerificationSubject
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>lambda_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#lambda_config CognitoUserPool#lambda_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolLambdaConfig\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolLambdaConfig? LambdaConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#mfa_configuration CognitoUserPool#mfa_configuration}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "mfaConfiguration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MfaConfiguration
        {
            get;
            set;
        }

        /// <summary>password_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#password_policy CognitoUserPool#password_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "passwordPolicy", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolPasswordPolicy\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolPasswordPolicy? PasswordPolicy
        {
            get;
            set;
        }

        private object? _schema;

        /// <summary>schema block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#schema CognitoUserPool#schema}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schema", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public object? Schema
        {
            get => _schema;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case aws.CognitoUserPool.ICognitoUserPoolSchema[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CognitoUserPool.ICognitoUserPoolSchema).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _schema = value;
            }
        }

        /// <summary>sign_in_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sign_in_policy CognitoUserPool#sign_in_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "signInPolicy", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSignInPolicy\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolSignInPolicy? SignInPolicy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sms_authentication_message CognitoUserPool#sms_authentication_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "smsAuthenticationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SmsAuthenticationMessage
        {
            get;
            set;
        }

        /// <summary>sms_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sms_configuration CognitoUserPool#sms_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "smsConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSmsConfiguration\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolSmsConfiguration? SmsConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#sms_verification_message CognitoUserPool#sms_verification_message}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "smsVerificationMessage", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SmsVerificationMessage
        {
            get;
            set;
        }

        /// <summary>software_token_mfa_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#software_token_mfa_configuration CognitoUserPool#software_token_mfa_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "softwareTokenMfaConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSoftwareTokenMfaConfiguration\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolSoftwareTokenMfaConfiguration? SoftwareTokenMfaConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#tags CognitoUserPool#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Tags
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#tags_all CognitoUserPool#tags_all}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? TagsAll
        {
            get;
            set;
        }

        /// <summary>user_attribute_update_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_attribute_update_settings CognitoUserPool#user_attribute_update_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userAttributeUpdateSettings", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserAttributeUpdateSettings\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolUserAttributeUpdateSettings? UserAttributeUpdateSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#username_attributes CognitoUserPool#username_attributes}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "usernameAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? UsernameAttributes
        {
            get;
            set;
        }

        /// <summary>username_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#username_configuration CognitoUserPool#username_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "usernameConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUsernameConfiguration\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolUsernameConfiguration? UsernameConfiguration
        {
            get;
            set;
        }

        /// <summary>user_pool_add_ons block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_pool_add_ons CognitoUserPool#user_pool_add_ons}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userPoolAddOns", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserPoolAddOns\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOns? UserPoolAddOns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#user_pool_tier CognitoUserPool#user_pool_tier}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userPoolTier", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? UserPoolTier
        {
            get;
            set;
        }

        /// <summary>verification_message_template block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#verification_message_template CognitoUserPool#verification_message_template}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verificationMessageTemplate", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolVerificationMessageTemplate\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolVerificationMessageTemplate? VerificationMessageTemplate
        {
            get;
            set;
        }

        /// <summary>web_authn_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#web_authn_configuration CognitoUserPool#web_authn_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "webAuthnConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolWebAuthnConfiguration\"}", isOptional: true)]
        public aws.CognitoUserPool.ICognitoUserPoolWebAuthnConfiguration? WebAuthnConfiguration
        {
            get;
            set;
        }

        private object? _connection;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "connection", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.SSHProvisionerConnection\"},{\"fqn\":\"cdktf.WinrmProvisionerConnection\"}]}}", isOptional: true)]
        public object? Connection
        {
            get => _connection;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.ISSHProvisionerConnection cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IWinrmProvisionerConnection cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.ISSHProvisionerConnection).FullName}, {typeof(HashiCorp.Cdktf.IWinrmProvisionerConnection).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _connection = value;
            }
        }

        private object? _count;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.TerraformCount\"}]}}", isOptional: true)]
        public object? Count
        {
            get => _count;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case double cast_cd4240:
                            break;
                        case byte cast_cd4240:
                            break;
                        case decimal cast_cd4240:
                            break;
                        case float cast_cd4240:
                            break;
                        case int cast_cd4240:
                            break;
                        case long cast_cd4240:
                            break;
                        case sbyte cast_cd4240:
                            break;
                        case short cast_cd4240:
                            break;
                        case uint cast_cd4240:
                            break;
                        case ulong cast_cd4240:
                            break;
                        case ushort cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.TerraformCount cast_cd4240:
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: double, {typeof(HashiCorp.Cdktf.TerraformCount).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _count = value;
            }
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forEach", typeJson: "{\"fqn\":\"cdktf.ITerraformIterator\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformIterator? ForEach
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }

        private object[]? _provisioners;

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provisioners", typeJson: "{\"collection\":{\"elementtype\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.FileProvisioner\"},{\"fqn\":\"cdktf.LocalExecProvisioner\"},{\"fqn\":\"cdktf.RemoteExecProvisioner\"}]}},\"kind\":\"array\"}}", isOptional: true)]
        public object[]? Provisioners
        {
            get => _provisioners;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    for (var __idx_cd4240 = 0 ; __idx_cd4240 < value.Length ; __idx_cd4240++)
                    {
                        switch (value[__idx_cd4240])
                        {
                            case HashiCorp.Cdktf.IFileProvisioner cast_e9c63e:
                                break;
                            case HashiCorp.Cdktf.ILocalExecProvisioner cast_e9c63e:
                                break;
                            case HashiCorp.Cdktf.IRemoteExecProvisioner cast_e9c63e:
                                break;
                            case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_e9c63e:
                                // Not enough information to type-check...
                                break;
                            case null:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(HashiCorp.Cdktf.IFileProvisioner).FullName}, {typeof(HashiCorp.Cdktf.ILocalExecProvisioner).FullName}, {typeof(HashiCorp.Cdktf.IRemoteExecProvisioner).FullName}; received null", nameof(value));
                            default:
                                throw new System.ArgumentException($"Expected {nameof(value)}[{__idx_cd4240}] to be one of: {typeof(HashiCorp.Cdktf.IFileProvisioner).FullName}, {typeof(HashiCorp.Cdktf.ILocalExecProvisioner).FullName}, {typeof(HashiCorp.Cdktf.IRemoteExecProvisioner).FullName}; received {value[__idx_cd4240].GetType().FullName}", nameof(value));
                        }
                    }
                }
                _provisioners = value;
            }
        }
    }
}
