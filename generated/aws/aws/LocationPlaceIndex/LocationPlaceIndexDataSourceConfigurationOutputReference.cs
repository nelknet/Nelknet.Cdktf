using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.LocationPlaceIndex
{
    [JsiiClass(nativeType: typeof(aws.LocationPlaceIndex.LocationPlaceIndexDataSourceConfigurationOutputReference), fullyQualifiedName: "aws.locationPlaceIndex.LocationPlaceIndexDataSourceConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class LocationPlaceIndexDataSourceConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public LocationPlaceIndexDataSourceConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected LocationPlaceIndexDataSourceConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LocationPlaceIndexDataSourceConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetIntendedUse")]
        public virtual void ResetIntendedUse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "intendedUseInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IntendedUseInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "intendedUse", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IntendedUse
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.locationPlaceIndex.LocationPlaceIndexDataSourceConfiguration\"}", isOptional: true)]
        public virtual aws.LocationPlaceIndex.ILocationPlaceIndexDataSourceConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.LocationPlaceIndex.ILocationPlaceIndexDataSourceConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
