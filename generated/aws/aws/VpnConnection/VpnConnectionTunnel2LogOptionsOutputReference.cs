using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.VpnConnection
{
    [JsiiClass(nativeType: typeof(aws.VpnConnection.VpnConnectionTunnel2LogOptionsOutputReference), fullyQualifiedName: "aws.vpnConnection.VpnConnectionTunnel2LogOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class VpnConnectionTunnel2LogOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public VpnConnectionTunnel2LogOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected VpnConnectionTunnel2LogOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected VpnConnectionTunnel2LogOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCloudwatchLogOptions", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.vpnConnection.VpnConnectionTunnel2LogOptionsCloudwatchLogOptions\"}}]")]
        public virtual void PutCloudwatchLogOptions(aws.VpnConnection.IVpnConnectionTunnel2LogOptionsCloudwatchLogOptions @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.VpnConnection.IVpnConnectionTunnel2LogOptionsCloudwatchLogOptions)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCloudwatchLogOptions")]
        public virtual void ResetCloudwatchLogOptions()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "cloudwatchLogOptions", typeJson: "{\"fqn\":\"aws.vpnConnection.VpnConnectionTunnel2LogOptionsCloudwatchLogOptionsOutputReference\"}")]
        public virtual aws.VpnConnection.VpnConnectionTunnel2LogOptionsCloudwatchLogOptionsOutputReference CloudwatchLogOptions
        {
            get => GetInstanceProperty<aws.VpnConnection.VpnConnectionTunnel2LogOptionsCloudwatchLogOptionsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudwatchLogOptionsInput", typeJson: "{\"fqn\":\"aws.vpnConnection.VpnConnectionTunnel2LogOptionsCloudwatchLogOptions\"}", isOptional: true)]
        public virtual aws.VpnConnection.IVpnConnectionTunnel2LogOptionsCloudwatchLogOptions? CloudwatchLogOptionsInput
        {
            get => GetInstanceProperty<aws.VpnConnection.IVpnConnectionTunnel2LogOptionsCloudwatchLogOptions?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.vpnConnection.VpnConnectionTunnel2LogOptions\"}", isOptional: true)]
        public virtual aws.VpnConnection.IVpnConnectionTunnel2LogOptions? InternalValue
        {
            get => GetInstanceProperty<aws.VpnConnection.IVpnConnectionTunnel2LogOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
