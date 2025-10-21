using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotIndexingConfiguration
{
    [JsiiClass(nativeType: typeof(aws.IotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationOutputReference), fullyQualifiedName: "aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotIndexingConfigurationThingGroupIndexingConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotIndexingConfigurationThingGroupIndexingConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IotIndexingConfigurationThingGroupIndexingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotIndexingConfigurationThingGroupIndexingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomField", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationCustomField\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomField(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfigurationCustomField[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfigurationCustomField).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfigurationCustomField).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManagedField", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationManagedField\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutManagedField(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfigurationManagedField[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfigurationManagedField).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfigurationManagedField).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomField")]
        public virtual void ResetCustomField()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedField")]
        public virtual void ResetManagedField()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customField", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationCustomFieldList\"}")]
        public virtual aws.IotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationCustomFieldList CustomField
        {
            get => GetInstanceProperty<aws.IotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationCustomFieldList>()!;
        }

        [JsiiProperty(name: "managedField", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationManagedFieldList\"}")]
        public virtual aws.IotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationManagedFieldList ManagedField
        {
            get => GetInstanceProperty<aws.IotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationManagedFieldList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customFieldInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationCustomField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomFieldInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedFieldInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfigurationManagedField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ManagedFieldInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thingGroupIndexingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ThingGroupIndexingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "thingGroupIndexingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ThingGroupIndexingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingGroupIndexingConfiguration\"}", isOptional: true)]
        public virtual aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.IotIndexingConfiguration.IIotIndexingConfigurationThingGroupIndexingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
