using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaWorkgroup
{
    [JsiiClass(nativeType: typeof(aws.AthenaWorkgroup.AthenaWorkgroupConfigurationEngineVersionOutputReference), fullyQualifiedName: "aws.athenaWorkgroup.AthenaWorkgroupConfigurationEngineVersionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AthenaWorkgroupConfigurationEngineVersionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AthenaWorkgroupConfigurationEngineVersionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AthenaWorkgroupConfigurationEngineVersionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AthenaWorkgroupConfigurationEngineVersionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSelectedEngineVersion")]
        public virtual void ResetSelectedEngineVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "effectiveEngineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EffectiveEngineVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "selectedEngineVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SelectedEngineVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "selectedEngineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SelectedEngineVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.athenaWorkgroup.AthenaWorkgroupConfigurationEngineVersion\"}", isOptional: true)]
        public virtual aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationEngineVersion? InternalValue
        {
            get => GetInstanceProperty<aws.AthenaWorkgroup.IAthenaWorkgroupConfigurationEngineVersion?>();
            set => SetInstanceProperty(value);
        }
    }
}
