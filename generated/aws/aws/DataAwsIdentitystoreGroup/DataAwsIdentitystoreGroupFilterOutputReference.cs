using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsIdentitystoreGroup
{
    [JsiiClass(nativeType: typeof(aws.DataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupFilterOutputReference), fullyQualifiedName: "aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupFilterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataAwsIdentitystoreGroupFilterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataAwsIdentitystoreGroupFilterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataAwsIdentitystoreGroupFilterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsIdentitystoreGroupFilterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributePathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttributePathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "attributeValueInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AttributeValueInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "attributePath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttributePath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "attributeValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttributeValue
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsIdentitystoreGroup.DataAwsIdentitystoreGroupFilter\"}", isOptional: true)]
        public virtual aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupFilter? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsIdentitystoreGroup.IDataAwsIdentitystoreGroupFilter?>();
            set => SetInstanceProperty(value);
        }
    }
}
