using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsAppmeshRoute
{
    [JsiiClass(nativeType: typeof(aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteOutputReference), fullyQualifiedName: "aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsAppmeshRouteSpecHttpRouteOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsAppmeshRouteSpecHttpRouteOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsAppmeshRouteSpecHttpRouteOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsAppmeshRouteSpecHttpRouteOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteActionList\"}")]
        public virtual aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteActionList Action
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteActionList>()!;
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteMatchList\"}")]
        public virtual aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteMatchList Match
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteMatchList>()!;
        }

        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteRetryPolicyList\"}")]
        public virtual aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteRetryPolicyList RetryPolicy
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteRetryPolicyList>()!;
        }

        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteTimeoutList\"}")]
        public virtual aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteTimeoutList Timeout
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRouteTimeoutList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsAppmeshRoute.DataAwsAppmeshRouteSpecHttpRoute\"}", isOptional: true)]
        public virtual aws.DataAwsAppmeshRoute.IDataAwsAppmeshRouteSpecHttpRoute? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsAppmeshRoute.IDataAwsAppmeshRouteSpecHttpRoute?>();
            set => SetInstanceProperty(value);
        }
    }
}
