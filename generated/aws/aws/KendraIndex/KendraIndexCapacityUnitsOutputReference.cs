using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraIndex
{
    [JsiiClass(nativeType: typeof(aws.KendraIndex.KendraIndexCapacityUnitsOutputReference), fullyQualifiedName: "aws.kendraIndex.KendraIndexCapacityUnitsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class KendraIndexCapacityUnitsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public KendraIndexCapacityUnitsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected KendraIndexCapacityUnitsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KendraIndexCapacityUnitsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetQueryCapacityUnits")]
        public virtual void ResetQueryCapacityUnits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetStorageCapacityUnits")]
        public virtual void ResetStorageCapacityUnits()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryCapacityUnitsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? QueryCapacityUnitsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "storageCapacityUnitsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? StorageCapacityUnitsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "queryCapacityUnits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double QueryCapacityUnits
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "storageCapacityUnits", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double StorageCapacityUnits
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.kendraIndex.KendraIndexCapacityUnits\"}", isOptional: true)]
        public virtual aws.KendraIndex.IKendraIndexCapacityUnits? InternalValue
        {
            get => GetInstanceProperty<aws.KendraIndex.IKendraIndexCapacityUnits?>();
            set => SetInstanceProperty(value);
        }
    }
}
