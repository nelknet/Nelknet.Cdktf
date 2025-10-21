using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxFunctionApp
{
    [JsiiClass(nativeType: typeof(azurerm.LinuxFunctionApp.LinuxFunctionAppAuthSettingsOutputReference), fullyQualifiedName: "azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxFunctionAppAuthSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxFunctionAppAuthSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxFunctionAppAuthSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxFunctionAppAuthSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActiveDirectory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsActiveDirectory\"}}]")]
        public virtual void PutActiveDirectory(azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsActiveDirectory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsActiveDirectory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFacebook", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsFacebook\"}}]")]
        public virtual void PutFacebook(azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsFacebook @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsFacebook)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithub", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsGithub\"}}]")]
        public virtual void PutGithub(azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsGithub @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsGithub)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGoogle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsGoogle\"}}]")]
        public virtual void PutGoogle(azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsGoogle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsGoogle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMicrosoft", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsMicrosoft\"}}]")]
        public virtual void PutMicrosoft(azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsMicrosoft @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsMicrosoft)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTwitter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsTwitter\"}}]")]
        public virtual void PutTwitter(azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsTwitter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsTwitter)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetActiveDirectory")]
        public virtual void ResetActiveDirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdditionalLoginParameters")]
        public virtual void ResetAdditionalLoginParameters()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAllowedExternalRedirectUrls")]
        public virtual void ResetAllowedExternalRedirectUrls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultProvider")]
        public virtual void ResetDefaultProvider()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFacebook")]
        public virtual void ResetFacebook()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGithub")]
        public virtual void ResetGithub()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGoogle")]
        public virtual void ResetGoogle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIssuer")]
        public virtual void ResetIssuer()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMicrosoft")]
        public virtual void ResetMicrosoft()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRuntimeVersion")]
        public virtual void ResetRuntimeVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTokenRefreshExtensionHours")]
        public virtual void ResetTokenRefreshExtensionHours()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTokenStoreEnabled")]
        public virtual void ResetTokenStoreEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTwitter")]
        public virtual void ResetTwitter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUnauthenticatedClientAction")]
        public virtual void ResetUnauthenticatedClientAction()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsActiveDirectoryOutputReference\"}")]
        public virtual azurerm.LinuxFunctionApp.LinuxFunctionAppAuthSettingsActiveDirectoryOutputReference ActiveDirectory
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionApp.LinuxFunctionAppAuthSettingsActiveDirectoryOutputReference>()!;
        }

        [JsiiProperty(name: "facebook", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsFacebookOutputReference\"}")]
        public virtual azurerm.LinuxFunctionApp.LinuxFunctionAppAuthSettingsFacebookOutputReference Facebook
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionApp.LinuxFunctionAppAuthSettingsFacebookOutputReference>()!;
        }

        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsGithubOutputReference\"}")]
        public virtual azurerm.LinuxFunctionApp.LinuxFunctionAppAuthSettingsGithubOutputReference Github
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionApp.LinuxFunctionAppAuthSettingsGithubOutputReference>()!;
        }

        [JsiiProperty(name: "google", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsGoogleOutputReference\"}")]
        public virtual azurerm.LinuxFunctionApp.LinuxFunctionAppAuthSettingsGoogleOutputReference Google
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionApp.LinuxFunctionAppAuthSettingsGoogleOutputReference>()!;
        }

        [JsiiProperty(name: "microsoft", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsMicrosoftOutputReference\"}")]
        public virtual azurerm.LinuxFunctionApp.LinuxFunctionAppAuthSettingsMicrosoftOutputReference Microsoft
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionApp.LinuxFunctionAppAuthSettingsMicrosoftOutputReference>()!;
        }

        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsTwitterOutputReference\"}")]
        public virtual azurerm.LinuxFunctionApp.LinuxFunctionAppAuthSettingsTwitterOutputReference Twitter
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionApp.LinuxFunctionAppAuthSettingsTwitterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsActiveDirectory\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsActiveDirectory? ActiveDirectoryInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsActiveDirectory?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalLoginParametersInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? AdditionalLoginParametersInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedExternalRedirectUrlsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedExternalRedirectUrlsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultProviderInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DefaultProviderInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "facebookInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsFacebook\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsFacebook? FacebookInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsFacebook?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsGithub\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsGithub? GithubInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsGithub?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "googleInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsGoogle\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsGoogle? GoogleInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsGoogle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "issuerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IssuerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "microsoftInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsMicrosoft\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsMicrosoft? MicrosoftInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsMicrosoft?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuntimeVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenRefreshExtensionHoursInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TokenRefreshExtensionHoursInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tokenStoreEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? TokenStoreEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "twitterInput", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettingsTwitter\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsTwitter? TwitterInput
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettingsTwitter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "unauthenticatedClientActionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UnauthenticatedClientActionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "additionalLoginParameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> AdditionalLoginParameters
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "allowedExternalRedirectUrls", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedExternalRedirectUrls
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultProvider", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DefaultProvider
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runtimeVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tokenRefreshExtensionHours", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TokenRefreshExtensionHours
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tokenStoreEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object TokenStoreEnabled
        {
            get => GetInstanceProperty<object>()!;
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
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "unauthenticatedClientAction", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UnauthenticatedClientAction
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.linuxFunctionApp.LinuxFunctionAppAuthSettings\"}", isOptional: true)]
        public virtual azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.LinuxFunctionApp.ILinuxFunctionAppAuthSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
