using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.RolesanywhereTrustAnchor
{
    [JsiiClass(nativeType: typeof(aws.RolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceOutputReference), fullyQualifiedName: "aws.rolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class RolesanywhereTrustAnchorSourceOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public RolesanywhereTrustAnchorSourceOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected RolesanywhereTrustAnchorSourceOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected RolesanywhereTrustAnchorSourceOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSourceData", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.rolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceSourceData\"}}]")]
        public virtual void PutSourceData(aws.RolesanywhereTrustAnchor.IRolesanywhereTrustAnchorSourceSourceData @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.RolesanywhereTrustAnchor.IRolesanywhereTrustAnchorSourceSourceData)}, new object[]{@value});
        }

        [JsiiProperty(name: "sourceData", typeJson: "{\"fqn\":\"aws.rolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceSourceDataOutputReference\"}")]
        public virtual aws.RolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceSourceDataOutputReference SourceData
        {
            get => GetInstanceProperty<aws.RolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceSourceDataOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceDataInput", typeJson: "{\"fqn\":\"aws.rolesanywhereTrustAnchor.RolesanywhereTrustAnchorSourceSourceData\"}", isOptional: true)]
        public virtual aws.RolesanywhereTrustAnchor.IRolesanywhereTrustAnchorSourceSourceData? SourceDataInput
        {
            get => GetInstanceProperty<aws.RolesanywhereTrustAnchor.IRolesanywhereTrustAnchorSourceSourceData?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sourceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SourceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "sourceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SourceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.rolesanywhereTrustAnchor.RolesanywhereTrustAnchorSource\"}", isOptional: true)]
        public virtual aws.RolesanywhereTrustAnchor.IRolesanywhereTrustAnchorSource? InternalValue
        {
            get => GetInstanceProperty<aws.RolesanywhereTrustAnchor.IRolesanywhereTrustAnchorSource?>();
            set => SetInstanceProperty(value);
        }
    }
}
