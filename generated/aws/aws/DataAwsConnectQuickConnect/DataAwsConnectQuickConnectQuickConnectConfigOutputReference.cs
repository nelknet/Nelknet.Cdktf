using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsConnectQuickConnect
{
    [JsiiClass(nativeType: typeof(aws.DataAwsConnectQuickConnect.DataAwsConnectQuickConnectQuickConnectConfigOutputReference), fullyQualifiedName: "aws.dataAwsConnectQuickConnect.DataAwsConnectQuickConnectQuickConnectConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsConnectQuickConnectQuickConnectConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsConnectQuickConnectQuickConnectConfigOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsConnectQuickConnectQuickConnectConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsConnectQuickConnectQuickConnectConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "phoneConfig", typeJson: "{\"fqn\":\"aws.dataAwsConnectQuickConnect.DataAwsConnectQuickConnectQuickConnectConfigPhoneConfigList\"}")]
        public virtual aws.DataAwsConnectQuickConnect.DataAwsConnectQuickConnectQuickConnectConfigPhoneConfigList PhoneConfig
        {
            get => GetInstanceProperty<aws.DataAwsConnectQuickConnect.DataAwsConnectQuickConnectQuickConnectConfigPhoneConfigList>()!;
        }

        [JsiiProperty(name: "queueConfig", typeJson: "{\"fqn\":\"aws.dataAwsConnectQuickConnect.DataAwsConnectQuickConnectQuickConnectConfigQueueConfigList\"}")]
        public virtual aws.DataAwsConnectQuickConnect.DataAwsConnectQuickConnectQuickConnectConfigQueueConfigList QueueConfig
        {
            get => GetInstanceProperty<aws.DataAwsConnectQuickConnect.DataAwsConnectQuickConnectQuickConnectConfigQueueConfigList>()!;
        }

        [JsiiProperty(name: "quickConnectType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string QuickConnectType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "userConfig", typeJson: "{\"fqn\":\"aws.dataAwsConnectQuickConnect.DataAwsConnectQuickConnectQuickConnectConfigUserConfigList\"}")]
        public virtual aws.DataAwsConnectQuickConnect.DataAwsConnectQuickConnectQuickConnectConfigUserConfigList UserConfig
        {
            get => GetInstanceProperty<aws.DataAwsConnectQuickConnect.DataAwsConnectQuickConnectQuickConnectConfigUserConfigList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsConnectQuickConnect.DataAwsConnectQuickConnectQuickConnectConfig\"}", isOptional: true)]
        public virtual aws.DataAwsConnectQuickConnect.IDataAwsConnectQuickConnectQuickConnectConfig? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsConnectQuickConnect.IDataAwsConnectQuickConnectQuickConnectConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
