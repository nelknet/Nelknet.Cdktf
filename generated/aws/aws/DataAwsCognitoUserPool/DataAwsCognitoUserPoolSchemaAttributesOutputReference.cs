using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsCognitoUserPool
{
    [JsiiClass(nativeType: typeof(aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolSchemaAttributesOutputReference), fullyQualifiedName: "aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolSchemaAttributesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsCognitoUserPoolSchemaAttributesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsCognitoUserPoolSchemaAttributesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsCognitoUserPoolSchemaAttributesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsCognitoUserPoolSchemaAttributesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "attributeDataType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AttributeDataType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "developerOnlyAttribute", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable DeveloperOnlyAttribute
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "mutable", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Mutable
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "numberAttributeConstraints", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolSchemaAttributesNumberAttributeConstraintsList\"}")]
        public virtual aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolSchemaAttributesNumberAttributeConstraintsList NumberAttributeConstraints
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolSchemaAttributesNumberAttributeConstraintsList>()!;
        }

        [JsiiProperty(name: "required", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable Required
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiProperty(name: "stringAttributeConstraints", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolSchemaAttributesStringAttributeConstraintsList\"}")]
        public virtual aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolSchemaAttributesStringAttributeConstraintsList StringAttributeConstraints
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPool.DataAwsCognitoUserPoolSchemaAttributesStringAttributeConstraintsList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsCognitoUserPool.DataAwsCognitoUserPoolSchemaAttributes\"}", isOptional: true)]
        public virtual aws.DataAwsCognitoUserPool.IDataAwsCognitoUserPoolSchemaAttributes? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsCognitoUserPool.IDataAwsCognitoUserPoolSchemaAttributes?>();
            set => SetInstanceProperty(value);
        }
    }
}
