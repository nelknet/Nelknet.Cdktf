using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    [JsiiClass(nativeType: typeof(aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putVirtualService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService\"}}]")]
        public virtual void PutVirtualService(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPort")]
        public virtual void ResetPort()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualServiceOutputReference\"}")]
        public virtual aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualServiceOutputReference VirtualService
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualServiceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "portInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PortInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualServiceInput", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService\"}", isOptional: true)]
        public virtual aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService? VirtualServiceInput
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService?>();
        }

        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Port
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttp2RouteActionTarget\"}", isOptional: true)]
        public virtual aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionTarget? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttp2RouteActionTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
