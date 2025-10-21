using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsEc2ClientVpnEndpoint
{
    [JsiiClass(nativeType: typeof(aws.DataAwsEc2ClientVpnEndpoint.DataAwsEc2ClientVpnEndpointAuthenticationOptionsOutputReference), fullyQualifiedName: "aws.dataAwsEc2ClientVpnEndpoint.DataAwsEc2ClientVpnEndpointAuthenticationOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsEc2ClientVpnEndpointAuthenticationOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsEc2ClientVpnEndpointAuthenticationOptionsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsEc2ClientVpnEndpointAuthenticationOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsEc2ClientVpnEndpointAuthenticationOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "activeDirectoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActiveDirectoryId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "rootCertificateChainArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootCertificateChainArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "samlProviderArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SamlProviderArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "selfServiceSamlProviderArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SelfServiceSamlProviderArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsEc2ClientVpnEndpoint.DataAwsEc2ClientVpnEndpointAuthenticationOptions\"}", isOptional: true)]
        public virtual aws.DataAwsEc2ClientVpnEndpoint.IDataAwsEc2ClientVpnEndpointAuthenticationOptions? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsEc2ClientVpnEndpoint.IDataAwsEc2ClientVpnEndpointAuthenticationOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
