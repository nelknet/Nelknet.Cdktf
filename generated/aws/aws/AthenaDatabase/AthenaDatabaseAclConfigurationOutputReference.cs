using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AthenaDatabase
{
    [JsiiClass(nativeType: typeof(aws.AthenaDatabase.AthenaDatabaseAclConfigurationOutputReference), fullyQualifiedName: "aws.athenaDatabase.AthenaDatabaseAclConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AthenaDatabaseAclConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AthenaDatabaseAclConfigurationOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AthenaDatabaseAclConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AthenaDatabaseAclConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3AclOptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? S3AclOptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "s3AclOption", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string S3AclOption
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.athenaDatabase.AthenaDatabaseAclConfiguration\"}", isOptional: true)]
        public virtual aws.AthenaDatabase.IAthenaDatabaseAclConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.AthenaDatabase.IAthenaDatabaseAclConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
