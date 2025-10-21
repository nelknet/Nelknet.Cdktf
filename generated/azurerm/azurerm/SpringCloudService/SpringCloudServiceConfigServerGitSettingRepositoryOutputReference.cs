using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SpringCloudService
{
    [JsiiClass(nativeType: typeof(azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSettingRepositoryOutputReference), fullyQualifiedName: "azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositoryOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SpringCloudServiceConfigServerGitSettingRepositoryOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public SpringCloudServiceConfigServerGitSettingRepositoryOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudServiceConfigServerGitSettingRepositoryOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SpringCloudServiceConfigServerGitSettingRepositoryOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHttpBasicAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth\"}}]")]
        public virtual void PutHttpBasicAuth(azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSshAuth", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositorySshAuth\"}}]")]
        public virtual void PutSshAuth(azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositorySshAuth @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositorySshAuth)}, new object[]{@value});
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

        [JsiiMethod(name: "resetPattern")]
        public virtual void ResetPattern()
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

        [JsiiProperty(name: "httpBasicAuth", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuthOutputReference\"}")]
        public virtual azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuthOutputReference HttpBasicAuth
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuthOutputReference>()!;
        }

        [JsiiProperty(name: "sshAuth", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositorySshAuthOutputReference\"}")]
        public virtual azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSettingRepositorySshAuthOutputReference SshAuth
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.SpringCloudServiceConfigServerGitSettingRepositorySshAuthOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpBasicAuthInput", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth\"}", isOptional: true)]
        public virtual azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth? HttpBasicAuthInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositoryHttpBasicAuth?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LabelInput
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
        [JsiiProperty(name: "patternInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? PatternInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "searchPathsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SearchPathsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sshAuthInput", typeJson: "{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepositorySshAuth\"}", isOptional: true)]
        public virtual azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositorySshAuth? SshAuthInput
        {
            get => GetInstanceProperty<azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepositorySshAuth?>();
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

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "pattern", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Pattern
        {
            get => GetInstanceProperty<string[]>()!;
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"azurerm.springCloudService.SpringCloudServiceConfigServerGitSettingRepository\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepository cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.SpringCloudService.ISpringCloudServiceConfigServerGitSettingRepository).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
