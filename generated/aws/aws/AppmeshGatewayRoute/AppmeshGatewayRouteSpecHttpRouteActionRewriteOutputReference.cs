using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppmeshGatewayRoute
{
    [JsiiClass(nativeType: typeof(aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewriteOutputReference), fullyQualifiedName: "aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewriteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AppmeshGatewayRouteSpecHttpRouteActionRewriteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AppmeshGatewayRouteSpecHttpRouteActionRewriteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AppmeshGatewayRouteSpecHttpRouteActionRewriteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecHttpRouteActionRewriteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHostname", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewriteHostname\"}}]")]
        public virtual void PutHostname(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewriteHostname @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewriteHostname)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPath", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePath\"}}]")]
        public virtual void PutPath(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePath @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePath)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPrefix", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePrefix\"}}]")]
        public virtual void PutPrefix(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePrefix @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePrefix)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHostname")]
        public virtual void ResetHostname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPath")]
        public virtual void ResetPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPrefix")]
        public virtual void ResetPrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "hostname", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewriteHostnameOutputReference\"}")]
        public virtual aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewriteHostnameOutputReference Hostname
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewriteHostnameOutputReference>()!;
        }

        [JsiiProperty(name: "path", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePathOutputReference\"}")]
        public virtual aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePathOutputReference Path
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePathOutputReference>()!;
        }

        [JsiiProperty(name: "prefix", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePrefixOutputReference\"}")]
        public virtual aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePrefixOutputReference Prefix
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePrefixOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostnameInput", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewriteHostname\"}", isOptional: true)]
        public virtual aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewriteHostname? HostnameInput
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewriteHostname?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "pathInput", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePath\"}", isOptional: true)]
        public virtual aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePath? PathInput
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePath?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "prefixInput", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewritePrefix\"}", isOptional: true)]
        public virtual aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePrefix? PrefixInput
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewritePrefix?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmeshGatewayRoute.AppmeshGatewayRouteSpecHttpRouteActionRewrite\"}", isOptional: true)]
        public virtual aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewrite? InternalValue
        {
            get => GetInstanceProperty<aws.AppmeshGatewayRoute.IAppmeshGatewayRouteSpecHttpRouteActionRewrite?>();
            set => SetInstanceProperty(value);
        }
    }
}
