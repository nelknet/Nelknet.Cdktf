using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.EmrcontainersJobTemplate
{
    [JsiiClass(nativeType: typeof(aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesOutputReference), fullyQualifiedName: "aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putApplicationConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesApplicationConfiguration\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutApplicationConfiguration(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesApplicationConfiguration[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesApplicationConfiguration).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesApplicationConfiguration).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putMonitoringConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfiguration\"}}]")]
        public virtual void PutMonitoringConfiguration(aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetApplicationConfiguration")]
        public virtual void ResetApplicationConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMonitoringConfiguration")]
        public virtual void ResetMonitoringConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "applicationConfiguration", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesApplicationConfigurationList\"}")]
        public virtual aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesApplicationConfigurationList ApplicationConfiguration
        {
            get => GetInstanceProperty<aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesApplicationConfigurationList>()!;
        }

        [JsiiProperty(name: "monitoringConfiguration", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationOutputReference\"}")]
        public virtual aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationOutputReference MonitoringConfiguration
        {
            get => GetInstanceProperty<aws.EmrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "applicationConfigurationInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesApplicationConfiguration\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ApplicationConfigurationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "monitoringConfigurationInput", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfiguration\"}", isOptional: true)]
        public virtual aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfiguration? MonitoringConfigurationInput
        {
            get => GetInstanceProperty<aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverridesMonitoringConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emrcontainersJobTemplate.EmrcontainersJobTemplateJobTemplateDataConfigurationOverrides\"}", isOptional: true)]
        public virtual aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverrides? InternalValue
        {
            get => GetInstanceProperty<aws.EmrcontainersJobTemplate.IEmrcontainersJobTemplateJobTemplateDataConfigurationOverrides?>();
            set => SetInstanceProperty(value);
        }
    }
}
