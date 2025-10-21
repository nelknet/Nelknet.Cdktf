using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.KendraDataSource
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.kendraDataSource.KendraDataSourceConfigurationTemplateConfiguration")]
    public class KendraDataSourceConfigurationTemplateConfiguration : aws.KendraDataSource.IKendraDataSourceConfigurationTemplateConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_data_source#template KendraDataSource#template}.</summary>
        [JsiiProperty(name: "template", typeJson: "{\"primitive\":\"string\"}")]
        public string Template
        {
            get;
            set;
        }
    }
}
