using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAppmeshRoute
{
    [JsiiClass(nativeType: typeof(aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameterOutputReference), fullyQualifiedName: "aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameterMatchList\"}")]
        public virtual aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameterMatchList Match
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameterMatchList>()!;
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameter\"}", isOptional: true)]
        public virtual aws.DataAwsAppmeshRoute.IDataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameter? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.IDataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameter?>();
            set => SetInstanceProperty(value);
        }
    }
}
