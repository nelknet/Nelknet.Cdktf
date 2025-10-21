using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAppmeshVirtualNode
{
    [JsiiClass(nativeType: typeof(aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsOutputReference), fullyQualifiedName: "aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "certificate", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsCertificateList\"}")]
        public virtual aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsCertificateList Certificate
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsCertificateList>()!;
        }

        [JsiiProperty(name: "enforce", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Enforce
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public virtual double[] Ports
        {
            get => GetInstanceProperty<double[]>()!;
        }

        [JsiiProperty(name: "validation", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationList\"}")]
        public virtual aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationList Validation
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTlsValidationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualNode.DataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTls\"}", isOptional: true)]
        public virtual aws.DataAwsAppmeshVirtualNode.IDataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTls? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualNode.IDataAwsAppmeshVirtualNodeSpecBackendDefaultsClientPolicyTls?>();
            set => SetInstanceProperty(value);
        }
    }
}
