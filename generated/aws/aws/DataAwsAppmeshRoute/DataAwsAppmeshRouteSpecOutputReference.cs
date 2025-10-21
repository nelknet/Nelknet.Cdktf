using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAppmeshRoute
{
    [JsiiClass(nativeType: typeof(aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecOutputReference), fullyQualifiedName: "aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsAppmeshRouteSpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsAppmeshRouteSpecOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsAppmeshRouteSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAppmeshRouteSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecGrpcRouteList\"}")]
        public virtual aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecGrpcRouteList GrpcRoute
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecGrpcRouteList>()!;
        }

        [JsiiProperty(name: "http2Route", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteList\"}")]
        public virtual aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteList Http2Route
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttp2RouteList>()!;
        }

        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteList\"}")]
        public virtual aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteList HttpRoute
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteList>()!;
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "tcpRoute", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecTcpRouteList\"}")]
        public virtual aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecTcpRouteList TcpRoute
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecTcpRouteList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpec\"}", isOptional: true)]
        public virtual aws.DataAwsAppmeshRoute.IDataAwsAppmeshRouteSpec? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.IDataAwsAppmeshRouteSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
