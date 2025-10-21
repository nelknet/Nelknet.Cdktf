using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsDxRouterConfiguration
{
    [JsiiClass(nativeType: typeof(aws.DataAwsDxRouterConfiguration.DataAwsDxRouterConfigurationRouterOutputReference), fullyQualifiedName: "aws.dataAwsDxRouterConfiguration.DataAwsDxRouterConfigurationRouterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsDxRouterConfigurationRouterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsDxRouterConfigurationRouterOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsDxRouterConfigurationRouterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsDxRouterConfigurationRouterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "platform", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Platform
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "routerTypeIdentifier", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RouterTypeIdentifier
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "softwareAttribute", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SoftwareAttribute
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "vendor", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Vendor
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "xsltTemplateName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string XsltTemplateName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "xsltTemplateNameForMacSec", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string XsltTemplateNameForMacSec
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsDxRouterConfiguration.DataAwsDxRouterConfigurationRouter\"}", isOptional: true)]
        public virtual aws.DataAwsDxRouterConfiguration.IDataAwsDxRouterConfigurationRouter? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsDxRouterConfiguration.IDataAwsDxRouterConfigurationRouter?>();
            set => SetInstanceProperty(value);
        }
    }
}
