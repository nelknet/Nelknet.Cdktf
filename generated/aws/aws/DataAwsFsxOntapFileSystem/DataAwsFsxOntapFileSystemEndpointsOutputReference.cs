using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsFsxOntapFileSystem
{
    [JsiiClass(nativeType: typeof(aws.DataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystemEndpointsOutputReference), fullyQualifiedName: "aws.dataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystemEndpointsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsFsxOntapFileSystemEndpointsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsFsxOntapFileSystemEndpointsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsFsxOntapFileSystemEndpointsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsFsxOntapFileSystemEndpointsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "intercluster", typeJson: "{\"fqn\":\"aws.dataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystemEndpointsInterclusterList\"}")]
        public virtual aws.DataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystemEndpointsInterclusterList Intercluster
        {
            get => GetInstanceProperty<aws.DataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystemEndpointsInterclusterList>()!;
        }

        [JsiiProperty(name: "management", typeJson: "{\"fqn\":\"aws.dataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystemEndpointsManagementList\"}")]
        public virtual aws.DataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystemEndpointsManagementList Management
        {
            get => GetInstanceProperty<aws.DataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystemEndpointsManagementList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsFsxOntapFileSystem.DataAwsFsxOntapFileSystemEndpoints\"}", isOptional: true)]
        public virtual aws.DataAwsFsxOntapFileSystem.IDataAwsFsxOntapFileSystemEndpoints? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsFsxOntapFileSystem.IDataAwsFsxOntapFileSystemEndpoints?>();
            set => SetInstanceProperty(value);
        }
    }
}
