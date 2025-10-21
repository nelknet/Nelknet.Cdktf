using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.ResiliencehubResiliencyPolicy
{
    [JsiiClass(nativeType: typeof(aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyOutputReference), fullyQualifiedName: "aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class ResiliencehubResiliencyPolicyPolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public ResiliencehubResiliencyPolicyPolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected ResiliencehubResiliencyPolicyPolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ResiliencehubResiliencyPolicyPolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAz", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAz\"}}]")]
        public virtual void PutAz(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyAz @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyAz)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHardware", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardware\"}}]")]
        public virtual void PutHardware(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyHardware @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyHardware)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegion", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegion\"}}]")]
        public virtual void PutRegion(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicyRegion)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSoftwareAttribute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftware\"}}]")]
        public virtual void PutSoftwareAttribute(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicySoftware @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicySoftware)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetRegion")]
        public virtual void ResetRegion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "az", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAzOutputReference\"}")]
        public virtual aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAzOutputReference Az
        {
            get => GetInstanceProperty<aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAzOutputReference>()!;
        }

        [JsiiProperty(name: "hardware", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardwareOutputReference\"}")]
        public virtual aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardwareOutputReference Hardware
        {
            get => GetInstanceProperty<aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardwareOutputReference>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegionOutputReference\"}")]
        public virtual aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegionOutputReference Region
        {
            get => GetInstanceProperty<aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegionOutputReference>()!;
        }

        [JsiiProperty(name: "softwareAttribute", typeJson: "{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftwareOutputReference\"}")]
        public virtual aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftwareOutputReference SoftwareAttribute
        {
            get => GetInstanceProperty<aws.ResiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftwareOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "azInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyAz\"}]}}", isOptional: true)]
        public virtual object? AzInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hardwareInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyHardware\"}]}}", isOptional: true)]
        public virtual object? HardwareInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicyRegion\"}]}}", isOptional: true)]
        public virtual object? RegionInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "softwareAttributeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicySoftware\"}]}}", isOptional: true)]
        public virtual object? SoftwareAttributeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"fqn\":\"aws.resiliencehubResiliencyPolicy.ResiliencehubResiliencyPolicyPolicy\"}]}}", isOptional: true)]
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
                        case aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicy cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(aws.ResiliencehubResiliencyPolicy.IResiliencehubResiliencyPolicyPolicy).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
