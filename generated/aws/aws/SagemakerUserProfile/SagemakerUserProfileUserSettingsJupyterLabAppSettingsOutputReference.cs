using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.SagemakerUserProfile
{
    [JsiiClass(nativeType: typeof(aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsOutputReference), fullyQualifiedName: "aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SagemakerUserProfileUserSettingsJupyterLabAppSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SagemakerUserProfileUserSettingsJupyterLabAppSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SagemakerUserProfileUserSettingsJupyterLabAppSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerUserProfileUserSettingsJupyterLabAppSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAppLifecycleManagement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagement\"}}]")]
        public virtual void PutAppLifecycleManagement(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCodeRepository", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsCodeRepository\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCodeRepository(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsCodeRepository[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsCodeRepository).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsCodeRepository).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putCustomImage", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsCustomImage\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomImage(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsCustomImage[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsCustomImage).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsCustomImage).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDefaultResourceSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsDefaultResourceSpec\"}}]")]
        public virtual void PutDefaultResourceSpec(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsDefaultResourceSpec @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsDefaultResourceSpec)}, new object[]{@value});
        }

        [JsiiMethod(name: "putEmrSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsEmrSettings\"}}]")]
        public virtual void PutEmrSettings(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsEmrSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsEmrSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAppLifecycleManagement")]
        public virtual void ResetAppLifecycleManagement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBuiltInLifecycleConfigArn")]
        public virtual void ResetBuiltInLifecycleConfigArn()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCodeRepository")]
        public virtual void ResetCodeRepository()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCustomImage")]
        public virtual void ResetCustomImage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultResourceSpec")]
        public virtual void ResetDefaultResourceSpec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEmrSettings")]
        public virtual void ResetEmrSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLifecycleConfigArns")]
        public virtual void ResetLifecycleConfigArns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "appLifecycleManagement", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementOutputReference\"}")]
        public virtual aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementOutputReference AppLifecycleManagement
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagementOutputReference>()!;
        }

        [JsiiProperty(name: "codeRepository", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsCodeRepositoryList\"}")]
        public virtual aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsCodeRepositoryList CodeRepository
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsCodeRepositoryList>()!;
        }

        [JsiiProperty(name: "customImage", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsCustomImageList\"}")]
        public virtual aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsCustomImageList CustomImage
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsCustomImageList>()!;
        }

        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsDefaultResourceSpecOutputReference\"}")]
        public virtual aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsDefaultResourceSpecOutputReference DefaultResourceSpec
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsDefaultResourceSpecOutputReference>()!;
        }

        [JsiiProperty(name: "emrSettings", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsEmrSettingsOutputReference\"}")]
        public virtual aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsEmrSettingsOutputReference EmrSettings
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsEmrSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "appLifecycleManagementInput", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagement\"}", isOptional: true)]
        public virtual aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagement? AppLifecycleManagementInput
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsAppLifecycleManagement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "builtInLifecycleConfigArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BuiltInLifecycleConfigArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeRepositoryInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsCodeRepository\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CodeRepositoryInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "customImageInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsCustomImage\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomImageInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultResourceSpecInput", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsDefaultResourceSpec\"}", isOptional: true)]
        public virtual aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsDefaultResourceSpec? DefaultResourceSpecInput
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsDefaultResourceSpec?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "emrSettingsInput", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettingsEmrSettings\"}", isOptional: true)]
        public virtual aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsEmrSettings? EmrSettingsInput
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettingsEmrSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifecycleConfigArnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LifecycleConfigArnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "builtInLifecycleConfigArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BuiltInLifecycleConfigArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LifecycleConfigArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemakerUserProfile.SagemakerUserProfileUserSettingsJupyterLabAppSettings\"}", isOptional: true)]
        public virtual aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettings? InternalValue
        {
            get => GetInstanceProperty<aws.SagemakerUserProfile.ISagemakerUserProfileUserSettingsJupyterLabAppSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
