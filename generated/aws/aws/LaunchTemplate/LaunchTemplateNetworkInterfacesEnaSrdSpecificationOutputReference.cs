using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LaunchTemplate
{
    [JsiiClass(nativeType: typeof(aws.LaunchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecificationOutputReference), fullyQualifiedName: "aws.launchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecificationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LaunchTemplateNetworkInterfacesEnaSrdSpecificationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LaunchTemplateNetworkInterfacesEnaSrdSpecificationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LaunchTemplateNetworkInterfacesEnaSrdSpecificationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LaunchTemplateNetworkInterfacesEnaSrdSpecificationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putEnaSrdUdpSpecification", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.launchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification\"}}]")]
        public virtual void PutEnaSrdUdpSpecification(aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnaSrdEnabled")]
        public virtual void ResetEnaSrdEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnaSrdUdpSpecification")]
        public virtual void ResetEnaSrdUdpSpecification()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "enaSrdUdpSpecification", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecificationOutputReference\"}")]
        public virtual aws.LaunchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecificationOutputReference EnaSrdUdpSpecification
        {
            get => GetInstanceProperty<aws.LaunchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecificationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enaSrdEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnaSrdEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enaSrdUdpSpecificationInput", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification? EnaSrdUdpSpecificationInput
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesEnaSrdSpecificationEnaSrdUdpSpecification?>();
        }

        [JsiiProperty(name: "enaSrdEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnaSrdEnabled
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.launchTemplate.LaunchTemplateNetworkInterfacesEnaSrdSpecification\"}", isOptional: true)]
        public virtual aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesEnaSrdSpecification? InternalValue
        {
            get => GetInstanceProperty<aws.LaunchTemplate.ILaunchTemplateNetworkInterfacesEnaSrdSpecification?>();
            set => SetInstanceProperty(value);
        }
    }
}
