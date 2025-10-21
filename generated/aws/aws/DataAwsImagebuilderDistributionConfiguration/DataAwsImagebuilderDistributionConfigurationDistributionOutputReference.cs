using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.DataAwsImagebuilderDistributionConfiguration
{
    [JsiiClass(nativeType: typeof(aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionOutputReference), fullyQualifiedName: "aws.dataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataAwsImagebuilderDistributionConfigurationDistributionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataAwsImagebuilderDistributionConfigurationDistributionOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DataAwsImagebuilderDistributionConfigurationDistributionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsImagebuilderDistributionConfigurationDistributionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "amiDistributionConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionAmiDistributionConfigurationList\"}")]
        public virtual aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionAmiDistributionConfigurationList AmiDistributionConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionAmiDistributionConfigurationList>()!;
        }

        [JsiiProperty(name: "containerDistributionConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionContainerDistributionConfigurationList\"}")]
        public virtual aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionContainerDistributionConfigurationList ContainerDistributionConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionContainerDistributionConfigurationList>()!;
        }

        [JsiiProperty(name: "fastLaunchConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationList\"}")]
        public virtual aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationList FastLaunchConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionFastLaunchConfigurationList>()!;
        }

        [JsiiProperty(name: "launchTemplateConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionLaunchTemplateConfigurationList\"}")]
        public virtual aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionLaunchTemplateConfigurationList LaunchTemplateConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionLaunchTemplateConfigurationList>()!;
        }

        [JsiiProperty(name: "licenseConfigurationArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LicenseConfigurationArns
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "region", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Region
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "s3ExportConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionS3ExportConfigurationList\"}")]
        public virtual aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionS3ExportConfigurationList S3ExportConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionS3ExportConfigurationList>()!;
        }

        [JsiiProperty(name: "ssmParameterConfiguration", typeJson: "{\"fqn\":\"aws.dataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionSsmParameterConfigurationList\"}")]
        public virtual aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionSsmParameterConfigurationList SsmParameterConfiguration
        {
            get => GetInstanceProperty<aws.DataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistributionSsmParameterConfigurationList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.dataAwsImagebuilderDistributionConfiguration.DataAwsImagebuilderDistributionConfigurationDistribution\"}", isOptional: true)]
        public virtual aws.DataAwsImagebuilderDistributionConfiguration.IDataAwsImagebuilderDistributionConfigurationDistribution? InternalValue
        {
            get => GetInstanceProperty<aws.DataAwsImagebuilderDistributionConfiguration.IDataAwsImagebuilderDistributionConfigurationDistribution?>();
            set => SetInstanceProperty(value);
        }
    }
}
