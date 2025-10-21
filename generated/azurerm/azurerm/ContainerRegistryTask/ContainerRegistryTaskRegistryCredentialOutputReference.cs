using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.ContainerRegistryTask
{
    [JsiiClass(nativeType: typeof(azurerm.ContainerRegistryTask.ContainerRegistryTaskRegistryCredentialOutputReference), fullyQualifiedName: "azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ContainerRegistryTaskRegistryCredentialOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ContainerRegistryTaskRegistryCredentialOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ContainerRegistryTaskRegistryCredentialOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ContainerRegistryTaskRegistryCredentialOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustom", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialCustom\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutCustom(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case HashiCorp.Cdktf.IResolvable cast_2ed7d7:
                        break;
                    case azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialCustom[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialCustom).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialCustom).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSource", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialSource\"}}]")]
        public virtual void PutSource(azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialSource @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialSource)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustom")]
        public virtual void ResetCustom()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSource")]
        public virtual void ResetSource()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "custom", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialCustomList\"}")]
        public virtual azurerm.ContainerRegistryTask.ContainerRegistryTaskRegistryCredentialCustomList Custom
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.ContainerRegistryTaskRegistryCredentialCustomList>()!;
        }

        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialSourceOutputReference\"}")]
        public virtual azurerm.ContainerRegistryTask.ContainerRegistryTaskRegistryCredentialSourceOutputReference Source
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.ContainerRegistryTaskRegistryCredentialSourceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialCustom\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? CustomInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceInput", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredentialSource\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialSource? SourceInput
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredentialSource?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.containerRegistryTask.ContainerRegistryTaskRegistryCredential\"}", isOptional: true)]
        public virtual azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredential? InternalValue
        {
            get => GetInstanceProperty<azurerm.ContainerRegistryTask.IContainerRegistryTaskRegistryCredential?>();
            set => SetInstanceProperty(value);
        }
    }
}
