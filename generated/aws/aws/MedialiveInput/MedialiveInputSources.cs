using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.MedialiveInput
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.medialiveInput.MedialiveInputSources")]
    public class MedialiveInputSources : aws.MedialiveInput.IMedialiveInputSources
    {
        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#password_param MedialiveInput#password_param}.</summary>
        [JsiiProperty(name: "passwordParam", typeJson: "{\"primitive\":\"string\"}")]
        public string PasswordParam
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#url MedialiveInput#url}.</summary>
        [JsiiProperty(name: "url", typeJson: "{\"primitive\":\"string\"}")]
        public string Url
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_input#username MedialiveInput#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}")]
        public string Username
        {
            get;
            set;
        }
    }
}
