using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAppmeshVirtualService
{
    [JsiiClass(nativeType: typeof(aws.DataAwsAppmeshVirtualService.DataAwsAppmeshVirtualServiceSpecOutputReference), fullyQualifiedName: "aws.dataAwsAppmeshVirtualService.DataAwsAppmeshVirtualServiceSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsAppmeshVirtualServiceSpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsAppmeshVirtualServiceSpecOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsAppmeshVirtualServiceSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAppmeshVirtualServiceSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualService.DataAwsAppmeshVirtualServiceSpecProviderList\"}")]
        public virtual aws.DataAwsAppmeshVirtualService.DataAwsAppmeshVirtualServiceSpecProviderList Provider
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualService.DataAwsAppmeshVirtualServiceSpecProviderList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshVirtualService.DataAwsAppmeshVirtualServiceSpec\"}", isOptional: true)]
        public virtual aws.DataAwsAppmeshVirtualService.IDataAwsAppmeshVirtualServiceSpec? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshVirtualService.IDataAwsAppmeshVirtualServiceSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
