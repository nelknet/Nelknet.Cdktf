using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsServicecatalogLaunchPaths
{
    [JsiiClass(nativeType: typeof(aws.DataAwsServicecatalogLaunchPaths.DataAwsServicecatalogLaunchPathsSummariesOutputReference), fullyQualifiedName: "aws.dataAwsServicecatalogLaunchPaths.DataAwsServicecatalogLaunchPathsSummariesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsServicecatalogLaunchPathsSummariesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsServicecatalogLaunchPathsSummariesOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsServicecatalogLaunchPathsSummariesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsServicecatalogLaunchPathsSummariesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "constraintSummaries", typeJson: "{\"fqn\":\"aws.dataAwsServicecatalogLaunchPaths.DataAwsServicecatalogLaunchPathsSummariesConstraintSummariesList\"}")]
        public virtual aws.DataAwsServicecatalogLaunchPaths.DataAwsServicecatalogLaunchPathsSummariesConstraintSummariesList ConstraintSummaries
        {
            get => GetInstanceProperty<aws.DataAwsServicecatalogLaunchPaths.DataAwsServicecatalogLaunchPathsSummariesConstraintSummariesList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "pathId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PathId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tags", typeJson: "{\"fqn\":\"cdktf.StringMap\"}")]
        public virtual HashiCorp.Cdktf.StringMap Tags
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.StringMap>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsServicecatalogLaunchPaths.DataAwsServicecatalogLaunchPathsSummaries\"}", isOptional: true)]
        public virtual aws.DataAwsServicecatalogLaunchPaths.IDataAwsServicecatalogLaunchPathsSummaries? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsServicecatalogLaunchPaths.IDataAwsServicecatalogLaunchPathsSummaries?>();
            set => SetInstanceProperty(value);
        }
    }
}
