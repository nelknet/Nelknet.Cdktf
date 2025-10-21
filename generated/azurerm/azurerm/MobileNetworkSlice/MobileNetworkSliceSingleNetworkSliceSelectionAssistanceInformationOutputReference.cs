using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.MobileNetworkSlice
{
    [JsiiClass(nativeType: typeof(azurerm.MobileNetworkSlice.MobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformationOutputReference), fullyQualifiedName: "azurerm.mobileNetworkSlice.MobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class MobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public MobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected MobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSliceDifferentiator")]
        public virtual void ResetSliceDifferentiator()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "sliceDifferentiatorInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SliceDifferentiatorInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sliceServiceTypeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SliceServiceTypeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "sliceDifferentiator", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SliceDifferentiator
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sliceServiceType", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SliceServiceType
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.mobileNetworkSlice.MobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformation\"}", isOptional: true)]
        public virtual azurerm.MobileNetworkSlice.IMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformation? InternalValue
        {
            get => GetInstanceProperty<azurerm.MobileNetworkSlice.IMobileNetworkSliceSingleNetworkSliceSelectionAssistanceInformation?>();
            set => SetInstanceProperty(value);
        }
    }
}
