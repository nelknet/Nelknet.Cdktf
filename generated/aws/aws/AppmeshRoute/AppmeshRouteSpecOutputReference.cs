using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshRoute
{
    [JsiiClass(nativeType: typeof(aws.AppmeshRoute.AppmeshRouteSpecOutputReference), fullyQualifiedName: "aws.appmeshRoute.AppmeshRouteSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshRouteSpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshRouteSpecOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrpcRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRoute\"}}]")]
        public virtual void PutGrpcRoute(aws.AppmeshRoute.IAppmeshRouteSpecGrpcRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshRoute.IAppmeshRouteSpecGrpcRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttp2Route", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2Route\"}}]")]
        public virtual void PutHttp2Route(aws.AppmeshRoute.IAppmeshRouteSpecHttp2Route @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshRoute.IAppmeshRouteSpecHttp2Route)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRoute\"}}]")]
        public virtual void PutHttpRoute(aws.AppmeshRoute.IAppmeshRouteSpecHttpRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshRoute.IAppmeshRouteSpecHttpRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTcpRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRoute\"}}]")]
        public virtual void PutTcpRoute(aws.AppmeshRoute.IAppmeshRouteSpecTcpRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshRoute.IAppmeshRouteSpecTcpRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGrpcRoute")]
        public virtual void ResetGrpcRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttp2Route")]
        public virtual void ResetHttp2Route()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpRoute")]
        public virtual void ResetHttpRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPriority")]
        public virtual void ResetPriority()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTcpRoute")]
        public virtual void ResetTcpRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRouteOutputReference\"}")]
        public virtual aws.AppmeshRoute.AppmeshRouteSpecGrpcRouteOutputReference GrpcRoute
        {
            get => GetInstanceProperty<aws.AppmeshRoute.AppmeshRouteSpecGrpcRouteOutputReference>()!;
        }

        [JsiiProperty(name: "http2Route", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2RouteOutputReference\"}")]
        public virtual aws.AppmeshRoute.AppmeshRouteSpecHttp2RouteOutputReference Http2Route
        {
            get => GetInstanceProperty<aws.AppmeshRoute.AppmeshRouteSpecHttp2RouteOutputReference>()!;
        }

        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRouteOutputReference\"}")]
        public virtual aws.AppmeshRoute.AppmeshRouteSpecHttpRouteOutputReference HttpRoute
        {
            get => GetInstanceProperty<aws.AppmeshRoute.AppmeshRouteSpecHttpRouteOutputReference>()!;
        }

        [JsiiProperty(name: "tcpRoute", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRouteOutputReference\"}")]
        public virtual aws.AppmeshRoute.AppmeshRouteSpecTcpRouteOutputReference TcpRoute
        {
            get => GetInstanceProperty<aws.AppmeshRoute.AppmeshRouteSpecTcpRouteOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grpcRouteInput", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecGrpcRoute\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecGrpcRoute? GrpcRouteInput
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecGrpcRoute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "http2RouteInput", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttp2Route\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecHttp2Route? Http2RouteInput
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttp2Route?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRouteInput", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecHttpRoute\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecHttpRoute? HttpRouteInput
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecHttpRoute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "priorityInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PriorityInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tcpRouteInput", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpecTcpRoute\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpecTcpRoute? TcpRouteInput
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpecTcpRoute?>();
        }

        [JsiiProperty(name: "priority", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Priority
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshRoute.AppmeshRouteSpec\"}", isOptional: true)]
        public virtual aws.AppmeshRoute.IAppmeshRouteSpec? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshRoute.IAppmeshRouteSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
