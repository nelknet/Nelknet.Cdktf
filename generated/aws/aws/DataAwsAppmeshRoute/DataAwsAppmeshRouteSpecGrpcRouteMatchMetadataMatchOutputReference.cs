using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAppmeshRoute
{
    [JsiiClass(nativeType: typeof(aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecGrpcRouteMatchMetadataMatchOutputReference), fullyQualifiedName: "aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecGrpcRouteMatchMetadataMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsAppmeshRouteSpecGrpcRouteMatchMetadataMatchOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsAppmeshRouteSpecGrpcRouteMatchMetadataMatchOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsAppmeshRouteSpecGrpcRouteMatchMetadataMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAppmeshRouteSpecGrpcRouteMatchMetadataMatchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "exact", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Exact
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "range", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecGrpcRouteMatchMetadataMatchRangeList\"}")]
        public virtual aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecGrpcRouteMatchMetadataMatchRangeList Range
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecGrpcRouteMatchMetadataMatchRangeList>()!;
        }

        [JsiiProperty(name: "regex", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Regex
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "suffix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Suffix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecGrpcRouteMatchMetadataMatch\"}", isOptional: true)]
        public virtual aws.DataAwsAppmeshRoute.IDataAwsAppmeshRouteSpecGrpcRouteMatchMetadataMatch? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.IDataAwsAppmeshRouteSpecGrpcRouteMatchMetadataMatch?>();
            set => SetInstanceProperty(value);
        }
    }
}
