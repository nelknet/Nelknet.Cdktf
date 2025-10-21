using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsSecurityhubStandardsControlAssociations
{
    [JsiiClass(nativeType: typeof(aws.DataAwsSecurityhubStandardsControlAssociations.DataAwsSecurityhubStandardsControlAssociationsStandardsControlAssociationsOutputReference), fullyQualifiedName: "aws.dataAwsSecurityhubStandardsControlAssociations.DataAwsSecurityhubStandardsControlAssociationsStandardsControlAssociationsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsSecurityhubStandardsControlAssociationsStandardsControlAssociationsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsSecurityhubStandardsControlAssociationsStandardsControlAssociationsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsSecurityhubStandardsControlAssociationsStandardsControlAssociationsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsSecurityhubStandardsControlAssociationsStandardsControlAssociationsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "associationStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssociationStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "relatedRequirements", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RelatedRequirements
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "securityControlArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityControlArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "securityControlId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecurityControlId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "standardsArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StandardsArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "standardsControlDescription", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StandardsControlDescription
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "standardsControlTitle", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StandardsControlTitle
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedAt", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedAt
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "updatedReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string UpdatedReason
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsSecurityhubStandardsControlAssociations.DataAwsSecurityhubStandardsControlAssociationsStandardsControlAssociations\"}", isOptional: true)]
        public virtual aws.DataAwsSecurityhubStandardsControlAssociations.IDataAwsSecurityhubStandardsControlAssociationsStandardsControlAssociations? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsSecurityhubStandardsControlAssociations.IDataAwsSecurityhubStandardsControlAssociationsStandardsControlAssociations?>();
            set => SetInstanceProperty(value);
        }
    }
}
