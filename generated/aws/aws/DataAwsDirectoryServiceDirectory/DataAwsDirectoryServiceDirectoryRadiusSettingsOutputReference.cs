using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsDirectoryServiceDirectory
{
    [JsiiClass(nativeType: typeof(aws.DataAwsDirectoryServiceDirectory.DataAwsDirectoryServiceDirectoryRadiusSettingsOutputReference), fullyQualifiedName: "aws.dataAwsDirectoryServiceDirectory.DataAwsDirectoryServiceDirectoryRadiusSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsDirectoryServiceDirectoryRadiusSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsDirectoryServiceDirectoryRadiusSettingsOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsDirectoryServiceDirectoryRadiusSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDirectoryServiceDirectoryRadiusSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "authenticationProtocol", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationProtocol
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "displayLabel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DisplayLabel
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "radiusPort", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RadiusPort
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "radiusRetries", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RadiusRetries
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "radiusServers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RadiusServers
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "radiusTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RadiusTimeout
        {
            get => GetInstanceProperty<double>()!;
        }

        [JsiiProperty(name: "useSameUsername", typeJson: "{\"fqn\":\"cdktf.IResolvable\"}")]
        public virtual HashiCorp.Cdktf.IResolvable UseSameUsername
        {
            get => GetInstanceProperty<HashiCorp.Cdktf.IResolvable>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsDirectoryServiceDirectory.DataAwsDirectoryServiceDirectoryRadiusSettings\"}", isOptional: true)]
        public virtual aws.DataAwsDirectoryServiceDirectory.IDataAwsDirectoryServiceDirectoryRadiusSettings? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsDirectoryServiceDirectory.IDataAwsDirectoryServiceDirectoryRadiusSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
