using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.AppstreamStack
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appstreamStack.AppstreamStackUserSettings")]
    public class AppstreamStackUserSettings : aws.AppstreamStack.IAppstreamStackUserSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#action AppstreamStack#action}.</summary>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}")]
        public string Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/appstream_stack#permission AppstreamStack#permission}.</summary>
        [JsiiProperty(name: "permission", typeJson: "{\"primitive\":\"string\"}")]
        public string Permission
        {
            get;
            set;
        }
    }
}
