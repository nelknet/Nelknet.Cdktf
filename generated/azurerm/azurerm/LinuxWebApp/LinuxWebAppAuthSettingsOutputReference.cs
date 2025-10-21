using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.LinuxWebApp
{
    [JsiiClass(nativeType: typeof(azurerm.LinuxWebApp.LinuxWebAppAuthSettingsOutputReference), fullyQualifiedName: "azurerm.linuxWebApp.LinuxWebAppAuthSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LinuxWebAppAuthSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LinuxWebAppAuthSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LinuxWebAppAuthSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LinuxWebAppAuthSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActiveDirectory", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsActiveDirectory\"}}]")]
        public virtual void PutActiveDirectory(azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsActiveDirectory @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsActiveDirectory)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFacebook", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsFacebook\"}}]")]
        public virtual void PutFacebook(azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsFacebook @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsFacebook)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGithub", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsGithub\"}}]")]
        public virtual void PutGithub(azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsGithub @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsGithub)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGoogle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsGoogle\"}}]")]
        public virtual void PutGoogle(azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsGoogle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsGoogle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMicrosoft", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsMicrosoft\"}}]")]
        public virtual void PutMicrosoft(azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsMicrosoft @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsMicrosoft)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTwitter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsTwitter\"}}]")]
        public virtual void PutTwitter(azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsTwitter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsTwitter)}, new object[]{@value});
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

        [JsiiProperty(name: "activeDirectory", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsActiveDirectoryOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppAuthSettingsActiveDirectoryOutputReference ActiveDirectory
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppAuthSettingsActiveDirectoryOutputReference>()!;
        }

        [JsiiProperty(name: "facebook", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsFacebookOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppAuthSettingsFacebookOutputReference Facebook
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppAuthSettingsFacebookOutputReference>()!;
        }

        [JsiiProperty(name: "github", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsGithubOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppAuthSettingsGithubOutputReference Github
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppAuthSettingsGithubOutputReference>()!;
        }

        [JsiiProperty(name: "google", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsGoogleOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppAuthSettingsGoogleOutputReference Google
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppAuthSettingsGoogleOutputReference>()!;
        }

        [JsiiProperty(name: "microsoft", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsMicrosoftOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppAuthSettingsMicrosoftOutputReference Microsoft
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppAuthSettingsMicrosoftOutputReference>()!;
        }

        [JsiiProperty(name: "twitter", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsTwitterOutputReference\"}")]
        public virtual azurerm.LinuxWebApp.LinuxWebAppAuthSettingsTwitterOutputReference Twitter
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.LinuxWebAppAuthSettingsTwitterOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "activeDirectoryInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsActiveDirectory\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsActiveDirectory? ActiveDirectoryInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsActiveDirectory?>();
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
        [JsiiProperty(name: "facebookInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsFacebook\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsFacebook? FacebookInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsFacebook?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "githubInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsGithub\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsGithub? GithubInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsGithub?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "googleInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsGoogle\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsGoogle? GoogleInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsGoogle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "issuerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IssuerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "microsoftInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsMicrosoft\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsMicrosoft? MicrosoftInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsMicrosoft?>();
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
        [JsiiProperty(name: "twitterInput", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettingsTwitter\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsTwitter? TwitterInput
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppAuthSettingsTwitter?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.linuxWebApp.LinuxWebAppAuthSettings\"}", isOptional: true)]
        public virtual azurerm.LinuxWebApp.ILinuxWebAppAuthSettings? InternalValue
        {
            get => GetInstanceProperty<azurerm.LinuxWebApp.ILinuxWebAppAuthSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
