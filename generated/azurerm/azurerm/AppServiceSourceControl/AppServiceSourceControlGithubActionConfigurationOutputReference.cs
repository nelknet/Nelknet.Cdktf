using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AppServiceSourceControl
{
    [JsiiClass(nativeType: typeof(azurerm.AppServiceSourceControl.AppServiceSourceControlGithubActionConfigurationOutputReference), fullyQualifiedName: "azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppServiceSourceControlGithubActionConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppServiceSourceControlGithubActionConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppServiceSourceControlGithubActionConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppServiceSourceControlGithubActionConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCodeConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationCodeConfiguration\"}}]")]
        public virtual void PutCodeConfiguration(azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationCodeConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationCodeConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putContainerConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationContainerConfiguration\"}}]")]
        public virtual void PutContainerConfiguration(azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationContainerConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationContainerConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCodeConfiguration")]
        public virtual void ResetCodeConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetContainerConfiguration")]
        public virtual void ResetContainerConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGenerateWorkflowFile")]
        public virtual void ResetGenerateWorkflowFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "codeConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationCodeConfigurationOutputReference\"}")]
        public virtual azurerm.AppServiceSourceControl.AppServiceSourceControlGithubActionConfigurationCodeConfigurationOutputReference CodeConfiguration
        {
            get => GetInstanceProperty<azurerm.AppServiceSourceControl.AppServiceSourceControlGithubActionConfigurationCodeConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "containerConfiguration", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationContainerConfigurationOutputReference\"}")]
        public virtual azurerm.AppServiceSourceControl.AppServiceSourceControlGithubActionConfigurationContainerConfigurationOutputReference ContainerConfiguration
        {
            get => GetInstanceProperty<azurerm.AppServiceSourceControl.AppServiceSourceControlGithubActionConfigurationContainerConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "linuxAction", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable LinuxAction
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "codeConfigurationInput", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationCodeConfiguration\"}", isOptional: true)]
        public virtual azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationCodeConfiguration? CodeConfigurationInput
        {
            get => GetInstanceProperty<azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationCodeConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerConfigurationInput", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfigurationContainerConfiguration\"}", isOptional: true)]
        public virtual azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationContainerConfiguration? ContainerConfigurationInput
        {
            get => GetInstanceProperty<azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfigurationContainerConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "generateWorkflowFileInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? GenerateWorkflowFileInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "generateWorkflowFile", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object GenerateWorkflowFile
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

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.appServiceSourceControl.AppServiceSourceControlGithubActionConfiguration\"}", isOptional: true)]
        public virtual azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfiguration? InternalValue
        {
            get => GetInstanceProperty<azurerm.AppServiceSourceControl.IAppServiceSourceControlGithubActionConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
