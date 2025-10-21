using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsLbListener
{
    [JsiiClass(nativeType: typeof(aws.DataAwsLbListener.DataAwsLbListenerDefaultActionOutputReference), fullyQualifiedName: "aws.dataAwsLbListener.DataAwsLbListenerDefaultActionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsLbListenerDefaultActionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsLbListenerDefaultActionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsLbListenerDefaultActionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsLbListenerDefaultActionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authenticateCognito", typeJson: "{\"fqn\":\"aws.dataAwsLbListener.DataAwsLbListenerDefaultActionAuthenticateCognitoList\"}")]
        public virtual aws.DataAwsLbListener.DataAwsLbListenerDefaultActionAuthenticateCognitoList AuthenticateCognito
        {
            get => GetInstanceProperty<aws.DataAwsLbListener.DataAwsLbListenerDefaultActionAuthenticateCognitoList>()!;
        }

        [JsiiProperty(name: "authenticateOidc", typeJson: "{\"fqn\":\"aws.dataAwsLbListener.DataAwsLbListenerDefaultActionAuthenticateOidcList\"}")]
        public virtual aws.DataAwsLbListener.DataAwsLbListenerDefaultActionAuthenticateOidcList AuthenticateOidc
        {
            get => GetInstanceProperty<aws.DataAwsLbListener.DataAwsLbListenerDefaultActionAuthenticateOidcList>()!;
        }

        [JsiiProperty(name: "fixedResponse", typeJson: "{\"fqn\":\"aws.dataAwsLbListener.DataAwsLbListenerDefaultActionFixedResponseList\"}")]
        public virtual aws.DataAwsLbListener.DataAwsLbListenerDefaultActionFixedResponseList FixedResponse
        {
            get => GetInstanceProperty<aws.DataAwsLbListener.DataAwsLbListenerDefaultActionFixedResponseList>()!;
        }

        [JsiiProperty(name: "forward", typeJson: "{\"fqn\":\"aws.dataAwsLbListener.DataAwsLbListenerDefaultActionForwardList\"}")]
        public virtual aws.DataAwsLbListener.DataAwsLbListenerDefaultActionForwardList Forward
        {
            get => GetInstanceProperty<aws.DataAwsLbListener.DataAwsLbListenerDefaultActionForwardList>()!;
        }

        [JsiiProperty(name: "order", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double Order
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "redirect", typeJson: "{\"fqn\":\"aws.dataAwsLbListener.DataAwsLbListenerDefaultActionRedirectList\"}")]
        public virtual aws.DataAwsLbListener.DataAwsLbListenerDefaultActionRedirectList Redirect
        {
            get => GetInstanceProperty<aws.DataAwsLbListener.DataAwsLbListenerDefaultActionRedirectList>()!;
        }

        [JsiiProperty(name: "targetGroupArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TargetGroupArn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsLbListener.DataAwsLbListenerDefaultAction\"}", isOptional: true)]
        public virtual aws.DataAwsLbListener.IDataAwsLbListenerDefaultAction? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsLbListener.IDataAwsLbListenerDefaultAction?>();
            set => SetInstanceProperty(value);
        }
    }
}
