using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    [JsiiClass(nativeType: typeof(azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSettingOutputReference), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SpringCloudServiceConfigServerGitSettingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SpringCloudServiceConfigServerGitSettingOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SpringCloudServiceConfigServerGitSettingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudServiceConfigServerGitSettingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHttpBasicAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingHttpBasicAuth\"}}]")]
        public virtual void PutHttpBasicAuth(azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingHttpBasicAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingHttpBasicAuth)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRepository", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepository\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutRepository(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepository[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepository).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepository).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSshAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingSshAuth\"}}]")]
        public virtual void PutSshAuth(azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingSshAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingSshAuth)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHttpBasicAuth")]
        public virtual void ResetHttpBasicAuth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabel")]
        public virtual void ResetLabel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRepository")]
        public virtual void ResetRepository()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSearchPaths")]
        public virtual void ResetSearchPaths()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSshAuth")]
        public virtual void ResetSshAuth()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "httpBasicAuth", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingHttpBasicAuthOutputReference\"}")]
        public virtual azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSettingHttpBasicAuthOutputReference HttpBasicAuth
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSettingHttpBasicAuthOutputReference>()!;
        }

        [JsiiProperty(name: "repository", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositoryList\"}")]
        public virtual azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSettingRepositoryList Repository
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSettingRepositoryList>()!;
        }

        [JsiiProperty(name: "sshAuth", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingSshAuthOutputReference\"}")]
        public virtual azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSettingSshAuthOutputReference SshAuth
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSettingSshAuthOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpBasicAuthInput", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingHttpBasicAuth\"}", isOptional: true)]
        public virtual azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingHttpBasicAuth? HttpBasicAuthInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingHttpBasicAuth?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LabelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "repositoryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepository\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? RepositoryInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchPathsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SearchPathsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshAuthInput", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingSshAuth\"}", isOptional: true)]
        public virtual azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingSshAuth? SshAuthInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingSshAuth?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "uriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? UriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "label", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Label
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "searchPaths", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SearchPaths
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSetting\"}", isOptional: true)]
        public virtual azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSetting? InternalValue
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSetting?>();
            set => SetInstanceProperty(value);
        }
    }
}
