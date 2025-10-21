using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Instance
{
    [JsiiClass(nativeType: typeof(aws.Instance.InstanceMaintenanceOptionsOutputReference), fullyQualifiedName: "aws.instance.InstanceMaintenanceOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class InstanceMaintenanceOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public InstanceMaintenanceOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected InstanceMaintenanceOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected InstanceMaintenanceOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAutoRecovery")]
        public virtual void ResetAutoRecovery()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoRecoveryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AutoRecoveryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "autoRecovery", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AutoRecovery
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.instance.InstanceMaintenanceOptions\"}", isOptional: true)]
        public virtual aws.Instance.IInstanceMaintenanceOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Instance.IInstanceMaintenanceOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
