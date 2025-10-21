using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.WorkloadsSapThreeTierVirtualInstance
{
    [JsiiClass(nativeType: typeof(azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerOutputReference), fullyQualifiedName: "azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putVirtualMachine", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerVirtualMachine\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutVirtualMachine(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerVirtualMachine[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerVirtualMachine).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerVirtualMachine).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAvailabilitySetName")]
        public virtual void ResetAvailabilitySetName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVirtualMachine")]
        public virtual void ResetVirtualMachine()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "virtualMachine", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerVirtualMachineList\"}")]
        public virtual azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerVirtualMachineList VirtualMachine
        {
            get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerVirtualMachineList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "availabilitySetNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AvailabilitySetNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualMachineInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServerVirtualMachine\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? VirtualMachineInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "availabilitySetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AvailabilitySetName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.workloadsSapThreeTierVirtualInstance.WorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServer\"}", isOptional: true)]
        public virtual azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServer? InternalValue
        {
            get => GetInstanceProperty<azurerm.WorkloadsSapThreeTierVirtualInstance.IWorkloadsSapThreeTierVirtualInstanceThreeTierConfigurationResourceNamesApplicationServer?>();
            set => SetInstanceProperty(value);
        }
    }
}
