using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.CognitoUserPool
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool aws_cognito_user_pool}.</summary>
    [JsiiClass(nativeType: typeof(aws.CognitoUserPool.CognitoUserPool), fullyQualifiedName: "aws.cognitoUserPool.CognitoUserPool", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolConfig\"}}]")]
    public class CognitoUserPool : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool aws_cognito_user_pool} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CognitoUserPool(Constructs.Construct scope, string id, aws.CognitoUserPool.ICognitoUserPoolConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, aws.CognitoUserPool.ICognitoUserPoolConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPool(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPool(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTF code for importing a CognitoUserPool resource upon running "cdktf plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the CognitoUserPool to import.</param>
        /// <param name="importFromId">The id of the existing CognitoUserPool that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the CognitoUserPool to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktf.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the CognitoUserPool to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cognito_user_pool#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing CognitoUserPool that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the CognitoUserPool to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktf.TerraformProvider\"}}]")]
        public static HashiCorp.Cdktf.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, HashiCorp.Cdktf.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<HashiCorp.Cdktf.ImportableResource>(typeof(aws.CognitoUserPool.CognitoUserPool), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(HashiCorp.Cdktf.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putAccountRecoverySetting", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAccountRecoverySetting\"}}]")]
        public virtual void PutAccountRecoverySetting(aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySetting @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySetting)}, new object[]{@value});
        }

        [JsiiMethod(name: "putAdminCreateUserConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfig\"}}]")]
        public virtual void PutAdminCreateUserConfig(aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDeviceConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolDeviceConfiguration\"}}]")]
        public virtual void PutDeviceConfiguration(aws.CognitoUserPool.ICognitoUserPoolDeviceConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolDeviceConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolEmailConfiguration\"}}]")]
        public virtual void PutEmailConfiguration(aws.CognitoUserPool.ICognitoUserPoolEmailConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolEmailConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmailMfaConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolEmailMfaConfiguration\"}}]")]
        public virtual void PutEmailMfaConfiguration(aws.CognitoUserPool.ICognitoUserPoolEmailMfaConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolEmailMfaConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLambdaConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolLambdaConfig\"}}]")]
        public virtual void PutLambdaConfig(aws.CognitoUserPool.ICognitoUserPoolLambdaConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolLambdaConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPasswordPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolPasswordPolicy\"}}]")]
        public virtual void PutPasswordPolicy(aws.CognitoUserPool.ICognitoUserPoolPasswordPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolPasswordPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSchema", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchema\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSchema(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.CognitoUserPool.ICognitoUserPoolSchema[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CognitoUserPool.ICognitoUserPoolSchema).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.CognitoUserPool.ICognitoUserPoolSchema).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSignInPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSignInPolicy\"}}]")]
        public virtual void PutSignInPolicy(aws.CognitoUserPool.ICognitoUserPoolSignInPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolSignInPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSmsConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSmsConfiguration\"}}]")]
        public virtual void PutSmsConfiguration(aws.CognitoUserPool.ICognitoUserPoolSmsConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolSmsConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSoftwareTokenMfaConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSoftwareTokenMfaConfiguration\"}}]")]
        public virtual void PutSoftwareTokenMfaConfiguration(aws.CognitoUserPool.ICognitoUserPoolSoftwareTokenMfaConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolSoftwareTokenMfaConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserAttributeUpdateSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserAttributeUpdateSettings\"}}]")]
        public virtual void PutUserAttributeUpdateSettings(aws.CognitoUserPool.ICognitoUserPoolUserAttributeUpdateSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolUserAttributeUpdateSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUsernameConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUsernameConfiguration\"}}]")]
        public virtual void PutUsernameConfiguration(aws.CognitoUserPool.ICognitoUserPoolUsernameConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolUsernameConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putUserPoolAddOns", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserPoolAddOns\"}}]")]
        public virtual void PutUserPoolAddOns(aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOns @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOns)}, new object[]{@value});
        }

        [JsiiMethod(name: "putVerificationMessageTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolVerificationMessageTemplate\"}}]")]
        public virtual void PutVerificationMessageTemplate(aws.CognitoUserPool.ICognitoUserPoolVerificationMessageTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolVerificationMessageTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "putWebAuthnConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolWebAuthnConfiguration\"}}]")]
        public virtual void PutWebAuthnConfiguration(aws.CognitoUserPool.ICognitoUserPoolWebAuthnConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.CognitoUserPool.ICognitoUserPoolWebAuthnConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountRecoverySetting")]
        public virtual void ResetAccountRecoverySetting()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdminCreateUserConfig")]
        public virtual void ResetAdminCreateUserConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAliasAttributes")]
        public virtual void ResetAliasAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAutoVerifiedAttributes")]
        public virtual void ResetAutoVerifiedAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeletionProtection")]
        public virtual void ResetDeletionProtection()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceConfiguration")]
        public virtual void ResetDeviceConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailConfiguration")]
        public virtual void ResetEmailConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailMfaConfiguration")]
        public virtual void ResetEmailMfaConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailVerificationMessage")]
        public virtual void ResetEmailVerificationMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmailVerificationSubject")]
        public virtual void ResetEmailVerificationSubject()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLambdaConfig")]
        public virtual void ResetLambdaConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMfaConfiguration")]
        public virtual void ResetMfaConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPasswordPolicy")]
        public virtual void ResetPasswordPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSchema")]
        public virtual void ResetSchema()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSignInPolicy")]
        public virtual void ResetSignInPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmsAuthenticationMessage")]
        public virtual void ResetSmsAuthenticationMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmsConfiguration")]
        public virtual void ResetSmsConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSmsVerificationMessage")]
        public virtual void ResetSmsVerificationMessage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSoftwareTokenMfaConfiguration")]
        public virtual void ResetSoftwareTokenMfaConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserAttributeUpdateSettings")]
        public virtual void ResetUserAttributeUpdateSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsernameAttributes")]
        public virtual void ResetUsernameAttributes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUsernameConfiguration")]
        public virtual void ResetUsernameConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserPoolAddOns")]
        public virtual void ResetUserPoolAddOns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUserPoolTier")]
        public virtual void ResetUserPoolTier()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVerificationMessageTemplate")]
        public virtual void ResetVerificationMessageTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetWebAuthnConfiguration")]
        public virtual void ResetWebAuthnConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.CognitoUserPool.CognitoUserPool))!;

        [JsiiProperty(name: "accountRecoverySetting", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAccountRecoverySettingOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolAccountRecoverySettingOutputReference AccountRecoverySetting
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolAccountRecoverySettingOutputReference>()!;
        }

        [JsiiProperty(name: "adminCreateUserConfig", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfigOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolAdminCreateUserConfigOutputReference AdminCreateUserConfig
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolAdminCreateUserConfigOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "creationDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreationDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "deviceConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolDeviceConfigurationOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolDeviceConfigurationOutputReference DeviceConfiguration
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolDeviceConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "domain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Domain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "emailConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolEmailConfigurationOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolEmailConfigurationOutputReference EmailConfiguration
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolEmailConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "emailMfaConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolEmailMfaConfigurationOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolEmailMfaConfigurationOutputReference EmailMfaConfiguration
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolEmailMfaConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "endpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Endpoint
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "estimatedNumberOfUsers", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double EstimatedNumberOfUsers
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "lambdaConfig", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolLambdaConfigOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolLambdaConfigOutputReference LambdaConfig
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolLambdaConfigOutputReference>()!;
        }

        [JsiiProperty(name: "lastModifiedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastModifiedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "passwordPolicy", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolPasswordPolicyOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolPasswordPolicyOutputReference PasswordPolicy
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolPasswordPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchemaList\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolSchemaList Schema
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolSchemaList>()!;
        }

        [JsiiProperty(name: "signInPolicy", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSignInPolicyOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolSignInPolicyOutputReference SignInPolicy
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolSignInPolicyOutputReference>()!;
        }

        [JsiiProperty(name: "smsConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSmsConfigurationOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolSmsConfigurationOutputReference SmsConfiguration
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolSmsConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "softwareTokenMfaConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSoftwareTokenMfaConfigurationOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolSoftwareTokenMfaConfigurationOutputReference SoftwareTokenMfaConfiguration
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolSoftwareTokenMfaConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "userAttributeUpdateSettings", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserAttributeUpdateSettingsOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolUserAttributeUpdateSettingsOutputReference UserAttributeUpdateSettings
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolUserAttributeUpdateSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "usernameConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUsernameConfigurationOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolUsernameConfigurationOutputReference UsernameConfiguration
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolUsernameConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "userPoolAddOns", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserPoolAddOnsOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolUserPoolAddOnsOutputReference UserPoolAddOns
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolUserPoolAddOnsOutputReference>()!;
        }

        [JsiiProperty(name: "verificationMessageTemplate", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolVerificationMessageTemplateOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolVerificationMessageTemplateOutputReference VerificationMessageTemplate
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolVerificationMessageTemplateOutputReference>()!;
        }

        [JsiiProperty(name: "webAuthnConfiguration", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolWebAuthnConfigurationOutputReference\"}")]
        public virtual aws.CognitoUserPool.CognitoUserPoolWebAuthnConfigurationOutputReference WebAuthnConfiguration
        {
            get => GetInstanceProperty<aws.CognitoUserPool.CognitoUserPoolWebAuthnConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountRecoverySettingInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAccountRecoverySetting\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySetting? AccountRecoverySettingInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolAccountRecoverySetting?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminCreateUserConfigInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolAdminCreateUserConfig\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfig? AdminCreateUserConfigInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolAdminCreateUserConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "aliasAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AliasAttributesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoVerifiedAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AutoVerifiedAttributesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deletionProtectionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeletionProtectionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceConfigurationInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolDeviceConfiguration\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolDeviceConfiguration? DeviceConfigurationInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolDeviceConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailConfigurationInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolEmailConfiguration\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolEmailConfiguration? EmailConfigurationInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolEmailConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailMfaConfigurationInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolEmailMfaConfiguration\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolEmailMfaConfiguration? EmailMfaConfigurationInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolEmailMfaConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailVerificationMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailVerificationMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emailVerificationSubjectInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? EmailVerificationSubjectInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lambdaConfigInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolLambdaConfig\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolLambdaConfig? LambdaConfigInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolLambdaConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mfaConfigurationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MfaConfigurationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "passwordPolicyInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolPasswordPolicy\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolPasswordPolicy? PasswordPolicyInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolPasswordPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "schemaInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSchema\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SchemaInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signInPolicyInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSignInPolicy\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolSignInPolicy? SignInPolicyInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolSignInPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsAuthenticationMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SmsAuthenticationMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsConfigurationInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSmsConfiguration\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolSmsConfiguration? SmsConfigurationInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolSmsConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "smsVerificationMessageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SmsVerificationMessageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softwareTokenMfaConfigurationInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolSoftwareTokenMfaConfiguration\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolSoftwareTokenMfaConfiguration? SoftwareTokenMfaConfigurationInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolSoftwareTokenMfaConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsAllInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? TagsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userAttributeUpdateSettingsInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserAttributeUpdateSettings\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolUserAttributeUpdateSettings? UserAttributeUpdateSettingsInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolUserAttributeUpdateSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameAttributesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? UsernameAttributesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "usernameConfigurationInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUsernameConfiguration\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolUsernameConfiguration? UsernameConfigurationInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolUsernameConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPoolAddOnsInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolUserPoolAddOns\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOns? UserPoolAddOnsInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolUserPoolAddOns?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "userPoolTierInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UserPoolTierInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "verificationMessageTemplateInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolVerificationMessageTemplate\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolVerificationMessageTemplate? VerificationMessageTemplateInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolVerificationMessageTemplate?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "webAuthnConfigurationInput", typeJson: "{\"fqn\":\"aws.cognitoUserPool.CognitoUserPoolWebAuthnConfiguration\"}", isOptional: true)]
        public virtual aws.CognitoUserPool.ICognitoUserPoolWebAuthnConfiguration? WebAuthnConfigurationInput
        {
            get => GetInstanceProperty<aws.CognitoUserPool.ICognitoUserPoolWebAuthnConfiguration?>();
        }

        [JsiiProperty(name: "aliasAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AliasAttributes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "autoVerifiedAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AutoVerifiedAttributes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deletionProtection", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeletionProtection
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailVerificationMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailVerificationMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "emailVerificationSubject", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EmailVerificationSubject
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mfaConfiguration", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MfaConfiguration
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smsAuthenticationMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmsAuthenticationMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "smsVerificationMessage", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SmsVerificationMessage
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Tags
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tagsAll", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> TagsAll
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "usernameAttributes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] UsernameAttributes
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "userPoolTier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UserPoolTier
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
