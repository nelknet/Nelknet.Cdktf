using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAppmeshRoute
{
    [JsiiClass(nativeType: typeof(aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchOutputReference), fullyQualifiedName: "aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsAppmeshRouteSpecHttp2RouteMatchOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsAppmeshRouteSpecHttp2RouteMatchOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsAppmeshRouteSpecHttp2RouteMatchOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAppmeshRouteSpecHttp2RouteMatchOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "header", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchHeaderList\"}")]
        public virtual aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchHeaderList Header
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchHeaderList>()!;
        }

        [JsiiProperty(name: "method", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Method
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchPathList\"}")]
        public virtual aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchPathList Path
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchPathList>()!;
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Prefix
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "queryParameter", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameterList\"}")]
        public virtual aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameterList QueryParameter
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatchQueryParameterList>()!;
        }

        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Scheme
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteMatch\"}", isOptional: true)]
        public virtual aws.DataAwsAppmeshRoute.IDataAwsAppmeshRouteSpecHttp2RouteMatch? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.IDataAwsAppmeshRouteSpecHttp2RouteMatch?>();
            set => SetInstanceProperty(value);
        }
    }
}
