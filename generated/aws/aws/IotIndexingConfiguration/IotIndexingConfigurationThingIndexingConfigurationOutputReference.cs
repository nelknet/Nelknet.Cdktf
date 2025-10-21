using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.IotIndexingConfiguration
{
    [JsiiClass(nativeType: typeof(aws.IotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationOutputReference), fullyQualifiedName: "aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IotIndexingConfigurationThingIndexingConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IotIndexingConfigurationThingIndexingConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IotIndexingConfigurationThingIndexingConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IotIndexingConfigurationThingIndexingConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomField", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationCustomField\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustomField(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationCustomField[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationCustomField).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationCustomField).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putFilter", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationFilter\"}}]")]
        public virtual void PutFilter(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationFilter @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationFilter)}, new object[]{@value});
        }

        [JsiiMethod(name: "putManagedField", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationManagedField\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutManagedField(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationManagedField[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationManagedField).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationManagedField).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomField")]
        public virtual void ResetCustomField()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeviceDefenderIndexingMode")]
        public virtual void ResetDeviceDefenderIndexingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFilter")]
        public virtual void ResetFilter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetManagedField")]
        public virtual void ResetManagedField()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNamedShadowIndexingMode")]
        public virtual void ResetNamedShadowIndexingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThingConnectivityIndexingMode")]
        public virtual void ResetThingConnectivityIndexingMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customField", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationCustomFieldList\"}")]
        public virtual aws.IotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationCustomFieldList CustomField
        {
            get => GetInstanceProperty<aws.IotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationCustomFieldList>()!;
        }

        [JsiiProperty(name: "filter", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationFilterOutputReference\"}")]
        public virtual aws.IotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationFilterOutputReference Filter
        {
            get => GetInstanceProperty<aws.IotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationFilterOutputReference>()!;
        }

        [JsiiProperty(name: "managedField", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationManagedFieldList\"}")]
        public virtual aws.IotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationManagedFieldList ManagedField
        {
            get => GetInstanceProperty<aws.IotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationManagedFieldList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customFieldInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationCustomField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomFieldInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deviceDefenderIndexingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeviceDefenderIndexingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "filterInput", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationFilter\"}", isOptional: true)]
        public virtual aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationFilter? FilterInput
        {
            get => GetInstanceProperty<aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfigurationFilter?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "managedFieldInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfigurationManagedField\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ManagedFieldInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "namedShadowIndexingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NamedShadowIndexingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thingConnectivityIndexingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ThingConnectivityIndexingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "thingIndexingModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ThingIndexingModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "deviceDefenderIndexingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeviceDefenderIndexingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "namedShadowIndexingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NamedShadowIndexingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "thingConnectivityIndexingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ThingConnectivityIndexingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "thingIndexingMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ThingIndexingMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.iotIndexingConfiguration.IotIndexingConfigurationThingIndexingConfiguration\"}", isOptional: true)]
        public virtual aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.IotIndexingConfiguration.IIotIndexingConfigurationThingIndexingConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
