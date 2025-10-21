using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EcsService
{
    [JsiiClass(nativeType: typeof(aws.EcsService.EcsServiceServiceConnectConfigurationLogConfigurationOutputReference), fullyQualifiedName: "aws.ecsService.EcsServiceServiceConnectConfigurationLogConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EcsServiceServiceConnectConfigurationLogConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EcsServiceServiceConnectConfigurationLogConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EcsServiceServiceConnectConfigurationLogConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsServiceServiceConnectConfigurationLogConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSecretOption", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationLogConfigurationSecretOption\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutSecretOption(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EcsService.IEcsServiceServiceConnectConfigurationLogConfigurationSecretOption[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceServiceConnectConfigurationLogConfigurationSecretOption).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EcsService.IEcsServiceServiceConnectConfigurationLogConfigurationSecretOption).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetOptions")]
        public virtual void ResetOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecretOption")]
        public virtual void ResetSecretOption()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "secretOption", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationLogConfigurationSecretOptionList\"}")]
        public virtual aws.EcsService.EcsServiceServiceConnectConfigurationLogConfigurationSecretOptionList SecretOption
        {
            get => GetInstanceProperty<aws.EcsService.EcsServiceServiceConnectConfigurationLogConfigurationSecretOptionList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "logDriverInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LogDriverInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "optionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public virtual System.Collections.Generic.IDictionary<string, string>? OptionsInput
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretOptionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationLogConfigurationSecretOption\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? SecretOptionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "logDriver", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LogDriver
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}")]
        public virtual System.Collections.Generic.IDictionary<string, string> Options
        {
            get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecsService.EcsServiceServiceConnectConfigurationLogConfiguration\"}", isOptional: true)]
        public virtual aws.EcsService.IEcsServiceServiceConnectConfigurationLogConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.EcsService.IEcsServiceServiceConnectConfigurationLogConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
